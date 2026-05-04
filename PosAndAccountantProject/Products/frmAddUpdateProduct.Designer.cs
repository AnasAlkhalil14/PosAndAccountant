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
            this.pnlMain = new Guna.UI2.WinForms.Guna2Panel();
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
            this.lnkMostSold = new System.Windows.Forms.LinkLabel();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
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
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(889, 680);
            this.pnlMain.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitle.Location = new System.Drawing.Point(600, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(259, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "إضافة / تعديل منتج";
            // 
            // pbProductImage
            // 
            this.pbProductImage.BorderRadius = 15;
            this.pbProductImage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.pbProductImage.ImageRotate = 0F;
            this.pbProductImage.Location = new System.Drawing.Point(35, 90);
            this.pbProductImage.Name = "pbProductImage";
            this.pbProductImage.Size = new System.Drawing.Size(220, 220);
            this.pbProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProductImage.TabIndex = 1;
            this.pbProductImage.TabStop = false;
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.BorderRadius = 10;
            this.btnUploadImage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUploadImage.ForeColor = System.Drawing.Color.White;
            this.btnUploadImage.Location = new System.Drawing.Point(35, 320);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(220, 35);
            this.btnUploadImage.TabIndex = 2;
            this.btnUploadImage.Text = "تحميل صورة";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.BackColor = System.Drawing.Color.Transparent;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblProductName.Location = new System.Drawing.Point(745, 75);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(76, 20);
            this.lblProductName.TabIndex = 3;
            this.lblProductName.Text = "اسم المنتج";
            // 
            // txtProductName
            // 
            this.txtProductName.BorderRadius = 8;
            this.txtProductName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductName.DefaultText = "";
            this.txtProductName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProductName.Location = new System.Drawing.Point(300, 95);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.PlaceholderText = "";
            this.txtProductName.SelectedText = "";
            this.txtProductName.Size = new System.Drawing.Size(510, 40);
            this.txtProductName.TabIndex = 4;
            this.txtProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.BackColor = System.Drawing.Color.Transparent;
            this.lblBarcode.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblBarcode.Location = new System.Drawing.Point(495, 145);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(56, 20);
            this.lblBarcode.TabIndex = 5;
            this.lblBarcode.Text = "الباركود";
            // 
            // txtBarcode
            // 
            this.txtBarcode.BorderRadius = 8;
            this.txtBarcode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBarcode.DefaultText = "";
            this.txtBarcode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBarcode.Location = new System.Drawing.Point(300, 165);
            this.txtBarcode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.PlaceholderText = "";
            this.txtBarcode.SelectedText = "";
            this.txtBarcode.Size = new System.Drawing.Size(245, 40);
            this.txtBarcode.TabIndex = 6;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblCategory.Location = new System.Drawing.Point(755, 145);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(63, 20);
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
            this.cbCategory.Location = new System.Drawing.Point(565, 165);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(245, 36);
            this.cbCategory.TabIndex = 8;
            // 
            // lblPurchasePrice
            // 
            this.lblPurchasePrice.AutoSize = true;
            this.lblPurchasePrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPurchasePrice.Location = new System.Drawing.Point(390, 215);
            this.lblPurchasePrice.Name = "lblPurchasePrice";
            this.lblPurchasePrice.Size = new System.Drawing.Size(60, 16);
            this.lblPurchasePrice.TabIndex = 9;
            this.lblPurchasePrice.Text = "سعر الشراء";
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.BorderRadius = 8;
            this.txtPurchasePrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPurchasePrice.DefaultText = "";
            this.txtPurchasePrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPurchasePrice.Location = new System.Drawing.Point(300, 235);
            this.txtPurchasePrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.PlaceholderText = "";
            this.txtPurchasePrice.SelectedText = "";
            this.txtPurchasePrice.Size = new System.Drawing.Size(160, 40);
            this.txtPurchasePrice.TabIndex = 10;
            // 
            // lblSalePrice
            // 
            this.lblSalePrice.AutoSize = true;
            this.lblSalePrice.BackColor = System.Drawing.Color.Transparent;
            this.lblSalePrice.Location = new System.Drawing.Point(565, 215);
            this.lblSalePrice.Name = "lblSalePrice";
            this.lblSalePrice.Size = new System.Drawing.Size(53, 16);
            this.lblSalePrice.TabIndex = 11;
            this.lblSalePrice.Text = "سعر البيع";
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.BorderRadius = 8;
            this.txtSalePrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSalePrice.DefaultText = "";
            this.txtSalePrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSalePrice.Location = new System.Drawing.Point(475, 235);
            this.txtSalePrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.PlaceholderText = "";
            this.txtSalePrice.SelectedText = "";
            this.txtSalePrice.Size = new System.Drawing.Size(160, 40);
            this.txtSalePrice.TabIndex = 12;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantity.Location = new System.Drawing.Point(765, 215);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(36, 16);
            this.lblQuantity.TabIndex = 13;
            this.lblQuantity.Text = "الكمية";
            // 
            // txtQuantity
            // 
            this.txtQuantity.BorderRadius = 8;
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantity.DefaultText = "";
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQuantity.Location = new System.Drawing.Point(650, 235);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PlaceholderText = "";
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.Size = new System.Drawing.Size(160, 40);
            this.txtQuantity.TabIndex = 14;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Location = new System.Drawing.Point(760, 285);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(39, 16);
            this.lblDescription.TabIndex = 15;
            this.lblDescription.Text = "الوصف";
            // 
            // txtDescription
            // 
            this.txtDescription.BorderRadius = 8;
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.DefaultText = "";
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDescription.Location = new System.Drawing.Point(300, 305);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PlaceholderText = "";
            this.txtDescription.SelectedText = "";
            this.txtDescription.Size = new System.Drawing.Size(510, 100);
            this.txtDescription.TabIndex = 16;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatus.Location = new System.Drawing.Point(730, 430);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(121, 20);
            this.lblStatus.TabIndex = 17;
            this.lblStatus.Text = "حالة المنتج (نشط)";
            // 
            // tsStatus
            // 
            this.tsStatus.Checked = true;
            this.tsStatus.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.tsStatus.Location = new System.Drawing.Point(760, 455);
            this.tsStatus.Name = "tsStatus";
            this.tsStatus.Size = new System.Drawing.Size(50, 25);
            this.tsStatus.TabIndex = 18;
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 10;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(660, 580);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 45);
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
            this.btnCancel.Location = new System.Drawing.Point(490, 580);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 45);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "إلغاء";
            // 
            // lnkMostSold
            // 
            this.lnkMostSold.AutoSize = true;
            this.lnkMostSold.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lnkMostSold.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkMostSold.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lnkMostSold.Location = new System.Drawing.Point(522, 455);
            this.lnkMostSold.Name = "lnkMostSold";
            this.lnkMostSold.Size = new System.Drawing.Size(194, 23);
            this.lnkMostSold.TabIndex = 21;
            this.lnkMostSold.TabStop = true;
            this.lnkMostSold.Text = "اضافة صنف منتجات جديد";
            // 
            // frmAddUpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 680);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddUpdateProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة/تعديل منتج";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).EndInit();
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
    }
}