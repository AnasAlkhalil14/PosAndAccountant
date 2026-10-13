namespace PosAndAccountantProject.Partners
{
    partial class frmListPartners
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPartners = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmsPartners = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.phoneCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.عمليةسحبToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.عمليةايداعToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAddPartner = new Guna.UI2.WinForms.Guna2Button();
            this.pbPersonImage = new System.Windows.Forms.PictureBox();
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.lnkManagePartners = new System.Windows.Forms.LinkLabel();
            this.lnkAddNewTransaction = new System.Windows.Forms.LinkLabel();
            this.lblRelatedTopics = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartners)).BeginInit();
            this.cmsPartners.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPartners
            // 
            this.dgvPartners.AllowUserToAddRows = false;
            this.dgvPartners.AllowUserToDeleteRows = false;
            this.dgvPartners.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvPartners.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPartners.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPartners.ColumnHeadersHeight = 40;
            this.dgvPartners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPartners.ContextMenuStrip = this.cmsPartners;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPartners.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPartners.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPartners.Location = new System.Drawing.Point(12, 259);
            this.dgvPartners.MultiSelect = false;
            this.dgvPartners.Name = "dgvPartners";
            this.dgvPartners.ReadOnly = true;
            this.dgvPartners.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvPartners.RowHeadersVisible = false;
            this.dgvPartners.RowHeadersWidth = 51;
            this.dgvPartners.RowTemplate.Height = 35;
            this.dgvPartners.Size = new System.Drawing.Size(916, 320);
            this.dgvPartners.TabIndex = 128;
            this.dgvPartners.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPartners.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPartners.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPartners.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPartners.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPartners.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvPartners.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPartners.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.dgvPartners.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPartners.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.dgvPartners.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPartners.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPartners.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvPartners.ThemeStyle.ReadOnly = true;
            this.dgvPartners.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPartners.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPartners.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvPartners.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPartners.ThemeStyle.RowsStyle.Height = 35;
            this.dgvPartners.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPartners.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // cmsPartners
            // 
            this.cmsPartners.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmsPartners.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsPartners.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.toolStripSeparator2,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator1,
            this.phoneCallToolStripMenuItem,
            this.toolStripMenuItem1,
            this.عمليةسحبToolStripMenuItem,
            this.عمليةايداعToolStripMenuItem});
            this.cmsPartners.Name = "cmsUsers";
            this.cmsPartners.Size = new System.Drawing.Size(168, 166);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.showDetailsToolStripMenuItem.Text = "عرض التفاصيل";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(164, 6);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.editToolStripMenuItem.Text = "تعديل";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.deleteToolStripMenuItem.Text = "حذف";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(164, 6);
            // 
            // phoneCallToolStripMenuItem
            // 
            this.phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            this.phoneCallToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.phoneCallToolStripMenuItem.Text = "اتصال هاتف";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(164, 6);
            // 
            // عمليةسحبToolStripMenuItem
            // 
            this.عمليةسحبToolStripMenuItem.Name = "عمليةسحبToolStripMenuItem";
            this.عمليةسحبToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.عمليةسحبToolStripMenuItem.Text = "عملية سحب";
            this.عمليةسحبToolStripMenuItem.Click += new System.EventHandler(this.عمليةسحبToolStripMenuItem_Click);
            // 
            // عمليةايداعToolStripMenuItem
            // 
            this.عمليةايداعToolStripMenuItem.Name = "عمليةايداعToolStripMenuItem";
            this.عمليةايداعToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.عمليةايداعToolStripMenuItem.Text = "عملية ايداع";
            this.عمليةايداعToolStripMenuItem.Click += new System.EventHandler(this.عمليةايداعToolStripMenuItem_Click);
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblRecordsCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.lblRecordsCount.Location = new System.Drawing.Point(185, 628);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(26, 21);
            this.lblRecordsCount.TabIndex = 133;
            this.lblRecordsCount.Text = "??";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(29, 628);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 21);
            this.label2.TabIndex = 132;
            this.label2.Text = "عدد السجلات:";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(667, 38);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(249, 50);
            this.lblTitle.TabIndex = 135;
            this.lblTitle.Text = "إدارة الشركاء";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddPartner
            // 
            this.btnAddPartner.Animated = true;
            this.btnAddPartner.BorderRadius = 10;
            this.btnAddPartner.BorderThickness = 1;
            this.btnAddPartner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPartner.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddPartner.FillColor = System.Drawing.Color.Transparent;
            this.btnAddPartner.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAddPartner.ForeColor = System.Drawing.Color.YellowGreen;
            this.btnAddPartner.Image = global::PosAndAccountantProject.Properties.Resources.addCustomer;
            this.btnAddPartner.ImageSize = new System.Drawing.Size(32, 32);
            this.btnAddPartner.Location = new System.Drawing.Point(810, 198);
            this.btnAddPartner.Name = "btnAddPartner";
            this.btnAddPartner.Size = new System.Drawing.Size(84, 43);
            this.btnAddPartner.TabIndex = 137;
            this.btnAddPartner.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // pbPersonImage
            // 
            this.pbPersonImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPersonImage.Image = global::PosAndAccountantProject.Properties.Resources.PartnersList;
            this.pbPersonImage.Location = new System.Drawing.Point(305, 6);
            this.pbPersonImage.Name = "pbPersonImage";
            this.pbPersonImage.Size = new System.Drawing.Size(310, 131);
            this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersonImage.TabIndex = 134;
            this.pbPersonImage.TabStop = false;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.pnlHeader.Controls.Add(this.pbPersonImage);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(953, 137);
            this.pnlHeader.TabIndex = 139;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.Location = new System.Drawing.Point(12, 594);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(892, 19);
            this.guna2Separator1.TabIndex = 143;
            // 
            // lnkManagePartners
            // 
            this.lnkManagePartners.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkManagePartners.AutoSize = true;
            this.lnkManagePartners.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lnkManagePartners.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkManagePartners.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.lnkManagePartners.Location = new System.Drawing.Point(201, 221);
            this.lnkManagePartners.Name = "lnkManagePartners";
            this.lnkManagePartners.Size = new System.Drawing.Size(129, 20);
            this.lnkManagePartners.TabIndex = 142;
            this.lnkManagePartners.TabStop = true;
            this.lnkManagePartners.Text = "إدارة حركات الشركاء";
            this.lnkManagePartners.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkManagePartners_LinkClicked);
            // 
            // lnkAddNewTransaction
            // 
            this.lnkAddNewTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkAddNewTransaction.AutoSize = true;
            this.lnkAddNewTransaction.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lnkAddNewTransaction.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkAddNewTransaction.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.lnkAddNewTransaction.Location = new System.Drawing.Point(368, 221);
            this.lnkAddNewTransaction.Name = "lnkAddNewTransaction";
            this.lnkAddNewTransaction.Size = new System.Drawing.Size(124, 20);
            this.lnkAddNewTransaction.TabIndex = 141;
            this.lnkAddNewTransaction.TabStop = true;
            this.lnkAddNewTransaction.Text = "إضافة حركة جديدة";
            this.lnkAddNewTransaction.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAddNewTransaction_LinkClicked);
            // 
            // lblRelatedTopics
            // 
            this.lblRelatedTopics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRelatedTopics.AutoSize = true;
            this.lblRelatedTopics.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblRelatedTopics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRelatedTopics.Location = new System.Drawing.Point(29, 221);
            this.lblRelatedTopics.Name = "lblRelatedTopics";
            this.lblRelatedTopics.Size = new System.Drawing.Size(125, 20);
            this.lblRelatedTopics.TabIndex = 140;
            this.lblRelatedTopics.Text = "مواضيع ذات صلة:";
            // 
            // frmListPartners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(953, 676);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.lnkManagePartners);
            this.Controls.Add(this.lnkAddNewTransaction);
            this.Controls.Add(this.lblRelatedTopics);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.btnAddPartner);
            this.Controls.Add(this.dgvPartners);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.label2);
            this.Name = "frmListPartners";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmListPartners_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartners)).EndInit();
            this.cmsPartners.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnAddPartner;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPartners;
        private System.Windows.Forms.ContextMenuStrip cmsPartners;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem phoneCallToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbPersonImage;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem عمليةسحبToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem عمليةايداعToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.LinkLabel lnkManagePartners;
        private System.Windows.Forms.LinkLabel lnkAddNewTransaction;
        private System.Windows.Forms.Label lblRelatedTopics;
    }
}