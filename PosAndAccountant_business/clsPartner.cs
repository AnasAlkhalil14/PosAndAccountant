using PosAndAccountant_DataAccess;
using PosAndAccountant_DataTransfer;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace PosAndAccountant_business
{
    public class clsPartner
    {
        public enum enMode { eAdd, eUpdate }
        public enMode Mode;

        private bool _AddPartner(DataTable OtherPartners,out string Error )
        {

            this.PartnerID = clsPartnerData.SavePartnerWithPercentages(null, this.PersonID, this.CurrentBalance, this.ProfitPercentage, OtherPartners, out Error);


             return this.PartnerID != -1;
        }
        private bool _UpdatePartner(DataTable Other,out string Error)
        {

            this.PartnerID = clsPartnerData.SavePartnerWithPercentages(PartnerID, this.PersonID, this.CurrentBalance, this.ProfitPercentage, Other, out Error);


            return this.PartnerID != -1;

        }

    

        public clsPerson PersonInfo { get; set; }
        public int PartnerID { get; set; }
        public int PersonID
        {
            get { return _PersonID; }
            set
            {
                _PersonID = value;
                PersonInfo = clsPerson.FindPersonByID(value);
            }
        }
        private int _PersonID;
        public bool IsActive { get; set; }
        public decimal ProfitPercentage { get; set; }
       
        public decimal CurrentBalance { get; set; }
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
             Mode = enMode.eUpdate;

        }

        public bool Save(DataTable OtherPartners,out string Error)
        {

            switch (Mode)
            {
                case enMode.eAdd:
                    {
                        if (_AddPartner(OtherPartners,out Error))
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
                        return _UpdatePartner(OtherPartners, out Error);

                    }
                default:
                    {
                        Error = "An Error in Mode Occure";
                        return false;
                    }


            }


        }
        public static DataTable GetAllPartnersShort()
        {
            return clsPartnerData.GetAllPartnersShort();
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
        public static clsPartner FindPartnerByPersonID(int PersonID)
        {
            clsPartnerDTO PartnerDTO = clsPartnerData.FindPartnerByPersonID(PersonID);
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

        public static decimal AllPartnersBalance()
        {
            return clsPartnerData.AllPartnersBalance();
        }
        public static DataTable GetAllPartnersShortWithPercentage()
        {
            return clsPartnerData.GetAllPartnersShortWithPercentage();
        }
        public static int SavePartnerWithPercentages(
 int? partnerID,              // null = new partner, value = edit
 int personID,
 decimal currentBalance,      // used only for a new partner (pass 0 when editing)
 decimal profitPercentage,    // this partner's own percentage
 DataTable otherPartners,     // columns in this order: PartnerID (int), ProfitPercentage (decimal)
 out string error,bool IsActive=true)
        {
            error = "";
            return clsPartnerData.SavePartnerWithPercentages(partnerID, personID, currentBalance, profitPercentage, otherPartners,out error,IsActive);
        }
    }
}
