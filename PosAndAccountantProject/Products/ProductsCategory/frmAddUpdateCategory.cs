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

namespace PosAndAccountantProject.Products.ProductsCategory
{
    public partial class frmAddUpdateCategory : Form
    {
       
        public frmAddUpdateCategory()
        {
            InitializeComponent();
            _CategoryID = -1;
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;
        }
        public frmAddUpdateCategory(int CategoryID)
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;

            _CategoryID = CategoryID;
        }

        private int _CategoryID;
        private clsProductCategory _Category;
        public bool WasSaved { get; private set; }
        private void btnSave_Click(object sender, EventArgs e)
        {


            if(!this.ValidateChildren())
            {
                MessageBox.Show("خطأ في البيانات ضع المؤشر على العلامة الحمراء", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _Category.Description = txtDescription.Text.Trim();
            _Category.CategoryName = txtCategoryName.Text.Trim();

            if(_Category.Save())
            {
                lblCategoryID.Text = _Category.CategoryID.ToString();
                lblTitle.Text = lblTitle.Text = "تعديل بيانات الصنف";
                WasSaved = true;
                MessageBox.Show("تم حفظ البيانات بنجاح", "النتيحة", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                WasSaved = false;
                MessageBox.Show("حدث خطأ غير معروف,يرجى مراجعة مركز الدعم", "النتيحة", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void frmAddUpdateCategory_Load(object sender, EventArgs e)
        {
            if(_CategoryID!=-1)
            {
                _Category = clsProductCategory.FindByID(_CategoryID);
                if( _Category != null )
                {
                    lblTitle.Text = "تعديل بيانات الصنف";
                    lblCategoryID.Text=_Category.CategoryID.ToString();
                    txtCategoryName.Text = _Category.CategoryName;
                    txtDescription.Text = _Category.Description;
                }
                else
                {
                    MessageBox.Show($"لا يوجد صنف بمعرف {_CategoryID}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnSave.Enabled = false;

                    this.Close();
                }

            }
            else
            {
                _Category = new clsProductCategory();
                lblTitle.Text = "اضافة صنف جديد";

            }

        }

        private void txtCategoryName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCategoryName.Text.Trim()))
            {
                errorProvider1.SetError(txtCategoryName, "هذا الحقل مطلوب");
                e.Cancel = true;
            }
            else if(_Category.Mode==clsProductCategory.enMode.eUpdate&&txtCategoryName.Text.Trim() != _Category.CategoryName&&clsProductCategory.IsCategoryExistByName(txtCategoryName.Text.Trim()))
            {
                errorProvider1.SetError(txtCategoryName, "هذا الصنف موجود من قبل");
                e.Cancel = true;
            }
            else if (_Category.Mode == clsProductCategory.enMode.eAdd && clsProductCategory.IsCategoryExistByName(txtCategoryName.Text.Trim()))
            {
                errorProvider1.SetError(txtCategoryName, "هذا الصنف موجود من قبل");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtCategoryName, "");   
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
