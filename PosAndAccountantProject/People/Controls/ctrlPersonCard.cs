using PosAndAccountant_business;
using PosAndAccountantProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosAndAccountantProject.People.Controls
{
    public partial class ctrlPersonCard : UserControl
    {
        private clsPerson _Person=null;

        private int _PersonID=-1;

        public bool WasUpdated { get;set;}=false;
        public int PersonID{ get { return _PersonID; } }
        public clsPerson PersonSelected { get { return _Person; } }

        public ctrlPersonCard()
        {
            InitializeComponent();
            
        }

        public bool LoadPersoDataToControl(int PersonID)
        {
            _Person = clsPerson.FindPersonByID(PersonID);
            _PersonID = PersonID; 
            if( _Person != null )
            {
                _FillPersonInfo();


                return true;
            }
            else
            {

                ResetPersonInfo();
                MessageBox.Show("لا يوجد شخص بمعرف  = " + PersonID.ToString(), "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
 

                return false;
            }



        }

        public bool LoadPersoDataToControl(string Phone)
        {
            _Person = clsPerson.FindPersonByPhone(Phone);

            if (_Person != null)
            {
                _FillPersonInfo();
                _PersonID= _Person.ID;

                return true;
            }
            else
            {

                ResetPersonInfo();
                MessageBox.Show("No Person with PersonID = " + PersonID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                return false;
            }



        }

        public void ResetPersonInfo()
        {
            llEditPersonInfo.Enabled = false;
            lblPersonID.Text = "[????]";
            lblPhone.Text = "[????]";
            lblAddress.Text = "[????]";
            lblCreateDate.Text = "[????]";
            lblFullName.Text = "[????]";
            lblModifyDate.Text = "[????]";

            pbPersonImage.Image = Resources.Male_512;

        }

        private void _LoadPersonImage()
        {
            pbPersonImage.Image = Resources.Male_512;

            if (!string.IsNullOrEmpty(_Person.ImagePath ) )
            {
                if (File.Exists(_Person.ImagePath))
                {
                    pbPersonImage.ImageLocation = null;
                    pbPersonImage.ImageLocation = _Person.ImagePath;

                 }
                else
                {
                    MessageBox.Show("Could not find this image: = " +_Person.ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

         


        }
        private void _FillPersonInfo()
        {
            llEditPersonInfo.Enabled = true;
            lblPersonID.Text=_Person.ID.ToString();
            lblPhone.Text=_Person.Phone??"N/A";
            lblAddress.Text=_Person.Address??"N/A";
            lblCreateDate.Text = _Person.CreateDate.ToShortDateString();
            lblFullName.Text = _Person.FullName;
            lblModifyDate.Text = _Person.ModifyDate.ToShortDateString();

            _LoadPersonImage();

        }




        private void llEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           if( _Person != null )
            {
                frmAddUpdatePerson frm=new frmAddUpdatePerson(_PersonID);
                frm.ShowDialog();
                if(frm.WasSaved)
                {
                    LoadPersoDataToControl(_PersonID);
                }
                WasUpdated = frm.WasSaved;


            }

        }

         
    }
}
