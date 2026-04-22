

namespace PosAndAccountantProject.Users
{
    partial class frmAddUpdatUser
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
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.tcUserInfo = new Guna.UI2.WinForms.Guna2TabControl();
            this.tpPersonalInfo = new System.Windows.Forms.TabPage();
            this.ctrlPersonCardWithFilter1 = new PosAndAccountantProject.People.Controls.ctrlPersonCardWithFilter();
            this.btnPersonInfoNext = new Guna.UI2.WinForms.Guna2Button();
            this.tpLoginInfo = new System.Windows.Forms.TabPage();
            this.btnPrevious = new Guna.UI2.WinForms.Guna2Button();
            this.gbForPermissions = new Guna.UI2.WinForms.Guna2GroupBox();
            this.chbManageTransaction = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chbManageReturn = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chbManageBooking = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chbManageVehicles = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chbManageUsers = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chbManageCustomer = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chbAllPermission = new Guna.UI2.WinForms.Guna2CheckBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkIsActive = new Guna.UI2.WinForms.Guna2CheckBox();
            this.txtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tcUserInfo.SuspendLayout();
            this.tpPersonalInfo.SuspendLayout();
            this.tpLoginInfo.SuspendLayout();
            this.gbForPermissions.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(114)))), ((int)(((byte)(228)))));
            this.lblTitle.Location = new System.Drawing.Point(142, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(863, 50);
            this.lblTitle.TabIndex = 122;
            this.lblTitle.Text = "تعديل بيانات المستخدم";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tcUserInfo
            // 
            this.tcUserInfo.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tcUserInfo.Controls.Add(this.tpPersonalInfo);
            this.tcUserInfo.Controls.Add(this.tpLoginInfo);
            this.tcUserInfo.ItemSize = new System.Drawing.Size(180, 40);
            this.tcUserInfo.Location = new System.Drawing.Point(5, 95);
            this.tcUserInfo.Name = "tcUserInfo";
            this.tcUserInfo.SelectedIndex = 0;
            this.tcUserInfo.Size = new System.Drawing.Size(1143, 540);
            this.tcUserInfo.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tcUserInfo.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcUserInfo.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcUserInfo.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tcUserInfo.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcUserInfo.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tcUserInfo.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcUserInfo.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcUserInfo.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tcUserInfo.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcUserInfo.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tcUserInfo.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tcUserInfo.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcUserInfo.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tcUserInfo.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tcUserInfo.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tcUserInfo.TabIndex = 121;
            this.tcUserInfo.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            // 
            // tpPersonalInfo
            // 
            this.tpPersonalInfo.BackColor = System.Drawing.Color.White;
            this.tpPersonalInfo.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.tpPersonalInfo.Controls.Add(this.btnPersonInfoNext);
            this.tpPersonalInfo.Location = new System.Drawing.Point(184, 4);
            this.tpPersonalInfo.Name = "tpPersonalInfo";
            this.tpPersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonalInfo.Size = new System.Drawing.Size(955, 532);
            this.tpPersonalInfo.TabIndex = 0;
            this.tpPersonalInfo.Text = "المعلومات الشخصية";
            // 
            // ctrlPersonCardWithFilter1
            // 
            this.ctrlPersonCardWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(15, 15);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(846, 400);
            this.ctrlPersonCardWithFilter1.TabIndex = 120;
            this.ctrlPersonCardWithFilter1.PersonSelected += new System.EventHandler<PosAndAccountantProject.People.Controls.ctrlPersonCardWithFilter.PersonSelectedEventArgs>(this.ctrlPersonCardWithFilter1_PersonSelected);
            this.ctrlPersonCardWithFilter1.PersonNotFound += new System.EventHandler(this.ctrlPersonCardWithFilter1_PersonNotFound);
            // 
            // btnPersonInfoNext
            // 
            this.btnPersonInfoNext.BorderRadius = 5;
            this.btnPersonInfoNext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(114)))), ((int)(((byte)(228)))));
            this.btnPersonInfoNext.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPersonInfoNext.ForeColor = System.Drawing.Color.White;
            this.btnPersonInfoNext.Location = new System.Drawing.Point(20, 470);
            this.btnPersonInfoNext.Name = "btnPersonInfoNext";
            this.btnPersonInfoNext.Size = new System.Drawing.Size(130, 45);
            this.btnPersonInfoNext.TabIndex = 119;
            this.btnPersonInfoNext.Text = "التالي";
            this.btnPersonInfoNext.Click += new System.EventHandler(this.btnPersonInfoNext_Click);
            // 
            // tpLoginInfo
            // 
            this.tpLoginInfo.BackColor = System.Drawing.Color.White;
            this.tpLoginInfo.Controls.Add(this.btnPrevious);
            this.tpLoginInfo.Controls.Add(this.gbForPermissions);
            this.tpLoginInfo.Controls.Add(this.lblUserID);
            this.tpLoginInfo.Controls.Add(this.label4);
            this.tpLoginInfo.Controls.Add(this.chkIsActive);
            this.tpLoginInfo.Controls.Add(this.txtUserName);
            this.tpLoginInfo.Controls.Add(this.txtConfirmPassword);
            this.tpLoginInfo.Controls.Add(this.label1);
            this.tpLoginInfo.Controls.Add(this.label3);
            this.tpLoginInfo.Controls.Add(this.label2);
            this.tpLoginInfo.Controls.Add(this.txtPassword);
            this.tpLoginInfo.Location = new System.Drawing.Point(184, 4);
            this.tpLoginInfo.Name = "tpLoginInfo";
            this.tpLoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpLoginInfo.Size = new System.Drawing.Size(955, 532);
            this.tpLoginInfo.TabIndex = 1;
            this.tpLoginInfo.Text = "بيانات الحساب";
            // 
            // btnPrevious
            // 
            this.btnPrevious.BorderRadius = 5;
            this.btnPrevious.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(114)))), ((int)(((byte)(228)))));
            this.btnPrevious.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Location = new System.Drawing.Point(26, 471);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(130, 45);
            this.btnPrevious.TabIndex = 131;
            this.btnPrevious.Text = "السابق";
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // gbForPermissions
            // 
            this.gbForPermissions.BackColor = System.Drawing.Color.White;
            this.gbForPermissions.BorderColor = System.Drawing.Color.Black;
            this.gbForPermissions.BorderRadius = 20;
            this.gbForPermissions.Controls.Add(this.chbManageTransaction);
            this.gbForPermissions.Controls.Add(this.chbManageReturn);
            this.gbForPermissions.Controls.Add(this.chbManageBooking);
            this.gbForPermissions.Controls.Add(this.chbManageVehicles);
            this.gbForPermissions.Controls.Add(this.chbManageUsers);
            this.gbForPermissions.Controls.Add(this.label5);
            this.gbForPermissions.Controls.Add(this.chbManageCustomer);
            this.gbForPermissions.Controls.Add(this.chbAllPermission);
            this.gbForPermissions.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(14)))), ((int)(((byte)(150)))));
            this.gbForPermissions.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbForPermissions.ForeColor = System.Drawing.Color.Black;
            this.gbForPermissions.Location = new System.Drawing.Point(159, 49);
            this.gbForPermissions.Name = "gbForPermissions";
            this.gbForPermissions.Size = new System.Drawing.Size(262, 311);
            this.gbForPermissions.TabIndex = 130;
            // 
            // chbManageTransaction
            // 
            this.chbManageTransaction.AutoSize = true;
            this.chbManageTransaction.Checked = true;
            this.chbManageTransaction.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbManageTransaction.CheckedState.BorderRadius = 0;
            this.chbManageTransaction.CheckedState.BorderThickness = 0;
            this.chbManageTransaction.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbManageTransaction.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbManageTransaction.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbManageTransaction.ForeColor = System.Drawing.Color.Black;
            this.chbManageTransaction.Location = new System.Drawing.Point(17, 275);
            this.chbManageTransaction.Name = "chbManageTransaction";
            this.chbManageTransaction.Size = new System.Drawing.Size(208, 32);
            this.chbManageTransaction.TabIndex = 12;
            this.chbManageTransaction.Text = "Manage Transaction";
            this.chbManageTransaction.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbManageTransaction.UncheckedState.BorderRadius = 0;
            this.chbManageTransaction.UncheckedState.BorderThickness = 0;
            this.chbManageTransaction.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // chbManageReturn
            // 
            this.chbManageReturn.AutoSize = true;
            this.chbManageReturn.Checked = true;
            this.chbManageReturn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbManageReturn.CheckedState.BorderRadius = 0;
            this.chbManageReturn.CheckedState.BorderThickness = 0;
            this.chbManageReturn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbManageReturn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbManageReturn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbManageReturn.ForeColor = System.Drawing.Color.Black;
            this.chbManageReturn.Location = new System.Drawing.Point(17, 237);
            this.chbManageReturn.Name = "chbManageReturn";
            this.chbManageReturn.Size = new System.Drawing.Size(167, 32);
            this.chbManageReturn.TabIndex = 11;
            this.chbManageReturn.Text = "Manage Return";
            this.chbManageReturn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbManageReturn.UncheckedState.BorderRadius = 0;
            this.chbManageReturn.UncheckedState.BorderThickness = 0;
            this.chbManageReturn.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // chbManageBooking
            // 
            this.chbManageBooking.AutoSize = true;
            this.chbManageBooking.Checked = true;
            this.chbManageBooking.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbManageBooking.CheckedState.BorderRadius = 0;
            this.chbManageBooking.CheckedState.BorderThickness = 0;
            this.chbManageBooking.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbManageBooking.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbManageBooking.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbManageBooking.ForeColor = System.Drawing.Color.Black;
            this.chbManageBooking.Location = new System.Drawing.Point(17, 199);
            this.chbManageBooking.Name = "chbManageBooking";
            this.chbManageBooking.Size = new System.Drawing.Size(183, 32);
            this.chbManageBooking.TabIndex = 10;
            this.chbManageBooking.Text = "Manage Booking";
            this.chbManageBooking.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbManageBooking.UncheckedState.BorderRadius = 0;
            this.chbManageBooking.UncheckedState.BorderThickness = 0;
            this.chbManageBooking.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // chbManageVehicles
            // 
            this.chbManageVehicles.AutoSize = true;
            this.chbManageVehicles.Checked = true;
            this.chbManageVehicles.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbManageVehicles.CheckedState.BorderRadius = 0;
            this.chbManageVehicles.CheckedState.BorderThickness = 0;
            this.chbManageVehicles.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbManageVehicles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbManageVehicles.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbManageVehicles.ForeColor = System.Drawing.Color.Black;
            this.chbManageVehicles.Location = new System.Drawing.Point(17, 161);
            this.chbManageVehicles.Name = "chbManageVehicles";
            this.chbManageVehicles.Size = new System.Drawing.Size(179, 32);
            this.chbManageVehicles.TabIndex = 9;
            this.chbManageVehicles.Text = "Manage Vehicles";
            this.chbManageVehicles.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbManageVehicles.UncheckedState.BorderRadius = 0;
            this.chbManageVehicles.UncheckedState.BorderThickness = 0;
            this.chbManageVehicles.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // chbManageUsers
            // 
            this.chbManageUsers.AutoSize = true;
            this.chbManageUsers.Checked = true;
            this.chbManageUsers.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbManageUsers.CheckedState.BorderRadius = 0;
            this.chbManageUsers.CheckedState.BorderThickness = 0;
            this.chbManageUsers.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbManageUsers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbManageUsers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbManageUsers.ForeColor = System.Drawing.Color.Black;
            this.chbManageUsers.Location = new System.Drawing.Point(17, 123);
            this.chbManageUsers.Name = "chbManageUsers";
            this.chbManageUsers.Size = new System.Drawing.Size(157, 32);
            this.chbManageUsers.TabIndex = 8;
            this.chbManageUsers.Text = "Manage Users";
            this.chbManageUsers.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbManageUsers.UncheckedState.BorderRadius = 0;
            this.chbManageUsers.UncheckedState.BorderThickness = 0;
            this.chbManageUsers.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(49, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "Permissions";
            // 
            // chbManageCustomer
            // 
            this.chbManageCustomer.AutoSize = true;
            this.chbManageCustomer.Checked = true;
            this.chbManageCustomer.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbManageCustomer.CheckedState.BorderRadius = 0;
            this.chbManageCustomer.CheckedState.BorderThickness = 0;
            this.chbManageCustomer.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbManageCustomer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbManageCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbManageCustomer.ForeColor = System.Drawing.Color.Black;
            this.chbManageCustomer.Location = new System.Drawing.Point(17, 85);
            this.chbManageCustomer.Name = "chbManageCustomer";
            this.chbManageCustomer.Size = new System.Drawing.Size(202, 32);
            this.chbManageCustomer.TabIndex = 7;
            this.chbManageCustomer.Text = "Manage Customers";
            this.chbManageCustomer.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbManageCustomer.UncheckedState.BorderRadius = 0;
            this.chbManageCustomer.UncheckedState.BorderThickness = 0;
            this.chbManageCustomer.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // chbAllPermission
            // 
            this.chbAllPermission.AutoSize = true;
            this.chbAllPermission.Checked = true;
            this.chbAllPermission.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbAllPermission.CheckedState.BorderRadius = 0;
            this.chbAllPermission.CheckedState.BorderThickness = 0;
            this.chbAllPermission.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbAllPermission.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbAllPermission.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbAllPermission.ForeColor = System.Drawing.Color.Red;
            this.chbAllPermission.Location = new System.Drawing.Point(17, 48);
            this.chbAllPermission.Name = "chbAllPermission";
            this.chbAllPermission.Size = new System.Drawing.Size(158, 32);
            this.chbAllPermission.TabIndex = 6;
            this.chbAllPermission.Text = "All Permissons";
            this.chbAllPermission.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbAllPermission.UncheckedState.BorderRadius = 0;
            this.chbAllPermission.UncheckedState.BorderThickness = 0;
            this.chbAllPermission.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblUserID.Location = new System.Drawing.Point(587, 110);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(42, 28);
            this.lblUserID.TabIndex = 129;
            this.lblUserID.Text = "???";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(690, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 28);
            this.label4.TabIndex = 128;
            this.label4.Text = "رقم المستخدم:";
            // 
            // chkIsActive
            // 
            this.chkIsActive.Checked = true;
            this.chkIsActive.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(114)))), ((int)(((byte)(228)))));
            this.chkIsActive.CheckedState.BorderRadius = 2;
            this.chkIsActive.CheckedState.BorderThickness = 0;
            this.chkIsActive.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(114)))), ((int)(((byte)(228)))));
            this.chkIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsActive.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.chkIsActive.Location = new System.Drawing.Point(570, 336);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(100, 24);
            this.chkIsActive.TabIndex = 127;
            this.chkIsActive.Text = "نشط";
            this.chkIsActive.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkIsActive.UncheckedState.BorderRadius = 2;
            this.chkIsActive.UncheckedState.BorderThickness = 0;
            this.chkIsActive.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // txtUserName
            // 
            this.txtUserName.BorderRadius = 5;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.DefaultText = "";
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUserName.Location = new System.Drawing.Point(470, 162);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PlaceholderText = "";
            this.txtUserName.SelectedText = "";
            this.txtUserName.Size = new System.Drawing.Size(200, 36);
            this.txtUserName.TabIndex = 118;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BorderRadius = 5;
            this.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPassword.DefaultText = "";
            this.txtConfirmPassword.Enabled = false;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtConfirmPassword.Location = new System.Drawing.Point(470, 262);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '●';
            this.txtConfirmPassword.PlaceholderText = "";
            this.txtConfirmPassword.SelectedText = "";
            this.txtConfirmPassword.Size = new System.Drawing.Size(200, 36);
            this.txtConfirmPassword.TabIndex = 124;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.label1.Location = new System.Drawing.Point(690, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 120;
            this.label1.Text = "اسم المستخدم:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.label3.Location = new System.Drawing.Point(690, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 25);
            this.label3.TabIndex = 125;
            this.label3.Text = "تأكيد كلمة المرور:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.label2.Location = new System.Drawing.Point(690, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 121;
            this.label2.Text = "كلمة المرور:";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderRadius = 5;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.Location = new System.Drawing.Point(470, 212);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(200, 36);
            this.txtPassword.TabIndex = 119;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 5;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(206)))), ((int)(((byte)(137)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(51, 645);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 40);
            this.btnSave.TabIndex = 119;
            this.btnSave.Text = "حفظ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BorderRadius = 5;
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(54)))), ((int)(((byte)(92)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(207, 645);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 40);
            this.btnClose.TabIndex = 120;
            this.btnClose.Text = "إغلاق";
            // 
            // frmAddUpdatUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1165, 706);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tcUserInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmAddUpdatUser";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة / تحديث مستخدم";
            this.Load += new System.EventHandler(this.frmAddUpdatUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tcUserInfo.ResumeLayout(false);
            this.tpPersonalInfo.ResumeLayout(false);
            this.tpLoginInfo.ResumeLayout(false);
            this.tpLoginInfo.PerformLayout();
            this.gbForPermissions.ResumeLayout(false);
            this.gbForPermissions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2TabControl tcUserInfo;
        private System.Windows.Forms.TabPage tpPersonalInfo;
        private Guna.UI2.WinForms.Guna2Button btnPersonInfoNext;
        private People.Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private System.Windows.Forms.TabPage tpLoginInfo;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2CheckBox chkIsActive;
        private Guna.UI2.WinForms.Guna2TextBox txtUserName;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2GroupBox gbForPermissions;
        private Guna.UI2.WinForms.Guna2CheckBox chbManageTransaction;
        private Guna.UI2.WinForms.Guna2CheckBox chbManageReturn;
        private Guna.UI2.WinForms.Guna2CheckBox chbManageBooking;
        private Guna.UI2.WinForms.Guna2CheckBox chbManageVehicles;
        private Guna.UI2.WinForms.Guna2CheckBox chbManageUsers;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2CheckBox chbManageCustomer;
        private Guna.UI2.WinForms.Guna2CheckBox chbAllPermission;
        private Guna.UI2.WinForms.Guna2Button btnPrevious;
    }
}