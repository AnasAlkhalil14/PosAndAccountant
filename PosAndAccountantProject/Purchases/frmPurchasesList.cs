using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosAndAccountantProject.Purchases
{
    public partial class frmPurchasesList : Form
    {
        public frmPurchasesList()
        {
            InitializeComponent();
        }

        private void btnAddNewSale_Click(object sender, EventArgs e)
        {
            frmAddUpdatePurchase frm=new frmAddUpdatePurchase();        
            frm.ShowDialog();
        }
    }
}
