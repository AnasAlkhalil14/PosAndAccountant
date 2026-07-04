using PosAndAccountantProject.Customers;
using PosAndAccountantProject.Customers.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosAndAccountantProject.Suppliers.Controls
{
    public partial class ctrlSupplierCardWithFilter : UserControl
    {
        public ctrlSupplierCardWithFilter()
        {
            InitializeComponent();
        }
        public class SupplierSelectedEventArgs : EventArgs
        {
            public int SupplierID { get; }
            public SupplierSelectedEventArgs(int SupplierID) => this.SupplierID = SupplierID;
        }



        [Category("Action"), Description("Fired when a supplier is selected"), Browsable(true)]
        public event EventHandler<SupplierSelectedEventArgs> SupplierSelected;

        [Category("Action"), Description("Fired when no supplier is found"), Browsable(true)]
        public event EventHandler SupplierNotFound;

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilterValue.Text.Trim()))
            {
                MessageBox.Show("حقل البحث فارغ ضع البيانات الي تريد البحث عبرها", "خطأ في بيانات البحث", MessageBoxButtons.OK, MessageBoxIcon.Error);


                return;
            }
            FindNow();

        }

        private void ctrlSupplierCardWithFilter_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;
            txtFilterValue.Focus();
        }
        public void ReseteSupplierInfo()
        {
            ctrlSupplierCard1.ReseteSupplierInfo();
        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            frmAddUpdateSupplier frm = new frmAddUpdateSupplier();
            frm.ShowDialog();

            if (frm.WasSaved)
            {

                ctrlSupplierCard1.LoadDataToControl(frm.SupplierID);
                SupplierSelected?.Invoke(this, new SupplierSelectedEventArgs(frm.SupplierID));
            }

        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)13 == e.KeyChar)
            {
                btnFind.PerformClick();
            }
            else
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void SettingTextBoxsForFiltering()
        {
            if (cbFilterBy.SelectedIndex == 0)
            {

                txtFilterValue.PlaceholderText = "معرف العميل";
            }

            else
            {

                txtFilterValue.PlaceholderText = "رقم الهاتف";



            }

        }
        void FindNow()
        {

            switch (cbFilterBy.SelectedIndex)
            {
                case 0:
                    {


                        if (ctrlSupplierCard1.Supplier == null || (txtFilterValue.Text != ctrlSupplierCard1.SuppplierID.ToString()))
                        {
                            if (ctrlSupplierCard1.LoadDataToControl(int.Parse(txtFilterValue.Text)))
                            {
                                SupplierSelected?.Invoke(this, new SupplierSelectedEventArgs(int.Parse(txtFilterValue.Text)));
                            }
                            else
                            {
                                MessageBox.Show("لا يوجد مورد بمعرف : " + txtFilterValue.Text, "خطأ في  البيانات", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                SupplierNotFound?.Invoke(this, new EventArgs());
                            }
                        }


                        break;
                    }
                case 1:
                    {
                        if (ctrlSupplierCard1.Supplier == null || (txtFilterValue.Text != ctrlSupplierCard1.Supplier.PersonInfo.Phone))
                        {
                            if (ctrlSupplierCard1.LoadDataToControl(txtFilterValue.Text))
                            {
                                SupplierSelected?.Invoke(this, new SupplierSelectedEventArgs(int.Parse(txtFilterValue.Text)));
                            }
                            else
                            {
                                MessageBox.Show("لا يوجد مورد برقم هاتف : " + txtFilterValue.Text, "خطأ في  البيانات", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                SupplierNotFound?.Invoke(this, new EventArgs());
                            }
                        }


                        break;


                    }

                default:
                    {


                        break;
                    }


            }

        }
        public void FindNow(int SupplierID)
        {

            txtFilterValue.Text = SupplierID.ToString();
            cbFilterBy.SelectedIndex = 0;
            FindNow();
        }
        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Clear();

            txtFilterValue.Focus();
            SettingTextBoxsForFiltering();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void ctrlSupplierCard1_Load(object sender, EventArgs e)
        {

        }
    }
}
