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

namespace PosAndAccountantProject.Partners
{
    public partial class frmListPartners : Form
    {
        public frmListPartners()
        {
            InitializeComponent();
        }

        private DataTable _AllPartners ;

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            frmAddUpdatePartners frm = new frmAddUpdatePartners();
            frm.ShowDialog();
            if(frm.WasSaved)
            {
                _RefreshForm();
            }
        }

        private void _RefreshForm()
        {
            _AllPartners = clsPartner.GetAllPartners();
            dgvPartners.DataSource = _AllPartners;
            lblRecordsCount.Text = dgvPartners.Rows.Count.ToString();
        }
        private void frmListPartners_Load(object sender, EventArgs e)
        {
            _RefreshForm();


            if(dgvPartners.Rows.Count > 0)
            {

                dgvPartners.Columns[0].HeaderText = "معرف العميل";

                dgvPartners.Columns[1].HeaderText = "الاسم الكامل";

                dgvPartners.Columns[2].HeaderText = "الرصيد الحالي";


                dgvPartners.Columns[3].HeaderText = "نسبة الربح";

            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPartnerInfo frm = new frmPartnerInfo(Convert.ToInt32(dgvPartners.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
            
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdatePartners frm = new frmAddUpdatePartners(Convert.ToInt32(dgvPartners.CurrentRow.Cells[0].Value));
            frm.ShowDialog(); 
            if (frm.WasSaved)
            {
                _RefreshForm();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int PartnerID = Convert.ToInt32(dgvPartners.CurrentRow.Cells[0].Value);
            if (MessageBox.Show($"هل متاكد من حذف الشريك ذو المعرف:{PartnerID}", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (clsPerson.DeletePersonByID(PartnerID))
                {
                    _RefreshForm();
                    MessageBox.Show($"الشريك ذو المعرف={PartnerID} حذف بنجاح", "النتيجة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"فشل في حذف الشريك ذو المعرف={PartnerID},يوجد بيانات مربوطة به", "النتيجة", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }
    }
}
