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
    public partial class frmChangePassword : Form
    {
        public frmChangePassword(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            _User=clsUser.FindUserByID(_UserID);
            
        }

        private int _UserID;
        private clsUser _User;

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            if(_User!=null)
            {
                ctrlUserCard1.LoadUserInfo(_UserID);


            }
            else
            {
                btnSave.Enabled = false;
                ctrlUserCard1.ReseteUserInfo();

            }

        }

    }
}
