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
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlPersonCardWithFilter1 = new PosAndAccountantProject.People.Controls.ctrlPersonCardWithFilter();
            this.ctrlEditPartnersProfitPercentage1 = new PosAndAccountantProject.Partners.Controls.ctrlEditPartnersProfitPercentage();
            this.gbCustomerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProfitPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBalance)).BeginInit();
            this.guna2TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(114)))), ((int)(((byte)(228)))));
            this.lblTitle.Location = new System.Drawing.Point(283, 9);
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
            this.btnClose.Location = new System.Drawing.Point(575, 751);
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
            this.btnSave.Location = new System.Drawing.Point(359, 751);
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
            this.gbCustomerInfo.Location = new System.Drawing.Point(30, 431);
            this.gbCustomerInfo.Margin = new System.Windows.Forms.Padding(2);
            this.gbCustomerInfo.Name = "gbCustomerInfo";
            this.gbCustomerInfo.Size = new System.Drawing.Size(736, 204);
            this.gbCustomerInfo.TabIndex = 129;
            this.gbCustomerInfo.Text = "بيانات الشريك ";
            this.gbCustomerInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lnkDepositeWithdraw
            // 
            this.lnkDepositeWithdraw.AutoSize = true;
            this.lnkDepositeWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkDepositeWithdraw.Location = new System.Drawing.Point(113, 170);
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
            this.label3.Location = new System.Drawing.Point(547, 155);
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
            this.lnkTransactionHistory.Location = new System.Drawing.Point(93, 137);
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
            this.label8.Location = new System.Drawing.Point(172, 106);
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
            this.numProfitPercentage.Location = new System.Drawing.Point(414, 101);
            this.numProfitPercentage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.numProfitPercentage.Name = "numProfitPercentage";
            this.numProfitPercentage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numProfitPercentage.Size = new System.Drawing.Size(108, 29);
            this.numProfitPercentage.TabIndex = 25;
            this.numProfitPercentage.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.numProfitPercentage.Validating += new System.ComponentModel.CancelEventHandler(this.numProfitPercentage_Validating);
            // 
            // numBalance
            // 
            this.numBalance.BackColor = System.Drawing.Color.White;
            this.numBalance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.numBalance.BorderRadius = 10;
            this.numBalance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numBalance.DecimalPlaces = 2;
            this.numBalance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numBalance.Location = new System.Drawing.Point(411, 155);
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
            this.label6.Location = new System.Drawing.Point(183, 62);
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
            this.label5.Location = new System.Drawing.Point(533, 102);
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
            this.label9.Location = new System.Drawing.Point(563, 65);
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
            this.lblCreatedDate.Location = new System.Drawing.Point(93, 62);
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
            this.lblPartnerID.Location = new System.Drawing.Point(476, 65);
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
            this.tsIsActive.Location = new System.Drawing.Point(103, 107);
            this.tsIsActive.Margin = new System.Windows.Forms.Padding(2);
            this.tsIsActive.Name = "tsIsActive";
            this.tsIsActive.Size = new System.Drawing.Size(34, 19);
            this.tsIsActive.TabIndex = 20;
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.guna2TabControl1.Controls.Add(this.tabPage1);
            this.guna2TabControl1.Controls.Add(this.tabPage2);
            this.guna2TabControl1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.Location = new System.Drawing.Point(-3, 73);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(1034, 661);
            this.guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.DimGray;
            this.guna2TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.Silver;
            this.guna2TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.Black;
            this.guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.guna2TabControl1.TabButtonSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.TabIndex = 130;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.DimGray;
            this.guna2TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.VerticalRight;
            this.guna2TabControl1.SelectedIndexChanged += new System.EventHandler(this.guna2TabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.tabPage1.Controls.Add(this.gbCustomerInfo);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(846, 653);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Tag = " ";
            this.tabPage1.Text = "معلومات الشريك";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.ctrlEditPartnersProfitPercentage1);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(846, 653);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "تعديل نسبة ربح الشركاء";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(391, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 103);
            this.label1.TabIndex = 1;
            this.label1.Text = "يمكنك تعديل نسب ربح الشركاء من القائمة مباشرة وتأاكد ان يكون المجموع الكلي يساوي " +
    "100";
            // 
            // ctrlPersonCardWithFilter1
            // 
            this.ctrlPersonCardWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(13, 5);
            this.ctrlPersonCardWithFilter1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(837, 421);
            this.ctrlPersonCardWithFilter1.TabIndex = 125;
            this.ctrlPersonCardWithFilter1.PersonSelected += new System.EventHandler<PosAndAccountantProject.People.Controls.ctrlPersonCardWithFilter.PersonSelectedEventArgs>(this.ctrlPersonCardWithFilter1_PersonSelected);
            this.ctrlPersonCardWithFilter1.PersonNotFound += new System.EventHandler(this.ctrlPersonCardWithFilter1_PersonNotFound);
            // 
            // ctrlEditPartnersProfitPercentage1
            // 
            this.ctrlEditPartnersProfitPercentage1.BackColor = System.Drawing.Color.White;
            this.ctrlEditPartnersProfitPercentage1.Location = new System.Drawing.Point(7, 221);
            this.ctrlEditPartnersProfitPercentage1.Margin = new System.Windows.Forms.Padding(2);
            this.ctrlEditPartnersProfitPercentage1.Name = "ctrlEditPartnersProfitPercentage1";
            this.ctrlEditPartnersProfitPercentage1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctrlEditPartnersProfitPercentage1.Size = new System.Drawing.Size(823, 344);
            this.ctrlEditPartnersProfitPercentage1.TabIndex = 0;
            // 
            // frmAddUpdatePartners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1031, 821);
            this.Controls.Add(this.guna2TabControl1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
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
            this.guna2TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
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
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Controls.ctrlEditPartnersProfitPercentage ctrlEditPartnersProfitPercentage1;
        private System.Windows.Forms.Label label1;
    }
}