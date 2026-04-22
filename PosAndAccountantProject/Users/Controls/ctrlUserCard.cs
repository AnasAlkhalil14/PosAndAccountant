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

namespace PosAndAccountantProject.Users.Controls
{
    public partial class ctrlUserCard : UserControl
    {
        public ctrlUserCard()
        {
            InitializeComponent();
        }

        private int _UserID;
        private clsUser _User;

        public bool WasPersonUpdated { get { return ctrlPersonCard1.WasUpdated; } }
        public int UserID { get { return _UserID; } }
        public clsUser User { get { return _User; } }   


        public bool LoadUserInfo(int UserID)
        {
            _User=clsUser.FindUserByID(UserID);

            if(_User==null)
            {
                _UserID = -1;
                ReseteUserInfo();
                MessageBox.Show("لا يوجد مستخدم بمعرف  = " + UserID.ToString(), "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            _UserID = UserID;
            _FillUserInfo();

            return true;
        }

        public void ReseteUserInfo()
        {
            ctrlPersonCard1.ResetPersonInfo();
            lblIsActive.Text = "[????]";
            lblNotes.Text = "[????]";
            lblPermissions.Text = "[????]";
            lblUserID.Text = "[????]";
            lblUserName.Text = "[????]";
        }
        private void _FillUserInfo()
        {
            if (_User == null) return;

            ctrlPersonCard1.LoadPersoDataToControl(_User.PersonID);
            lblIsActive.Text = _User.IsActive?"Yes":"No";
            lblNotes.Text = _User.Notes;
            lblPermissions.Text = _User.Permission();
            lblUserID.Text = _User.UserID.ToString();
            lblUserName.Text = _User.UserName ;


        }


       
    }
}
