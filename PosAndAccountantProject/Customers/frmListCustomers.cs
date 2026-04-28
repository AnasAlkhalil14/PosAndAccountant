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
        private void RefreshForm()
        {

            _AllCustomers=clsCustomer.GetAllCustombersList();
            dgvCustomers.DataSource= _AllCustomers;
            lblRecordsCount.Text=dgvCustomers.Rows.Count.ToString();

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            frmAddUpdateCustomer frm=new frmAddUpdateCustomer();
            frm.ShowDialog();
            if(frm.WasSaved)
            {
                RefreshForm();

            }

        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomerInfo frm = new frmCustomerInfo(Convert.ToInt32(dgvCustomers.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
            if(frm.WasPersonUpdated)
            {
                RefreshForm();
            }

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAddUpdateCustomer frm = new frmAddUpdateCustomer();
            frm.ShowDialog();
            if (frm.WasSaved)
            {
                RefreshForm();

            }

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateCustomer frm = new frmAddUpdateCustomer(Convert.ToInt32(dgvCustomers.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
            if (frm.WasSaved)
            {
                RefreshForm();

            }

        }

        private void انشاءفاتورةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feture will be implemented soon");
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int CustomerID = Convert.ToInt32(dgvCustomers.CurrentRow.Cells[0].Value);
            if (MessageBox.Show($"هل متاكد من حذف العميل ذو المعرف:{CustomerID}", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (clsCustomer.DeleteCustomerByID(CustomerID))
                {
                    RefreshForm();
                    MessageBox.Show($"العميل ذو المعرف={CustomerID} حذف بنجاح", "النتيجة", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show($"فشل في حذف العميل ذو المعرف={CustomerID},يوجد بيانات مربوطة به", "النتيجة", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }

            }
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = false;

            
            if(cbFilterBy.SelectedIndex == 3)
            {
                _AllCustomers.DefaultView.RowFilter = string.Format("[{0}]>0", "TotalRemainingDebt");

            }
            else if(cbFilterBy.SelectedIndex==0)
            {
                _AllCustomers.DefaultView.RowFilter = "";

            }
            else
            {
                txtFilterValue.Visible = true;
            }

            lblRecordsCount.Text=dgvCustomers.Rows.Count.ToString();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilterValue.Text.Trim()))
            {
                _AllCustomers.DefaultView.RowFilter = "";
                lblRecordsCount.Text=dgvCustomers.Rows.Count.ToString() ;
                return;
            }



            if (cbFilterBy.SelectedIndex==1)
            {
                _AllCustomers.DefaultView.RowFilter = string.Format("[{0}]={1}", "CustomerID",Convert.ToInt32(txtFilterValue.Text));

            }
            else
            {
                _AllCustomers.DefaultView.RowFilter = string.Format("[{0}] like '%{1}%'", "FullName",txtFilterValue.Text.Trim());

            }
            lblRecordsCount.Text = dgvCustomers.Rows.Count.ToString();


        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feture will be implemented soon");

        }
    }
}
