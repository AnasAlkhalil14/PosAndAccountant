using Guna.UI2.WinForms;
using PosAndAccountant_business;
using PosAndAccountantProject.GlobalClasses;
using PosAndAccountantProject.Products.ProductsCategory;
using PosAndAccountantProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
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

        private bool _HandleProductImage()
        {
            if(_Product.ImagePath!=pbProductImage.ImageLocation)
            {
                if(!string.IsNullOrEmpty(_Product.ImagePath))
                {
                    try
                    {
                        if(File.Exists(_Product.ImagePath))
                        {
                            File.Delete(_Product.ImagePath);
                           

                        }

                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("خطأ عند مسحصورة المنتج القديمة " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }


                }

                if (!string.IsNullOrEmpty(pbProductImage.ImageLocation))
                {
                    string Source=pbProductImage.ImageLocation;
                  if(  clsUtil.CopyImageToProjectImagesFolder(ref Source, ConfigurationManager.AppSettings["DestinationProductsImagesFolder"]))
                    {
                        _Product.ImagePath = Source;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("خطأ غي نسخ الصورة", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
          
               
                }




            }    
            else
            {
                return true;

            }

            return true;


        }


        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("تأكد من تعبئة الحقول ب البيانات الصحيحة", "خطأ في البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(!_HandleProductImage())
            {
                return;
            }

            _Product.UnitOfSale=txtUnitOfSale.Text.Trim();
            _Product.Description=txtDescription.Text.Trim();
            _Product.CostPrice=Convert.ToDecimal(txtPurchasePrice.Text.Trim());
            _Product.SellingPrice=Convert.ToDecimal(txtSalePrice.Text.Trim())   ;
            _Product.MinimumQuantityForWarning=Convert.ToInt32(txtMinimamQuantity.Text.Trim());
            _Product.QuantityInStock=Convert.ToInt32(txtQuantity.Text.Trim());
            _Product.BarCode=txtBarcode.Text.Trim();
            _Product.ProductName=txtProductName.Text.Trim();
            _Product.ProductCategoryID = Convert.ToInt32(cbCategory.SelectedValue);
            _Product.IsActive = tsStatus.Checked;
            if(_Product.Save())
            {
                _ProductID = _Product.ProductID;
                lblTitle.Text = "تعديل بيانات منتج";
                lblProductID.Text = _Product.ProductID.ToString();
                MessageBox.Show("تم تخزين البيانات بنجاح", "نتيجة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //invoke event;
                WasSaved = true;
            }
            else
            {
                MessageBox.Show("خطأو لم يتم تخزين البيانات", "نتيجة", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
         


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
