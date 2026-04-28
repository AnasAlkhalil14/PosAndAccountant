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

namespace PosAndAccountantProject.Customers
{
    public partial class frmAddUpdateCustomer : Form
    {
        public frmAddUpdateCustomer()
        {
            InitializeComponent();
            _CustomerID = -1;
        }
        public frmAddUpdateCustomer(int CustomerID)
        {
            InitializeComponent();
            _CustomerID = CustomerID;

        }
       private int _CustomerID=-1;
        private clsCustomer _Customer;
        public bool WasSaved = false;
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _FillCustomerData()
        {
            ctrlPersonCardWithFilter1.FindNow(_Customer.PersonID);
            lblCustomerID.Text = _Customer.CustomerID.ToString();
           numCreditLimit.Value=(decimal) _Customer.CreditLimit;
            numDiscount.Value=(decimal)_Customer.DiscountPercentage;
            txtTotalDebt.Text=_Customer.TotalRemainingDebt.ToString();
            cbCustomerType.SelectedIndex = _Customer.CustomerType;
            tsIsActive.Checked = _Customer.IsActive;
            txtNotes.Text= _Customer.Notes;
            
        }
        private void frmAddUpdateCustomer_Load(object sender, EventArgs e)
        {
            if(_CustomerID!=-1)
            {
                lblTitle.Text = "تعديل بيانات العميل";
                _Customer = clsCustomer.FindCustomerByID(_CustomerID);
                if( _Customer!=null )
                {
                    _FillCustomerData();
                }
                else
                {
                    MessageBox.Show($"لا يوجد عميل بمعرف {_CustomerID}", "خطأ", MessageBoxButtons.OK);
                }
                
            }
            else
            {
                lblTitle.Text = "اضافة عميل جديد";
                _Customer = new clsCustomer();
            }
          
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("This feture will implemented soon");

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if(_Customer.PersonID==-1)
            {
                MessageBox.Show("اختر الشخص اولا", "نقص في البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            _Customer.DiscountPercentage= (double)numDiscount.Value;
            _Customer.CreditLimit = (double)numCreditLimit.Value;
            _Customer.IsActive = tsIsActive.Checked;
            _Customer.CustomerType = cbCustomerType.SelectedIndex;
            _Customer.Notes= txtNotes.Text; 

            if(_Customer.Save())
            {
                WasSaved = true;
                lblTitle.Text = "تعديل بيانات العميل";
                lblCustomerID.Text = _Customer.CustomerID.ToString();
                MessageBox.Show("تم جفظ بيانات العميل بنجاح", "النتيجة", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("حدث خطا,فشل في حفظ بيانات العميل", "النتيجة", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }

        private void ctrlPersonCardWithFilter1_PersonSelected(object sender, People.Controls.ctrlPersonCardWithFilter.PersonSelectedEventArgs e)
        {
            if(_Customer.Mode==clsCustomer.enMode.eAdd)
            {
                if(clsCustomer.IsPersonCustomer(e.PersonID))
                {
                    MessageBox.Show("هذا الشخص هو عميل لدينا مسبقا يرجى اختيار شخص اخر", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrlPersonCardWithFilter1.ResetePersonInfo();
                    return;
                }

            }
            else if(e.PersonID!=_Customer.PersonID && clsCustomer.IsPersonCustomer(e.PersonID))
            {

                MessageBox.Show("هذا الشخص هو عميل لدينا مسبقا يرجى اختيار شخص اخر", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlPersonCardWithFilter1.ResetePersonInfo();
                return;


            }



            _Customer.PersonID = e.PersonID;
        }

        private void ctrlPersonCardWithFilter1_PersonNotFound(object sender, EventArgs e)
        {
            _Customer.PersonID = -1;
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
