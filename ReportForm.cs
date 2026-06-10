using System.Data;
using System.Drawing.Printing;

namespace PoliceDepartmentIS;

internal partial class ReportForm : Form
{
    private DbObjectDefinition? _definition;
    private bool _pageMode;

    // Parameterless constructor — for Visual Studio Designer
    public ReportForm()
    {
        InitializeComponent();
    }

    // Runtime constructor — stores parameters only, no logic
    public ReportForm(DbObjectDefinition definition, bool pageMode = false) : this()
    {
        _definition = definition;
        _pageMode   = pageMode;
    }

    // ── Logic (Load event) ────────────────────────────────────────────────────

    private void ReportForm_Load(object sender, EventArgs e)
    {
        if (_definition is null) return;

        lblTitle.Text = _pageMode
            ? $"Страница «{_definition.Title}»"
            : $"Отчёт «{_definition.Title}»";
        Text = _pageMode
            ? $"Страница: {_definition.Title}"
            : $"Отчёт: {_definition.Title}";

        DataTable table = new SqlDataRepository().Load(_definition);
        dataGrid.DataSource = table;
        dataGrid.EnableHeadersVisualStyles = false;
        dataGrid.ColumnHeadersDefaultCellStyle.BackColor       = Color.FromArgb(26, 72, 112);
        dataGrid.ColumnHeadersDefaultCellStyle.ForeColor       = Color.White;
        dataGrid.DefaultCellStyle.BackColor                    = _pageMode ? Color.White : Color.FromArgb(247, 250, 252);
        dataGrid.AlternatingRowsDefaultCellStyle.BackColor     = Color.FromArgb(232, 240, 248);
        dataGrid.DefaultCellStyle.SelectionBackColor           = Color.FromArgb(255, 239, 184);
        dataGrid.DefaultCellStyle.SelectionForeColor           = Color.Black;
        dataGrid.CellBorderStyle                               = DataGridViewCellBorderStyle.Single;
    }

    // ── Event handlers ────────────────────────────────────────────────────────

    private void btnPrint_Click(object sender, EventArgs e)
    {
        if (_definition is null) return;
        using var document = new PrintDocument();
        document.DocumentName = _definition.Title;
        document.PrintPage += (_, pe) =>
        {
            pe.Graphics?.DrawString(_definition.Title,
                new Font("Segoe UI", 18, FontStyle.Bold), Brushes.Black, 80, 80);
            pe.Graphics?.DrawString(
                "Печатная форма отчёта формируется из тех же данных, что и экранная форма.",
                new Font("Segoe UI", 10), Brushes.Black, 80, 130);
        };
        using var dlg = new PrintPreviewDialog { Document = document, Width = 900, Height = 700 };
        dlg.ShowDialog(this);
    }

    private void btnClose_Click(object sender, EventArgs e) => Close();
}
