using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosAndAccountant_DataTransfer
{
    public class clsPartnerTransactionDTO
    {
        
        public int PartnerTransactionID {  get; set; }
        public int PartnerID { get; set; }
        public int TransactionType {  get; set; }
        public double Amount {  get; set; }
        public DateTime CreatedDate { get; set; }
        public string Notes { get; set; }
    }
}
