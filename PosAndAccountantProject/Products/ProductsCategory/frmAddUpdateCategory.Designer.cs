namespace PosAndAccountantProject.Products.ProductsCategory
{
    partial class frmAddUpdateCategory
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbCategoryInfo = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCategoryName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCategoryID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.gbCategoryInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblTitle.Location = new System.Drawing.Point(12, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(526, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "إضافة / تعديل تصنيف";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbCategoryInfo
            // 
            this.gbCategoryInfo.BorderRadius = 10;
            this.gbCategoryInfo.Controls.Add(this.txtDescription);
            this.gbCategoryInfo.Controls.Add(this.label3);
            this.gbCategoryInfo.Controls.Add(this.txtCategoryName);
            this.gbCategoryInfo.Controls.Add(this.label2);
            this.gbCategoryInfo.Controls.Add(this.lblCategoryID);
            this.gbCategoryInfo.Controls.Add(this.label1);
            this.gbCategoryInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gbCategoryInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gbCategoryInfo.Location = new System.Drawing.Point(25, 85);
            this.gbCategoryInfo.Name = "gbCategoryInfo";
            this.gbCategoryInfo.Size = new System.Drawing.Size(500, 380);
            this.gbCategoryInfo.TabIndex = 1;
            this.gbCategoryInfo.Text = "بيانات التصنيف";
            this.gbCategoryInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDescription
            // 
            this.txtDescription.BorderRadius = 8;
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.DefaultText = "";
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDescription.Location = new System.Drawing.Point(30, 235);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PlaceholderText = "أدخل وصفاً مختصراً للتصنيف...";
            this.txtDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDescription.SelectedText = "";
            this.txtDescription.Size = new System.Drawing.Size(440, 110);
            this.txtDescription.TabIndex = 1;
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(405, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "الوصف:";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.BorderRadius = 8;
            this.txtCategoryName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCategoryName.DefaultText = "";
            this.txtCategoryName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCategoryName.Location = new System.Drawing.Point(30, 145);
            this.txtCategoryName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.PlaceholderText = "أدخل اسم التصنيف هنا...";
            this.txtCategoryName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCategoryName.SelectedText = "";
            this.txtCategoryName.Size = new System.Drawing.Size(440, 40);
            this.txtCategoryName.TabIndex = 0;
            this.txtCategoryName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(375, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "اسم التصنيف:";
            // 
            // lblCategoryID
            // 
            this.lblCategoryID.AutoSize = true;
            this.lblCategoryID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCategoryID.ForeColor = System.Drawing.Color.Red;
            this.lblCategoryID.Location = new System.Drawing.Point(310, 65);
            this.lblCategoryID.Name = "lblCategoryID";
            this.lblCategoryID.Size = new System.Drawing.Size(46, 20);
            this.lblCategoryID.TabIndex = 4;
            this.lblCategoryID.Text = "[???]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(380, 65);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "رقم التصنيف:";
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 10;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(91, 489);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 45);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "حفظ";
            // 
            // btnClose
            // 
            this.btnClose.BorderRadius = 10;
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(276, 489);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(140, 45);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "إلغاء";
            // 
            // frmAddUpdateCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(550, 560);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbCategoryInfo);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAddUpdateCategory";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "إضافة / تعديل تصنيف";
            this.gbCategoryInfo.ResumeLayout(false);
            this.gbCategoryInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2GroupBox gbCategoryInfo;
        private Guna.UI2.WinForms.Guna2TextBox txtDescription;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtCategoryName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCategoryID;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}