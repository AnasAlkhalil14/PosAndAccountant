//namespace PosAndAccountantProject
//{
//    partial class frmMain : System.Windows.Forms.Form
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//                components.Dispose();
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        private void InitializeComponent()
//        {
//            this.components = new System.ComponentModel.Container();
//            Guna.Charts.WinForms.ChartFont chartFont1 = new Guna.Charts.WinForms.ChartFont();
//            Guna.Charts.WinForms.ChartFont chartFont2 = new Guna.Charts.WinForms.ChartFont();
//            Guna.Charts.WinForms.ChartFont chartFont3 = new Guna.Charts.WinForms.ChartFont();
//            Guna.Charts.WinForms.ChartFont chartFont4 = new Guna.Charts.WinForms.ChartFont();
//            Guna.Charts.WinForms.Grid grid1 = new Guna.Charts.WinForms.Grid();
//            Guna.Charts.WinForms.Tick tick1 = new Guna.Charts.WinForms.Tick();
//            Guna.Charts.WinForms.ChartFont chartFont5 = new Guna.Charts.WinForms.ChartFont();
//            Guna.Charts.WinForms.Grid grid2 = new Guna.Charts.WinForms.Grid();
//            Guna.Charts.WinForms.Tick tick2 = new Guna.Charts.WinForms.Tick();
//            Guna.Charts.WinForms.ChartFont chartFont6 = new Guna.Charts.WinForms.ChartFont();
//            Guna.Charts.WinForms.Grid grid3 = new Guna.Charts.WinForms.Grid();
//            Guna.Charts.WinForms.PointLabel pointLabel1 = new Guna.Charts.WinForms.PointLabel();
//            Guna.Charts.WinForms.ChartFont chartFont7 = new Guna.Charts.WinForms.ChartFont();
//            Guna.Charts.WinForms.Tick tick3 = new Guna.Charts.WinForms.Tick();
//            Guna.Charts.WinForms.ChartFont chartFont8 = new Guna.Charts.WinForms.ChartFont();
//            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
//            this.tcMain = new Guna.UI2.WinForms.Guna2TabControl();
//            this.tabDashboard = new System.Windows.Forms.TabPage();
//            this.pnlSalesOverview = new Guna.UI2.WinForms.Guna2Panel();
//            this.chartSales = new Guna.Charts.WinForms.GunaChart();
//            this.gunaAreaDataset1 = new Guna.Charts.WinForms.GunaAreaDataset();
//            this.cmbTimeFilter = new Guna.UI2.WinForms.Guna2ComboBox();
//            this.lblSalesChartSubtitle = new System.Windows.Forms.Label();
//            this.label2 = new System.Windows.Forms.Label();
//            this.pnlRecentInvoices = new Guna.UI2.WinForms.Guna2Panel();
//            this.btnViewAllInvoices = new Guna.UI2.WinForms.Guna2Button();
//            this.dgvRecentInvoices = new Guna.UI2.WinForms.Guna2DataGridView();
//            this.colInvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.colInvoiceCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.colInvoiceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.colInvoiceAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.lblInvoicesSubtitle = new System.Windows.Forms.Label();
//            this.lblInvoices = new System.Windows.Forms.Label();
//            this.pnlLowStock = new Guna.UI2.WinForms.Guna2Panel();
//            this.btnViewAllLowStock = new Guna.UI2.WinForms.Guna2Button();
//            this.dgvLowStock = new Guna.UI2.WinForms.Guna2DataGridView();
//            this.colLowStockProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.colLowStockQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.colLowStockMinQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.lblLowStockSubtitle = new System.Windows.Forms.Label();
//            this.lblLowStock = new System.Windows.Forms.Label();
//            this.pnlStockValueCard = new Guna.UI2.WinForms.Guna2Panel();
//            this.lblStockValue = new System.Windows.Forms.Label();
//            this.lblStockValueVal = new System.Windows.Forms.Label();
//            this.lblStockValueHint = new System.Windows.Forms.Label();
//            this.pnlPayablesCard = new Guna.UI2.WinForms.Guna2Panel();
//            this.lblPayables = new System.Windows.Forms.Label();
//            this.lblPayablesVal = new System.Windows.Forms.Label();
//            this.lblPayablesHint = new System.Windows.Forms.Label();
//            this.pnlReceivablesCard = new Guna.UI2.WinForms.Guna2Panel();
//            this.lblReceivables = new System.Windows.Forms.Label();
//            this.lblReceivablesVal = new System.Windows.Forms.Label();
//            this.lblReceivablesHint = new System.Windows.Forms.Label();
//            this.pnlPurchaseCard = new Guna.UI2.WinForms.Guna2Panel();
//            this.lblTodayPurchases = new System.Windows.Forms.Label();
//            this.lblTodayPurchasesVal = new System.Windows.Forms.Label();
//            this.lblTodayPurchasesTrend = new System.Windows.Forms.Label();
//            this.pnlUsersCard = new Guna.UI2.WinForms.Guna2Panel();
//            this.DDSFSFSF = new System.Windows.Forms.Label();
//            this.lblProfitVal = new System.Windows.Forms.Label();
//            this.lblProfitTrend = new System.Windows.Forms.Label();
//            this.pnlOrdersCard = new Guna.UI2.WinForms.Guna2Panel();
//            this.ddfsfsf = new System.Windows.Forms.Label();
//            this.lblTotalOrdersVal = new System.Windows.Forms.Label();
//            this.lblTotalOrdersTrend = new System.Windows.Forms.Label();
//            this.pnlCashCard = new Guna.UI2.WinForms.Guna2Panel();
//            this.DFSSFS = new System.Windows.Forms.Label();
//            this.lblCashBalanceVal = new System.Windows.Forms.Label();
//            this.lblCashBalanceTrend = new System.Windows.Forms.Label();
//            this.pnlSalesCard = new Guna.UI2.WinForms.Guna2Panel();
//            this.lblTodaySales = new System.Windows.Forms.Label();
//            this.lblTodaySalesVal = new System.Windows.Forms.Label();
//            this.lblTodaySalesTrend = new System.Windows.Forms.Label();
//            this.btnRefreshDashboard = new Guna.UI2.WinForms.Guna2Button();
//            this.lblDashboardSubtitle = new System.Windows.Forms.Label();
//            this.lblDashboardTitle = new System.Windows.Forms.Label();
//            this.tabSales = new System.Windows.Forms.TabPage();
//            this.lblSalesSubtitle = new System.Windows.Forms.Label();
//            this.lblSalesTitle = new System.Windows.Forms.Label();
//            this.pnlSalesActions = new Guna.UI2.WinForms.Guna2Panel();
//            this.lblSalesActionsHint = new System.Windows.Forms.Label();
//            this.lblSalesActions = new System.Windows.Forms.Label();
//            this.pnlSalesDebt = new Guna.UI2.WinForms.Guna2Panel();
//            this.lblSalesDebtValue = new System.Windows.Forms.Label();
//            this.lblSalesDebtCaption = new System.Windows.Forms.Label();
//            this.pnlSalesInvoices = new Guna.UI2.WinForms.Guna2Panel();
//            this.lblSalesInvoicesValue = new System.Windows.Forms.Label();
//            this.lblSalesInvoicesCaption = new System.Windows.Forms.Label();
//            this.pnlSalesToday = new Guna.UI2.WinForms.Guna2Panel();
//            this.lblSalesTodayValue = new System.Windows.Forms.Label();
//            this.lblSalesTodayCaption = new System.Windows.Forms.Label();
//            this.btnListSales = new Guna.UI2.WinForms.Guna2Button();
//            this.btnAddNewSale = new Guna.UI2.WinForms.Guna2Button();
//            this.tabPurchases = new System.Windows.Forms.TabPage();
//            this.lblPurchasesSubtitle = new System.Windows.Forms.Label();
//            this.lblPurchasesTitle = new System.Windows.Forms.Label();
//            this.pnlPurchasesActions = new Guna.UI2.WinForms.Guna2Panel();
//            this.lblPurchasesActionsHint = new System.Windows.Forms.Label();
//            this.lblPurchasesActions = new System.Windows.Forms.Label();
//            this.pnlPurchasesDebt = new Guna.UI2.WinForms.Guna2Panel();
//            this.lblPurchasesDebtValue = new System.Windows.Forms.Label();
//            this.lblPurchasesDebtCaption = new System.Windows.Forms.Label();
//            this.pnlPurchasesInvoices = new Guna.UI2.WinForms.Guna2Panel();
//            this.lblPurchasesInvoicesValue = new System.Windows.Forms.Label();
//            this.lblPurchasesInvoicesCaption = new System.Windows.Forms.Label();
//            this.pnlPurchasesToday = new Guna.UI2.WinForms.Guna2Panel();
//            this.lblPurchasesTodayValue = new System.Windows.Forms.Label();
//            this.lblPurchasesTodayCaption = new System.Windows.Forms.Label();
//            this.btnListPurchases = new Guna.UI2.WinForms.Guna2Button();
//            this.btnAddNewPurchase = new Guna.UI2.WinForms.Guna2Button();
//            this.tabProducts = new System.Windows.Forms.TabPage();
//            this.lblProductsSubtitle = new System.Windows.Forms.Label();
//            this.lblProductsTitle = new System.Windows.Forms.Label();
//            this.pnlProductsActions = new Guna.UI2.WinForms.Guna2Panel();
//            this.lblProductsActionsHint = new System.Windows.Forms.Label();
//            this.lblProductsActions = new System.Windows.Forms.Label();
//            this.pnlProductsCategories = new Guna.UI2.WinForms.Guna2Panel();
//            this.lblProductsCategoriesValue = new System.Windows.Forms.Label();
//            this.lblProductsCategoriesCaption = new System.Windows.Forms.Label();
//            this.pnlProductsLowStock = new Guna.UI2.WinForms.Guna2Panel();
//            this.lblProductsLowStockValue = new System.Windows.Forms.Label();
//            this.lblProductsLowStockCaption = new System.Windows.Forms.Label();
//            this.pnlProductsCount = new Guna.UI2.WinForms.Guna2Panel();
//            this.lblProductsCountValue = new System.Windows.Forms.Label();
//            this.lblProductsCountCaption = new System.Windows.Forms.Label();
//            this.btnListCategories = new Guna.UI2.WinForms.Guna2Button();
//            this.btnListProducts = new Guna.UI2.WinForms.Guna2Button();
//            this.btnAddNewProduct = new Guna.UI2.WinForms.Guna2Button();
//            this.tabCustomers = new System.Windows.Forms.TabPage();
//            this.lblCustomersSubtitle = new System.Windows.Forms.Label();
//            this.lblCustomersTitle = new System.Windows.Forms.Label();
//            this.pnlCustomersActions = new Guna.UI2.WinForms.Guna2Panel();
//            this.lblCustomersActionsHint = new System.Windows.Forms.Label();
//            this.lblCustomersActions = new System.Windows.Forms.Label();
//            this.pnlCustomersDebt = new Guna.UI2.WinForms.Guna2Panel();
//            this.lblCustomersDebtValue = new System.Windows.Forms.Label();
//            this.lblCustomersDebtCaption = new System.Windows.Forms.Label();
//            this.pnlCustomersCount = new Guna.UI2.WinForms.Guna2Panel();
//            this.lblCustomersCountValue = new System.Windows.Forms.Label();
//            this.lblCustomersCountCaption = new System.Windows.Forms.Label();
//            this.btnListCustomers = new Guna.UI2.WinForms.Guna2Button();
//            this.btnAddNewCustomer = new Guna.UI2.WinForms.Guna2Button();
//            this.tabSuppliers = new System.Windows.Forms.TabPage();
//            this.lblSuppliersSubtitle = new System.Windows.Forms.Label();
//            this.lblSuppliersTitle = new System.Windows.Forms.Label();
//            this.pnlSuppliersActions = new Guna.UI2.WinForms.Guna2Panel();
//            this.lblSuppliersActionsHint = new System.Windows.Forms.Label();
//            this.lblSuppliersActions = new System.Windows.Forms.Label();
//            this.pnlSuppliersDebt = new Guna.UI2.WinForms.Guna2Panel();
//            this.lblSuppliersDebtValue = new System.Windows.Forms.Label();
//            this.lblSuppliersDebtCaption = new System.Windows.Forms.Label();
//            this.pnlSuppliersCount = new Guna.UI2.WinForms.Guna2Panel();
//            this.lblSuppliersCountValue = new System.Windows.Forms.Label();
//            this.lblSuppliersCountCaption = new System.Windows.Forms.Label();
//            this.btnListSuppliers = new Guna.UI2.WinForms.Guna2Button();
//            this.btnAddNewSupplier = new Guna.UI2.WinForms.Guna2Button();
//            this.tabReports = new System.Windows.Forms.TabPage();
//            this.lblReportsSubtitle = new System.Windows.Forms.Label();
//            this.lblReportsTitle = new System.Windows.Forms.Label();
//            this.pnlReportsProfit = new Guna.UI2.WinForms.Guna2Panel();
//            this.lblReportsProfitText = new System.Windows.Forms.Label();
//            this.lblReportsProfitTitle = new System.Windows.Forms.Label();
//            this.pnlReportsDebt = new Guna.UI2.WinForms.Guna2Panel();
//            this.lblReportsDebtText = new System.Windows.Forms.Label();
//            this.lblReportsDebtTitle = new System.Windows.Forms.Label();
//            this.pnlReportsStock = new Guna.UI2.WinForms.Guna2Panel();
//            this.lblReportsStockText = new System.Windows.Forms.Label();
//            this.lblReportsStockTitle = new System.Windows.Forms.Label();
//            this.pnlReportsSales = new Guna.UI2.WinForms.Guna2Panel();
//            this.lblReportsSalesText = new System.Windows.Forms.Label();
//            this.lblReportsSalesTitle = new System.Windows.Forms.Label();
//            this.btnCustomUsingAi = new Guna.UI2.WinForms.Guna2Button();
//            this.btnImportantReports = new Guna.UI2.WinForms.Guna2Button();
//            this.tabPartners = new System.Windows.Forms.TabPage();
//            this.lblPartnersSubtitle = new System.Windows.Forms.Label();
//            this.lblPartnersTitle = new System.Windows.Forms.Label();
//            this.pnlPartnersActions = new Guna.UI2.WinForms.Guna2Panel();
//            this.lblPartnersActionsHint = new System.Windows.Forms.Label();
//            this.lblPartnersActions = new System.Windows.Forms.Label();
//            this.pnlPartnersTransactions = new Guna.UI2.WinForms.Guna2Panel();
//            this.lblPartnersTransactionsValue = new System.Windows.Forms.Label();
//            this.lblPartnersTransactionsCaption = new System.Windows.Forms.Label();
//            this.pnlPartnersProfit = new Guna.UI2.WinForms.Guna2Panel();
//            this.lblPartnersProfitValue = new System.Windows.Forms.Label();
//            this.lblPartnersProfitCaption = new System.Windows.Forms.Label();
//            this.pnlPartnersBalance = new Guna.UI2.WinForms.Guna2Panel();
//            this.lblPartnersBalanceValue = new System.Windows.Forms.Label();
//            this.lblPartnersBalanceCaption = new System.Windows.Forms.Label();
//            this.btnListPartners = new Guna.UI2.WinForms.Guna2Button();
//            this.btnWithdrawDeposit = new Guna.UI2.WinForms.Guna2Button();
//            this.tabUsers = new System.Windows.Forms.TabPage();
//            this.lblUsersSubtitle = new System.Windows.Forms.Label();
//            this.lblUsersTitle = new System.Windows.Forms.Label();
//            this.pnlUsersActions = new Guna.UI2.WinForms.Guna2Panel();
//            this.lblUsersActionsHint = new System.Windows.Forms.Label();
//            this.lblUsersActions = new System.Windows.Forms.Label();
//            this.pnlUsersSecurity = new Guna.UI2.WinForms.Guna2Panel();
//            this.lblUsersSecurityValue = new System.Windows.Forms.Label();
//            this.lblUsersSecurityCaption = new System.Windows.Forms.Label();
//            this.pnlUsersCount = new Guna.UI2.WinForms.Guna2Panel();
//            this.lblUsersCountValue = new System.Windows.Forms.Label();
//            this.lblUsersCountCaption = new System.Windows.Forms.Label();
//            this.btnListUsers = new Guna.UI2.WinForms.Guna2Button();
//            this.btnAddNewUser = new Guna.UI2.WinForms.Guna2Button();
//            this.tabSettings = new System.Windows.Forms.TabPage();
//            this.lblSettingsSubtitle = new System.Windows.Forms.Label();
//            this.lblSettingsTitle = new System.Windows.Forms.Label();
//            this.pnlSettingsAccount = new Guna.UI2.WinForms.Guna2Panel();
//            this.lblSettingsAccountText = new System.Windows.Forms.Label();
//            this.lblSettingsAccountTitle = new System.Windows.Forms.Label();
//            this.pnlSettingsBackup = new Guna.UI2.WinForms.Guna2Panel();
//            this.lblSettingsBackupText = new System.Windows.Forms.Label();
//            this.lblSettingsBackupTitle = new System.Windows.Forms.Label();
//            this.pnlSettingsInfo = new Guna.UI2.WinForms.Guna2Panel();
//            this.lblSettingsInfoText = new System.Windows.Forms.Label();
//            this.lblSettingsInfoTitle = new System.Windows.Forms.Label();
//            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
//            this.btnBackupRestore = new Guna.UI2.WinForms.Guna2Button();
//            this.btnGeneralSettings = new Guna.UI2.WinForms.Guna2Button();
//            this.btnCurrentUserInfo = new Guna.UI2.WinForms.Guna2Button();
//            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
//            this.tcMain.SuspendLayout();
//            this.tabDashboard.SuspendLayout();
//            this.pnlSalesOverview.SuspendLayout();
//            this.pnlRecentInvoices.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentInvoices)).BeginInit();
//            this.pnlLowStock.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.dgvLowStock)).BeginInit();
//            this.pnlStockValueCard.SuspendLayout();
//            this.pnlPayablesCard.SuspendLayout();
//            this.pnlReceivablesCard.SuspendLayout();
//            this.pnlPurchaseCard.SuspendLayout();
//            this.pnlUsersCard.SuspendLayout();
//            this.pnlOrdersCard.SuspendLayout();
//            this.pnlCashCard.SuspendLayout();
//            this.pnlSalesCard.SuspendLayout();
//            this.tabSales.SuspendLayout();
//            this.pnlSalesActions.SuspendLayout();
//            this.pnlSalesDebt.SuspendLayout();
//            this.pnlSalesInvoices.SuspendLayout();
//            this.pnlSalesToday.SuspendLayout();
//            this.tabPurchases.SuspendLayout();
//            this.pnlPurchasesActions.SuspendLayout();
//            this.pnlPurchasesDebt.SuspendLayout();
//            this.pnlPurchasesInvoices.SuspendLayout();
//            this.pnlPurchasesToday.SuspendLayout();
//            this.tabProducts.SuspendLayout();
//            this.pnlProductsActions.SuspendLayout();
//            this.pnlProductsCategories.SuspendLayout();
//            this.pnlProductsLowStock.SuspendLayout();
//            this.pnlProductsCount.SuspendLayout();
//            this.tabCustomers.SuspendLayout();
//            this.pnlCustomersActions.SuspendLayout();
//            this.pnlCustomersDebt.SuspendLayout();
//            this.pnlCustomersCount.SuspendLayout();
//            this.tabSuppliers.SuspendLayout();
//            this.pnlSuppliersActions.SuspendLayout();
//            this.pnlSuppliersDebt.SuspendLayout();
//            this.pnlSuppliersCount.SuspendLayout();
//            this.tabReports.SuspendLayout();
//            this.pnlReportsProfit.SuspendLayout();
//            this.pnlReportsDebt.SuspendLayout();
//            this.pnlReportsStock.SuspendLayout();
//            this.pnlReportsSales.SuspendLayout();
//            this.tabPartners.SuspendLayout();
//            this.pnlPartnersActions.SuspendLayout();
//            this.pnlPartnersTransactions.SuspendLayout();
//            this.pnlPartnersProfit.SuspendLayout();
//            this.pnlPartnersBalance.SuspendLayout();
//            this.tabUsers.SuspendLayout();
//            this.pnlUsersActions.SuspendLayout();
//            this.pnlUsersSecurity.SuspendLayout();
//            this.pnlUsersCount.SuspendLayout();
//            this.tabSettings.SuspendLayout();
//            this.pnlSettingsAccount.SuspendLayout();
//            this.pnlSettingsBackup.SuspendLayout();
//            this.pnlSettingsInfo.SuspendLayout();
//            this.SuspendLayout();
//            // 
//            // tcMain
//            // 
//            this.tcMain.Alignment = System.Windows.Forms.TabAlignment.Right;
//            this.tcMain.Controls.Add(this.tabDashboard);
//            this.tcMain.Controls.Add(this.tabSales);
//            this.tcMain.Controls.Add(this.tabPurchases);
//            this.tcMain.Controls.Add(this.tabProducts);
//            this.tcMain.Controls.Add(this.tabCustomers);
//            this.tcMain.Controls.Add(this.tabSuppliers);
//            this.tcMain.Controls.Add(this.tabReports);
//            this.tcMain.Controls.Add(this.tabPartners);
//            this.tcMain.Controls.Add(this.tabUsers);
//            this.tcMain.Controls.Add(this.tabSettings);
//            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
//            this.tcMain.ItemSize = new System.Drawing.Size(190, 46);
//            this.tcMain.Location = new System.Drawing.Point(0, 0);
//            this.tcMain.Name = "tcMain";
//            this.tcMain.RightToLeft = System.Windows.Forms.RightToLeft.No;
//            this.tcMain.RightToLeftLayout = true;
//            this.tcMain.SelectedIndex = 0;
//            this.tcMain.Size = new System.Drawing.Size(1184, 792);
//            this.tcMain.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
//            this.tcMain.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(53)))), ((int)(((byte)(72)))));
//            this.tcMain.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
//            this.tcMain.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
//            this.tcMain.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(53)))), ((int)(((byte)(72)))));
//            this.tcMain.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
//            this.tcMain.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(38)))), ((int)(((byte)(52)))));
//            this.tcMain.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
//            this.tcMain.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(169)))), ((int)(((byte)(178)))));
//            this.tcMain.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(38)))), ((int)(((byte)(52)))));
//            this.tcMain.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
//            this.tcMain.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(46)))));
//            this.tcMain.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
//            this.tcMain.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
//            this.tcMain.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(103)))), ((int)(((byte)(240)))));
//            this.tcMain.TabButtonSize = new System.Drawing.Size(190, 46);
//            this.tcMain.TabIndex = 0;
//            this.tcMain.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(38)))), ((int)(((byte)(52)))));
//            this.tcMain.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.VerticalRight;
//            // 
//            // tabDashboard
//            // 
//            this.tabDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
//            this.tabDashboard.Controls.Add(this.pnlSalesOverview);
//            this.tabDashboard.Controls.Add(this.pnlRecentInvoices);
//            this.tabDashboard.Controls.Add(this.pnlLowStock);
//            this.tabDashboard.Controls.Add(this.pnlStockValueCard);
//            this.tabDashboard.Controls.Add(this.pnlPayablesCard);
//            this.tabDashboard.Controls.Add(this.pnlReceivablesCard);
//            this.tabDashboard.Controls.Add(this.pnlPurchaseCard);
//            this.tabDashboard.Controls.Add(this.pnlUsersCard);
//            this.tabDashboard.Controls.Add(this.pnlOrdersCard);
//            this.tabDashboard.Controls.Add(this.pnlCashCard);
//            this.tabDashboard.Controls.Add(this.pnlSalesCard);
//            this.tabDashboard.Controls.Add(this.btnRefreshDashboard);
//            this.tabDashboard.Controls.Add(this.lblDashboardSubtitle);
//            this.tabDashboard.Controls.Add(this.lblDashboardTitle);
//            this.tabDashboard.Location = new System.Drawing.Point(4, 4);
//            this.tabDashboard.Name = "tabDashboard";
//            this.tabDashboard.Padding = new System.Windows.Forms.Padding(22);
//            this.tabDashboard.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
//            this.tabDashboard.Size = new System.Drawing.Size(986, 784);
//            this.tabDashboard.TabIndex = 0;
//            this.tabDashboard.Text = "Dashboard";
//            // 
//            // pnlSalesOverview
//            // 
//            this.pnlSalesOverview.BorderRadius = 14;
//            this.pnlSalesOverview.Controls.Add(this.chartSales);
//            this.pnlSalesOverview.Controls.Add(this.cmbTimeFilter);
//            this.pnlSalesOverview.Controls.Add(this.lblSalesChartSubtitle);
//            this.pnlSalesOverview.Controls.Add(this.label2);
//            this.pnlSalesOverview.FillColor = System.Drawing.Color.White;
//            this.pnlSalesOverview.Location = new System.Drawing.Point(28, 312);
//            this.pnlSalesOverview.Name = "pnlSalesOverview";
//            this.pnlSalesOverview.Size = new System.Drawing.Size(600, 220);
//            this.pnlSalesOverview.TabIndex = 20;
//            // 
//            // chartSales
//            // 
//            this.chartSales.BackColor = System.Drawing.Color.Transparent;
//            this.chartSales.Datasets.AddRange(new Guna.Charts.Interfaces.IGunaDataset[] {
//            this.gunaAreaDataset1});
//            this.chartSales.Legend.Display = false;
//            chartFont1.FontName = "Arial";
//            this.chartSales.Legend.LabelFont = chartFont1;
//            this.chartSales.Location = new System.Drawing.Point(14, 56);
//            this.chartSales.Name = "chartSales";
//            this.chartSales.Size = new System.Drawing.Size(572, 148);
//            this.chartSales.TabIndex = 3;
//            chartFont2.FontName = "Arial";
//            chartFont2.Size = 12;
//            chartFont2.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
//            this.chartSales.Title.Font = chartFont2;
//            chartFont3.FontName = "Arial";
//            this.chartSales.Tooltips.BodyFont = chartFont3;
//            chartFont4.FontName = "Arial";
//            chartFont4.Size = 9;
//            chartFont4.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
//            this.chartSales.Tooltips.TitleFont = chartFont4;
//            this.chartSales.XAxes.GridLines = grid1;
//            chartFont5.FontName = "Arial";
//            tick1.Font = chartFont5;
//            this.chartSales.XAxes.Ticks = tick1;
//            this.chartSales.YAxes.GridLines = grid2;
//            chartFont6.FontName = "Arial";
//            tick2.Font = chartFont6;
//            this.chartSales.YAxes.Ticks = tick2;
//            this.chartSales.ZAxes.GridLines = grid3;
//            chartFont7.FontName = "Arial";
//            pointLabel1.Font = chartFont7;
//            this.chartSales.ZAxes.PointLabels = pointLabel1;
//            chartFont8.FontName = "Arial";
//            tick3.Font = chartFont8;
//            this.chartSales.ZAxes.Ticks = tick3;
//            // 
//            // gunaAreaDataset1
//            // 
//            this.gunaAreaDataset1.BorderColor = System.Drawing.Color.Empty;
//            this.gunaAreaDataset1.FillColor = System.Drawing.Color.Empty;
//            this.gunaAreaDataset1.Label = "Sales";
//            this.gunaAreaDataset1.TargetChart = this.chartSales;
//            // 
//            // cmbTimeFilter
//            // 
//            this.cmbTimeFilter.BackColor = System.Drawing.Color.Transparent;
//            this.cmbTimeFilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(227)))), ((int)(((byte)(232)))));
//            this.cmbTimeFilter.BorderRadius = 7;
//            this.cmbTimeFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
//            this.cmbTimeFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
//            this.cmbTimeFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(103)))), ((int)(((byte)(240)))));
//            this.cmbTimeFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(103)))), ((int)(((byte)(240)))));
//            this.cmbTimeFilter.Font = new System.Drawing.Font("Segoe UI", 8.5F);
//            this.cmbTimeFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
//            this.cmbTimeFilter.ItemHeight = 22;
//            this.cmbTimeFilter.Items.AddRange(new object[] {
//            "آخر 10 أيام",
//            "آخر 10 أشهر"});
//            this.cmbTimeFilter.Location = new System.Drawing.Point(20, 12);
//            this.cmbTimeFilter.Name = "cmbTimeFilter";
//            this.cmbTimeFilter.Size = new System.Drawing.Size(125, 28);
//            this.cmbTimeFilter.StartIndex = 0;
//            this.cmbTimeFilter.TabIndex = 2;
//            // 
//            // lblSalesChartSubtitle
//            // 
//            this.lblSalesChartSubtitle.AutoSize = true;
//            this.lblSalesChartSubtitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
//            this.lblSalesChartSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(145)))), ((int)(((byte)(153)))));
//            this.lblSalesChartSubtitle.Location = new System.Drawing.Point(405, 38);
//            this.lblSalesChartSubtitle.Name = "lblSalesChartSubtitle";
//            this.lblSalesChartSubtitle.Size = new System.Drawing.Size(159, 15);
//            this.lblSalesChartSubtitle.TabIndex = 1;
//            this.lblSalesChartSubtitle.Text = "تطور قيمة المبيعات خلال الفترة";
//            // 
//            // label2
//            // 
//            this.label2.AutoSize = true;
//            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
//            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
//            this.label2.Location = new System.Drawing.Point(430, 14);
//            this.label2.Name = "label2";
//            this.label2.Size = new System.Drawing.Size(167, 21);
//            this.label2.TabIndex = 0;
//            this.label2.Text = "نظرة عامة على المبيعات";
//            // 
//            // pnlRecentInvoices
//            // 
//            this.pnlRecentInvoices.BackColor = System.Drawing.Color.Transparent;
//            this.pnlRecentInvoices.BorderRadius = 14;
//            this.pnlRecentInvoices.Controls.Add(this.btnViewAllInvoices);
//            this.pnlRecentInvoices.Controls.Add(this.dgvRecentInvoices);
//            this.pnlRecentInvoices.Controls.Add(this.lblInvoicesSubtitle);
//            this.pnlRecentInvoices.Controls.Add(this.lblInvoices);
//            this.pnlRecentInvoices.FillColor = System.Drawing.Color.White;
//            this.pnlRecentInvoices.Location = new System.Drawing.Point(642, 312);
//            this.pnlRecentInvoices.Name = "pnlRecentInvoices";
//            this.pnlRecentInvoices.ShadowDecoration.Enabled = true;
//            this.pnlRecentInvoices.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.pnlRecentInvoices.Size = new System.Drawing.Size(316, 220);
//            this.pnlRecentInvoices.TabIndex = 21;
//            // 
//            // btnViewAllInvoices
//            // 
//            this.btnViewAllInvoices.BorderRadius = 7;
//            this.btnViewAllInvoices.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
//            this.btnViewAllInvoices.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
//            this.btnViewAllInvoices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(103)))), ((int)(((byte)(240)))));
//            this.btnViewAllInvoices.Location = new System.Drawing.Point(10, 187);
//            this.btnViewAllInvoices.Name = "btnViewAllInvoices";
//            this.btnViewAllInvoices.Size = new System.Drawing.Size(96, 24);
//            this.btnViewAllInvoices.TabIndex = 4;
//            this.btnViewAllInvoices.Text = "عرض الكل";
//            // 
//            // dgvRecentInvoices
//            // 
//            this.dgvRecentInvoices.AllowUserToAddRows = false;
//            this.dgvRecentInvoices.AllowUserToDeleteRows = false;
//            this.dgvRecentInvoices.AllowUserToResizeRows = false;
//            this.dgvRecentInvoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
//            this.dgvRecentInvoices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
//            this.dgvRecentInvoices.ColumnHeadersHeight = 30;
//            this.dgvRecentInvoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
//            this.colInvoiceNo,
//            this.colInvoiceCustomer,
//            this.colInvoiceDate,
//            this.colInvoiceAmount});
//            this.dgvRecentInvoices.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
//            this.dgvRecentInvoices.Location = new System.Drawing.Point(10, 62);
//            this.dgvRecentInvoices.Name = "dgvRecentInvoices";
//            this.dgvRecentInvoices.ReadOnly = true;
//            this.dgvRecentInvoices.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
//            this.dgvRecentInvoices.RowHeadersVisible = false;
//            this.dgvRecentInvoices.RowTemplate.Height = 28;
//            this.dgvRecentInvoices.Size = new System.Drawing.Size(296, 120);
//            this.dgvRecentInvoices.TabIndex = 0;
//            this.dgvRecentInvoices.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Empty;
//            this.dgvRecentInvoices.ThemeStyle.AlternatingRowsStyle.Font = null;
//            this.dgvRecentInvoices.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
//            this.dgvRecentInvoices.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
//            this.dgvRecentInvoices.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
//            this.dgvRecentInvoices.ThemeStyle.BackColor = System.Drawing.Color.White;
//            this.dgvRecentInvoices.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
//            this.dgvRecentInvoices.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
//            this.dgvRecentInvoices.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
//            this.dgvRecentInvoices.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
//            this.dgvRecentInvoices.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(79)))), ((int)(((byte)(87)))));
//            this.dgvRecentInvoices.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
//            this.dgvRecentInvoices.ThemeStyle.HeaderStyle.Height = 30;
//            this.dgvRecentInvoices.ThemeStyle.ReadOnly = true;
//            this.dgvRecentInvoices.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
//            this.dgvRecentInvoices.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
//            this.dgvRecentInvoices.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8F);
//            this.dgvRecentInvoices.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
//            this.dgvRecentInvoices.ThemeStyle.RowsStyle.Height = 28;
//            this.dgvRecentInvoices.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
//            this.dgvRecentInvoices.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
//            // 
//            // colInvoiceNo
//            // 
//            this.colInvoiceNo.HeaderText = "الفاتورة";
//            this.colInvoiceNo.Name = "colInvoiceNo";
//            this.colInvoiceNo.ReadOnly = true;
//            this.colInvoiceNo.Width = 55;
//            // 
//            // colInvoiceCustomer
//            // 
//            this.colInvoiceCustomer.HeaderText = "العميل";
//            this.colInvoiceCustomer.Name = "colInvoiceCustomer";
//            this.colInvoiceCustomer.ReadOnly = true;
//            this.colInvoiceCustomer.Width = 82;
//            // 
//            // colInvoiceDate
//            // 
//            this.colInvoiceDate.HeaderText = "الوقت";
//            this.colInvoiceDate.Name = "colInvoiceDate";
//            this.colInvoiceDate.ReadOnly = true;
//            this.colInvoiceDate.Width = 60;
//            // 
//            // colInvoiceAmount
//            // 
//            this.colInvoiceAmount.HeaderText = "المبلغ";
//            this.colInvoiceAmount.Name = "colInvoiceAmount";
//            this.colInvoiceAmount.ReadOnly = true;
//            this.colInvoiceAmount.Width = 85;
//            // 
//            // lblInvoicesSubtitle
//            // 
//            this.lblInvoicesSubtitle.Font = new System.Drawing.Font("Segoe UI", 8F);
//            this.lblInvoicesSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(149)))), ((int)(((byte)(157)))));
//            this.lblInvoicesSubtitle.Location = new System.Drawing.Point(270, 37);
//            this.lblInvoicesSubtitle.Name = "lblInvoicesSubtitle";
//            this.lblInvoicesSubtitle.Size = new System.Drawing.Size(130, 18);
//            this.lblInvoicesSubtitle.TabIndex = 5;
//            this.lblInvoicesSubtitle.Text = "آخر العمليات المسجلة";
//            this.lblInvoicesSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // lblInvoices
//            // 
//            this.lblInvoices.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
//            this.lblInvoices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
//            this.lblInvoices.Location = new System.Drawing.Point(270, 12);
//            this.lblInvoices.Name = "lblInvoices";
//            this.lblInvoices.Size = new System.Drawing.Size(130, 22);
//            this.lblInvoices.TabIndex = 6;
//            this.lblInvoices.Text = "أحدث الفواتير";
//            this.lblInvoices.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // pnlLowStock
//            // 
//            this.pnlLowStock.BackColor = System.Drawing.Color.Transparent;
//            this.pnlLowStock.BorderRadius = 14;
//            this.pnlLowStock.Controls.Add(this.btnViewAllLowStock);
//            this.pnlLowStock.Controls.Add(this.dgvLowStock);
//            this.pnlLowStock.Controls.Add(this.lblLowStockSubtitle);
//            this.pnlLowStock.Controls.Add(this.lblLowStock);
//            this.pnlLowStock.FillColor = System.Drawing.Color.White;
//            this.pnlLowStock.Location = new System.Drawing.Point(28, 548);
//            this.pnlLowStock.Name = "pnlLowStock";
//            this.pnlLowStock.ShadowDecoration.Enabled = true;
//            this.pnlLowStock.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.pnlLowStock.Size = new System.Drawing.Size(930, 214);
//            this.pnlLowStock.TabIndex = 22;
//            // 
//            // btnViewAllLowStock
//            // 
//            this.btnViewAllLowStock.BorderRadius = 7;
//            this.btnViewAllLowStock.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
//            this.btnViewAllLowStock.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
//            this.btnViewAllLowStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(84)))), ((int)(((byte)(85)))));
//            this.btnViewAllLowStock.Location = new System.Drawing.Point(12, 181);
//            this.btnViewAllLowStock.Name = "btnViewAllLowStock";
//            this.btnViewAllLowStock.Size = new System.Drawing.Size(96, 24);
//            this.btnViewAllLowStock.TabIndex = 4;
//            this.btnViewAllLowStock.Text = "عرض المنتجات";
//            // 
//            // dgvLowStock
//            // 
//            this.dgvLowStock.AllowUserToAddRows = false;
//            this.dgvLowStock.AllowUserToDeleteRows = false;
//            this.dgvLowStock.AllowUserToResizeRows = false;
//            this.dgvLowStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
//            this.dgvLowStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
//            this.dgvLowStock.ColumnHeadersHeight = 30;
//            this.dgvLowStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
//            this.colLowStockProduct,
//            this.colLowStockQty,
//            this.colLowStockMinQty});
//            this.dgvLowStock.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
//            this.dgvLowStock.Location = new System.Drawing.Point(12, 62);
//            this.dgvLowStock.Name = "dgvLowStock";
//            this.dgvLowStock.ReadOnly = true;
//            this.dgvLowStock.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
//            this.dgvLowStock.RowHeadersVisible = false;
//            this.dgvLowStock.RowTemplate.Height = 28;
//            this.dgvLowStock.Size = new System.Drawing.Size(906, 112);
//            this.dgvLowStock.TabIndex = 0;
//            this.dgvLowStock.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Empty;
//            this.dgvLowStock.ThemeStyle.AlternatingRowsStyle.Font = null;
//            this.dgvLowStock.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
//            this.dgvLowStock.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
//            this.dgvLowStock.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
//            this.dgvLowStock.ThemeStyle.BackColor = System.Drawing.Color.White;
//            this.dgvLowStock.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
//            this.dgvLowStock.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
//            this.dgvLowStock.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
//            this.dgvLowStock.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
//            this.dgvLowStock.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(79)))), ((int)(((byte)(87)))));
//            this.dgvLowStock.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
//            this.dgvLowStock.ThemeStyle.HeaderStyle.Height = 30;
//            this.dgvLowStock.ThemeStyle.ReadOnly = true;
//            this.dgvLowStock.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
//            this.dgvLowStock.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
//            this.dgvLowStock.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8F);
//            this.dgvLowStock.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
//            this.dgvLowStock.ThemeStyle.RowsStyle.Height = 28;
//            this.dgvLowStock.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
//            this.dgvLowStock.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
//            // 
//            // colLowStockProduct
//            // 
//            this.colLowStockProduct.HeaderText = "اسم المنتج";
//            this.colLowStockProduct.Name = "colLowStockProduct";
//            this.colLowStockProduct.ReadOnly = true;
//            this.colLowStockProduct.Width = 540;
//            // 
//            // colLowStockQty
//            // 
//            this.colLowStockQty.HeaderText = "الكمية المتبقية";
//            this.colLowStockQty.Name = "colLowStockQty";
//            this.colLowStockQty.ReadOnly = true;
//            this.colLowStockQty.Width = 170;
//            // 
//            // colLowStockMinQty
//            // 
//            this.colLowStockMinQty.HeaderText = "حد التنبيه";
//            this.colLowStockMinQty.Name = "colLowStockMinQty";
//            this.colLowStockMinQty.ReadOnly = true;
//            this.colLowStockMinQty.Width = 170;
//            // 
//            // lblLowStockSubtitle
//            // 
//            this.lblLowStockSubtitle.Font = new System.Drawing.Font("Segoe UI", 8F);
//            this.lblLowStockSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(149)))), ((int)(((byte)(157)))));
//            this.lblLowStockSubtitle.Location = new System.Drawing.Point(690, 37);
//            this.lblLowStockSubtitle.Name = "lblLowStockSubtitle";
//            this.lblLowStockSubtitle.Size = new System.Drawing.Size(220, 18);
//            this.lblLowStockSubtitle.TabIndex = 5;
//            this.lblLowStockSubtitle.Text = "منتجات وصلت إلى حد التنبيه أو أقل";
//            this.lblLowStockSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // lblLowStock
//            // 
//            this.lblLowStock.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
//            this.lblLowStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
//            this.lblLowStock.Location = new System.Drawing.Point(785, 12);
//            this.lblLowStock.Name = "lblLowStock";
//            this.lblLowStock.Size = new System.Drawing.Size(130, 22);
//            this.lblLowStock.TabIndex = 6;
//            this.lblLowStock.Text = "تنبيهات المخزون";
//            this.lblLowStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // pnlStockValueCard
//            // 
//            this.pnlStockValueCard.BackColor = System.Drawing.Color.Transparent;
//            this.pnlStockValueCard.BorderRadius = 12;
//            this.pnlStockValueCard.Controls.Add(this.lblStockValue);
//            this.pnlStockValueCard.Controls.Add(this.lblStockValueVal);
//            this.pnlStockValueCard.Controls.Add(this.lblStockValueHint);
//            this.pnlStockValueCard.FillColor = System.Drawing.Color.White;
//            this.pnlStockValueCard.Location = new System.Drawing.Point(28, 204);
//            this.pnlStockValueCard.Name = "pnlStockValueCard";
//            this.pnlStockValueCard.ShadowDecoration.Enabled = true;
//            this.pnlStockValueCard.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.pnlStockValueCard.Size = new System.Drawing.Size(166, 92);
//            this.pnlStockValueCard.TabIndex = 23;
//            // 
//            // lblStockValue
//            // 
//            this.lblStockValue.Font = new System.Drawing.Font("Segoe UI", 9F);
//            this.lblStockValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(138)))));
//            this.lblStockValue.Location = new System.Drawing.Point(14, 11);
//            this.lblStockValue.Name = "lblStockValue";
//            this.lblStockValue.Size = new System.Drawing.Size(125, 20);
//            this.lblStockValue.TabIndex = 0;
//            this.lblStockValue.Text = "قيمة المخزون";
//            this.lblStockValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // lblStockValueVal
//            // 
//            this.lblStockValueVal.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
//            this.lblStockValueVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
//            this.lblStockValueVal.Location = new System.Drawing.Point(14, 35);
//            this.lblStockValueVal.Name = "lblStockValueVal";
//            this.lblStockValueVal.Size = new System.Drawing.Size(135, 31);
//            this.lblStockValueVal.TabIndex = 1;
//            this.lblStockValueVal.Text = "0.00";
//            this.lblStockValueVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // lblStockValueHint
//            // 
//            this.lblStockValueHint.Font = new System.Drawing.Font("Segoe UI", 8F);
//            this.lblStockValueHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(158)))), ((int)(((byte)(165)))));
//            this.lblStockValueHint.Location = new System.Drawing.Point(14, 69);
//            this.lblStockValueHint.Name = "lblStockValueHint";
//            this.lblStockValueHint.Size = new System.Drawing.Size(135, 18);
//            this.lblStockValueHint.TabIndex = 2;
//            this.lblStockValueHint.Text = "القيمة التقديرية";
//            this.lblStockValueHint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // pnlPayablesCard
//            // 
//            this.pnlPayablesCard.BackColor = System.Drawing.Color.Transparent;
//            this.pnlPayablesCard.BorderRadius = 12;
//            this.pnlPayablesCard.Controls.Add(this.lblPayables);
//            this.pnlPayablesCard.Controls.Add(this.lblPayablesVal);
//            this.pnlPayablesCard.Controls.Add(this.lblPayablesHint);
//            this.pnlPayablesCard.FillColor = System.Drawing.Color.White;
//            this.pnlPayablesCard.Location = new System.Drawing.Point(210, 204);
//            this.pnlPayablesCard.Name = "pnlPayablesCard";
//            this.pnlPayablesCard.ShadowDecoration.Enabled = true;
//            this.pnlPayablesCard.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.pnlPayablesCard.Size = new System.Drawing.Size(240, 92);
//            this.pnlPayablesCard.TabIndex = 24;
//            // 
//            // lblPayables
//            // 
//            this.lblPayables.Font = new System.Drawing.Font("Segoe UI", 9F);
//            this.lblPayables.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(138)))));
//            this.lblPayables.Location = new System.Drawing.Point(18, 11);
//            this.lblPayables.Name = "lblPayables";
//            this.lblPayables.Size = new System.Drawing.Size(130, 20);
//            this.lblPayables.TabIndex = 0;
//            this.lblPayables.Text = "ذمم الموردين";
//            this.lblPayables.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // lblPayablesVal
//            // 
//            this.lblPayablesVal.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
//            this.lblPayablesVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(193)))));
//            this.lblPayablesVal.Location = new System.Drawing.Point(18, 35);
//            this.lblPayablesVal.Name = "lblPayablesVal";
//            this.lblPayablesVal.Size = new System.Drawing.Size(180, 31);
//            this.lblPayablesVal.TabIndex = 1;
//            this.lblPayablesVal.Text = "0.00 ل.س";
//            this.lblPayablesVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // lblPayablesHint
//            // 
//            this.lblPayablesHint.Font = new System.Drawing.Font("Segoe UI", 8F);
//            this.lblPayablesHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(158)))), ((int)(((byte)(165)))));
//            this.lblPayablesHint.Location = new System.Drawing.Point(18, 69);
//            this.lblPayablesHint.Name = "lblPayablesHint";
//            this.lblPayablesHint.Size = new System.Drawing.Size(180, 18);
//            this.lblPayablesHint.TabIndex = 2;
//            this.lblPayablesHint.Text = "المبالغ المستحقة";
//            this.lblPayablesHint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // pnlReceivablesCard
//            // 
//            this.pnlReceivablesCard.BackColor = System.Drawing.Color.Transparent;
//            this.pnlReceivablesCard.BorderRadius = 12;
//            this.pnlReceivablesCard.Controls.Add(this.lblReceivables);
//            this.pnlReceivablesCard.Controls.Add(this.lblReceivablesVal);
//            this.pnlReceivablesCard.Controls.Add(this.lblReceivablesHint);
//            this.pnlReceivablesCard.FillColor = System.Drawing.Color.White;
//            this.pnlReceivablesCard.Location = new System.Drawing.Point(464, 204);
//            this.pnlReceivablesCard.Name = "pnlReceivablesCard";
//            this.pnlReceivablesCard.ShadowDecoration.Enabled = true;
//            this.pnlReceivablesCard.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.pnlReceivablesCard.Size = new System.Drawing.Size(240, 92);
//            this.pnlReceivablesCard.TabIndex = 25;
//            // 
//            // lblReceivables
//            // 
//            this.lblReceivables.Font = new System.Drawing.Font("Segoe UI", 9F);
//            this.lblReceivables.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(138)))));
//            this.lblReceivables.Location = new System.Drawing.Point(18, 11);
//            this.lblReceivables.Name = "lblReceivables";
//            this.lblReceivables.Size = new System.Drawing.Size(130, 20);
//            this.lblReceivables.TabIndex = 0;
//            this.lblReceivables.Text = "ذمم العملاء";
//            this.lblReceivables.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // lblReceivablesVal
//            // 
//            this.lblReceivablesVal.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
//            this.lblReceivablesVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(84)))), ((int)(((byte)(85)))));
//            this.lblReceivablesVal.Location = new System.Drawing.Point(18, 35);
//            this.lblReceivablesVal.Name = "lblReceivablesVal";
//            this.lblReceivablesVal.Size = new System.Drawing.Size(180, 31);
//            this.lblReceivablesVal.TabIndex = 1;
//            this.lblReceivablesVal.Text = "0.00 ل.س";
//            this.lblReceivablesVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // lblReceivablesHint
//            // 
//            this.lblReceivablesHint.Font = new System.Drawing.Font("Segoe UI", 8F);
//            this.lblReceivablesHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(158)))), ((int)(((byte)(165)))));
//            this.lblReceivablesHint.Location = new System.Drawing.Point(18, 69);
//            this.lblReceivablesHint.Name = "lblReceivablesHint";
//            this.lblReceivablesHint.Size = new System.Drawing.Size(180, 18);
//            this.lblReceivablesHint.TabIndex = 2;
//            this.lblReceivablesHint.Text = "المبالغ المستحقة";
//            this.lblReceivablesHint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // pnlPurchaseCard
//            // 
//            this.pnlPurchaseCard.BackColor = System.Drawing.Color.Transparent;
//            this.pnlPurchaseCard.BorderRadius = 12;
//            this.pnlPurchaseCard.Controls.Add(this.lblTodayPurchases);
//            this.pnlPurchaseCard.Controls.Add(this.lblTodayPurchasesVal);
//            this.pnlPurchaseCard.Controls.Add(this.lblTodayPurchasesTrend);
//            this.pnlPurchaseCard.FillColor = System.Drawing.Color.White;
//            this.pnlPurchaseCard.Location = new System.Drawing.Point(718, 204);
//            this.pnlPurchaseCard.Name = "pnlPurchaseCard";
//            this.pnlPurchaseCard.ShadowDecoration.Enabled = true;
//            this.pnlPurchaseCard.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.pnlPurchaseCard.Size = new System.Drawing.Size(240, 92);
//            this.pnlPurchaseCard.TabIndex = 26;
//            // 
//            // lblTodayPurchases
//            // 
//            this.lblTodayPurchases.Font = new System.Drawing.Font("Segoe UI", 9F);
//            this.lblTodayPurchases.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(138)))));
//            this.lblTodayPurchases.Location = new System.Drawing.Point(18, 11);
//            this.lblTodayPurchases.Name = "lblTodayPurchases";
//            this.lblTodayPurchases.Size = new System.Drawing.Size(130, 20);
//            this.lblTodayPurchases.TabIndex = 0;
//            this.lblTodayPurchases.Text = "مشتريات اليوم";
//            this.lblTodayPurchases.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // lblTodayPurchasesVal
//            // 
//            this.lblTodayPurchasesVal.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
//            this.lblTodayPurchasesVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
//            this.lblTodayPurchasesVal.Location = new System.Drawing.Point(18, 35);
//            this.lblTodayPurchasesVal.Name = "lblTodayPurchasesVal";
//            this.lblTodayPurchasesVal.Size = new System.Drawing.Size(180, 31);
//            this.lblTodayPurchasesVal.TabIndex = 1;
//            this.lblTodayPurchasesVal.Text = "0.00 ل.س";
//            this.lblTodayPurchasesVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // lblTodayPurchasesTrend
//            // 
//            this.lblTodayPurchasesTrend.Font = new System.Drawing.Font("Segoe UI", 8F);
//            this.lblTodayPurchasesTrend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(158)))), ((int)(((byte)(165)))));
//            this.lblTodayPurchasesTrend.Location = new System.Drawing.Point(18, 69);
//            this.lblTodayPurchasesTrend.Name = "lblTodayPurchasesTrend";
//            this.lblTodayPurchasesTrend.Size = new System.Drawing.Size(180, 18);
//            this.lblTodayPurchasesTrend.TabIndex = 2;
//            this.lblTodayPurchasesTrend.Text = "إجمالي المشتريات";
//            this.lblTodayPurchasesTrend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // pnlUsersCard
//            // 
//            this.pnlUsersCard.BackColor = System.Drawing.Color.Transparent;
//            this.pnlUsersCard.BorderRadius = 12;
//            this.pnlUsersCard.Controls.Add(this.DDSFSFSF);
//            this.pnlUsersCard.Controls.Add(this.lblProfitVal);
//            this.pnlUsersCard.Controls.Add(this.lblProfitTrend);
//            this.pnlUsersCard.FillColor = System.Drawing.Color.White;
//            this.pnlUsersCard.Location = new System.Drawing.Point(28, 84);
//            this.pnlUsersCard.Name = "pnlUsersCard";
//            this.pnlUsersCard.ShadowDecoration.Enabled = true;
//            this.pnlUsersCard.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.pnlUsersCard.Size = new System.Drawing.Size(166, 108);
//            this.pnlUsersCard.TabIndex = 27;
//            // 
//            // DDSFSFSF
//            // 
//            this.DDSFSFSF.Font = new System.Drawing.Font("Segoe UI", 9F);
//            this.DDSFSFSF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(138)))));
//            this.DDSFSFSF.Location = new System.Drawing.Point(16, 13);
//            this.DDSFSFSF.Name = "DDSFSFSF";
//            this.DDSFSFSF.Size = new System.Drawing.Size(120, 20);
//            this.DDSFSFSF.TabIndex = 0;
//            this.DDSFSFSF.Text = "أرباح اليوم";
//            this.DDSFSFSF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // lblProfitVal
//            // 
//            this.lblProfitVal.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
//            this.lblProfitVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(199)))), ((int)(((byte)(111)))));
//            this.lblProfitVal.Location = new System.Drawing.Point(16, 39);
//            this.lblProfitVal.Name = "lblProfitVal";
//            this.lblProfitVal.Size = new System.Drawing.Size(135, 31);
//            this.lblProfitVal.TabIndex = 1;
//            this.lblProfitVal.Text = "0.00";
//            this.lblProfitVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // lblProfitTrend
//            // 
//            this.lblProfitTrend.Font = new System.Drawing.Font("Segoe UI", 8F);
//            this.lblProfitTrend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(158)))), ((int)(((byte)(165)))));
//            this.lblProfitTrend.Location = new System.Drawing.Point(16, 78);
//            this.lblProfitTrend.Name = "lblProfitTrend";
//            this.lblProfitTrend.Size = new System.Drawing.Size(135, 18);
//            this.lblProfitTrend.TabIndex = 2;
//            this.lblProfitTrend.Text = "صافي الربح";
//            this.lblProfitTrend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // pnlOrdersCard
//            // 
//            this.pnlOrdersCard.BackColor = System.Drawing.Color.Transparent;
//            this.pnlOrdersCard.BorderRadius = 12;
//            this.pnlOrdersCard.Controls.Add(this.ddfsfsf);
//            this.pnlOrdersCard.Controls.Add(this.lblTotalOrdersVal);
//            this.pnlOrdersCard.Controls.Add(this.lblTotalOrdersTrend);
//            this.pnlOrdersCard.FillColor = System.Drawing.Color.White;
//            this.pnlOrdersCard.Location = new System.Drawing.Point(210, 84);
//            this.pnlOrdersCard.Name = "pnlOrdersCard";
//            this.pnlOrdersCard.ShadowDecoration.Enabled = true;
//            this.pnlOrdersCard.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.pnlOrdersCard.Size = new System.Drawing.Size(240, 108);
//            this.pnlOrdersCard.TabIndex = 28;
//            // 
//            // ddfsfsf
//            // 
//            this.ddfsfsf.Font = new System.Drawing.Font("Segoe UI", 9F);
//            this.ddfsfsf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(138)))));
//            this.ddfsfsf.Location = new System.Drawing.Point(20, 13);
//            this.ddfsfsf.Name = "ddfsfsf";
//            this.ddfsfsf.Size = new System.Drawing.Size(130, 20);
//            this.ddfsfsf.TabIndex = 0;
//            this.ddfsfsf.Text = "عدد فواتير اليوم";
//            this.ddfsfsf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // lblTotalOrdersVal
//            // 
//            this.lblTotalOrdersVal.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
//            this.lblTotalOrdersVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
//            this.lblTotalOrdersVal.Location = new System.Drawing.Point(20, 39);
//            this.lblTotalOrdersVal.Name = "lblTotalOrdersVal";
//            this.lblTotalOrdersVal.Size = new System.Drawing.Size(180, 31);
//            this.lblTotalOrdersVal.TabIndex = 1;
//            this.lblTotalOrdersVal.Text = "0";
//            this.lblTotalOrdersVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // lblTotalOrdersTrend
//            // 
//            this.lblTotalOrdersTrend.Font = new System.Drawing.Font("Segoe UI", 8F);
//            this.lblTotalOrdersTrend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(158)))), ((int)(((byte)(165)))));
//            this.lblTotalOrdersTrend.Location = new System.Drawing.Point(20, 78);
//            this.lblTotalOrdersTrend.Name = "lblTotalOrdersTrend";
//            this.lblTotalOrdersTrend.Size = new System.Drawing.Size(180, 18);
//            this.lblTotalOrdersTrend.TabIndex = 2;
//            this.lblTotalOrdersTrend.Text = "إجمالي الفواتير";
//            this.lblTotalOrdersTrend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // pnlCashCard
//            // 
//            this.pnlCashCard.BackColor = System.Drawing.Color.Transparent;
//            this.pnlCashCard.BorderRadius = 12;
//            this.pnlCashCard.Controls.Add(this.DFSSFS);
//            this.pnlCashCard.Controls.Add(this.lblCashBalanceVal);
//            this.pnlCashCard.Controls.Add(this.lblCashBalanceTrend);
//            this.pnlCashCard.FillColor = System.Drawing.Color.White;
//            this.pnlCashCard.Location = new System.Drawing.Point(464, 84);
//            this.pnlCashCard.Name = "pnlCashCard";
//            this.pnlCashCard.ShadowDecoration.Enabled = true;
//            this.pnlCashCard.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.pnlCashCard.Size = new System.Drawing.Size(240, 108);
//            this.pnlCashCard.TabIndex = 29;
//            // 
//            // DFSSFS
//            // 
//            this.DFSSFS.Font = new System.Drawing.Font("Segoe UI", 9F);
//            this.DFSSFS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(138)))));
//            this.DFSSFS.Location = new System.Drawing.Point(20, 13);
//            this.DFSSFS.Name = "DFSSFS";
//            this.DFSSFS.Size = new System.Drawing.Size(120, 20);
//            this.DFSSFS.TabIndex = 0;
//            this.DFSSFS.Text = "رصيد الصندوق";
//            this.DFSSFS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // lblCashBalanceVal
//            // 
//            this.lblCashBalanceVal.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
//            this.lblCashBalanceVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(199)))), ((int)(((byte)(111)))));
//            this.lblCashBalanceVal.Location = new System.Drawing.Point(20, 39);
//            this.lblCashBalanceVal.Name = "lblCashBalanceVal";
//            this.lblCashBalanceVal.Size = new System.Drawing.Size(180, 31);
//            this.lblCashBalanceVal.TabIndex = 1;
//            this.lblCashBalanceVal.Text = "0.00 ل.س";
//            this.lblCashBalanceVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // lblCashBalanceTrend
//            // 
//            this.lblCashBalanceTrend.Font = new System.Drawing.Font("Segoe UI", 8F);
//            this.lblCashBalanceTrend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(158)))), ((int)(((byte)(165)))));
//            this.lblCashBalanceTrend.Location = new System.Drawing.Point(20, 78);
//            this.lblCashBalanceTrend.Name = "lblCashBalanceTrend";
//            this.lblCashBalanceTrend.Size = new System.Drawing.Size(180, 18);
//            this.lblCashBalanceTrend.TabIndex = 2;
//            this.lblCashBalanceTrend.Text = "الرصيد الحالي";
//            this.lblCashBalanceTrend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // pnlSalesCard
//            // 
//            this.pnlSalesCard.BackColor = System.Drawing.Color.Transparent;
//            this.pnlSalesCard.BorderRadius = 12;
//            this.pnlSalesCard.Controls.Add(this.lblTodaySales);
//            this.pnlSalesCard.Controls.Add(this.lblTodaySalesVal);
//            this.pnlSalesCard.Controls.Add(this.lblTodaySalesTrend);
//            this.pnlSalesCard.FillColor = System.Drawing.Color.White;
//            this.pnlSalesCard.Location = new System.Drawing.Point(718, 84);
//            this.pnlSalesCard.Name = "pnlSalesCard";
//            this.pnlSalesCard.ShadowDecoration.Enabled = true;
//            this.pnlSalesCard.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.pnlSalesCard.Size = new System.Drawing.Size(240, 108);
//            this.pnlSalesCard.TabIndex = 30;
//            // 
//            // lblTodaySales
//            // 
//            this.lblTodaySales.Font = new System.Drawing.Font("Segoe UI", 9F);
//            this.lblTodaySales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(138)))));
//            this.lblTodaySales.Location = new System.Drawing.Point(20, 13);
//            this.lblTodaySales.Name = "lblTodaySales";
//            this.lblTodaySales.Size = new System.Drawing.Size(100, 20);
//            this.lblTodaySales.TabIndex = 0;
//            this.lblTodaySales.Text = "مبيعات اليوم";
//            this.lblTodaySales.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // lblTodaySalesVal
//            // 
//            this.lblTodaySalesVal.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
//            this.lblTodaySalesVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(103)))), ((int)(((byte)(240)))));
//            this.lblTodaySalesVal.Location = new System.Drawing.Point(20, 39);
//            this.lblTodaySalesVal.Name = "lblTodaySalesVal";
//            this.lblTodaySalesVal.Size = new System.Drawing.Size(180, 31);
//            this.lblTodaySalesVal.TabIndex = 1;
//            this.lblTodaySalesVal.Text = "0.00 ل.س";
//            this.lblTodaySalesVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // lblTodaySalesTrend
//            // 
//            this.lblTodaySalesTrend.Font = new System.Drawing.Font("Segoe UI", 8F);
//            this.lblTodaySalesTrend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(158)))), ((int)(((byte)(165)))));
//            this.lblTodaySalesTrend.Location = new System.Drawing.Point(20, 78);
//            this.lblTodaySalesTrend.Name = "lblTodaySalesTrend";
//            this.lblTodaySalesTrend.Size = new System.Drawing.Size(180, 18);
//            this.lblTodaySalesTrend.TabIndex = 2;
//            this.lblTodaySalesTrend.Text = "مقارنة مع أمس";
//            this.lblTodaySalesTrend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // btnRefreshDashboard
//            // 
//            this.btnRefreshDashboard.BackColor = System.Drawing.Color.Transparent;
//            this.btnRefreshDashboard.BorderRadius = 10;
//            this.btnRefreshDashboard.FillColor = System.Drawing.Color.White;
//            this.btnRefreshDashboard.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
//            this.btnRefreshDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(103)))), ((int)(((byte)(240)))));
//            this.btnRefreshDashboard.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
//            this.btnRefreshDashboard.Location = new System.Drawing.Point(28, 23);
//            this.btnRefreshDashboard.Name = "btnRefreshDashboard";
//            this.btnRefreshDashboard.ShadowDecoration.Enabled = true;
//            this.btnRefreshDashboard.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.btnRefreshDashboard.Size = new System.Drawing.Size(108, 38);
//            this.btnRefreshDashboard.TabIndex = 2;
//            this.btnRefreshDashboard.Text = "⟳  تحديث";
//            // 
//            // lblDashboardSubtitle
//            // 
//            this.lblDashboardSubtitle.AutoSize = true;
//            this.lblDashboardSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
//            this.lblDashboardSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(126)))), ((int)(((byte)(136)))));
//            this.lblDashboardSubtitle.Location = new System.Drawing.Point(464, 54);
//            this.lblDashboardSubtitle.Name = "lblDashboardSubtitle";
//            this.lblDashboardSubtitle.Size = new System.Drawing.Size(270, 17);
//            this.lblDashboardSubtitle.TabIndex = 1;
//            this.lblDashboardSubtitle.Text = "ملخص سريع لحالة المبيعات والمخزون والحسابات";
//            // 
//            // lblDashboardTitle
//            // 
//            this.lblDashboardTitle.AutoSize = true;
//            this.lblDashboardTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
//            this.lblDashboardTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
//            this.lblDashboardTitle.Location = new System.Drawing.Point(772, 42);
//            this.lblDashboardTitle.Name = "lblDashboardTitle";
//            this.lblDashboardTitle.Size = new System.Drawing.Size(214, 32);
//            this.lblDashboardTitle.TabIndex = 0;
//            this.lblDashboardTitle.Text = "لوحة التحكم الرئيسية";
//            // 
//            // tabSales
//            // 
//            this.tabSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
//            this.tabSales.Controls.Add(this.lblSalesSubtitle);
//            this.tabSales.Controls.Add(this.lblSalesTitle);
//            this.tabSales.Controls.Add(this.pnlSalesActions);
//            this.tabSales.Controls.Add(this.pnlSalesDebt);
//            this.tabSales.Controls.Add(this.pnlSalesInvoices);
//            this.tabSales.Controls.Add(this.pnlSalesToday);
//            this.tabSales.Controls.Add(this.btnListSales);
//            this.tabSales.Controls.Add(this.btnAddNewSale);
//            this.tabSales.Location = new System.Drawing.Point(4, 4);
//            this.tabSales.Name = "tabSales";
//            this.tabSales.Padding = new System.Windows.Forms.Padding(28);
//            this.tabSales.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
//            this.tabSales.Size = new System.Drawing.Size(986, 784);
//            this.tabSales.TabIndex = 1;
//            // 
//            // lblSalesSubtitle
//            // 
//            this.lblSalesSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
//            this.lblSalesSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(126)))), ((int)(((byte)(136)))));
//            this.lblSalesSubtitle.Location = new System.Drawing.Point(480, 55);
//            this.lblSalesSubtitle.Name = "lblSalesSubtitle";
//            this.lblSalesSubtitle.Size = new System.Drawing.Size(478, 20);
//            this.lblSalesSubtitle.TabIndex = 1;
//            this.lblSalesSubtitle.Text = "إنشاء الفواتير ومراجعة عمليات البيع اليومية";
//            this.lblSalesSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // lblSalesTitle
//            // 
//            this.lblSalesTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
//            this.lblSalesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
//            this.lblSalesTitle.Location = new System.Drawing.Point(600, 20);
//            this.lblSalesTitle.Name = "lblSalesTitle";
//            this.lblSalesTitle.Size = new System.Drawing.Size(358, 32);
//            this.lblSalesTitle.TabIndex = 0;
//            this.lblSalesTitle.Text = "المبيعات";
//            this.lblSalesTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // pnlSalesActions
//            // 
//            this.pnlSalesActions.BackColor = System.Drawing.Color.Transparent;
//            this.pnlSalesActions.BorderRadius = 12;
//            this.pnlSalesActions.Controls.Add(this.lblSalesActionsHint);
//            this.pnlSalesActions.Controls.Add(this.lblSalesActions);
//            this.pnlSalesActions.FillColor = System.Drawing.Color.White;
//            this.pnlSalesActions.Location = new System.Drawing.Point(28, 340);
//            this.pnlSalesActions.Name = "pnlSalesActions";
//            this.pnlSalesActions.ShadowDecoration.Enabled = true;
//            this.pnlSalesActions.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.pnlSalesActions.Size = new System.Drawing.Size(930, 150);
//            this.pnlSalesActions.TabIndex = 2;
//            // 
//            // lblSalesActionsHint
//            // 
//            this.lblSalesActionsHint.Font = new System.Drawing.Font("Segoe UI", 8.5F);
//            this.lblSalesActionsHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(138)))));
//            this.lblSalesActionsHint.Location = new System.Drawing.Point(18, 46);
//            this.lblSalesActionsHint.Name = "lblSalesActionsHint";
//            this.lblSalesActionsHint.Size = new System.Drawing.Size(894, 92);
//            this.lblSalesActionsHint.TabIndex = 0;
//            this.lblSalesActionsHint.Text = "ابدأ بإنشاء فاتورة جديدة أو افتح قائمة المبيعات للبحث، المراجعة، والتعديل على الف" +
//    "واتير المسجلة.";
//            this.lblSalesActionsHint.TextAlign = System.Drawing.ContentAlignment.TopRight;
//            // 
//            // lblSalesActions
//            // 
//            this.lblSalesActions.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
//            this.lblSalesActions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
//            this.lblSalesActions.Location = new System.Drawing.Point(18, 16);
//            this.lblSalesActions.Name = "lblSalesActions";
//            this.lblSalesActions.Size = new System.Drawing.Size(894, 24);
//            this.lblSalesActions.TabIndex = 1;
//            this.lblSalesActions.Text = "إدارة المبيعات";
//            this.lblSalesActions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // pnlSalesDebt
//            // 
//            this.pnlSalesDebt.BackColor = System.Drawing.Color.Transparent;
//            this.pnlSalesDebt.BorderRadius = 12;
//            this.pnlSalesDebt.Controls.Add(this.lblSalesDebtValue);
//            this.pnlSalesDebt.Controls.Add(this.lblSalesDebtCaption);
//            this.pnlSalesDebt.FillColor = System.Drawing.Color.White;
//            this.pnlSalesDebt.Location = new System.Drawing.Point(160, 216);
//            this.pnlSalesDebt.Name = "pnlSalesDebt";
//            this.pnlSalesDebt.ShadowDecoration.Enabled = true;
//            this.pnlSalesDebt.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.pnlSalesDebt.Size = new System.Drawing.Size(254, 100);
//            this.pnlSalesDebt.TabIndex = 3;
//            // 
//            // lblSalesDebtValue
//            // 
//            this.lblSalesDebtValue.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
//            this.lblSalesDebtValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(84)))), ((int)(((byte)(85)))));
//            this.lblSalesDebtValue.Location = new System.Drawing.Point(16, 38);
//            this.lblSalesDebtValue.Name = "lblSalesDebtValue";
//            this.lblSalesDebtValue.Size = new System.Drawing.Size(222, 30);
//            this.lblSalesDebtValue.TabIndex = 0;
//            this.lblSalesDebtValue.Text = "0.00 ل.س";
//            this.lblSalesDebtValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // lblSalesDebtCaption
//            // 
//            this.lblSalesDebtCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
//            this.lblSalesDebtCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(138)))));
//            this.lblSalesDebtCaption.Location = new System.Drawing.Point(16, 12);
//            this.lblSalesDebtCaption.Name = "lblSalesDebtCaption";
//            this.lblSalesDebtCaption.Size = new System.Drawing.Size(222, 20);
//            this.lblSalesDebtCaption.TabIndex = 1;
//            this.lblSalesDebtCaption.Text = "مبيعات الآجل";
//            this.lblSalesDebtCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // pnlSalesInvoices
//            // 
//            this.pnlSalesInvoices.BackColor = System.Drawing.Color.Transparent;
//            this.pnlSalesInvoices.BorderRadius = 12;
//            this.pnlSalesInvoices.Controls.Add(this.lblSalesInvoicesValue);
//            this.pnlSalesInvoices.Controls.Add(this.lblSalesInvoicesCaption);
//            this.pnlSalesInvoices.FillColor = System.Drawing.Color.White;
//            this.pnlSalesInvoices.Location = new System.Drawing.Point(432, 216);
//            this.pnlSalesInvoices.Name = "pnlSalesInvoices";
//            this.pnlSalesInvoices.ShadowDecoration.Enabled = true;
//            this.pnlSalesInvoices.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.pnlSalesInvoices.Size = new System.Drawing.Size(254, 100);
//            this.pnlSalesInvoices.TabIndex = 4;
//            // 
//            // lblSalesInvoicesValue
//            // 
//            this.lblSalesInvoicesValue.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
//            this.lblSalesInvoicesValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
//            this.lblSalesInvoicesValue.Location = new System.Drawing.Point(16, 38);
//            this.lblSalesInvoicesValue.Name = "lblSalesInvoicesValue";
//            this.lblSalesInvoicesValue.Size = new System.Drawing.Size(222, 30);
//            this.lblSalesInvoicesValue.TabIndex = 0;
//            this.lblSalesInvoicesValue.Text = "0";
//            this.lblSalesInvoicesValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // lblSalesInvoicesCaption
//            // 
//            this.lblSalesInvoicesCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
//            this.lblSalesInvoicesCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(138)))));
//            this.lblSalesInvoicesCaption.Location = new System.Drawing.Point(16, 12);
//            this.lblSalesInvoicesCaption.Name = "lblSalesInvoicesCaption";
//            this.lblSalesInvoicesCaption.Size = new System.Drawing.Size(222, 20);
//            this.lblSalesInvoicesCaption.TabIndex = 1;
//            this.lblSalesInvoicesCaption.Text = "فواتير اليوم";
//            this.lblSalesInvoicesCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // pnlSalesToday
//            // 
//            this.pnlSalesToday.BackColor = System.Drawing.Color.Transparent;
//            this.pnlSalesToday.BorderRadius = 12;
//            this.pnlSalesToday.Controls.Add(this.lblSalesTodayValue);
//            this.pnlSalesToday.Controls.Add(this.lblSalesTodayCaption);
//            this.pnlSalesToday.FillColor = System.Drawing.Color.White;
//            this.pnlSalesToday.Location = new System.Drawing.Point(704, 216);
//            this.pnlSalesToday.Name = "pnlSalesToday";
//            this.pnlSalesToday.ShadowDecoration.Enabled = true;
//            this.pnlSalesToday.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.pnlSalesToday.Size = new System.Drawing.Size(254, 100);
//            this.pnlSalesToday.TabIndex = 5;
//            // 
//            // lblSalesTodayValue
//            // 
//            this.lblSalesTodayValue.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
//            this.lblSalesTodayValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(103)))), ((int)(((byte)(240)))));
//            this.lblSalesTodayValue.Location = new System.Drawing.Point(16, 38);
//            this.lblSalesTodayValue.Name = "lblSalesTodayValue";
//            this.lblSalesTodayValue.Size = new System.Drawing.Size(222, 30);
//            this.lblSalesTodayValue.TabIndex = 0;
//            this.lblSalesTodayValue.Text = "0.00 ل.س";
//            this.lblSalesTodayValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // lblSalesTodayCaption
//            // 
//            this.lblSalesTodayCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
//            this.lblSalesTodayCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(138)))));
//            this.lblSalesTodayCaption.Location = new System.Drawing.Point(16, 12);
//            this.lblSalesTodayCaption.Name = "lblSalesTodayCaption";
//            this.lblSalesTodayCaption.Size = new System.Drawing.Size(222, 20);
//            this.lblSalesTodayCaption.TabIndex = 1;
//            this.lblSalesTodayCaption.Text = "مبيعات اليوم";
//            this.lblSalesTodayCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // btnListSales
//            // 
//            this.btnListSales.BackColor = System.Drawing.Color.Transparent;
//            this.btnListSales.BorderRadius = 12;
//            this.btnListSales.FillColor = System.Drawing.Color.White;
//            this.btnListSales.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
//            this.btnListSales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
//            this.btnListSales.HoverState.FillColor = System.Drawing.Color.White;
//            this.btnListSales.Location = new System.Drawing.Point(432, 84);
//            this.btnListSales.Name = "btnListSales";
//            this.btnListSales.ShadowDecoration.Enabled = true;
//            this.btnListSales.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.btnListSales.Size = new System.Drawing.Size(254, 112);
//            this.btnListSales.TabIndex = 0;
//            this.btnListSales.Text = "☷  قائمة المبيعات";
//            // 
//            // btnAddNewSale
//            // 
//            this.btnAddNewSale.BackColor = System.Drawing.Color.Transparent;
//            this.btnAddNewSale.BorderRadius = 12;
//            this.btnAddNewSale.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(103)))), ((int)(((byte)(240)))));
//            this.btnAddNewSale.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
//            this.btnAddNewSale.ForeColor = System.Drawing.Color.White;
//            this.btnAddNewSale.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(103)))), ((int)(((byte)(240)))));
//            this.btnAddNewSale.Location = new System.Drawing.Point(704, 84);
//            this.btnAddNewSale.Name = "btnAddNewSale";
//            this.btnAddNewSale.ShadowDecoration.Enabled = true;
//            this.btnAddNewSale.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.btnAddNewSale.Size = new System.Drawing.Size(254, 112);
//            this.btnAddNewSale.TabIndex = 0;
//            this.btnAddNewSale.Text = "＋  إضافة بيع جديد";
//            // 
//            // tabPurchases
//            // 
//            this.tabPurchases.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
//            this.tabPurchases.Controls.Add(this.lblPurchasesSubtitle);
//            this.tabPurchases.Controls.Add(this.lblPurchasesTitle);
//            this.tabPurchases.Controls.Add(this.pnlPurchasesActions);
//            this.tabPurchases.Controls.Add(this.pnlPurchasesDebt);
//            this.tabPurchases.Controls.Add(this.pnlPurchasesInvoices);
//            this.tabPurchases.Controls.Add(this.pnlPurchasesToday);
//            this.tabPurchases.Controls.Add(this.btnListPurchases);
//            this.tabPurchases.Controls.Add(this.btnAddNewPurchase);
//            this.tabPurchases.Location = new System.Drawing.Point(4, 4);
//            this.tabPurchases.Name = "tabPurchases";
//            this.tabPurchases.Padding = new System.Windows.Forms.Padding(28);
//            this.tabPurchases.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
//            this.tabPurchases.Size = new System.Drawing.Size(986, 784);
//            this.tabPurchases.TabIndex = 2;
//            // 
//            // lblPurchasesSubtitle
//            // 
//            this.lblPurchasesSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
//            this.lblPurchasesSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(126)))), ((int)(((byte)(136)))));
//            this.lblPurchasesSubtitle.Location = new System.Drawing.Point(480, 55);
//            this.lblPurchasesSubtitle.Name = "lblPurchasesSubtitle";
//            this.lblPurchasesSubtitle.Size = new System.Drawing.Size(478, 20);
//            this.lblPurchasesSubtitle.TabIndex = 1;
//            this.lblPurchasesSubtitle.Text = "تسجيل مشتريات البضاعة ومتابعة التزامات الموردين";
//            this.lblPurchasesSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // lblPurchasesTitle
//            // 
//            this.lblPurchasesTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
//            this.lblPurchasesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
//            this.lblPurchasesTitle.Location = new System.Drawing.Point(600, 20);
//            this.lblPurchasesTitle.Name = "lblPurchasesTitle";
//            this.lblPurchasesTitle.Size = new System.Drawing.Size(358, 32);
//            this.lblPurchasesTitle.TabIndex = 0;
//            this.lblPurchasesTitle.Text = "المشتريات";
//            this.lblPurchasesTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // pnlPurchasesActions
//            // 
//            this.pnlPurchasesActions.BackColor = System.Drawing.Color.Transparent;
//            this.pnlPurchasesActions.BorderRadius = 12;
//            this.pnlPurchasesActions.Controls.Add(this.lblPurchasesActionsHint);
//            this.pnlPurchasesActions.Controls.Add(this.lblPurchasesActions);
//            this.pnlPurchasesActions.FillColor = System.Drawing.Color.White;
//            this.pnlPurchasesActions.Location = new System.Drawing.Point(28, 340);
//            this.pnlPurchasesActions.Name = "pnlPurchasesActions";
//            this.pnlPurchasesActions.ShadowDecoration.Enabled = true;
//            this.pnlPurchasesActions.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.pnlPurchasesActions.Size = new System.Drawing.Size(930, 150);
//            this.pnlPurchasesActions.TabIndex = 2;
//            // 
//            // lblPurchasesActionsHint
//            // 
//            this.lblPurchasesActionsHint.Font = new System.Drawing.Font("Segoe UI", 8.5F);
//            this.lblPurchasesActionsHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(138)))));
//            this.lblPurchasesActionsHint.Location = new System.Drawing.Point(18, 46);
//            this.lblPurchasesActionsHint.Name = "lblPurchasesActionsHint";
//            this.lblPurchasesActionsHint.Size = new System.Drawing.Size(894, 92);
//            this.lblPurchasesActionsHint.TabIndex = 0;
//            this.lblPurchasesActionsHint.Text = "سجل مشترياتك مع الحفاظ على تكلفة الشراء التاريخية، ثم راجع الفواتير والذمم الخاصة" +
//    " بالموردين.";
//            this.lblPurchasesActionsHint.TextAlign = System.Drawing.ContentAlignment.TopRight;
//            // 
//            // lblPurchasesActions
//            // 
//            this.lblPurchasesActions.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
//            this.lblPurchasesActions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
//            this.lblPurchasesActions.Location = new System.Drawing.Point(18, 16);
//            this.lblPurchasesActions.Name = "lblPurchasesActions";
//            this.lblPurchasesActions.Size = new System.Drawing.Size(894, 24);
//            this.lblPurchasesActions.TabIndex = 1;
//            this.lblPurchasesActions.Text = "إدارة المشتريات";
//            this.lblPurchasesActions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // pnlPurchasesDebt
//            // 
//            this.pnlPurchasesDebt.BackColor = System.Drawing.Color.Transparent;
//            this.pnlPurchasesDebt.BorderRadius = 12;
//            this.pnlPurchasesDebt.Controls.Add(this.lblPurchasesDebtValue);
//            this.pnlPurchasesDebt.Controls.Add(this.lblPurchasesDebtCaption);
//            this.pnlPurchasesDebt.FillColor = System.Drawing.Color.White;
//            this.pnlPurchasesDebt.Location = new System.Drawing.Point(160, 216);
//            this.pnlPurchasesDebt.Name = "pnlPurchasesDebt";
//            this.pnlPurchasesDebt.ShadowDecoration.Enabled = true;
//            this.pnlPurchasesDebt.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.pnlPurchasesDebt.Size = new System.Drawing.Size(254, 100);
//            this.pnlPurchasesDebt.TabIndex = 3;
//            // 
//            // lblPurchasesDebtValue
//            // 
//            this.lblPurchasesDebtValue.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
//            this.lblPurchasesDebtValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(193)))));
//            this.lblPurchasesDebtValue.Location = new System.Drawing.Point(16, 38);
//            this.lblPurchasesDebtValue.Name = "lblPurchasesDebtValue";
//            this.lblPurchasesDebtValue.Size = new System.Drawing.Size(222, 30);
//            this.lblPurchasesDebtValue.TabIndex = 0;
//            this.lblPurchasesDebtValue.Text = "0.00 ل.س";
//            this.lblPurchasesDebtValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // lblPurchasesDebtCaption
//            // 
//            this.lblPurchasesDebtCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
//            this.lblPurchasesDebtCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(138)))));
//            this.lblPurchasesDebtCaption.Location = new System.Drawing.Point(16, 12);
//            this.lblPurchasesDebtCaption.Name = "lblPurchasesDebtCaption";
//            this.lblPurchasesDebtCaption.Size = new System.Drawing.Size(222, 20);
//            this.lblPurchasesDebtCaption.TabIndex = 1;
//            this.lblPurchasesDebtCaption.Text = "ذمم الموردين";
//            this.lblPurchasesDebtCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // pnlPurchasesInvoices
//            // 
//            this.pnlPurchasesInvoices.BackColor = System.Drawing.Color.Transparent;
//            this.pnlPurchasesInvoices.BorderRadius = 12;
//            this.pnlPurchasesInvoices.Controls.Add(this.lblPurchasesInvoicesValue);
//            this.pnlPurchasesInvoices.Controls.Add(this.lblPurchasesInvoicesCaption);
//            this.pnlPurchasesInvoices.FillColor = System.Drawing.Color.White;
//            this.pnlPurchasesInvoices.Location = new System.Drawing.Point(432, 216);
//            this.pnlPurchasesInvoices.Name = "pnlPurchasesInvoices";
//            this.pnlPurchasesInvoices.ShadowDecoration.Enabled = true;
//            this.pnlPurchasesInvoices.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.pnlPurchasesInvoices.Size = new System.Drawing.Size(254, 100);
//            this.pnlPurchasesInvoices.TabIndex = 4;
//            // 
//            // lblPurchasesInvoicesValue
//            // 
//            this.lblPurchasesInvoicesValue.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
//            this.lblPurchasesInvoicesValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
//            this.lblPurchasesInvoicesValue.Location = new System.Drawing.Point(16, 38);
//            this.lblPurchasesInvoicesValue.Name = "lblPurchasesInvoicesValue";
//            this.lblPurchasesInvoicesValue.Size = new System.Drawing.Size(222, 30);
//            this.lblPurchasesInvoicesValue.TabIndex = 0;
//            this.lblPurchasesInvoicesValue.Text = "0";
//            this.lblPurchasesInvoicesValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // lblPurchasesInvoicesCaption
//            // 
//            this.lblPurchasesInvoicesCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
//            this.lblPurchasesInvoicesCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(138)))));
//            this.lblPurchasesInvoicesCaption.Location = new System.Drawing.Point(16, 12);
//            this.lblPurchasesInvoicesCaption.Name = "lblPurchasesInvoicesCaption";
//            this.lblPurchasesInvoicesCaption.Size = new System.Drawing.Size(222, 20);
//            this.lblPurchasesInvoicesCaption.TabIndex = 1;
//            this.lblPurchasesInvoicesCaption.Text = "فواتير اليوم";
//            this.lblPurchasesInvoicesCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // pnlPurchasesToday
//            // 
//            this.pnlPurchasesToday.BackColor = System.Drawing.Color.Transparent;
//            this.pnlPurchasesToday.BorderRadius = 12;
//            this.pnlPurchasesToday.Controls.Add(this.lblPurchasesTodayValue);
//            this.pnlPurchasesToday.Controls.Add(this.lblPurchasesTodayCaption);
//            this.pnlPurchasesToday.FillColor = System.Drawing.Color.White;
//            this.pnlPurchasesToday.Location = new System.Drawing.Point(704, 216);
//            this.pnlPurchasesToday.Name = "pnlPurchasesToday";
//            this.pnlPurchasesToday.ShadowDecoration.Enabled = true;
//            this.pnlPurchasesToday.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.pnlPurchasesToday.Size = new System.Drawing.Size(254, 100);
//            this.pnlPurchasesToday.TabIndex = 5;
//            // 
//            // lblPurchasesTodayValue
//            // 
//            this.lblPurchasesTodayValue.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
//            this.lblPurchasesTodayValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
//            this.lblPurchasesTodayValue.Location = new System.Drawing.Point(16, 38);
//            this.lblPurchasesTodayValue.Name = "lblPurchasesTodayValue";
//            this.lblPurchasesTodayValue.Size = new System.Drawing.Size(222, 30);
//            this.lblPurchasesTodayValue.TabIndex = 0;
//            this.lblPurchasesTodayValue.Text = "0.00 ل.س";
//            this.lblPurchasesTodayValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // lblPurchasesTodayCaption
//            // 
//            this.lblPurchasesTodayCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
//            this.lblPurchasesTodayCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(138)))));
//            this.lblPurchasesTodayCaption.Location = new System.Drawing.Point(16, 12);
//            this.lblPurchasesTodayCaption.Name = "lblPurchasesTodayCaption";
//            this.lblPurchasesTodayCaption.Size = new System.Drawing.Size(222, 20);
//            this.lblPurchasesTodayCaption.TabIndex = 1;
//            this.lblPurchasesTodayCaption.Text = "مشتريات اليوم";
//            this.lblPurchasesTodayCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // btnListPurchases
//            // 
//            this.btnListPurchases.BackColor = System.Drawing.Color.Transparent;
//            this.btnListPurchases.BorderRadius = 12;
//            this.btnListPurchases.FillColor = System.Drawing.Color.White;
//            this.btnListPurchases.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
//            this.btnListPurchases.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
//            this.btnListPurchases.HoverState.FillColor = System.Drawing.Color.White;
//            this.btnListPurchases.Location = new System.Drawing.Point(432, 84);
//            this.btnListPurchases.Name = "btnListPurchases";
//            this.btnListPurchases.ShadowDecoration.Enabled = true;
//            this.btnListPurchases.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.btnListPurchases.Size = new System.Drawing.Size(254, 112);
//            this.btnListPurchases.TabIndex = 0;
//            this.btnListPurchases.Text = "☷  قائمة المشتريات";
//            // 
//            // btnAddNewPurchase
//            // 
//            this.btnAddNewPurchase.BackColor = System.Drawing.Color.Transparent;
//            this.btnAddNewPurchase.BorderRadius = 12;
//            this.btnAddNewPurchase.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(199)))), ((int)(((byte)(111)))));
//            this.btnAddNewPurchase.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
//            this.btnAddNewPurchase.ForeColor = System.Drawing.Color.White;
//            this.btnAddNewPurchase.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(199)))), ((int)(((byte)(111)))));
//            this.btnAddNewPurchase.Location = new System.Drawing.Point(704, 84);
//            this.btnAddNewPurchase.Name = "btnAddNewPurchase";
//            this.btnAddNewPurchase.ShadowDecoration.Enabled = true;
//            this.btnAddNewPurchase.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.btnAddNewPurchase.Size = new System.Drawing.Size(254, 112);
//            this.btnAddNewPurchase.TabIndex = 0;
//            this.btnAddNewPurchase.Text = "＋  إضافة شراء جديد";
//            // 
//            // tabProducts
//            // 
//            this.tabProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
//            this.tabProducts.Controls.Add(this.lblProductsSubtitle);
//            this.tabProducts.Controls.Add(this.lblProductsTitle);
//            this.tabProducts.Controls.Add(this.pnlProductsActions);
//            this.tabProducts.Controls.Add(this.pnlProductsCategories);
//            this.tabProducts.Controls.Add(this.pnlProductsLowStock);
//            this.tabProducts.Controls.Add(this.pnlProductsCount);
//            this.tabProducts.Controls.Add(this.btnListCategories);
//            this.tabProducts.Controls.Add(this.btnListProducts);
//            this.tabProducts.Controls.Add(this.btnAddNewProduct);
//            this.tabProducts.Location = new System.Drawing.Point(4, 4);
//            this.tabProducts.Name = "tabProducts";
//            this.tabProducts.Padding = new System.Windows.Forms.Padding(28);
//            this.tabProducts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
//            this.tabProducts.Size = new System.Drawing.Size(986, 784);
//            this.tabProducts.TabIndex = 3;
//            // 
//            // lblProductsSubtitle
//            // 
//            this.lblProductsSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
//            this.lblProductsSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(126)))), ((int)(((byte)(136)))));
//            this.lblProductsSubtitle.Location = new System.Drawing.Point(480, 55);
//            this.lblProductsSubtitle.Name = "lblProductsSubtitle";
//            this.lblProductsSubtitle.Size = new System.Drawing.Size(478, 20);
//            this.lblProductsSubtitle.TabIndex = 1;
//            this.lblProductsSubtitle.Text = "إدارة المنتجات والأقسام ومتابعة حالة المخزون";
//            this.lblProductsSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // lblProductsTitle
//            // 
//            this.lblProductsTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
//            this.lblProductsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
//            this.lblProductsTitle.Location = new System.Drawing.Point(600, 20);
//            this.lblProductsTitle.Name = "lblProductsTitle";
//            this.lblProductsTitle.Size = new System.Drawing.Size(358, 32);
//            this.lblProductsTitle.TabIndex = 0;
//            this.lblProductsTitle.Text = "المنتجات والمخزون";
//            this.lblProductsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // pnlProductsActions
//            // 
//            this.pnlProductsActions.BackColor = System.Drawing.Color.Transparent;
//            this.pnlProductsActions.BorderRadius = 12;
//            this.pnlProductsActions.Controls.Add(this.lblProductsActionsHint);
//            this.pnlProductsActions.Controls.Add(this.lblProductsActions);
//            this.pnlProductsActions.FillColor = System.Drawing.Color.White;
//            this.pnlProductsActions.Location = new System.Drawing.Point(28, 340);
//            this.pnlProductsActions.Name = "pnlProductsActions";
//            this.pnlProductsActions.ShadowDecoration.Enabled = true;
//            this.pnlProductsActions.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.pnlProductsActions.Size = new System.Drawing.Size(930, 150);
//            this.pnlProductsActions.TabIndex = 2;
//            // 
//            // lblProductsActionsHint
//            // 
//            this.lblProductsActionsHint.Font = new System.Drawing.Font("Segoe UI", 8.5F);
//            this.lblProductsActionsHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(138)))));
//            this.lblProductsActionsHint.Location = new System.Drawing.Point(18, 46);
//            this.lblProductsActionsHint.Name = "lblProductsActionsHint";
//            this.lblProductsActionsHint.Size = new System.Drawing.Size(894, 92);
//            this.lblProductsActionsHint.TabIndex = 0;
//            this.lblProductsActionsHint.Text = "استخدم قائمة المنتجات للبحث والتعديل ومراجعة الكميات، واستخدم الأقسام لتنظيم المن" +
//    "تجات وتسهيل البحث داخل النظام.";
//            this.lblProductsActionsHint.TextAlign = System.Drawing.ContentAlignment.TopRight;
//            // 
//            // lblProductsActions
//            // 
//            this.lblProductsActions.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
//            this.lblProductsActions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
//            this.lblProductsActions.Location = new System.Drawing.Point(18, 16);
//            this.lblProductsActions.Name = "lblProductsActions";
//            this.lblProductsActions.Size = new System.Drawing.Size(894, 24);
//            this.lblProductsActions.TabIndex = 1;
//            this.lblProductsActions.Text = "إدارة المخزون";
//            this.lblProductsActions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // pnlProductsCategories
//            // 
//            this.pnlProductsCategories.BackColor = System.Drawing.Color.Transparent;
//            this.pnlProductsCategories.BorderRadius = 12;
//            this.pnlProductsCategories.Controls.Add(this.lblProductsCategoriesValue);
//            this.pnlProductsCategories.Controls.Add(this.lblProductsCategoriesCaption);
//            this.pnlProductsCategories.FillColor = System.Drawing.Color.White;
//            this.pnlProductsCategories.Location = new System.Drawing.Point(160, 216);
//            this.pnlProductsCategories.Name = "pnlProductsCategories";
//            this.pnlProductsCategories.ShadowDecoration.Enabled = true;
//            this.pnlProductsCategories.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.pnlProductsCategories.Size = new System.Drawing.Size(254, 100);
//            this.pnlProductsCategories.TabIndex = 3;
//            // 
//            // lblProductsCategoriesValue
//            // 
//            this.lblProductsCategoriesValue.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
//            this.lblProductsCategoriesValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
//            this.lblProductsCategoriesValue.Location = new System.Drawing.Point(16, 38);
//            this.lblProductsCategoriesValue.Name = "lblProductsCategoriesValue";
//            this.lblProductsCategoriesValue.Size = new System.Drawing.Size(222, 30);
//            this.lblProductsCategoriesValue.TabIndex = 0;
//            this.lblProductsCategoriesValue.Text = "0";
//            this.lblProductsCategoriesValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // lblProductsCategoriesCaption
//            // 
//            this.lblProductsCategoriesCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
//            this.lblProductsCategoriesCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(138)))));
//            this.lblProductsCategoriesCaption.Location = new System.Drawing.Point(16, 12);
//            this.lblProductsCategoriesCaption.Name = "lblProductsCategoriesCaption";
//            this.lblProductsCategoriesCaption.Size = new System.Drawing.Size(222, 20);
//            this.lblProductsCategoriesCaption.TabIndex = 1;
//            this.lblProductsCategoriesCaption.Text = "الأقسام";
//            this.lblProductsCategoriesCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // pnlProductsLowStock
//            // 
//            this.pnlProductsLowStock.BackColor = System.Drawing.Color.Transparent;
//            this.pnlProductsLowStock.BorderRadius = 12;
//            this.pnlProductsLowStock.Controls.Add(this.lblProductsLowStockValue);
//            this.pnlProductsLowStock.Controls.Add(this.lblProductsLowStockCaption);
//            this.pnlProductsLowStock.FillColor = System.Drawing.Color.White;
//            this.pnlProductsLowStock.Location = new System.Drawing.Point(432, 216);
//            this.pnlProductsLowStock.Name = "pnlProductsLowStock";
//            this.pnlProductsLowStock.ShadowDecoration.Enabled = true;
//            this.pnlProductsLowStock.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.pnlProductsLowStock.Size = new System.Drawing.Size(254, 100);
//            this.pnlProductsLowStock.TabIndex = 4;
//            // 
//            // lblProductsLowStockValue
//            // 
//            this.lblProductsLowStockValue.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
//            this.lblProductsLowStockValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(84)))), ((int)(((byte)(85)))));
//            this.lblProductsLowStockValue.Location = new System.Drawing.Point(16, 38);
//            this.lblProductsLowStockValue.Name = "lblProductsLowStockValue";
//            this.lblProductsLowStockValue.Size = new System.Drawing.Size(222, 30);
//            this.lblProductsLowStockValue.TabIndex = 0;
//            this.lblProductsLowStockValue.Text = "0";
//            this.lblProductsLowStockValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // lblProductsLowStockCaption
//            // 
//            this.lblProductsLowStockCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
//            this.lblProductsLowStockCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(138)))));
//            this.lblProductsLowStockCaption.Location = new System.Drawing.Point(16, 12);
//            this.lblProductsLowStockCaption.Name = "lblProductsLowStockCaption";
//            this.lblProductsLowStockCaption.Size = new System.Drawing.Size(222, 20);
//            this.lblProductsLowStockCaption.TabIndex = 1;
//            this.lblProductsLowStockCaption.Text = "مخزون منخفض";
//            this.lblProductsLowStockCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // pnlProductsCount
//            // 
//            this.pnlProductsCount.BackColor = System.Drawing.Color.Transparent;
//            this.pnlProductsCount.BorderRadius = 12;
//            this.pnlProductsCount.Controls.Add(this.lblProductsCountValue);
//            this.pnlProductsCount.Controls.Add(this.lblProductsCountCaption);
//            this.pnlProductsCount.FillColor = System.Drawing.Color.White;
//            this.pnlProductsCount.Location = new System.Drawing.Point(704, 216);
//            this.pnlProductsCount.Name = "pnlProductsCount";
//            this.pnlProductsCount.ShadowDecoration.Enabled = true;
//            this.pnlProductsCount.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.pnlProductsCount.Size = new System.Drawing.Size(254, 100);
//            this.pnlProductsCount.TabIndex = 5;
//            // 
//            // lblProductsCountValue
//            // 
//            this.lblProductsCountValue.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
//            this.lblProductsCountValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(103)))), ((int)(((byte)(240)))));
//            this.lblProductsCountValue.Location = new System.Drawing.Point(16, 38);
//            this.lblProductsCountValue.Name = "lblProductsCountValue";
//            this.lblProductsCountValue.Size = new System.Drawing.Size(222, 30);
//            this.lblProductsCountValue.TabIndex = 0;
//            this.lblProductsCountValue.Text = "0";
//            this.lblProductsCountValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // lblProductsCountCaption
//            // 
//            this.lblProductsCountCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
//            this.lblProductsCountCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(138)))));
//            this.lblProductsCountCaption.Location = new System.Drawing.Point(16, 12);
//            this.lblProductsCountCaption.Name = "lblProductsCountCaption";
//            this.lblProductsCountCaption.Size = new System.Drawing.Size(222, 20);
//            this.lblProductsCountCaption.TabIndex = 1;
//            this.lblProductsCountCaption.Text = "إجمالي المنتجات";
//            this.lblProductsCountCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // btnListCategories
//            // 
//            this.btnListCategories.BackColor = System.Drawing.Color.Transparent;
//            this.btnListCategories.BorderRadius = 12;
//            this.btnListCategories.FillColor = System.Drawing.Color.White;
//            this.btnListCategories.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
//            this.btnListCategories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
//            this.btnListCategories.HoverState.FillColor = System.Drawing.Color.White;
//            this.btnListCategories.Location = new System.Drawing.Point(160, 84);
//            this.btnListCategories.Name = "btnListCategories";
//            this.btnListCategories.ShadowDecoration.Enabled = true;
//            this.btnListCategories.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.btnListCategories.Size = new System.Drawing.Size(254, 112);
//            this.btnListCategories.TabIndex = 0;
//            this.btnListCategories.Text = "▦  إدارة الأقسام";
//            // 
//            // btnListProducts
//            // 
//            this.btnListProducts.BackColor = System.Drawing.Color.Transparent;
//            this.btnListProducts.BorderRadius = 12;
//            this.btnListProducts.FillColor = System.Drawing.Color.White;
//            this.btnListProducts.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
//            this.btnListProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
//            this.btnListProducts.HoverState.FillColor = System.Drawing.Color.White;
//            this.btnListProducts.Location = new System.Drawing.Point(432, 84);
//            this.btnListProducts.Name = "btnListProducts";
//            this.btnListProducts.ShadowDecoration.Enabled = true;
//            this.btnListProducts.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.btnListProducts.Size = new System.Drawing.Size(254, 112);
//            this.btnListProducts.TabIndex = 0;
//            this.btnListProducts.Text = "☷  قائمة المنتجات";
//            // 
//            // btnAddNewProduct
//            // 
//            this.btnAddNewProduct.BackColor = System.Drawing.Color.Transparent;
//            this.btnAddNewProduct.BorderRadius = 12;
//            this.btnAddNewProduct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
//            this.btnAddNewProduct.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
//            this.btnAddNewProduct.ForeColor = System.Drawing.Color.White;
//            this.btnAddNewProduct.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
//            this.btnAddNewProduct.Location = new System.Drawing.Point(704, 84);
//            this.btnAddNewProduct.Name = "btnAddNewProduct";
//            this.btnAddNewProduct.ShadowDecoration.Enabled = true;
//            this.btnAddNewProduct.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.btnAddNewProduct.Size = new System.Drawing.Size(254, 112);
//            this.btnAddNewProduct.TabIndex = 0;
//            this.btnAddNewProduct.Text = "＋  إضافة منتج جديد";
//            // 
//            // tabCustomers
//            // 
//            this.tabCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
//            this.tabCustomers.Controls.Add(this.lblCustomersSubtitle);
//            this.tabCustomers.Controls.Add(this.lblCustomersTitle);
//            this.tabCustomers.Controls.Add(this.pnlCustomersActions);
//            this.tabCustomers.Controls.Add(this.pnlCustomersDebt);
//            this.tabCustomers.Controls.Add(this.pnlCustomersCount);
//            this.tabCustomers.Controls.Add(this.btnListCustomers);
//            this.tabCustomers.Controls.Add(this.btnAddNewCustomer);
//            this.tabCustomers.Location = new System.Drawing.Point(4, 4);
//            this.tabCustomers.Name = "tabCustomers";
//            this.tabCustomers.Padding = new System.Windows.Forms.Padding(28);
//            this.tabCustomers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
//            this.tabCustomers.Size = new System.Drawing.Size(986, 784);
//            this.tabCustomers.TabIndex = 4;
//            // 
//            // lblCustomersSubtitle
//            // 
//            this.lblCustomersSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
//            this.lblCustomersSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(126)))), ((int)(((byte)(136)))));
//            this.lblCustomersSubtitle.Location = new System.Drawing.Point(480, 55);
//            this.lblCustomersSubtitle.Name = "lblCustomersSubtitle";
//            this.lblCustomersSubtitle.Size = new System.Drawing.Size(478, 20);
//            this.lblCustomersSubtitle.TabIndex = 1;
//            this.lblCustomersSubtitle.Text = "إدارة بيانات العملاء ومتابعة الأرصدة والديون";
//            this.lblCustomersSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // lblCustomersTitle
//            // 
//            this.lblCustomersTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
//            this.lblCustomersTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
//            this.lblCustomersTitle.Location = new System.Drawing.Point(600, 20);
//            this.lblCustomersTitle.Name = "lblCustomersTitle";
//            this.lblCustomersTitle.Size = new System.Drawing.Size(358, 32);
//            this.lblCustomersTitle.TabIndex = 0;
//            this.lblCustomersTitle.Text = "العملاء";
//            this.lblCustomersTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // pnlCustomersActions
//            // 
//            this.pnlCustomersActions.BackColor = System.Drawing.Color.Transparent;
//            this.pnlCustomersActions.BorderRadius = 12;
//            this.pnlCustomersActions.Controls.Add(this.lblCustomersActionsHint);
//            this.pnlCustomersActions.Controls.Add(this.lblCustomersActions);
//            this.pnlCustomersActions.FillColor = System.Drawing.Color.White;
//            this.pnlCustomersActions.Location = new System.Drawing.Point(160, 216);
//            this.pnlCustomersActions.Name = "pnlCustomersActions";
//            this.pnlCustomersActions.ShadowDecoration.Enabled = true;
//            this.pnlCustomersActions.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.pnlCustomersActions.Size = new System.Drawing.Size(254, 100);
//            this.pnlCustomersActions.TabIndex = 2;
//            // 
//            // lblCustomersActionsHint
//            // 
//            this.lblCustomersActionsHint.Font = new System.Drawing.Font("Segoe UI", 8.5F);
//            this.lblCustomersActionsHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(138)))));
//            this.lblCustomersActionsHint.Location = new System.Drawing.Point(16, 40);
//            this.lblCustomersActionsHint.Name = "lblCustomersActionsHint";
//            this.lblCustomersActionsHint.Size = new System.Drawing.Size(220, 45);
//            this.lblCustomersActionsHint.TabIndex = 0;
//            this.lblCustomersActionsHint.Text = "الوصول السريع لبيانات العملاء ودفعاتهم.";
//            this.lblCustomersActionsHint.TextAlign = System.Drawing.ContentAlignment.TopRight;
//            // 
//            // lblCustomersActions
//            // 
//            this.lblCustomersActions.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
//            this.lblCustomersActions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
//            this.lblCustomersActions.Location = new System.Drawing.Point(16, 12);
//            this.lblCustomersActions.Name = "lblCustomersActions";
//            this.lblCustomersActions.Size = new System.Drawing.Size(218, 24);
//            this.lblCustomersActions.TabIndex = 1;
//            this.lblCustomersActions.Text = "إدارة العملاء";
//            this.lblCustomersActions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // pnlCustomersDebt
//            // 
//            this.pnlCustomersDebt.BackColor = System.Drawing.Color.Transparent;
//            this.pnlCustomersDebt.BorderRadius = 12;
//            this.pnlCustomersDebt.Controls.Add(this.lblCustomersDebtValue);
//            this.pnlCustomersDebt.Controls.Add(this.lblCustomersDebtCaption);
//            this.pnlCustomersDebt.FillColor = System.Drawing.Color.White;
//            this.pnlCustomersDebt.Location = new System.Drawing.Point(432, 216);
//            this.pnlCustomersDebt.Name = "pnlCustomersDebt";
//            this.pnlCustomersDebt.ShadowDecoration.Enabled = true;
//            this.pnlCustomersDebt.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.pnlCustomersDebt.Size = new System.Drawing.Size(254, 100);
//            this.pnlCustomersDebt.TabIndex = 3;
//            // 
//            // lblCustomersDebtValue
//            // 
//            this.lblCustomersDebtValue.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
//            this.lblCustomersDebtValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(84)))), ((int)(((byte)(85)))));
//            this.lblCustomersDebtValue.Location = new System.Drawing.Point(16, 38);
//            this.lblCustomersDebtValue.Name = "lblCustomersDebtValue";
//            this.lblCustomersDebtValue.Size = new System.Drawing.Size(222, 30);
//            this.lblCustomersDebtValue.TabIndex = 0;
//            this.lblCustomersDebtValue.Text = "0.00 ل.س";
//            this.lblCustomersDebtValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // lblCustomersDebtCaption
//            // 
//            this.lblCustomersDebtCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
//            this.lblCustomersDebtCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(138)))));
//            this.lblCustomersDebtCaption.Location = new System.Drawing.Point(16, 12);
//            this.lblCustomersDebtCaption.Name = "lblCustomersDebtCaption";
//            this.lblCustomersDebtCaption.Size = new System.Drawing.Size(222, 20);
//            this.lblCustomersDebtCaption.TabIndex = 1;
//            this.lblCustomersDebtCaption.Text = "إجمالي الديون";
//            this.lblCustomersDebtCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // pnlCustomersCount
//            // 
//            this.pnlCustomersCount.BackColor = System.Drawing.Color.Transparent;
//            this.pnlCustomersCount.BorderRadius = 12;
//            this.pnlCustomersCount.Controls.Add(this.lblCustomersCountValue);
//            this.pnlCustomersCount.Controls.Add(this.lblCustomersCountCaption);
//            this.pnlCustomersCount.FillColor = System.Drawing.Color.White;
//            this.pnlCustomersCount.Location = new System.Drawing.Point(704, 216);
//            this.pnlCustomersCount.Name = "pnlCustomersCount";
//            this.pnlCustomersCount.ShadowDecoration.Enabled = true;
//            this.pnlCustomersCount.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.pnlCustomersCount.Size = new System.Drawing.Size(254, 100);
//            this.pnlCustomersCount.TabIndex = 4;
//            // 
//            // lblCustomersCountValue
//            // 
//            this.lblCustomersCountValue.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
//            this.lblCustomersCountValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
//            this.lblCustomersCountValue.Location = new System.Drawing.Point(16, 38);
//            this.lblCustomersCountValue.Name = "lblCustomersCountValue";
//            this.lblCustomersCountValue.Size = new System.Drawing.Size(222, 30);
//            this.lblCustomersCountValue.TabIndex = 0;
//            this.lblCustomersCountValue.Text = "0";
//            this.lblCustomersCountValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // lblCustomersCountCaption
//            // 
//            this.lblCustomersCountCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
//            this.lblCustomersCountCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(138)))));
//            this.lblCustomersCountCaption.Location = new System.Drawing.Point(16, 12);
//            this.lblCustomersCountCaption.Name = "lblCustomersCountCaption";
//            this.lblCustomersCountCaption.Size = new System.Drawing.Size(222, 20);
//            this.lblCustomersCountCaption.TabIndex = 1;
//            this.lblCustomersCountCaption.Text = "عدد العملاء";
//            this.lblCustomersCountCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // btnListCustomers
//            // 
//            this.btnListCustomers.BackColor = System.Drawing.Color.Transparent;
//            this.btnListCustomers.BorderRadius = 12;
//            this.btnListCustomers.FillColor = System.Drawing.Color.White;
//            this.btnListCustomers.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
//            this.btnListCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
//            this.btnListCustomers.HoverState.FillColor = System.Drawing.Color.White;
//            this.btnListCustomers.Location = new System.Drawing.Point(432, 84);
//            this.btnListCustomers.Name = "btnListCustomers";
//            this.btnListCustomers.ShadowDecoration.Enabled = true;
//            this.btnListCustomers.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.btnListCustomers.Size = new System.Drawing.Size(254, 112);
//            this.btnListCustomers.TabIndex = 0;
//            this.btnListCustomers.Text = "☷  قائمة العملاء";
//            // 
//            // btnAddNewCustomer
//            // 
//            this.btnAddNewCustomer.BackColor = System.Drawing.Color.Transparent;
//            this.btnAddNewCustomer.BorderRadius = 12;
//            this.btnAddNewCustomer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(84)))), ((int)(((byte)(85)))));
//            this.btnAddNewCustomer.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
//            this.btnAddNewCustomer.ForeColor = System.Drawing.Color.White;
//            this.btnAddNewCustomer.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(84)))), ((int)(((byte)(85)))));
//            this.btnAddNewCustomer.Location = new System.Drawing.Point(704, 84);
//            this.btnAddNewCustomer.Name = "btnAddNewCustomer";
//            this.btnAddNewCustomer.ShadowDecoration.Enabled = true;
//            this.btnAddNewCustomer.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.btnAddNewCustomer.Size = new System.Drawing.Size(254, 112);
//            this.btnAddNewCustomer.TabIndex = 0;
//            this.btnAddNewCustomer.Text = "＋  إضافة عميل جديد";
//            // 
//            // tabSuppliers
//            // 
//            this.tabSuppliers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
//            this.tabSuppliers.Controls.Add(this.lblSuppliersSubtitle);
//            this.tabSuppliers.Controls.Add(this.lblSuppliersTitle);
//            this.tabSuppliers.Controls.Add(this.pnlSuppliersActions);
//            this.tabSuppliers.Controls.Add(this.pnlSuppliersDebt);
//            this.tabSuppliers.Controls.Add(this.pnlSuppliersCount);
//            this.tabSuppliers.Controls.Add(this.btnListSuppliers);
//            this.tabSuppliers.Controls.Add(this.btnAddNewSupplier);
//            this.tabSuppliers.Location = new System.Drawing.Point(4, 4);
//            this.tabSuppliers.Name = "tabSuppliers";
//            this.tabSuppliers.Padding = new System.Windows.Forms.Padding(28);
//            this.tabSuppliers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
//            this.tabSuppliers.Size = new System.Drawing.Size(986, 784);
//            this.tabSuppliers.TabIndex = 5;
//            // 
//            // lblSuppliersSubtitle
//            // 
//            this.lblSuppliersSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
//            this.lblSuppliersSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(126)))), ((int)(((byte)(136)))));
//            this.lblSuppliersSubtitle.Location = new System.Drawing.Point(480, 55);
//            this.lblSuppliersSubtitle.Name = "lblSuppliersSubtitle";
//            this.lblSuppliersSubtitle.Size = new System.Drawing.Size(478, 20);
//            this.lblSuppliersSubtitle.TabIndex = 1;
//            this.lblSuppliersSubtitle.Text = "إدارة الموردين ومتابعة فواتير الشراء والذمم";
//            this.lblSuppliersSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // lblSuppliersTitle
//            // 
//            this.lblSuppliersTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
//            this.lblSuppliersTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
//            this.lblSuppliersTitle.Location = new System.Drawing.Point(600, 20);
//            this.lblSuppliersTitle.Name = "lblSuppliersTitle";
//            this.lblSuppliersTitle.Size = new System.Drawing.Size(358, 32);
//            this.lblSuppliersTitle.TabIndex = 0;
//            this.lblSuppliersTitle.Text = "الموردين";
//            this.lblSuppliersTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // pnlSuppliersActions
//            // 
//            this.pnlSuppliersActions.BackColor = System.Drawing.Color.Transparent;
//            this.pnlSuppliersActions.BorderRadius = 12;
//            this.pnlSuppliersActions.Controls.Add(this.lblSuppliersActionsHint);
//            this.pnlSuppliersActions.Controls.Add(this.lblSuppliersActions);
//            this.pnlSuppliersActions.FillColor = System.Drawing.Color.White;
//            this.pnlSuppliersActions.Location = new System.Drawing.Point(160, 216);
//            this.pnlSuppliersActions.Name = "pnlSuppliersActions";
//            this.pnlSuppliersActions.ShadowDecoration.Enabled = true;
//            this.pnlSuppliersActions.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.pnlSuppliersActions.Size = new System.Drawing.Size(254, 100);
//            this.pnlSuppliersActions.TabIndex = 2;
//            // 
//            // lblSuppliersActionsHint
//            // 
//            this.lblSuppliersActionsHint.Font = new System.Drawing.Font("Segoe UI", 8.5F);
//            this.lblSuppliersActionsHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(138)))));
//            this.lblSuppliersActionsHint.Location = new System.Drawing.Point(16, 40);
//            this.lblSuppliersActionsHint.Name = "lblSuppliersActionsHint";
//            this.lblSuppliersActionsHint.Size = new System.Drawing.Size(220, 45);
//            this.lblSuppliersActionsHint.TabIndex = 0;
//            this.lblSuppliersActionsHint.Text = "راجع بيانات الموردين وفواتير الشراء والأرصدة المستحقة من مكان واحد.";
//            this.lblSuppliersActionsHint.TextAlign = System.Drawing.ContentAlignment.TopRight;
//            // 
//            // lblSuppliersActions
//            // 
//            this.lblSuppliersActions.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
//            this.lblSuppliersActions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
//            this.lblSuppliersActions.Location = new System.Drawing.Point(16, 12);
//            this.lblSuppliersActions.Name = "lblSuppliersActions";
//            this.lblSuppliersActions.Size = new System.Drawing.Size(218, 24);
//            this.lblSuppliersActions.TabIndex = 1;
//            this.lblSuppliersActions.Text = "إدارة الموردين";
//            this.lblSuppliersActions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // pnlSuppliersDebt
//            // 
//            this.pnlSuppliersDebt.BackColor = System.Drawing.Color.Transparent;
//            this.pnlSuppliersDebt.BorderRadius = 12;
//            this.pnlSuppliersDebt.Controls.Add(this.lblSuppliersDebtValue);
//            this.pnlSuppliersDebt.Controls.Add(this.lblSuppliersDebtCaption);
//            this.pnlSuppliersDebt.FillColor = System.Drawing.Color.White;
//            this.pnlSuppliersDebt.Location = new System.Drawing.Point(432, 216);
//            this.pnlSuppliersDebt.Name = "pnlSuppliersDebt";
//            this.pnlSuppliersDebt.ShadowDecoration.Enabled = true;
//            this.pnlSuppliersDebt.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.pnlSuppliersDebt.Size = new System.Drawing.Size(254, 100);
//            this.pnlSuppliersDebt.TabIndex = 3;
//            // 
//            // lblSuppliersDebtValue
//            // 
//            this.lblSuppliersDebtValue.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
//            this.lblSuppliersDebtValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
//            this.lblSuppliersDebtValue.Location = new System.Drawing.Point(16, 38);
//            this.lblSuppliersDebtValue.Name = "lblSuppliersDebtValue";
//            this.lblSuppliersDebtValue.Size = new System.Drawing.Size(222, 30);
//            this.lblSuppliersDebtValue.TabIndex = 0;
//            this.lblSuppliersDebtValue.Text = "0.00 ل.س";
//            this.lblSuppliersDebtValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // lblSuppliersDebtCaption
//            // 
//            this.lblSuppliersDebtCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
//            this.lblSuppliersDebtCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(138)))));
//            this.lblSuppliersDebtCaption.Location = new System.Drawing.Point(16, 12);
//            this.lblSuppliersDebtCaption.Name = "lblSuppliersDebtCaption";
//            this.lblSuppliersDebtCaption.Size = new System.Drawing.Size(222, 20);
//            this.lblSuppliersDebtCaption.TabIndex = 1;
//            this.lblSuppliersDebtCaption.Text = "إجمالي المستحقات";
//            this.lblSuppliersDebtCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // pnlSuppliersCount
//            // 
//            this.pnlSuppliersCount.BackColor = System.Drawing.Color.Transparent;
//            this.pnlSuppliersCount.BorderRadius = 12;
//            this.pnlSuppliersCount.Controls.Add(this.lblSuppliersCountValue);
//            this.pnlSuppliersCount.Controls.Add(this.lblSuppliersCountCaption);
//            this.pnlSuppliersCount.FillColor = System.Drawing.Color.White;
//            this.pnlSuppliersCount.Location = new System.Drawing.Point(704, 216);
//            this.pnlSuppliersCount.Name = "pnlSuppliersCount";
//            this.pnlSuppliersCount.ShadowDecoration.Enabled = true;
//            this.pnlSuppliersCount.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.pnlSuppliersCount.Size = new System.Drawing.Size(254, 100);
//            this.pnlSuppliersCount.TabIndex = 4;
//            // 
//            // lblSuppliersCountValue
//            // 
//            this.lblSuppliersCountValue.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
//            this.lblSuppliersCountValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(193)))));
//            this.lblSuppliersCountValue.Location = new System.Drawing.Point(16, 38);
//            this.lblSuppliersCountValue.Name = "lblSuppliersCountValue";
//            this.lblSuppliersCountValue.Size = new System.Drawing.Size(222, 30);
//            this.lblSuppliersCountValue.TabIndex = 0;
//            this.lblSuppliersCountValue.Text = "0";
//            this.lblSuppliersCountValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // lblSuppliersCountCaption
//            // 
//            this.lblSuppliersCountCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
//            this.lblSuppliersCountCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(138)))));
//            this.lblSuppliersCountCaption.Location = new System.Drawing.Point(16, 12);
//            this.lblSuppliersCountCaption.Name = "lblSuppliersCountCaption";
//            this.lblSuppliersCountCaption.Size = new System.Drawing.Size(222, 20);
//            this.lblSuppliersCountCaption.TabIndex = 1;
//            this.lblSuppliersCountCaption.Text = "عدد الموردين";
//            this.lblSuppliersCountCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // btnListSuppliers
//            // 
//            this.btnListSuppliers.BackColor = System.Drawing.Color.Transparent;
//            this.btnListSuppliers.BorderRadius = 12;
//            this.btnListSuppliers.FillColor = System.Drawing.Color.White;
//            this.btnListSuppliers.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
//            this.btnListSuppliers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
//            this.btnListSuppliers.HoverState.FillColor = System.Drawing.Color.White;
//            this.btnListSuppliers.Location = new System.Drawing.Point(432, 84);
//            this.btnListSuppliers.Name = "btnListSuppliers";
//            this.btnListSuppliers.ShadowDecoration.Enabled = true;
//            this.btnListSuppliers.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.btnListSuppliers.Size = new System.Drawing.Size(254, 112);
//            this.btnListSuppliers.TabIndex = 0;
//            this.btnListSuppliers.Text = "☷  قائمة الموردين";
//            // 
//            // btnAddNewSupplier
//            // 
//            this.btnAddNewSupplier.BackColor = System.Drawing.Color.Transparent;
//            this.btnAddNewSupplier.BorderRadius = 12;
//            this.btnAddNewSupplier.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(193)))));
//            this.btnAddNewSupplier.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
//            this.btnAddNewSupplier.ForeColor = System.Drawing.Color.White;
//            this.btnAddNewSupplier.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(193)))));
//            this.btnAddNewSupplier.Location = new System.Drawing.Point(704, 84);
//            this.btnAddNewSupplier.Name = "btnAddNewSupplier";
//            this.btnAddNewSupplier.ShadowDecoration.Enabled = true;
//            this.btnAddNewSupplier.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.btnAddNewSupplier.Size = new System.Drawing.Size(254, 112);
//            this.btnAddNewSupplier.TabIndex = 0;
//            this.btnAddNewSupplier.Text = "＋  إضافة مورد جديد";
//            // 
//            // tabReports
//            // 
//            this.tabReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
//            this.tabReports.Controls.Add(this.lblReportsSubtitle);
//            this.tabReports.Controls.Add(this.lblReportsTitle);
//            this.tabReports.Controls.Add(this.pnlReportsProfit);
//            this.tabReports.Controls.Add(this.pnlReportsDebt);
//            this.tabReports.Controls.Add(this.pnlReportsStock);
//            this.tabReports.Controls.Add(this.pnlReportsSales);
//            this.tabReports.Controls.Add(this.btnCustomUsingAi);
//            this.tabReports.Controls.Add(this.btnImportantReports);
//            this.tabReports.Location = new System.Drawing.Point(4, 4);
//            this.tabReports.Name = "tabReports";
//            this.tabReports.Padding = new System.Windows.Forms.Padding(28);
//            this.tabReports.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
//            this.tabReports.Size = new System.Drawing.Size(986, 784);
//            this.tabReports.TabIndex = 6;
//            // 
//            // lblReportsSubtitle
//            // 
//            this.lblReportsSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
//            this.lblReportsSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(126)))), ((int)(((byte)(136)))));
//            this.lblReportsSubtitle.Location = new System.Drawing.Point(480, 55);
//            this.lblReportsSubtitle.Name = "lblReportsSubtitle";
//            this.lblReportsSubtitle.Size = new System.Drawing.Size(478, 20);
//            this.lblReportsSubtitle.TabIndex = 1;
//            this.lblReportsSubtitle.Text = "تحليل المبيعات والمشتريات والأرباح والمخزون والحسابات";
//            this.lblReportsSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // lblReportsTitle
//            // 
//            this.lblReportsTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
//            this.lblReportsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
//            this.lblReportsTitle.Location = new System.Drawing.Point(600, 20);
//            this.lblReportsTitle.Name = "lblReportsTitle";
//            this.lblReportsTitle.Size = new System.Drawing.Size(358, 32);
//            this.lblReportsTitle.TabIndex = 0;
//            this.lblReportsTitle.Text = "التقارير";
//            this.lblReportsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // pnlReportsProfit
//            // 
//            this.pnlReportsProfit.BackColor = System.Drawing.Color.Transparent;
//            this.pnlReportsProfit.BorderRadius = 12;
//            this.pnlReportsProfit.Controls.Add(this.lblReportsProfitText);
//            this.pnlReportsProfit.Controls.Add(this.lblReportsProfitTitle);
//            this.pnlReportsProfit.FillColor = System.Drawing.Color.White;
//            this.pnlReportsProfit.Location = new System.Drawing.Point(704, 352);
//            this.pnlReportsProfit.Name = "pnlReportsProfit";
//            this.pnlReportsProfit.ShadowDecoration.Enabled = true;
//            this.pnlReportsProfit.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.pnlReportsProfit.Size = new System.Drawing.Size(254, 112);
//            this.pnlReportsProfit.TabIndex = 2;
//            // 
//            // lblReportsProfitText
//            // 
//            this.lblReportsProfitText.Font = new System.Drawing.Font("Segoe UI", 8.5F);
//            this.lblReportsProfitText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(138)))));
//            this.lblReportsProfitText.Location = new System.Drawing.Point(18, 46);
//            this.lblReportsProfitText.Name = "lblReportsProfitText";
//            this.lblReportsProfitText.Size = new System.Drawing.Size(218, 54);
//            this.lblReportsProfitText.TabIndex = 0;
//            this.lblReportsProfitText.Text = "متابعة الربح الناتج عن المبيعات والمصروفات خلال فترة محددة.";
//            this.lblReportsProfitText.TextAlign = System.Drawing.ContentAlignment.TopRight;
//            // 
//            // lblReportsProfitTitle
//            // 
//            this.lblReportsProfitTitle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
//            this.lblReportsProfitTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
//            this.lblReportsProfitTitle.Location = new System.Drawing.Point(18, 16);
//            this.lblReportsProfitTitle.Name = "lblReportsProfitTitle";
//            this.lblReportsProfitTitle.Size = new System.Drawing.Size(218, 24);
//            this.lblReportsProfitTitle.TabIndex = 1;
//            this.lblReportsProfitTitle.Text = "تقرير الأرباح";
//            this.lblReportsProfitTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // pnlReportsDebt
//            // 
//            this.pnlReportsDebt.BackColor = System.Drawing.Color.Transparent;
//            this.pnlReportsDebt.BorderRadius = 12;
//            this.pnlReportsDebt.Controls.Add(this.lblReportsDebtText);
//            this.pnlReportsDebt.Controls.Add(this.lblReportsDebtTitle);
//            this.pnlReportsDebt.FillColor = System.Drawing.Color.White;
//            this.pnlReportsDebt.Location = new System.Drawing.Point(160, 216);
//            this.pnlReportsDebt.Name = "pnlReportsDebt";
//            this.pnlReportsDebt.ShadowDecoration.Enabled = true;
//            this.pnlReportsDebt.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.pnlReportsDebt.Size = new System.Drawing.Size(254, 112);
//            this.pnlReportsDebt.TabIndex = 3;
//            // 
//            // lblReportsDebtText
//            // 
//            this.lblReportsDebtText.Font = new System.Drawing.Font("Segoe UI", 8.5F);
//            this.lblReportsDebtText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(138)))));
//            this.lblReportsDebtText.Location = new System.Drawing.Point(18, 46);
//            this.lblReportsDebtText.Name = "lblReportsDebtText";
//            this.lblReportsDebtText.Size = new System.Drawing.Size(218, 54);
//            this.lblReportsDebtText.TabIndex = 0;
//            this.lblReportsDebtText.Text = "ديون العملاء، مستحقات الموردين، وحركات السداد.";
//            this.lblReportsDebtText.TextAlign = System.Drawing.ContentAlignment.TopRight;
//            // 
//            // lblReportsDebtTitle
//            // 
//            this.lblReportsDebtTitle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
//            this.lblReportsDebtTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
//            this.lblReportsDebtTitle.Location = new System.Drawing.Point(18, 16);
//            this.lblReportsDebtTitle.Name = "lblReportsDebtTitle";
//            this.lblReportsDebtTitle.Size = new System.Drawing.Size(218, 24);
//            this.lblReportsDebtTitle.TabIndex = 1;
//            this.lblReportsDebtTitle.Text = "تقرير الذمم";
//            this.lblReportsDebtTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // pnlReportsStock
//            // 
//            this.pnlReportsStock.BackColor = System.Drawing.Color.Transparent;
//            this.pnlReportsStock.BorderRadius = 12;
//            this.pnlReportsStock.Controls.Add(this.lblReportsStockText);
//            this.pnlReportsStock.Controls.Add(this.lblReportsStockTitle);
//            this.pnlReportsStock.FillColor = System.Drawing.Color.White;
//            this.pnlReportsStock.Location = new System.Drawing.Point(432, 216);
//            this.pnlReportsStock.Name = "pnlReportsStock";
//            this.pnlReportsStock.ShadowDecoration.Enabled = true;
//            this.pnlReportsStock.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.pnlReportsStock.Size = new System.Drawing.Size(254, 112);
//            this.pnlReportsStock.TabIndex = 4;
//            // 
//            // lblReportsStockText
//            // 
//            this.lblReportsStockText.Font = new System.Drawing.Font("Segoe UI", 8.5F);
//            this.lblReportsStockText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(138)))));
//            this.lblReportsStockText.Location = new System.Drawing.Point(18, 46);
//            this.lblReportsStockText.Name = "lblReportsStockText";
//            this.lblReportsStockText.Size = new System.Drawing.Size(218, 54);
//            this.lblReportsStockText.TabIndex = 0;
//            this.lblReportsStockText.Text = "حالة المخزون، المنتجات منخفضة الكمية، وقيمة المخزون.";
//            this.lblReportsStockText.TextAlign = System.Drawing.ContentAlignment.TopRight;
//            // 
//            // lblReportsStockTitle
//            // 
//            this.lblReportsStockTitle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
//            this.lblReportsStockTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
//            this.lblReportsStockTitle.Location = new System.Drawing.Point(18, 16);
//            this.lblReportsStockTitle.Name = "lblReportsStockTitle";
//            this.lblReportsStockTitle.Size = new System.Drawing.Size(218, 24);
//            this.lblReportsStockTitle.TabIndex = 1;
//            this.lblReportsStockTitle.Text = "تقرير المخزون";
//            this.lblReportsStockTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // pnlReportsSales
//            // 
//            this.pnlReportsSales.BackColor = System.Drawing.Color.Transparent;
//            this.pnlReportsSales.BorderRadius = 12;
//            this.pnlReportsSales.Controls.Add(this.lblReportsSalesText);
//            this.pnlReportsSales.Controls.Add(this.lblReportsSalesTitle);
//            this.pnlReportsSales.FillColor = System.Drawing.Color.White;
//            this.pnlReportsSales.Location = new System.Drawing.Point(704, 216);
//            this.pnlReportsSales.Name = "pnlReportsSales";
//            this.pnlReportsSales.ShadowDecoration.Enabled = true;
//            this.pnlReportsSales.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.pnlReportsSales.Size = new System.Drawing.Size(254, 112);
//            this.pnlReportsSales.TabIndex = 5;
//            // 
//            // lblReportsSalesText
//            // 
//            this.lblReportsSalesText.Font = new System.Drawing.Font("Segoe UI", 8.5F);
//            this.lblReportsSalesText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(138)))));
//            this.lblReportsSalesText.Location = new System.Drawing.Point(18, 46);
//            this.lblReportsSalesText.Name = "lblReportsSalesText";
//            this.lblReportsSalesText.Size = new System.Drawing.Size(218, 54);
//            this.lblReportsSalesText.TabIndex = 0;
//            this.lblReportsSalesText.Text = "المبيعات اليومية والشهرية، عدد الفواتير، ومتوسط قيمة الفاتورة.";
//            this.lblReportsSalesText.TextAlign = System.Drawing.ContentAlignment.TopRight;
//            // 
//            // lblReportsSalesTitle
//            // 
//            this.lblReportsSalesTitle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
//            this.lblReportsSalesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
//            this.lblReportsSalesTitle.Location = new System.Drawing.Point(18, 16);
//            this.lblReportsSalesTitle.Name = "lblReportsSalesTitle";
//            this.lblReportsSalesTitle.Size = new System.Drawing.Size(218, 24);
//            this.lblReportsSalesTitle.TabIndex = 1;
//            this.lblReportsSalesTitle.Text = "تقرير المبيعات";
//            this.lblReportsSalesTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // btnCustomUsingAi
//            // 
//            this.btnCustomUsingAi.BackColor = System.Drawing.Color.Transparent;
//            this.btnCustomUsingAi.BorderRadius = 12;
//            this.btnCustomUsingAi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
//            this.btnCustomUsingAi.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
//            this.btnCustomUsingAi.ForeColor = System.Drawing.Color.White;
//            this.btnCustomUsingAi.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
//            this.btnCustomUsingAi.Location = new System.Drawing.Point(432, 84);
//            this.btnCustomUsingAi.Name = "btnCustomUsingAi";
//            this.btnCustomUsingAi.ShadowDecoration.Enabled = true;
//            this.btnCustomUsingAi.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.btnCustomUsingAi.Size = new System.Drawing.Size(254, 112);
//            this.btnCustomUsingAi.TabIndex = 0;
//            this.btnCustomUsingAi.Text = "✦  تقارير مخصصة بالذكاء الاصطناعي";
//            // 
//            // btnImportantReports
//            // 
//            this.btnImportantReports.BackColor = System.Drawing.Color.Transparent;
//            this.btnImportantReports.BorderRadius = 12;
//            this.btnImportantReports.FillColor = System.Drawing.Color.White;
//            this.btnImportantReports.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
//            this.btnImportantReports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
//            this.btnImportantReports.HoverState.FillColor = System.Drawing.Color.White;
//            this.btnImportantReports.Location = new System.Drawing.Point(704, 84);
//            this.btnImportantReports.Name = "btnImportantReports";
//            this.btnImportantReports.ShadowDecoration.Enabled = true;
//            this.btnImportantReports.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.btnImportantReports.Size = new System.Drawing.Size(254, 112);
//            this.btnImportantReports.TabIndex = 0;
//            this.btnImportantReports.Text = "▤  التقارير الأساسية";
//            // 
//            // tabPartners
//            // 
//            this.tabPartners.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
//            this.tabPartners.Controls.Add(this.lblPartnersSubtitle);
//            this.tabPartners.Controls.Add(this.lblPartnersTitle);
//            this.tabPartners.Controls.Add(this.pnlPartnersActions);
//            this.tabPartners.Controls.Add(this.pnlPartnersTransactions);
//            this.tabPartners.Controls.Add(this.pnlPartnersProfit);
//            this.tabPartners.Controls.Add(this.pnlPartnersBalance);
//            this.tabPartners.Controls.Add(this.btnListPartners);
//            this.tabPartners.Controls.Add(this.btnWithdrawDeposit);
//            this.tabPartners.Location = new System.Drawing.Point(4, 4);
//            this.tabPartners.Name = "tabPartners";
//            this.tabPartners.Padding = new System.Windows.Forms.Padding(28);
//            this.tabPartners.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
//            this.tabPartners.Size = new System.Drawing.Size(986, 784);
//            this.tabPartners.TabIndex = 7;
//            // 
//            // lblPartnersSubtitle
//            // 
//            this.lblPartnersSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
//            this.lblPartnersSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(126)))), ((int)(((byte)(136)))));
//            this.lblPartnersSubtitle.Location = new System.Drawing.Point(480, 55);
//            this.lblPartnersSubtitle.Name = "lblPartnersSubtitle";
//            this.lblPartnersSubtitle.Size = new System.Drawing.Size(478, 20);
//            this.lblPartnersSubtitle.TabIndex = 1;
//            this.lblPartnersSubtitle.Text = "إدارة أرصدة الشركاء والسحب والإيداع وتوزيع الأرباح";
//            this.lblPartnersSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // lblPartnersTitle
//            // 
//            this.lblPartnersTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
//            this.lblPartnersTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
//            this.lblPartnersTitle.Location = new System.Drawing.Point(600, 20);
//            this.lblPartnersTitle.Name = "lblPartnersTitle";
//            this.lblPartnersTitle.Size = new System.Drawing.Size(358, 32);
//            this.lblPartnersTitle.TabIndex = 0;
//            this.lblPartnersTitle.Text = "الشركاء";
//            this.lblPartnersTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // pnlPartnersActions
//            // 
//            this.pnlPartnersActions.BackColor = System.Drawing.Color.Transparent;
//            this.pnlPartnersActions.BorderRadius = 12;
//            this.pnlPartnersActions.Controls.Add(this.lblPartnersActionsHint);
//            this.pnlPartnersActions.Controls.Add(this.lblPartnersActions);
//            this.pnlPartnersActions.FillColor = System.Drawing.Color.White;
//            this.pnlPartnersActions.Location = new System.Drawing.Point(28, 340);
//            this.pnlPartnersActions.Name = "pnlPartnersActions";
//            this.pnlPartnersActions.ShadowDecoration.Enabled = true;
//            this.pnlPartnersActions.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.pnlPartnersActions.Size = new System.Drawing.Size(930, 150);
//            this.pnlPartnersActions.TabIndex = 2;
//            // 
//            // lblPartnersActionsHint
//            // 
//            this.lblPartnersActionsHint.Font = new System.Drawing.Font("Segoe UI", 8.5F);
//            this.lblPartnersActionsHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(138)))));
//            this.lblPartnersActionsHint.Location = new System.Drawing.Point(18, 46);
//            this.lblPartnersActionsHint.Name = "lblPartnersActionsHint";
//            this.lblPartnersActionsHint.Size = new System.Drawing.Size(894, 92);
//            this.lblPartnersActionsHint.TabIndex = 0;
//            this.lblPartnersActionsHint.Text = "اعتبر حساب كل شريك حساباً داخلياً واضحاً، وسجل السحب والإيداع والأرباح ضمن سجل ال" +
//    "حركات.";
//            this.lblPartnersActionsHint.TextAlign = System.Drawing.ContentAlignment.TopRight;
//            // 
//            // lblPartnersActions
//            // 
//            this.lblPartnersActions.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
//            this.lblPartnersActions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
//            this.lblPartnersActions.Location = new System.Drawing.Point(18, 16);
//            this.lblPartnersActions.Name = "lblPartnersActions";
//            this.lblPartnersActions.Size = new System.Drawing.Size(894, 24);
//            this.lblPartnersActions.TabIndex = 1;
//            this.lblPartnersActions.Text = "حسابات الشركاء";
//            this.lblPartnersActions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // pnlPartnersTransactions
//            // 
//            this.pnlPartnersTransactions.BackColor = System.Drawing.Color.Transparent;
//            this.pnlPartnersTransactions.BorderRadius = 12;
//            this.pnlPartnersTransactions.Controls.Add(this.lblPartnersTransactionsValue);
//            this.pnlPartnersTransactions.Controls.Add(this.lblPartnersTransactionsCaption);
//            this.pnlPartnersTransactions.FillColor = System.Drawing.Color.White;
//            this.pnlPartnersTransactions.Location = new System.Drawing.Point(160, 216);
//            this.pnlPartnersTransactions.Name = "pnlPartnersTransactions";
//            this.pnlPartnersTransactions.ShadowDecoration.Enabled = true;
//            this.pnlPartnersTransactions.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.pnlPartnersTransactions.Size = new System.Drawing.Size(254, 100);
//            this.pnlPartnersTransactions.TabIndex = 3;
//            // 
//            // lblPartnersTransactionsValue
//            // 
//            this.lblPartnersTransactionsValue.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
//            this.lblPartnersTransactionsValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
//            this.lblPartnersTransactionsValue.Location = new System.Drawing.Point(16, 38);
//            this.lblPartnersTransactionsValue.Name = "lblPartnersTransactionsValue";
//            this.lblPartnersTransactionsValue.Size = new System.Drawing.Size(222, 30);
//            this.lblPartnersTransactionsValue.TabIndex = 0;
//            this.lblPartnersTransactionsValue.Text = "0";
//            this.lblPartnersTransactionsValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // lblPartnersTransactionsCaption
//            // 
//            this.lblPartnersTransactionsCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
//            this.lblPartnersTransactionsCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(138)))));
//            this.lblPartnersTransactionsCaption.Location = new System.Drawing.Point(16, 12);
//            this.lblPartnersTransactionsCaption.Name = "lblPartnersTransactionsCaption";
//            this.lblPartnersTransactionsCaption.Size = new System.Drawing.Size(222, 20);
//            this.lblPartnersTransactionsCaption.TabIndex = 1;
//            this.lblPartnersTransactionsCaption.Text = "حركات هذا الشهر";
//            this.lblPartnersTransactionsCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // pnlPartnersProfit
//            // 
//            this.pnlPartnersProfit.BackColor = System.Drawing.Color.Transparent;
//            this.pnlPartnersProfit.BorderRadius = 12;
//            this.pnlPartnersProfit.Controls.Add(this.lblPartnersProfitValue);
//            this.pnlPartnersProfit.Controls.Add(this.lblPartnersProfitCaption);
//            this.pnlPartnersProfit.FillColor = System.Drawing.Color.White;
//            this.pnlPartnersProfit.Location = new System.Drawing.Point(432, 216);
//            this.pnlPartnersProfit.Name = "pnlPartnersProfit";
//            this.pnlPartnersProfit.ShadowDecoration.Enabled = true;
//            this.pnlPartnersProfit.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.pnlPartnersProfit.Size = new System.Drawing.Size(254, 100);
//            this.pnlPartnersProfit.TabIndex = 4;
//            // 
//            // lblPartnersProfitValue
//            // 
//            this.lblPartnersProfitValue.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
//            this.lblPartnersProfitValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(199)))), ((int)(((byte)(111)))));
//            this.lblPartnersProfitValue.Location = new System.Drawing.Point(16, 38);
//            this.lblPartnersProfitValue.Name = "lblPartnersProfitValue";
//            this.lblPartnersProfitValue.Size = new System.Drawing.Size(222, 30);
//            this.lblPartnersProfitValue.TabIndex = 0;
//            this.lblPartnersProfitValue.Text = "0.00 ل.س";
//            this.lblPartnersProfitValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // lblPartnersProfitCaption
//            // 
//            this.lblPartnersProfitCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
//            this.lblPartnersProfitCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(138)))));
//            this.lblPartnersProfitCaption.Location = new System.Drawing.Point(16, 12);
//            this.lblPartnersProfitCaption.Name = "lblPartnersProfitCaption";
//            this.lblPartnersProfitCaption.Size = new System.Drawing.Size(222, 20);
//            this.lblPartnersProfitCaption.TabIndex = 1;
//            this.lblPartnersProfitCaption.Text = "أرباح الشركاء";
//            this.lblPartnersProfitCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // pnlPartnersBalance
//            // 
//            this.pnlPartnersBalance.BackColor = System.Drawing.Color.Transparent;
//            this.pnlPartnersBalance.BorderRadius = 12;
//            this.pnlPartnersBalance.Controls.Add(this.lblPartnersBalanceValue);
//            this.pnlPartnersBalance.Controls.Add(this.lblPartnersBalanceCaption);
//            this.pnlPartnersBalance.FillColor = System.Drawing.Color.White;
//            this.pnlPartnersBalance.Location = new System.Drawing.Point(704, 216);
//            this.pnlPartnersBalance.Name = "pnlPartnersBalance";
//            this.pnlPartnersBalance.ShadowDecoration.Enabled = true;
//            this.pnlPartnersBalance.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.pnlPartnersBalance.Size = new System.Drawing.Size(254, 100);
//            this.pnlPartnersBalance.TabIndex = 5;
//            // 
//            // lblPartnersBalanceValue
//            // 
//            this.lblPartnersBalanceValue.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
//            this.lblPartnersBalanceValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(103)))), ((int)(((byte)(240)))));
//            this.lblPartnersBalanceValue.Location = new System.Drawing.Point(16, 38);
//            this.lblPartnersBalanceValue.Name = "lblPartnersBalanceValue";
//            this.lblPartnersBalanceValue.Size = new System.Drawing.Size(222, 30);
//            this.lblPartnersBalanceValue.TabIndex = 0;
//            this.lblPartnersBalanceValue.Text = "0.00 ل.س";
//            this.lblPartnersBalanceValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // lblPartnersBalanceCaption
//            // 
//            this.lblPartnersBalanceCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
//            this.lblPartnersBalanceCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(138)))));
//            this.lblPartnersBalanceCaption.Location = new System.Drawing.Point(16, 12);
//            this.lblPartnersBalanceCaption.Name = "lblPartnersBalanceCaption";
//            this.lblPartnersBalanceCaption.Size = new System.Drawing.Size(222, 20);
//            this.lblPartnersBalanceCaption.TabIndex = 1;
//            this.lblPartnersBalanceCaption.Text = "إجمالي أرصدة الشركاء";
//            this.lblPartnersBalanceCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // btnListPartners
//            // 
//            this.btnListPartners.BackColor = System.Drawing.Color.Transparent;
//            this.btnListPartners.BorderRadius = 12;
//            this.btnListPartners.FillColor = System.Drawing.Color.White;
//            this.btnListPartners.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
//            this.btnListPartners.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
//            this.btnListPartners.HoverState.FillColor = System.Drawing.Color.White;
//            this.btnListPartners.Location = new System.Drawing.Point(432, 84);
//            this.btnListPartners.Name = "btnListPartners";
//            this.btnListPartners.ShadowDecoration.Enabled = true;
//            this.btnListPartners.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.btnListPartners.Size = new System.Drawing.Size(254, 112);
//            this.btnListPartners.TabIndex = 0;
//            this.btnListPartners.Text = "☷  قائمة الشركاء";
//            // 
//            // btnWithdrawDeposit
//            // 
//            this.btnWithdrawDeposit.BackColor = System.Drawing.Color.Transparent;
//            this.btnWithdrawDeposit.BorderRadius = 12;
//            this.btnWithdrawDeposit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(199)))), ((int)(((byte)(111)))));
//            this.btnWithdrawDeposit.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
//            this.btnWithdrawDeposit.ForeColor = System.Drawing.Color.White;
//            this.btnWithdrawDeposit.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(199)))), ((int)(((byte)(111)))));
//            this.btnWithdrawDeposit.Location = new System.Drawing.Point(704, 84);
//            this.btnWithdrawDeposit.Name = "btnWithdrawDeposit";
//            this.btnWithdrawDeposit.ShadowDecoration.Enabled = true;
//            this.btnWithdrawDeposit.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.btnWithdrawDeposit.Size = new System.Drawing.Size(254, 112);
//            this.btnWithdrawDeposit.TabIndex = 0;
//            this.btnWithdrawDeposit.Text = "⇄  سحب / إيداع";
//            // 
//            // tabUsers
//            // 
//            this.tabUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
//            this.tabUsers.Controls.Add(this.lblUsersSubtitle);
//            this.tabUsers.Controls.Add(this.lblUsersTitle);
//            this.tabUsers.Controls.Add(this.pnlUsersActions);
//            this.tabUsers.Controls.Add(this.pnlUsersSecurity);
//            this.tabUsers.Controls.Add(this.pnlUsersCount);
//            this.tabUsers.Controls.Add(this.btnListUsers);
//            this.tabUsers.Controls.Add(this.btnAddNewUser);
//            this.tabUsers.Location = new System.Drawing.Point(4, 4);
//            this.tabUsers.Name = "tabUsers";
//            this.tabUsers.Padding = new System.Windows.Forms.Padding(28);
//            this.tabUsers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
//            this.tabUsers.Size = new System.Drawing.Size(986, 784);
//            this.tabUsers.TabIndex = 8;
//            // 
//            // lblUsersSubtitle
//            // 
//            this.lblUsersSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
//            this.lblUsersSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(126)))), ((int)(((byte)(136)))));
//            this.lblUsersSubtitle.Location = new System.Drawing.Point(480, 55);
//            this.lblUsersSubtitle.Name = "lblUsersSubtitle";
//            this.lblUsersSubtitle.Size = new System.Drawing.Size(478, 20);
//            this.lblUsersSubtitle.TabIndex = 1;
//            this.lblUsersSubtitle.Text = "إدارة مستخدمي النظام والصلاحيات والوصول";
//            this.lblUsersSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // lblUsersTitle
//            // 
//            this.lblUsersTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
//            this.lblUsersTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
//            this.lblUsersTitle.Location = new System.Drawing.Point(600, 20);
//            this.lblUsersTitle.Name = "lblUsersTitle";
//            this.lblUsersTitle.Size = new System.Drawing.Size(358, 32);
//            this.lblUsersTitle.TabIndex = 0;
//            this.lblUsersTitle.Text = "المستخدمين";
//            this.lblUsersTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // pnlUsersActions
//            // 
//            this.pnlUsersActions.BackColor = System.Drawing.Color.Transparent;
//            this.pnlUsersActions.BorderRadius = 12;
//            this.pnlUsersActions.Controls.Add(this.lblUsersActionsHint);
//            this.pnlUsersActions.Controls.Add(this.lblUsersActions);
//            this.pnlUsersActions.FillColor = System.Drawing.Color.White;
//            this.pnlUsersActions.Location = new System.Drawing.Point(160, 216);
//            this.pnlUsersActions.Name = "pnlUsersActions";
//            this.pnlUsersActions.ShadowDecoration.Enabled = true;
//            this.pnlUsersActions.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.pnlUsersActions.Size = new System.Drawing.Size(254, 100);
//            this.pnlUsersActions.TabIndex = 2;
//            // 
//            // lblUsersActionsHint
//            // 
//            this.lblUsersActionsHint.Font = new System.Drawing.Font("Segoe UI", 8.5F);
//            this.lblUsersActionsHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(138)))));
//            this.lblUsersActionsHint.Location = new System.Drawing.Point(18, 46);
//            this.lblUsersActionsHint.Name = "lblUsersActionsHint";
//            this.lblUsersActionsHint.Size = new System.Drawing.Size(218, 42);
//            this.lblUsersActionsHint.TabIndex = 0;
//            this.lblUsersActionsHint.Text = "أضف المستخدمين وحدد صلاحياتهم من قائمة المستخدمين، مع الحفاظ على سجل التدقيق في ا" +
//    "لعمليات الحساسة.";
//            this.lblUsersActionsHint.TextAlign = System.Drawing.ContentAlignment.TopRight;
//            // 
//            // lblUsersActions
//            // 
//            this.lblUsersActions.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
//            this.lblUsersActions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
//            this.lblUsersActions.Location = new System.Drawing.Point(18, 16);
//            this.lblUsersActions.Name = "lblUsersActions";
//            this.lblUsersActions.Size = new System.Drawing.Size(218, 24);
//            this.lblUsersActions.TabIndex = 1;
//            this.lblUsersActions.Text = "إدارة المستخدمين";
//            this.lblUsersActions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // pnlUsersSecurity
//            // 
//            this.pnlUsersSecurity.BackColor = System.Drawing.Color.Transparent;
//            this.pnlUsersSecurity.BorderRadius = 12;
//            this.pnlUsersSecurity.Controls.Add(this.lblUsersSecurityValue);
//            this.pnlUsersSecurity.Controls.Add(this.lblUsersSecurityCaption);
//            this.pnlUsersSecurity.FillColor = System.Drawing.Color.White;
//            this.pnlUsersSecurity.Location = new System.Drawing.Point(432, 216);
//            this.pnlUsersSecurity.Name = "pnlUsersSecurity";
//            this.pnlUsersSecurity.ShadowDecoration.Enabled = true;
//            this.pnlUsersSecurity.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.pnlUsersSecurity.Size = new System.Drawing.Size(254, 100);
//            this.pnlUsersSecurity.TabIndex = 3;
//            // 
//            // lblUsersSecurityValue
//            // 
//            this.lblUsersSecurityValue.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
//            this.lblUsersSecurityValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(199)))), ((int)(((byte)(111)))));
//            this.lblUsersSecurityValue.Location = new System.Drawing.Point(16, 38);
//            this.lblUsersSecurityValue.Name = "lblUsersSecurityValue";
//            this.lblUsersSecurityValue.Size = new System.Drawing.Size(222, 30);
//            this.lblUsersSecurityValue.TabIndex = 0;
//            this.lblUsersSecurityValue.Text = "مفعلة";
//            this.lblUsersSecurityValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // lblUsersSecurityCaption
//            // 
//            this.lblUsersSecurityCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
//            this.lblUsersSecurityCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(138)))));
//            this.lblUsersSecurityCaption.Location = new System.Drawing.Point(16, 12);
//            this.lblUsersSecurityCaption.Name = "lblUsersSecurityCaption";
//            this.lblUsersSecurityCaption.Size = new System.Drawing.Size(222, 20);
//            this.lblUsersSecurityCaption.TabIndex = 1;
//            this.lblUsersSecurityCaption.Text = "الحماية";
//            this.lblUsersSecurityCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // pnlUsersCount
//            // 
//            this.pnlUsersCount.BackColor = System.Drawing.Color.Transparent;
//            this.pnlUsersCount.BorderRadius = 12;
//            this.pnlUsersCount.Controls.Add(this.lblUsersCountValue);
//            this.pnlUsersCount.Controls.Add(this.lblUsersCountCaption);
//            this.pnlUsersCount.FillColor = System.Drawing.Color.White;
//            this.pnlUsersCount.Location = new System.Drawing.Point(704, 216);
//            this.pnlUsersCount.Name = "pnlUsersCount";
//            this.pnlUsersCount.ShadowDecoration.Enabled = true;
//            this.pnlUsersCount.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.pnlUsersCount.Size = new System.Drawing.Size(254, 100);
//            this.pnlUsersCount.TabIndex = 4;
//            // 
//            // lblUsersCountValue
//            // 
//            this.lblUsersCountValue.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
//            this.lblUsersCountValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(103)))), ((int)(((byte)(240)))));
//            this.lblUsersCountValue.Location = new System.Drawing.Point(16, 38);
//            this.lblUsersCountValue.Name = "lblUsersCountValue";
//            this.lblUsersCountValue.Size = new System.Drawing.Size(222, 30);
//            this.lblUsersCountValue.TabIndex = 0;
//            this.lblUsersCountValue.Text = "0";
//            this.lblUsersCountValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // lblUsersCountCaption
//            // 
//            this.lblUsersCountCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
//            this.lblUsersCountCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(138)))));
//            this.lblUsersCountCaption.Location = new System.Drawing.Point(16, 12);
//            this.lblUsersCountCaption.Name = "lblUsersCountCaption";
//            this.lblUsersCountCaption.Size = new System.Drawing.Size(222, 20);
//            this.lblUsersCountCaption.TabIndex = 1;
//            this.lblUsersCountCaption.Text = "المستخدمون";
//            this.lblUsersCountCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // btnListUsers
//            // 
//            this.btnListUsers.BackColor = System.Drawing.Color.Transparent;
//            this.btnListUsers.BorderRadius = 12;
//            this.btnListUsers.FillColor = System.Drawing.Color.White;
//            this.btnListUsers.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
//            this.btnListUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
//            this.btnListUsers.HoverState.FillColor = System.Drawing.Color.White;
//            this.btnListUsers.Location = new System.Drawing.Point(432, 84);
//            this.btnListUsers.Name = "btnListUsers";
//            this.btnListUsers.ShadowDecoration.Enabled = true;
//            this.btnListUsers.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.btnListUsers.Size = new System.Drawing.Size(254, 112);
//            this.btnListUsers.TabIndex = 0;
//            this.btnListUsers.Text = "☷  قائمة المستخدمين";
//            // 
//            // btnAddNewUser
//            // 
//            this.btnAddNewUser.BackColor = System.Drawing.Color.Transparent;
//            this.btnAddNewUser.BorderRadius = 12;
//            this.btnAddNewUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(103)))), ((int)(((byte)(240)))));
//            this.btnAddNewUser.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
//            this.btnAddNewUser.ForeColor = System.Drawing.Color.White;
//            this.btnAddNewUser.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(103)))), ((int)(((byte)(240)))));
//            this.btnAddNewUser.Location = new System.Drawing.Point(704, 84);
//            this.btnAddNewUser.Name = "btnAddNewUser";
//            this.btnAddNewUser.ShadowDecoration.Enabled = true;
//            this.btnAddNewUser.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.btnAddNewUser.Size = new System.Drawing.Size(254, 112);
//            this.btnAddNewUser.TabIndex = 0;
//            this.btnAddNewUser.Text = "＋  إضافة مستخدم جديد";
//            // 
//            // tabSettings
//            // 
//            this.tabSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
//            this.tabSettings.Controls.Add(this.lblSettingsSubtitle);
//            this.tabSettings.Controls.Add(this.lblSettingsTitle);
//            this.tabSettings.Controls.Add(this.pnlSettingsAccount);
//            this.tabSettings.Controls.Add(this.pnlSettingsBackup);
//            this.tabSettings.Controls.Add(this.pnlSettingsInfo);
//            this.tabSettings.Controls.Add(this.btnLogout);
//            this.tabSettings.Controls.Add(this.btnBackupRestore);
//            this.tabSettings.Controls.Add(this.btnGeneralSettings);
//            this.tabSettings.Controls.Add(this.btnCurrentUserInfo);
//            this.tabSettings.Location = new System.Drawing.Point(4, 4);
//            this.tabSettings.Name = "tabSettings";
//            this.tabSettings.Padding = new System.Windows.Forms.Padding(28);
//            this.tabSettings.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
//            this.tabSettings.Size = new System.Drawing.Size(986, 784);
//            this.tabSettings.TabIndex = 9;
//            // 
//            // lblSettingsSubtitle
//            // 
//            this.lblSettingsSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
//            this.lblSettingsSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(126)))), ((int)(((byte)(136)))));
//            this.lblSettingsSubtitle.Location = new System.Drawing.Point(480, 55);
//            this.lblSettingsSubtitle.Name = "lblSettingsSubtitle";
//            this.lblSettingsSubtitle.Size = new System.Drawing.Size(478, 20);
//            this.lblSettingsSubtitle.TabIndex = 1;
//            this.lblSettingsSubtitle.Text = "إعدادات النظام والحساب والنسخ الاحتياطي";
//            this.lblSettingsSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // lblSettingsTitle
//            // 
//            this.lblSettingsTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
//            this.lblSettingsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
//            this.lblSettingsTitle.Location = new System.Drawing.Point(600, 20);
//            this.lblSettingsTitle.Name = "lblSettingsTitle";
//            this.lblSettingsTitle.Size = new System.Drawing.Size(358, 32);
//            this.lblSettingsTitle.TabIndex = 0;
//            this.lblSettingsTitle.Text = "الإعدادات";
//            this.lblSettingsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // pnlSettingsAccount
//            // 
//            this.pnlSettingsAccount.BackColor = System.Drawing.Color.Transparent;
//            this.pnlSettingsAccount.BorderRadius = 12;
//            this.pnlSettingsAccount.Controls.Add(this.lblSettingsAccountText);
//            this.pnlSettingsAccount.Controls.Add(this.lblSettingsAccountTitle);
//            this.pnlSettingsAccount.FillColor = System.Drawing.Color.White;
//            this.pnlSettingsAccount.Location = new System.Drawing.Point(704, 316);
//            this.pnlSettingsAccount.Name = "pnlSettingsAccount";
//            this.pnlSettingsAccount.ShadowDecoration.Enabled = true;
//            this.pnlSettingsAccount.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.pnlSettingsAccount.Size = new System.Drawing.Size(254, 112);
//            this.pnlSettingsAccount.TabIndex = 2;
//            // 
//            // lblSettingsAccountText
//            // 
//            this.lblSettingsAccountText.Font = new System.Drawing.Font("Segoe UI", 8.5F);
//            this.lblSettingsAccountText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(138)))));
//            this.lblSettingsAccountText.Location = new System.Drawing.Point(18, 46);
//            this.lblSettingsAccountText.Name = "lblSettingsAccountText";
//            this.lblSettingsAccountText.Size = new System.Drawing.Size(218, 54);
//            this.lblSettingsAccountText.TabIndex = 0;
//            this.lblSettingsAccountText.Text = "إدارة معلومات المستخدم الحالي وكلمة المرور من الخيارات أعلاه.";
//            this.lblSettingsAccountText.TextAlign = System.Drawing.ContentAlignment.TopRight;
//            // 
//            // lblSettingsAccountTitle
//            // 
//            this.lblSettingsAccountTitle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
//            this.lblSettingsAccountTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
//            this.lblSettingsAccountTitle.Location = new System.Drawing.Point(18, 16);
//            this.lblSettingsAccountTitle.Name = "lblSettingsAccountTitle";
//            this.lblSettingsAccountTitle.Size = new System.Drawing.Size(218, 24);
//            this.lblSettingsAccountTitle.TabIndex = 1;
//            this.lblSettingsAccountTitle.Text = "الحساب";
//            this.lblSettingsAccountTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // pnlSettingsBackup
//            // 
//            this.pnlSettingsBackup.BackColor = System.Drawing.Color.Transparent;
//            this.pnlSettingsBackup.BorderRadius = 12;
//            this.pnlSettingsBackup.Controls.Add(this.lblSettingsBackupText);
//            this.pnlSettingsBackup.Controls.Add(this.lblSettingsBackupTitle);
//            this.pnlSettingsBackup.FillColor = System.Drawing.Color.White;
//            this.pnlSettingsBackup.Location = new System.Drawing.Point(160, 216);
//            this.pnlSettingsBackup.Name = "pnlSettingsBackup";
//            this.pnlSettingsBackup.ShadowDecoration.Enabled = true;
//            this.pnlSettingsBackup.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.pnlSettingsBackup.Size = new System.Drawing.Size(254, 112);
//            this.pnlSettingsBackup.TabIndex = 3;
//            // 
//            // lblSettingsBackupText
//            // 
//            this.lblSettingsBackupText.Font = new System.Drawing.Font("Segoe UI", 8.5F);
//            this.lblSettingsBackupText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(138)))));
//            this.lblSettingsBackupText.Location = new System.Drawing.Point(18, 46);
//            this.lblSettingsBackupText.Name = "lblSettingsBackupText";
//            this.lblSettingsBackupText.Size = new System.Drawing.Size(218, 54);
//            this.lblSettingsBackupText.TabIndex = 0;
//            this.lblSettingsBackupText.Text = "احرص على أخذ نسخة احتياطية دورية من قاعدة البيانات وحفظها في مكان آمن.";
//            this.lblSettingsBackupText.TextAlign = System.Drawing.ContentAlignment.TopRight;
//            // 
//            // lblSettingsBackupTitle
//            // 
//            this.lblSettingsBackupTitle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
//            this.lblSettingsBackupTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
//            this.lblSettingsBackupTitle.Location = new System.Drawing.Point(18, 16);
//            this.lblSettingsBackupTitle.Name = "lblSettingsBackupTitle";
//            this.lblSettingsBackupTitle.Size = new System.Drawing.Size(218, 24);
//            this.lblSettingsBackupTitle.TabIndex = 1;
//            this.lblSettingsBackupTitle.Text = "النسخ الاحتياطي";
//            this.lblSettingsBackupTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // pnlSettingsInfo
//            // 
//            this.pnlSettingsInfo.BackColor = System.Drawing.Color.Transparent;
//            this.pnlSettingsInfo.BorderRadius = 12;
//            this.pnlSettingsInfo.Controls.Add(this.lblSettingsInfoText);
//            this.pnlSettingsInfo.Controls.Add(this.lblSettingsInfoTitle);
//            this.pnlSettingsInfo.FillColor = System.Drawing.Color.White;
//            this.pnlSettingsInfo.Location = new System.Drawing.Point(432, 216);
//            this.pnlSettingsInfo.Name = "pnlSettingsInfo";
//            this.pnlSettingsInfo.ShadowDecoration.Enabled = true;
//            this.pnlSettingsInfo.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.pnlSettingsInfo.Size = new System.Drawing.Size(254, 112);
//            this.pnlSettingsInfo.TabIndex = 4;
//            // 
//            // lblSettingsInfoText
//            // 
//            this.lblSettingsInfoText.Font = new System.Drawing.Font("Segoe UI", 8.5F);
//            this.lblSettingsInfoText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(138)))));
//            this.lblSettingsInfoText.Location = new System.Drawing.Point(18, 46);
//            this.lblSettingsInfoText.Name = "lblSettingsInfoText";
//            this.lblSettingsInfoText.Size = new System.Drawing.Size(218, 54);
//            this.lblSettingsInfoText.TabIndex = 0;
//            this.lblSettingsInfoText.Text = "مكان مناسب لاحقاً لعرض إصدار النظام، حالة قاعدة البيانات، وآخر نسخة احتياطية.";
//            this.lblSettingsInfoText.TextAlign = System.Drawing.ContentAlignment.TopRight;
//            // 
//            // lblSettingsInfoTitle
//            // 
//            this.lblSettingsInfoTitle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
//            this.lblSettingsInfoTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
//            this.lblSettingsInfoTitle.Location = new System.Drawing.Point(18, 16);
//            this.lblSettingsInfoTitle.Name = "lblSettingsInfoTitle";
//            this.lblSettingsInfoTitle.Size = new System.Drawing.Size(218, 24);
//            this.lblSettingsInfoTitle.TabIndex = 1;
//            this.lblSettingsInfoTitle.Text = "معلومات النظام";
//            this.lblSettingsInfoTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // btnLogout
//            // 
//            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
//            this.btnLogout.BorderRadius = 12;
//            this.btnLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(84)))), ((int)(((byte)(85)))));
//            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
//            this.btnLogout.ForeColor = System.Drawing.Color.White;
//            this.btnLogout.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(84)))), ((int)(((byte)(85)))));
//            this.btnLogout.Location = new System.Drawing.Point(704, 216);
//            this.btnLogout.Name = "btnLogout";
//            this.btnLogout.ShadowDecoration.Enabled = true;
//            this.btnLogout.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.btnLogout.Size = new System.Drawing.Size(254, 72);
//            this.btnLogout.TabIndex = 0;
//            this.btnLogout.Text = "⇥  تسجيل الخروج";
//            // 
//            // btnBackupRestore
//            // 
//            this.btnBackupRestore.BackColor = System.Drawing.Color.Transparent;
//            this.btnBackupRestore.BorderRadius = 12;
//            this.btnBackupRestore.FillColor = System.Drawing.Color.White;
//            this.btnBackupRestore.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
//            this.btnBackupRestore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
//            this.btnBackupRestore.HoverState.FillColor = System.Drawing.Color.White;
//            this.btnBackupRestore.Location = new System.Drawing.Point(160, 84);
//            this.btnBackupRestore.Name = "btnBackupRestore";
//            this.btnBackupRestore.ShadowDecoration.Enabled = true;
//            this.btnBackupRestore.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.btnBackupRestore.Size = new System.Drawing.Size(254, 112);
//            this.btnBackupRestore.TabIndex = 0;
//            this.btnBackupRestore.Text = "↥  النسخ الاحتياطي والاستعادة";
//            // 
//            // btnGeneralSettings
//            // 
//            this.btnGeneralSettings.BackColor = System.Drawing.Color.Transparent;
//            this.btnGeneralSettings.BorderRadius = 12;
//            this.btnGeneralSettings.FillColor = System.Drawing.Color.White;
//            this.btnGeneralSettings.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
//            this.btnGeneralSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
//            this.btnGeneralSettings.HoverState.FillColor = System.Drawing.Color.White;
//            this.btnGeneralSettings.Location = new System.Drawing.Point(432, 84);
//            this.btnGeneralSettings.Name = "btnGeneralSettings";
//            this.btnGeneralSettings.ShadowDecoration.Enabled = true;
//            this.btnGeneralSettings.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.btnGeneralSettings.Size = new System.Drawing.Size(254, 112);
//            this.btnGeneralSettings.TabIndex = 0;
//            this.btnGeneralSettings.Text = "⚙  الإعدادات العامة";
//            // 
//            // btnCurrentUserInfo
//            // 
//            this.btnCurrentUserInfo.BackColor = System.Drawing.Color.Transparent;
//            this.btnCurrentUserInfo.BorderRadius = 12;
//            this.btnCurrentUserInfo.FillColor = System.Drawing.Color.White;
//            this.btnCurrentUserInfo.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
//            this.btnCurrentUserInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
//            this.btnCurrentUserInfo.HoverState.FillColor = System.Drawing.Color.White;
//            this.btnCurrentUserInfo.Location = new System.Drawing.Point(704, 84);
//            this.btnCurrentUserInfo.Name = "btnCurrentUserInfo";
//            this.btnCurrentUserInfo.ShadowDecoration.Enabled = true;
//            this.btnCurrentUserInfo.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 4);
//            this.btnCurrentUserInfo.Size = new System.Drawing.Size(254, 112);
//            this.btnCurrentUserInfo.TabIndex = 0;
//            this.btnCurrentUserInfo.Text = "◉  معلومات المستخدم الحالي";
//            // 
//            // frmMain
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
//            this.ClientSize = new System.Drawing.Size(1184, 792);
//            this.Controls.Add(this.tcMain);
//            this.Name = "frmMain";
//            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
//            this.RightToLeftLayout = true;
//            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
//            this.Text = "نظام الماهر لنقاط البيع والمحاسبة";
//            this.tcMain.ResumeLayout(false);
//            this.tabDashboard.ResumeLayout(false);
//            this.tabDashboard.PerformLayout();
//            this.pnlSalesOverview.ResumeLayout(false);
//            this.pnlSalesOverview.PerformLayout();
//            this.pnlRecentInvoices.ResumeLayout(false);
//            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentInvoices)).EndInit();
//            this.pnlLowStock.ResumeLayout(false);
//            ((System.ComponentModel.ISupportInitialize)(this.dgvLowStock)).EndInit();
//            this.pnlStockValueCard.ResumeLayout(false);
//            this.pnlPayablesCard.ResumeLayout(false);
//            this.pnlReceivablesCard.ResumeLayout(false);
//            this.pnlPurchaseCard.ResumeLayout(false);
//            this.pnlUsersCard.ResumeLayout(false);
//            this.pnlOrdersCard.ResumeLayout(false);
//            this.pnlCashCard.ResumeLayout(false);
//            this.pnlSalesCard.ResumeLayout(false);
//            this.tabSales.ResumeLayout(false);
//            this.pnlSalesActions.ResumeLayout(false);
//            this.pnlSalesDebt.ResumeLayout(false);
//            this.pnlSalesInvoices.ResumeLayout(false);
//            this.pnlSalesToday.ResumeLayout(false);
//            this.tabPurchases.ResumeLayout(false);
//            this.pnlPurchasesActions.ResumeLayout(false);
//            this.pnlPurchasesDebt.ResumeLayout(false);
//            this.pnlPurchasesInvoices.ResumeLayout(false);
//            this.pnlPurchasesToday.ResumeLayout(false);
//            this.tabProducts.ResumeLayout(false);
//            this.pnlProductsActions.ResumeLayout(false);
//            this.pnlProductsCategories.ResumeLayout(false);
//            this.pnlProductsLowStock.ResumeLayout(false);
//            this.pnlProductsCount.ResumeLayout(false);
//            this.tabCustomers.ResumeLayout(false);
//            this.pnlCustomersActions.ResumeLayout(false);
//            this.pnlCustomersDebt.ResumeLayout(false);
//            this.pnlCustomersCount.ResumeLayout(false);
//            this.tabSuppliers.ResumeLayout(false);
//            this.pnlSuppliersActions.ResumeLayout(false);
//            this.pnlSuppliersDebt.ResumeLayout(false);
//            this.pnlSuppliersCount.ResumeLayout(false);
//            this.tabReports.ResumeLayout(false);
//            this.pnlReportsProfit.ResumeLayout(false);
//            this.pnlReportsDebt.ResumeLayout(false);
//            this.pnlReportsStock.ResumeLayout(false);
//            this.pnlReportsSales.ResumeLayout(false);
//            this.tabPartners.ResumeLayout(false);
//            this.pnlPartnersActions.ResumeLayout(false);
//            this.pnlPartnersTransactions.ResumeLayout(false);
//            this.pnlPartnersProfit.ResumeLayout(false);
//            this.pnlPartnersBalance.ResumeLayout(false);
//            this.tabUsers.ResumeLayout(false);
//            this.pnlUsersActions.ResumeLayout(false);
//            this.pnlUsersSecurity.ResumeLayout(false);
//            this.pnlUsersCount.ResumeLayout(false);
//            this.tabSettings.ResumeLayout(false);
//            this.pnlSettingsAccount.ResumeLayout(false);
//            this.pnlSettingsBackup.ResumeLayout(false);
//            this.pnlSettingsInfo.ResumeLayout(false);
//            this.ResumeLayout(false);

