using PosAndAccountant_DataAccess;
using PosAndAccountant_DataTransfer;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PosAndAccountant_business
{
    public class clsUser
    {
        public static clsUser CurrentUser = clsUser.FindUserByID(1);
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

       private static readonly byte[] _Salt = Encoding.UTF8.GetBytes("PosAndAccounting");
        private static readonly string _PathForRememberMe = Path.Combine(

                   Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),

                 "RememberMeData","RememberMe.dat"

       );

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

        public bool IsPasswordEqual(string Password)
        {
            return HashPassword==clsCryptography.Hashing(Password,this.PasswordSalt);
        }

        public static bool IsUserExistByUserName(string UserName)
        {
            return clsUserData.IsUserExistByUserName(UserName);
        }

        public static void SaveDataForRememberMe(string UserName,string Password)
        {
           

            string Data = $"{UserName}#//#{Password}";
            byte[]DataBytes=Encoding.UTF8.GetBytes(Data);

            byte[] EncryptedData = ProtectedData.Protect(DataBytes, _Salt, DataProtectionScope.CurrentUser);

            Directory.CreateDirectory(Path.GetDirectoryName(_PathForRememberMe));

            File.WriteAllBytes(_PathForRememberMe,EncryptedData);
        }
        public static (string UserName, string Password)? LoadDataForRemeberMe()
        {
            if (!File.Exists(_PathForRememberMe)) return null;

            byte[]ProtectBytes=File.ReadAllBytes(_PathForRememberMe);

           byte [] DataBytes= ProtectedData.Unprotect(ProtectBytes, _Salt, DataProtectionScope.CurrentUser);
       
            string DataString= Encoding.UTF8.GetString(DataBytes);

            string[] DataStringArray = DataString.Split(new string[] { "#//#" },
    StringSplitOptions.None);

            if (DataStringArray.Length != 2) return null;
            
            return (DataStringArray[0], DataStringArray[1]);

        }

       public static void ClearDataOfRemeberMe()
        {
            if(File.Exists(_PathForRememberMe))
                File.Delete(_PathForRememberMe);
        }

    }
}
