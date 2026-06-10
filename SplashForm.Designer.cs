namespace PoliceDepartmentIS;

partial class SplashForm
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
        components = new System.ComponentModel.Container();
        lblTitle = new Label();
        lblSubtitle = new Label();
        timer = new System.Windows.Forms.Timer(components);
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.Dock = DockStyle.Fill;
        lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
        lblTitle.ForeColor = Color.FromArgb(26, 72, 112);
        lblTitle.Location = new Point(0, 0);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(731, 387);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "БД МВД";
        lblTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblSubtitle
        // 
        lblSubtitle.Dock = DockStyle.Bottom;
        lblSubtitle.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblSubtitle.Location = new Point(0, 387);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Size = new Size(731, 93);
        lblSubtitle.TabIndex = 1;
        lblSubtitle.Text = "  Гуржий Даниил Эдуардович | ВИС21 ";
        lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // timer
        // 
        timer.Interval = 1800;
        timer.Tick += Timer_Tick;
        // 
        // SplashForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(731, 480);
        Controls.Add(lblTitle);
        Controls.Add(lblSubtitle);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new Padding(3, 4, 3, 4);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "SplashForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Заставка";
        FormClosing += SplashForm_FormClosing;
        Shown += SplashForm_Shown;
        ResumeLayout(false);
    }

    #endregion

    private Label lblTitle;
    private Label lblSubtitle;
    private System.Windows.Forms.Timer timer;
}
