namespace PosAndAccountantProject.Purchases
{
    partial class frmPurchasesList
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPurchaseToday = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.lblLowStockProducts = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDebtToday = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cardTotal = new Guna.UI2.WinForms.Guna2Panel();
            this.lblMaxPurchaseToday = new System.Windows.Forms.Label();
            this.lnkPrivios = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.lnkNext = new System.Windows.Forms.LinkLabel();
            this.lblPageNumber = new System.Windows.Forms.Label();
            this.btnAddNewPurchase = new Guna.UI2.WinForms.Guna2Button();
            this.تعديلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSales = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cardOutOfStock = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPurchaseList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.cardTotal.SuspendLayout();
            this.cmsSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.cardOutOfStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseList)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel3.Controls.Add(this.pictureBox1);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(953, 128);
            this.guna2Panel3.TabIndex = 43;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PosAndAccountantProject.Properties.Resources.PurchaseList;
            this.pictureBox1.Location = new System.Drawing.Point(328, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // lblPurchaseToday
            // 
            this.lblPurchaseToday.AutoSize = true;
            this.lblPurchaseToday.BackColor = System.Drawing.Color.Transparent;
            this.lblPurchaseToday.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblPurchaseToday.ForeColor = System.Drawing.Color.White;
            this.lblPurchaseToday.Location = new System.Drawing.Point(11, 24);
            this.lblPurchaseToday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPurchaseToday.Name = "lblPurchaseToday";
            this.lblPurchaseToday.Size = new System.Drawing.Size(26, 30);
            this.lblPurchaseToday.TabIndex = 1;
            this.lblPurchaseToday.Text = "0";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderRadius = 12;
            this.guna2Panel2.Controls.Add(this.lblPurchaseToday);
            this.guna2Panel2.Controls.Add(this.label8);
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.guna2Panel2.Location = new System.Drawing.Point(818, 177);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(135, 65);
            this.guna2Panel2.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(11, 8);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "مشتريات اليوم";
            // 
            // lblLowStockProducts
            // 
            this.lblLowStockProducts.AutoSize = true;
            this.lblLowStockProducts.BackColor = System.Drawing.Color.Transparent;
            this.lblLowStockProducts.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblLowStockProducts.ForeColor = System.Drawing.Color.White;
            this.lblLowStockProducts.Location = new System.Drawing.Point(11, 24);
            this.lblLowStockProducts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLowStockProducts.Name = "lblLowStockProducts";
            this.lblLowStockProducts.Size = new System.Drawing.Size(26, 30);
            this.lblLowStockProducts.TabIndex = 1;
            this.lblLowStockProducts.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 8);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "منتجات منحفضة المخزون";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 12;
            this.guna2Panel1.Controls.Add(this.lblLowStockProducts);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel1.Location = new System.Drawing.Point(818, 261);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(135, 65);
            this.guna2Panel1.TabIndex = 41;
            // 
            // lblDebtToday
            // 
            this.lblDebtToday.AutoSize = true;
            this.lblDebtToday.BackColor = System.Drawing.Color.Transparent;
            this.lblDebtToday.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblDebtToday.ForeColor = System.Drawing.Color.White;
            this.lblDebtToday.Location = new System.Drawing.Point(11, 24);
            this.lblDebtToday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDebtToday.Name = "lblDebtToday";
            this.lblDebtToday.Size = new System.Drawing.Size(26, 30);
            this.lblDebtToday.TabIndex = 1;
            this.lblDebtToday.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "دبون الموردين لليوم";
            // 
            // cardTotal
            // 
            this.cardTotal.BorderRadius = 12;
            this.cardTotal.Controls.Add(this.lblDebtToday);
            this.cardTotal.Controls.Add(this.label3);
            this.cardTotal.FillColor = System.Drawing.Color.Red;
            this.cardTotal.Location = new System.Drawing.Point(652, 177);
            this.cardTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cardTotal.Name = "cardTotal";
            this.cardTotal.Size = new System.Drawing.Size(135, 65);
            this.cardTotal.TabIndex = 38;
            // 
            // lblMaxPurchaseToday
            // 
            this.lblMaxPurchaseToday.AutoSize = true;
            this.lblMaxPurchaseToday.BackColor = System.Drawing.Color.Transparent;
            this.lblMaxPurchaseToday.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblMaxPurchaseToday.ForeColor = System.Drawing.Color.White;
            this.lblMaxPurchaseToday.Location = new System.Drawing.Point(11, 24);
            this.lblMaxPurchaseToday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaxPurchaseToday.Name = "lblMaxPurchaseToday";
            this.lblMaxPurchaseToday.Size = new System.Drawing.Size(26, 30);
            this.lblMaxPurchaseToday.TabIndex = 1;
            this.lblMaxPurchaseToday.Text = "0";
            // 
            // lnkPrivios
            // 
            this.lnkPrivios.AutoSize = true;
            this.lnkPrivios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lnkPrivios.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lnkPrivios.Location = new System.Drawing.Point(652, 426);
            this.lnkPrivios.Name = "lnkPrivios";
            this.lnkPrivios.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lnkPrivios.Size = new System.Drawing.Size(61, 30);
            this.lnkPrivios.TabIndex = 37;
            this.lnkPrivios.TabStop = true;
            this.lnkPrivios.Text = "السابق";
            this.lnkPrivios.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPrivios_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 8);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "اكبر فاتورة اليوم";
            // 
            // lnkNext
            // 
            this.lnkNext.AutoSize = true;
            this.lnkNext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lnkNext.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lnkNext.Location = new System.Drawing.Point(726, 426);
            this.lnkNext.Name = "lnkNext";
            this.lnkNext.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lnkNext.Size = new System.Drawing.Size(55, 30);
            this.lnkNext.TabIndex = 36;
            this.lnkNext.TabStop = true;
            this.lnkNext.Text = "التالي";
            this.lnkNext.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkNext_LinkClicked);
            // 
            // lblPageNumber
            // 
            this.lblPageNumber.AutoSize = true;
            this.lblPageNumber.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageNumber.Location = new System.Drawing.Point(797, 426);
            this.lblPageNumber.Name = "lblPageNumber";
            this.lblPageNumber.Size = new System.Drawing.Size(49, 30);
            this.lblPageNumber.TabIndex = 35;
            this.lblPageNumber.Text = "1 3 ";
            this.lblPageNumber.TextChanged += new System.EventHandler(this.lblPageNumber_TextChanged);
            // 
            // btnAddNewPurchase
            // 
            this.btnAddNewPurchase.BorderRadius = 15;
            this.btnAddNewPurchase.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.btnAddNewPurchase.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAddNewPurchase.ForeColor = System.Drawing.Color.White;
            this.btnAddNewPurchase.Location = new System.Drawing.Point(13, 407);
            this.btnAddNewPurchase.Name = "btnAddNewPurchase";
            this.btnAddNewPurchase.Size = new System.Drawing.Size(179, 49);
            this.btnAddNewPurchase.TabIndex = 32;
            this.btnAddNewPurchase.Text = "+ إضافة شراء جديد";
            this.btnAddNewPurchase.Click += new System.EventHandler(this.btnAddNewPurchase_Click);
            // 
            // تعديلToolStripMenuItem
            // 
            this.تعديلToolStripMenuItem.Name = "تعديلToolStripMenuItem";
            this.تعديلToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.تعديلToolStripMenuItem.Text = "تعديل";
            this.تعديلToolStripMenuItem.Click += new System.EventHandler(this.تعديلToolStripMenuItem_Click);
            // 
            // cmsSales
            // 
            this.cmsSales.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تعديلToolStripMenuItem});
            this.cmsSales.Name = "cmsSales";
            this.cmsSales.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cmsSales.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmsSales.RenderStyle.ColorTable = null;
            this.cmsSales.RenderStyle.RoundedEdges = true;
            this.cmsSales.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmsSales.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmsSales.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsSales.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmsSales.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmsSales.Size = new System.Drawing.Size(104, 26);
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(69, 148);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(476, 229);
            this.chart.TabIndex = 42;
            this.chart.Text = " ";
            // 
            // cardOutOfStock
            // 
            this.cardOutOfStock.BorderRadius = 12;
            this.cardOutOfStock.Controls.Add(this.lblMaxPurchaseToday);
            this.cardOutOfStock.Controls.Add(this.label5);
            this.cardOutOfStock.FillColor = System.Drawing.Color.Maroon;
            this.cardOutOfStock.Location = new System.Drawing.Point(652, 261);
            this.cardOutOfStock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cardOutOfStock.Name = "cardOutOfStock";
            this.cardOutOfStock.Size = new System.Drawing.Size(135, 65);
            this.cardOutOfStock.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(851, 426);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 34;
            this.label1.Text = "رقم الصفحة :";
            // 
            // dgvPurchaseList
            // 
            this.dgvPurchaseList.AllowUserToAddRows = false;
            this.dgvPurchaseList.AllowUserToDeleteRows = false;
            this.dgvPurchaseList.AllowUserToResizeColumns = false;
            this.dgvPurchaseList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvPurchaseList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPurchaseList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPurchaseList.ColumnHeadersHeight = 35;
            this.dgvPurchaseList.ContextMenuStrip = this.cmsSales;
            this.dgvPurchaseList.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPurchaseList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPurchaseList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvPurchaseList.Location = new System.Drawing.Point(13, 479);
            this.dgvPurchaseList.Name = "dgvPurchaseList";
            this.dgvPurchaseList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvPurchaseList.RowHeadersVisible = false;
            this.dgvPurchaseList.RowHeadersWidth = 51;
            this.dgvPurchaseList.RowTemplate.Height = 30;
            this.dgvPurchaseList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPurchaseList.Size = new System.Drawing.Size(931, 322);
            this.dgvPurchaseList.TabIndex = 33;
            this.dgvPurchaseList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Light;
            this.dgvPurchaseList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvPurchaseList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPurchaseList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPurchaseList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPurchaseList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPurchaseList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvPurchaseList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvPurchaseList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvPurchaseList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPurchaseList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPurchaseList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvPurchaseList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPurchaseList.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvPurchaseList.ThemeStyle.ReadOnly = false;
            this.dgvPurchaseList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPurchaseList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPurchaseList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPurchaseList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvPurchaseList.ThemeStyle.RowsStyle.Height = 30;
            this.dgvPurchaseList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvPurchaseList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // frmPurchasesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(953, 811);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.cardTotal);
            this.Controls.Add(this.lnkPrivios);
            this.Controls.Add(this.lnkNext);
            this.Controls.Add(this.lblPageNumber);
            this.Controls.Add(this.btnAddNewPurchase);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.cardOutOfStock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPurchaseList);
            this.Name = "frmPurchasesList";
            this.Text = "frmPurchasesList";
            this.Load += new System.EventHandler(this.frmPurchasesList_Load);
            this.guna2Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.cardTotal.ResumeLayout(false);
            this.cardTotal.PerformLayout();
            this.cmsSales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.cardOutOfStock.ResumeLayout(false);
            this.cardOutOfStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPurchaseToday;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblLowStockProducts;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblDebtToday;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel cardTotal;
        private System.Windows.Forms.Label lblMaxPurchaseToday;
        private System.Windows.Forms.LinkLabel lnkPrivios;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel lnkNext;
        private System.Windows.Forms.Label lblPageNumber;
        private Guna.UI2.WinForms.Guna2Button btnAddNewPurchase;
        private System.Windows.Forms.ToolStripMenuItem تعديلToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsSales;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private Guna.UI2.WinForms.Guna2Panel cardOutOfStock;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPurchaseList;
    }
}