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
            this.labell = new System.Windows.Forms.Label();
            this.lblSalePrice = new System.Windows.Forms.Label();
            this.lable34 = new System.Windows.Forms.Label();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.lblCategoryID = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.pbProductImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPurchasePrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblProfit = new System.Windows.Forms.Label();
            this.gbMain.SuspendLayout();
            this.pnlPrices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // gbMain
            // 
            this.gbMain.BorderRadius = 15;
            this.gbMain.Controls.Add(this.label1);
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
            this.gbMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
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
            this.lblDataStock.Location = new System.Drawing.Point(529, 249);
            this.lblDataStock.Name = "lblDataStock";
            this.lblDataStock.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDataStock.Size = new System.Drawing.Size(153, 28);
            this.lblDataStock.TabIndex = 3;
            this.lblDataStock.Text = "المخزون المتوفر: ";
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
            this.pnlPrices.Controls.Add(this.lblProfit);
            this.pnlPrices.Controls.Add(this.label3);
            this.pnlPrices.Controls.Add(this.lblPurchasePrice);
            this.pnlPrices.Controls.Add(this.labell);
            this.pnlPrices.Controls.Add(this.lblSalePrice);
            this.pnlPrices.Controls.Add(this.lable34);
            this.pnlPrices.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.pnlPrices.Location = new System.Drawing.Point(25, 310);
            this.pnlPrices.Name = "pnlPrices";
            this.pnlPrices.Size = new System.Drawing.Size(645, 130);
            this.pnlPrices.TabIndex = 6;
            // 
            // labell
            // 
            this.labell.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.labell.Location = new System.Drawing.Point(520, 12);
            this.labell.Name = "labell";
            this.labell.Size = new System.Drawing.Size(108, 30);
            this.labell.TabIndex = 0;
            this.labell.Text = "سعر الشراء : ";
            this.labell.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSalePrice
            // 
            this.lblSalePrice.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold);
            this.lblSalePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.lblSalePrice.Location = new System.Drawing.Point(364, 70);
            this.lblSalePrice.Name = "lblSalePrice";
            this.lblSalePrice.Size = new System.Drawing.Size(139, 32);
            this.lblSalePrice.TabIndex = 1;
            this.lblSalePrice.Text = "0.00$";
            this.lblSalePrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lable34
            // 
            this.lable34.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lable34.ForeColor = System.Drawing.Color.Gray;
            this.lable34.Location = new System.Drawing.Point(135, 47);
            this.lable34.Name = "lable34";
            this.lable34.Size = new System.Drawing.Size(127, 40);
            this.lable34.TabIndex = 2;
            this.lable34.Text = "صافي الربح المتوقع : ";
            this.lable34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBarcode.Location = new System.Drawing.Point(600, 160);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
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
            this.lblCategoryID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(404, 249);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(20, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "0";
            // 
            // lblPurchasePrice
            // 
            this.lblPurchasePrice.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold);
            this.lblPurchasePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.lblPurchasePrice.Location = new System.Drawing.Point(364, 12);
            this.lblPurchasePrice.Name = "lblPurchasePrice";
            this.lblPurchasePrice.Size = new System.Drawing.Size(139, 32);
            this.lblPurchasePrice.TabIndex = 4;
            this.lblPurchasePrice.Text = "0.00$";
            this.lblPurchasePrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.label3.Location = new System.Drawing.Point(520, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "سعر البيع :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProfit
            // 
            this.lblProfit.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold);
            this.lblProfit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.lblProfit.Location = new System.Drawing.Point(24, 47);
            this.lblProfit.Name = "lblProfit";
            this.lblProfit.Size = new System.Drawing.Size(94, 32);
            this.lblProfit.TabIndex = 6;
            this.lblProfit.Text = "0.00$";
            this.lblProfit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
        private System.Windows.Forms.Label labell;
        private System.Windows.Forms.Label lable34;
        private System.Windows.Forms.Label lblDataBarcode;
        private System.Windows.Forms.Label lblDataCategory;
        private System.Windows.Forms.Label lblDataStock;
        private Guna.UI2.WinForms.Guna2Chip statusBadge;
        private Guna.UI2.WinForms.Guna2Separator sep1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPurchasePrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblProfit;
    }
}