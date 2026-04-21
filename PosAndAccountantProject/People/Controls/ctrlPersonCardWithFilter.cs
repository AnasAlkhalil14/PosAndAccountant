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

namespace PosAndAccountantProject.People.Controls
{
    public partial class ctrlPersonCardWithFilter : UserControl
    {
        public ctrlPersonCardWithFilter()
        {
            InitializeComponent();
        }

        public Action<int> OnPersonSelected;


        private void SettingTextBoxsForFiltering()
        {
            if (cbFilterBy.SelectedIndex == 0)
            {

                txtFilterValue.PlaceholderText = "معرف الشخص";
            }

            else
            {

                txtFilterValue.PlaceholderText = "رقم الهاتف";



            }

        }
        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Clear();
            
            txtFilterValue.Focus();
            SettingTextBoxsForFiltering();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)13 == e.KeyChar)
            {
                btnFind.PerformClick();
            }
            else
                 e.Handled=!char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar);


        }

        void FindNow()
        {

            switch (cbFilterBy.SelectedIndex)
            {
                case 0:
                    {
                        
                        
                        if(ctrlPersonCard1.PersonSelected==null||(   txtFilterValue.Text!=ctrlPersonCard1.PersonSelected.ID.ToString()))


                        {
                            if (ctrlPersonCard1.LoadPersoDataToControl(int.Parse(txtFilterValue.Text)))
                            {
                                //raise evetn
                            }
                        }
                       

                        break;
                    }
                case 1:
                    {
                        if(ctrlPersonCard1.PersonSelected == null || (txtFilterValue.Text!=ctrlPersonCard1.PersonSelected.Phone))
                        {
                            if (ctrlPersonCard1.LoadPersoDataToControl(txtFilterValue.Text))
                            {
                                //raise evetn
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
                MessageBox.Show("Some fileds are not valide!,fill them with real data", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                return;
            }
             
             FindNow();

        }

        
        private void ctrlPersonCardWithFilter_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;
            txtFilterValue.Focus();
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm=new frmAddUpdatePerson();
            frm.ShowDialog();

            if(frm.WasSaved)
            {
                ctrlPersonCard1.LoadPersoDataToControl(frm.PersonID);

            }


        }
    }
}
