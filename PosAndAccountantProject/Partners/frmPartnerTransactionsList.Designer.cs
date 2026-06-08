namespace PosAndAccountantProject.Partners
{
    partial class frmPartnerTransactionsList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTransType = new System.Windows.Forms.Label();
            this.cbxTransType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblPartnerName = new System.Windows.Forms.Label();
            this.cbxPartnerName = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvTransactions = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lnkAddNewTransaction = new System.Windows.Forms.LinkLabel();
            this.lnkManagePartners = new System.Windows.Forms.LinkLabel();
            this.lblRelatedTopics = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.pnlHeader.Controls.Add(this.guna2PictureBox1);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1151, 137);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(875, 49);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(252, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "سجل حركات الشركاء";
            // 
            // lblTransType
            // 
            this.lblTransType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTransType.AutoSize = true;
            this.lblTransType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTransType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTransType.Location = new System.Drawing.Point(718, 153);
            this.lblTransType.Name = "lblTransType";
            this.lblTransType.Size = new System.Drawing.Size(73, 19);
            this.lblTransType.TabIndex = 5;
            this.lblTransType.Text = "نوع الحركة:";
            // 
            // cbxTransType
            // 
            this.cbxTransType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxTransType.BackColor = System.Drawing.Color.Transparent;
            this.cbxTransType.BorderRadius = 8;
            this.cbxTransType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxTransType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTransType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.cbxTransType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.cbxTransType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxTransType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxTransType.ItemHeight = 30;
            this.cbxTransType.Items.AddRange(new object[] {
            "الكل",
            "إيداع",
            "سحب"});
            this.cbxTransType.Location = new System.Drawing.Point(608, 175);
            this.cbxTransType.Name = "cbxTransType";
            this.cbxTransType.Size = new System.Drawing.Size(185, 36);
            this.cbxTransType.StartIndex = 0;
            this.cbxTransType.TabIndex = 4;
            this.cbxTransType.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPartnerName
            // 
            this.lblPartnerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPartnerName.AutoSize = true;
            this.lblPartnerName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPartnerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPartnerName.Location = new System.Drawing.Point(998, 153);
            this.lblPartnerName.Name = "lblPartnerName";
            this.lblPartnerName.Size = new System.Drawing.Size(85, 19);
            this.lblPartnerName.TabIndex = 3;
            this.lblPartnerName.Text = "اسم الشريك:";
            // 
            // cbxPartnerName
            // 
            this.cbxPartnerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxPartnerName.BackColor = System.Drawing.Color.Transparent;
            this.cbxPartnerName.BorderRadius = 8;
            this.cbxPartnerName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxPartnerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPartnerName.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.cbxPartnerName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.cbxPartnerName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxPartnerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxPartnerName.ItemHeight = 30;
            this.cbxPartnerName.Location = new System.Drawing.Point(823, 175);
            this.cbxPartnerName.Name = "cbxPartnerName";
            this.cbxPartnerName.Size = new System.Drawing.Size(250, 36);
            this.cbxPartnerName.TabIndex = 2;
            this.cbxPartnerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.AllowUserToAddRows = false;
            this.dgvTransactions.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvTransactions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTransactions.ColumnHeadersHeight = 45;
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTransactions.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTransactions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTransactions.Location = new System.Drawing.Point(30, 234);
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.ReadOnly = true;
            this.dgvTransactions.RowHeadersVisible = false;
            this.dgvTransactions.RowTemplate.Height = 40;
            this.dgvTransactions.Size = new System.Drawing.Size(1090, 489);
            this.dgvTransactions.TabIndex = 2;
            this.dgvTransactions.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTransactions.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTransactions.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTransactions.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTransactions.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTransactions.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvTransactions.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTransactions.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.dgvTransactions.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTransactions.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.dgvTransactions.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTransactions.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTransactions.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvTransactions.ThemeStyle.ReadOnly = true;
            this.dgvTransactions.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTransactions.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTransactions.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvTransactions.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTransactions.ThemeStyle.RowsStyle.Height = 40;
            this.dgvTransactions.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTransactions.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // lnkAddNewTransaction
            // 
            this.lnkAddNewTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkAddNewTransaction.AutoSize = true;
            this.lnkAddNewTransaction.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lnkAddNewTransaction.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkAddNewTransaction.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.lnkAddNewTransaction.Location = new System.Drawing.Point(849, 751);
            this.lnkAddNewTransaction.Name = "lnkAddNewTransaction";
            this.lnkAddNewTransaction.Size = new System.Drawing.Size(124, 20);
            this.lnkAddNewTransaction.TabIndex = 4;
            this.lnkAddNewTransaction.TabStop = true;
            this.lnkAddNewTransaction.Text = "إضافة حركة جديدة";
            // 
            // lnkManagePartners
            // 
            this.lnkManagePartners.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkManagePartners.AutoSize = true;
            this.lnkManagePartners.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lnkManagePartners.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkManagePartners.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.lnkManagePartners.Location = new System.Drawing.Point(699, 751);
            this.lnkManagePartners.Name = "lnkManagePartners";
            this.lnkManagePartners.Size = new System.Drawing.Size(129, 20);
            this.lnkManagePartners.TabIndex = 5;
            this.lnkManagePartners.TabStop = true;
            this.lnkManagePartners.Text = "إدارة ملفات الشركاء";
            // 
            // lblRelatedTopics
            // 
            this.lblRelatedTopics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRelatedTopics.AutoSize = true;
            this.lblRelatedTopics.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblRelatedTopics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRelatedTopics.Location = new System.Drawing.Point(999, 751);
            this.lblRelatedTopics.Name = "lblRelatedTopics";
            this.lblRelatedTopics.Size = new System.Drawing.Size(125, 20);
            this.lblRelatedTopics.TabIndex = 3;
            this.lblRelatedTopics.Text = "مواضيع ذات صلة:";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.Location = new System.Drawing.Point(30, 729);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1090, 19);
            this.guna2Separator1.TabIndex = 6;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::PosAndAccountantProject.Properties.Resources.transaction;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(665, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(204, 112);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // frmPartnerTransactionsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1151, 793);
            this.Controls.Add(this.lblTransType);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.cbxTransType);
            this.Controls.Add(this.lnkManagePartners);
            this.Controls.Add(this.lblPartnerName);
            this.Controls.Add(this.lnkAddNewTransaction);
            this.Controls.Add(this.cbxPartnerName);
            this.Controls.Add(this.lblRelatedTopics);
            this.Controls.Add(this.dgvTransactions);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPartnerTransactionsList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سجل حركات الشركاء";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPartnerName;
        private Guna.UI2.WinForms.Guna2ComboBox cbxPartnerName;
        private System.Windows.Forms.Label lblTransType;
        private Guna.UI2.WinForms.Guna2ComboBox cbxTransType;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTransactions;
        private System.Windows.Forms.LinkLabel lnkAddNewTransaction;
        private System.Windows.Forms.Label lblRelatedTopics;
        private System.Windows.Forms.LinkLabel lnkManagePartners;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}