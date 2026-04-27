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
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNotes = new Guna.UI2.WinForms.Guna2TextBox();
            this.numCreditLimit = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.numDiscount = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.cbCustomerType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblCustomerType = new System.Windows.Forms.Label();
            this.lblCreditLimit = new System.Windows.Forms.Label();
            this.txtTotalDebt = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTotalDebt = new System.Windows.Forms.Label();
            this.tsIsActive = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.lblCustomerID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labeld = new System.Windows.Forms.Label();
            this.ctrlPersonCardWithFilter1 = new PosAndAccountantProject.People.Controls.ctrlPersonCardWithFilter();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCreditLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 8;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(498, 856);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 45);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "حفظ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BorderRadius = 8;
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(244, 856);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(140, 45);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "إغلاق";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(114)))), ((int)(((byte)(228)))));
            this.lblTitle.Location = new System.Drawing.Point(85, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(779, 50);
            this.lblTitle.TabIndex = 123;
            this.lblTitle.Text = "تعديل بيانات العميل";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 40;
            this.guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.linkLabel1);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.txtNotes);
            this.guna2Panel1.Controls.Add(this.numCreditLimit);
            this.guna2Panel1.Controls.Add(this.numDiscount);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.lblDiscount);
            this.guna2Panel1.Controls.Add(this.cbCustomerType);
            this.guna2Panel1.Controls.Add(this.lblCustomerType);
            this.guna2Panel1.Controls.Add(this.lblCreditLimit);
            this.guna2Panel1.Controls.Add(this.txtTotalDebt);
            this.guna2Panel1.Controls.Add(this.lblTotalDebt);
            this.guna2Panel1.Controls.Add(this.tsIsActive);
            this.guna2Panel1.Controls.Add(this.lblIsActive);
            this.guna2Panel1.Controls.Add(this.lblCustomerID);
            this.guna2Panel1.Controls.Add(this.labeld);
            this.guna2Panel1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.guna2Panel1.Location = new System.Drawing.Point(43, 500);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.guna2Panel1.Size = new System.Drawing.Size(821, 350);
            this.guna2Panel1.TabIndex = 124;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(626, 311);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(175, 29);
            this.linkLabel1.TabIndex = 29;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "عرض الفواتير السابقة";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(821, 48);
            this.label2.TabIndex = 28;
            this.label2.Text = "بيانات الحساب والعميل";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNotes
            // 
            this.txtNotes.BorderRadius = 5;
            this.txtNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNotes.DefaultText = "";
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNotes.Location = new System.Drawing.Point(50, 233);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.PlaceholderText = "";
            this.txtNotes.SelectedText = "";
            this.txtNotes.Size = new System.Drawing.Size(635, 62);
            this.txtNotes.TabIndex = 24;
            // 
            // numCreditLimit
            // 
            this.numCreditLimit.BackColor = System.Drawing.Color.White;
            this.numCreditLimit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.numCreditLimit.BorderRadius = 10;
            this.numCreditLimit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numCreditLimit.DecimalPlaces = 2;
            this.numCreditLimit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numCreditLimit.Location = new System.Drawing.Point(150, 130);
            this.numCreditLimit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numCreditLimit.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numCreditLimit.Name = "numCreditLimit";
            this.numCreditLimit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numCreditLimit.Size = new System.Drawing.Size(144, 36);
            this.numCreditLimit.TabIndex = 25;
            this.numCreditLimit.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(35)))), ((int)(((byte)(164)))));
            // 
            // numDiscount
            // 
            this.numDiscount.BackColor = System.Drawing.Color.White;
            this.numDiscount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.numDiscount.BorderRadius = 10;
            this.numDiscount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numDiscount.DecimalPlaces = 2;
            this.numDiscount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numDiscount.Location = new System.Drawing.Point(181, 180);
            this.numDiscount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numDiscount.Name = "numDiscount";
            this.numDiscount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numDiscount.Size = new System.Drawing.Size(113, 36);
            this.numDiscount.TabIndex = 26;
            this.numDiscount.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(35)))), ((int)(((byte)(164)))));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(695, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "ملاحظات:";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDiscount.Location = new System.Drawing.Point(300, 185);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(118, 25);
            this.lblDiscount.TabIndex = 14;
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
            this.cbCustomerType.Location = new System.Drawing.Point(455, 180);
            this.cbCustomerType.Name = "cbCustomerType";
            this.cbCustomerType.Size = new System.Drawing.Size(230, 36);
            this.cbCustomerType.TabIndex = 15;
            // 
            // lblCustomerType
            // 
            this.lblCustomerType.AutoSize = true;
            this.lblCustomerType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCustomerType.Location = new System.Drawing.Point(695, 185);
            this.lblCustomerType.Name = "lblCustomerType";
            this.lblCustomerType.Size = new System.Drawing.Size(86, 25);
            this.lblCustomerType.TabIndex = 16;
            this.lblCustomerType.Text = "نوع العميل:";
            // 
            // lblCreditLimit
            // 
            this.lblCreditLimit.AutoSize = true;
            this.lblCreditLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditLimit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCreditLimit.Location = new System.Drawing.Point(300, 130);
            this.lblCreditLimit.Name = "lblCreditLimit";
            this.lblCreditLimit.Size = new System.Drawing.Size(104, 25);
            this.lblCreditLimit.TabIndex = 17;
            this.lblCreditLimit.Text = "سقف الائتمان:";
            // 
            // txtTotalDebt
            // 
            this.txtTotalDebt.BorderRadius = 5;
            this.txtTotalDebt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalDebt.DefaultText = "0";
            this.txtTotalDebt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTotalDebt.Location = new System.Drawing.Point(505, 130);
            this.txtTotalDebt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotalDebt.Name = "txtTotalDebt";
            this.txtTotalDebt.PlaceholderText = "";
            this.txtTotalDebt.ReadOnly = true;
            this.txtTotalDebt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTotalDebt.SelectedText = "";
            this.txtTotalDebt.Size = new System.Drawing.Size(180, 36);
            this.txtTotalDebt.TabIndex = 18;
            // 
            // lblTotalDebt
            // 
            this.lblTotalDebt.AutoSize = true;
            this.lblTotalDebt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDebt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalDebt.Location = new System.Drawing.Point(695, 130);
            this.lblTotalDebt.Name = "lblTotalDebt";
            this.lblTotalDebt.Size = new System.Drawing.Size(106, 25);
            this.lblTotalDebt.TabIndex = 19;
            this.lblTotalDebt.Text = "إجمالي الديون:";
            // 
            // tsIsActive
            // 
            this.tsIsActive.Checked = true;
            this.tsIsActive.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tsIsActive.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tsIsActive.Location = new System.Drawing.Point(201, 75);
            this.tsIsActive.Name = "tsIsActive";
            this.tsIsActive.Size = new System.Drawing.Size(45, 23);
            this.tsIsActive.TabIndex = 20;
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIsActive.Location = new System.Drawing.Point(319, 73);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(100, 25);
            this.lblIsActive.TabIndex = 21;
            this.lblIsActive.Text = "حالة الحساب:";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCustomerID.ForeColor = System.Drawing.Color.Red;
            this.lblCustomerID.Location = new System.Drawing.Point(615, 75);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(44, 30);
            this.lblCustomerID.TabIndex = 22;
            this.lblCustomerID.Text = "[???]";
            // 
            // labeld
            // 
            this.labeld.AutoSize = true;
            this.labeld.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeld.ForeColor = System.Drawing.Color.Gray;
            this.labeld.Location = new System.Drawing.Point(697, 80);
            this.labeld.Name = "labeld";
            this.labeld.Size = new System.Drawing.Size(84, 25);
            this.labeld.TabIndex = 23;
            this.labeld.Text = "رقم العميل:";
            // 
            // ctrlPersonCardWithFilter1
            // 
            this.ctrlPersonCardWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(43, 74);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(854, 403);
            this.ctrlPersonCardWithFilter1.TabIndex = 0;
            this.ctrlPersonCardWithFilter1.PersonSelected += new System.EventHandler<PosAndAccountantProject.People.Controls.ctrlPersonCardWithFilter.PersonSelectedEventArgs>(this.ctrlPersonCardWithFilter1_PersonSelected);
            this.ctrlPersonCardWithFilter1.PersonNotFound += new System.EventHandler(this.ctrlPersonCardWithFilter1_PersonNotFound);
            // 
            // frmAddUpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(905, 913);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmAddUpdateCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة / تعديل عميل";
            this.Load += new System.EventHandler(this.frmAddUpdateCustomer_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCreditLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private People.Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtNotes;
        private Guna.UI2.WinForms.Guna2NumericUpDown numCreditLimit;
        private Guna.UI2.WinForms.Guna2NumericUpDown numDiscount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDiscount;
        private Guna.UI2.WinForms.Guna2ComboBox cbCustomerType;
        private System.Windows.Forms.Label lblCustomerType;
        private System.Windows.Forms.Label lblCreditLimit;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalDebt;
        private System.Windows.Forms.Label lblTotalDebt;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tsIsActive;
        private System.Windows.Forms.Label lblIsActive;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCustomerID;
        private System.Windows.Forms.Label labeld;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}