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

namespace PosAndAccountantProject.Sales
{
    public partial class frmSalesList : Form
    {
        public frmSalesList()
        {
            InitializeComponent();
        }

        private void btnAddNewSale_Click(object sender, EventArgs e)
        {
            frmAddUpdateSale frm=new frmAddUpdateSale();
            frm .ShowDialog();
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

        private void frmSalesList_Load(object sender, EventArgs e)
        {
            lblPageNumber.Text = "1";
            dgvSalesList.AutoGenerateColumns = false;
            dgvSalesList.Columns.Clear();

            dgvSalesList.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SaleID",
                HeaderText = "رقم الفاتورة",
                DataPropertyName = "SaleID"
            });
            dgvSalesList.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TotalAmount",
                HeaderText = "المبلع الكلي",
                DataPropertyName = "TotalAmount"
            });

            dgvSalesList.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PaidAmount",
                HeaderText = "المبلغ المدفوع",
                DataPropertyName = "PaidAmount"
            });
            dgvSalesList.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CustomerName",
                HeaderText = "اسم العميل",
                DataPropertyName = "CustomerName"
            });
            dgvSalesList.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CreateDate",
                HeaderText = "تاريخ الانشاء",
                DataPropertyName = "CreateDate"
            });
        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int SaleID = Convert.ToInt32(dgvSalesList.CurrentRow.Cells[0].Value);
            frmAddUpdateSale frm= new frmAddUpdateSale(SaleID);
            frm.ShowDialog();


        }
    }
}
