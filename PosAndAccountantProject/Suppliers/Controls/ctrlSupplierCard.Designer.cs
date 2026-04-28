namespace PosAndAccountantProject.Suppliers.Controls
{
    partial class ctrlSupplierCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctrlPersonCard1 = new PosAndAccountantProject.People.Controls.ctrlPersonCard();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblModifiedDate = new System.Windows.Forms.Label();
            this.lblCreatedDate = new System.Windows.Forms.Label();
            this.lblTotalRemainingDebt = new System.Windows.Forms.Label();
            this.lblSupplierID = new System.Windows.Forms.Label();
            this.gbSupplierInfo = new Guna.UI2.WinForms.Guna2GroupBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.gbSupplierInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlPersonCard1.Location = new System.Drawing.Point(6, 3);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctrlPersonCard1.Size = new System.Drawing.Size(841, 301);
            this.ctrlPersonCard1.TabIndex = 2;
            this.ctrlPersonCard1.WasUpdated = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.White;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(27, 614);
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
            this.label9.Location = new System.Drawing.Point(621, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 25);
            this.label9.TabIndex = 144;
            this.label9.Text = "ملاحظات:";
            // 
            // lblNotes
            // 
            this.lblNotes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNotes.Location = new System.Drawing.Point(30, 233);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(517, 50);
            this.lblNotes.TabIndex = 143;
            this.lblNotes.Text = " [???]";
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblIsActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lblIsActive.Location = new System.Drawing.Point(492, 169);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(61, 25);
            this.lblIsActive.TabIndex = 142;
            this.lblIsActive.Text = " [???]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(612, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 25);
            this.label8.TabIndex = 141;
            this.label8.Text = "نشط : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(229, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "آخر تعديل:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(229, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "تاريخ الإنشاء:";
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
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "رقم المورد:";
            // 
            // lblModifiedDate
            // 
            this.lblModifiedDate.AutoSize = true;
            this.lblModifiedDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblModifiedDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblModifiedDate.Location = new System.Drawing.Point(109, 124);
            this.lblModifiedDate.Name = "lblModifiedDate";
            this.lblModifiedDate.Size = new System.Drawing.Size(52, 23);
            this.lblModifiedDate.TabIndex = 6;
            this.lblModifiedDate.Text = " [???]";
            // 
            // lblCreatedDate
            // 
            this.lblCreatedDate.AutoSize = true;
            this.lblCreatedDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCreatedDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCreatedDate.Location = new System.Drawing.Point(109, 79);
            this.lblCreatedDate.Name = "lblCreatedDate";
            this.lblCreatedDate.Size = new System.Drawing.Size(52, 23);
            this.lblCreatedDate.TabIndex = 5;
            this.lblCreatedDate.Text = " [???]";
            // 
            // lblTotalRemainingDebt
            // 
            this.lblTotalRemainingDebt.AutoSize = true;
            this.lblTotalRemainingDebt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalRemainingDebt.ForeColor = System.Drawing.Color.Crimson;
            this.lblTotalRemainingDebt.Location = new System.Drawing.Point(492, 124);
            this.lblTotalRemainingDebt.Name = "lblTotalRemainingDebt";
            this.lblTotalRemainingDebt.Size = new System.Drawing.Size(54, 23);
            this.lblTotalRemainingDebt.TabIndex = 1;
            this.lblTotalRemainingDebt.Text = " [???]";
            // 
            // lblSupplierID
            // 
            this.lblSupplierID.AutoSize = true;
            this.lblSupplierID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSupplierID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSupplierID.Location = new System.Drawing.Point(492, 79);
            this.lblSupplierID.Name = "lblSupplierID";
            this.lblSupplierID.Size = new System.Drawing.Size(52, 23);
            this.lblSupplierID.TabIndex = 0;
            this.lblSupplierID.Text = " [???]";
            // 
            // gbSupplierInfo
            // 
            this.gbSupplierInfo.BorderRadius = 10;
            this.gbSupplierInfo.Controls.Add(this.label9);
            this.gbSupplierInfo.Controls.Add(this.lblNotes);
            this.gbSupplierInfo.Controls.Add(this.lblIsActive);
            this.gbSupplierInfo.Controls.Add(this.label8);
            this.gbSupplierInfo.Controls.Add(this.label7);
            this.gbSupplierInfo.Controls.Add(this.label6);
            this.gbSupplierInfo.Controls.Add(this.label2);
            this.gbSupplierInfo.Controls.Add(this.label1);
            this.gbSupplierInfo.Controls.Add(this.lblModifiedDate);
            this.gbSupplierInfo.Controls.Add(this.lblCreatedDate);
            this.gbSupplierInfo.Controls.Add(this.lblTotalRemainingDebt);
            this.gbSupplierInfo.Controls.Add(this.lblSupplierID);
            this.gbSupplierInfo.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.gbSupplierInfo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.gbSupplierInfo.ForeColor = System.Drawing.Color.White;
            this.gbSupplierInfo.Location = new System.Drawing.Point(17, 299);
            this.gbSupplierInfo.Name = "gbSupplierInfo";
            this.gbSupplierInfo.Size = new System.Drawing.Size(830, 312);
            this.gbSupplierInfo.TabIndex = 3;
            this.gbSupplierInfo.Text = "بيانات المورد ";
            this.gbSupplierInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(246, 614);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(143, 29);
            this.linkLabel2.TabIndex = 147;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "انشاء فاتورة شراء";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // ctrlSupplierCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.ctrlPersonCard1);
            this.Controls.Add(this.gbSupplierInfo);
            this.Name = "ctrlSupplierCard";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(853, 654);
            this.gbSupplierInfo.ResumeLayout(false);
            this.gbSupplierInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private People.Controls.ctrlPersonCard ctrlPersonCard1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblIsActive;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblModifiedDate;
        private System.Windows.Forms.Label lblCreatedDate;
        private System.Windows.Forms.Label lblTotalRemainingDebt;
        private System.Windows.Forms.Label lblSupplierID;
        private Guna.UI2.WinForms.Guna2GroupBox gbSupplierInfo;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}
