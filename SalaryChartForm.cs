using System.Data;

namespace PoliceDepartmentIS;

internal partial class SalaryChartForm : Form
{
    private bool _pageMode;
    private DataTable? _data;

    // Parameterless constructor — for Visual Studio Designer
    public SalaryChartForm()
    {
        InitializeComponent();
    }

    // Runtime constructor — stores parameter only, no logic
    public SalaryChartForm(bool pageMode) : this()
    {
        _pageMode = pageMode;
    }

    // ── Logic (Load event) ────────────────────────────────────────────────────

    private void SalaryChartForm_Load(object sender, EventArgs e)
    {
        if (_pageMode)
            Text = "Страница с гистограммой заработной платы";

        _data = new SqlDataRepository().Load(DatabaseCatalog.Queries.First(q => q.Title == "Отдел кадров"));
        Invalidate();
    }

    // ── Event handlers ────────────────────────────────────────────────────────

    private void btnClose_Click(object sender, EventArgs e) => Close();

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        if (_data is null || _data.Rows.Count == 0) return;

        var area = new Rectangle(70, 120, ClientSize.Width - 130, ClientSize.Height - 210);
        e.Graphics.FillRectangle(
            _pageMode ? Brushes.White : new SolidBrush(Color.FromArgb(247, 250, 252)), area);
        e.Graphics.DrawRectangle(Pens.DimGray, area);

        var maxSalary = _data.Rows.Cast<DataRow>().Max(r => Convert.ToDecimal(r["Итого зарплата"]));
        var barWidth  = Math.Max(28, area.Width / _data.Rows.Count - 12);
        var x         = area.Left + 10;

        using var barBrush  = new SolidBrush(Color.FromArgb(65, 132, 179));
        using var textBrush = new SolidBrush(Color.Black);
        using var smallFont = new Font("Segoe UI", 8);

        foreach (DataRow row in _data.Rows)
        {
            var salary = Convert.ToDecimal(row["Итого зарплата"]);
            var height = (int)((area.Height - 40) * salary / maxSalary);
            var bar    = new Rectangle(x, area.Bottom - height - 25, barWidth, height);

            e.Graphics.FillRectangle(barBrush, bar);
            e.Graphics.DrawRectangle(Pens.Black, bar);
            e.Graphics.DrawString($"{salary:N0}", smallFont, textBrush, x, bar.Top - 18);

            var name      = row["ФИО"].ToString() ?? "";
            var shortName = name.Length > 14 ? name[..14] : name;
            e.Graphics.TranslateTransform(x + 4, area.Bottom - 20);
            e.Graphics.RotateTransform(-35);
            e.Graphics.DrawString(shortName, smallFont, textBrush, 0, 0);
            e.Graphics.ResetTransform();
            x += barWidth + 12;
        }
    }
}
