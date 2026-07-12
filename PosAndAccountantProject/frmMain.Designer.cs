namespace PosAndAccountantProject
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tcMain = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabDashboard = new System.Windows.Forms.TabPage();
            this.lblInvoices = new System.Windows.Forms.Label();
            this.lblLowStock = new System.Windows.Forms.Label();
            this.dgvRecentInvoices = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvLowStock = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlUsersCard = new Guna.UI2.WinForms.Guna2Panel();
            this.lblActiveUsersVal = new System.Windows.Forms.Label();
            this.lblActiveUsers = new System.Windows.Forms.Label();
            this.pnlOrdersCard = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTotalOrdersVal = new System.Windows.Forms.Label();
            this.lblTotalOrders = new System.Windows.Forms.Label();
            this.pnlCashCard = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCashBalanceVal = new System.Windows.Forms.Label();
            this.lblCashBalance = new System.Windows.Forms.Label();
            this.pnlSalesCard = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTodaySalesVal = new System.Windows.Forms.Label();
            this.lblTodaySales = new System.Windows.Forms.Label();
            this.tabSales = new System.Windows.Forms.TabPage();
            this.btnListSales = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNewSale = new Guna.UI2.WinForms.Guna2Button();
            this.tabPurchases = new System.Windows.Forms.TabPage();
            this.btnListPurchases = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNewPurchase = new Guna.UI2.WinForms.Guna2Button();
            this.tabProducts = new System.Windows.Forms.TabPage();
            this.btnListProducts = new Guna.UI2.WinForms.Guna2Button();
            this.btnListCategories = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNewProduct = new Guna.UI2.WinForms.Guna2Button();
            this.tabCustomers = new System.Windows.Forms.TabPage();
            this.btnAddNewCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.btnListCustomers = new Guna.UI2.WinForms.Guna2Button();
            this.tabSuppliers = new System.Windows.Forms.TabPage();
            this.btnAddNewSupplier = new Guna.UI2.WinForms.Guna2Button();
            this.btnListSuppliers = new Guna.UI2.WinForms.Guna2Button();
            this.tabReports = new System.Windows.Forms.TabPage();
            this.btnImportantReports = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomUsingAi = new Guna.UI2.WinForms.Guna2Button();
            this.tabPartners = new System.Windows.Forms.TabPage();
            this.btnWithdrawDeposit = new Guna.UI2.WinForms.Guna2Button();
            this.btnListPartners = new Guna.UI2.WinForms.Guna2Button();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.btnAddNewUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnListUsers = new Guna.UI2.WinForms.Guna2Button();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.btnGeneralSettings = new Guna.UI2.WinForms.Guna2Button();
            this.btnBackupRestore = new Guna.UI2.WinForms.Guna2Button();
            this.btnCurrentUserInfo = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.tcMain.SuspendLayout();
            this.tabDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLowStock)).BeginInit();
            this.pnlUsersCard.SuspendLayout();
            this.pnlOrdersCard.SuspendLayout();
            this.pnlCashCard.SuspendLayout();
            this.pnlSalesCard.SuspendLayout();
            this.tabSales.SuspendLayout();
            this.tabPurchases.SuspendLayout();
            this.tabProducts.SuspendLayout();
            this.tabCustomers.SuspendLayout();
            this.tabSuppliers.SuspendLayout();
            this.tabReports.SuspendLayout();
            this.tabPartners.SuspendLayout();
            this.tabUsers.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tcMain.Controls.Add(this.tabDashboard);
            this.tcMain.Controls.Add(this.tabSales);
            this.tcMain.Controls.Add(this.tabPurchases);
            this.tcMain.Controls.Add(this.tabProducts);
            this.tcMain.Controls.Add(this.tabCustomers);
            this.tcMain.Controls.Add(this.tabSuppliers);
            this.tcMain.Controls.Add(this.tabReports);
            this.tcMain.Controls.Add(this.tabPartners);
            this.tcMain.Controls.Add(this.tabUsers);
            this.tcMain.Controls.Add(this.tabSettings);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.ItemSize = new System.Drawing.Size(180, 40);
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tcMain.RightToLeftLayout = true;
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(1184, 761);
            this.tcMain.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tcMain.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcMain.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.tcMain.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tcMain.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcMain.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tcMain.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcMain.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.tcMain.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tcMain.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcMain.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tcMain.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tcMain.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.tcMain.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tcMain.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tcMain.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tcMain.TabIndex = 0;
            this.tcMain.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcMain.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.VerticalRight;
            // 
            // tabDashboard
            // 
            this.tabDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.tabDashboard.Controls.Add(this.lblInvoices);
            this.tabDashboard.Controls.Add(this.lblLowStock);
            this.tabDashboard.Controls.Add(this.dgvRecentInvoices);
            this.tabDashboard.Controls.Add(this.dgvLowStock);
            this.tabDashboard.Controls.Add(this.pnlUsersCard);
            this.tabDashboard.Controls.Add(this.pnlOrdersCard);
            this.tabDashboard.Controls.Add(this.pnlCashCard);
            this.tabDashboard.Controls.Add(this.pnlSalesCard);
            this.tabDashboard.Location = new System.Drawing.Point(4, 4);
            this.tabDashboard.Name = "tabDashboard";
            this.tabDashboard.Padding = new System.Windows.Forms.Padding(3);
            this.tabDashboard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabDashboard.Size = new System.Drawing.Size(996, 753);
            this.tabDashboard.TabIndex = 0;
            this.tabDashboard.Text = "Dashboard";
            // 
            // lblInvoices
            // 
            this.lblInvoices.AutoSize = true;
            this.lblInvoices.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoices.Location = new System.Drawing.Point(35, 169);
            this.lblInvoices.Name = "lblInvoices";
            this.lblInvoices.Size = new System.Drawing.Size(96, 21);
            this.lblInvoices.TabIndex = 7;
            this.lblInvoices.Text = "أحدث الفواتير";
            // 
            // lblLowStock
            // 
            this.lblLowStock.AutoSize = true;
            this.lblLowStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowStock.Location = new System.Drawing.Point(525, 169);
            this.lblLowStock.Name = "lblLowStock";
            this.lblLowStock.Size = new System.Drawing.Size(172, 21);
            this.lblLowStock.TabIndex = 6;
            this.lblLowStock.Text = "منتجات منخفضة المخزون";
            // 
            // dgvRecentInvoices
            // 
            this.dgvRecentInvoices.AllowUserToAddRows = false;
            this.dgvRecentInvoices.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvRecentInvoices.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecentInvoices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRecentInvoices.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecentInvoices.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRecentInvoices.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvRecentInvoices.Location = new System.Drawing.Point(39, 203);
            this.dgvRecentInvoices.Name = "dgvRecentInvoices";
            this.dgvRecentInvoices.ReadOnly = true;
            this.dgvRecentInvoices.RowHeadersVisible = false;
            this.dgvRecentInvoices.Size = new System.Drawing.Size(450, 520);
            this.dgvRecentInvoices.TabIndex = 5;
            this.dgvRecentInvoices.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvRecentInvoices.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvRecentInvoices.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvRecentInvoices.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvRecentInvoices.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvRecentInvoices.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvRecentInvoices.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvRecentInvoices.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvRecentInvoices.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRecentInvoices.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRecentInvoices.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvRecentInvoices.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRecentInvoices.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvRecentInvoices.ThemeStyle.ReadOnly = true;
            this.dgvRecentInvoices.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvRecentInvoices.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRecentInvoices.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRecentInvoices.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvRecentInvoices.ThemeStyle.RowsStyle.Height = 22;
            this.dgvRecentInvoices.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvRecentInvoices.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dgvLowStock
            // 
            this.dgvLowStock.AllowUserToAddRows = false;
            this.dgvLowStock.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvLowStock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLowStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvLowStock.ColumnHeadersHeight = 30;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLowStock.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvLowStock.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLowStock.Location = new System.Drawing.Point(512, 203);
            this.dgvLowStock.Name = "dgvLowStock";
            this.dgvLowStock.ReadOnly = true;
            this.dgvLowStock.RowHeadersVisible = false;
            this.dgvLowStock.Size = new System.Drawing.Size(450, 520);
            this.dgvLowStock.TabIndex = 4;
            this.dgvLowStock.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLowStock.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvLowStock.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvLowStock.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvLowStock.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvLowStock.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvLowStock.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLowStock.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgvLowStock.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvLowStock.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLowStock.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvLowStock.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLowStock.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvLowStock.ThemeStyle.ReadOnly = true;
            this.dgvLowStock.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLowStock.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLowStock.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLowStock.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvLowStock.ThemeStyle.RowsStyle.Height = 22;
            this.dgvLowStock.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLowStock.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // pnlUsersCard
            // 
            this.pnlUsersCard.BackColor = System.Drawing.Color.Transparent;
            this.pnlUsersCard.BorderRadius = 10;
            this.pnlUsersCard.Controls.Add(this.lblActiveUsersVal);
            this.pnlUsersCard.Controls.Add(this.lblActiveUsers);
            this.pnlUsersCard.FillColor = System.Drawing.Color.White;
            this.pnlUsersCard.Location = new System.Drawing.Point(39, 25);
            this.pnlUsersCard.Name = "pnlUsersCard";
            this.pnlUsersCard.ShadowDecoration.Enabled = true;
            this.pnlUsersCard.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2, 2, 5, 5);
            this.pnlUsersCard.Size = new System.Drawing.Size(205, 115);
            this.pnlUsersCard.TabIndex = 3;
            // 
            // lblActiveUsersVal
            // 
            this.lblActiveUsersVal.AutoSize = true;
            this.lblActiveUsersVal.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveUsersVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.lblActiveUsersVal.Location = new System.Drawing.Point(20, 50);
            this.lblActiveUsersVal.Name = "lblActiveUsersVal";
            this.lblActiveUsersVal.Size = new System.Drawing.Size(49, 37);
            this.lblActiveUsersVal.TabIndex = 1;
            this.lblActiveUsersVal.Text = "12";
            // 
            // lblActiveUsers
            // 
            this.lblActiveUsers.AutoSize = true;
            this.lblActiveUsers.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveUsers.ForeColor = System.Drawing.Color.Gray;
            this.lblActiveUsers.Location = new System.Drawing.Point(23, 20);
            this.lblActiveUsers.Name = "lblActiveUsers";
            this.lblActiveUsers.Size = new System.Drawing.Size(145, 20);
            this.lblActiveUsers.TabIndex = 0;
            this.lblActiveUsers.Text = "المستخدمين النشطين";
            // 
            // pnlOrdersCard
            // 
            this.pnlOrdersCard.BackColor = System.Drawing.Color.Transparent;
            this.pnlOrdersCard.BorderRadius = 10;
            this.pnlOrdersCard.Controls.Add(this.lblTotalOrdersVal);
            this.pnlOrdersCard.Controls.Add(this.lblTotalOrders);
            this.pnlOrdersCard.FillColor = System.Drawing.Color.White;
            this.pnlOrdersCard.Location = new System.Drawing.Point(284, 25);
            this.pnlOrdersCard.Name = "pnlOrdersCard";
            this.pnlOrdersCard.ShadowDecoration.Enabled = true;
            this.pnlOrdersCard.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2, 2, 5, 5);
            this.pnlOrdersCard.Size = new System.Drawing.Size(205, 115);
            this.pnlOrdersCard.TabIndex = 2;
            // 
            // lblTotalOrdersVal
            // 
            this.lblTotalOrdersVal.AutoSize = true;
            this.lblTotalOrdersVal.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOrdersVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.lblTotalOrdersVal.Location = new System.Drawing.Point(20, 50);
            this.lblTotalOrdersVal.Name = "lblTotalOrdersVal";
            this.lblTotalOrdersVal.Size = new System.Drawing.Size(65, 37);
            this.lblTotalOrdersVal.TabIndex = 1;
            this.lblTotalOrdersVal.Text = "143";
            // 
            // lblTotalOrders
            // 
            this.lblTotalOrders.AutoSize = true;
            this.lblTotalOrders.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOrders.ForeColor = System.Drawing.Color.Gray;
            this.lblTotalOrders.Location = new System.Drawing.Point(23, 20);
            this.lblTotalOrders.Name = "lblTotalOrders";
            this.lblTotalOrders.Size = new System.Drawing.Size(133, 20);
            this.lblTotalOrders.TabIndex = 0;
            this.lblTotalOrders.Text = "إجمالي طلبات اليوم";
            // 
            // pnlCashCard
            // 
            this.pnlCashCard.BackColor = System.Drawing.Color.Transparent;
            this.pnlCashCard.BorderRadius = 10;
            this.pnlCashCard.Controls.Add(this.lblCashBalanceVal);
            this.pnlCashCard.Controls.Add(this.lblCashBalance);
            this.pnlCashCard.FillColor = System.Drawing.Color.White;
            this.pnlCashCard.Location = new System.Drawing.Point(529, 25);
            this.pnlCashCard.Name = "pnlCashCard";
            this.pnlCashCard.ShadowDecoration.Enabled = true;
            this.pnlCashCard.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2, 2, 5, 5);
            this.pnlCashCard.Size = new System.Drawing.Size(205, 115);
            this.pnlCashCard.TabIndex = 1;
            // 
            // lblCashBalanceVal
            // 
            this.lblCashBalanceVal.AutoSize = true;
            this.lblCashBalanceVal.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashBalanceVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(199)))), ((int)(((byte)(111)))));
            this.lblCashBalanceVal.Location = new System.Drawing.Point(20, 50);
            this.lblCashBalanceVal.Name = "lblCashBalanceVal";
            this.lblCashBalanceVal.Size = new System.Drawing.Size(159, 37);
            this.lblCashBalanceVal.TabIndex = 1;
            this.lblCashBalanceVal.Text = "$15,240.50";
            // 
            // lblCashBalance
            // 
            this.lblCashBalance.AutoSize = true;
            this.lblCashBalance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashBalance.ForeColor = System.Drawing.Color.Gray;
            this.lblCashBalance.Location = new System.Drawing.Point(23, 20);
            this.lblCashBalance.Name = "lblCashBalance";
            this.lblCashBalance.Size = new System.Drawing.Size(96, 20);
            this.lblCashBalance.TabIndex = 0;
            this.lblCashBalance.Text = "الرصيد النقدي";
            // 
            // pnlSalesCard
            // 
            this.pnlSalesCard.BackColor = System.Drawing.Color.Transparent;
            this.pnlSalesCard.BorderRadius = 10;
            this.pnlSalesCard.Controls.Add(this.lblTodaySalesVal);
            this.pnlSalesCard.Controls.Add(this.lblTodaySales);
            this.pnlSalesCard.FillColor = System.Drawing.Color.White;
            this.pnlSalesCard.Location = new System.Drawing.Point(774, 25);
            this.pnlSalesCard.Name = "pnlSalesCard";
            this.pnlSalesCard.ShadowDecoration.Enabled = true;
            this.pnlSalesCard.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2, 2, 5, 5);
            this.pnlSalesCard.Size = new System.Drawing.Size(205, 115);
            this.pnlSalesCard.TabIndex = 0;
            // 
            // lblTodaySalesVal
            // 
            this.lblTodaySalesVal.AutoSize = true;
            this.lblTodaySalesVal.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodaySalesVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(103)))), ((int)(((byte)(240)))));
            this.lblTodaySalesVal.Location = new System.Drawing.Point(20, 50);
            this.lblTodaySalesVal.Name = "lblTodaySalesVal";
            this.lblTodaySalesVal.Size = new System.Drawing.Size(143, 37);
            this.lblTodaySalesVal.TabIndex = 1;
            this.lblTodaySalesVal.Text = "$4,250.00";
            // 
            // lblTodaySales
            // 
            this.lblTodaySales.AutoSize = true;
            this.lblTodaySales.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodaySales.ForeColor = System.Drawing.Color.Gray;
            this.lblTodaySales.Location = new System.Drawing.Point(23, 20);
            this.lblTodaySales.Name = "lblTodaySales";
            this.lblTodaySales.Size = new System.Drawing.Size(90, 20);
            this.lblTodaySales.TabIndex = 0;
            this.lblTodaySales.Text = "مبيعات اليوم";
            // 
            // tabSales
            // 
            this.tabSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.tabSales.Controls.Add(this.btnListSales);
            this.tabSales.Controls.Add(this.btnAddNewSale);
            this.tabSales.Location = new System.Drawing.Point(4, 4);
            this.tabSales.Name = "tabSales";
            this.tabSales.Padding = new System.Windows.Forms.Padding(3);
            this.tabSales.Size = new System.Drawing.Size(996, 753);
            this.tabSales.TabIndex = 1;
            this.tabSales.Text = "المبيعات";
            // 
            // btnListSales
            // 
            this.btnListSales.BorderRadius = 15;
            this.btnListSales.FillColor = System.Drawing.Color.White;
            this.btnListSales.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnListSales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnListSales.Location = new System.Drawing.Point(427, 59);
            this.btnListSales.Name = "btnListSales";
            this.btnListSales.Size = new System.Drawing.Size(239, 172);
            this.btnListSales.TabIndex = 1;
            this.btnListSales.Text = "قائمة المبيعات";
            // 
            // btnAddNewSale
            // 
            this.btnAddNewSale.BorderRadius = 15;
            this.btnAddNewSale.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(103)))), ((int)(((byte)(240)))));
            this.btnAddNewSale.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAddNewSale.ForeColor = System.Drawing.Color.White;
            this.btnAddNewSale.Location = new System.Drawing.Point(700, 59);
            this.btnAddNewSale.Name = "btnAddNewSale";
            this.btnAddNewSale.Size = new System.Drawing.Size(239, 172);
            this.btnAddNewSale.TabIndex = 0;
            this.btnAddNewSale.Text = "+ إضافة بيع جديد";
            // 
            // tabPurchases
            // 
            this.tabPurchases.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.tabPurchases.Controls.Add(this.btnListPurchases);
            this.tabPurchases.Controls.Add(this.btnAddNewPurchase);
            this.tabPurchases.Location = new System.Drawing.Point(4, 4);
            this.tabPurchases.Name = "tabPurchases";
            this.tabPurchases.Size = new System.Drawing.Size(996, 753);
            this.tabPurchases.TabIndex = 2;
            this.tabPurchases.Text = "المشتريات";
            // 
            // btnListPurchases
            // 
            this.btnListPurchases.BorderRadius = 15;
            this.btnListPurchases.FillColor = System.Drawing.Color.White;
            this.btnListPurchases.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnListPurchases.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnListPurchases.Location = new System.Drawing.Point(427, 59);
            this.btnListPurchases.Name = "btnListPurchases";
            this.btnListPurchases.Size = new System.Drawing.Size(239, 172);
            this.btnListPurchases.TabIndex = 3;
            this.btnListPurchases.Text = "قائمة المشتريات";
            // 
            // btnAddNewPurchase
            // 
            this.btnAddNewPurchase.BorderRadius = 15;
            this.btnAddNewPurchase.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(199)))), ((int)(((byte)(111)))));
            this.btnAddNewPurchase.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAddNewPurchase.ForeColor = System.Drawing.Color.White;
            this.btnAddNewPurchase.Location = new System.Drawing.Point(700, 59);
            this.btnAddNewPurchase.Name = "btnAddNewPurchase";
            this.btnAddNewPurchase.Size = new System.Drawing.Size(239, 172);
            this.btnAddNewPurchase.TabIndex = 2;
            this.btnAddNewPurchase.Text = "+ إضافة شراء جديد";
            // 
            // tabProducts
            // 
            this.tabProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.tabProducts.Controls.Add(this.btnListProducts);
            this.tabProducts.Controls.Add(this.btnListCategories);
            this.tabProducts.Controls.Add(this.btnAddNewProduct);
            this.tabProducts.Location = new System.Drawing.Point(4, 4);
            this.tabProducts.Name = "tabProducts";
            this.tabProducts.Size = new System.Drawing.Size(996, 753);
            this.tabProducts.TabIndex = 3;
            this.tabProducts.Text = "المنتجات";
            // 
            // btnListProducts
            // 
            this.btnListProducts.BorderRadius = 15;
            this.btnListProducts.FillColor = System.Drawing.Color.White;
            this.btnListProducts.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnListProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnListProducts.Location = new System.Drawing.Point(154, 59);
            this.btnListProducts.Name = "btnListProducts";
            this.btnListProducts.Size = new System.Drawing.Size(239, 172);
            this.btnListProducts.TabIndex = 2;
            this.btnListProducts.Text = "قائمة المنتجات";
            // 
            // btnListCategories
            // 
            this.btnListCategories.BorderRadius = 15;
            this.btnListCategories.FillColor = System.Drawing.Color.White;
            this.btnListCategories.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnListCategories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnListCategories.Location = new System.Drawing.Point(427, 59);
            this.btnListCategories.Name = "btnListCategories";
            this.btnListCategories.Size = new System.Drawing.Size(239, 172);
            this.btnListCategories.TabIndex = 3;
            this.btnListCategories.Text = "قائمة الأقسام";
            // 
            // btnAddNewProduct
            // 
            this.btnAddNewProduct.BorderRadius = 15;
            this.btnAddNewProduct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.btnAddNewProduct.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAddNewProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddNewProduct.Location = new System.Drawing.Point(700, 59);
            this.btnAddNewProduct.Name = "btnAddNewProduct";
            this.btnAddNewProduct.Size = new System.Drawing.Size(239, 172);
            this.btnAddNewProduct.TabIndex = 4;
            this.btnAddNewProduct.Text = "+ إضافة منتج جديد";
            // 
            // tabCustomers
            // 
            this.tabCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.tabCustomers.Controls.Add(this.btnAddNewCustomer);
            this.tabCustomers.Controls.Add(this.btnListCustomers);
            this.tabCustomers.Location = new System.Drawing.Point(4, 4);
            this.tabCustomers.Name = "tabCustomers";
            this.tabCustomers.Size = new System.Drawing.Size(996, 753);
            this.tabCustomers.TabIndex = 4;
            this.tabCustomers.Text = "العملاء";
            // 
            // btnAddNewCustomer
            // 
            this.btnAddNewCustomer.BorderRadius = 15;
            this.btnAddNewCustomer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(84)))), ((int)(((byte)(85)))));
            this.btnAddNewCustomer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAddNewCustomer.ForeColor = System.Drawing.Color.White;
            this.btnAddNewCustomer.Location = new System.Drawing.Point(700, 59);
            this.btnAddNewCustomer.Name = "btnAddNewCustomer";
            this.btnAddNewCustomer.Size = new System.Drawing.Size(239, 172);
            this.btnAddNewCustomer.TabIndex = 5;
            this.btnAddNewCustomer.Text = "+ إضافة عميل جديد";
            // 
            // btnListCustomers
            // 
            this.btnListCustomers.BorderRadius = 15;
            this.btnListCustomers.FillColor = System.Drawing.Color.White;
            this.btnListCustomers.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnListCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnListCustomers.Location = new System.Drawing.Point(427, 59);
            this.btnListCustomers.Name = "btnListCustomers";
            this.btnListCustomers.Size = new System.Drawing.Size(239, 172);
            this.btnListCustomers.TabIndex = 4;
            this.btnListCustomers.Text = "قائمة العملاء";
            // 
            // tabSuppliers
            // 
            this.tabSuppliers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.tabSuppliers.Controls.Add(this.btnAddNewSupplier);
            this.tabSuppliers.Controls.Add(this.btnListSuppliers);
            this.tabSuppliers.Location = new System.Drawing.Point(4, 4);
            this.tabSuppliers.Name = "tabSuppliers";
            this.tabSuppliers.Size = new System.Drawing.Size(996, 753);
            this.tabSuppliers.TabIndex = 5;
            this.tabSuppliers.Text = "الموردين";
            // 
            // btnAddNewSupplier
            // 
            this.btnAddNewSupplier.BorderRadius = 15;
            this.btnAddNewSupplier.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(207)))), ((int)(((byte)(232)))));
            this.btnAddNewSupplier.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAddNewSupplier.ForeColor = System.Drawing.Color.White;
            this.btnAddNewSupplier.Location = new System.Drawing.Point(700, 59);
            this.btnAddNewSupplier.Name = "btnAddNewSupplier";
            this.btnAddNewSupplier.Size = new System.Drawing.Size(239, 172);
            this.btnAddNewSupplier.TabIndex = 7;
            this.btnAddNewSupplier.Text = "+ إضافة مورد جديد";
            // 
            // btnListSuppliers
            // 
            this.btnListSuppliers.BorderRadius = 15;
            this.btnListSuppliers.FillColor = System.Drawing.Color.White;
            this.btnListSuppliers.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnListSuppliers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnListSuppliers.Location = new System.Drawing.Point(427, 59);
            this.btnListSuppliers.Name = "btnListSuppliers";
            this.btnListSuppliers.Size = new System.Drawing.Size(239, 172);
            this.btnListSuppliers.TabIndex = 6;
            this.btnListSuppliers.Text = "قائمة الموردين";
            // 
            // tabReports
            // 
            this.tabReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.tabReports.Controls.Add(this.btnImportantReports);
            this.tabReports.Controls.Add(this.btnCustomUsingAi);
            this.tabReports.Location = new System.Drawing.Point(4, 4);
            this.tabReports.Name = "tabReports";
            this.tabReports.Size = new System.Drawing.Size(996, 753);
            this.tabReports.TabIndex = 6;
            this.tabReports.Text = "التقارير";
            // 
            // btnImportantReports
            // 
            this.btnImportantReports.BorderRadius = 15;
            this.btnImportantReports.FillColor = System.Drawing.Color.White;
            this.btnImportantReports.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnImportantReports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnImportantReports.Location = new System.Drawing.Point(700, 59);
            this.btnImportantReports.Name = "btnImportantReports";
            this.btnImportantReports.Size = new System.Drawing.Size(239, 172);
            this.btnImportantReports.TabIndex = 9;
            this.btnImportantReports.Text = "التقارير الهامة";
            // 
            // btnCustomUsingAi
            // 
            this.btnCustomUsingAi.BorderRadius = 15;
            this.btnCustomUsingAi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.btnCustomUsingAi.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCustomUsingAi.ForeColor = System.Drawing.Color.White;
            this.btnCustomUsingAi.Location = new System.Drawing.Point(427, 59);
            this.btnCustomUsingAi.Name = "btnCustomUsingAi";
            this.btnCustomUsingAi.Size = new System.Drawing.Size(239, 172);
            this.btnCustomUsingAi.TabIndex = 8;
            this.btnCustomUsingAi.Text = "تقارير مخصصة بالذكاء الاصطناعي";
            // 
            // tabPartners
            // 
            this.tabPartners.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.tabPartners.Controls.Add(this.btnWithdrawDeposit);
            this.tabPartners.Controls.Add(this.btnListPartners);
            this.tabPartners.Location = new System.Drawing.Point(4, 4);
            this.tabPartners.Name = "tabPartners";
            this.tabPartners.Size = new System.Drawing.Size(996, 753);
            this.tabPartners.TabIndex = 7;
            this.tabPartners.Text = "الشركاء";
            // 
            // btnWithdrawDeposit
            // 
            this.btnWithdrawDeposit.BorderRadius = 15;
            this.btnWithdrawDeposit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(199)))), ((int)(((byte)(111)))));
            this.btnWithdrawDeposit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnWithdrawDeposit.ForeColor = System.Drawing.Color.White;
            this.btnWithdrawDeposit.Location = new System.Drawing.Point(427, 59);
            this.btnWithdrawDeposit.Name = "btnWithdrawDeposit";
            this.btnWithdrawDeposit.Size = new System.Drawing.Size(239, 172);
            this.btnWithdrawDeposit.TabIndex = 9;
            this.btnWithdrawDeposit.Text = "سحب / إيداع";
            // 
            // btnListPartners
            // 
            this.btnListPartners.BorderRadius = 15;
            this.btnListPartners.FillColor = System.Drawing.Color.White;
            this.btnListPartners.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnListPartners.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnListPartners.Location = new System.Drawing.Point(700, 59);
            this.btnListPartners.Name = "btnListPartners";
            this.btnListPartners.Size = new System.Drawing.Size(239, 172);
            this.btnListPartners.TabIndex = 8;
            this.btnListPartners.Text = "قائمة الشركاء";
            // 
            // tabUsers
            // 
            this.tabUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.tabUsers.Controls.Add(this.btnAddNewUser);
            this.tabUsers.Controls.Add(this.btnListUsers);
            this.tabUsers.Location = new System.Drawing.Point(4, 4);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Size = new System.Drawing.Size(996, 753);
            this.tabUsers.TabIndex = 8;
            this.tabUsers.Text = "المستخدمين";
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.BorderRadius = 15;
            this.btnAddNewUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(103)))), ((int)(((byte)(240)))));
            this.btnAddNewUser.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAddNewUser.ForeColor = System.Drawing.Color.White;
            this.btnAddNewUser.Location = new System.Drawing.Point(700, 59);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(239, 172);
            this.btnAddNewUser.TabIndex = 9;
            this.btnAddNewUser.Text = "+ إضافة مستخدم جديد";
            // 
            // btnListUsers
            // 
            this.btnListUsers.BorderRadius = 15;
            this.btnListUsers.FillColor = System.Drawing.Color.White;
            this.btnListUsers.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnListUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnListUsers.Location = new System.Drawing.Point(427, 59);
            this.btnListUsers.Name = "btnListUsers";
            this.btnListUsers.Size = new System.Drawing.Size(239, 172);
            this.btnListUsers.TabIndex = 8;
            this.btnListUsers.Text = "قائمة المستخدمين";
            // 
            // tabSettings
            // 
            this.tabSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.tabSettings.Controls.Add(this.btnGeneralSettings);
            this.tabSettings.Controls.Add(this.btnBackupRestore);
            this.tabSettings.Controls.Add(this.btnCurrentUserInfo);
            this.tabSettings.Controls.Add(this.btnLogout);
            this.tabSettings.Location = new System.Drawing.Point(4, 4);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(996, 753);
            this.tabSettings.TabIndex = 9;
            this.tabSettings.Text = "الإعدادات";
            // 
            // btnGeneralSettings
            // 
            this.btnGeneralSettings.BorderRadius = 15;
            this.btnGeneralSettings.FillColor = System.Drawing.Color.White;
            this.btnGeneralSettings.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnGeneralSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGeneralSettings.Location = new System.Drawing.Point(700, 266);
            this.btnGeneralSettings.Name = "btnGeneralSettings";
            this.btnGeneralSettings.Size = new System.Drawing.Size(239, 172);
            this.btnGeneralSettings.TabIndex = 11;
            this.btnGeneralSettings.Text = "الإعدادات العامة";
            // 
            // btnBackupRestore
            // 
            this.btnBackupRestore.BorderRadius = 15;
            this.btnBackupRestore.FillColor = System.Drawing.Color.White;
            this.btnBackupRestore.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnBackupRestore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBackupRestore.Location = new System.Drawing.Point(427, 266);
            this.btnBackupRestore.Name = "btnBackupRestore";
            this.btnBackupRestore.Size = new System.Drawing.Size(239, 172);
            this.btnBackupRestore.TabIndex = 10;
            this.btnBackupRestore.Text = "النسخ الاحتياطي والاستعادة";
            // 
            // btnCurrentUserInfo
            // 
            this.btnCurrentUserInfo.BorderRadius = 15;
            this.btnCurrentUserInfo.FillColor = System.Drawing.Color.White;
            this.btnCurrentUserInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCurrentUserInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCurrentUserInfo.Location = new System.Drawing.Point(700, 59);
            this.btnCurrentUserInfo.Name = "btnCurrentUserInfo";
            this.btnCurrentUserInfo.Size = new System.Drawing.Size(239, 172);
            this.btnCurrentUserInfo.TabIndex = 9;
            this.btnCurrentUserInfo.Text = "معلومات المستخدم الحالي";
            // 
            // btnLogout
            // 
            this.btnLogout.BorderRadius = 15;
            this.btnLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(84)))), ((int)(((byte)(85)))));
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(427, 59);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(239, 172);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "تسجيل الخروج";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.tcMain);
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لوحة تحكم نظام الماهر لنقاط البيع والمحاسبة";
            this.tcMain.ResumeLayout(false);
            this.tabDashboard.ResumeLayout(false);
            this.tabDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLowStock)).EndInit();
            this.pnlUsersCard.ResumeLayout(false);
            this.pnlUsersCard.PerformLayout();
            this.pnlOrdersCard.ResumeLayout(false);
            this.pnlOrdersCard.PerformLayout();
            this.pnlCashCard.ResumeLayout(false);
            this.pnlCashCard.PerformLayout();
            this.pnlSalesCard.ResumeLayout(false);
            this.pnlSalesCard.PerformLayout();
            this.tabSales.ResumeLayout(false);
            this.tabPurchases.ResumeLayout(false);
            this.tabProducts.ResumeLayout(false);
            this.tabCustomers.ResumeLayout(false);
            this.tabSuppliers.ResumeLayout(false);
            this.tabReports.ResumeLayout(false);
            this.tabPartners.ResumeLayout(false);
            this.tabUsers.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl tcMain;
        private System.Windows.Forms.TabPage tabDashboard;
        private System.Windows.Forms.TabPage tabSales;
        private System.Windows.Forms.TabPage tabPurchases;
        private System.Windows.Forms.TabPage tabProducts;
        private System.Windows.Forms.TabPage tabCustomers;
        private System.Windows.Forms.TabPage tabSuppliers;
        private System.Windows.Forms.TabPage tabReports;
        private System.Windows.Forms.TabPage tabPartners;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.TabPage tabSettings;
        private Guna.UI2.WinForms.Guna2Panel pnlSalesCard;
        private System.Windows.Forms.Label lblTodaySalesVal;
        private System.Windows.Forms.Label lblTodaySales;
        private Guna.UI2.WinForms.Guna2Panel pnlCashCard;
        private System.Windows.Forms.Label lblCashBalanceVal;
        private System.Windows.Forms.Label lblCashBalance;
        private Guna.UI2.WinForms.Guna2Panel pnlOrdersCard;
        private System.Windows.Forms.Label lblTotalOrdersVal;
        private System.Windows.Forms.Label lblTotalOrders;
        private Guna.UI2.WinForms.Guna2Panel pnlUsersCard;
        private System.Windows.Forms.Label lblActiveUsersVal;
        private System.Windows.Forms.Label lblActiveUsers;
        private Guna.UI2.WinForms.Guna2DataGridView dgvLowStock;
        private Guna.UI2.WinForms.Guna2DataGridView dgvRecentInvoices;
        private System.Windows.Forms.Label lblLowStock;
        private System.Windows.Forms.Label lblInvoices;

        private Guna.UI2.WinForms.Guna2Button btnAddNewSale;
        private Guna.UI2.WinForms.Guna2Button btnListSales;
        private Guna.UI2.WinForms.Guna2Button btnListPurchases;
        private Guna.UI2.WinForms.Guna2Button btnAddNewPurchase;

        private Guna.UI2.WinForms.Guna2Button btnAddNewProduct;
        private Guna.UI2.WinForms.Guna2Button btnListCategories;
        private Guna.UI2.WinForms.Guna2Button btnListProducts;

        private Guna.UI2.WinForms.Guna2Button btnAddNewCustomer;
        private Guna.UI2.WinForms.Guna2Button btnListCustomers;

        private Guna.UI2.WinForms.Guna2Button btnAddNewSupplier;
        private Guna.UI2.WinForms.Guna2Button btnListSuppliers;

        private Guna.UI2.WinForms.Guna2Button btnImportantReports;
        private Guna.UI2.WinForms.Guna2Button btnCustomUsingAi;

        private Guna.UI2.WinForms.Guna2Button btnWithdrawDeposit;
        private Guna.UI2.WinForms.Guna2Button btnListPartners;

        private Guna.UI2.WinForms.Guna2Button btnAddNewUser;
        private Guna.UI2.WinForms.Guna2Button btnListUsers;

        private Guna.UI2.WinForms.Guna2Button btnGeneralSettings;
        private Guna.UI2.WinForms.Guna2Button btnBackupRestore;
        private Guna.UI2.WinForms.Guna2Button btnCurrentUserInfo;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
    }
}