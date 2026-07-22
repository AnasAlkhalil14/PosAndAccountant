using PosAndAccountant_business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Configuration;

namespace PosAndAccountantProject.Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            
            InitializeComponent();
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;
        }



      

        private void lklForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


             MessageBox.Show("يرجى مراجعة مسؤول النظام لإعادة تعيين كلمة المرور", "طلب المساعدة", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
        
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {

            
          if(!  this.ValidateChildren())
            {
                MessageBox.Show("خطا في البيانات ضع المؤشر على العلامة الحمراء لرؤية الخطأ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsUser User = clsUser.FindUserByUserNameAndPassword(txtUserName.Text.Trim(), txtPassword.Text.Trim());
            if( User != null )
            {
                clsUser.ClearDataOfRemeberMe();
                if(chbRememberMe.Checked)
                {
                    clsUser.SaveDataForRememberMe(txtUserName.Text.Trim(), txtPassword.Text.Trim());

                }
                

                frmMain frm=new frmMain();
                frm.Show();
                this.Close();
             }
            else
            {
                MessageBox.Show("خطأ في كلمة السر او اسم المستخدم", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                errorProvider1.SetError(txtUserName, "هذا الحقل مطلوب");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtUserName, "");
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                errorProvider1.SetError(txtPassword, "هذا الحقل مطلوب");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtPassword, "");
            }

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            chbRememberMe.Checked = true;

            var PreData = clsUser.LoadDataForRemeberMe();
            if(PreData.HasValue)
            {
                
                txtUserName.Text = PreData.Value.UserName;
                txtPassword.Text = PreData.Value.Password;

            }


        }

        private void lklAnasAlkhalil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
              

                

                System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = ConfigurationManager.AppSettings["URLForAnasAlkhalil"],
                    UseShellExecute = true
                };
                System.Diagnostics.Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open the link. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
