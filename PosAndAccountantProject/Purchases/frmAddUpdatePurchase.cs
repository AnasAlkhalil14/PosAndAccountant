using PosAndAccountant_business;
using PosAndAccountant_DataTransfer;
using PosAndAccountantProject.Properties;
using PosAndAccountantProject.Suppliers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosAndAccountantProject.Purchases
{
    public partial class frmAddUpdatePurchase : Form
    {
        public frmAddUpdatePurchase()
        {
            InitializeComponent();
        }

        private DataTable _AllProducts = clsProduct.GetAllProducts();
        private clsPurchase _Purchase=new clsPurchase();

        private void frmAddUpdatePurchase_Load(object sender, EventArgs e)
        {
            _SettleTheProductSideOnFormLoad();
           
        
        
        
        }
            void _RefreshForm()
            {
                dgvPurchaseDetails.DataSource = null;
                dgvPurchaseDetails.DataSource = _Purchase.Details;

                if(dgvPurchaseDetails.Rows.Count > 0 )
                {
                    dgvPurchaseDetails.Columns[0].HeaderText = "م";
                    dgvPurchaseDetails.Columns[0].Width = 50;
                    dgvPurchaseDetails.Columns[0].ReadOnly= true;
                    dgvPurchaseDetails.Columns[1].HeaderText = "اسم المنتج";
                    dgvPurchaseDetails.Columns[1].Width = 150;
                    dgvPurchaseDetails.Columns[1].ReadOnly = true;

                    dgvPurchaseDetails.Columns[2].HeaderText = "سعر الشراء";
                    dgvPurchaseDetails.Columns[2].Width = 100;
                    dgvPurchaseDetails.Columns[2].ReadOnly = true;

                    dgvPurchaseDetails.Columns[3].HeaderText = "الكمية";
                    dgvPurchaseDetails.Columns[3].Width = 100;
                    dgvPurchaseDetails.Columns[3].ReadOnly = false;

                    dgvPurchaseDetails.Columns[4].HeaderText = "السعر الكلي";
                    dgvPurchaseDetails.Columns[4].Width = 100;
                    dgvPurchaseDetails.Columns[4].ReadOnly = true;

                    dgvPurchaseDetails.Columns[5].Visible= false;
                    dgvPurchaseDetails.Columns[6].HeaderText = "الكمية المعادة";
                    dgvPurchaseDetails.Columns[6].Width = 100;
                    dgvPurchaseDetails.Columns[6].ReadOnly = false;


                }


            }
        void _OnActionForPurchaseDetails()
        {
            lblTotalDebt.Text=_Purchase.RemainingAmountDebt.ToString();
            lblTotalAmountWithDebt.Text = _Purchase.NetTotalWithDebt.ToString();
            lblTotalAmountWithDiscoount.Text = _Purchase.NetTotalAmount.ToString();
            lblTotalAmountWithOutDebtAndDiscout.Text = _Purchase.TotalAmount.ToString();
            lblTotalQuantity.Text=_Purchase.TotalQ.ToString();
        }
        void LoadCategoriesToCobmoBox()
        {
            cbProductCategory.DataSource = clsProductCategory.GetAllProductsCategory();
            cbProductCategory.DisplayMember = "CategoryName";
            cbProductCategory.ValueMember = "CategoryID";
            cbProductCategory.SelectedIndex = 0;


        }
        private void FilterProductForCategory()
        {
            txtProductName.Clear();
            _AllProducts.DefaultView.RowFilter = string.Format("[{0}] like '%{1}%'", "CategoryName", cbProductCategory.Text);
            
        }
        void _SettleTheProductSideOnFormLoad()
        {
            dgvProductList.DataSource = _AllProducts;

            if (dgvProductList.Rows.Count > 0)
            {
                dgvProductList.Columns["SellingPrice"].HeaderText = "سعر البيع";
                dgvProductList.Columns["ProductName"].HeaderText = "اسم المنتج";
                dgvProductList.Columns["QuantityInStock"].HeaderText = "الكمية المتاحة";

            }
            dgvProductList.Columns["CategoryName"].Visible = false;
            dgvProductList.Columns["CostPrice"].Visible = false;
            dgvProductList.Columns["ProductID"].Visible = false;
            dgvProductList.Columns["UnitOfSale"].Visible = false;
            dgvProductList.Columns["ImagePath"].Visible = false;
            dgvProductList.Columns["BarCode"].Visible = false;
            dgvProductList.Columns["MinimumQuantityForWarning"].Visible = false;
            dgvProductList.Columns["CreateDate"].Visible = false;

            LoadCategoriesToCobmoBox();

            FilterProductForCategory();


        }

        private void cbProductCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterProductForCategory();
        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtProductName.Text.Trim()))
            {
                FilterProductForCategory();
                return;
            }



            _AllProducts.DefaultView.RowFilter = string.Format("[{0}] like '%{1}%'", "ProductName", txtProductName.Text.Trim());

        }

        private void dgvProductList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewRow row =
       dgvProductList.Rows[e.RowIndex];

            int quantity =
                Convert.ToInt32(row.Cells["QuantityInStock"].Value);

            if (quantity < 1)
            {
                row.DefaultCellStyle.BackColor = Color.Red;
                row.DefaultCellStyle.ForeColor = Color.White;

                row.DefaultCellStyle.SelectionBackColor = Color.DarkRed;
                row.DefaultCellStyle.SelectionForeColor = Color.White;
            }
            else
            {
                row.DefaultCellStyle.BackColor = Color.White;
                row.DefaultCellStyle.ForeColor = Color.Black;

                row.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 192, 192);
                row.DefaultCellStyle.SelectionForeColor = Color.White;
            }

        }

        private void tsmiAddToPurchase_Click(object sender, EventArgs e)
        {
            if (dgvProductList.SelectedRows.Count == 0)
            {
                return;
            }
            DataGridViewRow SelectedProduct = dgvProductList.SelectedRows[0];
            clsPurchaseDetailsDTO detailDTO=new clsPurchaseDetailsDTO();
            detailDTO.ProductID = (int)SelectedProduct.Cells["ProductID"].Value;
            detailDTO.ProductName=SelectedProduct.Cells["ProductName"].Value.ToString();
            detailDTO.ReturnQ = 0;
            detailDTO.Quantity = 1;
            detailDTO.CostPrice = Convert.ToDecimal(SelectedProduct.Cells["CostPrice"].Value);
       _Purchase.AddToPurchase(detailDTO);
            if(_Purchase.Details.Count==1)
            {
                _RefreshForm();
            }
         
            _OnActionForPurchaseDetails();


        }

        private void lnkSelectSupplier_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmFindSupplier frm=new frmFindSupplier();
            frm.SupplierSelected += Frm_SupplierSelected;
            frm.ShowDialog();
        }

        void _LoadSupplierInfo(int SupplierID)
        {
            clsSupplier supplier = clsSupplier.FindSupplierByID(SupplierID);
            if (supplier != null)
            {
                lblSupplierID.Text = SupplierID.ToString();
                lblSupplierName.Text = supplier.PersonInfo.FullName;
                lblSupplierPhone.Text= supplier.PersonInfo.Phone;
                _Purchase.SupplierID = SupplierID;
                _OnActionForPurchaseDetails();
            }

                    }
        private void Frm_SupplierSelected(object sender, frmFindSupplier.SupplierSelectedEventArgs e)
        {
            _LoadSupplierInfo(e.SupplierID);


        }

        private void txtPaidAmount_Leave(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtPaidAmount.Text))
            {
                _Purchase.PaidAmount = Convert.ToDecimal(txtPaidAmount.Text);
            }
       }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDiscount.Text))
                _Purchase.DiscountAmount = Convert.ToDecimal(txtDiscount.Text);
            else
                _Purchase.DiscountAmount = 0;
            _OnActionForPurchaseDetails();
        }

        private void dgvPurchaseDetails_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int ProductID = (int)dgvPurchaseDetails.Rows[e.RowIndex].Cells["ProductID"].Value;
            if (dgvPurchaseDetails.Columns["Quantity"].Index==e.ColumnIndex)
            {
                int NewQ = (int)dgvPurchaseDetails.Rows[e.RowIndex].Cells["Quantity"].Value;
                int OldRQ = (int)dgvPurchaseDetails.Rows[e.RowIndex].Cells["ReturnQ"].Value;
                if(NewQ<OldRQ)
                {
                    MessageBox.Show("لا يمكن ان تكون الكمية المعادة اكبر من الكمية الاصلية سيتم وضعها ال صفر", "خطأ في البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvPurchaseDetails.Rows[e.RowIndex].Cells["ReturnQ"].Value = "0";
                    _Purchase.EditReturnQ(ProductID, 0);
                }
                _Purchase.EditQuantity(ProductID, NewQ);
            }
            else
            {
                int NewRQ = (int)dgvPurchaseDetails.Rows[e.RowIndex].Cells["ReturnQ"].Value;
                int OldQ= (int)dgvPurchaseDetails.Rows[e.RowIndex].Cells["Quantity"].Value;
                if (OldQ < NewRQ)
                {
                    MessageBox.Show("لا يمكن ان تكون الكمية المعادة اكبر من الكمية الاصلية سيتم وضعها ال صفر", "خطأ في البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _Purchase.EditReturnQ(ProductID, 0);
                    dgvPurchaseDetails.Rows[e.RowIndex].Cells["ReturnQ"].Value = "0";

                }
                else
                {
                    _Purchase.EditReturnQ(ProductID, NewRQ);
                }
            }
            _OnActionForPurchaseDetails();
            
         }
        private void txtOnlyNumbes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
     !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }
        private void dgvPurchaseDetails_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvPurchaseDetails.CurrentCell.ColumnIndex == dgvPurchaseDetails.Columns["Quantity"].Index
                || dgvPurchaseDetails.CurrentCell.ColumnIndex == dgvPurchaseDetails .Columns["ReturnQ"].Index)
            {
                TextBox txt = e.Control as TextBox;
                if (txt != null)
                {
                    txt.KeyPress -= txtOnlyNumbes_KeyPress;
                    txt.KeyPress += txtOnlyNumbes_KeyPress;

                }


            }

        }
        private void _SetQuantityOfProductInGroupProductInfo(int Quantity, int MinQuantity)
        {
            lblQuantity.Text = $"الكمية: {Quantity}";
            if (Quantity <= MinQuantity)
            {
                lblQuantity.BackColor = Color.FromArgb(255, 128, 128);
                lblQuantity.ForeColor = Color.White;
            }
            else
            {

                lblQuantity.BackColor = Color.White;
                lblQuantity.ForeColor = Color.FromArgb(46, 204, 113);
            }
        }
        private void dgvPurchaseDetails_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataRow[] ProductsInf = _AllProducts.Select($"ProductID={dgvPurchaseDetails.Rows[e.RowIndex].Cells["ProductID"].Value.ToString()}");
            if (ProductsInf.Length == 0) MessageBox.Show("شي خاطء حدث عند عرض معلومات المنتج");


            if (e.RowIndex < 0 || dgvPurchaseDetails.Rows[e.RowIndex].IsNewRow) return;
            if (!string.IsNullOrEmpty(ProductsInf[0]["ImagePath"].ToString()))
                pbProductImage.ImageLocation = ProductsInf[0]["ImagePath"].ToString();
            else
                pbProductImage.Image = Resources.default_product;

            txtProductQuantity.Text = dgvPurchaseDetails.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();

            lblProductName.Text = ProductsInf[0]["ProductName"].ToString();
            lblQuantity.Text = $"الكمية: {ProductsInf[0]["QuantityInStock"].ToString()}";
            lblMinQuantity.Text = $"حد الطلب: {ProductsInf[0]["MinimumQuantityForWarning"].ToString()}";
            lblPurchasePrice.Text = $"سعر الشراء: {ProductsInf[0]["CostPrice"].ToString()}ل.س";
            lblCategory.Text = $"الصنف: {ProductsInf[0]["CategoryName"].ToString()}";

            _SetQuantityOfProductInGroupProductInfo(Convert.ToInt32(ProductsInf[0]["QuantityInStock"]), Convert.ToInt32(ProductsInf[0]["MinimumQuantityForWarning"]));


        }

        private void btnEditQuantity_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtProductQuantity.Text))
            {
                int quant = Convert.ToInt32(txtProductQuantity.Text);
                int ProductID = Convert.ToInt32(dgvPurchaseDetails.CurrentRow.Cells["ProductID"].Value);
             if(   _Purchase.EditQuantity(ProductID, quant))
                {
                    _OnActionForPurchaseDetails();
                }
             else
                {
                    MessageBox.Show("لا يمكن ان تكون الكمية المعادة اكبر تاكد من البيانات", "خطأ في البيانات", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
            else
            {
                MessageBox.Show("اكتب الكمية التي تريدها اولا", "خطأ في البيانات", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void الغاءمنالفاتورةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvPurchaseDetails.CurrentRow == null) return;
            int ProductID = Convert.ToInt32(dgvPurchaseDetails.CurrentRow.Cells["ProductID"].Value);
            if(!_Purchase.RemoveDetail(ProductID))
            {
                MessageBox.Show("لم نتمن من حذف العنصر من الفاتورة", "حدث خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                _OnActionForPurchaseDetails();
            }
        }
    }
}
