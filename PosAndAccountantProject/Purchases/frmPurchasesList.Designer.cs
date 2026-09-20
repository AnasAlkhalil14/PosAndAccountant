namespace PosAndAccountantProject.Purchases
{
    partial class frmPurchasesList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilterValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbFilterBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvPurchaseDetails = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnAddNewSale = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(888, 322);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = ":البحث عبر";
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.BorderRadius = 8;
            this.txtFilterValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterValue.DefaultText = "";
            this.txtFilterValue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.txtFilterValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFilterValue.ForeColor = System.Drawing.Color.Black;
            this.txtFilterValue.Location = new System.Drawing.Point(544, 315);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.PlaceholderText = "....اكتب للبحث  ";
            this.txtFilterValue.SelectedText = "";
            this.txtFilterValue.Size = new System.Drawing.Size(188, 29);
            this.txtFilterValue.TabIndex = 26;
            this.txtFilterValue.Visible = false;
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.BackColor = System.Drawing.Color.Transparent;
            this.cbFilterBy.BorderRadius = 8;
            this.cbFilterBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.cbFilterBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.cbFilterBy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFilterBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFilterBy.ItemHeight = 30;
            this.cbFilterBy.Items.AddRange(new object[] {
            "لا شيء",
            "الاسم",
            "الباركود",
            "التصنيف"});
            this.cbFilterBy.Location = new System.Drawing.Point(745, 315);
            this.cbFilterBy.Margin = new System.Windows.Forms.Padding(2);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(121, 36);
            this.cbFilterBy.StartIndex = 0;
            this.cbFilterBy.TabIndex = 25;
            // 
            // dgvPurchaseDetails
            // 
            this.dgvPurchaseDetails.AllowUserToAddRows = false;
            this.dgvPurchaseDetails.AllowUserToDeleteRows = false;
            this.dgvPurchaseDetails.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvPurchaseDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPurchaseDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvPurchaseDetails.ColumnHeadersHeight = 35;
            this.dgvPurchaseDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPurchaseDetails.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvPurchaseDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvPurchaseDetails.Location = new System.Drawing.Point(25, 357);
            this.dgvPurchaseDetails.Name = "dgvPurchaseDetails";
            this.dgvPurchaseDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPurchaseDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvPurchaseDetails.RowHeadersVisible = false;
            this.dgvPurchaseDetails.RowHeadersWidth = 51;
            this.dgvPurchaseDetails.RowTemplate.Height = 30;
            this.dgvPurchaseDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPurchaseDetails.Size = new System.Drawing.Size(916, 410);
            this.dgvPurchaseDetails.TabIndex = 23;
            this.dgvPurchaseDetails.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Light;
            this.dgvPurchaseDetails.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvPurchaseDetails.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPurchaseDetails.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPurchaseDetails.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPurchaseDetails.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPurchaseDetails.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvPurchaseDetails.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvPurchaseDetails.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvPurchaseDetails.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPurchaseDetails.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPurchaseDetails.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvPurchaseDetails.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPurchaseDetails.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvPurchaseDetails.ThemeStyle.ReadOnly = false;
            this.dgvPurchaseDetails.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPurchaseDetails.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPurchaseDetails.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPurchaseDetails.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvPurchaseDetails.ThemeStyle.RowsStyle.Height = 30;
            this.dgvPurchaseDetails.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvPurchaseDetails.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // btnAddNewSale
            // 
            this.btnAddNewSale.BorderRadius = 15;
            this.btnAddNewSale.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.btnAddNewSale.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.btnAddNewSale.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAddNewSale.ForeColor = System.Drawing.Color.White;
            this.btnAddNewSale.Location = new System.Drawing.Point(12, 293);
            this.btnAddNewSale.Name = "btnAddNewSale";
            this.btnAddNewSale.Size = new System.Drawing.Size(181, 49);
            this.btnAddNewSale.TabIndex = 22;
            this.btnAddNewSale.Text = "+ إضافة شراء جديد";
            this.btnAddNewSale.Click += new System.EventHandler(this.btnAddNewSale_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PosAndAccountantProject.Properties.Resources.PurchaseList;
            this.pictureBox1.Location = new System.Drawing.Point(317, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 232);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // frmPurchasesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(953, 811);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.dgvPurchaseDetails);
            this.Controls.Add(this.btnAddNewSale);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmPurchasesList";
            this.Text = "frmPurchasesList";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtFilterValue;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterBy;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPurchaseDetails;
        private Guna.UI2.WinForms.Guna2Button btnAddNewSale;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}