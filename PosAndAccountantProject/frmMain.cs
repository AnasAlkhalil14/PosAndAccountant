using Guna.Charts.WinForms;
using PosAndAccountant_business;
using PosAndAccountantProject.Sales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosAndAccountantProject
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAddNewSale_Click(object sender, EventArgs e)
        {
            frmAddUpdateSale frm = new frmAddUpdateSale();
            frm.ShowDialog();
        }

        private void _DaySale()
        {
            lblTodaySalesVal.Text = clsSale.GetDaySale().ToString();
            decimal diff = clsSale.GetDiffPercentDaySale();
            if (diff > 0)
            {
                lblTodaySalesTrend.Text = $"▲ {diff}% عن أمس";
            }
            else if (diff < 0)
            {
                lblTodaySalesTrend.Text = $"▼ {diff}% عن أمس";

            }
            else
            {
                lblTodaySalesTrend.Text = "بدون تغيير اليوم";

            }

        }
        private void _CountDaySale()
        {
            lblTotalOrdersVal.Text = clsSale.GetCountDaySale().ToString();
            double diff = clsSale.GetDiffPercentCountDaySale();
            if (diff > 0)
            {
                lblTotalOrdersTrend.Text = $"▲ {diff}% عن أمس";
            }
            else if (diff < 0)
            {
                lblTotalOrdersTrend.Text = $"▼ {diff}% عن أمس";

            }
            else
            {
                lblTotalOrdersTrend.Text = "بدون تغيير اليوم";

            }

        }
        private void _DayProfit()

        {
            lblProfitVal.Text = clsSale.GetDayProfit().ToString();
            decimal diff = clsSale.GetDiffPercentDayProfit();
            if (diff > 0)
            {
                lblProfitTrend.Text = $"▲ {diff}% عن أمس";
            }
            else if (diff < 0)
            {
                lblProfitTrend.Text = $"▼ {diff}% عن أمس";

            }
            else
            {
                lblProfitTrend.Text = "بدون تغيير اليوم";

            }

        }
        private void _DayCashPaid()


        {
            lblCashBalanceVal.Text = clsSale.GetDayPaid().ToString();
            decimal diff = clsSale.GetDiffPercentDayPaid();
            if (diff > 0)
            {
                lblCashBalanceTrend.Text = $"▲ {diff}% عن أمس";
            }
            else if (diff < 0)
            {
                lblCashBalanceTrend.Text = $"▼ {diff}% عن أمس";

            }
            else
            {
                lblCashBalanceTrend.Text = "بدون تغيير اليوم";

            }

        }
        private void _LowStockProduct()
        {
            dgvLowStock.DataSource = clsProduct.GetLowStockProducts();


            if (dgvLowStock.Rows.Count > 0)
            {
                dgvLowStock.Columns[0].HeaderText = "اسم المنتج";
                dgvLowStock.Columns[1].HeaderText = "الكمية المتبقية";
                dgvLowStock.Columns[2].HeaderText = "حد التنبيه";

            }

        }
        private void _LastNewInvoices()
        {
            dgvRecentInvoices.AutoGenerateColumns = false;

            dgvRecentInvoices.Columns.Clear();

            dgvRecentInvoices.Columns.Add("SaleID", "رقم الفاتورة");
            dgvRecentInvoices.Columns.Add("FullName", "اسم الزبون");
            dgvRecentInvoices.Columns.Add("CreateTime", "الوقت");
            dgvRecentInvoices.Columns.Add("TotalAmount", "المبلغ");

            dgvRecentInvoices.DataSource = clsSale.GetLast10SalesToday();
        }
        private void _SalesChart()
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
            DataTable SalesDt = clsSale.GetLast10TotalSaleByDay();
            foreach (DataRow row in SalesDt.Rows)
            {
                dataset.DataPoints.Add(Convert.ToDateTime(row["SaleDate"]).ToString("MM-dd"), Convert.ToDouble(row["TotalSale"]));
            }




            // 4. Render to Chart
            chartSales.Datasets.Clear();
            chartSales.Datasets.Add(dataset);
            chartSales.Update();
        }
        private void _DayPurchase()
        {
            lblTodayPurchasesVal.Text = clsPurchase.GetDayPurchase().ToString();
            decimal diff = clsPurchase.GetDiffPercentDayPurchase();
            if (diff > 0)
            {
                lblTodayPurchasesTrend.Text = $"▲ {diff}% عن أمس";
            }
            else if (diff < 0)
            {
                lblTodayPurchasesTrend.Text = $"▼ {diff}% عن أمس";

            }
            else
            {
                lblTodayPurchasesTrend.Text = "بدون تغيير اليوم";

            }

        }
        private void _LoadDashboardData()
        {
            _DaySale();
            _CountDaySale();
            _DayProfit();
            _DayCashPaid();
            _LowStockProduct();
            _LastNewInvoices();
            _SalesChart();

            lblCustomersDebtVal.Text = clsCustomer.GetAllCustomersDebt().ToString();
            lblSuppliersDebtVal.Text=clsSupplier.GetAllSuppliersDebt().ToString(); 
            lblStockValueVal.Text=clsProduct.GetTotalValueOfStock().ToString();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            _LoadDashboardData();

        }

         
    }
}