//        }

//        #endregion

//        // -----------------------------------------------------------------
//        // Existing fields preserved for compatibility with frmMain.cs.
//        // -----------------------------------------------------------------
//        private Guna.UI2.WinForms.Guna2TabControl tcMain;
//        private System.Windows.Forms.TabPage tabDashboard;
//        private System.Windows.Forms.TabPage tabSales;
//        private System.Windows.Forms.TabPage tabPurchases;
//        private System.Windows.Forms.TabPage tabProducts;
//        private System.Windows.Forms.TabPage tabCustomers;
//        private System.Windows.Forms.TabPage tabSuppliers;
//        private System.Windows.Forms.TabPage tabReports;
//        private System.Windows.Forms.TabPage tabPartners;
//        private System.Windows.Forms.TabPage tabUsers;
//        private System.Windows.Forms.TabPage tabSettings;

//        private Guna.UI2.WinForms.Guna2Panel pnlSalesCard;
//        private System.Windows.Forms.Label lblTodaySalesVal;
//        private System.Windows.Forms.Label lblTodaySales;
//        private System.Windows.Forms.Label lblTodaySalesTrend;
//        private Guna.UI2.WinForms.Guna2Panel pnlCashCard;
//        private System.Windows.Forms.Label lblCashBalanceVal;
//        private System.Windows.Forms.Label DFSSFS;
//        private System.Windows.Forms.Label lblCashBalanceTrend;
//        private Guna.UI2.WinForms.Guna2Panel pnlOrdersCard;
//        private System.Windows.Forms.Label lblTotalOrdersVal;
//        private System.Windows.Forms.Label ddfsfsf;
//        private System.Windows.Forms.Label lblTotalOrdersTrend;
//        private Guna.UI2.WinForms.Guna2Panel pnlUsersCard;
//        private System.Windows.Forms.Label lblProfitVal;
//        private System.Windows.Forms.Label DDSFSFSF;
//        private System.Windows.Forms.Label lblProfitTrend;
//        private Guna.UI2.WinForms.Guna2DataGridView dgvLowStock;
//        private Guna.UI2.WinForms.Guna2DataGridView dgvRecentInvoices;
//        private System.Windows.Forms.Label lblLowStock;
//        private System.Windows.Forms.Label lblLowStockSubtitle;
//        private System.Windows.Forms.Label lblInvoices;
//        private System.Windows.Forms.Label lblInvoicesSubtitle;
//        private System.Windows.Forms.Label lblDashboardTitle;
//        private Guna.UI2.WinForms.Guna2Button btnRefreshDashboard;
//        private Guna.UI2.WinForms.Guna2Button btnAddNewSale;
//        private Guna.UI2.WinForms.Guna2Button btnListSales;
//        private Guna.UI2.WinForms.Guna2Button btnListPurchases;
//        private Guna.UI2.WinForms.Guna2Button btnAddNewPurchase;
//        private Guna.UI2.WinForms.Guna2Button btnAddNewProduct;
//        private Guna.UI2.WinForms.Guna2Button btnListCategories;
//        private Guna.UI2.WinForms.Guna2Button btnListProducts;
//        private Guna.UI2.WinForms.Guna2Button btnAddNewCustomer;
//        private Guna.UI2.WinForms.Guna2Button btnListCustomers;
//        private Guna.UI2.WinForms.Guna2Button btnAddNewSupplier;
//        private Guna.UI2.WinForms.Guna2Button btnListSuppliers;
//        private Guna.UI2.WinForms.Guna2Button btnImportantReports;
//        private Guna.UI2.WinForms.Guna2Button btnCustomUsingAi;
//        private Guna.UI2.WinForms.Guna2Button btnWithdrawDeposit;
//        private Guna.UI2.WinForms.Guna2Button btnListPartners;
//        private Guna.UI2.WinForms.Guna2Button btnAddNewUser;
//        private Guna.UI2.WinForms.Guna2Button btnListUsers;
//        private Guna.UI2.WinForms.Guna2Button btnGeneralSettings;
//        private Guna.UI2.WinForms.Guna2Button btnBackupRestore;
//        private Guna.UI2.WinForms.Guna2Button btnCurrentUserInfo;
//        private Guna.UI2.WinForms.Guna2Button btnLogout;
//        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
//        private Guna.Charts.WinForms.GunaChart chartSales;
//        private Guna.UI2.WinForms.Guna2Panel pnlSalesOverview;
//        private Guna.UI2.WinForms.Guna2ComboBox cmbTimeFilter;
//        private Guna.Charts.WinForms.GunaAreaDataset gunaAreaDataset1;
//        private System.Windows.Forms.Label label2;
//        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceNo;
//        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceCustomer;
//        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceDate;
//        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceAmount;
//        private System.Windows.Forms.DataGridViewTextBoxColumn colLowStockProduct;
//        private System.Windows.Forms.DataGridViewTextBoxColumn colLowStockQty;
//        private System.Windows.Forms.DataGridViewTextBoxColumn colLowStockMinQty;

