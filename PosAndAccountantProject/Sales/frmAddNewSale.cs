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

        private DataTable _AllProducts=clsProduct.GetAllProducts();
       

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
            if (e.ColumnIndex == dgvSaleDetails.Columns["clmQuantity"].Index)
            {

                DataGridViewCell cell = dgvSaleDetails.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if ((cell.Value == null || string.IsNullOrEmpty(cell.Value.ToString())) )
                {

                    cell.Value = "1";
                    return;

                }
               
                else
                {
                    HandleChangeQuantityInListSales(Convert.ToInt32(cell.Value),e.RowIndex);


                }
                


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

        private void HandleChangeQuantityInListSales(int  quantity,int RowIndex)
        {

            if (dgvSaleDetails.Rows[RowIndex ]!= null)
            {


                if (quantity == 0)
                {
                    dgvSaleDetails.Rows[RowIndex].Cells["clmQuantity"].Value = "1";
                    return;
                }

                DataRow ProductInfRow = _AllProducts.Select($"ProductID={dgvSaleDetails.Rows[RowIndex].Cells["clmProductID"].Value.ToString()}")[0];

                int TotalQuantityExist = Convert.ToInt32(ProductInfRow["QuantityInStock"].ToString());
                if (quantity <= TotalQuantityExist)
                    dgvSaleDetails.Rows[RowIndex].Cells["clmQuantity"].Value = quantity;
                else
                {
                    MessageBox.Show($"الكمية المتوفرة هي فقط: {TotalQuantityExist} يرجى اختيار كمية كافية سيتم اختيار كمية 1 ويمكنك تغييرها ", "كمية غير كافية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dgvSaleDetails.Rows[RowIndex].Cells["clmQuantity"].Value = 1;

                }
            }
          

        }

        private void btnEditQuantity_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtProductQuantity.Text.Trim()))
                HandleChangeQuantityInListSales(Convert.ToInt32(txtProductQuantity.Text.Trim()),dgvSaleDetails.CurrentRow.Index);
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
    }
}
