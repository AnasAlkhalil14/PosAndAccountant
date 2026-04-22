 



namespace PosAndAccountantProject.Users
{
    partial class frmChangePassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCurrentPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.txtConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrlUserCard1 = new PosAndAccountantProject.Users.Controls.ctrlUserCard();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(29, 567);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 147;
            this.label1.Text = "كلمة المرور الحالية:";
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.BorderRadius = 5;
            this.txtCurrentPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCurrentPassword.DefaultText = "";
            this.txtCurrentPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCurrentPassword.Location = new System.Drawing.Point(211, 567);
            this.txtCurrentPassword.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtCurrentPassword.MaxLength = 50;
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.PasswordChar = '●';
            this.txtCurrentPassword.PlaceholderText = "";
            this.txtCurrentPassword.SelectedText = "";
            this.txtCurrentPassword.Size = new System.Drawing.Size(220, 36);
            this.txtCurrentPassword.TabIndex = 138;
            this.txtCurrentPassword.UseSystemPasswordChar = true;
            this.txtCurrentPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCurrentPassword_KeyPress);
            this.txtCurrentPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtCurrentPassword_Validating);
            // 
            // btnClose
            // 
            this.btnClose.BorderRadius = 5;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(54)))), ((int)(((byte)(92)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(559, 713);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 40);
            this.btnClose.TabIndex = 142;
            this.btnClose.Text = "إغلاق";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 5;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(206)))), ((int)(((byte)(137)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(559, 642);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 40);
            this.btnSave.TabIndex = 141;
            this.btnSave.Text = "حفظ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BorderRadius = 5;
            this.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPassword.DefaultText = "";
            this.txtConfirmPassword.Enabled = false;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtConfirmPassword.Location = new System.Drawing.Point(211, 657);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtConfirmPassword.MaxLength = 50;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '●';
            this.txtConfirmPassword.PlaceholderText = "";
            this.txtConfirmPassword.SelectedText = "";
            this.txtConfirmPassword.Size = new System.Drawing.Size(220, 36);
            this.txtConfirmPassword.TabIndex = 140;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmPassword_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(29, 657);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 25);
            this.label3.TabIndex = 145;
            this.label3.Text = "تأكيد كلمة المرور:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(29, 612);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 25);
            this.label2.TabIndex = 143;
            this.label2.Text = "كلمة المرور الجديدة:";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BorderRadius = 5;
            this.txtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPassword.DefaultText = "";
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNewPassword.Location = new System.Drawing.Point(211, 612);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtNewPassword.MaxLength = 50;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '●';
            this.txtNewPassword.PlaceholderText = "";
            this.txtNewPassword.SelectedText = "";
            this.txtNewPassword.Size = new System.Drawing.Size(220, 36);
            this.txtNewPassword.TabIndex = 139;
            this.txtNewPassword.UseSystemPasswordChar = true;
            this.txtNewPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewPassword_KeyPress);
            this.txtNewPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtNewPassword_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlUserCard1
            // 
            this.ctrlUserCard1.BackColor = System.Drawing.Color.White;
            this.ctrlUserCard1.Location = new System.Drawing.Point(12, 12);
            this.ctrlUserCard1.Name = "ctrlUserCard1";
            this.ctrlUserCard1.Size = new System.Drawing.Size(850, 545);
            this.ctrlUserCard1.TabIndex = 0;
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(877, 765);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCurrentPassword);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.ctrlUserCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmChangePassword";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تغيير كلمة المرور";
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ctrlUserCard ctrlUserCard1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtCurrentPassword;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtNewPassword;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}