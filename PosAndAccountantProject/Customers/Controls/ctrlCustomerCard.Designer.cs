namespace PosAndAccountantProject.Customers.Controls
{
    partial class ctrlCustomerCard
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
            this.gbCustomerInfo = new Guna.UI2.WinForms.Guna2GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblModifiedDate = new System.Windows.Forms.Label();
            this.lblCreatedDate = new System.Windows.Forms.Label();
            this.lblDiscountPercentage = new System.Windows.Forms.Label();
            this.lblCustomerType = new System.Windows.Forms.Label();
            this.lblCreditLimit = new System.Windows.Forms.Label();
            this.lblTotalRemainingDebt = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.ctrlPersonCard1 = new PosAndAccountantProject.People.Controls.ctrlPersonCard();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.gbCustomerInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCustomerInfo
            // 
            this.gbCustomerInfo.BorderRadius = 10;
            this.gbCustomerInfo.Controls.Add(this.label9);
            this.gbCustomerInfo.Controls.Add(this.lblNotes);
            this.gbCustomerInfo.Controls.Add(this.lblIsActive);
            this.gbCustomerInfo.Controls.Add(this.label8);
            this.gbCustomerInfo.Controls.Add(this.label7);
            this.gbCustomerInfo.Controls.Add(this.label6);
            this.gbCustomerInfo.Controls.Add(this.label5);
            this.gbCustomerInfo.Controls.Add(this.label4);
            this.gbCustomerInfo.Controls.Add(this.label3);
            this.gbCustomerInfo.Controls.Add(this.label2);
            this.gbCustomerInfo.Controls.Add(this.label1);
            this.gbCustomerInfo.Controls.Add(this.lblModifiedDate);
            this.gbCustomerInfo.Controls.Add(this.lblCreatedDate);
            this.gbCustomerInfo.Controls.Add(this.lblDiscountPercentage);
            this.gbCustomerInfo.Controls.Add(this.lblCustomerType);
            this.gbCustomerInfo.Controls.Add(this.lblCreditLimit);
            this.gbCustomerInfo.Controls.Add(this.lblTotalRemainingDebt);
            this.gbCustomerInfo.Controls.Add(this.lblCustomerID);
            this.gbCustomerInfo.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.gbCustomerInfo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.gbCustomerInfo.ForeColor = System.Drawing.Color.White;
            this.gbCustomerInfo.Location = new System.Drawing.Point(12, 317);
            this.gbCustomerInfo.Name = "gbCustomerInfo";
            this.gbCustomerInfo.Size = new System.Drawing.Size(830, 340);
            this.gbCustomerInfo.TabIndex = 1;
            this.gbCustomerInfo.Text = "بيانات العميل ";
            this.gbCustomerInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(12, 660);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(175, 29);
            this.linkLabel1.TabIndex = 145;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "عرض الفواتير السابقة";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(612, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 25);
            this.label9.TabIndex = 144;
            this.label9.Text = "ملاحظات:";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNotes.Location = new System.Drawing.Point(492, 269);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(47, 23);
            this.lblNotes.TabIndex = 143;
            this.lblNotes.Text = "[???]";
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblIsActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lblIsActive.Location = new System.Drawing.Point(102, 212);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(56, 25);
            this.lblIsActive.TabIndex = 142;
            this.lblIsActive.Text = "[???]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(222, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 25);
            this.label8.TabIndex = 141;
            this.label8.Text = "نشط : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(222, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "آخر تعديل:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(222, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "تاريخ الإنشاء:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(222, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "نسبة الخصم:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(612, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "نوع العميل:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(612, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "سقف الائتمان:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(612, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "الديون المتبقية:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(612, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "رقم العميل:";
            // 
            // lblModifiedDate
            // 
            this.lblModifiedDate.AutoSize = true;
            this.lblModifiedDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblModifiedDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblModifiedDate.Location = new System.Drawing.Point(102, 158);
            this.lblModifiedDate.Name = "lblModifiedDate";
            this.lblModifiedDate.Size = new System.Drawing.Size(47, 23);
            this.lblModifiedDate.TabIndex = 6;
            this.lblModifiedDate.Text = "[???]";
            // 
            // lblCreatedDate
            // 
            this.lblCreatedDate.AutoSize = true;
            this.lblCreatedDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCreatedDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCreatedDate.Location = new System.Drawing.Point(102, 113);
            this.lblCreatedDate.Name = "lblCreatedDate";
            this.lblCreatedDate.Size = new System.Drawing.Size(47, 23);
            this.lblCreatedDate.TabIndex = 5;
            this.lblCreatedDate.Text = "[???]";
            // 
            // lblDiscountPercentage
            // 
            this.lblDiscountPercentage.AutoSize = true;
            this.lblDiscountPercentage.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDiscountPercentage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDiscountPercentage.Location = new System.Drawing.Point(102, 68);
            this.lblDiscountPercentage.Name = "lblDiscountPercentage";
            this.lblDiscountPercentage.Size = new System.Drawing.Size(47, 23);
            this.lblDiscountPercentage.TabIndex = 4;
            this.lblDiscountPercentage.Text = "[???]";
            // 
            // lblCustomerType
            // 
            this.lblCustomerType.AutoSize = true;
            this.lblCustomerType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCustomerType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCustomerType.Location = new System.Drawing.Point(492, 214);
            this.lblCustomerType.Name = "lblCustomerType";
            this.lblCustomerType.Size = new System.Drawing.Size(47, 23);
            this.lblCustomerType.TabIndex = 3;
            this.lblCustomerType.Text = "[???]";
            // 
            // lblCreditLimit
            // 
            this.lblCreditLimit.AutoSize = true;
            this.lblCreditLimit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCreditLimit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCreditLimit.Location = new System.Drawing.Point(492, 169);
            this.lblCreditLimit.Name = "lblCreditLimit";
            this.lblCreditLimit.Size = new System.Drawing.Size(47, 23);
            this.lblCreditLimit.TabIndex = 2;
            this.lblCreditLimit.Text = "[???]";
            // 
            // lblTotalRemainingDebt
            // 
            this.lblTotalRemainingDebt.AutoSize = true;
            this.lblTotalRemainingDebt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalRemainingDebt.ForeColor = System.Drawing.Color.Crimson;
            this.lblTotalRemainingDebt.Location = new System.Drawing.Point(492, 124);
            this.lblTotalRemainingDebt.Name = "lblTotalRemainingDebt";
            this.lblTotalRemainingDebt.Size = new System.Drawing.Size(49, 23);
            this.lblTotalRemainingDebt.TabIndex = 1;
            this.lblTotalRemainingDebt.Text = "[???]";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCustomerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCustomerID.Location = new System.Drawing.Point(492, 79);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(47, 23);
            this.lblCustomerID.TabIndex = 0;
            this.lblCustomerID.Text = "[???]";
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlPersonCard1.Location = new System.Drawing.Point(15, 10);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctrlPersonCard1.Size = new System.Drawing.Size(841, 301);
            this.ctrlPersonCard1.TabIndex = 0;
            this.ctrlPersonCard1.WasUpdated = false;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(234, 660);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(137, 29);
            this.linkLabel2.TabIndex = 146;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "انشاء فاتورة مبيع";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // ctrlCustomerCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.gbCustomerInfo);
            this.Controls.Add(this.ctrlPersonCard1);
            this.Name = "ctrlCustomerCard";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(853, 696);
            this.gbCustomerInfo.ResumeLayout(false);
            this.gbCustomerInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private People.Controls.ctrlPersonCard ctrlPersonCard1;
        private Guna.UI2.WinForms.Guna2GroupBox gbCustomerInfo;
        private System.Windows.Forms.Label lblModifiedDate;
        private System.Windows.Forms.Label lblCreatedDate;
        private System.Windows.Forms.Label lblDiscountPercentage;
        private System.Windows.Forms.Label lblCustomerType;
        private System.Windows.Forms.Label lblCreditLimit;
        private System.Windows.Forms.Label lblTotalRemainingDebt;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIsActive;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}