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
        public bool EditDone = false;
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            frmAddUpdatePartners frm = new frmAddUpdatePartners();
            frm.ShowDialog();
            if(frm.WasSaved)
            {
                _RefreshForm();
                EditDone = true;
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

                dgvPartners.Columns[0].HeaderText = "معرف الشريك";

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
                EditDone = true;
                _RefreshForm();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int PartnerID = Convert.ToInt32(dgvPartners.CurrentRow.Cells[0].Value);
            if (MessageBox.Show($"هل متاكد من حذف الشريك ذو المعرف:{PartnerID}", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (clsPerson.DeletePersonByID(PartnerID))
                {EditDone = true;
                    _RefreshForm();
                    MessageBox.Show($"الشريك ذو المعرف={PartnerID} حذف بنجاح", "النتيجة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"فشل في حذف الشريك ذو المعرف={PartnerID},يوجد بيانات مربوطة به", "النتيجة", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void عمليةسحبToolStripMenuItem_Click(object sender, EventArgs e)
        {
       frmWithdrawDeposite frm = new frmWithdrawDeposite();
               frm.Show(); frm.MakeWithDraw();
            frm.SelectPartner(Convert.ToInt32(dgvPartners.CurrentRow.Cells[0].Value));
            frm.OnSaveTrue -= Frm_OnSaveTrue;
            frm.OnSaveTrue += Frm_OnSaveTrue;
        }

        private void Frm_OnSaveTrue(object sender, EventArgs e)
        {
EditDone = true;
            _RefreshForm();
        }

        private void عمليةايداعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWithdrawDeposite frm = new frmWithdrawDeposite();
            frm.Show(); frm.MakeDeposite();
            frm.SelectPartner(Convert.ToInt32(dgvPartners.CurrentRow.Cells[0].Value));
            frm.OnSaveTrue -= Frm_OnSaveTrue;
            frm.OnSaveTrue += Frm_OnSaveTrue;
        }
        
        private void lnkManagePartners_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {this.Close();
         }

        private void lnkAddNewTransaction_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmWithdrawDeposite frm = new frmWithdrawDeposite();
            frm.ShowDialog(); 
            if(frm.WasSaved)
            {
                EditDone = true;
                _RefreshForm();
            }
        }
    }
}
