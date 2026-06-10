namespace PoliceDepartmentIS;

internal partial class MainForm : Form
{
    public MainForm() => InitializeComponent();

    // ── Footer ────────────────────────────────────────────────────────────────
    private void btnAbout_Click(object sender, EventArgs e)     => new AboutForm().ShowDialog(this);
    private void btnHistogram_Click(object sender, EventArgs e) => new SalaryChartForm().ShowDialog(this);
    private void btnExit_Click(object sender, EventArgs e)      => Close();

    // ── Forms tab — Ленточные формы ───────────────────────────────────────────
    private void fr1_Click(object sender, EventArgs e) => new RibbonDataForm(DatabaseCatalog.Tables[0]).ShowDialog(this);
    private void fr2_Click(object sender, EventArgs e) => new RibbonDataForm(DatabaseCatalog.Tables[1]).ShowDialog(this);
    private void fr3_Click(object sender, EventArgs e) => new RibbonDataForm(DatabaseCatalog.Tables[2]).ShowDialog(this);
    private void fr4_Click(object sender, EventArgs e) => new RibbonDataForm(DatabaseCatalog.Tables[3]).ShowDialog(this);
    private void fr5_Click(object sender, EventArgs e) => new RibbonDataForm(DatabaseCatalog.Tables[4]).ShowDialog(this);
    private void fr6_Click(object sender, EventArgs e) => new RibbonDataForm(DatabaseCatalog.Tables[5]).ShowDialog(this);

    // ── Forms tab — Запросы ───────────────────────────────────────────────────
    private void fq1_Click(object sender, EventArgs e) => new GridDataForm(DatabaseCatalog.Queries[0]).ShowDialog(this);
    private void fq2_Click(object sender, EventArgs e) => new GridDataForm(DatabaseCatalog.Queries[1]).ShowDialog(this);

    // ── Forms tab — Фильтры по должностям ────────────────────────────────────
    private void fd1_Click(object sender, EventArgs e) => new GridDataForm(DatabaseCatalog.Filters[0]).ShowDialog(this);
    private void fd2_Click(object sender, EventArgs e) => new GridDataForm(DatabaseCatalog.Filters[1]).ShowDialog(this);
    private void fd3_Click(object sender, EventArgs e) => new GridDataForm(DatabaseCatalog.Filters[2]).ShowDialog(this);
    private void fd4_Click(object sender, EventArgs e) => new GridDataForm(DatabaseCatalog.Filters[3]).ShowDialog(this);
    private void fd5_Click(object sender, EventArgs e) => new GridDataForm(DatabaseCatalog.Filters[4]).ShowDialog(this);

    // ── Forms tab — Фильтры по званиям ───────────────────────────────────────
    private void fz1_Click(object sender, EventArgs e) => new GridDataForm(DatabaseCatalog.Filters[5]).ShowDialog(this);
    private void fz2_Click(object sender, EventArgs e) => new GridDataForm(DatabaseCatalog.Filters[6]).ShowDialog(this);
    private void fz3_Click(object sender, EventArgs e) => new GridDataForm(DatabaseCatalog.Filters[7]).ShowDialog(this);
    private void fz4_Click(object sender, EventArgs e) => new GridDataForm(DatabaseCatalog.Filters[8]).ShowDialog(this);
    private void fz5_Click(object sender, EventArgs e) => new GridDataForm(DatabaseCatalog.Filters[9]).ShowDialog(this);

    // ── Forms tab — Фильтры по видам преступлений ────────────────────────────
    private void fv1_Click(object sender, EventArgs e) => new GridDataForm(DatabaseCatalog.Filters[10]).ShowDialog(this);
    private void fv2_Click(object sender, EventArgs e) => new GridDataForm(DatabaseCatalog.Filters[11]).ShowDialog(this);
    private void fv3_Click(object sender, EventArgs e) => new GridDataForm(DatabaseCatalog.Filters[12]).ShowDialog(this);
    private void fv4_Click(object sender, EventArgs e) => new GridDataForm(DatabaseCatalog.Filters[13]).ShowDialog(this);
    private void fv5_Click(object sender, EventArgs e) => new GridDataForm(DatabaseCatalog.Filters[14]).ShowDialog(this);

    // ── Forms tab — Фильтры по состоянию ─────────────────────────────────────
    private void fs1_Click(object sender, EventArgs e) => new GridDataForm(DatabaseCatalog.Filters[15]).ShowDialog(this);
    private void fs2_Click(object sender, EventArgs e) => new GridDataForm(DatabaseCatalog.Filters[16]).ShowDialog(this);
    private void fs3_Click(object sender, EventArgs e) => new GridDataForm(DatabaseCatalog.Filters[17]).ShowDialog(this);
    private void fs4_Click(object sender, EventArgs e) => new GridDataForm(DatabaseCatalog.Filters[18]).ShowDialog(this);
    private void fs5_Click(object sender, EventArgs e) => new GridDataForm(DatabaseCatalog.Filters[19]).ShowDialog(this);

