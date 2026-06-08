namespace PosAndAccountantProject.Partners
{
    partial class frmAddUpdatePartners
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.gbCustomerInfo = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lnkDepositeWithdraw = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.lnkTransactionHistory = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.numProfitPercentage = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.numBalance = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCreatedDate = new System.Windows.Forms.Label();
            this.lblPartnerID = new System.Windows.Forms.Label();
            this.tsIsActive = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.ctrlPersonCardWithFilter1 = new PosAndAccountantProject.People.Controls.ctrlPersonCardWithFilter();
            this.gbCustomerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProfitPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBalance)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(114)))), ((int)(((byte)(228)))));
            this.lblTitle.Location = new System.Drawing.Point(61, 10);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(584, 41);
            this.lblTitle.TabIndex = 128;
            this.lblTitle.Text = "تعديل بيانات الشريك";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.BorderRadius = 8;
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(418, 620);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 37);
            this.btnClose.TabIndex = 126;
            this.btnClose.Text = "إغلاق";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 8;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(202, 620);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 37);
            this.btnSave.TabIndex = 127;
            this.btnSave.Text = "حفظ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbCustomerInfo
            // 
            this.gbCustomerInfo.BorderRadius = 10;
            this.gbCustomerInfo.Controls.Add(this.lnkDepositeWithdraw);
            this.gbCustomerInfo.Controls.Add(this.label3);
            this.gbCustomerInfo.Controls.Add(this.lnkTransactionHistory);
            this.gbCustomerInfo.Controls.Add(this.label8);
            this.gbCustomerInfo.Controls.Add(this.numProfitPercentage);
            this.gbCustomerInfo.Controls.Add(this.numBalance);
            this.gbCustomerInfo.Controls.Add(this.label6);
            this.gbCustomerInfo.Controls.Add(this.label5);
            this.gbCustomerInfo.Controls.Add(this.label9);
            this.gbCustomerInfo.Controls.Add(this.lblCreatedDate);
            this.gbCustomerInfo.Controls.Add(this.lblPartnerID);
            this.gbCustomerInfo.Controls.Add(this.tsIsActive);
            this.gbCustomerInfo.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.gbCustomerInfo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.gbCustomerInfo.ForeColor = System.Drawing.Color.White;
            this.gbCustomerInfo.Location = new System.Drawing.Point(41, 397);
            this.gbCustomerInfo.Margin = new System.Windows.Forms.Padding(2);
            this.gbCustomerInfo.Name = "gbCustomerInfo";
            this.gbCustomerInfo.Size = new System.Drawing.Size(593, 204);
            this.gbCustomerInfo.TabIndex = 129;
            this.gbCustomerInfo.Text = "بيانات الشريك ";
            this.gbCustomerInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lnkDepositeWithdraw
            // 
            this.lnkDepositeWithdraw.AutoSize = true;
            this.lnkDepositeWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkDepositeWithdraw.Location = new System.Drawing.Point(101, 171);
            this.lnkDepositeWithdraw.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkDepositeWithdraw.Name = "lnkDepositeWithdraw";
            this.lnkDepositeWithdraw.Size = new System.Drawing.Size(100, 24);
            this.lnkDepositeWithdraw.TabIndex = 149;
            this.lnkDepositeWithdraw.TabStop = true;
            this.lnkDepositeWithdraw.Text = " سحب او ايداع";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(457, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 144;
            this.label3.Text = "الرصيد الحالي:";
            // 
            // lnkTransactionHistory
            // 
            this.lnkTransactionHistory.AutoSize = true;
            this.lnkTransactionHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkTransactionHistory.Location = new System.Drawing.Point(81, 138);
            this.lnkTransactionHistory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkTransactionHistory.Name = "lnkTransactionHistory";
            this.lnkTransactionHistory.Size = new System.Drawing.Size(151, 24);
            this.lnkTransactionHistory.TabIndex = 148;
            this.lnkTransactionHistory.TabStop = true;
            this.lnkTransactionHistory.Text = "عرض الحركات السابقة";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(160, 107);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 141;
            this.label8.Text = "هل نشط  : ";
            // 
            // numProfitPercentage
            // 
            this.numProfitPercentage.BackColor = System.Drawing.Color.White;
            this.numProfitPercentage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.numProfitPercentage.BorderRadius = 10;
            this.numProfitPercentage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numProfitPercentage.DecimalPlaces = 2;
            this.numProfitPercentage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numProfitPercentage.Location = new System.Drawing.Point(324, 98);
            this.numProfitPercentage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.numProfitPercentage.Name = "numProfitPercentage";
            this.numProfitPercentage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numProfitPercentage.Size = new System.Drawing.Size(108, 29);
            this.numProfitPercentage.TabIndex = 25;
            this.numProfitPercentage.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            // 
            // numBalance
            // 
            this.numBalance.BackColor = System.Drawing.Color.White;
            this.numBalance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.numBalance.BorderRadius = 10;
            this.numBalance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numBalance.DecimalPlaces = 2;
            this.numBalance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numBalance.Location = new System.Drawing.Point(321, 152);
            this.numBalance.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.numBalance.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numBalance.Name = "numBalance";
            this.numBalance.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numBalance.Size = new System.Drawing.Size(114, 29);
            this.numBalance.TabIndex = 26;
            this.numBalance.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(171, 63);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "تاريخ الإنشاء:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(443, 99);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "النسبة من الربح%  :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(473, 62);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "مغرف الشريك:";
            // 
            // lblCreatedDate
            // 
            this.lblCreatedDate.AutoSize = true;
            this.lblCreatedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCreatedDate.Location = new System.Drawing.Point(81, 63);
            this.lblCreatedDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCreatedDate.Name = "lblCreatedDate";
            this.lblCreatedDate.Size = new System.Drawing.Size(45, 18);
            this.lblCreatedDate.TabIndex = 5;
            this.lblCreatedDate.Text = "[???]";
            // 
            // lblPartnerID
            // 
            this.lblPartnerID.AutoSize = true;
            this.lblPartnerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartnerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPartnerID.Location = new System.Drawing.Point(386, 62);
            this.lblPartnerID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPartnerID.Name = "lblPartnerID";
            this.lblPartnerID.Size = new System.Drawing.Size(45, 18);
            this.lblPartnerID.TabIndex = 0;
            this.lblPartnerID.Text = "[???]";
            // 
            // tsIsActive
            // 
            this.tsIsActive.Checked = true;
            this.tsIsActive.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tsIsActive.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tsIsActive.Location = new System.Drawing.Point(91, 108);
            this.tsIsActive.Margin = new System.Windows.Forms.Padding(2);
            this.tsIsActive.Name = "tsIsActive";
            this.tsIsActive.Size = new System.Drawing.Size(34, 19);
            this.tsIsActive.TabIndex = 20;
            // 
            // ctrlPersonCardWithFilter1
            // 
            this.ctrlPersonCardWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(8, 66);
            this.ctrlPersonCardWithFilter1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(640, 327);
            this.ctrlPersonCardWithFilter1.TabIndex = 125;
            this.ctrlPersonCardWithFilter1.PersonSelected += new System.EventHandler<PosAndAccountantProject.People.Controls.ctrlPersonCardWithFilter.PersonSelectedEventArgs>(this.ctrlPersonCardWithFilter1_PersonSelected);
            this.ctrlPersonCardWithFilter1.PersonNotFound += new System.EventHandler(this.ctrlPersonCardWithFilter1_PersonNotFound);
            // 
            // frmAddUpdatePartners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(658, 692);
            this.Controls.Add(this.gbCustomerInfo);
            this.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Name = "frmAddUpdatePartners";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddUpdatePartners";
            this.Load += new System.EventHandler(this.frmAddUpdatePartners_Load);
            this.gbCustomerInfo.ResumeLayout(false);
            this.gbCustomerInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProfitPercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBalance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private People.Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2GroupBox gbCustomerInfo;
        private System.Windows.Forms.LinkLabel lnkDepositeWithdraw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lnkTransactionHistory;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2NumericUpDown numProfitPercentage;
        private Guna.UI2.WinForms.Guna2NumericUpDown numBalance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCreatedDate;
        private System.Windows.Forms.Label lblPartnerID;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tsIsActive;
    }
}