using PosAndAccountant_DataAccess;
using PosAndAccountant_DataTransfer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosAndAccountant_business
{
    public class clsUser
    {

        private bool _AddUser()
        {
            clsUserDTO UserDTO = new clsUserDTO();
            UserDTO.UserName=this.UserName;
            UserDTO.Notes=this.Notes;
            this.PasswordSalt = clsCryptography.GenerateSalt();
            UserDTO.PasswordSalt=this.PasswordSalt;
            this.HashPassword=clsCryptography.Hashing(this.HashPassword,this.PasswordSalt);

          UserDTO.HashPassword=this.HashPassword;
            UserDTO.PermissionInBinary=this.PermissionInBinary;
            UserDTO.PersonID=this.PersonID;
            UserDTO.IsActive=this.IsActive;
            this.UserID = clsUserData.AddNewUser(UserDTO);
            return this.UserID != -1;
         }
        private bool _UpdateUser()
        {
            clsUserDTO UserDTO = new clsUserDTO();
            UserDTO.UserID = this.UserID;
            UserDTO.CreatedDate = this.CreatedDate;
            UserDTO.UserName = this.UserName;
            UserDTO.Notes = this.Notes;
            this.HashPassword = clsCryptography.Hashing(this.HashPassword, this.PasswordSalt);
            UserDTO.HashPassword = this.HashPassword;

            UserDTO.PermissionInBinary = this.PermissionInBinary;
            UserDTO.PersonID = this.PersonID;
            UserDTO.IsActive = this.IsActive;

            return clsUserData.UpdateUserByID(UserDTO);

        }



        public enum enMode { eAdd,eUpdate}
        public enMode Mode { get; set; }

        public clsUser(clsUserDTO UserDTO)
        {
            UserID = UserDTO.UserID;
            PersonID = UserDTO.PersonID;
            UserName = UserDTO.UserName;
            HashPassword = UserDTO.HashPassword;
            PasswordSalt= UserDTO.PasswordSalt;
            Notes = UserDTO.Notes;
            PermissionInBinary = UserDTO.PermissionInBinary;
            CreatedDate = UserDTO.CreatedDate;
            IsActive = UserDTO.IsActive;
            Mode = enMode.eUpdate;
        }


        public clsUser()
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

            Mode=enMode.eAdd;

        }



        public int UserID { get; set; }
        public int PersonID { get; set; }
        public string UserName { get; set; }
        public string HashPassword { get; set; }

        public string PasswordSalt { get; private set; }

        public string Notes { get; set; }
        public int PermissionInBinary { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }

        public string Permission()
        {
            //Complite it When Complite The System to Know all Permissions Exist;
            return "";
        }

        public bool Save()
        {

            switch (Mode)
            {
                case enMode.eAdd:
                    {
                        if(_AddUser())
                        {
                            Mode = enMode.eUpdate;
                            return true;
                        }else
                        {
                            return false;
                        }

                     }
                    
                    case enMode.eUpdate:
                    {
                        return _UpdateUser();
                        
                    }
                default:
                    {
                        return false;
                    }


            }


         }

        public static DataTable GetAllUsersList()
        {
            return clsUserData.GetAllUsers();
        }
        public static bool DeleteUserByID(int UserID)
        {
            return clsUserData.DeleteUserByID(UserID);
        }

        public static clsUser FindUserByID(int UserID)
        {
            clsUserDTO UserDTO = clsUserData.GetUserByID(UserID);
            if (UserDTO != null)
            {
                return new clsUser(UserDTO);
            }
            return null;


        }
        public static clsUser FindUserByUserNameAndPassword(string UserName,string Password)
        {
            clsUserDTO UserDTO=clsUserData.GetUserByUserName(UserName);
            if(UserDTO != null)
            {
                if(clsCryptography.Hashing(Password, UserDTO.PasswordSalt)==UserDTO.HashPassword)
                {

                    return new clsUser(UserDTO);



                }
                else
                {
                    return null;
                }


            }



            return null;


        }


    }
}
