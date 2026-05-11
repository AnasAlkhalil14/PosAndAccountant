namespace PosAndAccountantProject.Products
{
    partial class frmAddUpdateProduct
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
            this.pnlMain = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMinimamQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUnitOfSale = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnRemoveImage = new Guna.UI2.WinForms.Guna2Button();
            this.lblProductID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lnkMostSold = new System.Windows.Forms.LinkLabel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbProductImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnUploadImage = new Guna.UI2.WinForms.Guna2Button();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.txtBarcode = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cbCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblPurchasePrice = new System.Windows.Forms.Label();
            this.txtPurchasePrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSalePrice = new System.Windows.Forms.Label();
            this.txtSalePrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tsStatus = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.txtMinimamQuantity);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.txtUnitOfSale);
            this.pnlMain.Controls.Add(this.btnRemoveImage);
            this.pnlMain.Controls.Add(this.lblProductID);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.lnkMostSold);
            this.pnlMain.Controls.Add(this.lblTitle);
            this.pnlMain.Controls.Add(this.pbProductImage);
            this.pnlMain.Controls.Add(this.btnUploadImage);
            this.pnlMain.Controls.Add(this.lblProductName);
            this.pnlMain.Controls.Add(this.txtProductName);
            this.pnlMain.Controls.Add(this.lblBarcode);
            this.pnlMain.Controls.Add(this.txtBarcode);
            this.pnlMain.Controls.Add(this.lblCategory);
            this.pnlMain.Controls.Add(this.cbCategory);
            this.pnlMain.Controls.Add(this.lblPurchasePrice);
            this.pnlMain.Controls.Add(this.txtPurchasePrice);
            this.pnlMain.Controls.Add(this.lblSalePrice);
            this.pnlMain.Controls.Add(this.txtSalePrice);
            this.pnlMain.Controls.Add(this.lblQuantity);
            this.pnlMain.Controls.Add(this.txtQuantity);
            this.pnlMain.Controls.Add(this.lblDescription);
            this.pnlMain.Controls.Add(this.txtDescription);
            this.pnlMain.Controls.Add(this.lblStatus);
            this.pnlMain.Controls.Add(this.tsStatus);
            this.pnlMain.Controls.Add(this.btnSave);
            this.pnlMain.Controls.Add(this.btnCancel);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.FillColor = System.Drawing.Color.White;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(667, 611);
            this.pnlMain.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(510, 289);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "الحد الأدنى من الكمية";
            // 
            // txtMinimamQuantity
            // 
            this.txtMinimamQuantity.BorderRadius = 8;
            this.txtMinimamQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMinimamQuantity.DefaultText = "";
            this.txtMinimamQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMinimamQuantity.Location = new System.Drawing.Point(485, 307);
            this.txtMinimamQuantity.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMinimamQuantity.Name = "txtMinimamQuantity";
            this.txtMinimamQuantity.PlaceholderText = "";
            this.txtMinimamQuantity.SelectedText = "";
            this.txtMinimamQuantity.Size = new System.Drawing.Size(120, 32);
            this.txtMinimamQuantity.TabIndex = 28;
            this.txtMinimamQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress_JustNumbers);
            this.txtMinimamQuantity.Validating += new System.ComponentModel.CancelEventHandler(this.txx_Validating_NotEmpty);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(310, 289);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "واحدة البيع (البيع بالقطعة كمثال)";
            // 
            // txtUnitOfSale
            // 
            this.txtUnitOfSale.BorderRadius = 8;
            this.txtUnitOfSale.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUnitOfSale.DefaultText = "";
            this.txtUnitOfSale.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUnitOfSale.Location = new System.Drawing.Point(229, 307);
            this.txtUnitOfSale.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtUnitOfSale.Name = "txtUnitOfSale";
            this.txtUnitOfSale.PlaceholderText = "";
            this.txtUnitOfSale.SelectedText = "";
            this.txtUnitOfSale.Size = new System.Drawing.Size(246, 32);
            this.txtUnitOfSale.TabIndex = 26;
            this.txtUnitOfSale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnRemoveImage
            // 
            this.btnRemoveImage.BorderRadius = 10;
            this.btnRemoveImage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRemoveImage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveImage.ForeColor = System.Drawing.Color.White;
            this.btnRemoveImage.Location = new System.Drawing.Point(26, 292);
            this.btnRemoveImage.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveImage.Name = "btnRemoveImage";
            this.btnRemoveImage.Size = new System.Drawing.Size(165, 28);
            this.btnRemoveImage.TabIndex = 24;
            this.btnRemoveImage.Text = "حذف";
            this.btnRemoveImage.Click += new System.EventHandler(this.btnRemoveImage_Click);
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.BackColor = System.Drawing.Color.Transparent;
            this.lblProductID.Font = new System.Drawing.Font("Segoe Fluent Icons", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProductID.Location = new System.Drawing.Point(481, 67);
            this.lblProductID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblProductID.Size = new System.Drawing.Size(47, 21);
            this.lblProductID.TabIndex = 23;
            this.lblProductID.Text = "[???]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(561, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "معرف المنتج:";
            // 
            // lnkMostSold
            // 
            this.lnkMostSold.AutoSize = true;
            this.lnkMostSold.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lnkMostSold.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkMostSold.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lnkMostSold.Location = new System.Drawing.Point(389, 481);
            this.lnkMostSold.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkMostSold.Name = "lnkMostSold";
            this.lnkMostSold.Size = new System.Drawing.Size(160, 19);
            this.lnkMostSold.TabIndex = 21;
            this.lnkMostSold.TabStop = true;
            this.lnkMostSold.Text = "اضافة صنف منتجات جديد";
            this.lnkMostSold.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkMostSold_LinkClicked);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitle.Location = new System.Drawing.Point(450, 16);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(207, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "إضافة / تعديل منتج";
            // 
            // pbProductImage
            // 
            this.pbProductImage.BorderRadius = 15;
            this.pbProductImage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.pbProductImage.Image = global::PosAndAccountantProject.Properties.Resources.default_product;
            this.pbProductImage.ImageRotate = 0F;
            this.pbProductImage.Location = new System.Drawing.Point(26, 73);
            this.pbProductImage.Margin = new System.Windows.Forms.Padding(2);
            this.pbProductImage.Name = "pbProductImage";
            this.pbProductImage.Size = new System.Drawing.Size(165, 179);
            this.pbProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProductImage.TabIndex = 1;
            this.pbProductImage.TabStop = false;
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.BorderRadius = 10;
            this.btnUploadImage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImage.ForeColor = System.Drawing.Color.White;
            this.btnUploadImage.Location = new System.Drawing.Point(26, 260);
            this.btnUploadImage.Margin = new System.Windows.Forms.Padding(2);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(165, 28);
            this.btnUploadImage.TabIndex = 2;
            this.btnUploadImage.Text = "تحميل صورة";
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.BackColor = System.Drawing.Color.Transparent;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblProductName.Location = new System.Drawing.Point(561, 110);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(59, 15);
            this.lblProductName.TabIndex = 3;
            this.lblProductName.Text = "اسم المنتج";
            // 
            // txtProductName
            // 
            this.txtProductName.BorderRadius = 8;
            this.txtProductName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductName.DefaultText = "";
            this.txtProductName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProductName.Location = new System.Drawing.Point(229, 128);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.PlaceholderText = "";
            this.txtProductName.SelectedText = "";
            this.txtProductName.Size = new System.Drawing.Size(382, 32);
            this.txtProductName.TabIndex = 4;
            this.txtProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtProductName.Validating += new System.ComponentModel.CancelEventHandler(this.txx_Validating_NotEmpty);
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.BackColor = System.Drawing.Color.Transparent;
            this.lblBarcode.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblBarcode.Location = new System.Drawing.Point(373, 167);
            this.lblBarcode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(43, 15);
            this.lblBarcode.TabIndex = 5;
            this.lblBarcode.Text = "الباركود";
            // 
            // txtBarcode
            // 
            this.txtBarcode.BorderRadius = 8;
            this.txtBarcode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBarcode.DefaultText = "";
            this.txtBarcode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBarcode.Location = new System.Drawing.Point(227, 183);
            this.txtBarcode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.PlaceholderText = "";
            this.txtBarcode.SelectedText = "";
            this.txtBarcode.Size = new System.Drawing.Size(184, 32);
            this.txtBarcode.TabIndex = 6;
            this.txtBarcode.Validating += new System.ComponentModel.CancelEventHandler(this.txx_Validating_NotEmpty);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblCategory.Location = new System.Drawing.Point(568, 167);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(50, 15);
            this.lblCategory.TabIndex = 7;
            this.lblCategory.Text = "التصنيف";
            // 
            // cbCategory
            // 
            this.cbCategory.BackColor = System.Drawing.Color.Transparent;
            this.cbCategory.BorderRadius = 8;
            this.cbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FocusedColor = System.Drawing.Color.Empty;
            this.cbCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbCategory.ItemHeight = 30;
            this.cbCategory.Location = new System.Drawing.Point(426, 183);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(2);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(185, 36);
            this.cbCategory.TabIndex = 8;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // lblPurchasePrice
            // 
            this.lblPurchasePrice.AutoSize = true;
            this.lblPurchasePrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPurchasePrice.Location = new System.Drawing.Point(294, 224);
            this.lblPurchasePrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPurchasePrice.Name = "lblPurchasePrice";
            this.lblPurchasePrice.Size = new System.Drawing.Size(59, 13);
            this.lblPurchasePrice.TabIndex = 9;
            this.lblPurchasePrice.Text = "سعر الشراء";
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.BorderRadius = 8;
            this.txtPurchasePrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPurchasePrice.DefaultText = "";
            this.txtPurchasePrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPurchasePrice.Location = new System.Drawing.Point(227, 240);
            this.txtPurchasePrice.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.PlaceholderText = "";
            this.txtPurchasePrice.SelectedText = "";
            this.txtPurchasePrice.Size = new System.Drawing.Size(120, 32);
            this.txtPurchasePrice.TabIndex = 10;
            this.txtPurchasePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress_JustNumbers);
            this.txtPurchasePrice.Validating += new System.ComponentModel.CancelEventHandler(this.txx_Validating_NotEmpty);
            // 
            // lblSalePrice
            // 
            this.lblSalePrice.AutoSize = true;
            this.lblSalePrice.BackColor = System.Drawing.Color.Transparent;
            this.lblSalePrice.Location = new System.Drawing.Point(426, 224);
            this.lblSalePrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSalePrice.Name = "lblSalePrice";
            this.lblSalePrice.Size = new System.Drawing.Size(51, 13);
            this.lblSalePrice.TabIndex = 11;
            this.lblSalePrice.Text = "سعر البيع";
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.BorderRadius = 8;
            this.txtSalePrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSalePrice.DefaultText = "";
            this.txtSalePrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSalePrice.Location = new System.Drawing.Point(358, 240);
            this.txtSalePrice.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.PlaceholderText = "";
            this.txtSalePrice.SelectedText = "";
            this.txtSalePrice.Size = new System.Drawing.Size(120, 32);
            this.txtSalePrice.TabIndex = 12;
            this.txtSalePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress_JustNumbers);
            this.txtSalePrice.Validating += new System.ComponentModel.CancelEventHandler(this.txx_Validating_NotEmpty);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantity.Location = new System.Drawing.Point(576, 224);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(34, 13);
            this.lblQuantity.TabIndex = 13;
            this.lblQuantity.Text = "الكمية";
            // 
            // txtQuantity
            // 
            this.txtQuantity.BorderRadius = 8;
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantity.DefaultText = "";
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQuantity.Location = new System.Drawing.Point(490, 240);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PlaceholderText = "";
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.Size = new System.Drawing.Size(120, 32);
            this.txtQuantity.TabIndex = 14;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress_JustNumbers);
            this.txtQuantity.Validating += new System.ComponentModel.CancelEventHandler(this.txx_Validating_NotEmpty);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Location = new System.Drawing.Point(567, 343);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(37, 13);
            this.lblDescription.TabIndex = 15;
            this.lblDescription.Text = "الوصف";
            // 
            // txtDescription
            // 
            this.txtDescription.BorderRadius = 8;
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.DefaultText = "";
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDescription.Location = new System.Drawing.Point(222, 359);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PlaceholderText = "";
            this.txtDescription.SelectedText = "";
            this.txtDescription.Size = new System.Drawing.Size(382, 81);
            this.txtDescription.TabIndex = 16;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatus.Location = new System.Drawing.Point(545, 460);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(100, 15);
            this.lblStatus.TabIndex = 17;
            this.lblStatus.Text = "حالة المنتج (نشط?)";
            // 
            // tsStatus
            // 
            this.tsStatus.Checked = true;
            this.tsStatus.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.tsStatus.Location = new System.Drawing.Point(567, 481);
            this.tsStatus.Margin = new System.Windows.Forms.Padding(2);
            this.tsStatus.Name = "tsStatus";
            this.tsStatus.Size = new System.Drawing.Size(38, 20);
            this.tsStatus.TabIndex = 18;
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 10;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(490, 533);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 37);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "حفظ البيانات";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.BorderRadius = 10;
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(363, 533);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 37);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "إلغاء";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddUpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 611);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmAddUpdateProduct";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة/تعديل منتج";
            this.Load += new System.EventHandler(this.frmAddUpdateProduct_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlMain;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2PictureBox pbProductImage;
        private Guna.UI2.WinForms.Guna2Button btnUploadImage;
        private System.Windows.Forms.Label lblProductName;
        private Guna.UI2.WinForms.Guna2TextBox txtProductName;
        private System.Windows.Forms.Label lblBarcode;
        private Guna.UI2.WinForms.Guna2TextBox txtBarcode;
        private System.Windows.Forms.Label lblCategory;
        private Guna.UI2.WinForms.Guna2ComboBox cbCategory;
        private System.Windows.Forms.Label lblPurchasePrice;
        private Guna.UI2.WinForms.Guna2TextBox txtPurchasePrice;
        private System.Windows.Forms.Label lblSalePrice;
        private Guna.UI2.WinForms.Guna2TextBox txtSalePrice;
        private System.Windows.Forms.Label lblQuantity;
        private Guna.UI2.WinForms.Guna2TextBox txtQuantity;
        private System.Windows.Forms.Label lblDescription;
        private Guna.UI2.WinForms.Guna2TextBox txtDescription;
        private System.Windows.Forms.Label lblStatus;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tsStatus;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private System.Windows.Forms.LinkLabel lnkMostSold;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnRemoveImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtUnitOfSale;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtMinimamQuantity;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}