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
    public class clsSupplier
    {

        public enum enMode { eAdd, eUpdate }
        public enMode Mode;

        private bool _AddSupplier()
        {
            clsSupplierDTO SupplierDTO = new clsSupplierDTO();
            SupplierDTO.PersonID = this.PersonID;
            SupplierDTO.Notes = this.Notes;
            SupplierDTO.IsActive = this.IsActive;
            SupplierDTO.TotalRemainingDebt = this.TotalRemainingDebt;

            this.SupplierID = clsSupplierData.AddNewSupplier(SupplierDTO);
            return this.SupplierID != -1;
        }
        private bool _UpdateSupplier()
        {

            clsSupplierDTO SupplierDTO = new clsSupplierDTO();
            SupplierDTO.SupplierID = this.SupplierID;
            SupplierDTO.PersonID = this.PersonID;
            SupplierDTO.Notes = this.Notes;
            SupplierDTO.IsActive = this.IsActive;
           
            SupplierDTO.TotalRemainingDebt = this.TotalRemainingDebt;


            return clsSupplierData.UpdateSupplierByID(SupplierDTO);

        }

       

        public clsPerson PersonInfo { get; set; }
        public int SupplierID { get; set; }
        public int PersonID { get; set; }
        public bool IsActive { get; set; }
        public string Notes { get; set; }
        public double TotalRemainingDebt { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public clsSupplier()
        {
            SupplierID = -1;
            PersonID = -1;
            IsActive = false;
            Notes = "";
            TotalRemainingDebt = 0;
           
            CreatedDate = DateTime.Now;
            ModifiedDate = DateTime.Now;
            Mode = enMode.eAdd;

        }

        public clsSupplier(clsSupplierDTO SupplierDTO)
        {
            SupplierID = SupplierDTO.SupplierID;
            PersonID = SupplierDTO.PersonID;
            IsActive = SupplierDTO.IsActive;
            Notes = SupplierDTO.Notes;
            TotalRemainingDebt = SupplierDTO.TotalRemainingDebt;
           
            CreatedDate = SupplierDTO.CreatedDate;
            ModifiedDate = SupplierDTO.ModifiedDate;
            PersonInfo = clsPerson.FindPersonByID(PersonID);
            Mode = enMode.eUpdate;

        }

        public bool Save()
        {

            switch (Mode)
            {
                case enMode.eAdd:
                    {
                        if (_AddSupplier())
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
                        return _UpdateSupplier();

                    }
                default:
                    {
                        return false;
                    }


            }


        }

        public static DataTable GetAllSuppliersList()
        {
            return clsSupplierData.GetAllSuppliers();
        }
        public static bool DeleteSupplierByID(int SupplierID)
        {
            return clsSupplierData.DeleteSupplierByID(SupplierID);
        }

        public static clsSupplier FindSupplierByID(int SupplierID)
        {
            clsSupplierDTO SupplierDTO = clsSupplierData.FindSupplierByID(SupplierID);
            if (SupplierDTO != null)
            {
                return new clsSupplier(SupplierDTO);
            }
            return null;


        }
        public static clsSupplier FindUserByPersonID(int PersonID)
        {
            clsSupplierDTO SupplierDTO = clsSupplierData.FindSupplierByPersonID(PersonID);
            if (SupplierDTO != null)
            {
                return new clsSupplier(SupplierDTO);


            }

            return null;
        }

        public static bool IsPersonSupplier(int PersonID)
        {
            return clsSupplierData.IsPersonSupplier(PersonID);
        }





    }
}
