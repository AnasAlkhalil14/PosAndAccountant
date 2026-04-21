using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosAndAccountantProject.People
{
    public partial class frmShowPersonInfo : Form
    {
        int _PersonID;

         public frmShowPersonInfo(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
            ctrlPersonCard1.LoadPersoDataToControl(PersonID);


        }
         
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
