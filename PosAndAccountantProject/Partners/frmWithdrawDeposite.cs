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
    public partial class frmWithdrawDeposite : Form
    {
        public frmWithdrawDeposite()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;
            partnerTransaction = new clsPartnerTransaction();
        }
        public frmWithdrawDeposite(int TransactionID)
        {
            InitializeComponent();
        //partnerTransaction=clsPartnerTransaction.Find(TransactionID);
        }

        clsPartnerTransaction partnerTransaction;

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)&&!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        DataTable _AllPartners= clsPartner.GetAllPartnersShort();
        private void _LoadPartnersToCompoBox()
        {
            cbxPartner.DisplayMember = "FullName";
            cbxPartner.ValueMember = "PartnerID";
            cbxPartner.DataSource = _AllPartners;


        }
        private void frmWithdrawDeposite_Load(object sender, EventArgs e)
        {
            _LoadPartnersToCompoBox();
          
            dtpDate.Value = DateTime.Now;
        }

      

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
                {
                MessageBox.Show("يوجد بيانات غيير مكتملة او خاطئة لا يمكن اكمال العملية", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ;
                return;
            }
            partnerTransaction.PartnerID = Convert.ToInt32(cbxPartner.SelectedValue);
            partnerTransaction.Notes = txtNotes.Text;
            partnerTransaction.Amount = Convert.ToDouble(txtAmount.Text);
            
            partnerTransaction.TransactionType = rbDeposit.Checked ? clsPartnerTransaction.enTransactionType.eDeposit : clsPartnerTransaction.enTransactionType.eWithDraw;
            if(partnerTransaction.Save())
            {
                MessageBox.Show("تمت العملية بنجاح", "النتيجة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _AllPartners = clsPartner.GetAllPartnersShort();
                int PartnerIndex = cbxPartner.SelectedIndex;
                _LoadPartnersToCompoBox();
                cbxPartner.SelectedIndex = PartnerIndex;
            }
            else
            {
                MessageBox.Show("حدث خطا لم تتم العملية", "النتيجة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbxPartner_SelectedIndexChanged(object sender, EventArgs e)
        {

            int PartnerID = Convert.ToInt32(cbxPartner.SelectedValue.ToString());
            DataRow row = _AllPartners.Select($"PartnerID={PartnerID}")[0];
            double Balnce = Convert.ToDouble(row["CurrentBalance"]);
            lblBalance.Text = Balnce.ToString();

        }

        private void txtAmount_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtAmount.Text.Trim()))
            {
                errorProvider1.SetError( txtAmount, "هذا الحقل مطلوب");
                e.Cancel = true;
            }
            else if(rbWithdraw.Checked&&Convert.ToDouble(txtAmount.Text)>Convert.ToDouble(lblBalance.Text))
            {
                errorProvider1.SetError(txtAmount, "مبلغ غير صالح لان رصيدك الكلي هو:"+ lblBalance.Text);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtAmount, "");
                e.Cancel = false;
            }

        }
    }
}
