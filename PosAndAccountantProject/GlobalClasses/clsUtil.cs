using PosAndAccountant_business;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosAndAccountantProject.GlobalClasses
{
    internal class clsUtil
    {
        public static clsUser CurrentUser=clsUser.FindUserByID(1);

        public static bool CreateFolderIfNotExist(string FolderPath)
        {
            try
            {
                if (!Directory.Exists(FolderPath))
                {
                    Directory.CreateDirectory(FolderPath);
                    return true;
                }


            }

            catch (Exception ex)
            {

                MessageBox.Show("خطأ اثناء انشاء فولدر ل الصور " + ex.Message);
                return false;
            }


            return true;

        }

        public static string CreateGuideString()
        {
            Guid guid = Guid.NewGuid();
            return guid.ToString();
        }
        public static string ReplaceFileNameWithGuied(string FileName)
        {

            FileInfo file = new FileInfo(FileName);

            return CreateGuideString() + file.Extension;

        }

        public static bool CopyImageToProjectImagesFolder(ref string sourceFile,string ProjectImagesFolder)
        {
            if (!CreateFolderIfNotExist(ProjectImagesFolder))
            {
                return false;

            }
            string Destination = ProjectImagesFolder + ReplaceFileNameWithGuied(sourceFile);
            try
            {
                File.Copy(sourceFile, Destination);

            }
            catch (IOException ex)
            {
                
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
               
            }


            sourceFile = Destination;

            return true;

        }


    }
}