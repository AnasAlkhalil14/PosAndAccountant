using Guna.UI2.WinForms;
using PosAndAccountant_business;
using PosAndAccountantProject.Products.ProductsCategory;
using PosAndAccountantProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosAndAccountantProject.Products
{
    public partial class frmAddUpdateProduct : Form
    {
        public frmAddUpdateProduct()
        {
            InitializeComponent();
            _ProductID = -1;
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;

        }
        public frmAddUpdateProduct(int ProductID)
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;
            _ProductID = ProductID;

        }

        private int _ProductID;
        private clsProduct _Product;
        public bool WasSaved { get; private set; } = false;
        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        void LoadCategoriesToCobmoBox()
        {
            cbCategory.DataSource = clsProductCategory.GetAllProductsCategory();
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "CategoryID";
        }

        private void frmAddUpdateProduct_Load(object sender, EventArgs e)
        {

            LoadCategoriesToCobmoBox();
            pbProductImage.Image = Resources.default_product;
            btnRemoveImage.Visible = false;
            if (_ProductID != -1)
            {
               
                _Product = clsProduct.FindByID(_ProductID);
                if (_Product != null)
                { cbCategory.SelectedValue=_Product.ProductCategoryID;
                   lblProductID.Text=_ProductID.ToString();
                    txtBarcode.Text = _Product.BarCode;
                    txtProductName.Text = _Product.ProductName;
                    txtDescription.Text=_Product.Description;
                    txtPurchasePrice.Text = _Product.CostPrice.ToString();
                    txtSalePrice.Text=_Product.SellingPrice.ToString();
                    txtQuantity.Text=_Product.QuantityInStock.ToString();
                    tsStatus.Checked = _Product.IsActive;
                   txtUnitOfSale.Text = _Product.UnitOfSale;
                    txtMinimamQuantity.Text=_Product.MinimumQuantityForWarning.ToString();

                    if(!string.IsNullOrEmpty(_Product.ImagePath))
                    {
                        pbProductImage.ImageLocation = _Product.ImagePath;
                        btnRemoveImage.Visible = true;
                    }

                    lblTitle.Text = "تعديل بيانات منتج ";


                }
                else
                {
                    MessageBox.Show($"لا يوجد منتج بمعرف {_ProductID}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnSave.Enabled = false;

                    this.Close();
                }

            }
            else
            {
                _Product = new clsProduct();
                lblTitle.Text = "اضافة منتج جديد";
            }

        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void lnkMostSold_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdateCategory frm = new frmAddUpdateCategory();
            frm.ShowDialog();
            if(frm.WasSaved)
            {
LoadCategoriesToCobmoBox();
            }

        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbProductImage.ImageLocation = openFileDialog1.FileName;
                btnRemoveImage.Visible = true;
            }
        }

        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            pbProductImage.ImageLocation = null;

            pbProductImage.Image = Resources.default_product;
            btnRemoveImage.Visible = false;
        }

        private void txx_Validating_NotEmpty(object sender, CancelEventArgs e)
        {
            Guna2TextBox t=(Guna2TextBox)sender;
            if(string.IsNullOrEmpty(t.Text.Trim()))
            {
                errorProvider1.SetError(t, "هذا الحقل مطلوب");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(t, "");
            }


        }

        private void txt_KeyPress_JustNumbers(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            

        }
    }
}
