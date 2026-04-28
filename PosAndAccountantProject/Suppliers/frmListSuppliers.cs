using PosAndAccountant_business;
using PosAndAccountantProject.Customers;
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
    public partial class frmListSuppliers : Form
    {
        public frmListSuppliers()
        {
            InitializeComponent();
        }

        private DataTable _AllSuppliers = clsSupplier.GetAllSuppliersList();

        private void btnClose_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void frmListSuppliers_Load(object sender, EventArgs e)
        {
            dgvSuppliers.DataSource = _AllSuppliers;
            lblRecordsCount.Text=dgvSuppliers.Rows.Count.ToString();

            if (dgvSuppliers.Rows.Count > 0)
            {
                dgvSuppliers.Columns[0].HeaderText = "معرف المورد";
                dgvSuppliers.Columns[0].Width = 100;

                dgvSuppliers.Columns[1].HeaderText = "الاسم الكامل";
                dgvSuppliers.Columns[1].Width = 200;

                dgvSuppliers.Columns[2].HeaderText = "رقم الهاتف";
                dgvSuppliers.Columns[2].Width = 200;


                dgvSuppliers.Columns[3].HeaderText = "العنوان";
                dgvSuppliers.Columns[3].Width = 200;


                dgvSuppliers.Columns[4].HeaderText = "هل نشط";
                dgvSuppliers.Columns[4].Width = 100;



                dgvSuppliers.Columns[5].HeaderText = "الدين الكلي";
                dgvSuppliers.Columns[5].Width = 100;



            }


        }
        private void RefreshForm()
        {

            _AllSuppliers = clsSupplier.GetAllSuppliersList();
            dgvSuppliers.DataSource = _AllSuppliers;
            lblRecordsCount.Text = dgvSuppliers.Rows.Count.ToString();

        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSupplierInfo frm = new frmSupplierInfo(Convert.ToInt32(dgvSuppliers.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
            if (frm.WasPersonUpdated)
            {
                RefreshForm();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            frmAddUpdateSupplier frm = new frmAddUpdateSupplier();
            frm.ShowDialog();
            if (frm.WasSaved)
            {
                RefreshForm();

            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateSupplier frm = new frmAddUpdateSupplier(Convert.ToInt32(dgvSuppliers.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
            if (frm.WasSaved)
            {
                RefreshForm();

            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int SupplierID = Convert.ToInt32(dgvSuppliers.CurrentRow.Cells[0].Value);
            if (MessageBox.Show($"هل متاكد من حذف المورد ذو المعرف:{SupplierID}", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (clsSupplier.DeleteSupplierByID(SupplierID))
                {
                    RefreshForm();
                    MessageBox.Show($"المورد ذو المعرف={SupplierID} حذف بنجاح", "النتيجة", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show($"فشل في حذف المورد ذو المعرف={SupplierID},يوجد بيانات مربوطة به", "النتيجة", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }

            }
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feture will be implemented soon");

        }

        private void انشاءفاتورةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feture will be implemented soon");

        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            frmAddUpdateSupplier frm = new frmAddUpdateSupplier();
            frm.ShowDialog();
            if (frm.WasSaved)
            {
                RefreshForm();

            }
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtFilterValue.Visible = false;


            if (cbFilterBy.SelectedIndex == 3)
            {
                _AllSuppliers.DefaultView.RowFilter = string.Format("[{0}]>0", "TotalRemainingDebt");

            }
           
            else
            {
                _AllSuppliers.DefaultView.RowFilter = "";
                txtFilterValue.Visible = true;
            }

            lblRecordsCount.Text = dgvSuppliers.Rows.Count.ToString();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtFilterValue.Text.Trim()))
            {
                _AllSuppliers.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvSuppliers.Rows.Count.ToString();
                return;
            }



            if (cbFilterBy.SelectedIndex == 1)
            {
                _AllSuppliers.DefaultView.RowFilter = string.Format("[{0}]={1}", "SupplierID", Convert.ToInt32(txtFilterValue.Text));

            }
            else
            {
                _AllSuppliers.DefaultView.RowFilter = string.Format("[{0}] like '%{1}%'", "FullName", txtFilterValue.Text.Trim());

            }
            lblRecordsCount.Text = dgvSuppliers.Rows.Count.ToString();


        }
    }
}
