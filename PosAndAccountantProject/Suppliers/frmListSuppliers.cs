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

        private DataTable _AllSuppliers ;
        enum enGridSource { eAll, eMostSale , eSlowMove, eDebt }
        enGridSource GridSource = enGridSource.eAll;
        private void btnClose_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void frmListSuppliers_Load(object sender, EventArgs e)
        {

            dgvSuppliers.AutoGenerateColumns = false;
            dgvSuppliers.Columns.Clear();

            dgvSuppliers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SupplierID",
                HeaderText = "معرف المورد",
                DataPropertyName = "SupplierID",
                ReadOnly = true

            });


            dgvSuppliers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FullName",
                HeaderText = "الاسم الكامل",
                DataPropertyName = "FullName",
                ReadOnly = true
            });
            dgvSuppliers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Phone",
                HeaderText = "رقم الهاتف",
                DataPropertyName = "Phone",
                ReadOnly = true
            }); dgvSuppliers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Address",
                HeaderText = "العنوان",
                DataPropertyName = "Address",
                ReadOnly = true
            });
            dgvSuppliers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "IsActive",
                HeaderText = "هل نشط",
                DataPropertyName = "IsActive",
                ReadOnly = true
            });
            dgvSuppliers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TotalRemainingDebt",
                HeaderText = "الدين الكلي",
                DataPropertyName = "TotalRemainingDebt",
                ReadOnly = true
            }); 
            RefreshForm();


             

        }
        private void RefreshForm()
        {

            _AllSuppliers = clsSupplier.GetAllSuppliersList(Convert.ToInt32(lblPageNumber.Text),10);
            dgvSuppliers.DataSource = _AllSuppliers;
            lblCountDebtSuppliers.Text = clsSupplier.CountDebtSuppliers().ToString ();
            lblDebt.Text=clsSupplier.GetAllSuppliersDebt().ToString();
            lblDiscountToday.Text = clsPurchase.TotalDiscountToday().ToString();
            lblSuppliersToday.Text=clsSupplier.CountSuppliersToday().ToString();
            
            
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lnkNext_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblPageNumber.Text = (Convert.ToInt32(lblPageNumber.Text) + 1).ToString();

        }

        private void lnkPrivios_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (lblPageNumber.Text != "1")
                lblPageNumber.Text = (Convert.ToInt32(lblPageNumber.Text) - 1).ToString();

        }

        private void lnkSlowMoving_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            GridSource = enGridSource.eSlowMove;
            if (lblPageNumber.Text != "1")
                lblPageNumber.Text = "1";
            else
                lblPageNumber_TextChanged(null, null);
            lnkEverySupplier.BackColor = Color.White;
            lnkDebt.BackColor = Color.White;
             lnkSlowMoving.BackColor = Color.Silver;
            lnkMostPurchase.BackColor = Color.White;

        }

        private void lblPageNumber_TextChanged(object sender, EventArgs e)
        {

            switch (GridSource)
            {
                case enGridSource.eMostSale:
                    {
                        _AllSuppliers = clsSupplier.GetSuppliersMostSaled(Convert.ToInt32(lblPageNumber.Text), 10);
                        break;
                    }
                case enGridSource.eSlowMove:
                    {
                        _AllSuppliers = clsSupplier.GetSuppliersLowSaled (Convert.ToInt32(lblPageNumber.Text), 10);
                        break;
                    }
                case enGridSource.eDebt:
                    {
                        _AllSuppliers.DefaultView.RowFilter = string.Format("[{0}]>0", "TotalRemainingDebt");
                        break;
                    }
               
                    
                default:
                    {
                        _AllSuppliers = clsSupplier.GetAllSuppliersList(Convert.ToInt32(lblPageNumber.Text), 10);
                        break;
                    }


            }
            dgvSuppliers.DataSource = _AllSuppliers;

        }

        private void lnkMostSold_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            GridSource = enGridSource.eMostSale;
            if (lblPageNumber.Text != "1")
                lblPageNumber.Text = "1";
            else
                lblPageNumber_TextChanged(null, null);
            lnkEverySupplier.BackColor = Color.White;
            lnkDebt.BackColor = Color.White;
             lnkSlowMoving.BackColor = Color.White;
            lnkMostPurchase.BackColor = Color.Silver;
        }

        private void lnkEveryProduct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            GridSource = enGridSource.eAll;
            if (lblPageNumber.Text != "1")
                lblPageNumber.Text = "1";
            else
                lblPageNumber_TextChanged(null, null);
            lnkEverySupplier.BackColor = Color.Silver;
            lnkDebt.BackColor = Color.White;
             lnkSlowMoving.BackColor = Color.White;
            lnkMostPurchase.BackColor = Color.White;
        }

        private void lnkDebt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            GridSource = enGridSource.eDebt;
            if (lblPageNumber.Text != "1")
                lblPageNumber.Text = "1";
            else
                lblPageNumber_TextChanged(null, null);
            lnkEverySupplier.BackColor = Color.White;
            lnkDebt.BackColor = Color.Silver;
             lnkSlowMoving.BackColor = Color.White;
            lnkMostPurchase.BackColor = Color.White;
        }
    }
}
