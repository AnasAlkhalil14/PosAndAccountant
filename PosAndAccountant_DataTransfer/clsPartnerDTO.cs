using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PosAndAccountant_DataTransfer
{
    public class clsPartnerDTO
    {
        public int PartnerID {  get; set; }
        public int PersonID {  get; set; }
public decimal CurrentBalance {  get; set; }
            public decimal ProfitPercentage {  get; set; }
         public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }   

        public bool IsActive {  get; set; }
  

    }
}
