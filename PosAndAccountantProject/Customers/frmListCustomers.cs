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

namespace PosAndAccountantProject.Customers
{
    public partial class frmListCustomers : Form
    {
        public frmListCustomers()
        {
            InitializeComponent();
        }

        private DataTable _AllCustomers;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListCustomers_Load(object sender, EventArgs e)
        {
            _AllCustomers=clsCustomer.GetAllCustombersList();
            dgvCustomers.DataSource = _AllCustomers;
            lblRecordsCount.Text=dgvCustomers.Rows.Count.ToString();
            if(dgvCustomers.Rows.Count>0)
            {   
                dgvCustomers.Columns[0].HeaderText = "معرف العميل";
                dgvCustomers.Columns[0].Width = 100;

                dgvCustomers.Columns[1].HeaderText = "الاسم الكامل";
                dgvCustomers.Columns[1].Width = 200;

                dgvCustomers.Columns[2].HeaderText = "رقم الهاتف";
                dgvCustomers.Columns[2].Width = 200;


                dgvCustomers.Columns[3].HeaderText = "العنوان";
                dgvCustomers.Columns[3].Width = 200;


                dgvCustomers.Columns[4].HeaderText = "هل نشط";
                dgvCustomers.Columns[4].Width = 100;



                dgvCustomers.Columns[5].HeaderText = "الدين الكلي";
                dgvCustomers.Columns[5].Width = 100;


                dgvCustomers.Columns[6].HeaderText = "نوع العميل";
                dgvCustomers.Columns[6].Width = 100;

            }

        }
    }
}
