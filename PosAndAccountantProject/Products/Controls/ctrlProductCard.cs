using PosAndAccountant_business;
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

namespace PosAndAccountantProject.Products.Controls
{
    public partial class ctrlProductCard : UserControl
    {
        public ctrlProductCard()
        {
            InitializeComponent();
        }
        private int _ProductID=-1;
        public int ProductID { get; }
        private clsProduct _Product;
        public clsProduct Product { get; }

        public bool WasUpdated { get; private set; } = false;

      public bool LoadProductInfoToControl(int ProductID)
        {
            _ProductID=ProductID;
            _Product = clsProduct.FindByID(ProductID);
            if( _Product != null )
            {
                llEditInfo.Enabled = true;
                _FillProductData();
                return true;
            }
            else
            {
                llEditInfo.Enabled=false;
                llEditInfo.Enabled=false;
                MessageBox.Show("لا يوجد منتج بمعرف  = " + ProductID.ToString(), "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                _ProductID = -1;
                ReseteProdcutData();

                return false;
            }

           
        }
        public void ReseteProdcutData()
        {
            lblProductName.Text = $"[ اسم المنتج ] ";
            lblBarcode.Text = "????";
            lblCategory.Text = "????";
            lblQuantityInStock.Text = "????";
            lblPurchasePrice.Text = "????";
            lblSalePrice.Text = "????";
            lblProfit.Text = "????";
            lblProductID.Text = "????";
            lblDescription.Text = "????";
            lblMinimamQuantity.Text = "????";
            lblUnitOfPrice.Text = "????";
            lblCreateDate.Text = "????";
            lblModifyDate.Text = "????";
            statusBadge.Text = "نشط";
                statusBadge.FillColor = Color.FromArgb(255, 192, 192);
           
                pbProductImage.Image = Resources.default_product;
            

        }
        private void _FillProductData()
        {
            if (_Product != null)
            {
                lblProductName.Text = $"[ {_Product.ProductName} ] ";
                lblBarcode.Text = _Product.BarCode;
                lblCategory.Text = _Product.ProductCategory.CategoryName;
                lblQuantityInStock.Text = _Product.QuantityInStock.ToString();
                lblPurchasePrice.Text=_Product.CostPrice.ToString();
                lblSalePrice.Text=_Product.SellingPrice.ToString();
                lblProfit.Text=(_Product.SellingPrice-_Product.CostPrice).ToString();
                lblDescription.Text = _Product.Description;
                lblUnitOfPrice.Text = _Product.UnitOfSale;
                lblMinimamQuantity.Text = _Product.MinimumQuantityForWarning.ToString();
               lblProductID.Text= _Product.ProductID.ToString();
                lblCreateDate.Text = _Product.CreateDate.ToShortDateString();
                lblModifyDate.Text=_Product.ModifyDate.ToShortDateString();
                if(_Product.IsActive)
                {
                    statusBadge.Text = "نشط";
                    statusBadge.FillColor = Color.FromArgb(255, 192, 192);
                }
                else
                {
                    statusBadge.Text = "غير نشط";
                    statusBadge.FillColor = Color.FromArgb(255, 128, 128);
                }
             if(!string.IsNullOrEmpty(_Product.ImagePath.Trim()))
                {
                    pbProductImage.ImageLocation = _Product.ImagePath;
                }
             else
                {
                    pbProductImage.Image = Resources.default_product;
                }

            }

        }

        private void llEditInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdateProduct frm = new frmAddUpdateProduct(_ProductID);
            frm.ShowDialog();
            if (frm.WasSaved)
            {
                WasUpdated = true;
                LoadProductInfoToControl(_ProductID);
            }



        }
    }
}
