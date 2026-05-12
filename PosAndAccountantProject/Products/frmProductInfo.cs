using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosAndAccountantProject.Products
{
    public partial class frmProductInfo : Form
    {
        
        public frmProductInfo(int ProductID)
        {
            InitializeComponent();
            _ProductID = ProductID;
        }

        public bool WasUpated { get { return ctrlProductCard1.WasUpdated; }  }

        private int _ProductID;
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProductInfo_Load(object sender, EventArgs e)
        {
            ctrlProductCard1.LoadProductInfoToControl(_ProductID);
        }
    }
}
