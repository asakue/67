namespace PoliceDepartmentIS;

partial class AboutForm
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
        lblBody = new Label();
        btnClose = new Button();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.BackColor = Color.FromArgb(26, 72, 112);
        lblTitle.Dock = DockStyle.Top;
        lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        lblTitle.ForeColor = Color.White;
        lblTitle.Location = new Point(0, 0);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(549, 93);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "О программе";
        lblTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblBody
        // 
        lblBody.Dock = DockStyle.Fill;
        lblBody.Font = new Font("Segoe UI", 11F);
        lblBody.Location = new Point(0, 93);
        lblBody.Name = "lblBody";
        lblBody.Size = new Size(549, 181);
        lblBody.TabIndex = 1;
        lblBody.Text = "Информационная система\r\n«БД МВД»\r\n\r\nMicrosoft SQL Server + Visual C# Windows Forms\r\n\r\n© 2026";
        lblBody.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // btnClose
        // 
        btnClose.Dock = DockStyle.Bottom;
        btnClose.Font = new Font("Segoe UI", 10F);
        btnClose.Location = new Point(0, 274);
        btnClose.Margin = new Padding(3, 4, 3, 4);
        btnClose.Name = "btnClose";
        btnClose.Size = new Size(549, 59);
        btnClose.TabIndex = 2;
        btnClose.Text = "Закрыть";
        btnClose.UseVisualStyleBackColor = true;
        btnClose.Click += btnClose_Click;
        // 
        // AboutForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(549, 333);
        Controls.Add(lblBody);
        Controls.Add(lblTitle);
        Controls.Add(btnClose);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new Padding(3, 4, 3, 4);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "AboutForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "О программе";
        ResumeLayout(false);
    }

    #endregion

    private Label lblTitle;
    private Label lblBody;
    private Button btnClose;
}
