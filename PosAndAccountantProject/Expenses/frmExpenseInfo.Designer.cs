namespace PosAndAccountantProject.Expenses
{
    partial class frmExpenseInfo
    {
        private System.ComponentModel.IContainer components = null;


        private Guna.UI2.WinForms.Guna2Panel pnlMain;
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;


        private System.Windows.Forms.Label lblTitle;


        private System.Windows.Forms.Label lblExpenseID;
        private Guna.UI2.WinForms.Guna2TextBox txtExpenseID;


        private System.Windows.Forms.Label lblUserName;
        private Guna.UI2.WinForms.Guna2TextBox txtUserName;


        private System.Windows.Forms.Label lblExpenseType;
        private Guna.UI2.WinForms.Guna2TextBox txtExpenseType;


        private System.Windows.Forms.Label lblCreatedDate;
        private Guna.UI2.WinForms.Guna2TextBox txtCreatedDate;


        private System.Windows.Forms.Label lblAmount;
        private Guna.UI2.WinForms.Guna2TextBox txtAmount;


        private System.Windows.Forms.Label lblDescription;
        private Guna.UI2.WinForms.Guna2TextBox txtDescription;


        private Guna.UI2.WinForms.Guna2Button btnClose;



        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }



        private void InitializeComponent()
        {
            this.pnlMain = new Guna.UI2.WinForms.Guna2Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblExpenseID = new System.Windows.Forms.Label();
            this.txtExpenseID = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblExpenseType = new System.Windows.Forms.Label();
            this.txtExpenseType = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCreatedDate = new System.Windows.Forms.Label();
            this.txtCreatedDate = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.pnlMain.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BorderRadius = 20;
            this.pnlMain.Controls.Add(this.linkLabel1);
            this.pnlMain.Controls.Add(this.pnlHeader);
            this.pnlMain.Controls.Add(this.lblExpenseID);
            this.pnlMain.Controls.Add(this.txtExpenseID);
            this.pnlMain.Controls.Add(this.lblUserName);
            this.pnlMain.Controls.Add(this.txtUserName);
            this.pnlMain.Controls.Add(this.lblExpenseType);
            this.pnlMain.Controls.Add(this.txtExpenseType);
            this.pnlMain.Controls.Add(this.lblCreatedDate);
            this.pnlMain.Controls.Add(this.txtCreatedDate);
            this.pnlMain.Controls.Add(this.lblAmount);
            this.pnlMain.Controls.Add(this.txtAmount);
            this.pnlMain.Controls.Add(this.lblDescription);
            this.pnlMain.Controls.Add(this.txtDescription);
            this.pnlMain.Controls.Add(this.btnClose);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.FillColor = System.Drawing.Color.White;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(20);
            this.pnlMain.Size = new System.Drawing.Size(700, 520);
            this.pnlMain.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(97, 305);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(129, 20);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "تعديل بيانات المصروف";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BorderRadius = 15;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.pnlHeader.Location = new System.Drawing.Point(20, 20);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(660, 70);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(250, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(189, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "تفاصيل المصروف";
            // 
            // lblExpenseID
            // 
            this.lblExpenseID.AutoSize = true;
            this.lblExpenseID.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblExpenseID.Location = new System.Drawing.Point(520, 120);
            this.lblExpenseID.Name = "lblExpenseID";
            this.lblExpenseID.Size = new System.Drawing.Size(95, 20);
            this.lblExpenseID.TabIndex = 1;
            this.lblExpenseID.Text = "رقم المصروف";
            // 
            // txtExpenseID
            // 
            this.txtExpenseID.BorderRadius = 10;
            this.txtExpenseID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtExpenseID.DefaultText = "";
            this.txtExpenseID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtExpenseID.Location = new System.Drawing.Point(360, 145);
            this.txtExpenseID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtExpenseID.Name = "txtExpenseID";
            this.txtExpenseID.PlaceholderText = "";
            this.txtExpenseID.ReadOnly = true;
            this.txtExpenseID.SelectedText = "";
            this.txtExpenseID.Size = new System.Drawing.Size(260, 40);
            this.txtExpenseID.TabIndex = 2;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblUserName.Location = new System.Drawing.Point(520, 200);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(101, 20);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "اسم المستخدم";
            // 
            // txtUserName
            // 
            this.txtUserName.BorderRadius = 10;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.DefaultText = "";
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUserName.Location = new System.Drawing.Point(360, 225);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PlaceholderText = "";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.SelectedText = "";
            this.txtUserName.Size = new System.Drawing.Size(260, 40);
            this.txtUserName.TabIndex = 4;
            // 
            // lblExpenseType
            // 
            this.lblExpenseType.AutoSize = true;
            this.lblExpenseType.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblExpenseType.Location = new System.Drawing.Point(520, 280);
            this.lblExpenseType.Name = "lblExpenseType";
            this.lblExpenseType.Size = new System.Drawing.Size(95, 20);
            this.lblExpenseType.TabIndex = 5;
            this.lblExpenseType.Text = "نوع المصروف";
            // 
            // txtExpenseType
            // 
            this.txtExpenseType.BorderRadius = 10;
            this.txtExpenseType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtExpenseType.DefaultText = "";
            this.txtExpenseType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtExpenseType.Location = new System.Drawing.Point(360, 305);
            this.txtExpenseType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtExpenseType.Name = "txtExpenseType";
            this.txtExpenseType.PlaceholderText = "";
            this.txtExpenseType.ReadOnly = true;
            this.txtExpenseType.SelectedText = "";
            this.txtExpenseType.Size = new System.Drawing.Size(260, 40);
            this.txtExpenseType.TabIndex = 6;
            // 
            // lblCreatedDate
            // 
            this.lblCreatedDate.AutoSize = true;
            this.lblCreatedDate.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblCreatedDate.Location = new System.Drawing.Point(180, 120);
            this.lblCreatedDate.Name = "lblCreatedDate";
            this.lblCreatedDate.Size = new System.Drawing.Size(84, 20);
            this.lblCreatedDate.TabIndex = 7;
            this.lblCreatedDate.Text = "تاريخ الإنشاء";
            // 
            // txtCreatedDate
            // 
            this.txtCreatedDate.BorderRadius = 10;
            this.txtCreatedDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCreatedDate.DefaultText = "";
            this.txtCreatedDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCreatedDate.Location = new System.Drawing.Point(40, 145);
            this.txtCreatedDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCreatedDate.Name = "txtCreatedDate";
            this.txtCreatedDate.PlaceholderText = "";
            this.txtCreatedDate.ReadOnly = true;
            this.txtCreatedDate.SelectedText = "";
            this.txtCreatedDate.Size = new System.Drawing.Size(260, 40);
            this.txtCreatedDate.TabIndex = 8;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblAmount.Location = new System.Drawing.Point(180, 200);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(46, 20);
            this.lblAmount.TabIndex = 9;
            this.lblAmount.Text = "المبلغ";
            // 
            // txtAmount
            // 
            this.txtAmount.BorderRadius = 10;
            this.txtAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmount.DefaultText = "";
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAmount.Location = new System.Drawing.Point(40, 225);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PlaceholderText = "";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.SelectedText = "";
            this.txtAmount.Size = new System.Drawing.Size(260, 40);
            this.txtAmount.TabIndex = 10;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblDescription.Location = new System.Drawing.Point(520, 370);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(56, 20);
            this.lblDescription.TabIndex = 11;
            this.lblDescription.Text = "الوصف";
            // 
            // txtDescription
            // 
            this.txtDescription.BorderRadius = 12;
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.DefaultText = "";
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDescription.Location = new System.Drawing.Point(40, 395);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PlaceholderText = "";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.SelectedText = "";
            this.txtDescription.Size = new System.Drawing.Size(580, 60);
            this.txtDescription.TabIndex = 12;
            // 
            // btnClose
            // 
            this.btnClose.BorderRadius = 12;
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(280, 470);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(140, 40);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "إغلاق";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmExpenseInfo
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 520);
            this.Controls.Add(this.pnlMain);
            this.Name = "frmExpenseInfo";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "معلومات المصروف";
            this.Load += new System.EventHandler(this.frmExpenseInfo_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}