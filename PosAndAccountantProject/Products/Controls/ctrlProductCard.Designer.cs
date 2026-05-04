namespace PosAndAccountantProject.Products.Controls
{
    partial class ctrlProductCard
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

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.gbMain = new Guna.UI2.WinForms.Guna2GroupBox();
            this.statusBadge = new Guna.UI2.WinForms.Guna2Chip();
            this.llEditInfo = new System.Windows.Forms.LinkLabel();
            this.sep1 = new Guna.UI2.WinForms.Guna2Separator();
            this.lblDataStock = new System.Windows.Forms.Label();
            this.lblDataCategory = new System.Windows.Forms.Label();
            this.lblDataBarcode = new System.Windows.Forms.Label();
            this.pnlPrices = new Guna.UI2.WinForms.Guna2Panel();
            this.lblPurchasePrice = new System.Windows.Forms.Label();
            this.lblSalePrice = new System.Windows.Forms.Label();
            this.lblProfitMargin = new System.Windows.Forms.Label();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.lblCategoryID = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.pbProductImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.gbMain.SuspendLayout();
            this.pnlPrices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // gbMain
            // 
            this.gbMain.BorderRadius = 15;
            this.gbMain.Controls.Add(this.statusBadge);
            this.gbMain.Controls.Add(this.llEditInfo);
            this.gbMain.Controls.Add(this.sep1);
            this.gbMain.Controls.Add(this.lblDataStock);
            this.gbMain.Controls.Add(this.lblDataCategory);
            this.gbMain.Controls.Add(this.lblDataBarcode);
            this.gbMain.Controls.Add(this.pnlPrices);
            this.gbMain.Controls.Add(this.lblBarcode);
            this.gbMain.Controls.Add(this.lblCategoryID);
            this.gbMain.Controls.Add(this.lblProductName);
            this.gbMain.Controls.Add(this.pbProductImage);
            this.gbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMain.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.gbMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gbMain.Location = new System.Drawing.Point(0, 0);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(700, 475);
            this.gbMain.TabIndex = 0;
            this.gbMain.Text = "تفاصيل المنتج";
            this.gbMain.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // statusBadge
            // 
            this.statusBadge.AutoRoundedCorners = true;
            this.statusBadge.BackColor = System.Drawing.Color.Transparent;
            this.statusBadge.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(201)))));
            this.statusBadge.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.statusBadge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.statusBadge.Location = new System.Drawing.Point(25, 20);
            this.statusBadge.Name = "statusBadge";
            this.statusBadge.Size = new System.Drawing.Size(100, 25);
            this.statusBadge.TabIndex = 0;
            this.statusBadge.Text = "نشط";
            // 
            // llEditInfo
            // 
            this.llEditInfo.AutoSize = true;
            this.llEditInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.llEditInfo.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.llEditInfo.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.llEditInfo.Location = new System.Drawing.Point(225, 110);
            this.llEditInfo.Name = "llEditInfo";
            this.llEditInfo.Size = new System.Drawing.Size(132, 23);
            this.llEditInfo.TabIndex = 1;
            this.llEditInfo.TabStop = true;
            this.llEditInfo.Text = "تعديل المعلومات";
            // 
            // sep1
            // 
            this.sep1.Location = new System.Drawing.Point(220, 280);
            this.sep1.Name = "sep1";
            this.sep1.Size = new System.Drawing.Size(450, 10);
            this.sep1.TabIndex = 2;
            // 
            // lblDataStock
            // 
            this.lblDataStock.AutoSize = true;
            this.lblDataStock.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblDataStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.lblDataStock.Location = new System.Drawing.Point(516, 249);
            this.lblDataStock.Name = "lblDataStock";
            this.lblDataStock.Size = new System.Drawing.Size(161, 28);
            this.lblDataStock.TabIndex = 3;
            this.lblDataStock.Text = "المخزون المتوفر: 0";
            // 
            // lblDataCategory
            // 
            this.lblDataCategory.AutoSize = true;
            this.lblDataCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDataCategory.Location = new System.Drawing.Point(400, 200);
            this.lblDataCategory.Name = "lblDataCategory";
            this.lblDataCategory.Size = new System.Drawing.Size(91, 23);
            this.lblDataCategory.TabIndex = 4;
            this.lblDataCategory.Text = "Electronics";
            // 
            // lblDataBarcode
            // 
            this.lblDataBarcode.AutoSize = true;
            this.lblDataBarcode.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDataBarcode.Location = new System.Drawing.Point(400, 160);
            this.lblDataBarcode.Name = "lblDataBarcode";
            this.lblDataBarcode.Size = new System.Drawing.Size(82, 23);
            this.lblDataBarcode.TabIndex = 5;
            this.lblDataBarcode.Text = "00000000";
            // 
            // pnlPrices
            // 
            this.pnlPrices.BorderRadius = 15;
            this.pnlPrices.Controls.Add(this.lblPurchasePrice);
            this.pnlPrices.Controls.Add(this.lblSalePrice);
            this.pnlPrices.Controls.Add(this.lblProfitMargin);
            this.pnlPrices.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.pnlPrices.Location = new System.Drawing.Point(25, 310);
            this.pnlPrices.Name = "pnlPrices";
            this.pnlPrices.Size = new System.Drawing.Size(645, 130);
            this.pnlPrices.TabIndex = 6;
            // 
            // lblPurchasePrice
            // 
            this.lblPurchasePrice.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lblPurchasePrice.Location = new System.Drawing.Point(430, 20);
            this.lblPurchasePrice.Name = "lblPurchasePrice";
            this.lblPurchasePrice.Size = new System.Drawing.Size(200, 30);
            this.lblPurchasePrice.TabIndex = 0;
            this.lblPurchasePrice.Text = "سعر التكلفة: 0.00$";
            this.lblPurchasePrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSalePrice
            // 
            this.lblSalePrice.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold);
            this.lblSalePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.lblSalePrice.Location = new System.Drawing.Point(430, 60);
            this.lblSalePrice.Name = "lblSalePrice";
            this.lblSalePrice.Size = new System.Drawing.Size(200, 40);
            this.lblSalePrice.TabIndex = 1;
            this.lblSalePrice.Text = "0.00$";
            this.lblSalePrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProfitMargin
            // 
            this.lblProfitMargin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblProfitMargin.ForeColor = System.Drawing.Color.Gray;
            this.lblProfitMargin.Location = new System.Drawing.Point(37, 60);
            this.lblProfitMargin.Name = "lblProfitMargin";
            this.lblProfitMargin.Size = new System.Drawing.Size(200, 40);
            this.lblProfitMargin.TabIndex = 2;
            this.lblProfitMargin.Text = "صافي الربح المتوقع: 0.00$";
            this.lblProfitMargin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBarcode.Location = new System.Drawing.Point(600, 160);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(68, 23);
            this.lblBarcode.TabIndex = 7;
            this.lblBarcode.Text = "الباركود:";
            // 
            // lblCategoryID
            // 
            this.lblCategoryID.AutoSize = true;
            this.lblCategoryID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCategoryID.Location = new System.Drawing.Point(600, 200);
            this.lblCategoryID.Name = "lblCategoryID";
            this.lblCategoryID.Size = new System.Drawing.Size(77, 23);
            this.lblCategoryID.TabIndex = 8;
            this.lblCategoryID.Text = "التصنيف:";
            // 
            // lblProductName
            // 
            this.lblProductName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold);
            this.lblProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblProductName.Location = new System.Drawing.Point(220, 65);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(450, 45);
            this.lblProductName.TabIndex = 9;
            this.lblProductName.Text = "[Product Name]";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbProductImage
            // 
            this.pbProductImage.BackColor = System.Drawing.Color.Transparent;
            this.pbProductImage.BorderRadius = 12;
            this.pbProductImage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.pbProductImage.ImageRotate = 0F;
            this.pbProductImage.Location = new System.Drawing.Point(25, 65);
            this.pbProductImage.Name = "pbProductImage";
            this.pbProductImage.Size = new System.Drawing.Size(180, 180);
            this.pbProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProductImage.TabIndex = 10;
            this.pbProductImage.TabStop = false;
            // 
            // ctrlProductCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbMain);
            this.Name = "ctrlProductCard";
            this.Size = new System.Drawing.Size(700, 475);
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            this.pnlPrices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gbMain;
        private Guna.UI2.WinForms.Guna2PictureBox pbProductImage;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblCategoryID;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.LinkLabel llEditInfo;
        private Guna.UI2.WinForms.Guna2Panel pnlPrices;
        private System.Windows.Forms.Label lblSalePrice;
        private System.Windows.Forms.Label lblPurchasePrice;
        private System.Windows.Forms.Label lblProfitMargin;
        private System.Windows.Forms.Label lblDataBarcode;
        private System.Windows.Forms.Label lblDataCategory;
        private System.Windows.Forms.Label lblDataStock;
        private Guna.UI2.WinForms.Guna2Chip statusBadge;
        private Guna.UI2.WinForms.Guna2Separator sep1;
    }
}