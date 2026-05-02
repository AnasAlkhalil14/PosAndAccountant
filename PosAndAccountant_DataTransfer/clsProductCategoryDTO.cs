using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosAndAccountant_DataTransfer
{
    public class clsProductCategoryDTO
    {
        public int CategoryID {  get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; } 
        public DateTime CreateDate { get; set; }

    }
}
