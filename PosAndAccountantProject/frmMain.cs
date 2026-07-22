using PosAndAccountantProject.Sales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosAndAccountantProject
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAddNewSale_Click(object sender, EventArgs e)
        {
            frmAddUpdateSale frm = new frmAddUpdateSale();
            frm.ShowDialog();
        }
    }
}
