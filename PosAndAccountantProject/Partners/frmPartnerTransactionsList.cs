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

namespace PosAndAccountantProject.Partners
{
    public partial class frmPartnerTransactionsList : Form
    {
        public frmPartnerTransactionsList()
        {
            InitializeComponent();
        }
        DataTable _AllPartners = clsPartner.GetAllPartnersShort();
        private void _LoadPartnersToCompoBox()
        {
            cbxPartnerName.DisplayMember = "FullName";
            cbxPartnerName.ValueMember = "PartnerID";
            cbxPartnerName.DataSource = _AllPartners;


        }
        private void frmPartnerTransactionsList_Load(object sender, EventArgs e)
        {
            _LoadPartnersToCompoBox();
            dgvTransactions.AutoGenerateColumns = false;
            dgvTransactions.Columns.Clear();

            dgvTransactions.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PartnerTransactionID",
                HeaderText = "معرف الحركة",
                DataPropertyName = "PartnerTransactionID",
                ReadOnly = true

            });


            dgvTransactions.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FullName",
                HeaderText = "الاسم الكامل",
                DataPropertyName = "FullName",
                ReadOnly = true
            });
            dgvTransactions.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TransactionType",
                HeaderText = "نوع الحركة",
                DataPropertyName = "TransactionType",
                ReadOnly = true
            }); dgvTransactions.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Amount",
                HeaderText = "المبلغ",
                DataPropertyName = "Amount",
                ReadOnly = true
            });
            dgvTransactions.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CreatedDate",
                HeaderText = "التاريخ",
                DataPropertyName = "CreatedDate",
                ReadOnly = true
            });
            dgvTransactions.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Notes",
                HeaderText = "الملاحظات",
                DataPropertyName = "Notes",
                ReadOnly = true
            });  

            RefreshForm();

            dgvTransactions.DataSource = clsPartnerTransaction.GetAllPartnerTransactions(1,10);
        }

        private void RefreshForm()
        {
           
        }

        private void lnkAddNewTransaction_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           frmWithdrawDeposite frm= new frmWithdrawDeposite();
            frm.ShowDialog();
        }

        private void lnkManagePartners_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmListPartners frm= new frmListPartners();
            frm.ShowDialog();
        }
    }
}
