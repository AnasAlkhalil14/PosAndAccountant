using PosAndAccountant_DataAccess;
using PosAndAccountant_DataTransfer;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosAndAccountant_business
{
    public class clsPartnerTransaction
    {
        public enum enMode { eAdd,eUpdate}
        public enMode Mode;

        public clsPartnerTransaction()
        {
            PartnerTransactionID =-1;
            PartnerID = -1;
            TransactionType = -1;
            Amount = 0;
            CreatedDate = DateTime.Now;
            Notes ="";
            Mode = enMode.eAdd;
        }

        public clsPartnerTransaction(clsPartnerTransactionDTO partnerTransactionDTO)
        {
            PartnerTransactionID = partnerTransactionDTO.PartnerTransactionID;
            PartnerID = partnerTransactionDTO.PartnerID;
            TransactionType = partnerTransactionDTO.TransactionType;
            Amount = partnerTransactionDTO.Amount;
            CreatedDate = partnerTransactionDTO.CreatedDate;
            Notes = partnerTransactionDTO.Notes;
            Mode = enMode.eUpdate;
        }

        public int PartnerTransactionID { get; set; }
        public int PartnerID { get; set; }
        public int TransactionType { get; set; }
        public double Amount { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Notes { get; set; }

        private bool _Add()
        {
            clsPartnerTransactionDTO partnerTransactionDTO = new clsPartnerTransactionDTO();
            partnerTransactionDTO.TransactionType = TransactionType;
            partnerTransactionDTO.Amount = Amount;
            partnerTransactionDTO.PartnerID = PartnerID;
            partnerTransactionDTO.Notes = Notes;
           PartnerTransactionID= clsPartnerTransactionData.AddPartnerTransaction(partnerTransactionDTO);
            return PartnerTransactionID != -1;
        }

        public bool Save()
        {

            switch (Mode)
            {
                case enMode.eAdd:
                    {
                        if(_Add())
                        {
                            Mode= enMode.eUpdate;
                        }
                        return true ;
                    }



            }

            return false;

        }


    }
}
