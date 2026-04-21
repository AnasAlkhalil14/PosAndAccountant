using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PosAndAccountant_DataTransfer;
using PosAndAccountant_DataAccess;
using System.Data;
using System.Runtime.InteropServices;
using System.IO;


namespace PosAndAccountant_business
{
    public class clsPerson
    {


        private bool _AddPerson()
        {
            clsPersonDTO personDTO = new clsPersonDTO();
            personDTO.ID = this.ID;
            personDTO.FirstName = this.FirstName.Trim();
            personDTO.SecondName = this.SecondName.Trim();
            personDTO.LastName = this.LastName.Trim();
            personDTO.Phone = this.Phone.Trim();
            personDTO.Address = this.Address.Trim();
            personDTO.ImagePath = this.ImagePath;


            this._ID = clsPersonData.AddNewPerson(personDTO);
            return this._ID != -1;

        }
        private bool _UpdatePerson()
        {
           clsPersonDTO personDTO = new clsPersonDTO();
            personDTO.ID=this.ID;
            personDTO.FirstName=this.FirstName.Trim();
            personDTO.SecondName=this.SecondName.Trim();
            personDTO.LastName=this.LastName.Trim();
            personDTO.Phone=this.Phone.Trim();
            personDTO.Address=this.Address.Trim();
            personDTO.ImagePath=this.ImagePath.Trim();

            return clsPersonData.UpdatePersonByID(personDTO);

        }
       
        public enum enMode{eAdd=0,eUpdate}
        public enMode Mode = enMode.eAdd;
 
        private int _ID;

        public int ID { get { return _ID; } }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }   
        public string Address { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifyDate { get; set; }

        public string ImagePath { get; set; }


        public string FullName
        {
            get {

                string _FullName = "";
                if (string.IsNullOrEmpty(SecondName))
                {
                    _FullName = FirstName + " " + LastName;
                }
                else
                {
                    _FullName = FirstName + " "+SecondName+" " + LastName;

                }
                return _FullName;

            }
        }



        public clsPerson(clsPersonDTO dto)
        {
            _ID = dto.ID;
            FirstName = dto.FirstName;
            SecondName = dto.SecondName;
            LastName = dto.LastName;
            Phone = dto.Phone;
            Address = dto.Address;
            CreateDate = dto.CreateDate;
            ModifyDate = dto.ModifyDate;
            ImagePath = dto.ImagePath;
             
            Mode = enMode.eUpdate;
        }

        public clsPerson( )
        {
            _ID = -1;
            FirstName ="";
            SecondName = "";
            LastName = "";
            Phone = "";
            Address = "";
            CreateDate = DateTime.Now;
            ModifyDate = DateTime.Now;


            Mode =enMode.eAdd;
        }


        public static clsPerson FindPersonByID(int PersonID)
        {
            clsPersonDTO personDTO =clsPersonData.FindPersonByID(PersonID);
            if(personDTO != null)
            {
                return new clsPerson(personDTO);
            }
            return null;


        }
        public static clsPerson FindPersonByPhone(string Phone)
        {
            clsPersonDTO personDTO = clsPersonData.FindPersonByPhone(Phone);
            if (personDTO != null)
            {
                return new clsPerson(personDTO);
            }
            return null;


        }

        public static DataTable GetAllPeople ()
        {
            return clsPersonData.GetAllPeople();
        }

        public static bool DeletePersonByID(int PersonID)
        {
            bool Deleted=false;
            string ImagePath=clsPersonData.GetImagePathByPersonID(PersonID);
            Deleted= clsPersonData.DeletePersonByID(PersonID);  
            if(Deleted&&!string.IsNullOrEmpty(ImagePath))
            {
                if(File.Exists(ImagePath))
                {
                    File.Delete(ImagePath);
                }

            }
            return Deleted;

        }

       
        public bool Save()
        {

            switch (Mode)
            {
                case enMode.eAdd:
                    {
                        if(_AddPerson())
                        {

                            Mode = enMode.eUpdate;
                            return true;
                        }

                        
                        break;
                    }
                case enMode.eUpdate:
                    {
                        if(_UpdatePerson())
                        {
                            return true; 
                        }


                        break;
                    }



            }

            return false;


        }



    }


}
