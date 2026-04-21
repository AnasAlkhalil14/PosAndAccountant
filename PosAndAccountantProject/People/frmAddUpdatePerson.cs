using PosAndAccountant_business;
using PosAndAccountantProject.GlobalClasses;
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

namespace PosAndAccountantProject.People
{
    public partial class frmAddUpdatePerson : Form
    {
        public frmAddUpdatePerson()
        {
            InitializeComponent();
            _Person=new clsPerson();
        }

        int _PersonID;
        

        public int PersonID { get { return _PersonID; } }

        public bool WasSaved { get; private set; }=false;


        private clsPerson _Person;
        public frmAddUpdatePerson(int PersonID)
        {
            InitializeComponent();

            _PersonID = PersonID;
            _Person=clsPerson.FindPersonByID(_PersonID);
        }

        private void _FillPersonData()
        {
            if(_Person != null )
            {
                txtAddress.Text =_Person.Address.Trim();
                txtFirstName.Text = _Person.FirstName.Trim();
                txtLastName.Text = _Person.LastName.Trim();
                txtPhone.Text = _Person.Phone.Trim();
                txtSecondName.Text = _Person.SecondName.Trim();
                lblPersonID.Text= _PersonID.ToString();
                lblTitle.Text = $"تعديل الشخص ذو المعرف  {_PersonID}";


               if(!string.IsNullOrEmpty(_Person.ImagePath))
                {
                    pbPersonImage.ImageLocation = _Person.ImagePath;
                    llRemoveImage.Visible = true;
                }
               else
                {
                    pbPersonImage.Image = Resources.Male_512;
                    llRemoveImage.Visible = false;
                }

            }


        }


        bool _HandlPersonImage()        
        {


            if (_Person.ImagePath != pbPersonImage.ImageLocation)
            {
                if (!string.IsNullOrEmpty(_Person.ImagePath))
                {
                    try
                    {
                        File.Delete(_Person.ImagePath);


                    }
                    catch (IOException ex)
                    {

                        MessageBox.Show(ex.Message);
                        return false;

                    }

                }

                if (pbPersonImage.ImageLocation != null)
                {
                    string SourcePath = pbPersonImage.ImageLocation;
                    if (clsUtil.CopyImageToProjectImagesFolder(ref SourcePath))
                    {
                        _Person.ImagePath = SourcePath;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("خطأ غي نسخ الصورة", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                   

                }
               



            }

            return true;






        }


        
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("تأكد من تعبئة الحقول ب البيانات الصحيحة","خطأ في البيانات",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if (!_HandlPersonImage())
            {

                return;
            }

            _Person.FirstName = txtFirstName.Text.Trim();
            _Person.LastName = txtLastName.Text.Trim();
            _Person.Address= txtAddress.Text.Trim();
            _Person.SecondName = txtSecondName.Text.Trim();
            _Person.Phone=txtPhone.Text.Trim();
            if(_Person.Save())
            {
                lblPersonID.Text=_Person.ID.ToString();
                _PersonID=_Person.ID;
                lblTitle.Text = $"تعديل معلومات الشخص ذو المعرف {_PersonID}";
                MessageBox.Show("تم تخزين البيانات بنجاح", "نتيجة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //invoke event;
                WasSaved = true;
             }
            else
            {
                MessageBox.Show("خطأو لم يتم تخزين البيانات", "نتيجة", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void frmAddUpdatePerson_Load(object sender, EventArgs e)
        {

            if(_Person!=null)
            {
                _FillPersonData();
            }

        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbPersonImage.ImageLocation= openFileDialog1.FileName;
                llRemoveImage.Visible= true;

            }




        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
pbPersonImage.ImageLocation= null;

            pbPersonImage.Image = Resources.Male_512;
            llRemoveImage.Visible = false;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {

           if(string.IsNullOrEmpty(txtFirstName.Text))
            {
                errorProvider1.SetError(txtFirstName, "هذا الحقل مطلوب");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtFirstName, null);


            }


        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                errorProvider1.SetError(txtLastName, "هذا الحقل مطلوب");
                e.Cancel= true;
            }
            else
            {
                errorProvider1.SetError(txtLastName, null);


            }
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {

            if(!string.IsNullOrEmpty(txtPhone.Text))
            {
                if (txtPhone.Text.Trim().Length != 10 || (txtPhone.Text.Trim()[0] != '0' || txtPhone.Text.Trim()[1]!='9'))
                {
                    errorProvider1.SetError(txtPhone,"ادخل رقم سوري صالح");
                    e.Cancel = true;
                }
                else
                {
                    errorProvider1.SetError(txtPhone, null);
                }






            }
            else
            {
                errorProvider1.SetError(txtPhone, null);
            }



        }
    }
}
