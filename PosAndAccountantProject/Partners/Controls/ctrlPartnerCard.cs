using PosAndAccountant_business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Hosting;
using System.Windows.Forms;

namespace PosAndAccountantProject.Partners.Controls
{
    public partial class ctrlPartnerCard : UserControl
    {
        public ctrlPartnerCard()
        {
            InitializeComponent();
        }
        public bool WasPersonUpdated { get { return ctrlPersonCard1.WasUpdated; } }

        public int PartnerID { get; private set; }
        public clsPartner Partner { get; private set; }
        public bool LoadPartnerDataToControl(int PartnerID)
        {
            Partner=clsPartner.FindPartnerByID(PartnerID);
            if(Partner == null)
            {
                ResetePartnerInfo();
                return false;
            }
            return _FillPartnerData();


        }

        public void ResetePartnerInfo()
        {
            Partner = null;
            PartnerID = -1;
            ctrlPersonCard1.ResetPersonInfo();
            lblBalance.Text = "[???]";
            lblCreatedDate.Text = "[???]";
            lblIsActive.Text = "[???]";
            lblModifiedDate.Text = "[???]";
            lblPartnerID.Text = "[???]";
            lblProfitPercentage.Text = "[???]";
        }

        private bool _FillPartnerData()
        {
            if (Partner == null) return false;
            lblProfitPercentage.Text=Partner.ProfitPercentage.ToString();
            lblPartnerID.Text=Partner.PartnerID.ToString();
            lblBalance.Text=Partner.CurrentBalance.ToString();
            lblIsActive.Text = Partner.IsActive ? "نعم" : "لا";
            lblCreatedDate.Text = Partner.CreatedDate.ToShortDateString();
            lblModifiedDate.Text = Partner.ModifiedDate.ToShortDateString();
           return  ctrlPersonCard1.LoadPersoDataToControl(Partner.PersonID);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("will be implemented soon");
        }

        private void lnkTransactionHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("will be implemented soon");

        }
    }
}
