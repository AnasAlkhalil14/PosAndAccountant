using PosAndAccountant_business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PosAndAccountantProject.Purchases
{
    public partial class frmPurchasesList : Form
    {
        public frmPurchasesList()
        {
            InitializeComponent();
        }

        

        private void btnAddNewPurchase_Click(object sender, EventArgs e)
        {
            frmAddUpdatePurchase frm=new frmAddUpdatePurchase();
            frm.ShowDialog();
            if(frm.WasSaved)
            {
                _RefreshForm();
            }
        }

        private void frmPurchasesList_Load(object sender, EventArgs e)
        {
            lblPageNumber.Text = "1";
            dgvPurchaseList.AutoGenerateColumns = false;
            dgvPurchaseList.Columns.Clear();

            dgvPurchaseList.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PurchaseID",
                HeaderText = "رقم الفاتورة",
                DataPropertyName = "PurchaseID",
                ReadOnly = true

            });
            dgvPurchaseList.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TotalAmount",
                HeaderText = "المبلع الكلي",
                DataPropertyName = "TotalAmount",
                ReadOnly = true
            });

            dgvPurchaseList.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PaidAmount",
                HeaderText = "المبلغ المدفوع",
                DataPropertyName = "PaidAmount",
                ReadOnly = true
            });
            dgvPurchaseList.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SupplierName",
                HeaderText = "اسم المورد",
                DataPropertyName = "SupplierName",
                ReadOnly = true
            });
            dgvPurchaseList.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CreateDate",
                HeaderText = "تاريخ الانشاء",
                DataPropertyName = "CreateDate",
                ReadOnly = true
            });

            _RefreshForm();
        }

        private void _RefreshForm()
        {
            dgvPurchaseList.DataSource = clsPurchase.GetAllPurchases(Convert.ToInt32(lblPageNumber.Text), 10);
            lblDebtToday.Text = clsPurchase.TotalDebtToday().ToString();
            lblPurchaseToday.Text = clsPurchase.GetDayPurchase().ToString();
            lblMaxPurchaseToday.Text = clsPurchase.MaxPurchaseToday().ToString();
            lblLowStockProducts.Text = clsProduct.CountOfLowStockProducts().ToString();
            _LoadProfitChart();
        }

        private void _LoadProfitChart()
        {
            DataTable dt=clsPurchase.GetLast10TotalSaleAndPurchase();

            chart.Series.Clear();
            chart.Legends.Clear();
            chart.ChartAreas.Clear();

            var area = chart.ChartAreas.Add("main");
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.LineColor = Color.Gainsboro;
            area.AxisX.Interval = 1;
            area.AxisY.LabelStyle.Format = "#,##0";
            area.AxisX.Title = "التاريخ";
            area.AxisY.Title = "المبلغ";

            chart.Legends.Add(new Legend("legend") { Docking = Docking.Top });

            var sSales = chart.Series.Add("المبيعات");
            var sPurch = chart.Series.Add("المشتريات");

            foreach (var s in new[] { sSales, sPurch })
            {
                s.ChartType = SeriesChartType.Column;
                s.ToolTip = "#SERIESNAME - #VALX: #VALY{N0}";
                s["PointWidth"] = "0.7";
            }
            sSales.Color = Color.FromArgb(46, 160, 67);   // أخضر
            sPurch.Color = Color.FromArgb(230, 126, 34);  // برتقالي

            foreach (DataRow row in dt.Rows)
            {
                if (row["Date"] == DBNull.Value) continue;

                string label = Convert.ToDateTime(row["Date"])
                                      .ToString("dd/MM", CultureInfo.InvariantCulture);

                decimal sale = row["TotalSale"] == DBNull.Value ? 0 : Convert.ToDecimal(row["TotalSale"]);
                decimal purchase = row["TotalPurchase"] == DBNull.Value ? 0 : Convert.ToDecimal(row["TotalPurchase"]);

                sSales.Points.AddXY(label, sale);
                sPurch.Points.AddXY(label, purchase);
            }
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

        private void lblPageNumber_TextChanged(object sender, EventArgs e)
        {
            dgvPurchaseList.DataSource = clsPurchase.GetAllPurchases(Convert.ToInt32(lblPageNumber.Text), 10);

        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dgvPurchaseList.CurrentRow.Cells[0].Value);
            frmAddUpdatePurchase frm = new frmAddUpdatePurchase(ID);
            frm.ShowDialog();
            if(frm.WasSaved)
            {
                _RefreshForm();
            }
        }
    }
}
