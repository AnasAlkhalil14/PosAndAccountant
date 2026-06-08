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
            this.numCreditLimit = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.numDiscount = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.tsIsActive = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.ctrlPersonCardWithFilter1 = new PosAndAccountantProject.People.Controls.ctrlPersonCardWithFilter();
            this.labeld = new System.Windows.Forms.Label();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.lblTotalDebt = new System.Windows.Forms.Label();
            this.txtTotalDebt = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCreditLimit = new System.Windows.Forms.Label();
            this.lblCustomerType = new System.Windows.Forms.Label();
            this.cbCustomerType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNotes = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lnkShowLastPurchases = new System.Windows.Forms.LinkLabel();
            this.lnkMakeOrder = new System.Windows.Forms.LinkLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCustomerID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numCreditLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 8;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(202, 696);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 37);
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
            this.btnClose.Location = new System.Drawing.Point(380, 696);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 37);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "إغلاق";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(114)))), ((int)(((byte)(228)))));
            this.lblTitle.Location = new System.Drawing.Point(64, 7);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(584, 41);
            this.lblTitle.TabIndex = 123;
            this.lblTitle.Text = "تعديل بيانات العميل";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numCreditLimit
            // 
            this.numCreditLimit.BackColor = System.Drawing.Color.White;
            this.numCreditLimit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.numCreditLimit.BorderRadius = 10;
            this.numCreditLimit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numCreditLimit.DecimalPlaces = 2;
            this.numCreditLimit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numCreditLimit.Location = new System.Drawing.Point(112, 106);
            this.numCreditLimit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.numCreditLimit.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numCreditLimit.Name = "numCreditLimit";
            this.numCreditLimit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numCreditLimit.Size = new System.Drawing.Size(108, 29);
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
            this.numDiscount.Location = new System.Drawing.Point(136, 146);
            this.numDiscount.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.numDiscount.Name = "numDiscount";
            this.numDiscount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numDiscount.Size = new System.Drawing.Size(85, 29);
            this.numDiscount.TabIndex = 26;
            this.numDiscount.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(35)))), ((int)(((byte)(164)))));
            // 
            // tsIsActive
            // 
            this.tsIsActive.Checked = true;
            this.tsIsActive.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tsIsActive.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tsIsActive.Location = new System.Drawing.Point(151, 61);
            this.tsIsActive.Margin = new System.Windows.Forms.Padding(2);
            this.tsIsActive.Name = "tsIsActive";
            this.tsIsActive.Size = new System.Drawing.Size(34, 19);
            this.tsIsActive.TabIndex = 20;
            // 
            // ctrlPersonCardWithFilter1
            // 
            this.ctrlPersonCardWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(11, 63);
            this.ctrlPersonCardWithFilter1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(640, 327);
            this.ctrlPersonCardWithFilter1.TabIndex = 0;
            this.ctrlPersonCardWithFilter1.PersonSelected += new System.EventHandler<PosAndAccountantProject.People.Controls.ctrlPersonCardWithFilter.PersonSelectedEventArgs>(this.ctrlPersonCardWithFilter1_PersonSelected);
            this.ctrlPersonCardWithFilter1.PersonNotFound += new System.EventHandler(this.ctrlPersonCardWithFilter1_PersonNotFound);
            // 
            // labeld
            // 
            this.labeld.AutoSize = true;
            this.labeld.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeld.ForeColor = System.Drawing.Color.Gray;
            this.labeld.Location = new System.Drawing.Point(523, 65);
            this.labeld.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labeld.Name = "labeld";
            this.labeld.Size = new System.Drawing.Size(64, 20);
            this.labeld.TabIndex = 23;
            this.labeld.Text = "رقم العميل:";
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIsActive.Location = new System.Drawing.Point(239, 59);
            this.lblIsActive.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(78, 20);
            this.lblIsActive.TabIndex = 21;
            this.lblIsActive.Text = "حالة الحساب:";
            // 
            // lblTotalDebt
            // 
            this.lblTotalDebt.AutoSize = true;
            this.lblTotalDebt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDebt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalDebt.Location = new System.Drawing.Point(521, 106);
            this.lblTotalDebt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalDebt.Name = "lblTotalDebt";
            this.lblTotalDebt.Size = new System.Drawing.Size(81, 20);
            this.lblTotalDebt.TabIndex = 19;
            this.lblTotalDebt.Text = "إجمالي الديون:";
            // 
            // txtTotalDebt
            // 
            this.txtTotalDebt.BorderRadius = 5;
            this.txtTotalDebt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalDebt.DefaultText = "0";
            this.txtTotalDebt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTotalDebt.Location = new System.Drawing.Point(379, 106);
            this.txtTotalDebt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTotalDebt.Name = "txtTotalDebt";
            this.txtTotalDebt.PlaceholderText = "";
            this.txtTotalDebt.ReadOnly = true;
            this.txtTotalDebt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTotalDebt.SelectedText = "";
            this.txtTotalDebt.Size = new System.Drawing.Size(135, 29);
            this.txtTotalDebt.TabIndex = 18;
            // 
            // lblCreditLimit
            // 
            this.lblCreditLimit.AutoSize = true;
            this.lblCreditLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditLimit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCreditLimit.Location = new System.Drawing.Point(225, 106);
            this.lblCreditLimit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCreditLimit.Name = "lblCreditLimit";
            this.lblCreditLimit.Size = new System.Drawing.Size(82, 20);
            this.lblCreditLimit.TabIndex = 17;
            this.lblCreditLimit.Text = "سقف الائتمان:";
            // 
            // lblCustomerType
            // 
            this.lblCustomerType.AutoSize = true;
            this.lblCustomerType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCustomerType.Location = new System.Drawing.Point(521, 150);
            this.lblCustomerType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerType.Name = "lblCustomerType";
            this.lblCustomerType.Size = new System.Drawing.Size(67, 20);
            this.lblCustomerType.TabIndex = 16;
            this.lblCustomerType.Text = "نوع العميل:";
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
            this.cbCustomerType.Location = new System.Drawing.Point(341, 146);
            this.cbCustomerType.Margin = new System.Windows.Forms.Padding(2);
            this.cbCustomerType.Name = "cbCustomerType";
            this.cbCustomerType.Size = new System.Drawing.Size(174, 36);
            this.cbCustomerType.TabIndex = 15;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDiscount.Location = new System.Drawing.Point(225, 150);
            this.lblDiscount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(93, 20);
            this.lblDiscount.TabIndex = 14;
            this.lblDiscount.Text = "نسبة الخصم %:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(521, 189);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "ملاحظات:";
            // 
            // txtNotes
            // 
            this.txtNotes.BorderRadius = 5;
            this.txtNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNotes.DefaultText = "";
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNotes.Location = new System.Drawing.Point(38, 189);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.PlaceholderText = "";
            this.txtNotes.SelectedText = "";
            this.txtNotes.Size = new System.Drawing.Size(476, 50);
            this.txtNotes.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(616, 39);
            this.label2.TabIndex = 28;
            this.label2.Text = "بيانات الحساب والعميل";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lnkShowLastPurchases
            // 
            this.lnkShowLastPurchases.AutoSize = true;
            this.lnkShowLastPurchases.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkShowLastPurchases.Location = new System.Drawing.Point(470, 253);
            this.lnkShowLastPurchases.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkShowLastPurchases.Name = "lnkShowLastPurchases";
            this.lnkShowLastPurchases.Size = new System.Drawing.Size(143, 24);
            this.lnkShowLastPurchases.TabIndex = 29;
            this.lnkShowLastPurchases.TabStop = true;
            this.lnkShowLastPurchases.Text = "عرض الفواتير السابقة";
            this.lnkShowLastPurchases.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lnkMakeOrder
            // 
            this.lnkMakeOrder.AutoSize = true;
            this.lnkMakeOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkMakeOrder.Location = new System.Drawing.Point(38, 253);
            this.lnkMakeOrder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkMakeOrder.Name = "lnkMakeOrder";
            this.lnkMakeOrder.Size = new System.Drawing.Size(113, 24);
            this.lnkMakeOrder.TabIndex = 31;
            this.lnkMakeOrder.TabStop = true;
            this.lnkMakeOrder.Text = "انشاء فاتورة مبيع";
            this.lnkMakeOrder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkMakeOrder_LinkClicked);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 40;
            this.guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.lnkMakeOrder);
            this.guna2Panel1.Controls.Add(this.lnkShowLastPurchases);
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
            this.guna2Panel1.Location = new System.Drawing.Point(32, 406);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.guna2Panel1.Size = new System.Drawing.Size(616, 284);
            this.guna2Panel1.TabIndex = 124;
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCustomerID.ForeColor = System.Drawing.Color.Red;
            this.lblCustomerID.Location = new System.Drawing.Point(461, 61);
            this.lblCustomerID.Margin = new System.Windows.Forms.Padding(2);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(36, 23);
            this.lblCustomerID.TabIndex = 22;
            this.lblCustomerID.Text = "[???]";
            // 
            // frmAddUpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(679, 742);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmAddUpdateCustomer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة / تعديل عميل";
            this.Load += new System.EventHandler(this.frmAddUpdateCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCreditLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private People.Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2NumericUpDown numCreditLimit;
        private Guna.UI2.WinForms.Guna2NumericUpDown numDiscount;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tsIsActive;
        private System.Windows.Forms.Label labeld;
        private System.Windows.Forms.Label lblIsActive;
        private System.Windows.Forms.Label lblTotalDebt;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalDebt;
        private System.Windows.Forms.Label lblCreditLimit;
        private System.Windows.Forms.Label lblCustomerType;
        private Guna.UI2.WinForms.Guna2ComboBox cbCustomerType;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtNotes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lnkShowLastPurchases;
        private System.Windows.Forms.LinkLabel lnkMakeOrder;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCustomerID;
    }
}