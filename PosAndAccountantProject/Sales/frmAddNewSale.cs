using PosAndAccountant_business;
using PosAndAccountantProject.Customers;
using PosAndAccountantProject.GlobalClasses;
using PosAndAccountantProject.Products;
using PosAndAccountantProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Web.Hosting;
using System.Windows.Forms;

namespace PosAndAccountantProject.Sales
{
    public partial class frmAddNewSale : Form
    {
        public frmAddNewSale()
        {
            InitializeComponent();
            _Sale = new clsSale();
        }
        public frmAddNewSale(int saleID)
        {
            InitializeComponent();
            _Sale=clsSale.Find(saleID);
            //_Sale.Mode = clsSale.enMode.eUpdate2;
        }
        private clsSale _Sale;

        private PosAndAccountantProject.Printing.ctrlSaleInvoice _currentReceipt = null;
        clsCustomer _SelectedCustomer;
        struct stProductSaleForTotalPriceInfo
        {
         public   double SalePrice;
            public double OldSalePrice;
         public   int OldQ;
         public   int NewQ;
         public   int OldReturnQ;
         public   int NewReturnQ;
      
        }

        private DataTable _AllProducts=clsProduct.GetAllProducts();
       
private void _LoadCustomerData(int CustomerID)
        {
            _SelectedCustomer = clsCustomer.FindCustomerByID(CustomerID);
            if( _SelectedCustomer != null )
            {
                lblCustomerID.Text=_SelectedCustomer.CustomerID.ToString();
                lblCustomerName.Text = _SelectedCustomer.PersonInfo.FullName;
                lblCustomerPhone.Text= _SelectedCustomer.PersonInfo.Phone;
                lblTotalDebt.Text=_SelectedCustomer.TotalRemainingDebt.ToString();
                _GetAndSetTotalAmountWithDebt(); 

            }
        }
        private void _UpdatTotalAmountWhenUpdatInSaleProductData(stProductSaleForTotalPriceInfo info)
        {
            double OldPrice = info.OldSalePrice * (info.OldQ - info.OldReturnQ);
            double NewPrice = info.SalePrice * (info.NewQ - info.NewReturnQ) ;
            double OldTotal = Convert.ToDouble(lblTotalAmountWithOutDebtAndDiscout.Text);
            lblTotalAmountWithOutDebtAndDiscout.Text = (OldTotal - OldPrice + NewPrice).ToString();
            _GetAndSetTotalAmountWithDisCount();
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

       private void _LoadData()
        {
            //if (_Sale.Mode == clsSale.enMode.eUpdate2)
            //{
            //    lblCustomerID.Text = _Sale.CustomerID.ToString();
            //    lblCustomerName.Text = _Sale.CustomerInfo.PersonInfo.FullName;
            //    lblCustomerPhone.Text=_Sale.CustomerInfo.PersonInfo.Phone;
            //    cbPayBy.SelectedValue = _Sale.PaymentMethodID;
            //   txtNotes.Text= _Sale.Notes;
            //    lblTotalDebt.Text=_Sale.CustomerInfo.TotalRemainingDebt.ToString();
            //    lblTotalAmountWithOutDebtAndDiscout.Text = _Sale.TotalAmount.ToString();
            //   txtDiscount.Text=_Sale.DiscountAmount.ToString();
            //    lblTotalAmountWithDiscoount.Text = (_Sale.TotalAmount - _Sale.DiscountAmount).ToString();
            //    //lblTotalAmountWithDebt.Text = (_Sale.TotalAmount - _Sale.DiscountAmount + _Sale.CustomerInfo.TotalRemainingDebt).ToString();
            //txtPaidAmount.Text=_Sale.PaidAmount.ToString();

                int TotalQ = 0;
                int Counter = 0;
               
                //foreach (DataRow row in _Sale.dtSaleDetails.Rows)
                //{
                //    DataGridViewRow grow = new DataGridViewRow();
                //    grow.CreateCells(dgvSaleDetails);
                //    Counter++;
                //    grow.Cells[0].Value = Counter;
                //    grow.Cells[1].Value = row["ProductName"];
                //    grow.Cells[2].Value = row["SellingPrice"];
                //    grow.Cells[3].Value = row["Quantity"];
                //    grow.Cells[5].Value = row["ReturnedQuantity"];
                //    grow.Cells[4].Value=(Convert.ToDouble(row["SellingPrice"])*(Convert.ToInt32(row["Quantity"])-Convert.ToInt32(row["ReturnedQuantity"])));
                //    grow.Cells[6].Value = row["DiscountAmount"];
                //    grow.Cells[7].Value = row["ProductID"];
                //    dgvSaleDetails.Rows.Add(grow);
                //    TotalQ += (Convert.ToInt32(row["Quantity"]) - Convert.ToInt32(row["ReturnedQuantity"]));
                //}
                //lblTotalQuantity.Text=TotalQ.ToString();
                //_Sale.dtSaleDetails.Columns.Remove("ProductName");

            }

         
        private void _HandleSaleDataOnLoad()
        {
            if(_Sale.Mode==clsSale.enMode.eAdd)
            {
                _Sale.UserID = 1;
                _Sale.Save();
            }
           //else if(_Sale.Mode==clsSale.enMode.eUpdate2)
           // {
           //     _LoadData();

           // }
            lblSaleID.Text = _Sale.SaleID.ToString();
            

        }
        private void frmAddNewSale_Load(object sender, EventArgs e)
        {
            _HandleSaleDataOnLoad();
            _SettleTheProductSideOnFormLoad();
            _LoadPaymentMethodToCompoBox();
            _LoadCustomerData(6);
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
 
            _SetQuantityOfProductInGroupProductInfo(Convert.ToInt32(row["QuantityInStock"]), Convert.ToInt32(row["MinimumQuantityForWarning"]));
        }
       
        double _GetAndSetTotalAmountWithDebt()
        {
            lblTotalAmountWithDebt.Text = (Convert.ToDouble(lblTotalAmountWithDiscoount.Text) + Convert.ToDouble(lblTotalDebt.Text)).ToString();
            return Convert.ToDouble(lblTotalAmountWithDebt.Text);
            
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
            _GetAndSetTotalAmountWithDisCount();       

        //Handl Quantity of product (-)
        _UpdatQuantityOfProductInDGVlistProduct(1,Convert.ToInt32(dgvProductList.SelectedRows[0].Cells["ProductID"].Value));

        }

        private DataGridViewRow _GetRowByProductIDInSaleDetails(int ProductID)
        {

            foreach (DataGridViewRow row in dgvSaleDetails.Rows)
            {
                if (!row.IsNewRow && row.Cells["clmProductID"].Value != null)
                {
                    if (Convert.ToInt32(row.Cells["clmProductID"].Value) == ProductID)
                    {
                        return row;
                    }
                }



            }

            return null;

        }
        private void اضافةللفاتورةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvProductList.SelectedRows.Count ==0)
            {
                return;
            }

