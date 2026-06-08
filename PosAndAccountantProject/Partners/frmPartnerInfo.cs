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

namespace PosAndAccountantProject.Partners
{
    public partial class frmPartnerInfo : Form
    {
        public frmPartnerInfo(int partnerID)
        {
            InitializeComponent();
            PartnerID = partnerID;
        }
        public int PartnerID { get; private set; } = -1;
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmPartnerInfo_Load(object sender, EventArgs e)
        {

            if (!ctrlPartnerCard1.LoadPartnerDataToControl(PartnerID))
            {
                MessageBox.Show($"خطأ عند تحميل بيانات الشريك ذو المعرف:{PartnerID}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PartnerID = -1;
            }
        }
    }
}
