namespace PoliceDepartmentIS;

partial class ReportForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        lblTitle = new Label();
        pnlToolbar = new Panel();
        btnPrint = new Button();
        btnClose = new Button();
        dataGrid = new DataGridView();
        pnlToolbar.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.BackColor = Color.FromArgb(26, 72, 112);
        lblTitle.Dock = DockStyle.Top;
        lblTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        lblTitle.ForeColor = Color.White;
        lblTitle.Location = new Point(0, 0);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(1100, 54);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Отчёт";
        lblTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // btnPrint
        // 
        btnPrint.Location = new Point(8, 10);
        btnPrint.Name = "btnPrint";
        btnPrint.Size = new Size(100, 32);
        btnPrint.TabIndex = 0;
        btnPrint.Text = "Печать";
        btnPrint.UseVisualStyleBackColor = true;
        btnPrint.Click += btnPrint_Click;
        // 
        // btnClose
        // 
        btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnClose.Location = new Point(990, 10);
        btnClose.Name = "btnClose";
        btnClose.Size = new Size(100, 32);
        btnClose.TabIndex = 1;
        btnClose.Text = "Закрыть";
        btnClose.UseVisualStyleBackColor = true;
        btnClose.Click += btnClose_Click;
        // 
        // pnlToolbar
        // 
        pnlToolbar.Controls.Add(btnPrint);
        pnlToolbar.Controls.Add(btnClose);
        pnlToolbar.Dock = DockStyle.Bottom;
        pnlToolbar.Location = new Point(0, 596);
        pnlToolbar.Name = "pnlToolbar";
        pnlToolbar.Size = new Size(1100, 52);
        pnlToolbar.TabIndex = 1;
        // 
        // dataGrid
        // 
        dataGrid.AllowUserToAddRows = false;
        dataGrid.AllowUserToDeleteRows = false;
        dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGrid.BackgroundColor = Color.FromArgb(247, 250, 252);
        dataGrid.BorderStyle = BorderStyle.None;
        dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGrid.Dock = DockStyle.Fill;
        dataGrid.Location = new Point(0, 54);
        dataGrid.Name = "dataGrid";
        dataGrid.ReadOnly = true;
        dataGrid.RowTemplate.Height = 25;
        dataGrid.Size = new Size(1100, 542);
        dataGrid.TabIndex = 2;
        // 
        // ReportForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1100, 648);
        Controls.Add(dataGrid);
        Controls.Add(pnlToolbar);
        Controls.Add(lblTitle);
        MinimumSize = new Size(1040, 680);
        Name = "ReportForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Отчёт";
        Load += ReportForm_Load;
        pnlToolbar.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Label lblTitle;
    private Panel pnlToolbar;
    private Button btnPrint;
    private Button btnClose;
    private DataGridView dataGrid;
}
