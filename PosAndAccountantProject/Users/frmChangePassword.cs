using PosAndAccountant_business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace PosAndAccountantProject.Users
{
    public partial class frmChangePassword : Form
    {
        public frmChangePassword(int UserID)
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;
            _UserID = UserID;
            _User=clsUser.FindUserByID(_UserID);
            
        }
        public bool WasSaved { get; private set; }=false;

        private int _UserID;
        private clsUser _User;

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("بعض الحقول غير صحيحة ضع المؤشر على العلامة الحمراء لتعلم الخطأ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _User.HashPassword = txtNewPassword.Text.Trim();
            
            if(_User.Save())
            {
                WasSaved = true;
                MessageBox.Show("تم تعديل كلمة السر بنجاح", "نتيجة", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                WasSaved = false;
                MessageBox.Show("خطا حدث, لم يتم تعديل كلمة السر", "نتيجة", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            if(_User!=null)
            {
                ctrlUserCard1.LoadUserInfo(_UserID);


            }
            else
            {
                MessageBox.Show($"لا يوجد مستخدم بمعرف:{_UserID}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                txtCurrentPassword.Enabled=false;
                txtNewPassword.Enabled=false;
                txtConfirmPassword.Enabled=false;
                ctrlUserCard1.ReseteUserInfo();

            }

        }

        private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCurrentPassword.Text.Trim()))
            {
                errorProvider1.SetError(txtCurrentPassword, "هذا الحقل مطلوب");
                e.Cancel = true;
            }

            else if (!_User.IsPasswordEqual(txtCurrentPassword.Text.Trim()))
            {
                errorProvider1.SetError(txtCurrentPassword, "كلمة سر غير صحيحة");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtCurrentPassword, "");
                
            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPassword.Text.Trim()))
            {
                errorProvider1.SetError(txtNewPassword, "هذا الحقل مطلوب");
                e.Cancel = true;
                txtConfirmPassword.Enabled = false;

            }
            else if(txtNewPassword.Text.Trim().Length<4)
            {
                errorProvider1.SetError(txtNewPassword, "كلمة السر يجب ان تكون 4 احرف على الاقل");
                e.Cancel = true;
                txtConfirmPassword.Enabled = false;
            }
            else
            {
                errorProvider1.SetError(txtNewPassword, "");
                txtConfirmPassword.Enabled = true;
            }

        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirmPassword.Text.Trim()))
            {
                errorProvider1.SetError(txtConfirmPassword, "هذا الحقل مطلوب");
                e.Cancel = true;
            }
            else if (txtNewPassword.Text.Trim()!=txtConfirmPassword.Text.Trim())
            {
                errorProvider1.SetError(txtConfirmPassword, "خطأ,هذه كلمة سر مختلفة ");
                e.Cancel = true;

            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, "");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _User.HashPassword = "0000";
            if(_User.Save())
            {
                MessageBox.Show("yes");
            }
        }

        private void txtNewPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
      if(e.KeyChar ==(char)13)
            {
                txtNewPassword_Validating(null,new CancelEventArgs());
               txtConfirmPassword.Focus();
            }



        }

        private void txtCurrentPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txtCurrentPassword_Validating(txtCurrentPassword, new CancelEventArgs());
                txtNewPassword.Focus();
            }
        }
    }
    }