//        // New visual-only fields.
//        private System.Windows.Forms.Label lblDashboardSubtitle;
//        private System.Windows.Forms.Label lblSalesChartSubtitle;
//        private Guna.UI2.WinForms.Guna2Panel pnlRecentInvoices;
//        private Guna.UI2.WinForms.Guna2Panel pnlLowStock;
//        private Guna.UI2.WinForms.Guna2Button btnViewAllInvoices;
//        private Guna.UI2.WinForms.Guna2Button btnViewAllLowStock;
//        private Guna.UI2.WinForms.Guna2Panel pnlPurchaseCard;
//        private System.Windows.Forms.Label lblTodayPurchases;
//        private System.Windows.Forms.Label lblTodayPurchasesVal;
//        private System.Windows.Forms.Label lblTodayPurchasesTrend;
//        private Guna.UI2.WinForms.Guna2Panel pnlReceivablesCard;
//        private System.Windows.Forms.Label lblReceivables;
//        private System.Windows.Forms.Label lblReceivablesVal;
//        private System.Windows.Forms.Label lblReceivablesHint;
//        private Guna.UI2.WinForms.Guna2Panel pnlPayablesCard;
//        private System.Windows.Forms.Label lblPayables;
//        private System.Windows.Forms.Label lblPayablesVal;
//        private System.Windows.Forms.Label lblPayablesHint;
//        private Guna.UI2.WinForms.Guna2Panel pnlStockValueCard;
//        private System.Windows.Forms.Label lblStockValue;
//        private System.Windows.Forms.Label lblStockValueVal;
//        private System.Windows.Forms.Label lblStockValueHint;

