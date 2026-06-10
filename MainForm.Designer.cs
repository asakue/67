namespace PoliceDepartmentIS;

partial class MainForm
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
        lblHeader = new Label();
        tabControl = new TabControl();
        tabForms = new TabPage();
        pnlForms = new Panel();
        grpFR = new GroupBox();
        fr1 = new Button();
        fr2 = new Button();
        fr3 = new Button();
        fr4 = new Button();
        fr5 = new Button();
        fr6 = new Button();
        grpFQ = new GroupBox();
        fq1 = new Button();
        fq2 = new Button();
        grpFD = new GroupBox();
        fd1 = new Button();
        fd2 = new Button();
        fd3 = new Button();
        fd4 = new Button();
        fd5 = new Button();
        grpFZ = new GroupBox();
        fz1 = new Button();
        fz2 = new Button();
        fz3 = new Button();
        fz4 = new Button();
        fz5 = new Button();
        grpFV = new GroupBox();
        fv1 = new Button();
        fv2 = new Button();
        fv3 = new Button();
        fv4 = new Button();
        fv5 = new Button();
        grpFS = new GroupBox();
        fs1 = new Button();
        fs2 = new Button();
        fs3 = new Button();
        fs4 = new Button();
        fs5 = new Button();
        tabReports = new TabPage();
        pnlReports = new Panel();
        grpRT = new GroupBox();
        rt1 = new Button();
        rt2 = new Button();
        rt3 = new Button();
        rt4 = new Button();
        rt5 = new Button();
        rt6 = new Button();
        grpRQ = new GroupBox();
        rq1 = new Button();
        rq2 = new Button();
        grpRD = new GroupBox();
        rd1 = new Button();
        rd2 = new Button();
        rd3 = new Button();
        rd4 = new Button();
        rd5 = new Button();
        grpRZ = new GroupBox();
        rz1 = new Button();
        rz2 = new Button();
        rz3 = new Button();
        rz4 = new Button();
        rz5 = new Button();
        grpRV = new GroupBox();
        rv1 = new Button();
        rv2 = new Button();
        rv3 = new Button();
        rv4 = new Button();
        rv5 = new Button();
        grpRS = new GroupBox();
        rs1 = new Button();
        rs2 = new Button();
        rs3 = new Button();
        rs4 = new Button();
        rs5 = new Button();
        pnlFooter = new Panel();
        btnHistogram = new Button();
        btnAbout = new Button();
        btnExit = new Button();
        tabControl.SuspendLayout();
        tabForms.SuspendLayout();
        pnlForms.SuspendLayout();
        grpFR.SuspendLayout();
        grpFQ.SuspendLayout();
        grpFD.SuspendLayout();
        grpFZ.SuspendLayout();
        grpFV.SuspendLayout();
        grpFS.SuspendLayout();
        tabReports.SuspendLayout();
        pnlReports.SuspendLayout();
        grpRT.SuspendLayout();
        grpRQ.SuspendLayout();
        grpRD.SuspendLayout();
        grpRZ.SuspendLayout();
        grpRV.SuspendLayout();
        grpRS.SuspendLayout();
        pnlFooter.SuspendLayout();
        SuspendLayout();
        // 
        // lblHeader
        // 
        lblHeader.BackColor = Color.FromArgb(26, 72, 112);
        lblHeader.Dock = DockStyle.Top;
        lblHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        lblHeader.ForeColor = Color.White;
        lblHeader.Location = new Point(0, 0);
        lblHeader.Name = "lblHeader";
        lblHeader.Size = new Size(1348, 83);
        lblHeader.TabIndex = 0;
        lblHeader.Text = "БД МВД";
        lblHeader.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // tabControl
        // 
        tabControl.Controls.Add(tabForms);
        tabControl.Controls.Add(tabReports);
        tabControl.Dock = DockStyle.Fill;
        tabControl.Location = new Point(0, 83);
        tabControl.Margin = new Padding(3, 4, 3, 4);
        tabControl.Name = "tabControl";
        tabControl.SelectedIndex = 0;
        tabControl.Size = new Size(1348, 705);
        tabControl.TabIndex = 1;
        // 
        // tabForms
        // 
        tabForms.Controls.Add(pnlForms);
        tabForms.Location = new Point(4, 29);
        tabForms.Margin = new Padding(3, 4, 3, 4);
        tabForms.Name = "tabForms";
        tabForms.Padding = new Padding(3, 4, 3, 4);
        tabForms.Size = new Size(1340, 672);
        tabForms.TabIndex = 0;
        tabForms.Text = "Формы";
        tabForms.UseVisualStyleBackColor = true;
        // 
        // pnlForms
        // 
        pnlForms.Controls.Add(grpFR);
        pnlForms.Controls.Add(grpFQ);
        pnlForms.Controls.Add(grpFD);
        pnlForms.Controls.Add(grpFZ);
        pnlForms.Controls.Add(grpFV);
        pnlForms.Controls.Add(grpFS);
        pnlForms.Dock = DockStyle.Fill;
        pnlForms.Location = new Point(3, 4);
        pnlForms.Margin = new Padding(3, 4, 3, 4);
        pnlForms.Name = "pnlForms";
        pnlForms.Padding = new Padding(9, 8, 9, 8);
        pnlForms.Size = new Size(1334, 664);
        pnlForms.TabIndex = 0;
        // 
        // grpFR
        // 
        grpFR.Controls.Add(fr1);
        grpFR.Controls.Add(fr2);
        grpFR.Controls.Add(fr3);
        grpFR.Controls.Add(fr4);
        grpFR.Controls.Add(fr5);
        grpFR.Controls.Add(fr6);
        grpFR.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        grpFR.Location = new Point(9, 0);
        grpFR.Margin = new Padding(3, 4, 3, 4);
        grpFR.Name = "grpFR";
        grpFR.Padding = new Padding(3, 4, 3, 4);
        grpFR.Size = new Size(1312, 121);
        grpFR.TabIndex = 0;
        grpFR.TabStop = false;
        grpFR.Text = "Ленточные формы";
        // 
        // fr1
        // 
        fr1.Location = new Point(9, 29);
        fr1.Margin = new Padding(3, 4, 3, 4);
        fr1.Name = "fr1";
        fr1.Size = new Size(423, 37);
        fr1.TabIndex = 0;
        fr1.Text = "Сотрудники";
        fr1.UseVisualStyleBackColor = true;
        fr1.Click += fr1_Click;
        // 
        // fr2
        // 
        fr2.Location = new Point(441, 29);
        fr2.Margin = new Padding(3, 4, 3, 4);
        fr2.Name = "fr2";
        fr2.Size = new Size(423, 37);
        fr2.TabIndex = 1;
        fr2.Text = "Должности";
        fr2.UseVisualStyleBackColor = true;
        fr2.Click += fr2_Click;
        // 
        // fr3
        // 
        fr3.Location = new Point(873, 29);
        fr3.Margin = new Padding(3, 4, 3, 4);
        fr3.Name = "fr3";
        fr3.Size = new Size(423, 37);
        fr3.TabIndex = 2;
        fr3.Text = "Звания";
        fr3.UseVisualStyleBackColor = true;
        fr3.Click += fr3_Click;
        // 
        // fr4
        // 
        fr4.Location = new Point(9, 73);
        fr4.Margin = new Padding(3, 4, 3, 4);
        fr4.Name = "fr4";
        fr4.Size = new Size(423, 37);
        fr4.TabIndex = 3;
        fr4.Text = "Виды преступлений";
        fr4.UseVisualStyleBackColor = true;
        fr4.Click += fr4_Click;
        // 
        // fr5
        // 
        fr5.Location = new Point(441, 73);
        fr5.Margin = new Padding(3, 4, 3, 4);
        fr5.Name = "fr5";
        fr5.Size = new Size(423, 37);
        fr5.TabIndex = 4;
        fr5.Text = "Преступники";
        fr5.UseVisualStyleBackColor = true;
        fr5.Click += fr5_Click;
        // 
        // fr6
        // 
        fr6.Location = new Point(873, 73);
        fr6.Margin = new Padding(3, 4, 3, 4);
        fr6.Name = "fr6";
        fr6.Size = new Size(423, 37);
        fr6.TabIndex = 5;
        fr6.Text = "Пострадавшие";
        fr6.UseVisualStyleBackColor = true;
        fr6.Click += fr6_Click;
        // 
        // grpFQ
        // 
        grpFQ.Controls.Add(fq1);
        grpFQ.Controls.Add(fq2);
        grpFQ.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        grpFQ.Location = new Point(9, 129);
        grpFQ.Margin = new Padding(3, 4, 3, 4);
        grpFQ.Name = "grpFQ";
        grpFQ.Padding = new Padding(3, 4, 3, 4);
        grpFQ.Size = new Size(1312, 77);
        grpFQ.TabIndex = 1;
        grpFQ.TabStop = false;
        grpFQ.Text = "Табличные формы — Запросы";
        // 
        // fq1
        // 
        fq1.Location = new Point(9, 29);
        fq1.Margin = new Padding(3, 4, 3, 4);
        fq1.Name = "fq1";
        fq1.Size = new Size(649, 37);
        fq1.TabIndex = 0;
        fq1.Text = "Отдел кадров";
        fq1.UseVisualStyleBackColor = true;
        fq1.Click += fq1_Click;
        // 
        // fq2
        // 
        fq2.Location = new Point(670, 29);
        fq2.Margin = new Padding(3, 4, 3, 4);
        fq2.Name = "fq2";
        fq2.Size = new Size(649, 37);
        fq2.TabIndex = 1;
        fq2.Text = "Преступники";
        fq2.UseVisualStyleBackColor = true;
        fq2.Click += fq2_Click;
        // 
        // grpFD
        // 
        grpFD.Controls.Add(fd1);
        grpFD.Controls.Add(fd2);
        grpFD.Controls.Add(fd3);
        grpFD.Controls.Add(fd4);
        grpFD.Controls.Add(fd5);
        grpFD.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        grpFD.Location = new Point(9, 215);
        grpFD.Margin = new Padding(3, 4, 3, 4);
        grpFD.Name = "grpFD";
        grpFD.Padding = new Padding(3, 4, 3, 4);
        grpFD.Size = new Size(1312, 77);
        grpFD.TabIndex = 2;
        grpFD.TabStop = false;
        grpFD.Text = "Табличные формы — Фильтры по должностям";
        // 
        // fd1
        // 
        fd1.Location = new Point(9, 29);
        fd1.Margin = new Padding(3, 4, 3, 4);
        fd1.Name = "fd1";
        fd1.Size = new Size(251, 37);
        fd1.TabIndex = 0;
        fd1.Text = "Начальник отдела";
        fd1.UseVisualStyleBackColor = true;
        fd1.Click += fd1_Click;
        // 
        // fd2
        // 
        fd2.Location = new Point(266, 29);
        fd2.Margin = new Padding(3, 4, 3, 4);
        fd2.Name = "fd2";
        fd2.Size = new Size(251, 37);
        fd2.TabIndex = 1;
        fd2.Text = "Ст. следователь";
        fd2.UseVisualStyleBackColor = true;
        fd2.Click += fd2_Click;
        // 
        // fd3
        // 
        fd3.Location = new Point(523, 29);
        fd3.Margin = new Padding(3, 4, 3, 4);
        fd3.Name = "fd3";
        fd3.Size = new Size(251, 37);
        fd3.TabIndex = 2;
        fd3.Text = "Следователь";
        fd3.UseVisualStyleBackColor = true;
        fd3.Click += fd3_Click;
        // 
        // fd4
        // 
        fd4.Location = new Point(781, 29);
        fd4.Margin = new Padding(3, 4, 3, 4);
        fd4.Name = "fd4";
        fd4.Size = new Size(251, 37);
        fd4.TabIndex = 3;
        fd4.Text = "Оперуполномоченный";
        fd4.UseVisualStyleBackColor = true;
        fd4.Click += fd4_Click;
        // 
        // fd5
        // 
        fd5.Location = new Point(1038, 29);
        fd5.Margin = new Padding(3, 4, 3, 4);
        fd5.Name = "fd5";
        fd5.Size = new Size(251, 37);
        fd5.TabIndex = 4;
        fd5.Text = "Инспектор архива";
        fd5.UseVisualStyleBackColor = true;
        fd5.Click += fd5_Click;
        // 
        // grpFZ
        // 
        grpFZ.Controls.Add(fz1);
        grpFZ.Controls.Add(fz2);
        grpFZ.Controls.Add(fz3);
        grpFZ.Controls.Add(fz4);
        grpFZ.Controls.Add(fz5);
        grpFZ.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        grpFZ.Location = new Point(9, 300);
        grpFZ.Margin = new Padding(3, 4, 3, 4);
        grpFZ.Name = "grpFZ";
        grpFZ.Padding = new Padding(3, 4, 3, 4);
        grpFZ.Size = new Size(1312, 77);
        grpFZ.TabIndex = 3;
        grpFZ.TabStop = false;
        grpFZ.Text = "Табличные формы — Фильтры по званиям";
        // 
        // fz1
        // 
        fz1.Location = new Point(9, 29);
        fz1.Margin = new Padding(3, 4, 3, 4);
        fz1.Name = "fz1";
        fz1.Size = new Size(251, 37);
        fz1.TabIndex = 0;
        fz1.Text = "Лейтенант";
        fz1.UseVisualStyleBackColor = true;
        fz1.Click += fz1_Click;
        // 
        // fz2
        // 
        fz2.Location = new Point(266, 29);
        fz2.Margin = new Padding(3, 4, 3, 4);
        fz2.Name = "fz2";
        fz2.Size = new Size(251, 37);
        fz2.TabIndex = 1;
        fz2.Text = "Ст. лейтенант";
        fz2.UseVisualStyleBackColor = true;
        fz2.Click += fz2_Click;
        // 
        // fz3
        // 
        fz3.Location = new Point(523, 29);
        fz3.Margin = new Padding(3, 4, 3, 4);
        fz3.Name = "fz3";
        fz3.Size = new Size(251, 37);
        fz3.TabIndex = 2;
        fz3.Text = "Капитан";
        fz3.UseVisualStyleBackColor = true;
        fz3.Click += fz3_Click;
        // 
        // fz4
        // 
        fz4.Location = new Point(781, 29);
        fz4.Margin = new Padding(3, 4, 3, 4);
        fz4.Name = "fz4";
        fz4.Size = new Size(251, 37);
        fz4.TabIndex = 3;
        fz4.Text = "Майор";
        fz4.UseVisualStyleBackColor = true;
        fz4.Click += fz4_Click;
        // 
        // fz5
        // 
        fz5.Location = new Point(1038, 29);
        fz5.Margin = new Padding(3, 4, 3, 4);
        fz5.Name = "fz5";
        fz5.Size = new Size(251, 37);
        fz5.TabIndex = 4;
        fz5.Text = "Подполковник";
        fz5.UseVisualStyleBackColor = true;
        fz5.Click += fz5_Click;
        // 
        // grpFV
        // 
        grpFV.Controls.Add(fv1);
        grpFV.Controls.Add(fv2);
        grpFV.Controls.Add(fv3);
        grpFV.Controls.Add(fv4);
        grpFV.Controls.Add(fv5);
        grpFV.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        grpFV.Location = new Point(9, 385);
        grpFV.Margin = new Padding(3, 4, 3, 4);
        grpFV.Name = "grpFV";
        grpFV.Padding = new Padding(3, 4, 3, 4);
        grpFV.Size = new Size(1312, 77);
        grpFV.TabIndex = 4;
        grpFV.TabStop = false;
        grpFV.Text = "Табличные формы — Фильтры по видам преступлений";
        // 
        // fv1
        // 
        fv1.Location = new Point(9, 29);
        fv1.Margin = new Padding(3, 4, 3, 4);
        fv1.Name = "fv1";
        fv1.Size = new Size(251, 37);
        fv1.TabIndex = 0;
        fv1.Text = "Кража";
        fv1.UseVisualStyleBackColor = true;
        fv1.Click += fv1_Click;
        // 
        // fv2
        // 
        fv2.Location = new Point(266, 29);
        fv2.Margin = new Padding(3, 4, 3, 4);
        fv2.Name = "fv2";
        fv2.Size = new Size(251, 37);
        fv2.TabIndex = 1;
        fv2.Text = "Мошенничество";
        fv2.UseVisualStyleBackColor = true;
        fv2.Click += fv2_Click;
        // 
        // fv3
        // 
        fv3.Location = new Point(523, 29);
        fv3.Margin = new Padding(3, 4, 3, 4);
        fv3.Name = "fv3";
        fv3.Size = new Size(251, 37);
        fv3.TabIndex = 2;
        fv3.Text = "Грабёж";
        fv3.UseVisualStyleBackColor = true;
        fv3.Click += fv3_Click;
        // 
        // fv4
        // 
        fv4.Location = new Point(781, 29);
        fv4.Margin = new Padding(3, 4, 3, 4);
        fv4.Name = "fv4";
        fv4.Size = new Size(251, 37);
        fv4.TabIndex = 3;
        fv4.Text = "Разбой";
        fv4.UseVisualStyleBackColor = true;
        fv4.Click += fv4_Click;
        // 
        // fv5
        // 
        fv5.Location = new Point(1038, 29);
        fv5.Margin = new Padding(3, 4, 3, 4);
        fv5.Name = "fv5";
        fv5.Size = new Size(251, 37);
        fv5.TabIndex = 4;
        fv5.Text = "Тяжкий вред здоровью";
        fv5.UseVisualStyleBackColor = true;
        fv5.Click += fv5_Click;
        // 
        // grpFS
        // 
        grpFS.Controls.Add(fs1);
        grpFS.Controls.Add(fs2);
        grpFS.Controls.Add(fs3);
        grpFS.Controls.Add(fs4);
        grpFS.Controls.Add(fs5);
        grpFS.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        grpFS.Location = new Point(9, 471);
        grpFS.Margin = new Padding(3, 4, 3, 4);
        grpFS.Name = "grpFS";
        grpFS.Padding = new Padding(3, 4, 3, 4);
        grpFS.Size = new Size(1312, 77);
        grpFS.TabIndex = 5;
        grpFS.TabStop = false;
        grpFS.Text = "Табличные формы — Фильтры по состоянию";
        // 
        // fs1
        // 
        fs1.Location = new Point(9, 29);
        fs1.Margin = new Padding(3, 4, 3, 4);
        fs1.Name = "fs1";
        fs1.Size = new Size(251, 37);
        fs1.TabIndex = 0;
        fs1.Text = "Передано в суд";
        fs1.UseVisualStyleBackColor = true;
        fs1.Click += fs1_Click;
        // 
        // fs2
        // 
        fs2.Location = new Point(266, 29);
        fs2.Margin = new Padding(3, 4, 3, 4);
        fs2.Name = "fs2";
        fs2.Size = new Size(251, 37);
        fs2.TabIndex = 1;
        fs2.Text = "Под следствием";
        fs2.UseVisualStyleBackColor = true;
        fs2.Click += fs2_Click;
        // 
        // fs3
        // 
        fs3.Location = new Point(523, 29);
        fs3.Margin = new Padding(3, 4, 3, 4);
        fs3.Name = "fs3";
        fs3.Size = new Size(251, 37);
        fs3.TabIndex = 2;
        fs3.Text = "В розыске";
        fs3.UseVisualStyleBackColor = true;
        fs3.Click += fs3_Click;
        // 
        // fs4
        // 
        fs4.Location = new Point(781, 29);
        fs4.Margin = new Padding(3, 4, 3, 4);
        fs4.Name = "fs4";
        fs4.Size = new Size(251, 37);
        fs4.TabIndex = 3;
        fs4.Text = "Задержан";
        fs4.UseVisualStyleBackColor = true;
        fs4.Click += fs4_Click;
        // 
        // fs5
        // 
        fs5.Location = new Point(1038, 29);
        fs5.Margin = new Padding(3, 4, 3, 4);
        fs5.Name = "fs5";
        fs5.Size = new Size(251, 37);
        fs5.TabIndex = 4;
        fs5.Text = "Под подпиской";
        fs5.UseVisualStyleBackColor = true;
        fs5.Click += fs5_Click;
        // 
        // tabReports
        // 
        tabReports.Controls.Add(pnlReports);
        tabReports.Location = new Point(4, 29);
        tabReports.Margin = new Padding(3, 4, 3, 4);
        tabReports.Name = "tabReports";
        tabReports.Padding = new Padding(3, 4, 3, 4);
        tabReports.Size = new Size(1320, 672);
        tabReports.TabIndex = 1;
        tabReports.Text = "Отчёты";
        tabReports.UseVisualStyleBackColor = true;
        // 
        // pnlReports
        // 
        pnlReports.Controls.Add(grpRT);
        pnlReports.Controls.Add(grpRQ);
        pnlReports.Controls.Add(grpRD);
        pnlReports.Controls.Add(grpRZ);
        pnlReports.Controls.Add(grpRV);
        pnlReports.Controls.Add(grpRS);
        pnlReports.Dock = DockStyle.Fill;
        pnlReports.Location = new Point(3, 4);
        pnlReports.Margin = new Padding(3, 4, 3, 4);
        pnlReports.Name = "pnlReports";
        pnlReports.Padding = new Padding(9, 8, 9, 8);
        pnlReports.Size = new Size(1314, 664);
        pnlReports.TabIndex = 0;
        // 
        // grpRT
        // 
        grpRT.Controls.Add(rt1);
        grpRT.Controls.Add(rt2);
        grpRT.Controls.Add(rt3);
        grpRT.Controls.Add(rt4);
        grpRT.Controls.Add(rt5);
        grpRT.Controls.Add(rt6);
        grpRT.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        grpRT.Location = new Point(9, 0);
        grpRT.Margin = new Padding(3, 4, 3, 4);
        grpRT.Name = "grpRT";
        grpRT.Padding = new Padding(3, 4, 3, 4);
        grpRT.Size = new Size(1312, 121);
        grpRT.TabIndex = 0;
        grpRT.TabStop = false;
        grpRT.Text = "Отчёты — Таблицы";
        // 
        // rt1
        // 
        rt1.Location = new Point(9, 29);
        rt1.Margin = new Padding(3, 4, 3, 4);
        rt1.Name = "rt1";
        rt1.Size = new Size(423, 37);
        rt1.TabIndex = 0;
        rt1.Text = "Сотрудники";
        rt1.UseVisualStyleBackColor = true;
        rt1.Click += rt1_Click;
        // 
        // rt2
        // 
        rt2.Location = new Point(441, 29);
        rt2.Margin = new Padding(3, 4, 3, 4);
        rt2.Name = "rt2";
        rt2.Size = new Size(423, 37);
        rt2.TabIndex = 1;
        rt2.Text = "Должности";
        rt2.UseVisualStyleBackColor = true;
        rt2.Click += rt2_Click;
        // 
        // rt3
        // 
        rt3.Location = new Point(873, 29);
        rt3.Margin = new Padding(3, 4, 3, 4);
        rt3.Name = "rt3";
        rt3.Size = new Size(423, 37);
        rt3.TabIndex = 2;
        rt3.Text = "Звания";
        rt3.UseVisualStyleBackColor = true;
        rt3.Click += rt3_Click;
        // 
        // rt4
        // 
        rt4.Location = new Point(9, 73);
        rt4.Margin = new Padding(3, 4, 3, 4);
        rt4.Name = "rt4";
        rt4.Size = new Size(423, 37);
        rt4.TabIndex = 3;
        rt4.Text = "Виды преступлений";
        rt4.UseVisualStyleBackColor = true;
        rt4.Click += rt4_Click;
        // 
        // rt5
        // 
        rt5.Location = new Point(441, 73);
        rt5.Margin = new Padding(3, 4, 3, 4);
        rt5.Name = "rt5";
        rt5.Size = new Size(423, 37);
        rt5.TabIndex = 4;
        rt5.Text = "Преступники";
        rt5.UseVisualStyleBackColor = true;
        rt5.Click += rt5_Click;
        // 
        // rt6
        // 
        rt6.Location = new Point(873, 73);
        rt6.Margin = new Padding(3, 4, 3, 4);
        rt6.Name = "rt6";
        rt6.Size = new Size(423, 37);
        rt6.TabIndex = 5;
        rt6.Text = "Пострадавшие";
        rt6.UseVisualStyleBackColor = true;
        rt6.Click += rt6_Click;
        // 
        // grpRQ
        // 
        grpRQ.Controls.Add(rq1);
        grpRQ.Controls.Add(rq2);
        grpRQ.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        grpRQ.Location = new Point(9, 129);
        grpRQ.Margin = new Padding(3, 4, 3, 4);
        grpRQ.Name = "grpRQ";
        grpRQ.Padding = new Padding(3, 4, 3, 4);
        grpRQ.Size = new Size(1312, 77);
        grpRQ.TabIndex = 1;
        grpRQ.TabStop = false;
        grpRQ.Text = "Отчёты — Запросы";
        // 
        // rq1
        // 
        rq1.Location = new Point(9, 29);
        rq1.Margin = new Padding(3, 4, 3, 4);
        rq1.Name = "rq1";
        rq1.Size = new Size(649, 37);
        rq1.TabIndex = 0;
        rq1.Text = "Отдел кадров";
        rq1.UseVisualStyleBackColor = true;
        rq1.Click += rq1_Click;
        // 
        // rq2
        // 
        rq2.Location = new Point(670, 29);
        rq2.Margin = new Padding(3, 4, 3, 4);
        rq2.Name = "rq2";
        rq2.Size = new Size(649, 37);
        rq2.TabIndex = 1;
        rq2.Text = "Преступники";
        rq2.UseVisualStyleBackColor = true;
        rq2.Click += rq2_Click;
        // 
        // grpRD
        // 
        grpRD.Controls.Add(rd1);
        grpRD.Controls.Add(rd2);
        grpRD.Controls.Add(rd3);
        grpRD.Controls.Add(rd4);
        grpRD.Controls.Add(rd5);
        grpRD.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        grpRD.Location = new Point(9, 215);
        grpRD.Margin = new Padding(3, 4, 3, 4);
        grpRD.Name = "grpRD";
        grpRD.Padding = new Padding(3, 4, 3, 4);
        grpRD.Size = new Size(1312, 77);
        grpRD.TabIndex = 2;
        grpRD.TabStop = false;
        grpRD.Text = "Отчёты — Фильтры по должностям";
        // 
        // rd1
        // 
        rd1.Location = new Point(9, 29);
        rd1.Margin = new Padding(3, 4, 3, 4);
        rd1.Name = "rd1";
        rd1.Size = new Size(251, 37);
        rd1.TabIndex = 0;
        rd1.Text = "Начальник отдела";
        rd1.UseVisualStyleBackColor = true;
        rd1.Click += rd1_Click;
        // 
        // rd2
        // 
        rd2.Location = new Point(266, 29);
        rd2.Margin = new Padding(3, 4, 3, 4);
        rd2.Name = "rd2";
        rd2.Size = new Size(251, 37);
        rd2.TabIndex = 1;
        rd2.Text = "Ст. следователь";
        rd2.UseVisualStyleBackColor = true;
        rd2.Click += rd2_Click;
        // 
        // rd3
        // 
        rd3.Location = new Point(523, 29);
        rd3.Margin = new Padding(3, 4, 3, 4);
        rd3.Name = "rd3";
        rd3.Size = new Size(251, 37);
        rd3.TabIndex = 2;
        rd3.Text = "Следователь";
        rd3.UseVisualStyleBackColor = true;
        rd3.Click += rd3_Click;
        // 
        // rd4
        // 
        rd4.Location = new Point(781, 29);
        rd4.Margin = new Padding(3, 4, 3, 4);
        rd4.Name = "rd4";
        rd4.Size = new Size(251, 37);
        rd4.TabIndex = 3;
        rd4.Text = "Оперуполномоченный";
        rd4.UseVisualStyleBackColor = true;
        rd4.Click += rd4_Click;
        // 
        // rd5
        // 
        rd5.Location = new Point(1038, 29);
        rd5.Margin = new Padding(3, 4, 3, 4);
        rd5.Name = "rd5";
        rd5.Size = new Size(251, 37);
        rd5.TabIndex = 4;
        rd5.Text = "Инспектор архива";
        rd5.UseVisualStyleBackColor = true;
        rd5.Click += rd5_Click;
        // 
        // grpRZ
        // 
        grpRZ.Controls.Add(rz1);
        grpRZ.Controls.Add(rz2);
        grpRZ.Controls.Add(rz3);
        grpRZ.Controls.Add(rz4);
        grpRZ.Controls.Add(rz5);
        grpRZ.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        grpRZ.Location = new Point(9, 300);
        grpRZ.Margin = new Padding(3, 4, 3, 4);
        grpRZ.Name = "grpRZ";
        grpRZ.Padding = new Padding(3, 4, 3, 4);
        grpRZ.Size = new Size(1312, 77);
        grpRZ.TabIndex = 3;
        grpRZ.TabStop = false;
        grpRZ.Text = "Отчёты — Фильтры по званиям";
        // 
        // rz1
        // 
        rz1.Location = new Point(9, 29);
        rz1.Margin = new Padding(3, 4, 3, 4);
        rz1.Name = "rz1";
        rz1.Size = new Size(251, 37);
        rz1.TabIndex = 0;
        rz1.Text = "Лейтенант";
        rz1.UseVisualStyleBackColor = true;
        rz1.Click += rz1_Click;
        // 
        // rz2
        // 
        rz2.Location = new Point(266, 29);
        rz2.Margin = new Padding(3, 4, 3, 4);
        rz2.Name = "rz2";
        rz2.Size = new Size(251, 37);
        rz2.TabIndex = 1;
        rz2.Text = "Ст. лейтенант";
        rz2.UseVisualStyleBackColor = true;
        rz2.Click += rz2_Click;
        // 
        // rz3
        // 
        rz3.Location = new Point(523, 29);
        rz3.Margin = new Padding(3, 4, 3, 4);
        rz3.Name = "rz3";
        rz3.Size = new Size(251, 37);
        rz3.TabIndex = 2;
        rz3.Text = "Капитан";
        rz3.UseVisualStyleBackColor = true;
        rz3.Click += rz3_Click;
        // 
        // rz4
        // 
        rz4.Location = new Point(781, 29);
        rz4.Margin = new Padding(3, 4, 3, 4);
        rz4.Name = "rz4";
        rz4.Size = new Size(251, 37);
        rz4.TabIndex = 3;
        rz4.Text = "Майор";
        rz4.UseVisualStyleBackColor = true;
        rz4.Click += rz4_Click;
        // 
        // rz5
        // 
        rz5.Location = new Point(1038, 29);
        rz5.Margin = new Padding(3, 4, 3, 4);
        rz5.Name = "rz5";
        rz5.Size = new Size(251, 37);
        rz5.TabIndex = 4;
        rz5.Text = "Подполковник";
        rz5.UseVisualStyleBackColor = true;
        rz5.Click += rz5_Click;
        // 
        // grpRV
        // 
        grpRV.Controls.Add(rv1);
        grpRV.Controls.Add(rv2);
        grpRV.Controls.Add(rv3);
        grpRV.Controls.Add(rv4);
        grpRV.Controls.Add(rv5);
        grpRV.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        grpRV.Location = new Point(9, 385);
        grpRV.Margin = new Padding(3, 4, 3, 4);
        grpRV.Name = "grpRV";
        grpRV.Padding = new Padding(3, 4, 3, 4);
        grpRV.Size = new Size(1312, 77);
        grpRV.TabIndex = 4;
        grpRV.TabStop = false;
        grpRV.Text = "Отчёты — Фильтры по видам преступлений";
        // 
        // rv1
        // 
        rv1.Location = new Point(9, 29);
        rv1.Margin = new Padding(3, 4, 3, 4);
        rv1.Name = "rv1";
        rv1.Size = new Size(251, 37);
        rv1.TabIndex = 0;
        rv1.Text = "Кража";
        rv1.UseVisualStyleBackColor = true;
        rv1.Click += rv1_Click;
        // 
        // rv2
        // 
        rv2.Location = new Point(266, 29);
        rv2.Margin = new Padding(3, 4, 3, 4);
        rv2.Name = "rv2";
        rv2.Size = new Size(251, 37);
        rv2.TabIndex = 1;
        rv2.Text = "Мошенничество";
        rv2.UseVisualStyleBackColor = true;
        rv2.Click += rv2_Click;
        // 
        // rv3
        // 
        rv3.Location = new Point(523, 29);
        rv3.Margin = new Padding(3, 4, 3, 4);
        rv3.Name = "rv3";
        rv3.Size = new Size(251, 37);
        rv3.TabIndex = 2;
        rv3.Text = "Грабёж";
        rv3.UseVisualStyleBackColor = true;
        rv3.Click += rv3_Click;
        // 
        // rv4
        // 
        rv4.Location = new Point(781, 29);
        rv4.Margin = new Padding(3, 4, 3, 4);
        rv4.Name = "rv4";
        rv4.Size = new Size(251, 37);
        rv4.TabIndex = 3;
        rv4.Text = "Разбой";
        rv4.UseVisualStyleBackColor = true;
        rv4.Click += rv4_Click;
        // 
        // rv5
        // 
        rv5.Location = new Point(1038, 29);
        rv5.Margin = new Padding(3, 4, 3, 4);
        rv5.Name = "rv5";
        rv5.Size = new Size(251, 37);
        rv5.TabIndex = 4;
        rv5.Text = "Тяжкий вред здоровью";
        rv5.UseVisualStyleBackColor = true;
        rv5.Click += rv5_Click;
        // 
        // grpRS
        // 
        grpRS.Controls.Add(rs1);
        grpRS.Controls.Add(rs2);
        grpRS.Controls.Add(rs3);
        grpRS.Controls.Add(rs4);
        grpRS.Controls.Add(rs5);
        grpRS.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        grpRS.Location = new Point(9, 471);
        grpRS.Margin = new Padding(3, 4, 3, 4);
        grpRS.Name = "grpRS";
        grpRS.Padding = new Padding(3, 4, 3, 4);
        grpRS.Size = new Size(1312, 77);
        grpRS.TabIndex = 5;
        grpRS.TabStop = false;
        grpRS.Text = "Отчёты — Фильтры по состоянию";
        // 
        // rs1
        // 
        rs1.Location = new Point(9, 29);
        rs1.Margin = new Padding(3, 4, 3, 4);
        rs1.Name = "rs1";
        rs1.Size = new Size(251, 37);
        rs1.TabIndex = 0;
        rs1.Text = "Передано в суд";
        rs1.UseVisualStyleBackColor = true;
        rs1.Click += rs1_Click;
        // 
        // rs2
        // 
        rs2.Location = new Point(266, 29);
        rs2.Margin = new Padding(3, 4, 3, 4);
        rs2.Name = "rs2";
        rs2.Size = new Size(251, 37);
        rs2.TabIndex = 1;
        rs2.Text = "Под следствием";
        rs2.UseVisualStyleBackColor = true;
        rs2.Click += rs2_Click;
        // 
        // rs3
        // 
        rs3.Location = new Point(523, 29);
        rs3.Margin = new Padding(3, 4, 3, 4);
        rs3.Name = "rs3";
        rs3.Size = new Size(251, 37);
        rs3.TabIndex = 2;
        rs3.Text = "В розыске";
        rs3.UseVisualStyleBackColor = true;
        rs3.Click += rs3_Click;
        // 
        // rs4
        // 
        rs4.Location = new Point(781, 29);
        rs4.Margin = new Padding(3, 4, 3, 4);
        rs4.Name = "rs4";
        rs4.Size = new Size(251, 37);
        rs4.TabIndex = 3;
        rs4.Text = "Задержан";
        rs4.UseVisualStyleBackColor = true;
        rs4.Click += rs4_Click;
        // 
        // rs5
        // 
        rs5.Location = new Point(1038, 29);
        rs5.Margin = new Padding(3, 4, 3, 4);
        rs5.Name = "rs5";
        rs5.Size = new Size(251, 37);
        rs5.TabIndex = 4;
        rs5.Text = "Под подпиской";
        rs5.UseVisualStyleBackColor = true;
        rs5.Click += rs5_Click;
        // 
        // pnlFooter
        // 
        pnlFooter.Controls.Add(btnHistogram);
        pnlFooter.Controls.Add(btnAbout);
        pnlFooter.Controls.Add(btnExit);
        pnlFooter.Dock = DockStyle.Bottom;
        pnlFooter.Location = new Point(0, 788);
        pnlFooter.Margin = new Padding(3, 4, 3, 4);
        pnlFooter.Name = "pnlFooter";
        pnlFooter.Size = new Size(1348, 83);
        pnlFooter.TabIndex = 2;
        // 
        // btnHistogram
        // 
        btnHistogram.Location = new Point(731, 17);
        btnHistogram.Margin = new Padding(3, 4, 3, 4);
        btnHistogram.Name = "btnHistogram";
        btnHistogram.Size = new Size(149, 48);
        btnHistogram.TabIndex = 0;
        btnHistogram.Text = "Гистограмма";
        btnHistogram.UseVisualStyleBackColor = true;
        btnHistogram.Click += btnHistogram_Click;
        // 
        // btnAbout
        // 
        btnAbout.Location = new Point(891, 17);
        btnAbout.Margin = new Padding(3, 4, 3, 4);
        btnAbout.Name = "btnAbout";
        btnAbout.Size = new Size(149, 48);
        btnAbout.TabIndex = 1;
        btnAbout.Text = "О программе";
        btnAbout.UseVisualStyleBackColor = true;
        btnAbout.Click += btnAbout_Click;
        // 
        // btnExit
        // 
        btnExit.Location = new Point(1223, 17);
        btnExit.Margin = new Padding(3, 4, 3, 4);
        btnExit.Name = "btnExit";
        btnExit.Size = new Size(114, 48);
        btnExit.TabIndex = 2;
        btnExit.Text = "Выход";
        btnExit.UseVisualStyleBackColor = true;
        btnExit.Click += btnExit_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1348, 871);
        Controls.Add(tabControl);
        Controls.Add(pnlFooter);
        Controls.Add(lblHeader);
        Margin = new Padding(3, 4, 3, 4);
        MinimumSize = new Size(1346, 918);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Главная кнопочная форма";
        tabControl.ResumeLayout(false);
        tabForms.ResumeLayout(false);
        pnlForms.ResumeLayout(false);
        grpFR.ResumeLayout(false);
        grpFQ.ResumeLayout(false);
        grpFD.ResumeLayout(false);
        grpFZ.ResumeLayout(false);
        grpFV.ResumeLayout(false);
        grpFS.ResumeLayout(false);
        tabReports.ResumeLayout(false);
        pnlReports.ResumeLayout(false);
        grpRT.ResumeLayout(false);
        grpRQ.ResumeLayout(false);
        grpRD.ResumeLayout(false);
        grpRZ.ResumeLayout(false);
        grpRV.ResumeLayout(false);
        grpRS.ResumeLayout(false);
        pnlFooter.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    // ── Field declarations ────────────────────────────────────────────────────
    private Label      lblHeader;
    private TabControl tabControl;
    private TabPage    tabForms;
    private TabPage    tabReports;
    private Panel      pnlFooter;
    private Button     btnExit;
    private Button     btnAbout;
    private Button     btnHistogram;

    private Panel    pnlForms;
    private GroupBox grpFR, grpFQ, grpFD, grpFZ, grpFV, grpFS;
    private Button   fr1, fr2, fr3, fr4, fr5, fr6;
    private Button   fq1, fq2;
    private Button   fd1, fd2, fd3, fd4, fd5;
    private Button   fz1, fz2, fz3, fz4, fz5;
    private Button   fv1, fv2, fv3, fv4, fv5;
    private Button   fs1, fs2, fs3, fs4, fs5;

    private Panel    pnlReports;
    private GroupBox grpRT, grpRQ, grpRD, grpRZ, grpRV, grpRS;
    private Button   rt1, rt2, rt3, rt4, rt5, rt6;
    private Button   rq1, rq2;
    private Button   rd1, rd2, rd3, rd4, rd5;
    private Button   rz1, rz2, rz3, rz4, rz5;
    private Button   rv1, rv2, rv3, rv4, rv5;
    private Button   rs1, rs2, rs3, rs4, rs5;
}
