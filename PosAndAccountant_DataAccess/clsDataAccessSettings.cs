using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace PosAndAccountant_DataAccess
{
    static class clsDataAccessSettings
    {

        public static string ConnectionString
        {

            get
            {
                return ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;


            }


        }


    }
}
