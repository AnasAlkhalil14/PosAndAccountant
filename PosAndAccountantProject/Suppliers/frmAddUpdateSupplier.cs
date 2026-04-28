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

namespace PosAndAccountantProject.Suppliers
{
    public partial class frmAddUpdateSupplier : Form
    {
        public frmAddUpdateSupplier()
        {
            InitializeComponent();
            _SupplierID = -1;
        }
        public frmAddUpdateSupplier(int SupplierID)
        {
            InitializeComponent();
            _SupplierID = SupplierID;
        }

        private int _SupplierID;
        private clsSupplier _Supplier;
        public bool WasSaved = false;


        private void _FillSupplierData()
        {
            ctrlPersonCardWithFilter1.FindNow(_Supplier.PersonID);
            lblCustomerID.Text = _Supplier.SupplierID.ToString();
           
            txtTotalDebt.Text = _Supplier.TotalRemainingDebt.ToString();
            tsIsActive.Checked = _Supplier.IsActive;
            txtNotes.Text = _Supplier.Notes;

        }
        private void frmAddUpdateSupplier_Load(object sender, EventArgs e)
        {
            if (_SupplierID != -1)
            {
                lblTitle.Text = "تعديل بيانات المورد";
                _Supplier = clsSupplier.FindSupplierByID(_SupplierID);

                if (_Supplier != null)
                {
                    lnkMakeOrder.Enabled = true;
                    lnkShowLastPurchases.Enabled = true;
                    _FillSupplierData();
                }
                else
                {
                    lnkMakeOrder.Enabled = false;
                    lnkShowLastPurchases.Enabled = false;
                    btnSave.Enabled = false;
                    MessageBox.Show($"لا يوجد مورد بمعرف {_SupplierID}", "خطأ", MessageBoxButtons.OK);
                }

            }
            else
            {
                lnkMakeOrder.Enabled = false;
                lnkShowLastPurchases.Enabled = false;
                lblTitle.Text = "اضافة مورد جديد";
                _Supplier = new clsSupplier();
            }




        }

        private void lnkMakeOrder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("This feture will implemented soon");

        }

        private void lnkShowLastPurchases_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("This feture will implemented soon");

        }

        private void ctrlPersonCardWithFilter1_PersonSelected(object sender, People.Controls.ctrlPersonCardWithFilter.PersonSelectedEventArgs e)
        {
            if (_Supplier.Mode == clsSupplier.enMode.eAdd)
            {
                if (clsSupplier.IsPersonSupplier(e.PersonID))
                {
                    MessageBox.Show("هذا الشخص هو مورد لدينا مسبقا يرجى اختيار شخص اخر", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrlPersonCardWithFilter1.ResetePersonInfo();
                    return;
                }

            }
            else if (e.PersonID != _Supplier.PersonID && clsSupplier.IsPersonSupplier(e.PersonID))
            {

                MessageBox.Show("هذا الشخص هو مورد لدينا مسبقا يرجى اختيار شخص اخر", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlPersonCardWithFilter1.ResetePersonInfo();
                lnkMakeOrder.Enabled = false;
                lnkShowLastPurchases.Enabled = false;
                return;


            }



            _Supplier.PersonID = e.PersonID;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            if (_Supplier.PersonID == -1)
            {
                MessageBox.Show("اختر الشخص اولا", "نقص في البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            _Supplier.IsActive = tsIsActive.Checked;
            _Supplier.Notes = txtNotes.Text;

            if (_Supplier.Save())
            {
                lnkMakeOrder.Enabled = true;
                lnkShowLastPurchases.Enabled = true;
                WasSaved = true;
                lblTitle.Text = "تعديل بيانات المورد";
                lblCustomerID.Text = _Supplier.SupplierID.ToString();
                MessageBox.Show("تم جفظ بيانات المورد بنجاح", "النتيجة", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("حدث خطا,فشل في حفظ بيانات المورد", "النتيجة", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void ctrlPersonCardWithFilter1_PersonNotFound(object sender, EventArgs e)
        {

            lnkMakeOrder.Enabled = false;
            lnkShowLastPurchases.Enabled = false;
            _Supplier.PersonID = -1;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
