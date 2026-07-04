using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosAndAccountantProject.Suppliers
{
    public partial class frmFindSupplier : Form
    {
        public frmFindSupplier()
        {
            InitializeComponent();
        }
        int _SupplierID;
        public class SupplierSelectedEventArgs : EventArgs
        {
            public int SupplierID { get; }
            public SupplierSelectedEventArgs(int SupplierID) => this.SupplierID = SupplierID;
        }



        [Category("Action"), Description("Fired when a supplier is selected"), Browsable(true)]
        public event EventHandler<SupplierSelectedEventArgs> SupplierSelected;

        private void ctrlSupplierCardWithFilter1_SupplierSelected(object sender, Controls.ctrlSupplierCardWithFilter.SupplierSelectedEventArgs e)
        {
            btnSelect.Enabled = true;
            _SupplierID = e.SupplierID;
        }

        private void frmFindSupplier_Load(object sender, EventArgs e)
        {
            btnSelect.Enabled = false;

        }

        private void ctrlSupplierCardWithFilter1_SupplierNotFound(object sender, EventArgs e)
        {
            btnSelect.Enabled = false;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            SupplierSelected?.Invoke(this, new SupplierSelectedEventArgs(_SupplierID));

            this.Close();
        }
    }
}
