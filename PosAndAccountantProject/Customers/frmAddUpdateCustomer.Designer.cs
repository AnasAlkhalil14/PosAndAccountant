namespace PosAndAccountantProject.Customers
{
    partial class frmAddUpdateCustomer
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
            this.gbCustomerInfo = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.cbCustomerType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblCustomerType = new System.Windows.Forms.Label();
            this.lblCreditLimit = new System.Windows.Forms.Label();
            this.txtTotalDebt = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTotalDebt = new System.Windows.Forms.Label();
            this.tsIsActive = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.lblCustomerIDValue = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.numCreditLimit = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.guna2NumericUpDown1 = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.ctrlPersonCardWithFilter1 = new PosAndAccountantProject.People.Controls.ctrlPersonCardWithFilter();
            this.gbCustomerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCreditLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCustomerInfo
            // 
            this.gbCustomerInfo.BorderRadius = 20;
            this.gbCustomerInfo.Controls.Add(this.lblDiscount);
            this.gbCustomerInfo.Controls.Add(this.cbCustomerType);
            this.gbCustomerInfo.Controls.Add(this.lblCustomerType);
            this.gbCustomerInfo.Controls.Add(this.lblCreditLimit);
            this.gbCustomerInfo.Controls.Add(this.txtTotalDebt);
            this.gbCustomerInfo.Controls.Add(this.lblTotalDebt);
            this.gbCustomerInfo.Controls.Add(this.tsIsActive);
            this.gbCustomerInfo.Controls.Add(this.lblIsActive);
            this.gbCustomerInfo.Controls.Add(this.lblCustomerIDValue);
            this.gbCustomerInfo.Controls.Add(this.lblCustomerID);
            this.gbCustomerInfo.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.gbCustomerInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.gbCustomerInfo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.gbCustomerInfo.ForeColor = System.Drawing.Color.White;
            this.gbCustomerInfo.Location = new System.Drawing.Point(25, 446);
            this.gbCustomerInfo.Name = "gbCustomerInfo";
            this.gbCustomerInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gbCustomerInfo.Size = new System.Drawing.Size(821, 220);
            this.gbCustomerInfo.TabIndex = 1;
            this.gbCustomerInfo.Text = "بيانات الحساب والعميل";
            this.gbCustomerInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDiscount.Location = new System.Drawing.Point(268, 168);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(133, 25);
            this.lblDiscount.TabIndex = 1;
            this.lblDiscount.Text = "نسبة الخصم %:";
            // 
            // cbCustomerType
            // 
            this.cbCustomerType.BackColor = System.Drawing.Color.Transparent;
            this.cbCustomerType.BorderRadius = 5;
            this.cbCustomerType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCustomerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCustomerType.FocusedColor = System.Drawing.Color.Empty;
            this.cbCustomerType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbCustomerType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbCustomerType.ItemHeight = 30;
            this.cbCustomerType.Items.AddRange(new object[] {
            "عميل نقدي",
            "عميل آجل",
            "VIP"});
            this.cbCustomerType.Location = new System.Drawing.Point(423, 163);
            this.cbCustomerType.Name = "cbCustomerType";
            this.cbCustomerType.Size = new System.Drawing.Size(230, 36);
            this.cbCustomerType.TabIndex = 2;
            // 
            // lblCustomerType
            // 
            this.lblCustomerType.AutoSize = true;
            this.lblCustomerType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCustomerType.Location = new System.Drawing.Point(663, 168);
            this.lblCustomerType.Name = "lblCustomerType";
            this.lblCustomerType.Size = new System.Drawing.Size(102, 25);
            this.lblCustomerType.TabIndex = 3;
            this.lblCustomerType.Text = "نوع العميل:";
            // 
            // lblCreditLimit
            // 
            this.lblCreditLimit.AutoSize = true;
            this.lblCreditLimit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCreditLimit.Location = new System.Drawing.Point(268, 113);
            this.lblCreditLimit.Name = "lblCreditLimit";
            this.lblCreditLimit.Size = new System.Drawing.Size(124, 25);
            this.lblCreditLimit.TabIndex = 5;
            this.lblCreditLimit.Text = "سقف الائتمان:";
            // 
            // txtTotalDebt
            // 
            this.txtTotalDebt.BorderRadius = 5;
            this.txtTotalDebt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalDebt.DefaultText = "";
            this.txtTotalDebt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTotalDebt.Location = new System.Drawing.Point(473, 113);
            this.txtTotalDebt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotalDebt.Name = "txtTotalDebt";
            this.txtTotalDebt.PlaceholderText = "";
            this.txtTotalDebt.ReadOnly = true;
            this.txtTotalDebt.SelectedText = "";
            this.txtTotalDebt.Size = new System.Drawing.Size(180, 36);
            this.txtTotalDebt.TabIndex = 6;
            // 
            // lblTotalDebt
            // 
            this.lblTotalDebt.AutoSize = true;
            this.lblTotalDebt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalDebt.Location = new System.Drawing.Point(663, 113);
            this.lblTotalDebt.Name = "lblTotalDebt";
            this.lblTotalDebt.Size = new System.Drawing.Size(126, 25);
            this.lblTotalDebt.TabIndex = 7;
            this.lblTotalDebt.Text = "إجمالي الديون:";
            // 
            // tsIsActive
            // 
            this.tsIsActive.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tsIsActive.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tsIsActive.Location = new System.Drawing.Point(169, 58);
            this.tsIsActive.Name = "tsIsActive";
            this.tsIsActive.Size = new System.Drawing.Size(45, 23);
            this.tsIsActive.TabIndex = 8;
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIsActive.Location = new System.Drawing.Point(287, 56);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(114, 25);
            this.lblIsActive.TabIndex = 9;
            this.lblIsActive.Text = "حالة الحساب:";
            // 
            // lblCustomerIDValue
            // 
            this.lblCustomerIDValue.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerIDValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCustomerIDValue.ForeColor = System.Drawing.Color.Red;
            this.lblCustomerIDValue.Location = new System.Drawing.Point(583, 58);
            this.lblCustomerIDValue.Name = "lblCustomerIDValue";
            this.lblCustomerIDValue.Size = new System.Drawing.Size(44, 30);
            this.lblCustomerIDValue.TabIndex = 10;
            this.lblCustomerIDValue.Text = "[???]";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.ForeColor = System.Drawing.Color.Gray;
            this.lblCustomerID.Location = new System.Drawing.Point(663, 58);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(101, 25);
            this.lblCustomerID.TabIndex = 11;
            this.lblCustomerID.Text = "رقم العميل:";
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 8;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(448, 693);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 45);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "حفظ";
            // 
            // btnClose
            // 
            this.btnClose.BorderRadius = 8;
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(293, 693);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(140, 45);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "إغلاق";
            // 
            // numCreditLimit
            // 
            this.numCreditLimit.BackColor = System.Drawing.Color.Transparent;
            this.numCreditLimit.BorderRadius = 10;
            this.numCreditLimit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numCreditLimit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numCreditLimit.Location = new System.Drawing.Point(143, 559);
            this.numCreditLimit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numCreditLimit.Name = "numCreditLimit";
            this.numCreditLimit.Size = new System.Drawing.Size(144, 36);
            this.numCreditLimit.TabIndex = 12;
            this.numCreditLimit.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(35)))), ((int)(((byte)(164)))));
            // 
            // guna2NumericUpDown1
            // 
            this.guna2NumericUpDown1.BackColor = System.Drawing.Color.Transparent;
            this.guna2NumericUpDown1.BorderRadius = 10;
            this.guna2NumericUpDown1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2NumericUpDown1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2NumericUpDown1.Location = new System.Drawing.Point(161, 614);
            this.guna2NumericUpDown1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2NumericUpDown1.Name = "guna2NumericUpDown1";
            this.guna2NumericUpDown1.Size = new System.Drawing.Size(113, 36);
            this.guna2NumericUpDown1.TabIndex = 13;
            this.guna2NumericUpDown1.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(35)))), ((int)(((byte)(164)))));
            // 
            // ctrlPersonCardWithFilter1
            // 
            this.ctrlPersonCardWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(12, 20);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(854, 420);
            this.ctrlPersonCardWithFilter1.TabIndex = 0;
            // 
            // frmAddUpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(905, 750);
            this.Controls.Add(this.guna2NumericUpDown1);
            this.Controls.Add(this.numCreditLimit);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbCustomerInfo);
            this.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmAddUpdateCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة / تعديل عميل";
            this.gbCustomerInfo.ResumeLayout(false);
            this.gbCustomerInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCreditLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private People.Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private Guna.UI2.WinForms.Guna2GroupBox gbCustomerInfo;
        private System.Windows.Forms.Label lblCustomerID;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCustomerIDValue;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tsIsActive;
        private System.Windows.Forms.Label lblIsActive;
        private System.Windows.Forms.Label lblCreditLimit;
        private Guna.UI2.WinForms.Guna2ComboBox cbCustomerType;
        private System.Windows.Forms.Label lblCustomerType;
        private System.Windows.Forms.Label lblDiscount;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalDebt;
        private System.Windows.Forms.Label lblTotalDebt;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2NumericUpDown numCreditLimit;
        private Guna.UI2.WinForms.Guna2NumericUpDown guna2NumericUpDown1;
    }
}