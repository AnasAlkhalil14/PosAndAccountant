using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosAndAccountantProject
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void lklForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("يرجى مراجعة مسؤول النظام لإعادة تعيين كلمة المرور", "طلب المساعدة", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void frmTest_Load(object sender, EventArgs e)
         {
       
         }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void printDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }
    }
}
