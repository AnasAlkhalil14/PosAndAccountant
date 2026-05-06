using PosAndAccountant_business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Hosting;
using System.Windows.Forms;

namespace PosAndAccountantProject.Products.ProductsCategory
{
    public partial class frmListCategories : Form
    {
        public frmListCategories()
        {
            InitializeComponent();
        }

        DataTable _AllCategories = clsProductCategory.GetAllProductsCategory();


        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            frmAddUpdateCategory frm=new frmAddUpdateCategory();
            frm.ShowDialog();
            if(frm.WasSaved)
            {
                _RefreshForm();
            }
        }

        private void frmListCategories_Load(object sender, EventArgs e)
        {
            dgvCategories.DataSource = _AllCategories;
lblRecordsCount.Text=dgvCategories.Rows.Count.ToString();
            if (dgvCategories.Rows.Count > 0)
            {
                dgvCategories.Columns[0].HeaderText = "معرف الصنف";
                dgvCategories.Columns[1].HeaderText = "اسم الصنف";
                dgvCategories.Columns[2].HeaderText = "الصنف";
                dgvCategories.Columns[3].HeaderText = "تاريخ الانشاء";
                dgvCategories.Columns[3].DefaultCellStyle.Format= "yyyy-MM  -dd";

            }
            }

        private void _RefreshForm()
        {
            _AllCategories=clsProductCategory.GetAllProductsCategory();
            dgvCategories.DataSource= _AllCategories;
            lblRecordsCount.Text = dgvCategories.Rows.Count.ToString();
        }


        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int CategoryID = Convert.ToInt32(dgvCategories.CurrentRow.Cells[0].Value);
            if (MessageBox.Show($"هل متاكد من حذف الصنف ذو المعرف:{CategoryID}", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (clsProductCategory.Delete(CategoryID))
                {
                    _RefreshForm();

                    MessageBox.Show($"الصنف ذو المعرف={CategoryID} حذف بنجاح", "النتيجة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"فشل في حذف الصنف ذو المعرف={CategoryID},يوجد بيانات مربوطة به", "النتيجة", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateCategory frm=new frmAddUpdateCategory(Convert.ToInt32(dgvCategories.CurrentRow.Cells[0].Value));

            frm.ShowDialog();
            if (frm.WasSaved)
            {
                _RefreshForm();
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
