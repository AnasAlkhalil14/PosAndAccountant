using PosAndAccountant_business;
using PosAndAccountantProject.GlobalClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosAndAccountantProject.Expenses
{
    public partial class frmAddUpdateExpense : Form
    {
        public frmAddUpdateExpense()
        {

            InitializeComponent();
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;
            Expense = new clsExpense();
        }

        public bool WasSaved = false;

        clsExpense Expense;    
        private void _LoadTypesToComboBox()
        {
            cmbExpenseType.DataSource = clsExpense.GetAllExpenseTypes();
            cmbExpenseType.ValueMember = "ExpenseTypeID";
            cmbExpenseType.DisplayMember = "Type";
            
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtTypeName.Text.Trim()))
            {
                MessageBox.Show("اكتب اسم النوع الجديد لاضافته", "بيانات ناقصة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               txtTypeName.Focus();
                return;
            }
            if(clsExpense.AddExpenseType(txtTypeName.Text.Trim(),txtTypeNote.Text.Trim()))
            {
                MessageBox.Show("تمت اضافة نوع جديد بنجاح", "النتيجة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTypeNote.Clear();txtTypeName.Clear();
                _LoadTypesToComboBox();
            }
            else
            {
                MessageBox.Show("حدث خطأ عند اضافة النوع", "النتيجة", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }




        }

        private void frmAddUpdateExpense_Load(object sender, EventArgs e)
        {
            _LoadTypesToComboBox();
            dtpCreatedDate.Value = DateTime.Now;

        }

        private void cmbExpenseType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("خطأ في البيانات", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Expense.UserID=clsUtil.CurrentUser.UserID;
            Expense.ExpenseDescription=txtNotes.Text;
            Expense.ExpenseTypeID = Convert.ToInt32(cmbExpenseType.SelectedValue);
            Expense.Amount = Convert.ToDouble(txtAmount.Text);

            if (Expense.Save())
            {
                 
                 
                txtExpenseID.Text = Expense.ExpenseID.ToString();
                MessageBox.Show("تم تخزين البيانات بنجاح", "نتيجة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //invoke event;
                WasSaved = true;
            }
            else
            {
                MessageBox.Show("خطأو لم يتم تخزين البيانات", "نتيجة", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
                { e.Handled = false; }
        }

        private void txtAmount_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtAmount.Text))
            {
                errorProvider1.SetError(txtAmount, "هذا الحقل مطلوب");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtAmount, "");
                e.Cancel = false;

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
