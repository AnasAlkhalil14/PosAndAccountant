namespace PosAndAccountantProject.Expenses
{
    partial class frmListExpenses
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvExpenses = new Guna.UI2.WinForms.Guna2DataGridView();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.عرضالتفاصيلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddNew = new Guna.UI2.WinForms.Guna2Button();
            this.lnkEveryProduct = new System.Windows.Forms.LinkLabel();
            this.lnkPrivios = new System.Windows.Forms.LinkLabel();
            this.lnkNext = new System.Windows.Forms.LinkLabel();
            this.lblPageNumber = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lnkMostSold = new System.Windows.Forms.LinkLabel();
            this.lnkMostProfit = new System.Windows.Forms.LinkLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblValueOfStock = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lnkSlowMoving = new System.Windows.Forms.LinkLabel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCountLoseProduct = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lnkLowStock = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.cardOutOfStock = new Guna.UI2.WinForms.Guna2Panel();
            this.lblOutOfStockCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cardTotal = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.cardOutOfStock.SuspendLayout();
            this.cardTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BorderRadius = 15;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(953, 133);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(387, 42);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(167, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ادارة المصاريف";
            // 
            // dgvExpenses
            // 
            this.dgvExpenses.AllowUserToAddRows = false;
            this.dgvExpenses.AllowUserToDeleteRows = false;
            this.dgvExpenses.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvExpenses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExpenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvExpenses.ColumnHeadersHeight = 40;
            this.dgvExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvExpenses.ContextMenuStrip = this.contextMenuStrip2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExpenses.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvExpenses.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvExpenses.Location = new System.Drawing.Point(12, 475);
            this.dgvExpenses.MultiSelect = false;
            this.dgvExpenses.Name = "dgvExpenses";
            this.dgvExpenses.ReadOnly = true;
            this.dgvExpenses.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvExpenses.RowHeadersVisible = false;
            this.dgvExpenses.RowHeadersWidth = 51;
            this.dgvExpenses.RowTemplate.Height = 35;
            this.dgvExpenses.Size = new System.Drawing.Size(924, 275);
            this.dgvExpenses.TabIndex = 129;
            this.dgvExpenses.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvExpenses.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvExpenses.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvExpenses.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvExpenses.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvExpenses.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvExpenses.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvExpenses.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.dgvExpenses.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvExpenses.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.dgvExpenses.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvExpenses.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvExpenses.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvExpenses.ThemeStyle.ReadOnly = true;
            this.dgvExpenses.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvExpenses.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvExpenses.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvExpenses.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvExpenses.ThemeStyle.RowsStyle.Height = 35;
            this.dgvExpenses.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvExpenses.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.عرضالتفاصيلToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(149, 26);
            // 
            // عرضالتفاصيلToolStripMenuItem
            // 
            this.عرضالتفاصيلToolStripMenuItem.Name = "عرضالتفاصيلToolStripMenuItem";
            this.عرضالتفاصيلToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.عرضالتفاصيلToolStripMenuItem.Text = "عرض التفاصيل";
            this.عرضالتفاصيلToolStripMenuItem.Click += new System.EventHandler(this.عرضالتفاصيلToolStripMenuItem_Click);
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblRecordsCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.lblRecordsCount.Location = new System.Drawing.Point(195, 767);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(26, 21);
            this.lblRecordsCount.TabIndex = 138;
            this.lblRecordsCount.Text = "??";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(31, 767);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 21);
            this.label2.TabIndex = 137;
            this.label2.Text = "عدد السجلات:";
            // 
            // cbType
            // 
            this.cbType.BackColor = System.Drawing.Color.Transparent;
            this.cbType.BorderRadius = 8;
            this.cbType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbType.ItemHeight = 30;
            this.cbType.Items.AddRange(new object[] {
            "لا شيء",
            "معرف الشريك",
            "اسم الشريك"});
            this.cbType.Location = new System.Drawing.Point(504, 423);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(188, 36);
            this.cbType.StartIndex = 0;
            this.cbType.TabIndex = 141;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(390, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 140;
            this.label1.Text = "نوع المصروع";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Animated = true;
            this.btnAddNew.BorderRadius = 10;
            this.btnAddNew.BorderThickness = 1;
            this.btnAddNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNew.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddNew.FillColor = System.Drawing.Color.Transparent;
            this.btnAddNew.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAddNew.ForeColor = System.Drawing.Color.YellowGreen;
            this.btnAddNew.Image = global::PosAndAccountantProject.Properties.Resources.plus;
            this.btnAddNew.ImageSize = new System.Drawing.Size(32, 32);
            this.btnAddNew.Location = new System.Drawing.Point(851, 423);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(84, 44);
            this.btnAddNew.TabIndex = 142;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // lnkEveryProduct
            // 
            this.lnkEveryProduct.AutoSize = true;
            this.lnkEveryProduct.BackColor = System.Drawing.Color.Silver;
            this.lnkEveryProduct.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lnkEveryProduct.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkEveryProduct.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lnkEveryProduct.Location = new System.Drawing.Point(376, 310);
            this.lnkEveryProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkEveryProduct.Name = "lnkEveryProduct";
            this.lnkEveryProduct.Size = new System.Drawing.Size(81, 19);
            this.lnkEveryProduct.TabIndex = 159;
            this.lnkEveryProduct.TabStop = true;
            this.lnkEveryProduct.Text = "كل المنتجات";
            // 
            // lnkPrivios
            // 
            this.lnkPrivios.AutoSize = true;
            this.lnkPrivios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lnkPrivios.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lnkPrivios.Location = new System.Drawing.Point(237, 418);
            this.lnkPrivios.Name = "lnkPrivios";
            this.lnkPrivios.Padding = new System.Windows.Forms.Padding(4);
            this.lnkPrivios.Size = new System.Drawing.Size(61, 30);
            this.lnkPrivios.TabIndex = 158;
            this.lnkPrivios.TabStop = true;
            this.lnkPrivios.Text = "السابق";
            // 
            // lnkNext
            // 
            this.lnkNext.AutoSize = true;
            this.lnkNext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lnkNext.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lnkNext.Location = new System.Drawing.Point(176, 418);
            this.lnkNext.Name = "lnkNext";
            this.lnkNext.Padding = new System.Windows.Forms.Padding(4);
            this.lnkNext.Size = new System.Drawing.Size(55, 30);
            this.lnkNext.TabIndex = 157;
            this.lnkNext.TabStop = true;
            this.lnkNext.Text = "التالي";
            // 
            // lblPageNumber
            // 
            this.lblPageNumber.AutoSize = true;
            this.lblPageNumber.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageNumber.Location = new System.Drawing.Point(121, 421);
            this.lblPageNumber.Name = "lblPageNumber";
            this.lblPageNumber.Size = new System.Drawing.Size(18, 30);
            this.lblPageNumber.TabIndex = 156;
            this.lblPageNumber.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1, 423);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 25);
            this.label7.TabIndex = 155;
            this.label7.Text = "رقم الصفحة :";
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(487, 155);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(454, 240);
            this.chart.TabIndex = 154;
            this.chart.Text = "chart1";
            // 
            // lnkMostSold
            // 
            this.lnkMostSold.AutoSize = true;
            this.lnkMostSold.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lnkMostSold.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkMostSold.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lnkMostSold.Location = new System.Drawing.Point(299, 368);
            this.lnkMostSold.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkMostSold.Name = "lnkMostSold";
            this.lnkMostSold.Size = new System.Drawing.Size(86, 19);
            this.lnkMostSold.TabIndex = 147;
            this.lnkMostSold.TabStop = true;
            this.lnkMostSold.Text = "الأكثر مبيعاً ↑";
            // 
            // lnkMostProfit
            // 
            this.lnkMostProfit.AutoSize = true;
            this.lnkMostProfit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lnkMostProfit.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkMostProfit.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lnkMostProfit.Location = new System.Drawing.Point(389, 368);
            this.lnkMostProfit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkMostProfit.Name = "lnkMostProfit";
            this.lnkMostProfit.Size = new System.Drawing.Size(80, 19);
            this.lnkMostProfit.TabIndex = 148;
            this.lnkMostProfit.TabStop = true;
            this.lnkMostProfit.Text = "الأكثر ربحاً $";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 12;
            this.guna2Panel1.Controls.Add(this.lblValueOfStock);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.guna2Panel1.Location = new System.Drawing.Point(-6, 207);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(135, 65);
            this.guna2Panel1.TabIndex = 153;
            // 
            // lblValueOfStock
            // 
            this.lblValueOfStock.AutoSize = true;
            this.lblValueOfStock.BackColor = System.Drawing.Color.Transparent;
            this.lblValueOfStock.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblValueOfStock.ForeColor = System.Drawing.Color.White;
            this.lblValueOfStock.Location = new System.Drawing.Point(11, 24);
            this.lblValueOfStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValueOfStock.Name = "lblValueOfStock";
            this.lblValueOfStock.Size = new System.Drawing.Size(26, 30);
            this.lblValueOfStock.TabIndex = 1;
            this.lblValueOfStock.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(20, -1);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "قيمة المخزون";
            // 
            // lnkSlowMoving
            // 
            this.lnkSlowMoving.AutoSize = true;
            this.lnkSlowMoving.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lnkSlowMoving.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkSlowMoving.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lnkSlowMoving.Location = new System.Drawing.Point(299, 310);
            this.lnkSlowMoving.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkSlowMoving.Name = "lnkSlowMoving";
            this.lnkSlowMoving.Size = new System.Drawing.Size(83, 19);
            this.lnkSlowMoving.TabIndex = 149;
            this.lnkSlowMoving.TabStop = true;
            this.lnkSlowMoving.Text = "الأقل مبيعاً ↓";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderRadius = 12;
            this.guna2Panel2.Controls.Add(this.lblCountLoseProduct);
            this.guna2Panel2.Controls.Add(this.label4);
            this.guna2Panel2.FillColor = System.Drawing.Color.Gray;
            this.guna2Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.guna2Panel2.Location = new System.Drawing.Point(140, 207);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(135, 65);
            this.guna2Panel2.TabIndex = 152;
            // 
            // lblCountLoseProduct
            // 
            this.lblCountLoseProduct.AutoSize = true;
            this.lblCountLoseProduct.BackColor = System.Drawing.Color.Transparent;
            this.lblCountLoseProduct.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblCountLoseProduct.ForeColor = System.Drawing.Color.White;
            this.lblCountLoseProduct.Location = new System.Drawing.Point(11, 24);
            this.lblCountLoseProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCountLoseProduct.Name = "lblCountLoseProduct";
            this.lblCountLoseProduct.Size = new System.Drawing.Size(26, 30);
            this.lblCountLoseProduct.TabIndex = 1;
            this.lblCountLoseProduct.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(20, 4);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "منتجات تخسر";
            // 
            // lnkLowStock
            // 
            this.lnkLowStock.AutoSize = true;
            this.lnkLowStock.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lnkLowStock.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkLowStock.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.lnkLowStock.Location = new System.Drawing.Point(376, 337);
            this.lnkLowStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkLowStock.Name = "lnkLowStock";
            this.lnkLowStock.Size = new System.Drawing.Size(115, 19);
            this.lnkLowStock.TabIndex = 150;
            this.lnkLowStock.TabStop = true;
            this.lnkLowStock.Text = "تحت حد الطلب  !!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(296, 341);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 151;
            this.label3.Text = "تقارير سريعة :";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.Location = new System.Drawing.Point(16, 400);
            this.guna2Separator1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(913, 8);
            this.guna2Separator1.TabIndex = 146;
            // 
            // cardOutOfStock
            // 
            this.cardOutOfStock.BorderRadius = 12;
            this.cardOutOfStock.Controls.Add(this.lblOutOfStockCount);
            this.cardOutOfStock.Controls.Add(this.label5);
            this.cardOutOfStock.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardOutOfStock.Location = new System.Drawing.Point(140, 286);
            this.cardOutOfStock.Margin = new System.Windows.Forms.Padding(2);
            this.cardOutOfStock.Name = "cardOutOfStock";
            this.cardOutOfStock.Size = new System.Drawing.Size(135, 65);
            this.cardOutOfStock.TabIndex = 145;
            // 
            // lblOutOfStockCount
            // 
            this.lblOutOfStockCount.AutoSize = true;
            this.lblOutOfStockCount.BackColor = System.Drawing.Color.Transparent;
            this.lblOutOfStockCount.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblOutOfStockCount.ForeColor = System.Drawing.Color.White;
            this.lblOutOfStockCount.Location = new System.Drawing.Point(11, 24);
            this.lblOutOfStockCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOutOfStockCount.Name = "lblOutOfStockCount";
            this.lblOutOfStockCount.Size = new System.Drawing.Size(26, 30);
            this.lblOutOfStockCount.TabIndex = 1;
            this.lblOutOfStockCount.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(22, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "كمية قليلة";
            // 
            // cardTotal
            // 
            this.cardTotal.BorderRadius = 12;
            this.cardTotal.Controls.Add(this.lblTotalCount);
            this.cardTotal.Controls.Add(this.label8);
            this.cardTotal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.cardTotal.Location = new System.Drawing.Point(-6, 286);
            this.cardTotal.Margin = new System.Windows.Forms.Padding(2);
            this.cardTotal.Name = "cardTotal";
            this.cardTotal.Size = new System.Drawing.Size(135, 65);
            this.cardTotal.TabIndex = 144;
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalCount.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotalCount.ForeColor = System.Drawing.Color.White;
            this.lblTotalCount.Location = new System.Drawing.Point(11, 24);
            this.lblTotalCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(26, 30);
            this.lblTotalCount.TabIndex = 1;
            this.lblTotalCount.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(17, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "إجمالي المنتجات";
            // 
            // frmListExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(953, 811);
            this.Controls.Add(this.lnkEveryProduct);
            this.Controls.Add(this.lnkPrivios);
            this.Controls.Add(this.lnkNext);
            this.Controls.Add(this.lblPageNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.lnkMostSold);
            this.Controls.Add(this.lnkMostProfit);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.lnkSlowMoving);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.lnkLowStock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.cardOutOfStock);
            this.Controls.Add(this.cardTotal);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvExpenses);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frmListExpenses";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListExpenses";
            this.Load += new System.EventHandler(this.frmListExpenses_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.cardOutOfStock.ResumeLayout(false);
            this.cardOutOfStock.PerformLayout();
            this.cardTotal.ResumeLayout(false);
            this.cardTotal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2DataGridView dgvExpenses;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cbType;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnAddNew;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem عرضالتفاصيلToolStripMenuItem;
        private System.Windows.Forms.LinkLabel lnkEveryProduct;
        private System.Windows.Forms.LinkLabel lnkPrivios;
        private System.Windows.Forms.LinkLabel lnkNext;
        private System.Windows.Forms.Label lblPageNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.LinkLabel lnkMostSold;
        private System.Windows.Forms.LinkLabel lnkMostProfit;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblValueOfStock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel lnkSlowMoving;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label lblCountLoseProduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel lnkLowStock;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Panel cardOutOfStock;
        private System.Windows.Forms.Label lblOutOfStockCount;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Panel cardTotal;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Label label8;
    }
}