
namespace PosAndAccountantProject.Products
{
    partial class frmListProducts
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProducts = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmsProducts = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicateProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.viewPriceHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printBarcodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cbFilterBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtFilterValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddProduct = new Guna.UI2.WinForms.Guna2Button();
            this.pnlPreview = new Guna.UI2.WinForms.Guna2Panel();
            this.lblPreviewCategory = new System.Windows.Forms.Label();
            this.lblPreviewMinStock = new System.Windows.Forms.Label();
            this.lblPreviewStock = new System.Windows.Forms.Label();
            this.lblPreviewBarcode = new System.Windows.Forms.Label();
            this.lblPreviewPrice = new System.Windows.Forms.Label();
            this.lblPreviewName = new System.Windows.Forms.Label();
            this.pbProductPreview = new Guna.UI2.WinForms.Guna2PictureBox();
            this.cardTotal = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cardOutOfStock = new Guna.UI2.WinForms.Guna2Panel();
            this.lblOutOfStockCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.lnkMostSold = new System.Windows.Forms.LinkLabel();
            this.lnkMostProfit = new System.Windows.Forms.LinkLabel();
            this.lnkSlowMoving = new System.Windows.Forms.LinkLabel();
            this.lnkLowStock = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.cmsProducts.SuspendLayout();
            this.pnlPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductPreview)).BeginInit();
            this.cardTotal.SuspendLayout();
            this.cardOutOfStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProducts.ColumnHeadersHeight = 40;
            this.dgvProducts.ContextMenuStrip = this.cmsProducts;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProducts.Location = new System.Drawing.Point(265, 280);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 35;
            this.dgvProducts.Size = new System.Drawing.Size(1070, 520);
            this.dgvProducts.TabIndex = 0;
            this.dgvProducts.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvProducts.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvProducts.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvProducts.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvProducts.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvProducts.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvProducts.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProducts.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.dgvProducts.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProducts.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProducts.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvProducts.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProducts.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvProducts.ThemeStyle.ReadOnly = true;
            this.dgvProducts.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvProducts.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProducts.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProducts.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvProducts.ThemeStyle.RowsStyle.Height = 35;
            this.dgvProducts.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProducts.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // cmsProducts
            // 
            this.cmsProducts.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmsProducts.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsProducts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.duplicateProductToolStripMenuItem,
            this.toolStripSeparator1,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator2,
            this.viewPriceHistoryToolStripMenuItem,
            this.printBarcodeToolStripMenuItem});
            this.cmsProducts.Name = "cmsProducts";
            this.cmsProducts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmsProducts.Size = new System.Drawing.Size(205, 184);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(204, 28);
            this.showDetailsToolStripMenuItem.Text = "عرض التفاصيل";
            // 
            // duplicateProductToolStripMenuItem
            // 
            this.duplicateProductToolStripMenuItem.Name = "duplicateProductToolStripMenuItem";
            this.duplicateProductToolStripMenuItem.Size = new System.Drawing.Size(204, 28);
            this.duplicateProductToolStripMenuItem.Text = "تكرار المنتج (نسخ)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(201, 6);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(204, 28);
            this.editToolStripMenuItem.Text = "تعديل";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(204, 28);
            this.deleteToolStripMenuItem.Text = "حذف";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(201, 6);
            // 
            // viewPriceHistoryToolStripMenuItem
            // 
            this.viewPriceHistoryToolStripMenuItem.Name = "viewPriceHistoryToolStripMenuItem";
            this.viewPriceHistoryToolStripMenuItem.Size = new System.Drawing.Size(204, 28);
            this.viewPriceHistoryToolStripMenuItem.Text = "سجل الأسعار";
            // 
            // printBarcodeToolStripMenuItem
            // 
            this.printBarcodeToolStripMenuItem.Name = "printBarcodeToolStripMenuItem";
            this.printBarcodeToolStripMenuItem.Size = new System.Drawing.Size(204, 28);
            this.printBarcodeToolStripMenuItem.Text = "طباعة باركود";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.lblTitle.Location = new System.Drawing.Point(544, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(276, 60);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "إدارة المنتجات";
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.BackColor = System.Drawing.Color.Transparent;
            this.cbFilterBy.BorderRadius = 8;
            this.cbFilterBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.cbFilterBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.cbFilterBy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFilterBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFilterBy.ItemHeight = 30;
            this.cbFilterBy.Items.AddRange(new object[] {
            "لا شيء",
            "الاسم",
            "الباركود",
            "التصنيف"});
            this.cbFilterBy.Location = new System.Drawing.Point(370, 225);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(160, 36);
            this.cbFilterBy.StartIndex = 0;
            this.cbFilterBy.TabIndex = 2;
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.BorderRadius = 8;
            this.txtFilterValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterValue.DefaultText = "";
            this.txtFilterValue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.txtFilterValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFilterValue.ForeColor = System.Drawing.Color.Black;
            this.txtFilterValue.Location = new System.Drawing.Point(540, 225);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.PlaceholderText = "ابحث هنا...";
            this.txtFilterValue.SelectedText = "";
            this.txtFilterValue.Size = new System.Drawing.Size(250, 36);
            this.txtFilterValue.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(265, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "البحث عبر:";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BorderRadius = 8;
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1215, 815);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 45);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "إغلاق";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddProduct.BorderRadius = 8;
            this.btnAddProduct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Location = new System.Drawing.Point(1185, 225);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(150, 36);
            this.btnAddProduct.TabIndex = 6;
            this.btnAddProduct.Text = "إضافة منتج";
            // 
            // pnlPreview
            // 
            this.pnlPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlPreview.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlPreview.BorderRadius = 12;
            this.pnlPreview.BorderThickness = 1;
            this.pnlPreview.Controls.Add(this.lblPreviewCategory);
            this.pnlPreview.Controls.Add(this.lblPreviewMinStock);
            this.pnlPreview.Controls.Add(this.lblPreviewStock);
            this.pnlPreview.Controls.Add(this.lblPreviewBarcode);
            this.pnlPreview.Controls.Add(this.lblPreviewPrice);
            this.pnlPreview.Controls.Add(this.lblPreviewName);
            this.pnlPreview.Controls.Add(this.pbProductPreview);
            this.pnlPreview.FillColor = System.Drawing.Color.WhiteSmoke;
            this.pnlPreview.Location = new System.Drawing.Point(25, 280);
            this.pnlPreview.Name = "pnlPreview";
            this.pnlPreview.Size = new System.Drawing.Size(220, 520);
            this.pnlPreview.TabIndex = 7;
            // 
            // lblPreviewCategory
            // 
            this.lblPreviewCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblPreviewCategory.ForeColor = System.Drawing.Color.DimGray;
            this.lblPreviewCategory.Location = new System.Drawing.Point(10, 370);
            this.lblPreviewCategory.Name = "lblPreviewCategory";
            this.lblPreviewCategory.Size = new System.Drawing.Size(200, 25);
            this.lblPreviewCategory.TabIndex = 6;
            this.lblPreviewCategory.Text = "التصنيف: غير محدد";
            this.lblPreviewCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPreviewMinStock
            // 
            this.lblPreviewMinStock.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPreviewMinStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.lblPreviewMinStock.Location = new System.Drawing.Point(10, 335);
            this.lblPreviewMinStock.Name = "lblPreviewMinStock";
            this.lblPreviewMinStock.Size = new System.Drawing.Size(200, 25);
            this.lblPreviewMinStock.TabIndex = 5;
            this.lblPreviewMinStock.Text = "حد الطلب: 0";
            this.lblPreviewMinStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPreviewStock
            // 
            this.lblPreviewStock.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblPreviewStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lblPreviewStock.Location = new System.Drawing.Point(10, 305);
            this.lblPreviewStock.Name = "lblPreviewStock";
            this.lblPreviewStock.Size = new System.Drawing.Size(200, 30);
            this.lblPreviewStock.TabIndex = 4;
            this.lblPreviewStock.Text = "المخزون الحالي: 0";
            this.lblPreviewStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPreviewBarcode
            // 
            this.lblPreviewBarcode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPreviewBarcode.ForeColor = System.Drawing.Color.Gray;
            this.lblPreviewBarcode.Location = new System.Drawing.Point(10, 275);
            this.lblPreviewBarcode.Name = "lblPreviewBarcode";
            this.lblPreviewBarcode.Size = new System.Drawing.Size(200, 25);
            this.lblPreviewBarcode.TabIndex = 3;
            this.lblPreviewBarcode.Text = "Barcode: 000000";
            this.lblPreviewBarcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPreviewPrice
            // 
            this.lblPreviewPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPreviewPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblPreviewPrice.Location = new System.Drawing.Point(10, 240);
            this.lblPreviewPrice.Name = "lblPreviewPrice";
            this.lblPreviewPrice.Size = new System.Drawing.Size(200, 30);
            this.lblPreviewPrice.TabIndex = 2;
            this.lblPreviewPrice.Text = "0.00 ل.س";
            this.lblPreviewPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPreviewName
            // 
            this.lblPreviewName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblPreviewName.Location = new System.Drawing.Point(10, 200);
            this.lblPreviewName.Name = "lblPreviewName";
            this.lblPreviewName.Size = new System.Drawing.Size(200, 40);
            this.lblPreviewName.TabIndex = 1;
            this.lblPreviewName.Text = "اسم المنتج";
            this.lblPreviewName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbProductPreview
            // 
            this.pbProductPreview.ImageRotate = 0F;
            this.pbProductPreview.Location = new System.Drawing.Point(20, 20);
            this.pbProductPreview.Name = "pbProductPreview";
            this.pbProductPreview.Size = new System.Drawing.Size(180, 170);
            this.pbProductPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProductPreview.TabIndex = 0;
            this.pbProductPreview.TabStop = false;
            // 
            // cardTotal
            // 
            this.cardTotal.BorderRadius = 12;
            this.cardTotal.Controls.Add(this.lblTotalCount);
            this.cardTotal.Controls.Add(this.label3);
            this.cardTotal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.cardTotal.Location = new System.Drawing.Point(25, 100);
            this.cardTotal.Name = "cardTotal";
            this.cardTotal.Size = new System.Drawing.Size(180, 80);
            this.cardTotal.TabIndex = 8;
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalCount.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotalCount.ForeColor = System.Drawing.Color.White;
            this.lblTotalCount.Location = new System.Drawing.Point(15, 30);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(28, 37);
            this.lblTotalCount.TabIndex = 1;
            this.lblTotalCount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "إجمالي المواد";
            // 
            // cardOutOfStock
            // 
            this.cardOutOfStock.BorderRadius = 12;
            this.cardOutOfStock.Controls.Add(this.lblOutOfStockCount);
            this.cardOutOfStock.Controls.Add(this.label5);
            this.cardOutOfStock.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.cardOutOfStock.Location = new System.Drawing.Point(220, 100);
            this.cardOutOfStock.Name = "cardOutOfStock";
            this.cardOutOfStock.Size = new System.Drawing.Size(180, 80);
            this.cardOutOfStock.TabIndex = 9;
            // 
            // lblOutOfStockCount
            // 
            this.lblOutOfStockCount.AutoSize = true;
            this.lblOutOfStockCount.BackColor = System.Drawing.Color.Transparent;
            this.lblOutOfStockCount.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblOutOfStockCount.ForeColor = System.Drawing.Color.White;
            this.lblOutOfStockCount.Location = new System.Drawing.Point(15, 30);
            this.lblOutOfStockCount.Name = "lblOutOfStockCount";
            this.lblOutOfStockCount.Size = new System.Drawing.Size(28, 37);
            this.lblOutOfStockCount.TabIndex = 1;
            this.lblOutOfStockCount.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "نفذت الكمية";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.Location = new System.Drawing.Point(25, 200);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1302, 10);
            this.guna2Separator1.TabIndex = 10;
            // 
            // lnkMostSold
            // 
            this.lnkMostSold.AutoSize = true;
            this.lnkMostSold.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lnkMostSold.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkMostSold.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lnkMostSold.Location = new System.Drawing.Point(440, 145);
            this.lnkMostSold.Name = "lnkMostSold";
            this.lnkMostSold.Size = new System.Drawing.Size(101, 23);
            this.lnkMostSold.TabIndex = 11;
            this.lnkMostSold.TabStop = true;
            this.lnkMostSold.Text = "الأكثر مبيعاً ↑";
            // 
            // lnkMostProfit
            // 
            this.lnkMostProfit.AutoSize = true;
            this.lnkMostProfit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lnkMostProfit.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkMostProfit.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lnkMostProfit.Location = new System.Drawing.Point(565, 145);
            this.lnkMostProfit.Name = "lnkMostProfit";
            this.lnkMostProfit.Size = new System.Drawing.Size(94, 23);
            this.lnkMostProfit.TabIndex = 12;
            this.lnkMostProfit.TabStop = true;
            this.lnkMostProfit.Text = "الأكثر ربحاً $";
            // 
            // lnkSlowMoving
            // 
            this.lnkSlowMoving.AutoSize = true;
            this.lnkSlowMoving.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lnkSlowMoving.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkSlowMoving.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lnkSlowMoving.Location = new System.Drawing.Point(690, 145);
            this.lnkSlowMoving.Name = "lnkSlowMoving";
            this.lnkSlowMoving.Size = new System.Drawing.Size(98, 23);
            this.lnkSlowMoving.TabIndex = 13;
            this.lnkSlowMoving.TabStop = true;
            this.lnkSlowMoving.Text = "الأقل مبيعاً ↓";
            // 
            // lnkLowStock
            // 
            this.lnkLowStock.AutoSize = true;
            this.lnkLowStock.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lnkLowStock.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkLowStock.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.lnkLowStock.Location = new System.Drawing.Point(825, 145);
            this.lnkLowStock.Name = "lnkLowStock";
            this.lnkLowStock.Size = new System.Drawing.Size(134, 23);
            this.lnkLowStock.TabIndex = 14;
            this.lnkLowStock.TabStop = true;
            this.lnkLowStock.Text = "تحت حد الطلب !!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(440, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "تقارير سريعة :";
            // 
            // frmListProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1355, 880);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lnkLowStock);
            this.Controls.Add(this.lnkSlowMoving);
            this.Controls.Add(this.lnkMostProfit);
            this.Controls.Add(this.lnkMostSold);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.cardOutOfStock);
            this.Controls.Add(this.cardTotal);
            this.Controls.Add(this.pnlPreview);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmListProducts";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.cmsProducts.ResumeLayout(false);
            this.pnlPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbProductPreview)).EndInit();
            this.cardTotal.ResumeLayout(false);
            this.cardTotal.PerformLayout();
            this.cardOutOfStock.ResumeLayout(false);
            this.cardOutOfStock.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvProducts;
        private System.Windows.Forms.ContextMenuStrip cmsProducts;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duplicateProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem viewPriceHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printBarcodeToolStripMenuItem;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterBy;
        private Guna.UI2.WinForms.Guna2TextBox txtFilterValue;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnAddProduct;
        private Guna.UI2.WinForms.Guna2Panel pnlPreview;
        private Guna.UI2.WinForms.Guna2PictureBox pbProductPreview;
        private System.Windows.Forms.Label lblPreviewPrice;
        private System.Windows.Forms.Label lblPreviewName;
        private Guna.UI2.WinForms.Guna2Panel cardTotal;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel cardOutOfStock;
        private System.Windows.Forms.Label lblOutOfStockCount;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label lblPreviewCategory;
        private System.Windows.Forms.Label lblPreviewMinStock;
        private System.Windows.Forms.Label lblPreviewStock;
        private System.Windows.Forms.Label lblPreviewBarcode;
        private System.Windows.Forms.LinkLabel lnkMostSold;
        private System.Windows.Forms.LinkLabel lnkMostProfit;
        private System.Windows.Forms.LinkLabel lnkSlowMoving;
        private System.Windows.Forms.LinkLabel lnkLowStock;
        private System.Windows.Forms.Label label2;
    }
}



