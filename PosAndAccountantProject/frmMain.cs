using Guna.Charts.WinForms;
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

        private void frmMain_Load(object sender, EventArgs e)
        {
            // 1. Configure Dark Theme Axes & Grid
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
            dataset.DataPoints.Add("Feb 1", 200);
            dataset.DataPoints.Add("Feb 8", 400);
            dataset.DataPoints.Add("Feb 15", 520);
            dataset.DataPoints.Add("Feb 20", 500);
            dataset.DataPoints.Add("Feb 25", 700);
            dataset.DataPoints.Add("Feb 28", 950);
            dataset.DataPoints.Add("Feb 28", 950); dataset.DataPoints.Add("Feb 1", 200);
            dataset.DataPoints.Add("Feb 8", 400);
            dataset.DataPoints.Add("Feb 15", 520);
            dataset.DataPoints.Add("Feb 20", 500);
            dataset.DataPoints.Add("Feb 25", 700);
            dataset.DataPoints.Add("Feb 28", 950);
            dataset.DataPoints.Add("Feb 28", 950);


            // 4. Render to Chart
            chartSales.Datasets.Clear();
            chartSales.Datasets.Add(dataset);
            chartSales.Update();
        }
    }
}
