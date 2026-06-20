using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosAndAccountant_DataTransfer
{
    public class clsExpenseDTO
    {
      

        public int ExpenseID { get; set; }
        public int UserID {  get; set; }
        public int ExpenseTypeID { get; set; }
        public DateTime CreatedDate { get; set;}
        public double Amount { get; set; }
        public string ExpenseDescription {  get; set; }
    }
}
