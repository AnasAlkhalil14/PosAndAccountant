using PosAndAccountant_business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosAndAccountantProject.Partners
{
    public partial class frmAddUpdatePartners : Form
    {
        public frmAddUpdatePartners()
        {
            InitializeComponent();
            _PartnerID = -1;
        }
        public frmAddUpdatePartners(int PartnerID)
        {
            InitializeComponent();
            _PartnerID  = PartnerID;
        }
        private int _PartnerID;
        private clsPartner _Partner;
        public bool WasSaved { get; private set; } = false;
        private void _SetEnability(bool Enable)
        {
            btnSave.Enabled = Enable;
            lnkDepositeWithdraw.Enabled = Enable;
            lnkTransactionHistory.Enabled = Enable;

        }
        private void ctrlPersonCardWithFilter1_PersonSelected(object sender, People.Controls.ctrlPersonCardWithFilter.PersonSelectedEventArgs e)
        {

            if (_Partner.Mode == clsPartner.enMode.eAdd)
            {
                if (clsPartner.IsPersonPartner(e.PersonID))
                {

                    MessageBox.Show("هذا الشخص هو شريك لدينا مسبقا يرجى اختيار شخص اخر", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrlPersonCardWithFilter1.ResetePersonInfo();


                }
                _SetEnability(false);

                    return;
                

            }
            else if (e.PersonID != _Partner.PersonID && clsPartner.DeletePartnerByID(e.PersonID))
            {

                MessageBox.Show("هذا الشخص هو شريك لدينا مسبقا يرجى اختيار شخص اخر", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlPersonCardWithFilter1.ResetePersonInfo();
                _SetEnability(false);
                return;


            }

            _SetEnability(true);
            _Partner.PersonID = e.PersonID;


            
        }

        private void ctrlPersonCardWithFilter1_PersonNotFound(object sender, EventArgs e)
        {
            _SetEnability(false);
        }

        private void frmAddUpdatePartners_Load(object sender, EventArgs e)
        {
           if(_PartnerID!=-1)
            {
                lblTitle.Text= "تعديل بيانات الشريك";
                _Partner = clsPartner.FindPartnerByID(_PartnerID);
                if(_Partner!=null)
                {
                    ctrlPersonCardWithFilter1.FindNow(_Partner.PersonID);
                    _SetEnability(true);
                    lblPartnerID.Text = _PartnerID.ToString();
                    lblCreatedDate.Text = _Partner.CreatedDate.ToShortDateString();
                    numBalance.Value = Convert.ToDecimal(_Partner.CurrentBalance);
                    numProfitPercentage.Value = Convert.ToDecimal(_Partner.ProfitPercentage);
                    tsIsActive.Checked = _Partner.IsActive;
                }
                else
                {
                    MessageBox.Show($"لا يوجد شريك بمعرف {_PartnerID}", "خطأ", MessageBoxButtons.OK);
                    _SetEnability(false);
                }
                
            }

           else
            {
                lblTitle.Text = "اضافة شريك جديد";
                _Partner = new clsPartner();
                _SetEnability(false);
            }


        }

        private bool _SavePartner()
        {
            _Partner.CurrentBalance = Convert.ToDouble(numBalance.Value);
            _Partner.ProfitPercentage = Convert.ToDouble(numProfitPercentage.Value);
            _Partner.IsActive = tsIsActive.Checked;

            return _Partner.Save();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(_SavePartner())
            {
                lblPartnerID.Text = _Partner.PartnerID.ToString();
                lblTitle.Text = "تعديل بيانات الشريك";
                WasSaved = true;
                MessageBox.Show("تم جفظ بيانات الشريك بنجاح", "النتيجة", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                
                MessageBox.Show("حدث خطا,فشل في حفظ بيانات الشريك", "النتيجة", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