//        private System.Windows.Forms.Label lblSalesTitle, lblSalesSubtitle;
//        private Guna.UI2.WinForms.Guna2Panel pnlSalesToday, pnlSalesInvoices, pnlSalesDebt, pnlSalesActions;
//        private System.Windows.Forms.Label lblSalesTodayCaption, lblSalesTodayValue, lblSalesInvoicesCaption, lblSalesInvoicesValue, lblSalesDebtCaption, lblSalesDebtValue, lblSalesActions, lblSalesActionsHint;

//        private System.Windows.Forms.Label lblPurchasesTitle, lblPurchasesSubtitle;
//        private Guna.UI2.WinForms.Guna2Panel pnlPurchasesToday, pnlPurchasesInvoices, pnlPurchasesDebt, pnlPurchasesActions;
//        private System.Windows.Forms.Label lblPurchasesTodayCaption, lblPurchasesTodayValue, lblPurchasesInvoicesCaption, lblPurchasesInvoicesValue, lblPurchasesDebtCaption, lblPurchasesDebtValue, lblPurchasesActions, lblPurchasesActionsHint;

//        private System.Windows.Forms.Label lblProductsTitle, lblProductsSubtitle;
//        private Guna.UI2.WinForms.Guna2Panel pnlProductsCount, pnlProductsLowStock, pnlProductsCategories, pnlProductsActions;
//        private System.Windows.Forms.Label lblProductsCountCaption, lblProductsCountValue, lblProductsLowStockCaption, lblProductsLowStockValue, lblProductsCategoriesCaption, lblProductsCategoriesValue, lblProductsActions, lblProductsActionsHint;

