using PosAndAccountant_DataAccess;
using PosAndAccountant_DataTransfer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PosAndAccountant_business
{
    public class clsExpense
    {
public enum enMode { eAdd,eUpdate}
        public enMode Mode= enMode.eAdd;

        public int ExpenseID { get; set; }
        public int UserID { get; set; }
        public int ExpenseTypeID { get; set; }
        public DateTime CreatedDate { get; set; }
        public double Amount { get; set; }
        public string ExpenseDescription { get; set; }

       public clsExpense()
        {
            Mode = enMode.eAdd;
            ExpenseDescription = string.Empty;
            ExpenseID = -1;
            UserID = -1;
            ExpenseTypeID = -1;
            CreatedDate = DateTime.MinValue;
            Amount = 0;
           
        }

        private clsExpense(clsExpenseDTO dto)
        {
            ExpenseID= dto.ExpenseID;
            ExpenseTypeID = dto.ExpenseTypeID;
            UserID= dto.UserID;
            ExpenseDescription= dto.ExpenseDescription;
            CreatedDate= dto.CreatedDate;   
            Amount= dto.Amount;
            Mode = enMode.eUpdate;
        }

        private bool _Add()
        {
            clsExpenseDTO dto = new clsExpenseDTO();
            dto.ExpenseTypeID = ExpenseTypeID;
            dto.UserID = UserID;
            dto.ExpenseDescription = ExpenseDescription;
         dto.Amount = Amount;
            ExpenseID = clsExpneseData.AddExpense(dto);
            return ExpenseID != -1;

        }

        private bool _Update()
        {

            return false;
        }
        public bool Save()
        {
            switch(Mode)
            {

                case enMode.eAdd:
                    {
                        if(_Add())
                        {
                            Mode = enMode.eUpdate;
                        return true;
                        }
                        break;
                    }
                    case enMode.eUpdate:
                    {
                        return _Update();
                    }
            }

            return false;

        }


        public static DataTable GetAllExpenseTypes()
        {
            return clsExpneseData.GetAllExpenseTypes();
        }
        public static bool AddExpenseType(string Type,string Note) 
        {
            return clsExpneseData.AddExpneseType(Type, Note)!=-1;
        }

    }
}
