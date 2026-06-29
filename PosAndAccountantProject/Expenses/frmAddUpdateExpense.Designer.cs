namespace PosAndAccountantProject.Expenses
{
    partial class frmAddUpdateExpense
    {
        private System.ComponentModel.IContainer components = null;

        private Guna.UI2.WinForms.Guna2Panel pnlMain;
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;

        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.Label lblExpenseID;
        private Guna.UI2.WinForms.Guna2TextBox txtExpenseID;

        private System.Windows.Forms.Label lblExpenseType;
        private Guna.UI2.WinForms.Guna2ComboBox cmbExpenseType;

        private System.Windows.Forms.Label lblCreatedDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpCreatedDate;

        private System.Windows.Forms.Label lblAmount;
        private Guna.UI2.WinForms.Guna2TextBox txtAmount;

        private System.Windows.Forms.Label lblNotes;
        private Guna.UI2.WinForms.Guna2TextBox txtNotes;


        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnCancel;



        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }



        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlMain = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTypeName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTypeNote = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblExpenseID = new System.Windows.Forms.Label();
            this.txtExpenseID = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblExpenseType = new System.Windows.Forms.Label();
            this.cmbExpenseType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblCreatedDate = new System.Windows.Forms.Label();
            this.dtpCreatedDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlMain.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BorderRadius = 20;
            this.pnlMain.Controls.Add(this.guna2VSeparator1);
            this.pnlMain.Controls.Add(this.guna2GroupBox1);
            this.pnlMain.Controls.Add(this.pnlHeader);
            this.pnlMain.Controls.Add(this.lblExpenseID);
            this.pnlMain.Controls.Add(this.txtExpenseID);
            this.pnlMain.Controls.Add(this.lblExpenseType);
            this.pnlMain.Controls.Add(this.cmbExpenseType);
            this.pnlMain.Controls.Add(this.lblCreatedDate);
            this.pnlMain.Controls.Add(this.dtpCreatedDate);
            this.pnlMain.Controls.Add(this.lblAmount);
            this.pnlMain.Controls.Add(this.txtAmount);
            this.pnlMain.Controls.Add(this.lblNotes);
            this.pnlMain.Controls.Add(this.txtNotes);
            this.pnlMain.Controls.Add(this.btnSave);
            this.pnlMain.Controls.Add(this.btnCancel);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.FillColor = System.Drawing.Color.White;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(20);
            this.pnlMain.Size = new System.Drawing.Size(826, 475);
            this.pnlMain.TabIndex = 0;
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Location = new System.Drawing.Point(345, 0);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(19, 473);
            this.guna2VSeparator1.TabIndex = 13;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderRadius = 10;
            this.guna2GroupBox1.Controls.Add(this.guna2Button1);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.txtTypeName);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.Controls.Add(this.txtTypeNote);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Blue;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(335, 375);
            this.guna2GroupBox1.TabIndex = 1;
            this.guna2GroupBox1.Text = "اضافة نوع مصروف";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 12;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(169, 298);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(140, 45);
            this.guna2Button1.TabIndex = 15;
            this.guna2Button1.Text = "اضافة";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(223, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "اسم النوع";
            // 
            // txtTypeName
            // 
            this.txtTypeName.BorderRadius = 12;
            this.txtTypeName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTypeName.DefaultText = "";
            this.txtTypeName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTypeName.Location = new System.Drawing.Point(24, 105);
            this.txtTypeName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTypeName.Multiline = true;
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.PlaceholderText = "";
            this.txtTypeName.SelectedText = "";
            this.txtTypeName.Size = new System.Drawing.Size(276, 53);
            this.txtTypeName.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(233, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "شرح عن النوع";
            // 
            // txtTypeNote
            // 
            this.txtTypeNote.BorderRadius = 12;
            this.txtTypeNote.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTypeNote.DefaultText = "";
            this.txtTypeNote.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTypeNote.Location = new System.Drawing.Point(24, 190);
            this.txtTypeNote.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTypeNote.Multiline = true;
            this.txtTypeNote.Name = "txtTypeNote";
            this.txtTypeNote.PlaceholderText = "";
            this.txtTypeNote.SelectedText = "";
            this.txtTypeNote.Size = new System.Drawing.Size(276, 80);
            this.txtTypeNote.TabIndex = 12;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BorderRadius = 15;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.pnlHeader.Location = new System.Drawing.Point(353, 12);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(468, 70);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(180, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTitle.Size = new System.Drawing.Size(203, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "اضافة مصروف";
            // 
            // lblExpenseID
            // 
            this.lblExpenseID.AutoSize = true;
            this.lblExpenseID.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblExpenseID.Location = new System.Drawing.Point(668, 107);
            this.lblExpenseID.Name = "lblExpenseID";
            this.lblExpenseID.Size = new System.Drawing.Size(118, 25);
            this.lblExpenseID.TabIndex = 1;
            this.lblExpenseID.Text = "رقم المصروف";
            // 
            // txtExpenseID
            // 
            this.txtExpenseID.BorderRadius = 10;
            this.txtExpenseID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtExpenseID.DefaultText = "";
            this.txtExpenseID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtExpenseID.Location = new System.Drawing.Point(622, 132);
            this.txtExpenseID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtExpenseID.Name = "txtExpenseID";
            this.txtExpenseID.PlaceholderText = "تلقائي";
            this.txtExpenseID.ReadOnly = true;
            this.txtExpenseID.SelectedText = "";
            this.txtExpenseID.Size = new System.Drawing.Size(137, 40);
            this.txtExpenseID.TabIndex = 2;
            // 
            // lblExpenseType
            // 
            this.lblExpenseType.AutoSize = true;
            this.lblExpenseType.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblExpenseType.Location = new System.Drawing.Point(677, 189);
            this.lblExpenseType.Name = "lblExpenseType";
            this.lblExpenseType.Size = new System.Drawing.Size(119, 25);
            this.lblExpenseType.TabIndex = 3;
            this.lblExpenseType.Text = "نوع المصروف";
            // 
            // cmbExpenseType
            // 
            this.cmbExpenseType.BackColor = System.Drawing.Color.Transparent;
            this.cmbExpenseType.BorderRadius = 10;
            this.cmbExpenseType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbExpenseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExpenseType.FocusedColor = System.Drawing.Color.Empty;
            this.cmbExpenseType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbExpenseType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbExpenseType.ItemHeight = 30;
            this.cmbExpenseType.Location = new System.Drawing.Point(622, 216);
            this.cmbExpenseType.Name = "cmbExpenseType";
            this.cmbExpenseType.Size = new System.Drawing.Size(137, 36);
            this.cmbExpenseType.TabIndex = 4;
            this.cmbExpenseType.SelectedIndexChanged += new System.EventHandler(this.cmbExpenseType_SelectedIndexChanged);
            // 
            // lblCreatedDate
            // 
            this.lblCreatedDate.AutoSize = true;
            this.lblCreatedDate.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblCreatedDate.Location = new System.Drawing.Point(457, 107);
            this.lblCreatedDate.Name = "lblCreatedDate";
            this.lblCreatedDate.Size = new System.Drawing.Size(129, 25);
            this.lblCreatedDate.TabIndex = 5;
            this.lblCreatedDate.Text = "تاريخ المصروف";
            // 
            // dtpCreatedDate
            // 
            this.dtpCreatedDate.BorderRadius = 10;
            this.dtpCreatedDate.Checked = true;
            this.dtpCreatedDate.Enabled = false;
            this.dtpCreatedDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpCreatedDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpCreatedDate.Location = new System.Drawing.Point(393, 132);
            this.dtpCreatedDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpCreatedDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpCreatedDate.Name = "dtpCreatedDate";
            this.dtpCreatedDate.Size = new System.Drawing.Size(150, 40);
            this.dtpCreatedDate.TabIndex = 6;
            this.dtpCreatedDate.Value = new System.DateTime(2026, 6, 19, 20, 33, 2, 776);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblAmount.Location = new System.Drawing.Point(501, 189);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(57, 25);
            this.lblAmount.TabIndex = 7;
            this.lblAmount.Text = "المبلغ";
            // 
            // txtAmount
            // 
            this.txtAmount.BorderRadius = 10;
            this.txtAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmount.DefaultText = "";
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAmount.Location = new System.Drawing.Point(393, 212);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PlaceholderText = "0.00";
            this.txtAmount.SelectedText = "";
            this.txtAmount.Size = new System.Drawing.Size(137, 40);
            this.txtAmount.TabIndex = 8;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            this.txtAmount.Validating += new System.ComponentModel.CancelEventHandler(this.txtAmount_Validating);
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblNotes.Location = new System.Drawing.Point(705, 276);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(83, 25);
            this.lblNotes.TabIndex = 9;
            this.lblNotes.Text = "ملاحظات";
            // 
            // txtNotes
            // 
            this.txtNotes.BorderRadius = 12;
            this.txtNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNotes.DefaultText = "";
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNotes.Location = new System.Drawing.Point(406, 299);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.PlaceholderText = "";
            this.txtNotes.SelectedText = "";
            this.txtNotes.Size = new System.Drawing.Size(353, 80);
            this.txtNotes.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 12;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(628, 414);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 45);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "حفظ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BorderRadius = 12;
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(416, 414);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 45);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "إلغاء";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddUpdateExpense
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(826, 475);
            this.Controls.Add(this.pnlMain);
            this.Name = "frmAddUpdateExpense";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة / تعديل مصروف";
            this.Load += new System.EventHandler(this.frmAddUpdateExpense_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtTypeNote;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtTypeName;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}