    // ── Reports tab — Таблицы ─────────────────────────────────────────────────
    private void rt1_Click(object sender, EventArgs e) => new ReportForm(DatabaseCatalog.Tables[0]).ShowDialog(this);
    private void rt2_Click(object sender, EventArgs e) => new ReportForm(DatabaseCatalog.Tables[1]).ShowDialog(this);
    private void rt3_Click(object sender, EventArgs e) => new ReportForm(DatabaseCatalog.Tables[2]).ShowDialog(this);
    private void rt4_Click(object sender, EventArgs e) => new ReportForm(DatabaseCatalog.Tables[3]).ShowDialog(this);
    private void rt5_Click(object sender, EventArgs e) => new ReportForm(DatabaseCatalog.Tables[4]).ShowDialog(this);
    private void rt6_Click(object sender, EventArgs e) => new ReportForm(DatabaseCatalog.Tables[5]).ShowDialog(this);

    // ── Reports tab — Запросы ─────────────────────────────────────────────────
    private void rq1_Click(object sender, EventArgs e) => new ReportForm(DatabaseCatalog.Queries[0]).ShowDialog(this);
    private void rq2_Click(object sender, EventArgs e) => new ReportForm(DatabaseCatalog.Queries[1]).ShowDialog(this);

    // ── Reports tab — Фильтры по должностям ──────────────────────────────────
    private void rd1_Click(object sender, EventArgs e) => new ReportForm(DatabaseCatalog.Filters[0]).ShowDialog(this);
    private void rd2_Click(object sender, EventArgs e) => new ReportForm(DatabaseCatalog.Filters[1]).ShowDialog(this);
    private void rd3_Click(object sender, EventArgs e) => new ReportForm(DatabaseCatalog.Filters[2]).ShowDialog(this);
    private void rd4_Click(object sender, EventArgs e) => new ReportForm(DatabaseCatalog.Filters[3]).ShowDialog(this);
    private void rd5_Click(object sender, EventArgs e) => new ReportForm(DatabaseCatalog.Filters[4]).ShowDialog(this);

    // ── Reports tab — Фильтры по званиям ─────────────────────────────────────
    private void rz1_Click(object sender, EventArgs e) => new ReportForm(DatabaseCatalog.Filters[5]).ShowDialog(this);
    private void rz2_Click(object sender, EventArgs e) => new ReportForm(DatabaseCatalog.Filters[6]).ShowDialog(this);
    private void rz3_Click(object sender, EventArgs e) => new ReportForm(DatabaseCatalog.Filters[7]).ShowDialog(this);
    private void rz4_Click(object sender, EventArgs e) => new ReportForm(DatabaseCatalog.Filters[8]).ShowDialog(this);
    private void rz5_Click(object sender, EventArgs e) => new ReportForm(DatabaseCatalog.Filters[9]).ShowDialog(this);

    // ── Reports tab — Фильтры по видам преступлений ───────────────────────────
    private void rv1_Click(object sender, EventArgs e) => new ReportForm(DatabaseCatalog.Filters[10]).ShowDialog(this);
    private void rv2_Click(object sender, EventArgs e) => new ReportForm(DatabaseCatalog.Filters[11]).ShowDialog(this);
    private void rv3_Click(object sender, EventArgs e) => new ReportForm(DatabaseCatalog.Filters[12]).ShowDialog(this);
    private void rv4_Click(object sender, EventArgs e) => new ReportForm(DatabaseCatalog.Filters[13]).ShowDialog(this);
    private void rv5_Click(object sender, EventArgs e) => new ReportForm(DatabaseCatalog.Filters[14]).ShowDialog(this);

    // ── Reports tab — Фильтры по состоянию ───────────────────────────────────
    private void rs1_Click(object sender, EventArgs e) => new ReportForm(DatabaseCatalog.Filters[15]).ShowDialog(this);
    private void rs2_Click(object sender, EventArgs e) => new ReportForm(DatabaseCatalog.Filters[16]).ShowDialog(this);
    private void rs3_Click(object sender, EventArgs e) => new ReportForm(DatabaseCatalog.Filters[17]).ShowDialog(this);
    private void rs4_Click(object sender, EventArgs e) => new ReportForm(DatabaseCatalog.Filters[18]).ShowDialog(this);
    private void rs5_Click(object sender, EventArgs e) => new ReportForm(DatabaseCatalog.Filters[19]).ShowDialog(this);
}
