namespace PoliceDepartmentIS;

partial class GridDataForm
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
        btnFirst = new Button();
        btnPrev = new Button();
        btnNext = new Button();
        btnLast = new Button();
        lblField = new Label();
        cmbField = new ComboBox();
        txtSearch = new TextBox();
        btnSearch = new Button();
        btnSortAsc = new Button();
        btnSortDesc = new Button();
        btnFilter = new Button();
        btnReset = new Button();
        btnReport = new Button();
        btnPage = new Button();
        btnHistogram = new Button();
        btnHistogramPage = new Button();
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
        lblTitle.Text = "Табличная форма";
        lblTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // btnFirst
        // 
        btnFirst.Location = new Point(4, 8);
        btnFirst.Name = "btnFirst";
        btnFirst.Size = new Size(60, 30);
        btnFirst.TabIndex = 0;
        btnFirst.Text = "◀◀";
        btnFirst.UseVisualStyleBackColor = true;
        btnFirst.Click += btnFirst_Click;
        // 
        // btnPrev
        // 
        btnPrev.Location = new Point(68, 8);
        btnPrev.Name = "btnPrev";
        btnPrev.Size = new Size(60, 30);
        btnPrev.TabIndex = 1;
        btnPrev.Text = "◀";
        btnPrev.UseVisualStyleBackColor = true;
        btnPrev.Click += btnPrev_Click;
        // 
        // btnNext
        // 
        btnNext.Location = new Point(132, 8);
        btnNext.Name = "btnNext";
        btnNext.Size = new Size(60, 30);
        btnNext.TabIndex = 2;
        btnNext.Text = "▶";
        btnNext.UseVisualStyleBackColor = true;
        btnNext.Click += btnNext_Click;
        // 
        // btnLast
        // 
        btnLast.Location = new Point(196, 8);
        btnLast.Name = "btnLast";
        btnLast.Size = new Size(60, 30);
        btnLast.TabIndex = 3;
        btnLast.Text = "▶▶";
        btnLast.UseVisualStyleBackColor = true;
        btnLast.Click += btnLast_Click;
        // 
        // lblField
        // 
        lblField.AutoSize = true;
        lblField.Location = new Point(270, 14);
        lblField.Name = "lblField";
        lblField.Size = new Size(35, 15);
        lblField.TabIndex = 4;
        lblField.Text = "Поле:";
        // 
        // cmbField
        // 
        cmbField.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbField.Location = new Point(308, 11);
        cmbField.Name = "cmbField";
        cmbField.Size = new Size(180, 23);
        cmbField.TabIndex = 5;
        // 
        // txtSearch
        // 
        txtSearch.Location = new Point(494, 11);
        txtSearch.Name = "txtSearch";
        txtSearch.Size = new Size(160, 23);
        txtSearch.TabIndex = 6;
        // 
        // btnSearch
        // 
        btnSearch.Location = new Point(658, 8);
        btnSearch.Name = "btnSearch";
        btnSearch.Size = new Size(70, 30);
        btnSearch.TabIndex = 7;
        btnSearch.Text = "Поиск";
        btnSearch.UseVisualStyleBackColor = true;
        btnSearch.Click += btnSearch_Click;
        // 
        // btnSortAsc
        // 
        btnSortAsc.Location = new Point(732, 8);
        btnSortAsc.Name = "btnSortAsc";
        btnSortAsc.Size = new Size(80, 30);
        btnSortAsc.TabIndex = 8;
        btnSortAsc.Text = "Сорт. ↑";
        btnSortAsc.UseVisualStyleBackColor = true;
        btnSortAsc.Click += btnSortAsc_Click;
        // 
        // btnSortDesc
        // 
        btnSortDesc.Location = new Point(816, 8);
        btnSortDesc.Name = "btnSortDesc";
        btnSortDesc.Size = new Size(80, 30);
        btnSortDesc.TabIndex = 9;
        btnSortDesc.Text = "Сорт. ↓";
        btnSortDesc.UseVisualStyleBackColor = true;
        btnSortDesc.Click += btnSortDesc_Click;
        // 
        // btnFilter
        // 
        btnFilter.Location = new Point(900, 8);
        btnFilter.Name = "btnFilter";
        btnFilter.Size = new Size(70, 30);
        btnFilter.TabIndex = 10;
        btnFilter.Text = "Фильтр";
        btnFilter.UseVisualStyleBackColor = true;
        btnFilter.Click += btnFilter_Click;
        // 
        // btnReset
        // 
        btnReset.Location = new Point(974, 8);
        btnReset.Name = "btnReset";
        btnReset.Size = new Size(60, 30);
        btnReset.TabIndex = 11;
        btnReset.Text = "Сброс";
        btnReset.UseVisualStyleBackColor = true;
        btnReset.Click += btnReset_Click;
        // 
        // btnReport
        // 
        btnReport.Location = new Point(4, 46);
        btnReport.Name = "btnReport";
        btnReport.Size = new Size(80, 30);
        btnReport.TabIndex = 12;
        btnReport.Text = "Отчёт";
        btnReport.UseVisualStyleBackColor = true;
        btnReport.Click += btnReport_Click;
        // 
        // btnPage
        // 
        btnPage.Location = new Point(88, 46);
        btnPage.Name = "btnPage";
        btnPage.Size = new Size(80, 30);
        btnPage.TabIndex = 13;
        btnPage.Text = "Страница";
        btnPage.UseVisualStyleBackColor = true;
        btnPage.Click += btnPage_Click;
        // 
        // btnHistogram
        // 
        btnHistogram.Location = new Point(172, 46);
        btnHistogram.Name = "btnHistogram";
        btnHistogram.Size = new Size(100, 30);
        btnHistogram.TabIndex = 14;
        btnHistogram.Text = "Гистограмма";
        btnHistogram.UseVisualStyleBackColor = true;
        btnHistogram.Visible = false;
        btnHistogram.Click += btnHistogram_Click;
        // 
        // btnHistogramPage
        // 
        btnHistogramPage.Location = new Point(276, 46);
        btnHistogramPage.Name = "btnHistogramPage";
        btnHistogramPage.Size = new Size(160, 30);
        btnHistogramPage.TabIndex = 15;
        btnHistogramPage.Text = "Страница с гистограммой";
        btnHistogramPage.UseVisualStyleBackColor = true;
        btnHistogramPage.Visible = false;
        btnHistogramPage.Click += btnHistogramPage_Click;
        // 
        // btnClose
        // 
        btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnClose.Location = new Point(1010, 46);
        btnClose.Name = "btnClose";
        btnClose.Size = new Size(80, 30);
        btnClose.TabIndex = 16;
        btnClose.Text = "Закрыть";
        btnClose.UseVisualStyleBackColor = true;
        btnClose.Click += btnClose_Click;
        // 
        // pnlToolbar
        // 
        pnlToolbar.Controls.Add(btnFirst);
        pnlToolbar.Controls.Add(btnPrev);
        pnlToolbar.Controls.Add(btnNext);
        pnlToolbar.Controls.Add(btnLast);
        pnlToolbar.Controls.Add(lblField);
        pnlToolbar.Controls.Add(cmbField);
        pnlToolbar.Controls.Add(txtSearch);
        pnlToolbar.Controls.Add(btnSearch);
        pnlToolbar.Controls.Add(btnSortAsc);
        pnlToolbar.Controls.Add(btnSortDesc);
        pnlToolbar.Controls.Add(btnFilter);
        pnlToolbar.Controls.Add(btnReset);
        pnlToolbar.Controls.Add(btnReport);
        pnlToolbar.Controls.Add(btnPage);
        pnlToolbar.Controls.Add(btnHistogram);
        pnlToolbar.Controls.Add(btnHistogramPage);
        pnlToolbar.Controls.Add(btnClose);
        pnlToolbar.Dock = DockStyle.Top;
        pnlToolbar.Location = new Point(0, 54);
        pnlToolbar.Name = "pnlToolbar";
        pnlToolbar.Size = new Size(1100, 84);
        pnlToolbar.TabIndex = 1;
        // 
        // dataGrid
        // 
        dataGrid.AllowUserToAddRows = false;
        dataGrid.AllowUserToDeleteRows = false;
        dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGrid.BackgroundColor = Color.FromArgb(247, 250, 252);
        dataGrid.BorderStyle = BorderStyle.None;
        dataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(26, 72, 112);
        dataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        dataGrid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(26, 72, 112);
        dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGrid.Dock = DockStyle.Fill;
        dataGrid.EnableHeadersVisualStyles = false;
        dataGrid.Location = new Point(0, 138);
        dataGrid.Name = "dataGrid";
        dataGrid.ReadOnly = true;
        dataGrid.RowTemplate.Height = 25;
        dataGrid.Size = new Size(1100, 500);
        dataGrid.TabIndex = 2;
        // 
        // GridDataForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1100, 638);
        Controls.Add(dataGrid);
        Controls.Add(pnlToolbar);
        Controls.Add(lblTitle);
        MinimumSize = new Size(1040, 680);
        Name = "GridDataForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Табличная форма";
        Load += GridDataForm_Load;
        pnlToolbar.ResumeLayout(false);
        pnlToolbar.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Label lblTitle;
    private Panel pnlToolbar;
    private Button btnFirst;
    private Button btnPrev;
    private Button btnNext;
    private Button btnLast;
    private Label lblField;
    private ComboBox cmbField;
    private TextBox txtSearch;
    private Button btnSearch;
    private Button btnSortAsc;
    private Button btnSortDesc;
    private Button btnFilter;
    private Button btnReset;
    private Button btnReport;
    private Button btnPage;
    private Button btnHistogram;
    private Button btnHistogramPage;
    private Button btnClose;
    private DataGridView dataGrid;
}
