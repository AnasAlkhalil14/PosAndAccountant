namespace PosAndAccountantProject.Sales
{
    partial class frmSalesList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSalesList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmsSales = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.تعديلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddNewSale = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPageNumber = new System.Windows.Forms.Label();
            this.lnkNext = new System.Windows.Forms.LinkLabel();
            this.lnkPrivios = new System.Windows.Forms.LinkLabel();
            this.cardOutOfStock = new Guna.UI2.WinForms.Guna2Panel();
            this.lblMaxTotalSaleToday = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cardTotal = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDebtToday = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblProfitToday = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDiscountToday = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chartProfit = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesList)).BeginInit();
            this.cmsSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.cardOutOfStock.SuspendLayout();
            this.cardTotal.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartProfit)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(859, 416);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = ":رقم الصفحة";
            // 
            // dgvSalesList
            // 
            this.dgvSalesList.AllowUserToAddRows = false;
            this.dgvSalesList.AllowUserToDeleteRows = false;
            this.dgvSalesList.AllowUserToResizeColumns = false;
            this.dgvSalesList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvSalesList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalesList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSalesList.ColumnHeadersHeight = 35;
            this.dgvSalesList.ContextMenuStrip = this.cmsSales;
            this.dgvSalesList.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSalesList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSalesList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvSalesList.Location = new System.Drawing.Point(21, 469);
            this.dgvSalesList.Name = "dgvSalesList";
            this.dgvSalesList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvSalesList.RowHeadersVisible = false;
            this.dgvSalesList.RowHeadersWidth = 51;
            this.dgvSalesList.RowTemplate.Height = 30;
            this.dgvSalesList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvSalesList.Size = new System.Drawing.Size(931, 322);
            this.dgvSalesList.TabIndex = 17;
            this.dgvSalesList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Light;
            this.dgvSalesList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvSalesList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvSalesList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvSalesList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvSalesList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvSalesList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvSalesList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvSalesList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvSalesList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSalesList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSalesList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvSalesList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSalesList.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvSalesList.ThemeStyle.ReadOnly = false;
            this.dgvSalesList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSalesList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSalesList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSalesList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvSalesList.ThemeStyle.RowsStyle.Height = 30;
            this.dgvSalesList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvSalesList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
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
            // تعديلToolStripMenuItem
            // 
            this.تعديلToolStripMenuItem.Name = "تعديلToolStripMenuItem";
            this.تعديلToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.تعديلToolStripMenuItem.Text = "تعديل";
            this.تعديلToolStripMenuItem.Click += new System.EventHandler(this.تعديلToolStripMenuItem_Click);
            // 
            // btnAddNewSale
            // 
            this.btnAddNewSale.BorderRadius = 15;
            this.btnAddNewSale.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.btnAddNewSale.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAddNewSale.ForeColor = System.Drawing.Color.White;
            this.btnAddNewSale.Location = new System.Drawing.Point(21, 397);
            this.btnAddNewSale.Name = "btnAddNewSale";
            this.btnAddNewSale.Size = new System.Drawing.Size(171, 49);
            this.btnAddNewSale.TabIndex = 16;
            this.btnAddNewSale.Text = "+ إضافة بيع جديد";
            this.btnAddNewSale.Click += new System.EventHandler(this.btnAddNewSale_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PosAndAccountantProject.Properties.Resources.SaleList2;
            this.pictureBox1.Location = new System.Drawing.Point(362, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // lblPageNumber
            // 
            this.lblPageNumber.AutoSize = true;
            this.lblPageNumber.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageNumber.Location = new System.Drawing.Point(805, 416);
            this.lblPageNumber.Name = "lblPageNumber";
            this.lblPageNumber.Size = new System.Drawing.Size(49, 30);
            this.lblPageNumber.TabIndex = 22;
            this.lblPageNumber.Text = "1 3 ";
            this.lblPageNumber.TextChanged += new System.EventHandler(this.lblPageNumber_TextChanged);
            // 
            // lnkNext
            // 
            this.lnkNext.AutoSize = true;
            this.lnkNext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lnkNext.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lnkNext.Location = new System.Drawing.Point(734, 416);
            this.lnkNext.Name = "lnkNext";
            this.lnkNext.Padding = new System.Windows.Forms.Padding(4);
            this.lnkNext.Size = new System.Drawing.Size(55, 30);
            this.lnkNext.TabIndex = 23;
            this.lnkNext.TabStop = true;
            this.lnkNext.Text = "التالي";
            this.lnkNext.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkNext_LinkClicked);
            // 
            // lnkPrivios
            // 
            this.lnkPrivios.AutoSize = true;
            this.lnkPrivios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lnkPrivios.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lnkPrivios.Location = new System.Drawing.Point(660, 416);
            this.lnkPrivios.Name = "lnkPrivios";
            this.lnkPrivios.Padding = new System.Windows.Forms.Padding(4);
            this.lnkPrivios.Size = new System.Drawing.Size(61, 30);
            this.lnkPrivios.TabIndex = 24;
            this.lnkPrivios.TabStop = true;
            this.lnkPrivios.Text = "السابق";
            this.lnkPrivios.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPrivios_LinkClicked);
            // 
            // cardOutOfStock
            // 
            this.cardOutOfStock.BorderRadius = 12;
            this.cardOutOfStock.Controls.Add(this.lblMaxTotalSaleToday);
            this.cardOutOfStock.Controls.Add(this.label5);
            this.cardOutOfStock.FillColor = System.Drawing.Color.Gray;
            this.cardOutOfStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cardOutOfStock.Location = new System.Drawing.Point(823, 167);
            this.cardOutOfStock.Margin = new System.Windows.Forms.Padding(2);
            this.cardOutOfStock.Name = "cardOutOfStock";
            this.cardOutOfStock.Size = new System.Drawing.Size(135, 65);
            this.cardOutOfStock.TabIndex = 26;
            // 
            // lblMaxTotalSaleToday
            // 
            this.lblMaxTotalSaleToday.AutoSize = true;
            this.lblMaxTotalSaleToday.BackColor = System.Drawing.Color.Transparent;
            this.lblMaxTotalSaleToday.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblMaxTotalSaleToday.ForeColor = System.Drawing.Color.White;
            this.lblMaxTotalSaleToday.Location = new System.Drawing.Point(11, 24);
            this.lblMaxTotalSaleToday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaxTotalSaleToday.Name = "lblMaxTotalSaleToday";
            this.lblMaxTotalSaleToday.Size = new System.Drawing.Size(26, 30);
            this.lblMaxTotalSaleToday.TabIndex = 1;
            this.lblMaxTotalSaleToday.Text = "0";
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
            // cardTotal
            // 
            this.cardTotal.BorderRadius = 12;
            this.cardTotal.Controls.Add(this.lblDebtToday);
            this.cardTotal.Controls.Add(this.label3);
            this.cardTotal.FillColor = System.Drawing.Color.Red;
            this.cardTotal.Location = new System.Drawing.Point(660, 167);
            this.cardTotal.Margin = new System.Windows.Forms.Padding(2);
            this.cardTotal.Name = "cardTotal";
            this.cardTotal.Size = new System.Drawing.Size(135, 65);
            this.cardTotal.TabIndex = 25;
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
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "دبون الزبائن لليوم";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 12;
            this.guna2Panel1.Controls.Add(this.lblProfitToday);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.guna2Panel1.Location = new System.Drawing.Point(660, 251);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(135, 65);
            this.guna2Panel1.TabIndex = 28;
            // 
            // lblProfitToday
            // 
            this.lblProfitToday.AutoSize = true;
            this.lblProfitToday.BackColor = System.Drawing.Color.Transparent;
            this.lblProfitToday.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblProfitToday.ForeColor = System.Drawing.Color.White;
            this.lblProfitToday.Location = new System.Drawing.Point(11, 24);
            this.lblProfitToday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProfitToday.Name = "lblProfitToday";
            this.lblProfitToday.Size = new System.Drawing.Size(26, 30);
            this.lblProfitToday.TabIndex = 1;
            this.lblProfitToday.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(32, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "ارباح اليوم";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderRadius = 12;
            this.guna2Panel2.Controls.Add(this.lblDiscountToday);
            this.guna2Panel2.Controls.Add(this.label8);
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.guna2Panel2.Location = new System.Drawing.Point(823, 251);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(135, 65);
            this.guna2Panel2.TabIndex = 27;
            // 
            // lblDiscountToday
            // 
            this.lblDiscountToday.AutoSize = true;
            this.lblDiscountToday.BackColor = System.Drawing.Color.Transparent;
            this.lblDiscountToday.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblDiscountToday.ForeColor = System.Drawing.Color.White;
            this.lblDiscountToday.Location = new System.Drawing.Point(11, 24);
            this.lblDiscountToday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiscountToday.Name = "lblDiscountToday";
            this.lblDiscountToday.Size = new System.Drawing.Size(26, 30);
            this.lblDiscountToday.TabIndex = 1;
            this.lblDiscountToday.Text = "0";
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
            this.label8.Size = new System.Drawing.Size(116, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "حسومات اللزبائن اليوم";
            // 
            // chartProfit
            // 
            chartArea1.Name = "ChartArea1";
            this.chartProfit.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartProfit.Legends.Add(legend1);
            this.chartProfit.Location = new System.Drawing.Point(133, 146);
            this.chartProfit.Name = "chartProfit";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartProfit.Series.Add(series1);
            this.chartProfit.Size = new System.Drawing.Size(476, 229);
            this.chartProfit.TabIndex = 30;
            this.chartProfit.Text = "chart1";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel3.Controls.Add(this.pictureBox1);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(980, 128);
            this.guna2Panel3.TabIndex = 31;
            // 
            // frmSalesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(980, 803);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.chartProfit);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.cardOutOfStock);
            this.Controls.Add(this.cardTotal);
            this.Controls.Add(this.lnkPrivios);
            this.Controls.Add(this.lnkNext);
            this.Controls.Add(this.lblPageNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSalesList);
            this.Controls.Add(this.btnAddNewSale);
            this.Name = "frmSalesList";
            this.Text = "frmSalesList";
            this.Load += new System.EventHandler(this.frmSalesList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesList)).EndInit();
            this.cmsSales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.cardOutOfStock.ResumeLayout(false);
            this.cardOutOfStock.PerformLayout();
            this.cardTotal.ResumeLayout(false);
            this.cardTotal.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartProfit)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvSalesList;
        private Guna.UI2.WinForms.Guna2Button btnAddNewSale;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPageNumber;
        private System.Windows.Forms.LinkLabel lnkNext;
        private System.Windows.Forms.LinkLabel lnkPrivios;
        private Guna.UI2.WinForms.Guna2Panel cardOutOfStock;
        private System.Windows.Forms.Label lblMaxTotalSaleToday;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Panel cardTotal;
        private System.Windows.Forms.Label lblDebtToday;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblProfitToday;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label lblDiscountToday;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsSales;
        private System.Windows.Forms.ToolStripMenuItem تعديلToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProfit;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
    }
}