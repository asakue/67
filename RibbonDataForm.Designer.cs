namespace PoliceDepartmentIS;

partial class RibbonDataForm
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
        pnlNav = new Panel();
        navigator = new BindingNavigator(true);
        btnAdd = new Button();
        btnDelete = new Button();
        btnSave = new Button();
        btnGrid = new Button();
        btnReport = new Button();
        btnPage = new Button();
        btnClose = new Button();
        pnlFields = new TableLayoutPanel();
        pnlNav.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)navigator).BeginInit();
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
        lblTitle.Size = new Size(960, 54);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Ленточная форма";
        lblTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // navigator
        // 
        navigator.Dock = DockStyle.None;
        navigator.Location = new Point(4, 4);
        navigator.Name = "navigator";
        navigator.Size = new Size(340, 25);
        navigator.TabIndex = 0;
        navigator.Text = "navigator";
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(354, 2);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(80, 28);
        btnAdd.TabIndex = 1;
        btnAdd.Text = "Добавить";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;
        // 
        // btnDelete
        // 
        btnDelete.Location = new Point(438, 2);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(80, 28);
        btnDelete.TabIndex = 2;
        btnDelete.Text = "Удалить";
        btnDelete.UseVisualStyleBackColor = true;
        btnDelete.Click += btnDelete_Click;
        // 
        // btnSave
        // 
        btnSave.Location = new Point(522, 2);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(80, 28);
        btnSave.TabIndex = 3;
        btnSave.Text = "Сохранить";
        btnSave.UseVisualStyleBackColor = true;
        btnSave.Click += btnSave_Click;
        // 
        // btnGrid
        // 
        btnGrid.Location = new Point(606, 2);
        btnGrid.Name = "btnGrid";
        btnGrid.Size = new Size(110, 28);
        btnGrid.TabIndex = 4;
        btnGrid.Text = "Табличная форма";
        btnGrid.UseVisualStyleBackColor = true;
        btnGrid.Click += btnGrid_Click;
        // 
        // btnReport
        // 
        btnReport.Location = new Point(720, 2);
        btnReport.Name = "btnReport";
        btnReport.Size = new Size(70, 28);
        btnReport.TabIndex = 5;
        btnReport.Text = "Отчёт";
        btnReport.UseVisualStyleBackColor = true;
        btnReport.Click += btnReport_Click;
        // 
        // btnPage
        // 
        btnPage.Location = new Point(794, 2);
        btnPage.Name = "btnPage";
        btnPage.Size = new Size(80, 28);
        btnPage.TabIndex = 6;
        btnPage.Text = "Страница";
        btnPage.UseVisualStyleBackColor = true;
        btnPage.Click += btnPage_Click;
        // 
        // btnClose
        // 
        btnClose.Location = new Point(878, 2);
        btnClose.Name = "btnClose";
        btnClose.Size = new Size(74, 28);
        btnClose.TabIndex = 7;
        btnClose.Text = "Закрыть";
        btnClose.UseVisualStyleBackColor = true;
        btnClose.Click += btnClose_Click;
        // 
        // pnlNav
        // 
        pnlNav.Controls.Add(navigator);
        pnlNav.Controls.Add(btnAdd);
        pnlNav.Controls.Add(btnDelete);
        pnlNav.Controls.Add(btnSave);
        pnlNav.Controls.Add(btnGrid);
        pnlNav.Controls.Add(btnReport);
        pnlNav.Controls.Add(btnPage);
        pnlNav.Controls.Add(btnClose);
        pnlNav.Dock = DockStyle.Top;
        pnlNav.Location = new Point(0, 54);
        pnlNav.Name = "pnlNav";
        pnlNav.Size = new Size(960, 36);
        pnlNav.TabIndex = 1;
        // 
        // pnlFields
        // 
        pnlFields.AutoScroll = true;
        pnlFields.ColumnCount = 2;
        pnlFields.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
        pnlFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        pnlFields.Dock = DockStyle.Fill;
        pnlFields.Location = new Point(0, 90);
        pnlFields.Name = "pnlFields";
        pnlFields.Padding = new Padding(16);
        pnlFields.RowCount = 1;
        pnlFields.Size = new Size(960, 530);
        pnlFields.TabIndex = 2;
        // 
        // RibbonDataForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(960, 620);
        Controls.Add(pnlFields);
        Controls.Add(pnlNav);
        Controls.Add(lblTitle);
        MinimumSize = new Size(920, 660);
        Name = "RibbonDataForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Ленточная форма";
        Load += RibbonDataForm_Load;
        FormClosing += RibbonDataForm_FormClosing;
        ((System.ComponentModel.ISupportInitialize)navigator).EndInit();
        pnlNav.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Label lblTitle;
    private Panel pnlNav;
    private BindingNavigator navigator;
    private Button btnAdd;
    private Button btnDelete;
    private Button btnSave;
    private Button btnGrid;
    private Button btnReport;
    private Button btnPage;
    private Button btnClose;
    private TableLayoutPanel pnlFields;
}
