using System.Data;

namespace PoliceDepartmentIS;

internal partial class GridDataForm : Form
{
    private DbObjectDefinition? _definition;
    private readonly BindingSource _bindingSource = new();

    public GridDataForm()
    {
        InitializeComponent();
    }

    public GridDataForm(DbObjectDefinition definition) : this()
    {
        _definition = definition;
    }


    private void GridDataForm_Load(object sender, EventArgs e)
    {
        if (_definition is null) return;

        lblTitle.Text = _definition.Title;
        Text = $"Табличная форма: {_definition.Title}";

        if (_definition.Title == "Отдел кадров")
        {
            btnHistogram.Visible = true;
            btnHistogramPage.Visible = true;
        }

        var table = new SqlDataRepository().Load(_definition);
        _bindingSource.DataSource = table;
        dataGrid.DataSource = _bindingSource;
        cmbField.Items.AddRange(table.Columns.Cast<DataColumn>().Select(c => c.ColumnName).ToArray());
        if (cmbField.Items.Count > 0)
            cmbField.SelectedIndex = 0;
    }


    private void btnFirst_Click(object sender, EventArgs e)   => _bindingSource.MoveFirst();
    private void btnPrev_Click(object sender, EventArgs e)    => _bindingSource.MovePrevious();
    private void btnNext_Click(object sender, EventArgs e)    => _bindingSource.MoveNext();
    private void btnLast_Click(object sender, EventArgs e)    => _bindingSource.MoveLast();

    private void btnSearch_Click(object sender, EventArgs e)
    {
        if (cmbField.SelectedItem is null || string.IsNullOrWhiteSpace(txtSearch.Text)) return;
        var field = cmbField.SelectedItem.ToString();
        for (var i = 0; i < _bindingSource.Count; i++)
        {
            var row = (DataRowView)_bindingSource[i]!;
            if (row[field!]?.ToString()?.Contains(txtSearch.Text, StringComparison.CurrentCultureIgnoreCase) == true)
            {
                _bindingSource.Position = i;
                return;
            }
        }
    }

    private void btnSortAsc_Click(object sender, EventArgs e)
    {
        if (cmbField.SelectedItem is not null)
            _bindingSource.Sort = $"[{cmbField.SelectedItem}] ASC";
    }

    private void btnSortDesc_Click(object sender, EventArgs e)
    {
        if (cmbField.SelectedItem is not null)
            _bindingSource.Sort = $"[{cmbField.SelectedItem}] DESC";
    }

    private void btnFilter_Click(object sender, EventArgs e)
    {
        if (cmbField.SelectedItem is null) return;
        var field = cmbField.SelectedItem.ToString()!.Replace("'", "''");
        var value = txtSearch.Text.Replace("'", "''");
        _bindingSource.Filter = $"Convert([{field}], 'System.String') LIKE '%{value}%'";
    }

    private void btnReset_Click(object sender, EventArgs e)
    {
        _bindingSource.RemoveFilter();
        _bindingSource.Sort = string.Empty;
    }

    private void btnReport_Click(object sender, EventArgs e)
    {
        if (_definition is not null) new ReportForm(_definition).ShowDialog(this);
    }

    private void btnPage_Click(object sender, EventArgs e)
    {
        if (_definition is not null) new ReportForm(_definition, true).ShowDialog(this);
    }

    private void btnHistogram_Click(object sender, EventArgs e)     => new SalaryChartForm().ShowDialog(this);
    private void btnHistogramPage_Click(object sender, EventArgs e) => new SalaryChartForm(true).ShowDialog(this);
    private void btnClose_Click(object sender, EventArgs e)         => Close();
}
