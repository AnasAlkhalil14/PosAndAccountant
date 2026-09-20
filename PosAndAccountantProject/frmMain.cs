using Guna.Charts.WinForms;
using PosAndAccountant_business;
using PosAndAccountantProject.Customers;
using PosAndAccountantProject.Dashboard;
using PosAndAccountantProject.Partners;
using PosAndAccountantProject.Products;
using PosAndAccountantProject.Purchases;
using PosAndAccountantProject.Reports;
using PosAndAccountantProject.Sales;
using PosAndAccountantProject.Suppliers;
using PosAndAccountantProject.Users;
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


        private Form _ActiveForm = null;
        private void OpenChildForm(Form ChildForm)
        {
            if (_ActiveForm != null) { _ActiveForm.Close(); }

            _ActiveForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;

            panelContent.Controls.Clear();
            panelContent.Controls.Add(ChildForm);
            panelContent.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnDashBord.Checked = true;
        }

        private void btnAddNewSale_Click(object sender, EventArgs e)
        {

        }

        private void btnDashBord_CheckedChanged(object sender, EventArgs e)
        {
            OpenChildForm(new frmDashboard( ));
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmSalesList());

        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmListProducts());


        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmListCustomers());

        }

        private void btnVehicles_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmListSuppliers());

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmListUsers());

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmListPartners());

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmCustomReportsWithAi());

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmPurchasesList());

        }
    }
}
