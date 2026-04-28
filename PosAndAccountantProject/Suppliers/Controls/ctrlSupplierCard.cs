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

namespace PosAndAccountantProject.Suppliers.Controls
{
    public partial class ctrlSupplierCard : UserControl
    {
        private int _SupplierID;
        private clsSupplier _Supplier;

        public ctrlSupplierCard()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("This feture will implemented soon");

        }
        public bool WasPersonUpdated { get { return ctrlPersonCard1.WasUpdated; } }


        public int SuppplierID { get { return _SupplierID; } }
        public clsSupplier Supplier { get { return _Supplier; } }

        public bool LoadDataToControl(int SuppplierID)
        {
            _Supplier = clsSupplier.FindSupplierByID(SuppplierID);
            if (Supplier != null)
            {
                return _FillCustomerInfo();
            }
            ReseteCustomerInfo();
            return false;

        }

        private bool _FillCustomerInfo()
        {
            if (ctrlPersonCard1.LoadPersoDataToControl(Supplier.PersonID))
            {
                lblCreatedDate.Text = Supplier.CreatedDate.ToShortDateString();
                lblSupplierID.Text = Supplier.SupplierID.ToString();
             
                lblIsActive.Text = Supplier.IsActive ? "نعم" : "لا";
                lblModifiedDate.Text = Supplier.ModifiedDate.ToShortDateString();
                lblTotalRemainingDebt.Text = Supplier.TotalRemainingDebt.ToString();
              
                lblNotes.Text = Supplier.Notes;
                return true;
            }
            ReseteCustomerInfo();
            return false;
        }

        public void ReseteCustomerInfo()
        {
            ctrlPersonCard1.ResetPersonInfo();
            lblCreatedDate.Text = "[???]";
            lblSupplierID.Text = "[???]";
            lblIsActive.Text = "[???]";
            lblModifiedDate.Text = "[???]";
            lblTotalRemainingDebt.Text = "[???]";
            lblNotes.Text = "[???]";
           
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("This feture will implemented soon");

        }
    }
}
