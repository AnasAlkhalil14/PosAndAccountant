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
    public partial class frmCustomerInfo : Form
    {
        public frmCustomerInfo(int CustomerID)
        {
            InitializeComponent();
            _CustomerID = CustomerID;
        }
        private int _CustomerID;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool WasPersonUpdated { get { return ctrlCustomerCard1.WasPersonUpdated; } }
        private void frmCustomerInfo_Load(object sender, EventArgs e)
        {
            if(!ctrlCustomerCard1.LoadDataToControl(_CustomerID))
            {
                MessageBox.Show($"خطأ عند تحميل بيانات العميل ذو المعرف:{_CustomerID}","خطأ",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

     
    }
}