//        private System.Windows.Forms.Label lblCustomersTitle, lblCustomersSubtitle;
//        private Guna.UI2.WinForms.Guna2Panel pnlCustomersCount, pnlCustomersDebt, pnlCustomersActions;
//        private System.Windows.Forms.Label lblCustomersCountCaption, lblCustomersCountValue, lblCustomersDebtCaption, lblCustomersDebtValue, lblCustomersActions, lblCustomersActionsHint;

//        private System.Windows.Forms.Label lblSuppliersTitle, lblSuppliersSubtitle;
//        private Guna.UI2.WinForms.Guna2Panel pnlSuppliersCount, pnlSuppliersDebt, pnlSuppliersActions;
//        private System.Windows.Forms.Label lblSuppliersCountCaption, lblSuppliersCountValue, lblSuppliersDebtCaption, lblSuppliersDebtValue, lblSuppliersActions, lblSuppliersActionsHint;

//        private System.Windows.Forms.Label lblReportsTitle, lblReportsSubtitle;
//        private Guna.UI2.WinForms.Guna2Panel pnlReportsSales, pnlReportsStock, pnlReportsDebt, pnlReportsProfit;
//        private System.Windows.Forms.Label lblReportsSalesTitle, lblReportsSalesText, lblReportsStockTitle, lblReportsStockText, lblReportsDebtTitle, lblReportsDebtText, lblReportsProfitTitle, lblReportsProfitText;

