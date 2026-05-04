namespace PosAndAccountantProject.Products
{
    partial class frmProductInfo
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
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnPrintBarcode = new Guna.UI2.WinForms.Guna2Button();
            this.ctrlProductCard1 = new PosAndAccountantProject.Products.Controls.ctrlProductCard();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BorderRadius = 10;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(612, 545);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 45);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "إغلاق النافذة";
            // 
            // btnPrintBarcode
            // 
            this.btnPrintBarcode.BorderRadius = 10;
            this.btnPrintBarcode.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrintBarcode.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrintBarcode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrintBarcode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrintBarcode.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnPrintBarcode.ForeColor = System.Drawing.Color.White;
            this.btnPrintBarcode.Location = new System.Drawing.Point(62, 545);
            this.btnPrintBarcode.Name = "btnPrintBarcode";
            this.btnPrintBarcode.Size = new System.Drawing.Size(180, 45);
            this.btnPrintBarcode.TabIndex = 1;
            this.btnPrintBarcode.Text = "طباعة باركود المنتج";
            // 
            // ctrlProductCard1
            // 
            this.ctrlProductCard1.BackColor = System.Drawing.Color.White;
            this.ctrlProductCard1.Location = new System.Drawing.Point(62, 60);
            this.ctrlProductCard1.Name = "ctrlProductCard1";
            this.ctrlProductCard1.Size = new System.Drawing.Size(700, 475);
            this.ctrlProductCard1.TabIndex = 0;
            // 
            // frmProductInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(828, 620);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPrintBarcode);
            this.Controls.Add(this.ctrlProductCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "frmProductInfo";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "معلومات المنتج";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ctrlProductCard ctrlProductCard1;
        private Guna.UI2.WinForms.Guna2Button btnPrintBarcode;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}