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

namespace PosAndAccountantProject.Users
{
    public partial class frmAddUpdatUser : Form
    {
        public frmAddUpdatUser()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;
            _UserID = -1;
           
        }
        public frmAddUpdatUser(int UserID)
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;

            _UserID = UserID;
           

        }
        private clsUser _User;
        private int _UserID;
        private bool _IsPersonSelected=false;
        public bool WasSaved { get; private set; } = false;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("بعض البيانات غير صالحة ضع المؤشر على العلامة الحمراء لرؤية الخطأ", "خطأ في البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(!_IsPersonSelected)
            {
                MessageBox.Show("قم باختيار شخص او اضافة شخص اولا", "خطأ في البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tcUserInfo.SelectedTab = tpPersonalInfo;
                return;
            }
            _User.UserName = txtUserName.Text.Trim();
            _User.HashPassword=txtPassword.Text.Trim();
            _User.IsActive = chkIsActive.Checked;
            _User.Notes = txtNotes.Text.Trim();
            _User.PermissionInBinary = 0;
            if(_User.Save())
            {
                lblTitle.Text = "تعديل بيانات المستخدم";
                lblUserID.Text = _User.UserID.ToString();
                WasSaved = true;
                MessageBox.Show("تم حفظ البيانات بنجاح", "النتيحة", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                WasSaved = false;
                MessageBox.Show("حدث خطأ غير معروف,يرجى مراجعة مركز الدعم", "النتيحة", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
          
        }

        private void btnPersonInfoNext_Click(object sender, EventArgs e)
        {
            tcUserInfo.SelectedTab = tpLoginInfo;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            tcUserInfo.SelectedTab = tpPersonalInfo;
        }

        private void frmAddUpdatUser_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Add the unique person feture for users");


            if (_UserID!=-1)
            {
                _User = clsUser.FindUserByID(_UserID);
                lblTitle.Text = "تعديل بيانات المستخدم";
                if(_User!=null)
                {
                    ctrlPersonCardWithFilter1.FindNow(_User.PersonID);
                    txtUserName.Text = _User.UserName;
                    lblUserID.Text = _User.UserID.ToString();
                    chkIsActive.Checked = _User.IsActive;
                }
                else
                {
                    MessageBox.Show($"لا يوجد مستخدم بمعرف {_UserID}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnSave.Enabled= false;

                    this.Close();
                }

            }
            else
            {
                _User = new clsUser();

                lblTitle.Text = "اضافة مستخدم جديد";
            }

           


        }

        private void ctrlPersonCardWithFilter1_PersonSelected(object sender, People.Controls.ctrlPersonCardWithFilter.PersonSelectedEventArgs e)
        {
            _IsPersonSelected=true;
            _User.PersonID= e.PersonID;
        }

        private void ctrlPersonCardWithFilter1_PersonNotFound(object sender, EventArgs e)
        {
            _IsPersonSelected = false ;


        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {

            if(string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                errorProvider1.SetError(txtPassword, "هذا الحقل مطلوب");
                txtConfirmPassword.Enabled= false;
                e.Cancel = true;
            }
          
           
            else if(txtPassword.Text.Trim().Length<4)
            {
                errorProvider1.SetError(txtPassword, "كلمة السر يجب ان تكون 4 احرف على الاقل");
                txtConfirmPassword.Enabled = false;

                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtPassword, "");
                txtConfirmPassword.Enabled = true;


            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((char)13==e.KeyChar)
            {
                txtPassword_Validating(txtPassword,new CancelEventArgs());
                txtConfirmPassword.Focus();
            }
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                errorProvider1.SetError(txtUserName, "هذا الحقل مطلوب");
                e.Cancel = true;
            }


            else if (_User.Mode == clsUser.enMode.eUpdate && txtUserName.Text.Trim() != _User.UserName && clsUser.IsUserExistByUserName(txtUserName.Text.Trim()))
            {
                errorProvider1.SetError(txtUserName, "اسم مستخدم غير صالح لانه مستخدم من شخص اخر");
                e.Cancel = true;

            }
            else if (_User.Mode == clsUser.enMode.eAdd && clsUser.IsUserExistByUserName(txtUserName.Text.Trim()))
            {
                errorProvider1.SetError(txtUserName, "اسم مستخدم غير صالح لانه مستخدم من شخص اخر");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtUserName, "");
            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirmPassword.Text.Trim()))
            {
                errorProvider1.SetError(txtConfirmPassword, "هذا الحقل مطلوب");
                e.Cancel = true;
            }


            else if (txtConfirmPassword.Text.Trim() != txtPassword.Text.Trim())
            {
                errorProvider1.SetError(txtConfirmPassword, "خطأ,هذه كلمة سر مختلفة ");

            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, "");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)13 == e.KeyChar)
            {
                txtUserName_Validating(txtUserName, new CancelEventArgs());
                txtPassword .Focus();
            }

        }
    }
}
