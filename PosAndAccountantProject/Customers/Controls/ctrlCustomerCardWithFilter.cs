using PosAndAccountantProject.People;
using PosAndAccountantProject.People.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PosAndAccountantProject.People.Controls.ctrlPersonCardWithFilter;

namespace PosAndAccountantProject.Customers.Controls
{
    public partial class ctrlCustomerCardWithFilter : UserControl
    {
        public ctrlCustomerCardWithFilter()
        {
            InitializeComponent();
        }
        public class CustomerSelectedEventArgs : EventArgs
        {
            public int CustomerID { get; }
            public CustomerSelectedEventArgs(int CustomerID) => this.CustomerID = CustomerID;
        }
        


        [Category("Action"), Description("Fired when a customer is selected"), Browsable(true)]
        public event EventHandler<CustomerSelectedEventArgs> CustomerSelected;

        [Category("Action"), Description("Fired when no customer is found"), Browsable(true)]
        public event EventHandler CustomerNotFound;


        void FindNow()
        {

            switch (cbFilterBy.SelectedIndex)
            {
                case 0:
                    {


                        if (ctrlCustomerCard1.Customer == null || (txtFilterValue.Text != ctrlCustomerCard1.CustomerID.ToString()))
                        {
                            if (ctrlCustomerCard1.LoadDataToControl(int.Parse(txtFilterValue.Text)))
                            {
                                CustomerSelected?.Invoke(this, new CustomerSelectedEventArgs(int.Parse(txtFilterValue.Text)));
                            }
                            else
                            {
                                MessageBox.Show("لا يوجد عميل بمعرف : " + txtFilterValue.Text, "خطأ في  البيانات", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                CustomerNotFound?.Invoke(this, new EventArgs());
                            }
                        }


                        break;
                    }
                case 1:
                    {
                        if (ctrlCustomerCard1.Customer == null || (txtFilterValue.Text != ctrlCustomerCard1.Customer.PersonInfo.Phone))
                        {
                            if (ctrlCustomerCard1.LoadDataToControl(txtFilterValue.Text))
                            {
                                CustomerSelected?.Invoke(this, new CustomerSelectedEventArgs(int.Parse(txtFilterValue.Text)));
                            }
                            else
                            {
                                MessageBox.Show("لا يوجد عميل برقم هاتف : " + txtFilterValue.Text, "خطأ في  البيانات", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                CustomerNotFound?.Invoke(this, new EventArgs());
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
        private void btnFind_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtFilterValue.Text.Trim()))
            {
                MessageBox.Show("حقل البحث فارغ ضع البيانات الي تريد البحث عبرها", "خطأ في بيانات البحث", MessageBoxButtons.OK, MessageBoxIcon.Error);


                return;
            }
            FindNow();
        }

        private void ctrlCustomerCard1_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;
            txtFilterValue.Focus();
        }

        public void ReseteCustomerInfo()
        {
            ctrlCustomerCard1.ReseteCustomerInfo();
        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            frmAddUpdateCustomer frm = new frmAddUpdateCustomer();
            frm.ShowDialog();

            if (frm.WasSaved)
            {


                ctrlCustomerCard1.LoadDataToControl(frm.CustomerID);
                CustomerSelected?.Invoke(this, new CustomerSelectedEventArgs(frm.CustomerID));
            }

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

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)13 == e.KeyChar)
            {
                btnFind.PerformClick();
            }
            else
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
        public void FindNow(int CustomerID)
        {

            txtFilterValue.Text = CustomerID.ToString();
            cbFilterBy.SelectedIndex = 0;
            FindNow();
        }
        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Clear();

            txtFilterValue.Focus();
            SettingTextBoxsForFiltering();
        }
    }
}
