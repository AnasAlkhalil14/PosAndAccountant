using PosAndAccountant_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PosAndAccountant_business
{
    public class clsExpense
    {




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
