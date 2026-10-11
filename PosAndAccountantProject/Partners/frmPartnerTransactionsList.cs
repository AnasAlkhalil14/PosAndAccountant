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
        DataTable _AllPartners ;
        DataTable _AllTransactions;
        private void _LoadPartnersToCompoBox()
        {
            _AllPartners = clsPartner.GetAllPartnersShort();

            DataTable dtNew = _AllPartners.Copy();
            dtNew.PrimaryKey = null;
            foreach (DataColumn col in dtNew.Columns)
                col.AllowDBNull = true;
            DataRow row = dtNew.NewRow();
            row["PartnerID"] = Convert.ChangeType(0, dtNew.Columns["PartnerID"].DataType);
            row["FullName"] = "الكل";
            dtNew.Rows.InsertAt(row, 0);

            cbxPartnerName.DisplayMember = "FullName";
            cbxPartnerName.ValueMember = "PartnerID";
            cbxPartnerName.DataSource = dtNew;

            cbxPartnerName.SelectedIndex = 0;
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

            
        }
        private void LoadPartnersBalanceChart( )
        {
            DataTable dt = clsPartnerTransaction.GetAllPartnerNameWithBalance();

            // change these two to your column names
            const string nameCol = "FullName";
            const string valueCol = "CurrentBalance";

            var good = System.Drawing.Color.FromArgb(26, 188, 156);   // positive balance
            var bad = System.Drawing.Color.FromArgb(231, 76, 60);    // negative balance
            var text = System.Drawing.Color.FromArgb(90, 100, 110);
            var grid = System.Drawing.Color.FromArgb(232, 236, 238);

            chart.Datasets.Clear();

            // look
            chart.Legend.Display = false;
            chart.Title.Display = false;
             chart.XAxes.GridLines.Display = false;
            chart.YAxes.GridLines.Color = grid;
            chart.XAxes.Ticks.ForeColor = text;
            chart.YAxes.Ticks.ForeColor = text;

            if (dt != null && dt.Rows.Count > 0)
            {
                var ds = new Guna.Charts.WinForms.GunaBarDataset();
                ds.Label = "الرصيد";
                ds.CornerRadius = 6;
                ds.BarPercentage = 0.6;

                var view = new System.Data.DataView(dt) { Sort = valueCol + " DESC" };

                foreach (System.Data.DataRowView r in view)
                {
                    double v = r[valueCol] == System.DBNull.Value ? 0 : System.Convert.ToDouble(r[valueCol]);
                    ds.DataPoints.Add(r[nameCol].ToString(), v);
                    ds.FillColors.Add(v < 0 ? bad : good);
                }

                chart.Datasets.Add(ds);
            }

            chart.Update();
        }
        private void RefreshForm()
        {_AllTransactions= clsPartnerTransaction.GetAllPartnerTransactions(1, 10);
            dgvTransactions.DataSource = _AllTransactions;
            lblProfitThisMonth.Text = clsPartnerTransaction.ProfitDistriputedThisMonth().ToString();
       lblPartnersBalance.Text=clsPartner.AllPartnersBalance().ToString();
        lblExpensesThisMonth.Text=clsPartnerTransaction.ExpensesThisMonth().ToString();
            lblWithDrawMonth.Text=clsPartnerTransaction.WithDrawDistriputedThisMonth().ToString();
       LoadPartnersBalanceChart();  }

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

        private void lnkNext_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblPageNumber.Text = (Convert.ToInt32(lblPageNumber.Text) + 1).ToString();

        }

        private void lnkPrivios_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lblPageNumber.Text != "1")
                lblPageNumber.Text = (Convert.ToInt32(lblPageNumber.Text) - 1).ToString();


        }
        private void _ApplyFilter()
        {
            DataTable dt = dgvTransactions.DataSource as DataTable;
            if (dt == null) return;

            List<string> filters = new List<string>();

            if (cbxPartnerName.SelectedIndex > 0) // index 0 = الكل
            {
                filters.Add("FullName = '" + cbxPartnerName.Text.Replace("'", "''") + "'");
            }

            if (cbxTransType.SelectedIndex > 0) // index 0 = الكل
            {
                filters.Add("TransactionType = '" + cbxTransType.Text.Replace("'", "''") + "'");
            }

            dt.DefaultView.RowFilter = string.Join(" AND ", filters);
        }
        private void cbxTransType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ApplyFilter();
        }

        private void cbxPartnerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ApplyFilter();
        }
    }
    }

