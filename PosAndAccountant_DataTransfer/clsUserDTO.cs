using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosAndAccountant_DataTransfer
{
    public class clsUserDTO
    {
        public clsUserDTO(int userID, int personID, string userName, string hashPassword,string PasswordSalt, string notes, int permissionInBinary, DateTime createdDate, bool isActive)
        {
            UserID = userID;
            PersonID = personID;
            UserName = userName;
            HashPassword = hashPassword;
            this.PasswordSalt = PasswordSalt;
            Notes = notes;
            PermissionInBinary = permissionInBinary;
            CreatedDate = createdDate;
            IsActive = isActive;
        }


        public clsUserDTO() 
        {


            UserID = -1;
            PersonID = -1;
            UserName = "";
            HashPassword = "";
            PasswordSalt = "";
            Notes = "";
            PermissionInBinary = 0;
            CreatedDate = DateTime.Now;
            IsActive = false;



        }



        public int UserID { get; set; }
        public int PersonID {  get; set; }
        public string UserName {  get; set; }
 public string HashPassword {  get; set; }
        public string PasswordSalt {  get; set; }

        public string Notes {  get; set; }
        public int PermissionInBinary {  get; set; }
        public DateTime CreatedDate {  get; set; }
        public bool IsActive {  get; set; }
 

    }
}
