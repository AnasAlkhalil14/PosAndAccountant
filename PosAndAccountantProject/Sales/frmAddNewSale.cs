using PosAndAccountant_business;
using PosAndAccountantProject.Products;
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

namespace PosAndAccountantProject.Sales
{
    public partial class frmAddNewSale : Form
    {
        public frmAddNewSale()
        {
            InitializeComponent();
        }

        struct stProductSaleForTotalPriceInfo
        {
         public   double SalePrice;
         public   int OldQ;
         public   int NewQ;
         public   int OldReturnQ;
         public   int NewReturnQ;
         public   double NewDiscount;
            public double OldDiscount;

        }

        private DataTable _AllProducts=clsProduct.GetAllProducts();
       
        private void _UpdatTotalAmountWhenUpdatInSaleProductData(stProductSaleForTotalPriceInfo info)
        {
            double OldPrice = info.SalePrice * (info.OldQ - info.OldReturnQ) - info.OldDiscount;
            double NewPrice = info.SalePrice * (info.NewQ - info.NewReturnQ) - info.NewDiscount;
            double OldTotal = Convert.ToDouble(lblTotalAmountWithOutDebtAndDiscout.Text);
            lblTotalAmountWithOutDebtAndDiscout.Text = (OldTotal - OldPrice + NewPrice).ToString();
            lblTotalAmountWithDiscoount.Text= _GetTotalAmountWithDisCount().ToString();
        }

        private int _GetTotalQuantity()
        {
            int total = 0;
            if(dgvSaleDetails.Rows.Count <1  ) return total;

            foreach(DataGridViewRow row in dgvSaleDetails.Rows )
            {
                if (row.IsNewRow) continue;
                if (row.Cells["Quantity"].Value != null &&
            int.TryParse(row.Cells["Quantity"].Value.ToString(), out int qty))
                {
                    total += qty;
                }

            }
            return total;


        }
        void LoadCategoriesToCobmoBox()
        {
            cbProductCategory.DataSource = clsProductCategory.GetAllProductsCategory();
            cbProductCategory.DisplayMember = "CategoryName";
            cbProductCategory.ValueMember = "CategoryID";
            cbProductCategory.SelectedIndex = 0;


        }
        private void _LoadPaymentMethodToCompoBox()
        {
            cbPayBy.DataSource = clsPaymentMethod.AllPaymentMethos();
            cbPayBy.DisplayMember = "PaymentMethodName";
            cbPayBy.ValueMember = "PaymentMethodID";
            cbPayBy.SelectedIndex = 0;

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

            dgvProductList.Columns["ProductID"].Visible = false;
            dgvProductList.Columns["UnitOfSale"].Visible = false;
            dgvProductList.Columns["ImagePath"].Visible = false;
            dgvProductList.Columns["BarCode"].Visible = false;
            dgvProductList.Columns["MinimumQuantityForWarning"].Visible = false;
            dgvProductList.Columns["CreateDate"].Visible = false;

            LoadCategoriesToCobmoBox();

            FilterProductForCategory();

           
        }
        private void frmAddNewSale_Load(object sender, EventArgs e)
        {
            _SettleTheProductSideOnFormLoad();
            _LoadPaymentMethodToCompoBox();

            dgvSaleDetails.Columns[1].Width = 234;
            dgvSaleDetails.Columns[3].Width = 60;

          

        


        }

