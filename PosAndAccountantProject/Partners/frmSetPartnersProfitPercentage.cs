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

namespace PosAndAccountantProject.Partners
{
    public partial class frmSetPartnersProfitPercentage : Form
    {
        public frmSetPartnersProfitPercentage()
        {
            InitializeComponent();
        }
        private void StyleProfitColumn()
        {
            dgvPartners.EnableHeadersVisualStyles = false;

            dgvPartners.AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle();
            dgvPartners.RowsDefaultCellStyle = new DataGridViewCellStyle();

            // normal cells
            dgvPartners.DefaultCellStyle.BackColor = Color.White;
            dgvPartners.DefaultCellStyle.ForeColor = Color.Black;
            dgvPartners.DefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 200, 200); // gray selection
            dgvPartners.DefaultCellStyle.SelectionForeColor = Color.Black;

            foreach (DataGridViewColumn c in dgvPartners.Columns)
                c.DefaultCellStyle = new DataGridViewCellStyle();

            // percentage column
            var col = dgvPartners.Columns["ProfitPercentage"];
            col.DefaultCellStyle.BackColor = Color.FromArgb(176, 196, 222);
            col.DefaultCellStyle.ForeColor = Color.Black;
            col.DefaultCellStyle.Font = new Font(dgvPartners.Font.FontFamily, 14F, FontStyle.Bold); // change 16F to taste
            col.DefaultCellStyle.SelectionBackColor = Color.FromArgb(110, 130, 160); // darker on selection
            col.DefaultCellStyle.SelectionForeColor = Color.White;
            col.DefaultCellStyle.Format = "0.##";
            col.HeaderCell.Style.BackColor = Color.FromArgb(70, 100, 150);
            col.HeaderCell.Style.ForeColor = Color.White;
        }
        private void SetupGridSelection()
        {
            dgvPartners.MultiSelect = false;                              // one cell/row at a time
            dgvPartners.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvPartners.EditMode = DataGridViewEditMode.EditOnEnter;      // click the cell and type
            dgvPartners.AllowUserToAddRows = false;
            dgvPartners.AllowUserToDeleteRows = false;
            dgvPartners.RowHeadersVisible = false; 
          

        }
       
        private void frmSetPartnersProfitPercentage_Load(object sender, EventArgs e)
        {
            dgvPartners.AutoGenerateColumns = false;
            dgvPartners.Columns.Clear();

            dgvPartners.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PartnerID",
                HeaderText = "معرف الشريك",
                DataPropertyName = "PartnerID",
                ReadOnly = true

            }); dgvPartners.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FullName",
                HeaderText = "الاسم الكامل",
                DataPropertyName = "FullName",
                ReadOnly = true

            });
            dgvPartners.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ProfitPercentage",
                HeaderText = "النسبة من الربح",
                DataPropertyName = "ProfitPercentage",

                ReadOnly = false

            });
            dgvPartners.DataSource = clsPartner.GetAllPartnersShortWithPercentage();
            StyleProfitColumn(); SetupGridSelection();
            CalculateTotalPercentage();
        }
        private void txtOnlyNumbes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
     !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled =false    ;
            }

        }
        private void dgvPartners_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
             TextBox txt = e.Control as TextBox;
                if (txt != null)
                {
                    txt.KeyPress -= txtOnlyNumbes_KeyPress;
                    txt.KeyPress += txtOnlyNumbes_KeyPress;

                }
        }

        private decimal CalculateTotalPercentage()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgvPartners.Rows)
            {
                object v = row.Cells["ProfitPercentage"].Value;
                decimal p;
                if (v != null && v != DBNull.Value && decimal.TryParse(v.ToString(), out p))
                    total += p;
            }

            lblTotal.Text = total.ToString("0.##");
            lblTotal.BackColor = total == 100 ? Color.SeaGreen : Color.Red;
            lblTotal.ForeColor = Color.White;
            btnSave.Enabled = total == 100;   // delete this line if you don't want it

            return total;
        }

        private void dgvPartners_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            CalculateTotalPercentage();
        }
    }
}