//        private System.Windows.Forms.Label lblPartnersTitle, lblPartnersSubtitle;
//        private Guna.UI2.WinForms.Guna2Panel pnlPartnersBalance, pnlPartnersProfit, pnlPartnersTransactions, pnlPartnersActions;
//        private System.Windows.Forms.Label lblPartnersBalanceCaption, lblPartnersBalanceValue, lblPartnersProfitCaption, lblPartnersProfitValue, lblPartnersTransactionsCaption, lblPartnersTransactionsValue, lblPartnersActions, lblPartnersActionsHint;

//        private System.Windows.Forms.Label lblUsersTitle, lblUsersSubtitle;
//        private Guna.UI2.WinForms.Guna2Panel pnlUsersCount, pnlUsersSecurity, pnlUsersActions;
//        private System.Windows.Forms.Label lblUsersCountCaption, lblUsersCountValue, lblUsersSecurityCaption, lblUsersSecurityValue, lblUsersActions, lblUsersActionsHint;

//        private System.Windows.Forms.Label lblSettingsTitle, lblSettingsSubtitle;
//        private Guna.UI2.WinForms.Guna2Panel pnlSettingsInfo, pnlSettingsBackup, pnlSettingsAccount;
//        private System.Windows.Forms.Label lblSettingsInfoTitle, lblSettingsInfoText, lblSettingsBackupTitle, lblSettingsBackupText, lblSettingsAccountTitle, lblSettingsAccountText;
//    }
//}



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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.gunaAreaDataset1 = new Guna.Charts.WinForms.GunaAreaDataset();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.colLowStockMinQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLowStockQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLowStockProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoiceAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoiceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoiceCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnUsers = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomers = new Guna.UI2.WinForms.Guna2Button();
            this.btnTransaction = new Guna.UI2.WinForms.Guna2Button();
            this.btnReturn = new Guna.UI2.WinForms.Guna2Button();
            this.btnٍSales = new Guna.UI2.WinForms.Guna2Button();
            this.btnVehicles = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashBord = new Guna.UI2.WinForms.Guna2Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaAreaDataset1
            // 
            this.gunaAreaDataset1.BorderColor = System.Drawing.Color.Empty;
            this.gunaAreaDataset1.FillColor = System.Drawing.Color.Empty;
            this.gunaAreaDataset1.Label = "Area1";
            // 
            // colLowStockMinQty
            // 
            this.colLowStockMinQty.HeaderText = "حد التنبيه";
            this.colLowStockMinQty.MinimumWidth = 6;
            this.colLowStockMinQty.Name = "colLowStockMinQty";
            this.colLowStockMinQty.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colLowStockMinQty.Width = 129;
            // 
            // colLowStockQty
            // 
            this.colLowStockQty.HeaderText = "الكمية المتبقية";
            this.colLowStockQty.MinimumWidth = 6;
            this.colLowStockQty.Name = "colLowStockQty";
            this.colLowStockQty.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colLowStockQty.Width = 128;
            // 
            // colLowStockProduct
            // 
            this.colLowStockProduct.FillWeight = 150F;
            this.colLowStockProduct.HeaderText = "اسم المنتج";
            this.colLowStockProduct.MinimumWidth = 6;
            this.colLowStockProduct.Name = "colLowStockProduct";
            this.colLowStockProduct.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colLowStockProduct.Width = 193;
            // 
            // colInvoiceAmount
            // 
            this.colInvoiceAmount.HeaderText = "المبلغ";
            this.colInvoiceAmount.MinimumWidth = 6;
            this.colInvoiceAmount.Name = "colInvoiceAmount";
            this.colInvoiceAmount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colInvoiceAmount.Width = 119;
            // 
            // colInvoiceDate
            // 
            this.colInvoiceDate.FillWeight = 90F;
            this.colInvoiceDate.HeaderText = "التاريخ";
            this.colInvoiceDate.MinimumWidth = 6;
            this.colInvoiceDate.Name = "colInvoiceDate";
            this.colInvoiceDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colInvoiceDate.Width = 107;
            // 
            // colInvoiceCustomer
            // 
            this.colInvoiceCustomer.FillWeight = 130F;
            this.colInvoiceCustomer.HeaderText = "اسم الزبون";
            this.colInvoiceCustomer.MinimumWidth = 6;
            this.colInvoiceCustomer.Name = "colInvoiceCustomer";
            this.colInvoiceCustomer.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colInvoiceCustomer.Width = 155;
            // 
            // colInvoiceNo
            // 
            this.colInvoiceNo.FillWeight = 68F;
            this.colInvoiceNo.HeaderText = "رقم الفاتورة";
            this.colInvoiceNo.MinimumWidth = 6;
            this.colInvoiceNo.Name = "colInvoiceNo";
            this.colInvoiceNo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colInvoiceNo.Width = 81;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.guna2Button3);
            this.panel1.Controls.Add(this.guna2Button2);
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Controls.Add(this.btnVehicles);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnUsers);
            this.panel1.Controls.Add(this.btnCustomers);
            this.panel1.Controls.Add(this.btnTransaction);
            this.panel1.Controls.Add(this.btnReturn);
            this.panel1.Controls.Add(this.btnٍSales);
            this.panel1.Controls.Add(this.btnDashBord);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 850);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PosAndAccountantProject.Properties.Resources.MaherLogo1;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(215, 126);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.BorderRadius = 20;
            this.btnLogOut.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLogOut.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnLogOut.CheckedState.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.CheckedState.ForeColor = System.Drawing.Color.Maroon;
            this.btnLogOut.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.btnLogOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogOut.FillColor = System.Drawing.Color.Transparent;
            this.btnLogOut.FocusedColor = System.Drawing.Color.White;
            this.btnLogOut.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogOut.ImageSize = new System.Drawing.Size(40, 40);
            this.btnLogOut.Location = new System.Drawing.Point(7, 791);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.PressedColor = System.Drawing.Color.White;
            this.btnLogOut.Size = new System.Drawing.Size(208, 57);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnLogOut.UseTransparentBackground = true;
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.Transparent;
            this.btnUsers.BorderRadius = 20;
            this.btnUsers.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnUsers.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnUsers.CheckedState.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.CheckedState.ForeColor = System.Drawing.Color.Maroon;
            this.btnUsers.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnUsers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUsers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUsers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUsers.FillColor = System.Drawing.Color.Transparent;
            this.btnUsers.FocusedColor = System.Drawing.Color.White;
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnUsers.Image")));
            this.btnUsers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUsers.ImageSize = new System.Drawing.Size(40, 40);
            this.btnUsers.Location = new System.Drawing.Point(7, 545);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.PressedColor = System.Drawing.Color.White;
            this.btnUsers.Size = new System.Drawing.Size(208, 69);
            this.btnUsers.TabIndex = 6;
            this.btnUsers.Text = "المستخدمين";
            this.btnUsers.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnUsers.UseTransparentBackground = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.Transparent;
            this.btnCustomers.BorderRadius = 20;
            this.btnCustomers.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCustomers.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnCustomers.CheckedState.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.CheckedState.ForeColor = System.Drawing.Color.Maroon;
            this.btnCustomers.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnCustomers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomers.FillColor = System.Drawing.Color.Transparent;
            this.btnCustomers.FocusedColor = System.Drawing.Color.White;
            this.btnCustomers.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.btnCustomers.ForeColor = System.Drawing.Color.White;
            this.btnCustomers.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomers.Image")));
            this.btnCustomers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCustomers.ImageSize = new System.Drawing.Size(40, 40);
            this.btnCustomers.Location = new System.Drawing.Point(7, 411);
            this.btnCustomers.Margin = new System.Windows.Forms.Padding(2);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.PressedColor = System.Drawing.Color.White;
            this.btnCustomers.Size = new System.Drawing.Size(208, 69);
            this.btnCustomers.TabIndex = 5;
            this.btnCustomers.Text = "الزبائن";
            this.btnCustomers.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnCustomers.UseTransparentBackground = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnTransaction
            // 
            this.btnTransaction.BackColor = System.Drawing.Color.Transparent;
            this.btnTransaction.BorderRadius = 20;
            this.btnTransaction.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnTransaction.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnTransaction.CheckedState.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransaction.CheckedState.ForeColor = System.Drawing.Color.Maroon;
            this.btnTransaction.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnTransaction.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTransaction.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTransaction.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTransaction.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTransaction.FillColor = System.Drawing.Color.Transparent;
            this.btnTransaction.FocusedColor = System.Drawing.Color.White;
            this.btnTransaction.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.btnTransaction.ForeColor = System.Drawing.Color.White;
            this.btnTransaction.Image = ((System.Drawing.Image)(resources.GetObject("btnTransaction.Image")));
            this.btnTransaction.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTransaction.ImageSize = new System.Drawing.Size(40, 40);
            this.btnTransaction.Location = new System.Drawing.Point(7, 338);
            this.btnTransaction.Margin = new System.Windows.Forms.Padding(2);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.PressedColor = System.Drawing.Color.White;
            this.btnTransaction.Size = new System.Drawing.Size(208, 69);
            this.btnTransaction.TabIndex = 4;
            this.btnTransaction.Text = "المنتجات";
            this.btnTransaction.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnTransaction.UseTransparentBackground = true;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Transparent;
            this.btnReturn.BorderRadius = 20;
            this.btnReturn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnReturn.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnReturn.CheckedState.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.CheckedState.ForeColor = System.Drawing.Color.Maroon;
            this.btnReturn.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image8")));
            this.btnReturn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReturn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReturn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReturn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReturn.FillColor = System.Drawing.Color.Transparent;
            this.btnReturn.FocusedColor = System.Drawing.Color.White;
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.Image")));
            this.btnReturn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnReturn.ImageSize = new System.Drawing.Size(40, 40);
            this.btnReturn.Location = new System.Drawing.Point(7, 269);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.PressedColor = System.Drawing.Color.White;
            this.btnReturn.Size = new System.Drawing.Size(208, 69);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "المشتريات";
            this.btnReturn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnReturn.UseTransparentBackground = true;
            // 
            // btnٍSales
            // 
            this.btnٍSales.BackColor = System.Drawing.Color.Transparent;
            this.btnٍSales.BorderRadius = 20;
            this.btnٍSales.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnٍSales.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnٍSales.CheckedState.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnٍSales.CheckedState.ForeColor = System.Drawing.Color.Maroon;
            this.btnٍSales.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image9")));
            this.btnٍSales.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnٍSales.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnٍSales.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnٍSales.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnٍSales.FillColor = System.Drawing.Color.Transparent;
            this.btnٍSales.FocusedColor = System.Drawing.Color.White;
            this.btnٍSales.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.btnٍSales.ForeColor = System.Drawing.Color.White;
            this.btnٍSales.Image = ((System.Drawing.Image)(resources.GetObject("btnٍSales.Image")));
            this.btnٍSales.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnٍSales.ImageSize = new System.Drawing.Size(40, 40);
            this.btnٍSales.Location = new System.Drawing.Point(7, 200);
            this.btnٍSales.Margin = new System.Windows.Forms.Padding(2);
            this.btnٍSales.Name = "btnٍSales";
            this.btnٍSales.PressedColor = System.Drawing.Color.White;
            this.btnٍSales.Size = new System.Drawing.Size(208, 69);
            this.btnٍSales.TabIndex = 2;
            this.btnٍSales.Text = "المبيعات";
            this.btnٍSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnٍSales.UseTransparentBackground = true;
            this.btnٍSales.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // btnVehicles
            // 
            this.btnVehicles.BackColor = System.Drawing.Color.Transparent;
            this.btnVehicles.BorderRadius = 20;
            this.btnVehicles.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnVehicles.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnVehicles.CheckedState.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehicles.CheckedState.ForeColor = System.Drawing.Color.Maroon;
            this.btnVehicles.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnVehicles.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVehicles.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVehicles.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVehicles.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVehicles.FillColor = System.Drawing.Color.Transparent;
            this.btnVehicles.FocusedColor = System.Drawing.Color.White;
            this.btnVehicles.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.btnVehicles.ForeColor = System.Drawing.Color.White;
            this.btnVehicles.Image = ((System.Drawing.Image)(resources.GetObject("btnVehicles.Image")));
            this.btnVehicles.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnVehicles.ImageSize = new System.Drawing.Size(40, 40);
            this.btnVehicles.Location = new System.Drawing.Point(7, 484);
            this.btnVehicles.Margin = new System.Windows.Forms.Padding(2);
            this.btnVehicles.Name = "btnVehicles";
            this.btnVehicles.PressedColor = System.Drawing.Color.White;
            this.btnVehicles.Size = new System.Drawing.Size(208, 69);
            this.btnVehicles.TabIndex = 1;
            this.btnVehicles.Tag = " ";
            this.btnVehicles.Text = "الموردين";
            this.btnVehicles.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnVehicles.UseTransparentBackground = true;
            this.btnVehicles.Click += new System.EventHandler(this.btnVehicles_Click);
            // 
            // btnDashBord
            // 
            this.btnDashBord.BackColor = System.Drawing.Color.Transparent;
            this.btnDashBord.BorderRadius = 20;
            this.btnDashBord.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDashBord.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnDashBord.CheckedState.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashBord.CheckedState.ForeColor = System.Drawing.Color.Maroon;
            this.btnDashBord.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image10")));
            this.btnDashBord.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDashBord.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDashBord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDashBord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDashBord.FillColor = System.Drawing.Color.Transparent;
            this.btnDashBord.FocusedColor = System.Drawing.Color.White;
            this.btnDashBord.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashBord.ForeColor = System.Drawing.Color.White;
            this.btnDashBord.Image = ((System.Drawing.Image)(resources.GetObject("btnDashBord.Image")));
            this.btnDashBord.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashBord.ImageSize = new System.Drawing.Size(40, 40);
            this.btnDashBord.Location = new System.Drawing.Point(7, 131);
            this.btnDashBord.Margin = new System.Windows.Forms.Padding(2);
            this.btnDashBord.Name = "btnDashBord";
            this.btnDashBord.PressedColor = System.Drawing.Color.White;
            this.btnDashBord.Size = new System.Drawing.Size(208, 69);
            this.btnDashBord.TabIndex = 0;
            this.btnDashBord.Text = "Dash Bord";
            this.btnDashBord.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnDashBord.UseTransparentBackground = true;
            this.btnDashBord.CheckedChanged += new System.EventHandler(this.btnDashBord_CheckedChanged);
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(215, 0);
            this.panelContent.Margin = new System.Windows.Forms.Padding(2);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(969, 850);
            this.panelContent.TabIndex = 2;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 20;
            this.guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button1.CheckedState.FillColor = System.Drawing.Color.White;
            this.guna2Button1.CheckedState.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.CheckedState.ForeColor = System.Drawing.Color.Maroon;
            this.guna2Button1.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.FocusedColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button1.Location = new System.Drawing.Point(7, 618);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.White;
            this.guna2Button1.Size = new System.Drawing.Size(208, 69);
            this.guna2Button1.TabIndex = 9;
            this.guna2Button1.Text = "الشركاء";
            this.guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button1.UseTransparentBackground = true;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderRadius = 20;
            this.guna2Button2.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button2.CheckedState.FillColor = System.Drawing.Color.White;
            this.guna2Button2.CheckedState.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.CheckedState.ForeColor = System.Drawing.Color.Maroon;
            this.guna2Button2.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.FocusedColor = System.Drawing.Color.White;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button2.Image")));
            this.guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button2.Location = new System.Drawing.Point(2, 676);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.PressedColor = System.Drawing.Color.White;
            this.guna2Button2.Size = new System.Drawing.Size(208, 69);
            this.guna2Button2.TabIndex = 10;
            this.guna2Button2.Text = "التقارير";
            this.guna2Button2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button2.UseTransparentBackground = true;
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button3.BorderRadius = 20;
            this.guna2Button3.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button3.CheckedState.FillColor = System.Drawing.Color.White;
            this.guna2Button3.CheckedState.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.CheckedState.ForeColor = System.Drawing.Color.Maroon;
            this.guna2Button3.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button3.FocusedColor = System.Drawing.Color.White;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button3.Image")));
            this.guna2Button3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button3.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button3.Location = new System.Drawing.Point(5, 749);
            this.guna2Button3.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.PressedColor = System.Drawing.Color.White;
            this.guna2Button3.Size = new System.Drawing.Size(208, 38);
            this.guna2Button3.TabIndex = 11;
            this.guna2Button3.Text = "الاعدادات";
            this.guna2Button3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button3.UseTransparentBackground = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1184, 850);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لوحة تحكم نظام الماهر لنقاط البيع والمحاسبة";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.Charts.WinForms.GunaAreaDataset gunaAreaDataset1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLowStockMinQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLowStockQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLowStockProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceNo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Guna.UI2.WinForms.Guna2Button btnLogOut;
        private Guna.UI2.WinForms.Guna2Button btnUsers;
        private Guna.UI2.WinForms.Guna2Button btnCustomers;
        private Guna.UI2.WinForms.Guna2Button btnTransaction;
        private Guna.UI2.WinForms.Guna2Button btnReturn;
        private Guna.UI2.WinForms.Guna2Button btnٍSales;
        private Guna.UI2.WinForms.Guna2Button btnVehicles;
        private Guna.UI2.WinForms.Guna2Button btnDashBord;
        private System.Windows.Forms.Panel panelContent;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}


