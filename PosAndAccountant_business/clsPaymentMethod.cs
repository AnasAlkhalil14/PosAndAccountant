using PosAndAccountant_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosAndAccountant_business
{
    public class clsPaymentMethod
    {

        public static DataTable AllPaymentMethos()
        {
            return clsPaymentMethodData.GetAllPaymetnMethods();
        }
    }
}
