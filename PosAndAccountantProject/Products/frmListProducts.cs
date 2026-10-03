using PosAndAccountant_business;
using PosAndAccountantProject.Properties;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PosAndAccountantProject.Products
{
    public partial class frmListProducts : Form
    {
        public frmListProducts()
        {
            InitializeComponent();
        }

        private DataTable _AllProducts = clsProduct.GetAllProducts(1, 10);


        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        void _RefreshForm()
        {
            _AllProducts = clsProduct.GetAllProducts(Convert.ToInt32(lblPageNumber.Text), 10);
            dgvProducts.DataSource = _AllProducts;
            lblTotalCount.Text = dgvProducts.Rows.Count.ToString();
            lblOutOfStockCount.Text = ((int)_AllProducts.Compute("Count(QuantityInStock)", "MinimumQuantityForWarning >= QuantityInStock")).ToString();

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {

            frmAddUpdateProduct frm = new frmAddUpdateProduct();
            frm.ShowDialog();
            if (frm.WasSaved)
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
            


            lblPageNumber.Text = "1";
            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.Columns.Clear();

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ProductID",
                HeaderText = "معرف المنتج",
                DataPropertyName = "ProductID",
                ReadOnly = true

            });
           

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ProductName",
                HeaderText = "المبلغ المدفوع",
                DataPropertyName = "ProductName",
                ReadOnly = true
            });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "UnitOfSale",
                HeaderText = "اسم العميل",
                DataPropertyName = "UnitOfSale",
                ReadOnly = true
            }); dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CategoryName",
                HeaderText = "المبلع الكلي",
                DataPropertyName = "CategoryName",
                ReadOnly = true
            });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SellingPrice",
                HeaderText = "تاريخ الانشاء",
                DataPropertyName = "SellingPrice",
                ReadOnly = true
            });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CreateDate",
                HeaderText = "تاريخ الانشاء",
                DataPropertyName = "CreateDate",
                ReadOnly = true
            }); dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ImagePath",
                Visible = false,
                DataPropertyName = "ImagePath",
                ReadOnly = true
            });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CostPrice",
                Visible = false,
                DataPropertyName = "CostPrice",

                ReadOnly = true
            });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "QuantityInStock",
                Visible = false,
                DataPropertyName = "QuantityInStock",

                ReadOnly = true
            });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MinimumQuantityForWarning",
                Visible = false,
                DataPropertyName = "MinimumQuantityForWarning",

                ReadOnly = true
            });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "BarCode",
                Visible = false,
                DataPropertyName = "BarCode",

                ReadOnly = true
            });

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ProductCategoryID",
                Visible = false,
                DataPropertyName = "ProductCategoryID",

                ReadOnly = true
            });
            dgvProducts.DataSource = clsProduct.GetAllProducts(1, 10);


             lblTotalCount.Text = dgvProducts.Rows.Count.ToString();


 


                lblOutOfStockCount.Text = ((int)_AllProducts.Compute("Count(QuantityInStock)", "MinimumQuantityForWarning >= QuantityInStock")).ToString();
           






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
            if (frm.WasUpated)
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

            if (cbFilterBy.SelectedIndex == 0)
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
            if (string.IsNullOrEmpty(txtFilterValue.Text.Trim()) || cbFilterBy.SelectedIndex == 0)
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

            _AllProducts.DefaultView.RowFilter = string.Format("[{0}] like '%{1}%'", ColumnName, txtFilterValue.Text.Trim());

        }

        private void lnkPrivios_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lblPageNumber.Text != "1")
                lblPageNumber.Text = (Convert.ToInt32(lblPageNumber.Text) - 1).ToString();

        }

        private void lnkNext_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblPageNumber.Text = (Convert.ToInt32(lblPageNumber.Text) + 1).ToString();

        }

        private void lblPageNumber_Click(object sender, EventArgs e)
        {

        }

        private void lblPageNumber_TextChanged(object sender, EventArgs e)
        {
            dgvProducts.DataSource=clsProduct.GetAllProducts(Convert.ToInt32(lblPageNumber.Text),10);        }
         }
}
