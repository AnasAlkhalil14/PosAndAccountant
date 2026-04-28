namespace PosAndAccountantProject.Suppliers
{
    partial class frmAddUpdateSupplier
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
            this.ctrlPersonCardWithFilter1 = new PosAndAccountantProject.People.Controls.ctrlPersonCardWithFilter();
            this.lnkShowLastPurchases = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNotes = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.txtTotalDebt = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTotalDebt = new System.Windows.Forms.Label();
            this.tsIsActive = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.lblCustomerID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labeld = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lnkMakeOrder = new System.Windows.Forms.LinkLabel();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlPersonCardWithFilter1
            // 
            this.ctrlPersonCardWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(25, 75);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(854, 403);
            this.ctrlPersonCardWithFilter1.TabIndex = 125;
            this.ctrlPersonCardWithFilter1.PersonSelected += new System.EventHandler<PosAndAccountantProject.People.Controls.ctrlPersonCardWithFilter.PersonSelectedEventArgs>(this.ctrlPersonCardWithFilter1_PersonSelected);
            this.ctrlPersonCardWithFilter1.PersonNotFound += new System.EventHandler(this.ctrlPersonCardWithFilter1_PersonNotFound);
            // 
            // lnkShowLastPurchases
            // 
            this.lnkShowLastPurchases.AutoSize = true;
            this.lnkShowLastPurchases.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkShowLastPurchases.Location = new System.Drawing.Point(626, 275);
            this.lnkShowLastPurchases.Name = "lnkShowLastPurchases";
            this.lnkShowLastPurchases.Size = new System.Drawing.Size(175, 29);
            this.lnkShowLastPurchases.TabIndex = 29;
            this.lnkShowLastPurchases.TabStop = true;
            this.lnkShowLastPurchases.Text = "عرض الفواتير السابقة";
            this.lnkShowLastPurchases.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkShowLastPurchases_LinkClicked);
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
            this.label2.Text = "بيانات الحساب والمورد";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNotes
            // 
            this.txtNotes.BorderRadius = 5;
            this.txtNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNotes.DefaultText = "";
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNotes.Location = new System.Drawing.Point(52, 192);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.PlaceholderText = "";
            this.txtNotes.SelectedText = "";
            this.txtNotes.Size = new System.Drawing.Size(635, 62);
            this.txtNotes.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(697, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "ملاحظات:";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(114)))), ((int)(((byte)(228)))));
            this.lblTitle.Location = new System.Drawing.Point(67, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(779, 50);
            this.lblTitle.TabIndex = 128;
            this.lblTitle.Text = "تعديل بيانات المورد";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.BorderRadius = 8;
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(524, 857);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(140, 45);
            this.btnClose.TabIndex = 126;
            this.btnClose.Text = "إغلاق";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.labeld.Size = new System.Drawing.Size(86, 25);
            this.labeld.TabIndex = 23;
            this.labeld.Text = "رقم المورد:";
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
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.txtTotalDebt);
            this.guna2Panel1.Controls.Add(this.lblTotalDebt);
            this.guna2Panel1.Controls.Add(this.tsIsActive);
            this.guna2Panel1.Controls.Add(this.lblIsActive);
            this.guna2Panel1.Controls.Add(this.lblCustomerID);
            this.guna2Panel1.Controls.Add(this.labeld);
            this.guna2Panel1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.guna2Panel1.Location = new System.Drawing.Point(44, 501);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.guna2Panel1.Size = new System.Drawing.Size(821, 331);
            this.guna2Panel1.TabIndex = 129;
            // 
            // lnkMakeOrder
            // 
            this.lnkMakeOrder.AutoSize = true;
            this.lnkMakeOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkMakeOrder.Location = new System.Drawing.Point(19, 275);
            this.lnkMakeOrder.Name = "lnkMakeOrder";
            this.lnkMakeOrder.Size = new System.Drawing.Size(143, 29);
            this.lnkMakeOrder.TabIndex = 30;
            this.lnkMakeOrder.TabStop = true;
            this.lnkMakeOrder.Text = "انشاء فاتورة شراء";
            this.lnkMakeOrder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkMakeOrder_LinkClicked);
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 8;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(220, 862);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 45);
            this.btnSave.TabIndex = 127;
            this.btnSave.Text = "حفظ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddUpdateSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(905, 919);
            this.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "frmAddUpdateSupplier";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة / تعديل مورد";
            this.Load += new System.EventHandler(this.frmAddUpdateSupplier_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private People.Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private System.Windows.Forms.LinkLabel lnkShowLastPurchases;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtNotes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalDebt;
        private System.Windows.Forms.Label lblTotalDebt;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tsIsActive;
        private System.Windows.Forms.Label lblIsActive;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCustomerID;
        private System.Windows.Forms.Label labeld;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.LinkLabel lnkMakeOrder;
    }
}