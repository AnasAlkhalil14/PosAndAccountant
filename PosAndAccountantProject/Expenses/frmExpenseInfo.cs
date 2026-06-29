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
    public partial class frmExpenseInfo : Form
    {
        public frmExpenseInfo(int ExpenseID)
        {
            InitializeComponent();
        _ExpenseID = ExpenseID;
        }
        int _ExpenseID;
        clsExpense _Expense;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmExpenseInfo_Load(object sender, EventArgs e)
        {
            _Expense = clsExpense.Find(_ExpenseID);
            if(_Expense==null)
            {
                _ExpenseID = -1;
                MessageBox.Show("حدث خطأ لم يتم العثور على بيانات هذا المصروف", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnClose.PerformClick();
            }
            txtCreatedDate.Text=_Expense.CreatedDate.ToShortDateString();
            txtAmount.Text=_Expense.Amount.ToString();
            txtDescription.Text = _Expense.ExpenseDescription;
            txtExpenseType.Text = _Expense.TypeInfo.ExpenseType; ;
            txtUserName.Text=_Expense.UserInfo.UserName;
            txtExpenseID.Text = _Expense.ExpenseID.ToString();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("This feture will be implemented soon");
        }
    }
}
