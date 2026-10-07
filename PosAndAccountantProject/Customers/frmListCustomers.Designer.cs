namespace PosAndAccountantProject.Customers
{
    partial class frmListCustomers
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFilterBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtFilterValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.phoneCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsCustomers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.انشاءفاتورةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvCustomers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnAddCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.pbPersonImage = new System.Windows.Forms.PictureBox();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.lnkPrivios = new System.Windows.Forms.LinkLabel();
            this.lnkNext = new System.Windows.Forms.LinkLabel();
            this.lblPageNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCustomersToday = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDiscountToday = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cardOutOfStock = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCountDebtCustomers = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cardTotal = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDebt = new System.Windows.Forms.Label();
            this.lblTotalDebt = new System.Windows.Forms.Label();
            this.chartProfit = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label7 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.lnkEveryProduct = new System.Windows.Forms.LinkLabel();
            this.lnkMostSold = new System.Windows.Forms.LinkLabel();
            this.lnkMostProfit = new System.Windows.Forms.LinkLabel();
            this.lnkSlowMoving = new System.Windows.Forms.LinkLabel();
            this.lnkDebt = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmsCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.cardOutOfStock.SuspendLayout();
            this.cardTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartProfit)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblRecordsCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.lblRecordsCount.Location = new System.Drawing.Point(167, 756);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(24, 21);
            this.lblRecordsCount.TabIndex = 121;
            this.lblRecordsCount.Text = "??";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(20, 756);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 21);
            this.label2.TabIndex = 120;
            this.label2.Text = "عدد السجلات:";
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.BackColor = System.Drawing.Color.Transparent;
            this.cbFilterBy.BorderRadius = 8;
            this.cbFilterBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterBy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFilterBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFilterBy.ItemHeight = 30;
            this.cbFilterBy.Items.AddRange(new object[] {
            "لا شيء",
            "معرف العميل",
            "اسم لعمبل",
            "المديونين"});
            this.cbFilterBy.Location = new System.Drawing.Point(406, 375);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(160, 36);
            this.cbFilterBy.StartIndex = 0;
            this.cbFilterBy.TabIndex = 119;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.BorderRadius = 8;
            this.txtFilterValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterValue.DefaultText = "";
            this.txtFilterValue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilterValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFilterValue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilterValue.Location = new System.Drawing.Point(572, 375);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.PlaceholderText = "ابحث هنا...";
            this.txtFilterValue.SelectedText = "";
            this.txtFilterValue.Size = new System.Drawing.Size(168, 36);
            this.txtFilterValue.TabIndex = 118;
            this.txtFilterValue.Visible = false;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            // 
            // phoneCallToolStripMenuItem
            // 
            this.phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            this.phoneCallToolStripMenuItem.Size = new System.Drawing.Size(195, 38);
            this.phoneCallToolStripMenuItem.Text = "اتصال هاتف";
            this.phoneCallToolStripMenuItem.Click += new System.EventHandler(this.phoneCallToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(192, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(195, 38);
            this.deleteToolStripMenuItem.Text = "حذف";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(195, 38);
            this.editToolStripMenuItem.Text = "تعديل";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(195, 38);
            this.toolStripMenuItem1.Text = "إضافة عميل جديد";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(192, 6);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(195, 38);
            this.showDetailsToolStripMenuItem.Text = "عرض التفاصيل";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // cmsCustomers
            // 
            this.cmsCustomers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmsCustomers.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsCustomers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.toolStripSeparator2,
            this.toolStripMenuItem1,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator1,
            this.phoneCallToolStripMenuItem,
            this.toolStripMenuItem2,
            this.انشاءفاتورةToolStripMenuItem});
            this.cmsCustomers.Name = "cmsUsers";
            this.cmsCustomers.Size = new System.Drawing.Size(196, 250);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(192, 6);
            // 
            // انشاءفاتورةToolStripMenuItem
            // 
            this.انشاءفاتورةToolStripMenuItem.Image = global::PosAndAccountantProject.Properties.Resources.MakeOrder;
            this.انشاءفاتورةToolStripMenuItem.Name = "انشاءفاتورةToolStripMenuItem";
            this.انشاءفاتورةToolStripMenuItem.Size = new System.Drawing.Size(195, 38);
            this.انشاءفاتورةToolStripMenuItem.Text = "انشاء فاتورة";
            this.انشاءفاتورةToolStripMenuItem.Click += new System.EventHandler(this.انشاءفاتورةToolStripMenuItem_Click);
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvCustomers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCustomers.ColumnHeadersHeight = 40;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCustomers.ContextMenuStrip = this.cmsCustomers;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCustomers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCustomers.Location = new System.Drawing.Point(9, 419);
            this.dgvCustomers.MultiSelect = false;
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvCustomers.RowHeadersVisible = false;
            this.dgvCustomers.RowHeadersWidth = 51;
            this.dgvCustomers.RowTemplate.Height = 35;
            this.dgvCustomers.Size = new System.Drawing.Size(926, 334);
            this.dgvCustomers.TabIndex = 116;
            this.dgvCustomers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCustomers.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCustomers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCustomers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCustomers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCustomers.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvCustomers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCustomers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.dgvCustomers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCustomers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.dgvCustomers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCustomers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCustomers.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvCustomers.ThemeStyle.ReadOnly = true;
            this.dgvCustomers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCustomers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCustomers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvCustomers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCustomers.ThemeStyle.RowsStyle.Height = 35;
            this.dgvCustomers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCustomers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Animated = true;
            this.btnAddCustomer.BorderRadius = 10;
            this.btnAddCustomer.BorderThickness = 1;
            this.btnAddCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCustomer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddCustomer.FillColor = System.Drawing.Color.Transparent;
            this.btnAddCustomer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAddCustomer.ForeColor = System.Drawing.Color.YellowGreen;
            this.btnAddCustomer.Image = global::PosAndAccountantProject.Properties.Resources.addCustomer;
            this.btnAddCustomer.ImageSize = new System.Drawing.Size(32, 32);
            this.btnAddCustomer.Location = new System.Drawing.Point(838, 379);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(87, 32);
            this.btnAddCustomer.TabIndex = 127;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // pbPersonImage
            // 
            this.pbPersonImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPersonImage.Image = global::PosAndAccountantProject.Properties.Resources.Customers;
            this.pbPersonImage.Location = new System.Drawing.Point(315, 0);
            this.pbPersonImage.Name = "pbPersonImage";
            this.pbPersonImage.Size = new System.Drawing.Size(272, 122);
            this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersonImage.TabIndex = 122;
            this.pbPersonImage.TabStop = false;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel3.Controls.Add(this.pbPersonImage);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(953, 128);
            this.guna2Panel3.TabIndex = 129;
            // 
            // lnkPrivios
            // 
            this.lnkPrivios.AutoSize = true;
            this.lnkPrivios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lnkPrivios.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lnkPrivios.Location = new System.Drawing.Point(207, 369);
            this.lnkPrivios.Name = "lnkPrivios";
            this.lnkPrivios.Padding = new System.Windows.Forms.Padding(4);
            this.lnkPrivios.Size = new System.Drawing.Size(61, 30);
            this.lnkPrivios.TabIndex = 133;
            this.lnkPrivios.TabStop = true;
            this.lnkPrivios.Text = "السابق";
            this.lnkPrivios.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPrivios_LinkClicked);
            // 
            // lnkNext
            // 
            this.lnkNext.AutoSize = true;
            this.lnkNext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lnkNext.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lnkNext.Location = new System.Drawing.Point(146, 369);
            this.lnkNext.Name = "lnkNext";
            this.lnkNext.Padding = new System.Windows.Forms.Padding(4);
            this.lnkNext.Size = new System.Drawing.Size(55, 30);
            this.lnkNext.TabIndex = 132;
            this.lnkNext.TabStop = true;
            this.lnkNext.Text = "التالي";
            this.lnkNext.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkNext_LinkClicked);
            // 
            // lblPageNumber
            // 
            this.lblPageNumber.AutoSize = true;
            this.lblPageNumber.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageNumber.Location = new System.Drawing.Point(98, 371);
            this.lblPageNumber.Name = "lblPageNumber";
            this.lblPageNumber.Size = new System.Drawing.Size(25, 30);
            this.lblPageNumber.TabIndex = 131;
            this.lblPageNumber.Text = "1";
            this.lblPageNumber.TextChanged += new System.EventHandler(this.lblPageNumber_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 379);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 130;
            this.label3.Text = "رقم الصفحة :";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 12;
            this.guna2Panel1.Controls.Add(this.lblCustomersToday);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 253);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(135, 65);
            this.guna2Panel1.TabIndex = 137;
            // 
            // lblCustomersToday
            // 
            this.lblCustomersToday.AutoSize = true;
            this.lblCustomersToday.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomersToday.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblCustomersToday.ForeColor = System.Drawing.Color.White;
            this.lblCustomersToday.Location = new System.Drawing.Point(11, 24);
            this.lblCustomersToday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomersToday.Name = "lblCustomersToday";
            this.lblCustomersToday.Size = new System.Drawing.Size(26, 30);
            this.lblCustomersToday.TabIndex = 1;
            this.lblCustomersToday.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(17, 6);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "عدد الزبائن لليوم";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderRadius = 12;
            this.guna2Panel2.Controls.Add(this.lblDiscountToday);
            this.guna2Panel2.Controls.Add(this.label8);
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.guna2Panel2.Location = new System.Drawing.Point(163, 253);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(135, 65);
            this.guna2Panel2.TabIndex = 136;
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
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(11, 8);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "حسومات اللزبائن اليوم";
            // 
            // cardOutOfStock
            // 
            this.cardOutOfStock.BorderRadius = 12;
            this.cardOutOfStock.Controls.Add(this.lblCountDebtCustomers);
            this.cardOutOfStock.Controls.Add(this.label5);
            this.cardOutOfStock.FillColor = System.Drawing.Color.Gray;
            this.cardOutOfStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cardOutOfStock.Location = new System.Drawing.Point(163, 169);
            this.cardOutOfStock.Margin = new System.Windows.Forms.Padding(2);
            this.cardOutOfStock.Name = "cardOutOfStock";
            this.cardOutOfStock.Size = new System.Drawing.Size(135, 65);
            this.cardOutOfStock.TabIndex = 135;
            // 
            // lblCountDebtCustomers
            // 
            this.lblCountDebtCustomers.AutoSize = true;
            this.lblCountDebtCustomers.BackColor = System.Drawing.Color.Transparent;
            this.lblCountDebtCustomers.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblCountDebtCustomers.ForeColor = System.Drawing.Color.White;
            this.lblCountDebtCustomers.Location = new System.Drawing.Point(11, 24);
            this.lblCountDebtCustomers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCountDebtCustomers.Name = "lblCountDebtCustomers";
            this.lblCountDebtCustomers.Size = new System.Drawing.Size(19, 30);
            this.lblCountDebtCustomers.TabIndex = 1;
            this.lblCountDebtCustomers.Text = " ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 6);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "عدد الزبائن المتدينين";
            // 
            // cardTotal
            // 
            this.cardTotal.BorderRadius = 12;
            this.cardTotal.Controls.Add(this.lblDebt);
            this.cardTotal.Controls.Add(this.lblTotalDebt);
            this.cardTotal.FillColor = System.Drawing.Color.Red;
            this.cardTotal.Location = new System.Drawing.Point(0, 169);
            this.cardTotal.Margin = new System.Windows.Forms.Padding(2);
            this.cardTotal.Name = "cardTotal";
            this.cardTotal.Size = new System.Drawing.Size(135, 65);
            this.cardTotal.TabIndex = 134;
            // 
            // lblDebt
            // 
            this.lblDebt.AutoSize = true;
            this.lblDebt.BackColor = System.Drawing.Color.Transparent;
            this.lblDebt.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblDebt.ForeColor = System.Drawing.Color.White;
            this.lblDebt.Location = new System.Drawing.Point(11, 24);
            this.lblDebt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDebt.Name = "lblDebt";
            this.lblDebt.Size = new System.Drawing.Size(26, 30);
            this.lblDebt.TabIndex = 1;
            this.lblDebt.Text = "0";
            // 
            // lblTotalDebt
            // 
            this.lblTotalDebt.AutoSize = true;
            this.lblTotalDebt.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalDebt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDebt.ForeColor = System.Drawing.Color.White;
            this.lblTotalDebt.Location = new System.Drawing.Point(12, 6);
            this.lblTotalDebt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalDebt.Name = "lblTotalDebt";
            this.lblTotalDebt.Size = new System.Drawing.Size(112, 17);
            this.lblTotalDebt.TabIndex = 0;
            this.lblTotalDebt.Text = "اجمالي ديون الزبائن";
            // 
            // chartProfit
            // 
            chartArea1.Name = "ChartArea1";
            this.chartProfit.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartProfit.Legends.Add(legend1);
            this.chartProfit.Location = new System.Drawing.Point(509, 155);
            this.chartProfit.Name = "chartProfit";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartProfit.Series.Add(series1);
            this.chartProfit.Size = new System.Drawing.Size(416, 199);
            this.chartProfit.TabIndex = 138;
            this.chartProfit.Text = "chart1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(327, 379);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 140;
            this.label7.Text = "البحث عبر:";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.Location = new System.Drawing.Point(24, 359);
            this.guna2Separator1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(913, 8);
            this.guna2Separator1.TabIndex = 141;
            // 
            // lnkEveryProduct
            // 
            this.lnkEveryProduct.AutoSize = true;
            this.lnkEveryProduct.BackColor = System.Drawing.Color.Silver;
            this.lnkEveryProduct.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lnkEveryProduct.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkEveryProduct.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lnkEveryProduct.Location = new System.Drawing.Point(395, 232);
            this.lnkEveryProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkEveryProduct.Name = "lnkEveryProduct";
            this.lnkEveryProduct.Size = new System.Drawing.Size(71, 19);
            this.lnkEveryProduct.TabIndex = 147;
            this.lnkEveryProduct.TabStop = true;
            this.lnkEveryProduct.Text = "كل الزبائن ";
            this.lnkEveryProduct.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEveryProduct_LinkClicked);
            // 
            // lnkMostSold
            // 
            this.lnkMostSold.AutoSize = true;
            this.lnkMostSold.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lnkMostSold.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkMostSold.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lnkMostSold.Location = new System.Drawing.Point(318, 290);
            this.lnkMostSold.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkMostSold.Name = "lnkMostSold";
            this.lnkMostSold.Size = new System.Drawing.Size(86, 19);
            this.lnkMostSold.TabIndex = 142;
            this.lnkMostSold.TabStop = true;
            this.lnkMostSold.Text = "الأكثر مبيعاً ↑";
            this.lnkMostSold.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkMostSold_LinkClicked);
            // 
            // lnkMostProfit
            // 
            this.lnkMostProfit.AutoSize = true;
            this.lnkMostProfit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lnkMostProfit.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkMostProfit.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lnkMostProfit.Location = new System.Drawing.Point(402, 290);
            this.lnkMostProfit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkMostProfit.Name = "lnkMostProfit";
            this.lnkMostProfit.Size = new System.Drawing.Size(80, 19);
            this.lnkMostProfit.TabIndex = 143;
            this.lnkMostProfit.TabStop = true;
            this.lnkMostProfit.Text = "الأكثر ربحاً $";
            this.lnkMostProfit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkMostProfit_LinkClicked);
            // 
            // lnkSlowMoving
            // 
            this.lnkSlowMoving.AutoSize = true;
            this.lnkSlowMoving.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lnkSlowMoving.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkSlowMoving.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lnkSlowMoving.Location = new System.Drawing.Point(318, 232);
            this.lnkSlowMoving.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkSlowMoving.Name = "lnkSlowMoving";
            this.lnkSlowMoving.Size = new System.Drawing.Size(83, 19);
            this.lnkSlowMoving.TabIndex = 144;
            this.lnkSlowMoving.TabStop = true;
            this.lnkSlowMoving.Text = "الأقل مبيعاً ↓";
            this.lnkSlowMoving.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSlowMoving_LinkClicked);
            // 
            // lnkDebt
            // 
            this.lnkDebt.AutoSize = true;
            this.lnkDebt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lnkDebt.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkDebt.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.lnkDebt.Location = new System.Drawing.Point(395, 259);
            this.lnkDebt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkDebt.Name = "lnkDebt";
            this.lnkDebt.Size = new System.Drawing.Size(74, 19);
            this.lnkDebt.TabIndex = 145;
            this.lnkDebt.TabStop = true;
            this.lnkDebt.Text = "عليهم ديون";
            this.lnkDebt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLowStock_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(315, 263);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 146;
            this.label1.Text = "تقارير سريعة :";
            // 
            // frmListCustomers
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(953, 786);
            this.Controls.Add(this.lnkEveryProduct);
            this.Controls.Add(this.lnkMostSold);
            this.Controls.Add(this.lnkMostProfit);
            this.Controls.Add(this.lnkSlowMoving);
            this.Controls.Add(this.lnkDebt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chartProfit);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.cardOutOfStock);
            this.Controls.Add(this.cardTotal);
            this.Controls.Add(this.lnkPrivios);
            this.Controls.Add(this.lnkNext);
            this.Controls.Add(this.lblPageNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.dgvCustomers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmListCustomers";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Load += new System.EventHandler(this.frmListCustomers_Load);
            this.cmsCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.cardOutOfStock.ResumeLayout(false);
            this.cardOutOfStock.PerformLayout();
            this.cardTotal.ResumeLayout(false);
            this.cardTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartProfit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.PictureBox pbPersonImage;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterBy;
        private Guna.UI2.WinForms.Guna2TextBox txtFilterValue;
        private System.Windows.Forms.ToolStripMenuItem phoneCallToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsCustomers;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCustomers;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem انشاءفاتورةToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Button btnAddCustomer;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.LinkLabel lnkPrivios;
        private System.Windows.Forms.LinkLabel lnkNext;
        private System.Windows.Forms.Label lblPageNumber;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblCustomersToday;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label lblDiscountToday;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Panel cardOutOfStock;
        private System.Windows.Forms.Label lblCountDebtCustomers;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Panel cardTotal;
        private System.Windows.Forms.Label lblDebt;
        private System.Windows.Forms.Label lblTotalDebt;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProfit;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.LinkLabel lnkEveryProduct;
        private System.Windows.Forms.LinkLabel lnkMostSold;
        private System.Windows.Forms.LinkLabel lnkMostProfit;
        private System.Windows.Forms.LinkLabel lnkSlowMoving;
        private System.Windows.Forms.LinkLabel lnkDebt;
        private System.Windows.Forms.Label label1;
    }
        #endregion
}

