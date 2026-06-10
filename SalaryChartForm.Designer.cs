namespace PoliceDepartmentIS;

partial class SalaryChartForm
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
        btnClose = new Button();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.BackColor = Color.FromArgb(26, 72, 112);
        lblTitle.Dock = DockStyle.Top;
        lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblTitle.ForeColor = Color.White;
        lblTitle.Location = new Point(0, 0);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(960, 60);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Отдел кадров: гистограмма заработной платы сотрудников";
        lblTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // btnClose
        // 
        btnClose.Dock = DockStyle.Bottom;
        btnClose.Font = new Font("Segoe UI", 10F);
        btnClose.Location = new Point(0, 578);
        btnClose.Name = "btnClose";
        btnClose.Size = new Size(960, 42);
        btnClose.TabIndex = 1;
        btnClose.Text = "Закрыть";
        btnClose.UseVisualStyleBackColor = true;
        btnClose.Click += btnClose_Click;
        // 
        // SalaryChartForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(960, 620);
        Controls.Add(btnClose);
        Controls.Add(lblTitle);
        DoubleBuffered = true;
        MinimumSize = new Size(960, 660);
        Name = "SalaryChartForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Гистограмма заработной платы";
        Load += SalaryChartForm_Load;
        ResumeLayout(false);
    }

    #endregion

    private Label lblTitle;
    private Button btnClose;
}
