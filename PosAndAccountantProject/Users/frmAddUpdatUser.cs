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
            _User = new clsUser();

            lblTitle.Text = "اضافة مستخدم جديد";
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


            WasSaved = true;
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

           


        }

        private void ctrlPersonCardWithFilter1_PersonSelected(object sender, People.Controls.ctrlPersonCardWithFilter.PersonSelectedEventArgs e)
        {
            _IsPersonSelected=true;
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
    }
}
