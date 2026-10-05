using PosAndAccountant_business;
using PosAndAccountantProject.Properties;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PosAndAccountantProject.Products
{
    public partial class frmListProducts : Form
    {
        public frmListProducts()
        {
            InitializeComponent();
        }
        enum enGridSource { eAll,eMostSale,eMostProfit,eSlowMove,eLowStock}
        enGridSource GridSource=enGridSource.eAll;
        private DataTable _AllProducts = clsProduct.GetAllProducts(1, 10);


        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        void _RefreshForm()
        {
           dgvProducts.DataSource = clsProduct.GetAllProducts(Convert.ToInt32(lblPageNumber.Text), 10);
             lblTotalCount.Text = clsProduct.CountStockProducts().ToString();
            lblOutOfStockCount.Text =clsProduct.CountOfLowStockProducts() .ToString();
            lblValueOfStock.Text = clsProduct.GetTotalValueOfStock().ToString();
lblCountLoseProduct.Text=clsProduct.CountLoseProduct().ToString();
            _LoadDataTochart();
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
        private void _LoadDataTochart()
        {
            DataTable dt = clsProduct.GetMostProfitProductsInMonth();

            chart.Series.Clear();
            chart.ChartAreas.Clear();
            chart.Titles.Clear();
            chart.Legends.Clear();

            chart.RightToLeft = RightToLeft.Yes;
            chart.BackColor = Color.White;
            chart.AntiAliasing = AntiAliasingStyles.All;
            chart.TextAntiAliasingQuality = TextAntiAliasingQuality.High;

            // العنوان
            chart.Titles.Add(new Title("الربح حسب المنتج لهذا الشهر", Docking.Top,
                new Font("Segoe UI", 14, FontStyle.Bold), Color.FromArgb(40, 40, 40)));

            // منطقة الرسم
            var area = new ChartArea("Main") { BackColor = Color.White };

            area.AxisX.Interval = 1;
            area.AxisX.IsReversed = true;                  // first product on the right (RTL)
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisX.LabelStyle.Angle = -45;
            area.AxisX.LabelStyle.Font = new Font("Segoe UI", 9);
            area.AxisX.Title = "المنتج";
            area.AxisX.TitleFont = new Font("Segoe UI", 10, FontStyle.Bold);

            area.AxisY.Title = "الربح";
            area.AxisY.TitleFont = new Font("Segoe UI", 10, FontStyle.Bold);
            area.AxisY.LabelStyle.Format = "N0";
            area.AxisY.LabelStyle.Font = new Font("Segoe UI", 9);
            area.AxisY.MajorGrid.LineColor = Color.Gainsboro;
            area.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            chart.ChartAreas.Add(area);

            // السلسلة
            var series = new Series("الربح")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.FromArgb(52, 152, 219),
                IsValueShownAsLabel = true,
                LabelFormat = "N0",
                Font = new Font("Segoe UI", 8, FontStyle.Bold),
                ["PointWidth"] = "0.6"
            };
            chart.Series.Add(series);

            // ترتيب حسب الربح (الأعلى أولاً)
            DataView view = dt.DefaultView;
            view.Sort = "Profit DESC";

            foreach (DataRowView row in view)
            {
                string name = row["ProductName"].ToString();
                decimal profit = row["Profit"] == DBNull.Value ? 0 : Convert.ToDecimal(row["Profit"]);

                int i = series.Points.AddXY(name, profit);
                DataPoint p = series.Points[i];

                p.ToolTip = $"{name}: {profit:N0}";
                if (profit < 0) p.Color = Color.FromArgb(231, 76, 60);   // أحمر للخسارة
            }
        }
        private void frmListProducts_Load(object sender, EventArgs e)
        {
            


           
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
                HeaderText = "اسم المنتج",
                DataPropertyName = "ProductName",
                ReadOnly = true
            });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "UnitOfSale",
                HeaderText = "وحدة البيع",
                DataPropertyName = "UnitOfSale",
                ReadOnly = true
            }); dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CategoryName",
                HeaderText = "الصنف",
                DataPropertyName = "CategoryName",
                ReadOnly = true
            });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SellingPrice",
                HeaderText = "سعر البيع",
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

            _RefreshForm();


           

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
            switch (GridSource)
            {
                case enGridSource.eMostSale:
                    {
                        _AllProducts = clsProduct.GetMostSaledProducts(Convert.ToInt32(lblPageNumber.Text), 10);
                        break;
                    }
                case enGridSource.eSlowMove:
                    {
                        _AllProducts = clsProduct.GetLowSaledProducts(Convert.ToInt32(lblPageNumber.Text), 10);
                        break;
                    }
                case enGridSource.eLowStock:
                    {
                        _AllProducts = clsProduct.GetLowStockProducts(Convert.ToInt32(lblPageNumber.Text), 10);
                        break;
                    }
                case enGridSource.eMostProfit:
                    {
                        _AllProducts = clsProduct.GetMostProfitProducts(Convert.ToInt32(lblPageNumber.Text), 10);
                        break;
                    }
                default:
                    {
                        _AllProducts = clsProduct.GetAllProducts(Convert.ToInt32(lblPageNumber.Text), 10);
                        break;
                    }


            }
            dgvProducts.DataSource = _AllProducts;

        }

        private void lnkSlowMoving_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GridSource = enGridSource.eSlowMove;
            if(lblPageNumber.Text!="1")
            lblPageNumber.Text = "1";
            else
                lblPageNumber_TextChanged(null,null);
            lnkEveryProduct.BackColor = Color.White;
            lnkLowStock.BackColor = Color.White;
            lnkMostProfit.BackColor = Color.White;
            lnkSlowMoving.BackColor = Color.Silver;
            lnkMostSold.BackColor = Color.White;
        }

        private void lnkEveryProduct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GridSource = enGridSource.eAll;
            if (lblPageNumber.Text != "1")
                lblPageNumber.Text = "1";
            else
                lblPageNumber_TextChanged(null, null);
            lnkEveryProduct.BackColor= Color.Silver;
            lnkLowStock.BackColor= Color.White;
            lnkMostProfit.BackColor= Color.White;
            lnkSlowMoving.BackColor= Color.White;
            lnkMostSold.BackColor= Color.White;
        }

        private void lnkLowStock_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GridSource = enGridSource.eLowStock;
            if (lblPageNumber.Text != "1")
                lblPageNumber.Text = "1";
            else
                lblPageNumber_TextChanged(null, null);
            lnkEveryProduct.BackColor = Color.White;
            lnkLowStock.BackColor = Color.Silver;
            lnkMostProfit.BackColor = Color.White;
            lnkSlowMoving.BackColor = Color.White;
            lnkMostSold.BackColor = Color.White;
        }

        private void lnkMostProfit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GridSource = enGridSource.eMostProfit;
            if (lblPageNumber.Text != "1")
                lblPageNumber.Text = "1";
            else
                lblPageNumber_TextChanged(null, null);
            lnkEveryProduct.BackColor = Color.White;
            lnkLowStock.BackColor = Color.White;
            lnkMostProfit.BackColor = Color.Silver;
            lnkSlowMoving.BackColor = Color.White;
            lnkMostSold.BackColor = Color.White;
        }

        private void lnkMostSold_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GridSource = enGridSource.eMostSale;
            if (lblPageNumber.Text != "1")
                lblPageNumber.Text = "1";
            else
                lblPageNumber_TextChanged(null, null);
            lnkEveryProduct.BackColor = Color.White;
            lnkLowStock.BackColor = Color.White;
            lnkMostProfit.BackColor = Color.White;
            lnkSlowMoving.BackColor = Color.White;
            lnkMostSold.BackColor = Color.Silver;
        }
    }
}
