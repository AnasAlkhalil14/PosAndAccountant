using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosAndAccountant_DataTransfer
{
    public  class clsCustomerDTO
    {
        public int CustomerID               {  get; set; }   
        public int PersonID                 {  get; set; }
        public bool IsActive                {  get; set; }
        public string Notes                 {  get; set; }
        public double TotalRemainingDebt   {  get; set; }
        public double CreditLimit      {  get; set; }
        public int CustomerType             {  get; set; }
        public double DiscountPercentage    {  get; set; }
        public DateTime CreatedDate      {  get; set; }
        public DateTime ModifiedDate         { get; set; }


    }
}