            DataGridViewRow SelectedRow = dgvProductList.SelectedRows[0];

            int ProductID = Convert.ToInt32(SelectedRow.Cells["ProductID"].Value);
            DataGridViewRow SaleDetailRow = _GetRowByProductIDInSaleDetails(ProductID);

            if (SaleDetailRow == null)
            {
        SaleDetailRow = new DataGridViewRow();
                SaleDetailRow.CreateCells(dgvSaleDetails);
                if (dgvSaleDetails.Rows.Count > 0)

                    SaleDetailRow.Cells[0].Value = Convert.ToInt32(dgvSaleDetails.Rows[dgvSaleDetails.Rows.Count - 1].Cells[0].Value) + 1;
                else
                    SaleDetailRow.Cells[0].Value = 1;

                SaleDetailRow.Cells[1].Value = SelectedRow.Cells["ProductName"].Value;
                SaleDetailRow.Cells[2].Value = SelectedRow.Cells["SellingPrice"].Value;
                //Saving Orginal Selling Price In its tag
                SaleDetailRow.Cells[2].Tag = SelectedRow.Cells["SellingPrice"].Value;

                SaleDetailRow.Cells[3].Value = 1;
                SaleDetailRow.Cells[4].Value = Convert.ToDecimal(SaleDetailRow.Cells[2].Value) * Convert.ToDecimal(SaleDetailRow.Cells[3].Value);
                SaleDetailRow.Cells[5].Value = 0;
                SaleDetailRow.Cells[6].Value = 0;
                SaleDetailRow.Cells[7].Value = SelectedRow.Cells["ProductID"].Value;

                dgvSaleDetails.Rows.Add(SaleDetailRow);
                _ActionOnAddProductToSale();
            }
            else
            {
                HandleChangeQuantityInListSales(Convert.ToInt32(SaleDetailRow.Cells["clmQuantity"].Value)+1, SaleDetailRow.Index, Convert.ToInt32(SaleDetailRow.Cells["clmQuantity"].Value));
                return;
            }

           
          
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
                || dgvSaleDetails.CurrentCell.ColumnIndex == dgvSaleDetails.Columns["clmDiscount"].Index
                || dgvSaleDetails.CurrentCell.ColumnIndex == dgvSaleDetails.Columns["clmReturnQ"].Index)
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
                //for case if he repeate editing in same row and column