        private void cbProductCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterProductForCategory();
        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtProductName.Text.Trim()))
            {
                FilterProductForCategory();
                return;
            }

             

            _AllProducts.DefaultView.RowFilter = string.Format("[{0}] like '%{1}%'", "ProductName", txtProductName.Text.Trim());


        }

        private void _UpdatQuantityOfProductInDGVlistProduct(int NumberToSubtract,int ProductID)
        {
            DataRow row=_AllProducts.Select($"ProductID={ProductID}")[0];
            row["QuantityInStock"] = (Convert.ToInt32(row["QuantityInStock"]) - NumberToSubtract);

        }
        private void _ActionOnAddProductToSale()
        {
            //handle TotalProductCount
            lblTotalQuantity.Text = (Convert.ToInt32(lblTotalQuantity.Text) + 1).ToString();
            //HandlTotalPricec
            if (dgvProductList.SelectedRows.Count == 0)
            {
                return;
            }
            double SellingPrice = Convert.ToDouble(dgvProductList.SelectedRows[0].Cells["SellingPrice"].Value);
            lblTotalAmountWithOutDebtAndDiscout.Text = (Convert.ToDouble(lblTotalAmountWithOutDebtAndDiscout.Text)+SellingPrice).ToString();
            lblTotalAmountWithDiscoount.Text = _GetTotalAmountWithDisCount().ToString();

            //Handl Quantity of product (-)
            _UpdatQuantityOfProductInDGVlistProduct(1,Convert.ToInt32(dgvProductList.SelectedRows[0].Cells["ProductID"].Value));

        }
        private void اضافةللفاتورةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvProductList.SelectedRows.Count ==0)
            {
                return;
            }

            DataGridViewRow SelectedRow = dgvProductList.SelectedRows[0];

            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dgvSaleDetails);
            if(dgvSaleDetails.Rows.Count > 0 ) 

            row.Cells[0].Value = Convert.ToInt32(dgvSaleDetails.Rows[dgvSaleDetails.Rows.Count - 1].Cells[0].Value) + 1;
       else
                row.Cells[0].Value = 1;

            row.Cells[1].Value = SelectedRow.Cells["ProductName"].Value;
            row.Cells[2].Value = SelectedRow.Cells["SellingPrice"].Value;
            row.Cells[3].Value = 1;
            row.Cells [4].Value = Convert.ToDecimal(row.Cells[2].Value) * Convert.ToDecimal(row.Cells[3].Value);
            row.Cells[5].Value = 0;
            row.Cells[6].Value = 0;
            row.Cells[7].Value = SelectedRow.Cells["ProductID"].Value;

            _ActionOnAddProductToSale();
            dgvSaleDetails.Rows.Add(row);
        }

        private void txtProductName_KeyPress(object sender, KeyPressEventArgs e)
        {
if(e.KeyChar=='\'')
            {
                e.Handled = true;
            }
        }

        private void _RefreshProductList()
        {
            _AllProducts = clsProduct.GetAllProducts();

dgvProductList.DataSource = _AllProducts;

            FilterProductForCategory();

           
        }
        private void عرضToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductInfo frm = new frmProductInfo(Convert.ToInt32(dgvProductList.SelectedRows[0].Cells["ProductID"].Value));
            frm.ShowDialog();
            if(frm.WasUpated)
            {
                _RefreshProductList();
            }

        }

        private void dgvSaleDetails_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvSaleDetails.CurrentCell.ColumnIndex == dgvSaleDetails.Columns["clmQuantity"].Index
                | dgvSaleDetails.CurrentCell.ColumnIndex == dgvSaleDetails.Columns["clmDiscount"].Index)
            {
                TextBox txt=e.Control as TextBox;
                if(txt!=null)
                {
                    txt.KeyPress -= txtOnlyNumbes_KeyPress;
                    txt.KeyPress += txtOnlyNumbes_KeyPress;

                }


            }

        }

        private void txtOnlyNumbes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
     !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void dgvSaleDetails_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = dgvSaleDetails.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if (e.ColumnIndex == dgvSaleDetails.Columns["clmQuantity"].Index)
            {
              
                int RowIndex = e.RowIndex;
                int OldQ = Convert.ToInt32(cell.Tag);
                int NewQ;
                if ((cell.Value == null || string.IsNullOrEmpty(cell.Value.ToString())) )
                {

                    cell.Value = "1";
                    NewQ = 1;
                    
                }
               
                else
                {
                      NewQ = Convert.ToInt32(cell.Value);

                }
                HandleChangeQuantityInListSales(NewQ, RowIndex, OldQ);
                return;
            }

            stProductSaleForTotalPriceInfo info=new stProductSaleForTotalPriceInfo();
            info.NewQ = Convert.ToInt32(dgvSaleDetails.Rows[e.RowIndex].Cells["clmQuantity"].Value);
            info.OldQ= Convert.ToInt32(dgvSaleDetails.Rows[e.RowIndex].Cells["clmQuantity"].Value);
           info.SalePrice= Convert.ToInt32(dgvSaleDetails.Rows[e.RowIndex].Cells["clmSalePrice"].Value);

            if (e.ColumnIndex == dgvSaleDetails.Columns["clmDiscount"].Index)
            {
                info.OldDiscount = Convert.ToInt32(cell.Tag);
                info.OldReturnQ= Convert.ToInt32(dgvSaleDetails.Rows[e.RowIndex].Cells["clmReturnQ"].Value);
                info.NewReturnQ = info.OldReturnQ;
                if (string.IsNullOrEmpty(cell.Value.ToString().Trim()))
                {
                    cell.Value = 0;
                    info.NewDiscount = 0;

                }
                else
                {

                    info.NewDiscount=Convert.ToDouble(cell.Value);
                    cell.Value = info.NewDiscount;
                }
                _UpdatTotalAmountWhenUpdatInSaleProductData(info);
                return;

            }

            info.NewDiscount = Convert.ToDouble(dgvSaleDetails.Rows[e.RowIndex].Cells["clmDiscount"].Value); ;
            info.OldDiscount = info.NewDiscount;

            if (e.ColumnIndex == dgvSaleDetails.Columns["clmReturnQ"].Index)
            {
                info.OldReturnQ = Convert.ToInt32(cell.Tag);
                if (cell.Value==null|| string.IsNullOrEmpty(cell.Value.ToString().Trim()))
                {
                    cell.Value = 0;
                    info.NewReturnQ = 0;

                }
                else
                {
                   
                    if(info.NewQ>= Convert.ToInt32(cell.Value))
                    {
                        info.NewReturnQ = Convert.ToInt32(cell.Value);
                        cell.Value = info.NewReturnQ;

                    }
                    else
                    {
                        MessageBox.Show($"الكمية الكلية المفوترة من هذا المنتج :{info.NewQ} يرجى اختيار كمية مناسبة سيتم اعادة الحقل الى القيمة صفر 0","كمية كبيرة جدا خطأ",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        cell.Value = 0;
                        info.NewReturnQ = 0;

                    }

                }
                _UpdatTotalAmountWhenUpdatInSaleProductData(info);
                return;



            }

        }

        private void dgvSaleDetails_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataRow[] ProductsInf = _AllProducts.Select($"ProductID={dgvSaleDetails.Rows[e.RowIndex].Cells["clmProductID"].Value.ToString()}");
            if (ProductsInf.Length == 0) MessageBox.Show("Errr");


            if (e.RowIndex < 0 || dgvSaleDetails.Rows[e.RowIndex].IsNewRow) return;
            if (!string.IsNullOrEmpty(ProductsInf[0]["ImagePath"].ToString()))
                pbProductImage.ImageLocation = ProductsInf[0]["ImagePath"].ToString();
            else
                pbProductImage.Image = Resources.default_product;

            txtProductQuantity.Tag = dgvSaleDetails.Rows[e.RowIndex].Cells["clmQuantity"].Value.ToString();
            txtProductQuantity.Text = txtProductQuantity.Tag.ToString();

            lblProductName.Text = ProductsInf[0]["ProductName"].ToString();
            lblQuantity.Text = $"الكمية: {ProductsInf[0]["QuantityInStock"].ToString()}";
            lblMinQuantity.Text = $"حد الطلب: {ProductsInf[0]["MinimumQuantityForWarning"].ToString()}";
            lblSalePrice.Text = $"سعر البيع: {ProductsInf[0]["SellingPrice"].ToString()}ل.س";
            lblCategory.Text = $"الصنف: {ProductsInf[0]["CategoryName"] .ToString()}";
            if (Convert.ToInt32(ProductsInf[0]["QuantityInStock"].ToString()) <= Convert.ToInt32(ProductsInf[0]["MinimumQuantityForWarning"].ToString()))
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

        void _UpdateTotalQuantityForUpdatQuantityItem(int OldQ,int NewQ)
        {
            _UpdatQuantityOfProductInDGVlistProduct(NewQ - OldQ, Convert.ToInt32(dgvSaleDetails.CurrentRow.Cells["clmProductID"].Value));
            lblTotalQuantity.Text = (Convert.ToInt32(lblTotalQuantity.Text) - OldQ + NewQ).ToString();
        }
            private void HandleChangeQuantityInListSales(int  quantity,int RowIndex,int OldQuantity)
        {

            if (dgvSaleDetails.Rows[RowIndex ]!= null)
            {
                stProductSaleForTotalPriceInfo info = new stProductSaleForTotalPriceInfo();
                info.OldQ = OldQuantity;
                info.OldDiscount = Convert.ToInt32(dgvSaleDetails.CurrentRow.Cells["clmDiscount"].Value);
                info.NewDiscount = info.OldDiscount;

                info.NewReturnQ = Convert.ToInt32(dgvSaleDetails.CurrentRow.Cells["clmReturnQ"].Value);
                info.OldReturnQ = Convert.ToInt32(dgvSaleDetails.CurrentRow.Cells["clmReturnQ"].Value);
                info.SalePrice = Convert.ToInt32(dgvSaleDetails.CurrentRow.Cells["clmSalePrice"].Value);
                if (quantity == 0)
                {
                    dgvSaleDetails.Rows[RowIndex].Cells["clmQuantity"].Value = "1";
                    _UpdateTotalQuantityForUpdatQuantityItem(OldQuantity, 1);
                   
                    info.NewQ = 1;

                    txtProductQuantity.Tag = 1; ;
                    _UpdatTotalAmountWhenUpdatInSaleProductData(info);
                    return;
                }

                DataRow ProductInfRow = _AllProducts.Select($"ProductID={dgvSaleDetails.Rows[RowIndex].Cells["clmProductID"].Value.ToString()}")[0];

                int TotalQuantityExist = Convert.ToInt32(ProductInfRow["QuantityInStock"].ToString());
                if (quantity - OldQuantity <= TotalQuantityExist)
                {
                    txtProductQuantity.Tag = quantity;
                    dgvSaleDetails.Rows[RowIndex].Cells["clmQuantity"].Value = quantity;
                    info.NewQ = quantity;
                    _UpdateTotalQuantityForUpdatQuantityItem(OldQuantity, quantity);
                    _UpdatTotalAmountWhenUpdatInSaleProductData(info);

                }
                else
                {
                    MessageBox.Show($"الكمية المتوفرة هي فقط: {TotalQuantityExist} يرجى اختيار كمية كافية سيتم اختيار كمية 1 ويمكنك تغييرها ", "كمية غير كافية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dgvSaleDetails.Rows[RowIndex].Cells["clmQuantity"].Value = 1;
                    _UpdateTotalQuantityForUpdatQuantityItem(OldQuantity, 1);
                    info.NewQ = 1;
                    txtProductQuantity.Tag = 1; 
                    _UpdatTotalAmountWhenUpdatInSaleProductData(info);

                }
            }
          

        }

        private void btnEditQuantity_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtProductQuantity.Text.Trim())&&dgvSaleDetails.CurrentRow!=null)
            { int NewQ = Convert.ToInt32(txtProductQuantity.Text.Trim());
                int RowIndex = dgvSaleDetails.CurrentRow.Index;
                int OldQ = Convert.ToInt32(txtProductQuantity.Tag);
                HandleChangeQuantityInListSales(NewQ, RowIndex,OldQ);
               
            }
                txtProductQuantity.Clear();
        }

        private void dgvProductList_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
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

        private void cmsProduct_Opening(object sender, CancelEventArgs e)
        {
            if (Convert.ToInt32(dgvProductList.SelectedRows[0].Cells["QuantityInStock"].Value)<1)
            {
                tsmiAddToSale.Enabled = false ;
            } 
            else
            {  tsmiAddToSale.Enabled = true ;}
        }

        private void dgvSaleDetails_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvSaleDetails.Columns["clmQuantity"].Index||
                e.ColumnIndex == dgvSaleDetails.Columns["clmDiscount"].Index||
                e.ColumnIndex == dgvSaleDetails.Columns["clmReturnQ"].Index)
            {
               
                dgvSaleDetails.CurrentRow.Cells["clmQuantity"].Tag = dgvSaleDetails.CurrentRow.Cells["clmQuantity"].Value;
                dgvSaleDetails.CurrentRow.Cells["clmDiscount"].Tag = dgvSaleDetails.CurrentRow.Cells["clmDiscount"].Value;
                dgvSaleDetails.CurrentRow.Cells["clmReturnQ"].Tag = dgvSaleDetails.CurrentRow.Cells["clmReturnQ"].Value;

            }


        }

        private double _GetTotalAmountWithDisCount()
        {
            if(string.IsNullOrEmpty(txtDiscount.Text.Trim()))
            {
                txtDiscount.Tag = 0;
                txtDiscount.Text = "0";
            }
            return Convert.ToDouble(lblTotalAmountWithOutDebtAndDiscout.Text) - Convert.ToDouble(txtDiscount.Text);


        }
        private void txtDiscount_Leave(object sender, EventArgs e)
        {
            lblTotalAmountWithDiscoount.Text = _GetTotalAmountWithDisCount().ToString();
        }

        
    }
}
