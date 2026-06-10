using PosAndAccountant_DataAccess;
using PosAndAccountant_DataTransfer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosAndAccountant_business
{
    public class clsPartner
    {
        public enum enMode { eAdd, eUpdate }
        public enMode Mode;

        private bool _AddPartner()
        {
            clsPartnerDTO PartnerDTO = new clsPartnerDTO();
            PartnerDTO.PersonID = this.PersonID;
            PartnerDTO.CurrentBalance = this.CurrentBalance;
            PartnerDTO.IsActive = this.IsActive;
            PartnerDTO.ProfitPercentage = this.ProfitPercentage;
        


            this.PartnerID = clsPartnerData.AddNewPartner(PartnerDTO);
            return this.PartnerID != -1;
        }
        private bool _UpdatePartner()
        {

            clsPartnerDTO PartnerDTO = new clsPartnerDTO();
            PartnerDTO.PartnerID = this.PartnerID;
            PartnerDTO.PersonID = this.PersonID;
            PartnerDTO.CurrentBalance = this.CurrentBalance;
            PartnerDTO.IsActive = this.IsActive;
            PartnerDTO.ProfitPercentage = this.ProfitPercentage;



            return clsPartnerData.UpdatePartnerByID(PartnerDTO);

        }

    

        public clsPerson PersonInfo { get; set; }
        public int PartnerID { get; set; }
        public int PersonID { get; set; }
        public bool IsActive { get; set; }
        public double ProfitPercentage { get; set; }
       
        public double CurrentBalance { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public clsPartner()
        {
            PartnerID = -1;
            PersonID = -1;
            IsActive = false;

            CurrentBalance = 0;
            CurrentBalance = 0;
          
            CreatedDate = DateTime.Now;
            ModifiedDate = DateTime.Now;
            Mode = enMode.eAdd;

        }

        public clsPartner(clsPartnerDTO PartnerDTO)
        {
            PartnerID = PartnerDTO.PartnerID;
            PersonID = PartnerDTO.PersonID;
            IsActive = PartnerDTO.IsActive;

            CurrentBalance = PartnerDTO.CurrentBalance;
            ProfitPercentage = PartnerDTO.ProfitPercentage;
         
            CreatedDate = PartnerDTO.CreatedDate;
            ModifiedDate = PartnerDTO.ModifiedDate;
            PersonInfo = clsPerson.FindPersonByID(PersonID);
            Mode = enMode.eUpdate;

        }

        public bool Save()
        {

            switch (Mode)
            {
                case enMode.eAdd:
                    {
                        if (_AddPartner())
                        {
                            Mode = enMode.eUpdate;
                            return true;
                        }
                        else
                        {
                            return false;
                        }

                    }

                case enMode.eUpdate:
                    {
                        return _UpdatePartner();

                    }
                default:
                    {
                        return false;
                    }


            }


        }

        public static DataTable GetAllPartners()
        {
            return clsPartnerData.GetAllPartners();
        }
        public static bool DeletePartnerByID(int PartnerID)
        {
            return clsPartnerData.DeletePartnerByID(PartnerID);
        }

        public static clsPartner FindPartnerByID(int PartnerID)
        {
            clsPartnerDTO PartnerDTO = clsPartnerData.FindPartnerByID(PartnerID);
            if (PartnerDTO != null)
            {
                return new clsPartner(PartnerDTO);
            }
            return null;


        }
     

        public static bool IsPersonPartner(int PersonID)
        {
            return clsPartnerData.IsPersonPartner(PersonID);
        }




    }
}
