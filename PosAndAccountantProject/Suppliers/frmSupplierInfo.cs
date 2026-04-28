using PosAndAccountantProject.Customers.Controls;
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
    public partial class frmSupplierInfo : Form
    {
        public frmSupplierInfo(int customerID)
        {
            InitializeComponent();
            _CustomerID = customerID;
        }
        public bool WasPersonUpdated { get { return ctrlSupplierCard1.WasPersonUpdated; } }

        private int _CustomerID;
        private void frmSupplierInfo_Load(object sender, EventArgs e)
        {

            if (!ctrlSupplierCard1.LoadDataToControl(_CustomerID))
            {
                MessageBox.Show($"خطأ عند تحميل بيانات العميل ذو المعرف:{_CustomerID}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
