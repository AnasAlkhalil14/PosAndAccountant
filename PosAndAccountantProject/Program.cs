using PosAndAccountantProject.Customers;
using PosAndAccountantProject.Expenses;
using PosAndAccountantProject.Login;
using PosAndAccountantProject.Partners;
using PosAndAccountantProject.People;
using PosAndAccountantProject.Products;
using PosAndAccountantProject.Products.ProductsCategory;
using PosAndAccountantProject.Purchases;
using PosAndAccountantProject.Reports;
using PosAndAccountantProject.Sales;
using PosAndAccountantProject.Suppliers;
using PosAndAccountantProject.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
            
namespace PosAndAccountantProject
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmAddUpdateSale() );
        }
    }
}
