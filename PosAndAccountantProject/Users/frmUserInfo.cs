using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosAndAccountantProject.Users
{
    public partial class frmUserInfo : Form
    {
        public frmUserInfo(int UserID)
        {
            InitializeComponent();
           _UserID = UserID;
        }


        public bool WasPersonUpdated { get { return ctrlUserCard1.WasPersonUpdated; }  }

        private int _UserID;
        public int UserID { get { return _UserID; }  }

        private void frmUserInfo_Load(object sender, EventArgs e)
        {

            ctrlUserCard1.LoadUserInfo(_UserID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
