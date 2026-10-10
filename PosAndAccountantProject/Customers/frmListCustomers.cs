using Guna.Charts.WinForms;
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
        enum enGridSource { eAll, eMostSale, eMostProfit, eSlowMove, eDebt }
        enGridSource GridSource = enGridSource.eAll;
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListCustomers_Load(object sender, EventArgs e)
        {

            dgvCustomers.AutoGenerateColumns = false;
            dgvCustomers.Columns.Clear();

            dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CustomerID",
                HeaderText = "معرف العميل",
                DataPropertyName = "CustomerID",
                ReadOnly = true

            });


            dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FullName",
                HeaderText = "الاسم الكامل",
                DataPropertyName = "FullName",
                ReadOnly = true
            });
            dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Phone",
                HeaderText = "رقم الهاتف",
                DataPropertyName = "Phone",
                ReadOnly = true
            }); dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Address",
                HeaderText = "العنوان",
                DataPropertyName = "Address",
                ReadOnly = true
            });
            dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "IsActive",
                HeaderText = "هل نشط",
                DataPropertyName = "IsActive",
                ReadOnly = true
            });
            dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TotalRemainingDebt",
                HeaderText = "الدين الكلي",
                DataPropertyName = "TotalRemainingDebt",
                ReadOnly = true
            }); dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CustomerType",
                HeaderText = "نوع العميل",

                DataPropertyName = "CustomerType",
                ReadOnly = true
            });
         
             RefreshForm();





        }
        private void _CustomersChart()
        {
            chartSales.YAxes.GridLines.Color = Color.FromArgb(30, 255, 255, 255); // faint grid lines
            chartSales.XAxes.GridLines.Display = false; // hide vertical grid lines
            chartSales.YAxes.Ticks.ForeColor = Color.Gray;
            chartSales.XAxes.Ticks.ForeColor = Color.Gray;

            // 2. Create the Spline Area Dataset for smooth curved line with fill
            GunaSplineAreaDataset dataset = new GunaSplineAreaDataset();

            // Visual Styling (Line color & semi-transparent blue area underneath)
            dataset.BorderColor = Color.FromArgb(50, 140, 255);      // Glowing blue line
            dataset.FillColor = Color.FromArgb(35, 50, 140, 255);   // Faded fill color
            dataset.PointRadius = 4;                                  // Circle points on nodes
            dataset.PointStyle = PointStyle.Circle;

            // 3. Add Data Points (Matching your image: Feb 1 -> Feb 28)
            DataTable CustomersDt = clsCustomer.GetCustomersCountWithDate();
            foreach (DataRow row in CustomersDt.Rows)
            {
                dataset.DataPoints.Add(Convert.ToDateTime(row["date1"]).ToString("MM-dd"), Convert.ToDouble(row["CountDayCustomers"]));
            }




            // 4. Render to Chart
            chartSales.Datasets.Clear();
            chartSales.Datasets.Add(dataset);
            chartSales.Update();
        }
        private void RefreshForm()
        {
            _AllCustomers= clsCustomer.GetAllCustombersList(Convert.ToInt32(lblPageNumber.Text), 10); 
            dgvCustomers.DataSource = _AllCustomers;
            lblRecordsCount.Text=dgvCustomers.Rows.Count.ToString();
            lblDebt.Text = clsCustomer.GetAllCustomersDebt().ToString();
      lblCustomersToday.Text=clsCustomer.CountCustomersToday().ToString();
            lblCountDebtCustomers.Text=clsCustomer.CountDebtCustomers().ToString();
        lblDiscountToday.Text=clsSale.TotalDiscountToday().ToString();
            _CustomersChart();
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

            if (_AllCustomers == null) return;
            
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
            lnkEveryCustomer.BackColor = Color.White;
            lnkDebt.BackColor = Color.White;
            lnkMostProfit.BackColor = Color.White;
            lnkSlowMoving.BackColor = Color.Silver;
            lnkMostSold.BackColor = Color.White;
        }

        private void lblPageNumber_TextChanged(object sender, EventArgs e)
        {
            switch (GridSource)
            {
                case enGridSource.eMostSale:
                    {
                        _AllCustomers= clsCustomer.GetCustomersMostSaled(Convert.ToInt32(lblPageNumber.Text), 10);
                        break;
                    }
                case enGridSource.eSlowMove:
                    {
                        _AllCustomers = clsCustomer.GetCustomersLowSaled(Convert.ToInt32(lblPageNumber.Text), 10);
                        break;
                    }
                case enGridSource.eDebt:
                    {
                        _AllCustomers = clsCustomer.GetCustomersWithDebt(Convert.ToInt32(lblPageNumber.Text), 10);
                        break;
                    }
                case enGridSource.eMostProfit:
                    {
                        _AllCustomers = clsCustomer.GetCustomersMostProfit(Convert.ToInt32(lblPageNumber.Text), 10);
                        break;
                    }
                default:
                    {
                        _AllCustomers = clsCustomer.GetAllCustombersList(Convert.ToInt32(lblPageNumber.Text), 10);
                        break;
                    }


            }
            dgvCustomers.DataSource = _AllCustomers;

        }

        private void lnkEveryProduct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GridSource = enGridSource.eAll;
            if (lblPageNumber.Text != "1")
                lblPageNumber.Text = "1";
            else
                lblPageNumber_TextChanged(null, null);
            lnkEveryCustomer.BackColor = Color.Silver;
            lnkDebt.BackColor = Color.White;
            lnkMostProfit.BackColor = Color.White;
            lnkSlowMoving.BackColor = Color.White;
            lnkMostSold.BackColor = Color.White;
        }

        private void lnkMostSold_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            GridSource = enGridSource.eMostSale;
            if (lblPageNumber.Text != "1")
                lblPageNumber.Text = "1";
            else
                lblPageNumber_TextChanged(null, null);
            lnkEveryCustomer.BackColor = Color.White;
            lnkDebt.BackColor = Color.White;
            lnkMostProfit.BackColor = Color.White;
            lnkSlowMoving.BackColor = Color.White;
            lnkMostSold.BackColor = Color.Silver;
        }

        private void lnkMostProfit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            GridSource = enGridSource.eMostProfit;
            if (lblPageNumber.Text != "1")
                lblPageNumber.Text = "1";
            else
                lblPageNumber_TextChanged(null, null);
            lnkEveryCustomer.BackColor = Color.White;
            lnkDebt.BackColor = Color.White;
            lnkMostProfit.BackColor = Color.Silver;
            lnkSlowMoving.BackColor = Color.White;
            lnkMostSold.BackColor = Color.White;
        }

        private void lnkLowStock_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            GridSource = enGridSource.eDebt;
            if (lblPageNumber.Text != "1")
                lblPageNumber.Text = "1";
            else
                lblPageNumber_TextChanged(null, null);
            lnkEveryCustomer.BackColor = Color.White;
            lnkDebt.BackColor = Color.Silver;
            lnkMostProfit.BackColor = Color.White;
            lnkSlowMoving.BackColor = Color.White;
            lnkMostSold.BackColor = Color.White;
        }
    }
}
