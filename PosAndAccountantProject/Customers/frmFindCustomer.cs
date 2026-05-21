using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosAndAccountantProject.Customers
{
    public partial class frmFindCustomer : Form
    {
        public frmFindCustomer()
        {
            InitializeComponent();
        }
        private int _CustomerID;

        private void ctrlCustomerCardWithFilter1_Load(object sender, EventArgs e)
        {

        }

        private void ctrlCustomerCardWithFilter1_CustomerSelected(object sender, Controls.ctrlCustomerCardWithFilter.CustomerSelectedEventArgs e)
        {
            btnSelect.Enabled = true;
            _CustomerID = e.CustomerID;
        }

        private void ctrlCustomerCardWithFilter1_CustomerNotFound(object sender, EventArgs e)
        {
            btnSelect.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFindCustomer_Load(object sender, EventArgs e)
        {
            btnSelect.Enabled=false;
        }
        
        public class CustomerSelectedEventArgs : EventArgs
        {
            public int CustomrID { get; private set; }
            public CustomerSelectedEventArgs(int customerID)
            { this.CustomrID = customerID; }

        }

        public event EventHandler<CustomerSelectedEventArgs> SelectCustomer;

        private void btnSelect_Click(object sender, EventArgs e)
        {
            SelectCustomer?.Invoke(this,new CustomerSelectedEventArgs(_CustomerID));

            this.Close();
        }
    }
}
