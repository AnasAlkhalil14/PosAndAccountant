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

namespace PosAndAccountantProject.Expenses
{
    public partial class frmListExpenses : Form
    {
        public frmListExpenses()
        {
            InitializeComponent();
        }

        private DataTable _AllExpenses;
        private void _ExpensesChart()
        {
            DataTable dt=clsExpense.GetAllExpensesTypesWithTotalExpenses();
 
             gunaChart1.Datasets.Clear();

            if (dt == null || dt.Rows.Count == 0)
            {
                gunaChart1.Update();
                return;
            }

            // Colors (cycled if there are more categories than colors)
            Color[] palette =
            {
        Color.FromArgb(94, 148, 255),
        Color.FromArgb(255, 99, 132),
        Color.FromArgb(255, 205, 86),
        Color.FromArgb(75, 192, 192),
        Color.FromArgb(153, 102, 255),
        Color.FromArgb(255, 159, 64),
        Color.FromArgb(46, 204, 113),
        Color.FromArgb(149, 165, 166)
    };

            var dataset = new GunaDoughnutDataset();
            double total = 0;
            int i = 0;

            foreach (DataRow row in dt.Rows)
            {
                string category = row["ExpenseCategory"].ToString();
                double amount = Convert.ToDouble(row["TotalExpense"]);

                dataset.DataPoints.Add(category, amount);
                dataset.FillColors.Add(palette[i % palette.Length]);

                total += amount;
                i++;
            }

             dataset.BorderWidth = 2;

            gunaChart1.Datasets.Add(dataset);

            // Title
            gunaChart1.Title.Display = true;
            gunaChart1.Title.Text = "المصروفات حسب التصنيف - " + total.ToString("N0");
            gunaChart1.Title.Font = new  ChartFont("Segoe UI", 12, ChartFontStyle.Bold);
            gunaChart1.Title.ForeColor = Color.FromArgb(40, 40, 40);

            // Legend
            gunaChart1.Legend.Display = true;
            gunaChart1.Legend.Position = LegendPosition.Right;
            gunaChart1.Legend.LabelFont = new ChartFont("Segoe UI", 10);
            gunaChart1.Legend.LabelForeColor = Color.FromArgb(40, 40, 40);
 

            // Doughnut has no axes
            gunaChart1.XAxes.Display = false;
            gunaChart1.YAxes.Display = false;

            gunaChart1.Update();
        }
        private void _RefreshForm()
        {
            _AllExpenses=clsExpense.GetAllExpenses(Convert.ToInt32(lblPageNumber.Text),10);
            dgvExpenses.DataSource = _AllExpenses;
            lblRecordsCount.Text=dgvExpenses.Rows.Count.ToString();
            lblDayAVG.Text = clsExpense.AverageDayExpense().ToString("0");
            lblExpenseThisMonth.Text = clsExpense.TotalExpenseThisMonth().ToString("0");
            lblExpenseToday.Text=clsExpense.TotalExpenseToday().ToString("0");
            lblMaxExpenseMonth.Text = clsExpense.MaxExpenseThisMonth().ToString("0");
            _ExpensesChart();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _LoadTypesToComboBox()
        {
               

            DataTable dtNew = clsExpense.GetAllExpenseTypes(); ;
            dtNew.PrimaryKey = null;
            foreach (DataColumn col in dtNew.Columns)
                col.AllowDBNull = true;
            DataRow row = dtNew.NewRow();
            row["ExpenseTypeID"] = Convert.ChangeType(0, dtNew.Columns["ExpenseTypeID"].DataType);
            row["Type"] = "الكل";
            dtNew.Rows.InsertAt(row, 0);

            cbType.DisplayMember = "Type";
            cbType.ValueMember = "ExpenseTypeID";
            cbType.DataSource = dtNew;

            cbType.SelectedIndex = 0;


            //
            

        }

        private void frmListExpenses_Load(object sender, EventArgs e)
        {
            dgvExpenses.AutoGenerateColumns = false;
            dgvExpenses.Columns.Clear();

            dgvExpenses.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ExpenseID",
                HeaderText = "معرف المصروف",
                DataPropertyName = "ExpenseID",
                ReadOnly = true

            });


            dgvExpenses.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Amount",
                HeaderText = "المبلغ",
                DataPropertyName = "Amount",
                ReadOnly = true
            }); dgvExpenses.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Type",
                HeaderText = "النوع",
                DataPropertyName = "Type",
                ReadOnly = true
            });
            dgvExpenses.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ExpenseDescription",
                HeaderText = "ملاحظات",
                DataPropertyName = "ExpenseDescription",
                ReadOnly = true
            }); dgvExpenses.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CreatedDate",
                HeaderText = "تاريخ الانشاء",
                DataPropertyName = "CreatedDate",
                ReadOnly = true
            }); dgvExpenses.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "UserName",
                HeaderText = "صنع بواسطة",
                DataPropertyName = "UserName",
                ReadOnly = true
            });
            _RefreshForm();
            _LoadTypesToComboBox();
             

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddUpdateExpense frm=new frmAddUpdateExpense();
            frm.ShowDialog();
            if(frm.WasSaved)
            {
                _RefreshForm();
            }
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
        if(cbType.SelectedIndex == 0)
            {
                _AllExpenses.DefaultView.RowFilter = "";
                
            } else
            _AllExpenses.DefaultView.RowFilter = string.Format("[{0}] like '%{1}%'", "Type", cbType.Text);

            lblRecordsCount.Text = dgvExpenses.Rows.Count.ToString();

        }

        private void عرضالتفاصيلToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmExpenseInfo frm= new frmExpenseInfo(Convert.ToInt32(dgvExpenses.CurrentRow.Cells[0].Value));
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

        private void lblPageNumber_TextChanged(object sender, EventArgs e)
        {
            _AllExpenses = clsExpense.GetAllExpenses(Convert.ToInt32(lblPageNumber.Text), 10);
            dgvExpenses.DataSource = _AllExpenses;
            cbType.SelectedIndex = 0; lblRecordsCount.Text = dgvExpenses.Rows.Count.ToString();

        }
    }
}
