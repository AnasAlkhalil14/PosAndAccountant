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

        private void _RefreshForm()
        {
            _AllExpenses=clsExpense.GetAllExpenses();
            dgvExpenses.DataSource = _AllExpenses;
            lblRecordsCount.Text=dgvExpenses.Rows.Count.ToString();

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
            _RefreshForm();
            _LoadTypesToComboBox();
            if (dgvExpenses.Rows.Count > 0)
            {
                dgvExpenses.Columns[0].HeaderText = "معرف المصروف";
                dgvExpenses.Columns[0].Width = 100;

                dgvExpenses.Columns[1].HeaderText = "المبلغ";
                dgvExpenses.Columns[1].Width = 100;

                dgvExpenses.Columns[2].HeaderText = "النوع";
                dgvExpenses.Columns[2].Width = 200;


                dgvExpenses.Columns[3].HeaderText = "ملاحظات";
                dgvExpenses.Columns[3].Width = 300;


                dgvExpenses.Columns[4].HeaderText = "تاريخ الانشاء";
                dgvExpenses.Columns[4].Width = 250;



                dgvExpenses.Columns[5].HeaderText = "صنع بواسطة";
                dgvExpenses.Columns[5].Width = 100;

            }

            cbType.SelectedIndex = 0;

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
    }
}
