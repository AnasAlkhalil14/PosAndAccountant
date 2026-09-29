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
using System.Windows.Forms.DataVisualization.Charting;

namespace PosAndAccountantProject.Sales
{
    public partial class frmSalesList : Form
    {
        public frmSalesList()
        {
            InitializeComponent();
        }
        private void _RefreshForm()
        {
            dgvSalesList.DataSource = clsSale.GetAllSales(Convert.ToInt32(lblPageNumber.Text), 10);
             lblDebtToday.Text = clsSale.TotalDebtToday().ToString();
            lblDiscountToday.Text = clsSale.TotalDiscountToday().ToString();
            lblMaxTotalSaleToday.Text = clsSale.MaxSaleToday().ToString();
            lblProfitToday.Text = clsSale.GetDayProfit().ToString();
            LoadProfitChart();
        }
        private void btnAddNewSale_Click(object sender, EventArgs e)
        {
            frmAddUpdateSale frm=new frmAddUpdateSale();
            frm .ShowDialog();
            if (frm.WasSaved)
                _RefreshForm();
        }

        private void lnkPrivios_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(lblPageNumber.Text!="1")
                lblPageNumber.Text = (Convert.ToInt32(lblPageNumber.Text) -1).ToString();


        }

        private void lnkNext_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblPageNumber.Text=(Convert.ToInt32(lblPageNumber.Text)+1).ToString();
        }

        private void lblPageNumber_TextChanged(object sender, EventArgs e)
        {
            dgvSalesList.DataSource = clsSale.GetAllSales(Convert.ToInt32(lblPageNumber.Text), 10);
        }
        private void LoadProfitChart()
        {
            DataTable dt = clsSale.GetLast10TotalProfitByDay();
            // Clear old data
            chartProfit.Series.Clear();
            chartProfit.Legends.Clear();

            ChartArea area = chartProfit.ChartAreas[0];

            // Clear old formatting
            area.AxisX.CustomLabels.Clear();

            // =========================
            // Series
            // =========================

            Series series = new Series("Profit");

            series.ChartType = SeriesChartType.Column;

            // We will add the points manually
            // so the dates are displayed correctly.
            foreach (DataRow row in dt.Rows)
            {
                DateTime date = Convert.ToDateTime(row["Date"]);
                decimal profit = Convert.ToDecimal(row["Profit"]);

                series.Points.AddXY(date.ToString("dd/MM"), profit);
            }

            chartProfit.Series.Add(series);

            // =========================
            // X Axis
            // =========================
            // =========================
            // X Axis
            // =========================
            area.AxisX.Title = "التاريخ";
            area.AxisX.TitleFont = new Font("Segoe UI", 14, FontStyle.Bold);
            area.AxisX.TitleForeColor = Color.FromArgb(60, 60, 60);

            area.AxisX.Interval = 1;
            area.AxisX.LabelStyle.Angle = 0;
            area.AxisX.LabelStyle.Font = new Font("Segoe UI", 10);
            area.AxisX.MajorGrid.Enabled = false;

            // =========================
            // Y Axis
            // =========================
            area.AxisY.Title = "الارباح";
            area.AxisY.TitleFont = new Font("Segoe UI", 14, FontStyle.Bold);
            area.AxisY.TitleForeColor = Color.FromArgb(60, 60, 60);

            area.AxisY.IsStartedFromZero = true;
            area.AxisY.LabelStyle.Format = "N0";
            area.AxisY.LabelStyle.Font = new Font("Segoe UI", 10);
            area.AxisY.MajorGrid.Enabled = true;
            // =========================
            // Chart appearance
            // =========================

            series.IsValueShownAsLabel = false;

            series["PointWidth"] = "0.6";

            chartProfit.ChartAreas[0].RecalculateAxesScale();
        }
        private void frmSalesList_Load(object sender, EventArgs e)
        {
            lblPageNumber.Text = "1";
            dgvSalesList.AutoGenerateColumns = false;
            dgvSalesList.Columns.Clear();

            dgvSalesList.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SaleID",
                HeaderText = "رقم الفاتورة",
                DataPropertyName = "SaleID",ReadOnly = true
                
            });
            dgvSalesList.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TotalAmount",
                HeaderText = "المبلع الكلي",
                DataPropertyName = "TotalAmount",
                ReadOnly = true
            });

            dgvSalesList.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PaidAmount",
                HeaderText = "المبلغ المدفوع",
                DataPropertyName = "PaidAmount",
                ReadOnly = true
            });
            dgvSalesList.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CustomerName",
                HeaderText = "اسم العميل",
                DataPropertyName = "CustomerName",
                ReadOnly = true
            });
            dgvSalesList.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CreateDate",
                HeaderText = "تاريخ الانشاء",
                DataPropertyName = "CreateDate",
                ReadOnly = true
            });

            _RefreshForm();
        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int SaleID = Convert.ToInt32(dgvSalesList.CurrentRow.Cells[0].Value);
            frmAddUpdateSale frm= new frmAddUpdateSale(SaleID);
            frm.ShowDialog();
            if (frm.WasSaved)
                _RefreshForm();

        }
    }
}
