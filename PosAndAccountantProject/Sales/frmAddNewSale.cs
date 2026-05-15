using PosAndAccountant_business;
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
            _AllProducts.DefaultView.RowFilter = string.Format("[{0}] like '%{1}%'", "CategoryName", cbProductCategory.Text);

        }
        private void frmAddNewSale_Load(object sender, EventArgs e)
        {

            LoadCategoriesToCobmoBox();
            dgvProductList.DataSource = _AllProducts;

            FilterProductForCategory();


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
 


        }

        private void cbProductCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterProductForCategory();
        }
    }
}
