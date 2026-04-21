using PosAndAccountant_business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosAndAccountantProject.People
{
    public partial class frmListPeople : Form
    {
        public frmListPeople()
        {
            InitializeComponent();
        }
        

    private    DataTable _AllPeople  = clsPerson.GetAllPeople();

      
        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {


            frmShowPersonInfo frm = new frmShowPersonInfo(Convert.ToInt32(dgvPeople.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
             using (frmAddUpdatePerson frm = new frmAddUpdatePerson())
            {
                frm.ShowDialog();

                if (frm.WasSaved)
                {
                    _RefreshForm();
                }

            }
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void _RefreshForm()
        {
            _AllPeople=clsPerson.GetAllPeople();
            dgvPeople.DataSource= _AllPeople;
            lblRecordsCount.Text=dgvPeople.Rows.Count.ToString();

        }
        private void frmListPeople_Load(object sender, EventArgs e)
        {
            dgvPeople.DataSource= _AllPeople;

            lblRecordsCount.Text=dgvPeople.Rows.Count.ToString() ;
            if(dgvPeople.Rows.Count > 0 )
            {

                dgvPeople.Columns[0].HeaderText = "معرف الشخص";
                dgvPeople.Columns[1].HeaderText = "الاسم الاول";
                dgvPeople.Columns[2].HeaderText = "الاسم الثاني";
                dgvPeople.Columns[3].HeaderText = "الكنية";
                dgvPeople.Columns[4].HeaderText = "الهاتف";
                dgvPeople.Columns[7].HeaderText = "العنوان";
                dgvPeople.Columns[5].HeaderText = "تاريخ الانشاء";
                dgvPeople.Columns[6].Visible= false;
                dgvPeople.Columns[8].Visible = false;
 
            }

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmAddUpdatePerson frm = new frmAddUpdatePerson(Convert.ToInt32(dgvPeople.CurrentRow.Cells[0].Value)))
            {
                frm.ShowDialog();

                if (frm.WasSaved)
                {
                    _RefreshForm();
                }

            }

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = Convert.ToInt32(dgvPeople.CurrentRow.Cells[0].Value);
            if (MessageBox.Show($"Are you sure you want to delete Person with ID:{PersonID}","Confirm deltete",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                 if(clsPerson.DeletePersonByID(PersonID))
                {
                    _RefreshForm();
                    MessageBox.Show($"Person with ID={PersonID} deleted Successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Failed to delete Person with ID={PersonID},he has data linked to him", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
                    
                    
     }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            using (frmAddUpdatePerson frm = new frmAddUpdatePerson())
            {
                frm.ShowDialog();

                if(frm.WasSaved)
                {
                    _RefreshForm();
                }
               
            }
                
             
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = cbFilterBy.SelectedIndex != 0;

            txtFilterValue.Clear();
            txtFilterValue.Focus();
            
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
 


            if(cbFilterBy.SelectedIndex==1)
            {
                e.Handled=!char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar);
            }

        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            if(cbFilterBy.SelectedIndex==0||string.IsNullOrEmpty( txtFilterValue.Text.Trim()))
            {
                _AllPeople.DefaultView.RowFilter = "";
                lblRecordsCount.Text=dgvPeople.Rows.Count.ToString();
                return;
            }

            string ColumnName = "";
            switch(cbFilterBy.SelectedIndex)
            {
                case 1:
                    {
                        ColumnName = "PersonID";
                        break;
                    }
                case 2:
                    {
                        ColumnName = "FirstName";
                        break;
                    }
                case 3:
                    {
                        ColumnName = "LastName";
                        break;
                    }
                case 4:
                    {
                        ColumnName = "Phone";
                        break;
                    }


            }

            if (cbFilterBy.SelectedIndex==1)
            {
                _AllPeople.DefaultView.RowFilter = string.Format("[{0}]={1}",ColumnName,txtFilterValue.Text.Trim());


            }
            else
            {
                _AllPeople.DefaultView.RowFilter = string.Format("[{0}] like '%{1}%'", ColumnName, txtFilterValue.Text.Trim());
            }

            lblRecordsCount.Text = dgvPeople.Rows.Count.ToString();





        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
