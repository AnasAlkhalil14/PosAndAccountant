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
    public partial class frmAddUpdateExpense : Form
    {
        public frmAddUpdateExpense()
        {
            InitializeComponent();
        }

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

        }

        private void cmbExpenseType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
