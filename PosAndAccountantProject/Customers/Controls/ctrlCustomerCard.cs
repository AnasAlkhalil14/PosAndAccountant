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

namespace PosAndAccountantProject.Customers.Controls
{
    public partial class ctrlCustomerCard : UserControl
    {
        private int _CustomerID=-1;
        private clsCustomer _Customer;

        public ctrlCustomerCard()
        {
            InitializeComponent();
        }


        public bool WasPersonUpdated { get { return ctrlPersonCard1.WasUpdated; } }


        public int CustomerID { get { return _CustomerID; } }
        public clsCustomer Customer { get { return _Customer; } }

        public bool LoadDataToControl(int CustomerID)
        {
            _Customer = clsCustomer.FindCustomerByID(CustomerID);
            if (Customer!=null)
            {
                return _FillCustomerInfo();
            }
            return false;

        }

        private bool _FillCustomerInfo()
        {
            if(ctrlPersonCard1.LoadPersoDataToControl(Customer.PersonID))
            {
                lblCreatedDate.Text=Customer.CreatedDate.ToShortDateString();
                lblCustomerID.Text=Customer.CustomerID.ToString();
                lblCustomerType.Text=Customer.CustomerTypeString();
                lblDiscountPercentage.Text=Customer.DiscountPercentage.ToString();
                lblIsActive.Text = Customer.IsActive ? "نعم" : "لا";
                lblModifiedDate.Text=Customer.ModifiedDate.ToShortDateString();
                lblTotalRemainingDebt.Text=Customer.TotalRemainingDebt.ToString();
                lblCreditLimit.Text=Customer.CreditLimit.ToString();
                lblNotes.Text = Customer.Notes;
                return true;
            }
            ReseteCustomerInfo();
            return false;
        }

        public void ReseteCustomerInfo()
        {
            ctrlPersonCard1.ResetPersonInfo();
            lblCreatedDate.Text                 = "[???]";
            lblCustomerID.Text                  = "[???]";
            lblCustomerType.Text                = "[???]";
            lblDiscountPercentage.Text          = "[???]";
            lblIsActive.Text                    = "[???]";
            lblModifiedDate.Text                = "[???]";
            lblTotalRemainingDebt.Text          = "[???]";
            lblNotes.Text = "[???]";
            lblCreditLimit.Text = "[???]";
         }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("This feture will implemented soon");
        }
    }
}
