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

namespace PosAndAccountantProject.Partners.Controls
{
    public partial class ctrlEditPartnersProfitPercentage : UserControl
    {
        public ctrlEditPartnersProfitPercentage()
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
        public void _LoadToControl()
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
        private void ctrlEditPartnersProfitPercentage_Load(object sender, EventArgs e)
        {
          
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
            lblTotal.BackColor = total == 100 ? Color.LightGreen : Color.Red;
            lblTotal.ForeColor = Color.White;
           

            return total;
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
                e.Handled = false;
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
        private void dgvPartners_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            CalculateTotalPercentage();
        }
        public bool IsPercentage100 ()
        {
            return lblTotal.Text == "100";
        }
        public decimal GetTotalPercentage()
        {
            return Convert.ToDecimal(lblTotal.Text);
        }
        public void SetCurrentPartner(string fullName, decimal percentage, int partnerId = 0)
        {
            var dt = dgvPartners.DataSource as DataTable;
            if (dt == null) return;   // the grid isn't loaded yet

            // remove the previous version of this row, so calling it again never duplicates it
            for (int i = dt.Rows.Count - 1; i >= 0; i--)
                if (Convert.ToInt32(dt.Rows[i]["PartnerID"]) == partnerId)
                    dt.Rows.RemoveAt(i);

            // add the row at the top (position 0)
            DataRow row = dt.NewRow();
            row["PartnerID"] = partnerId;            // 0 = new partner
            row["FullName"] = fullName;
            row["ProfitPercentage"] = percentage;
            dt.Rows.InsertAt(row, 0);

            // lock + highlight it: its percentage is edited in the form, not in the grid
            foreach (DataGridViewRow r in dgvPartners.Rows)
            {
                if (Convert.ToInt32(r.Cells["PartnerID"].Value) == partnerId)
                {
                    r.ReadOnly = true;
                    r.DefaultCellStyle.BackColor = Color.FromArgb(255, 244, 200);
                    r.DefaultCellStyle.SelectionBackColor = Color.Orange;
                    break;
                }
            }

            CalculateTotalPercentage();   // adding a row doesn't fire CellValueChanged, so refresh the total here
        }
        public void EditPercentage(int PartnerID, decimal NewPercentage)
        {
            var dt = dgvPartners.DataSource as DataTable;
            for (int i = dt.Rows.Count - 1; i >= 0; i--)
                if (Convert.ToInt32(dt.Rows[i]["PartnerID"]) == PartnerID)
                { dt.Rows[i]["ProfitPercentage"] = NewPercentage;
                    CalculateTotalPercentage();
                    return;
                };

        }
        public DataTable BuildPartnersTable()
        {
            dgvPartners.EndEdit();   // commit the cell that is still being edited

            DataTable dt = new DataTable();
            dt.Columns.Add("PartnerID", typeof(int));              // same order and types as dbo.PartnerPercentageType
            dt.Columns.Add("ProfitPercentage", typeof(decimal));

            foreach (DataGridViewRow row in dgvPartners.Rows)
            {
                int id;
                decimal percentage;

                if (int.TryParse(Convert.ToString(row.Cells["PartnerID"].Value), out id) && id > 0 &&
                    decimal.TryParse(Convert.ToString(row.Cells["ProfitPercentage"].Value), out percentage))
                {
                    dt.Rows.Add(id, Math.Round(percentage, 2));
                }
            }

            return dt;
        }
    }
}

