using System.Data;
using Microsoft.Data.SqlClient;

namespace PoliceDepartmentIS;

internal partial class RibbonDataForm : Form
{
    private DbObjectDefinition? _definition;
    private readonly BindingSource _bindingSource = new();
    private readonly SqlDataRepository _repository = new();
    private SqlDataAdapter? _adapter;
    private DataTable? _table;

    // Parameterless constructor — for Visual Studio Designer
    public RibbonDataForm()
    {
        InitializeComponent();
    }

    // Runtime constructor — stores parameter only, no logic
    public RibbonDataForm(DbObjectDefinition definition) : this()
    {
        _definition = definition;
    }

    // ── Logic (Load event) ────────────────────────────────────────────────────

    private void RibbonDataForm_Load(object sender, EventArgs e)
    {
        if (_definition is null) return;

        lblTitle.Text = _definition.Title;
        Text = $"Ленточная форма: {_definition.Title}";

        navigator.BindingSource = _bindingSource;

        _adapter = _repository.CreateEditableAdapter(_definition);
        _table   = new DataTable(_definition.Title);
        _adapter.Fill(_table);
        _bindingSource.DataSource = _table;

        var keySet = new HashSet<string>(_definition.KeyColumns, StringComparer.OrdinalIgnoreCase);

        foreach (var columnName in _definition.DisplayColumns)
        {
            pnlFields.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            var lbl = new Label
            {
                Text = columnName,
                AutoSize = true,
                Anchor = AnchorStyles.Left,
                Margin = new Padding(6, 10, 12, 6),
                Font = new Font("Segoe UI", 10F)
            };

            var input = BuildInput(columnName, keySet.Contains(columnName));
            input.Margin = new Padding(4, 6, 4, 6);
            input.Anchor = AnchorStyles.Left | AnchorStyles.Right;

            pnlFields.Controls.Add(lbl);
            pnlFields.Controls.Add(input);
        }
    }

    // ── Event handlers ────────────────────────────────────────────────────────

    private void btnAdd_Click(object sender, EventArgs e)    => _bindingSource.AddNew();
    private void btnDelete_Click(object sender, EventArgs e) => _bindingSource.RemoveCurrent();
    private void btnSave_Click(object sender, EventArgs e)   => Save();

    private void btnGrid_Click(object sender, EventArgs e)
    {
        if (_definition is not null) new GridDataForm(_definition).ShowDialog(this);
    }

    private void btnReport_Click(object sender, EventArgs e)
    {
        if (_definition is not null) new ReportForm(_definition).ShowDialog(this);
    }

    private void btnPage_Click(object sender, EventArgs e)
    {
        if (_definition is not null) new ReportForm(_definition, true).ShowDialog(this);
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        Save();
        Close();
    }

    private void RibbonDataForm_FormClosing(object sender, FormClosingEventArgs e) => Save();

    // ── Helpers ───────────────────────────────────────────────────────────────

    private Control BuildInput(string columnName, bool readOnly)
    {
        if (!readOnly && _definition!.Lookups?.TryGetValue(columnName, out var lookup) == true)
        {
            var combo = new ComboBox
            {
                DropDownStyle = ComboBoxStyle.DropDownList,
                Width = 520,
                DataSource = _repository.LoadLookup(lookup),
                DisplayMember = lookup.ValueColumn,
                ValueMember = lookup.KeyColumn,
                Font = new Font("Segoe UI", 10F)
            };
            combo.DataBindings.Add("SelectedValue", _bindingSource, columnName, true, DataSourceUpdateMode.OnPropertyChanged);
            return combo;
        }

        var txt = new TextBox { Width = 520, ReadOnly = readOnly, Font = new Font("Segoe UI", 10F) };
        if (!readOnly)
            txt.DataBindings.Add("Text", _bindingSource, columnName, true, DataSourceUpdateMode.OnPropertyChanged);
        else
            _bindingSource.CurrentChanged += (_, _) =>
            {
                if (_bindingSource.Current is DataRowView row)
                    txt.Text = row[columnName]?.ToString() ?? string.Empty;
            };
        return txt;
    }

    private void Save()
    {
        if (_adapter is null || _table is null) return;
        Validate();
        _bindingSource.EndEdit();
        _adapter.Update(_table);
    }
}
