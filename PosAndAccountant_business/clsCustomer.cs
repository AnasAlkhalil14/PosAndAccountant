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
    public class clsCustomer
    {
        public enum enMode { eAdd,eUpdate}
        public enMode Mode;

        private bool _AddCustomer()
        {
            clsCustomerDTO CustomerDTO = new clsCustomerDTO();
            CustomerDTO.PersonID = this.PersonID;
            CustomerDTO.Notes = this.Notes;
            CustomerDTO.IsActive = this.IsActive;
            CustomerDTO.DiscountPercentage = this.DiscountPercentage;
            CustomerDTO.CreditLimit= this.CreditLimit;
            CustomerDTO.CustomerType=this.CustomerType;
            CustomerDTO.TotalRemainingDebt= this.TotalRemainingDebt;
                
            
            this.CustomerID = clsCustomerData.AddNewCustomer(CustomerDTO);
            return this.CustomerID != -1;
        }
        private bool _UpdateCustomer()
        {

            clsCustomerDTO CustomerDTO = new clsCustomerDTO();
            CustomerDTO.CustomerID = this.CustomerID;
            CustomerDTO.PersonID = this.PersonID;
            CustomerDTO.Notes = this.Notes;
            CustomerDTO.IsActive = this.IsActive;
            CustomerDTO.DiscountPercentage = this.DiscountPercentage;
            CustomerDTO.CreditLimit = this.CreditLimit;
            CustomerDTO.CustomerType = this.CustomerType;
            CustomerDTO.TotalRemainingDebt = this.TotalRemainingDebt;


            return clsCustomerData.UpdateCustomerByID(CustomerDTO);

        }

        public string CustomerTypeString()
        {
            return "Customer Typ String will be implemented soon";
        }

        public clsPerson PersonInfo {  get; set; }
        public int CustomerID { get; set; }
        public int PersonID { get; set; }
        public bool IsActive { get; set; }
        public string Notes { get; set; }
        public double TotalRemainingDebt { get; set; }
        public double CreditLimit { get; set; }
        public int CustomerType { get; set; }
        public double DiscountPercentage { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public clsCustomer()
        {
            CustomerID = -1;
            PersonID = -1;
             IsActive=false;
            Notes = "";
            TotalRemainingDebt = 0;
            CreditLimit = 0;
            CustomerType= 0;
            DiscountPercentage = 0;
            CreatedDate = DateTime.Now;
            ModifiedDate= DateTime.Now;
            Mode = enMode.eAdd;

        }

        public clsCustomer(clsCustomerDTO CustomerDTO)
        {
            CustomerID =CustomerDTO.CustomerID;
            PersonID = CustomerDTO.PersonID;
            IsActive = CustomerDTO.IsActive;
            Notes = CustomerDTO.Notes;
            TotalRemainingDebt = CustomerDTO.TotalRemainingDebt;
            CreditLimit = CustomerDTO.CreditLimit;
            CustomerType = CustomerDTO.CustomerType;
            DiscountPercentage = CustomerDTO.DiscountPercentage;
            CreatedDate = CustomerDTO.CreatedDate;
            ModifiedDate = CustomerDTO.ModifiedDate;
            PersonInfo = clsPerson.FindPersonByID(PersonID);
            Mode = enMode.eUpdate;

        }

        public bool Save()
        {

            switch (Mode)
            {
                case enMode.eAdd:
                    {
                        if (_AddCustomer())
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
                        return _UpdateCustomer();

                    }
                default:
                    {
                        return false;
                    }


            }


        }

        public static DataTable GetAllCustombersList()
        {
            return clsCustomerData.GetAllCustomers();
        }
        public static bool DeleteCustomerByID(int CustomerID)
        {
            return clsCustomerData.DeleteCustomerByID(CustomerID);
        }

        public static clsCustomer FindCustomerByID(int CustomerID)
        {
             clsCustomerDTO customerDTO = clsCustomerData.FindCustomerByID(CustomerID);
            if (customerDTO != null)
            {
                return new clsCustomer(customerDTO);
            }
            return null;


        }
        public static clsCustomer FindUserByPersonID(int PersonID)
        {
            clsCustomerDTO customerDTO = clsCustomerData.FindCustomerByPersonID(PersonID);
            if (customerDTO != null)
            {
                return new clsCustomer(customerDTO);


            }

            return null;
        }

        public static bool IsPersonCustomer(int PersonID)
        {
            return clsCustomerData.IsPersonCustomer(PersonID);
        }

    }
}