                dgvSaleDetails_CellEnter(null, new DataGridViewCellEventArgs(e.ColumnIndex, e.RowIndex));

                return;
            }

            stProductSaleForTotalPriceInfo info=new stProductSaleForTotalPriceInfo();
            info.NewQ = Convert.ToInt32(dgvSaleDetails.Rows[e.RowIndex].Cells["clmQuantity"].Value);
            info.OldQ= Convert.ToInt32(dgvSaleDetails.Rows[e.RowIndex].Cells["clmQuantity"].Value);
           info.OldSalePrice= Convert.ToDouble(dgvSaleDetails.Rows[e.RowIndex].Cells["clmSalePrice"].Value);

            if (e.ColumnIndex == dgvSaleDetails.Columns["clmDiscount"].Index)
            {
                info.OldReturnQ= Convert.ToInt32(dgvSaleDetails.Rows[e.RowIndex].Cells["clmReturnQ"].Value);
                info.NewReturnQ = info.OldReturnQ;
                if (string.IsNullOrEmpty(cell.Value.ToString().Trim()) || Convert.ToDouble(cell.Value)>
                    Convert.ToDouble(dgvSaleDetails.Rows[e.RowIndex].Cells["clmSalePrice"].Tag))
                {
                    cell.Value = 0;
                   

                }
                else
                {

                   
                    cell.Value = Convert.ToDouble(cell.Value); ;
                }

                info.SalePrice = Convert.ToDouble(dgvSaleDetails.Rows[e.RowIndex].Cells["clmSalePrice"].Tag)- Convert.ToDouble(cell.Value);
                dgvSaleDetails.Rows[e.RowIndex].Cells["clmSalePrice"].Value = info.SalePrice;
                _UpdatTotalAmountWhenUpdatInSaleProductData(info);
                _UpateTotalPriceInDGVForOneProductWhenChangeQuantity(info.SalePrice, info.NewQ - info.NewReturnQ, e.RowIndex);

                dgvSaleDetails_CellEnter(null, new DataGridViewCellEventArgs(e.ColumnIndex, e.RowIndex));

                return;

            }

          
            info.SalePrice = info.OldSalePrice;
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
                _AddQuantityProductOnDGVofProducts(info.NewReturnQ - info.OldReturnQ, Convert.ToInt32(dgvSaleDetails.Rows[e.RowIndex].Cells["clmProductID"].Value));
                _UpdatTotalAmountWhenUpdatInSaleProductData(info);
                _UpdateTotalQuantityWhenUpdatteReturnQuantity(info.OldReturnQ, info.NewReturnQ);
                _UpateTotalPriceInDGVForOneProductWhenChangeQuantity(info.SalePrice, info.NewQ, e.RowIndex);

                dgvSaleDetails_CellEnter(null, new DataGridViewCellEventArgs(e.ColumnIndex, e.RowIndex));

                return;



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


        private void dgvSaleDetails_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataRow[] ProductsInf = _AllProducts.Select($"ProductID={dgvSaleDetails.Rows[e.RowIndex].Cells["clmProductID"].Value.ToString()}");
            if (ProductsInf.Length == 0) MessageBox.Show("شي خاطء حدث عند عرض معلومات المنتج");


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

            _SetQuantityOfProductInGroupProductInfo(Convert.ToInt32(ProductsInf[0]["QuantityInStock"]),Convert.ToInt32(ProductsInf[0]["MinimumQuantityForWarning"]));
            

        }

        private void _UpdateTotalQuantityWhenUpdatteReturnQuantity(int OldReturnQ,int NewReturnQ)
        {
            lblTotalQuantity.Text = (Convert.ToInt32(lblTotalQuantity.Text) - (NewReturnQ-OldReturnQ)).ToString();

        }
        void _UpdateTotalQuantityForUpdatQuantityItem(int OldQ,int NewQ)
        {
            _UpdatQuantityOfProductInDGVlistProduct(NewQ - OldQ, Convert.ToInt32(dgvSaleDetails.CurrentRow.Cells["clmProductID"].Value));
            lblTotalQuantity.Text = (Convert.ToInt32(lblTotalQuantity.Text) - OldQ + NewQ).ToString();
        }

        private void _UpateTotalPriceInDGVForOneProductWhenChangeQuantity(double SellPrice,int NewQ,int RowIndex)
        {
            int ReturnQ = Convert.ToInt32(dgvSaleDetails.Rows[RowIndex].Cells["clmReturnQ"].Value);
            dgvSaleDetails.Rows[RowIndex].Cells["clmTotalPrice"].Value = (SellPrice * (NewQ - ReturnQ));
            //dgvSaleDetails.Rows[RowIndex].Cells["clmTotalPrice"].Value = (SellPrice * NewQ);
        }
            private void HandleChangeQuantityInListSales(int  quantity,int RowIndex,int OldQuantity)
        {

            if (dgvSaleDetails.Rows[RowIndex ]!= null)
            {
                stProductSaleForTotalPriceInfo info = new stProductSaleForTotalPriceInfo();
                info.OldQ = OldQuantity;

                info.NewReturnQ = Convert.ToInt32(dgvSaleDetails.CurrentRow.Cells["clmReturnQ"].Value);
                info.OldReturnQ = Convert.ToInt32(dgvSaleDetails.CurrentRow.Cells["clmReturnQ"].Value);
                info.SalePrice = Convert.ToDouble(dgvSaleDetails.CurrentRow.Cells["clmSalePrice"].Value);
                info.OldSalePrice = info.SalePrice;
                if (quantity == 0)
                {
                    dgvSaleDetails.Rows[RowIndex].Cells["clmQuantity"].Value = "1";
                    _UpdateTotalQuantityForUpdatQuantityItem(OldQuantity, 1);
                   
                    info.NewQ = 1;

                    txtProductQuantity.Tag = 1; ;
                    _UpateTotalPriceInDGVForOneProductWhenChangeQuantity(info.SalePrice,info.NewQ,RowIndex);
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
                    _UpateTotalPriceInDGVForOneProductWhenChangeQuantity(info.SalePrice, info.NewQ, RowIndex);

                }
                else
                {
                    MessageBox.Show($"الكمية المتوفرة هي فقط: {TotalQuantityExist} يرجى اختيار كمية كافية سيتم اختيار كمية 1 ويمكنك تغييرها ", "كمية غير كافية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dgvSaleDetails.Rows[RowIndex].Cells["clmQuantity"].Value = 1;
                    _UpdateTotalQuantityForUpdatQuantityItem(OldQuantity, 1);
                    info.NewQ = 1;
                    txtProductQuantity.Tag = 1; 
                    _UpdatTotalAmountWhenUpdatInSaleProductData(info);
                    _UpateTotalPriceInDGVForOneProductWhenChangeQuantity(info.SalePrice, info.NewQ, RowIndex);

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
        private double _GetAndSetTotalAmountWithDisCount()
        {
            if (string.IsNullOrEmpty(txtDiscount.Text.Trim()))
            {
                txtDiscount.Tag = 0;
                txtDiscount.Text = "0";
            }
            lblTotalAmountWithDiscoount.Text =( Convert.ToDouble(lblTotalAmountWithOutDebtAndDiscout.Text) - Convert.ToDouble(txtDiscount.Text)).ToString();
            _GetAndSetTotalAmountWithDebt();
            return Convert.ToDouble(lblTotalAmountWithDiscoount.Text);


        }

       
        private void txtDiscount_Leave(object sender, EventArgs e)
        {
            _GetAndSetTotalAmountWithDisCount();     
        }

        private void lnkSelectCustomer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmFindCustomer frm = new frmFindCustomer();
            frm.SelectCustomer += Frm_SelectCustomer;
            frm.ShowDialog();
        }

        private void Frm_SelectCustomer(object sender, frmFindCustomer.CustomerSelectedEventArgs e)
        {
            _LoadCustomerData(e.CustomrID);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {// 1. Create the receipt control instance here first
            _currentReceipt = new PosAndAccountantProject.Printing.ctrlSaleInvoice();

            // 2. Pass your textboxes and DataGridView data to it so it resizes its height dynamically
            string invId = lblSaleID.Text;
            string custName = lblCustomerName.Text;
            string totalAmt = lblTotalAmountWithOutDebtAndDiscout.Text;
            string netAmt = lblTotalAmountWithDiscoount.Text;
            string totalItemsCount = lblTotalQuantity.Text;
            string debt=lblTotalDebt.Text;
            _currentReceipt.PopulateAndResize(invId, custName, dgvSaleDetails, totalAmt, netAmt,debt, totalItemsCount,txtPaidAmount.Text);

            // 3. Convert the UserControl's pixel dimensions to hundredths of an inch (Printer standard at 96 DPI)
            int paperWidth = (int)((_currentReceipt.Width / 96.0) * 100);
            int paperHeight = (int)((_currentReceipt.Height / 96.0) * 100);

            // 4. Force the PrintDocument to use this exact custom paper size
            printDoc.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("CustomReceipt", paperWidth, paperHeight);

            // 5. Configure and open the Print Preview window
            printPreviewDlg.Width = 500;
            printPreviewDlg.Height = 700;
            printPreviewDlg.StartPosition = FormStartPosition.CenterScreen;

            printPreviewDlg.ShowDialog();

            // 6. Clean up memory safely after the user closes the preview window
            if (_currentReceipt != null)
            {
                _currentReceipt.Dispose();
                _currentReceipt = null;
            }
        }

        private void printDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (_currentReceipt == null) return;

            // 1. Create a blank digital image canvas using the exact size of our receipt
            Bitmap bmp = new Bitmap(_currentReceipt.Width, _currentReceipt.Height);

            // 2. Take a visual snapshot of the user control layout
            _currentReceipt.DrawToBitmap(bmp, new Rectangle(0, 0, _currentReceipt.Width, _currentReceipt.Height));

            // 3. Stamp it onto the page. Because the paper size now matches the bitmap perfectly, 
            // it will fill the page entirely with no blank margins on the right!
            e.Graphics.DrawImage(bmp, 0, 0);

            // 4. Dispose of the image asset immediately
            bmp.Dispose();
        }

        private void _SubtractFromTotalQuantity(int n)
        {
            if(n<=Convert.ToInt32(lblTotalQuantity.Text))
            {
                lblTotalQuantity.Text = (Convert.ToInt32(lblTotalQuantity.Text) - n).ToString();
            }
           
        }
        private void _SubtractProductPriceFromAllTotalAmount(double PriceProductAmount)
        {
            lblTotalAmountWithOutDebtAndDiscout.Text = (Convert.ToDouble(lblTotalAmountWithOutDebtAndDiscout.Text) - PriceProductAmount).ToString();
            lblTotalAmountWithDiscoount.Text = (Convert.ToDouble(lblTotalAmountWithDiscoount.Text) - PriceProductAmount).ToString();
            lblTotalAmountWithDebt.Text = (Convert.ToDouble(lblTotalAmountWithDebt.Text) - PriceProductAmount).ToString();
        }

        private void _AddQuantityProductOnDGVofProducts(int Quantity,int ProductID)
        {
            DataRow row = _AllProducts.Select($"ProductID={ProductID}")[0];
            int OldQ =Convert.ToInt32( row["QuantityInStock"]);
            row["QuantityInStock"] = (OldQ + Quantity);
        }
        private void _ActionOnDeleteItemFromSalesInvoice(DataGridViewRow row)
        {
            int Quantity = Convert.ToInt32(row.Cells["clmQuantity"].Value) - Convert.ToInt32(row.Cells["clmReturnQ"].Value);

            _AddQuantityProductOnDGVofProducts(Quantity, Convert.ToInt32(row.Cells["clmProductID"].Value));
            _SubtractFromTotalQuantity(Quantity);
            double PriceProductAmount = Convert.ToDouble(row.Cells["clmSalePrice"].Value) *
                (Convert.ToDouble(row.Cells["clmQuantity"].Value) - Convert.ToDouble(row.Cells["clmReturnQ"].Value));
            _SubtractProductPriceFromAllTotalAmount(PriceProductAmount);
        }
        private void الغاءمنالفاتورةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvSaleDetails.CurrentRow == null) return;
            _ActionOnDeleteItemFromSalesInvoice(dgvSaleDetails.CurrentRow);
            dgvSaleDetails.Rows.Remove(dgvSaleDetails.CurrentRow);

        }
        private bool _SaveSale()
         {
        //    _Sale.CustomerID=Convert.ToInt32(lblCustomerID.Text.Trim());
        //    _Sale.Notes=txtNotes.Text.Trim();
        //    _Sale.DiscountAmount=Convert.ToDouble(txtDiscount.Text.Trim());
        //    _Sale.TotalAmount=Convert.ToDouble (lblTotalAmountWithOutDebtAndDiscout.Text.Trim());
        //    _Sale.Status = 2;
        //    _Sale.PaidAmount=Convert.ToDouble(txtPaidAmount.Text.Trim());
        //    _Sale.PaymentMethodID = Convert.ToInt32(cbPayBy.SelectedValue);

        //    _Sale.dtSaleDetails.Rows.Clear();
        //    foreach (DataGridViewRow row in dgvSaleDetails.Rows)
        //    {
        //        if (row.IsNewRow) continue;
        //        _Sale.dtSaleDetails.Rows.Add(                 
        //            row.Cells["clmProductID"].Value,
        //               row.Cells["clmSalePrice"].Value,
        //            row.Cells["clmQuantity"].Value,
        //            row.Cells["clmReturnQ"].Value,
                
        //          row.Cells["clmDiscount"].Value


        //        );
        //    }

          return  _Sale.Save();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(_SaveSale())
            {
                MessageBox.Show("تم حفظ الفاتورة بنجاح", "نتيجة الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnPrint.PerformClick();
                btnOpenNewSale.PerformClick();
            }
            else
            {
                MessageBox.Show("حدث خطأ لم يتم حفظ الفاتورة", "نتيجة الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void _ReturnProductsToTable()
        {
            foreach(DataGridViewRow  DetailRow in dgvSaleDetails.Rows)
            {

                if (DetailRow.IsNewRow) continue;
                
                    int productId = Convert.ToInt32(DetailRow.Cells["clmProductID"].Value);
                int returnQty = Convert.ToInt32(DetailRow.Cells["clmQuantity"].Value)- Convert.ToInt32(DetailRow.Cells["clmReturnQ"].Value);
                DataRow[] matchedRows = _AllProducts.Select($"ProductID = {productId}");
            if(matchedRows.Length > 0)
                {
                    matchedRows[0]["QuantityInStock"] = Convert.ToInt32(matchedRows[0]["QuantityInStock"]) + returnQty;
                }
            
            }

            dgvSaleDetails.Rows.Clear();


        }
        private void _ReseteProductInfo()
        {
            pbProductImage.Image = Resources.default_product;
            lblProductName.Text = "اسم المنتج";
            lblSalePrice.Text = "0.00 ل.س";
            lblBarcode.Text = "Barcode: 000000";
            lblQuantity.Text = "المخزون الحالي: 0";
            lblMinQuantity.Text = "حد الطلب: 0";
            lblCategory.Text = "حد الطلب: 0";
            txtProductQuantity.Text = "";
        }
        private void _ReseteForNewSale()
        {
            lblTotalQuantity.Text = "0";
            lblTotalDebt.Text = "0";
            lblTotalAmountWithOutDebtAndDiscout.Text = "0";
            lblTotalAmountWithDiscoount.Text = "0";
            lblTotalAmountWithDebt.Text = "0";
            lblCustomerID.Text = "6";
            lblCustomerName.Text = "زبون نقدي";
            lblCustomerPhone.Text = "";
            cbPayBy.SelectedIndex = 0;
            txtDiscount.Text = "0";
            txtNotes.Text = "";
            txtPaidAmount.Text = "0";
            _ReturnProductsToTable();
            _ReseteProductInfo();
            _Sale = new clsSale();
            _Sale.UserID = 1;
            _Sale.Save();
            lblSaleID.Text = _Sale.SaleID.ToString();
        }

        private void btnOpenNewSale_Click(object sender, EventArgs e)
        {
            _ReseteForNewSale();
        }

        private void cbPayBy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
