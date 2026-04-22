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

namespace PosAndAccountantProject.Users
{
    public partial class frmListUsers : Form
    {
        public frmListUsers()
        {
            InitializeComponent();
        }

        private DataTable _AllUsers;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            if(cbFilterBy.SelectedIndex == 0)
            {
                txtFilterValue.Visible = false;
            }
            else if (cbFilterBy.SelectedIndex != 6)
            {
                txtFilterValue.Visible = true;

            }
            else
            {
                txtFilterValue.Visible = false;
            }
            cbIsActive.Visible = cbFilterBy.SelectedIndex==5;


            txtFilterValue.Clear();
            cbIsActive.SelectedIndex = 0;

            _AllUsers.DefaultView.RowFilter = "";
        }
        private void _RefreshForm()
        {
            _AllUsers = clsUser.GetAllUsersList();
dgvUsers.DataSource = _AllUsers;
            lblRecordsCount.Text = dgvUsers.Rows.Count.ToString();
         }

        private void frmListUsers_Load(object sender, EventArgs e)
        {
            _AllUsers=clsUser.GetAllUsersList();
            cbFilterBy.SelectedIndex = 0;

            dgvUsers.DataSource = _AllUsers;
              lblRecordsCount.Text=dgvUsers.Rows.Count.ToString();
            if(dgvUsers.Rows.Count > 0 )
            {
                dgvUsers.Columns[0].HeaderText = "معرف المستخدم";
                dgvUsers.Columns[1].HeaderText = "معرف الشخص";
                dgvUsers.Columns[2].HeaderText = "اسم المستخدم";
                dgvUsers.Columns[3].HeaderText = "اسم الكامل";
                dgvUsers.Columns[4].HeaderText = "ملاحظات";
                dgvUsers.Columns[5].HeaderText = "تاريخ الانشاء";
                dgvUsers.Columns[6].HeaderText = "هل نشط";

            }


        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddUpdatUser frm=new frmAddUpdatUser();
            frm.ShowDialog();
            //if(frm.WasSaved)
            //{RefreshForm();}
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbIsActive.SelectedIndex == 0)
            {
                _AllUsers.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvUsers.Rows.Count.ToString();
                return;
            }
            byte isActive = 1;
            if(cbIsActive.SelectedIndex == 2)
            {
                isActive= 0;
            }

            _AllUsers.DefaultView.RowFilter = string.Format("[{0}]={1}", "IsActive",isActive.ToString());
            lblRecordsCount.Text = dgvUsers.Rows.Count.ToString();

        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {


            string FilterColumn="";
            switch (cbFilterBy.SelectedIndex)
            {
                case 0:
                    {

                        break;
                    }
                case 1:
                    {
                        FilterColumn = "UserID";break;
                    }
                case 2:
                    {
                        FilterColumn = "UserName"; break;
                    }
                case 3:
                    {
                        FilterColumn = "PersonID"; break;
                    }
                case 4:
                    {
                        FilterColumn = "FullName"; break;
                    }
                case 5:
                    {
                        FilterColumn = "IsActive"; break;
                    }
                default:
                    {
                        FilterColumn = "None"; break;
                        
                    }

            }

            if(cbFilterBy.SelectedIndex == 0||string.IsNullOrEmpty(txtFilterValue.Text))
            {
                _AllUsers.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvUsers.Rows.Count.ToString();
                return;

            }

            if (FilterColumn=="PersonID"||FilterColumn=="UserID")
            {
                _AllUsers.DefaultView.RowFilter = $"{FilterColumn}={txtFilterValue.Text.Trim()}";
            }
            else
            {
                _AllUsers.DefaultView.RowFilter = string.Format("[{0}] like '%{1}%'",FilterColumn,txtFilterValue.Text.Trim());

            }

            lblRecordsCount.Text=dgvUsers.Rows.Count.ToString();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserInfo frm = new frmUserInfo(Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
            if (frm.WasPersonUpdated)
            {
                _RefreshForm();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAddUpdatUser frm = new frmAddUpdatUser();
                frm.ShowDialog();
            if(frm.WasSaved)
            {
                _RefreshForm();
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdatUser frm= new frmAddUpdatUser(Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
            if (frm.WasSaved)
            {
                _RefreshForm();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value);
            if (MessageBox.Show($"هل متاكد من حذف المستخدم ذو المعرف:{UserID}", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if(clsUser.DeleteUserByID(UserID))
                {
                    _RefreshForm();

                    MessageBox.Show($"المستخدم ذو المعرف={UserID} حذف بنجاح", "النتيجة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"فشل في حذف المستخدم ذو المعرف={UserID},يوجد بيانات مربوطة به", "النتيجة", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }


        }

        private void ChangePasswordtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword(Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
            if (frm.WasSaved)
            {
                _RefreshForm();
            }

        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("هذه الميزة ستضاف في النسخة القادمة من البرنامج");
        }
    }
}
