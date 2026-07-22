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

namespace PosAndAccountantProject.Products
{
    public partial class frmListProducts : Form
    {
        public frmListProducts()
        {
            InitializeComponent();
        }

        private DataTable _AllProducts=clsProduct.GetAllProducts();


        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        void _RefreshForm()
        {
            _AllProducts = clsProduct.GetAllProducts();
            dgvProducts.DataSource = _AllProducts;
            lblTotalCount.Text=dgvProducts.Rows.Count.ToString();
            lblOutOfStockCount.Text = ((int)_AllProducts.Compute("Count(QuantityInStock)", "MinimumQuantityForWarning >= QuantityInStock")).ToString();

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {

            frmAddUpdateProduct frm=new frmAddUpdateProduct();
            frm.ShowDialog();
            if(frm.WasSaved)
            {
                _RefreshForm();
            }
            

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmListProducts_Load(object sender, EventArgs e)
        {
            dgvProducts.DataSource = _AllProducts;  
            lblTotalCount.Text=dgvProducts.Rows.Count.ToString();
            
            if(dgvProducts.Rows.Count > 0 )
            {
                dgvProducts.Columns[0].HeaderText = "معرف المنتج";
                dgvProducts.Columns[1].HeaderText = "اسم المنتج";
                dgvProducts.Columns[2].HeaderText = "واحدة البيع";
                dgvProducts.Columns[3].HeaderText = "الصنف";
                dgvProducts.Columns[4].HeaderText = "سعر البيع";
                dgvProducts.Columns[8].HeaderText = "تاريخ الانشاء";
                dgvProducts.Columns[8].DefaultCellStyle.Format="dd-MM-yyyy";

                dgvProducts.Columns[5].Visible = false;
                dgvProducts.Columns[6].Visible = false;
                dgvProducts.Columns[7].Visible = false;
                dgvProducts.Columns[9].Visible = false;
                dgvProducts.Columns[10].Visible = false;

                lblOutOfStockCount.Text= (  (int)_AllProducts.Compute("Count(QuantityInStock)", "MinimumQuantityForWarning >= QuantityInStock")).ToString();
            }






        }

       
        private void dgvProducts_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvProducts.Rows[e.RowIndex].IsNewRow) return;

            if (!string.IsNullOrEmpty(dgvProducts.Rows[e.RowIndex].Cells["ImagePath"].Value.ToString()))
                pbProductImage.ImageLocation = dgvProducts.Rows[e.RowIndex].Cells["ImagePath"].Value.ToString();
            else
                pbProductImage.Image = Resources.default_product;

            lblProductName.Text = dgvProducts.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
            lblQuantity.Text = $"الكمية: {dgvProducts.Rows[e.RowIndex].Cells["QuantityInStock"].Value.ToString()}";
            lblMinQuantity.Text = $"حد الطلب: {dgvProducts.Rows[e.RowIndex].Cells["MinimumQuantityForWarning"].Value.ToString()}";
            lblSalePrice.Text = $"سعر البيع: {Convert.ToInt32(dgvProducts.Rows[e.RowIndex].Cells["SellingPrice"].Value).ToString()}ل.س";
            lblCategory.Text = $"الصنف: {dgvProducts.Rows[e.RowIndex].Cells["CategoryName"].Value.ToString()}";
            if (Convert.ToInt32(dgvProducts.Rows[e.RowIndex].Cells["QuantityInStock"].Value) <= Convert.ToInt32(dgvProducts.Rows[e.RowIndex].Cells["MinimumQuantityForWarning"].Value)) 
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

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductInfo frm = new frmProductInfo(Convert.ToInt32(dgvProducts.CurrentRow.Cells["ProductID"].Value));
            frm.ShowDialog();
            if(frm.WasUpated)
            {
                _RefreshForm();
            }

           
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateProduct frm = new frmAddUpdateProduct(Convert.ToInt32(dgvProducts.CurrentRow.Cells["ProductID"].Value));
            frm.ShowDialog();
            if (frm.WasSaved)
            {
                _RefreshForm();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int ProductID = Convert.ToInt32(dgvProducts.CurrentRow.Cells["ProductID"].Value);
            if (MessageBox.Show($"هل متاكد من حذف المنتج ذو المعرف:{ProductID}", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (clsProduct.DeleteProduct(ProductID))
                {
                    _RefreshForm();
                    MessageBox.Show($"المنتج ذو المعرف={ProductID} حذف بنجاح", "النتيجة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"فشل في حذف المنتج ذو المعرف={ProductID},يوجد بيانات مربوطة به", "النتيجة", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            _AllProducts.DefaultView.RowFilter = "";
            lblTotalCount.Text = dgvProducts.Rows.Count.ToString();
            txtFilterValue.Clear();
           
            if (cbFilterBy.SelectedIndex==0)
            {
                txtFilterValue.Visible = false;
            }
            else
            {
                txtFilterValue.Visible = true;
            }    
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtFilterValue.Text.Trim())|| cbFilterBy.SelectedIndex==0)
            {
                _AllProducts.DefaultView.RowFilter = "";
                lblTotalCount.Text = dgvProducts.Rows.Count.ToString();
                return;

            }
            string ColumnName = "";

            switch (cbFilterBy.SelectedIndex)
            {
                case 1:
                    {
                        ColumnName = "ProductName";
                        break;
                    }
                    case 2:
                    {

                        ColumnName = "BarCode";
                        break;
                    }
                case 3:
                    {
                        ColumnName = "CategoryName";
                        break;
                    }

            }

            _AllProducts.DefaultView.RowFilter=string.Format("[{0}] like '%{1}%'",ColumnName,txtFilterValue.Text.Trim());

        }
    }
}
