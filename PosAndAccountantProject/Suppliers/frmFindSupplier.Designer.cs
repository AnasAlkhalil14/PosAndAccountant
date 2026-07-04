namespace PosAndAccountantProject.Suppliers
{
    partial class frmFindSupplier
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
            this.ctrlSupplierCardWithFilter1 = new PosAndAccountantProject.Suppliers.Controls.ctrlSupplierCardWithFilter();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnSelect = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // ctrlSupplierCardWithFilter1
            // 
            this.ctrlSupplierCardWithFilter1.Location = new System.Drawing.Point(3, 8);
            this.ctrlSupplierCardWithFilter1.Name = "ctrlSupplierCardWithFilter1";
            this.ctrlSupplierCardWithFilter1.Size = new System.Drawing.Size(650, 610);
            this.ctrlSupplierCardWithFilter1.TabIndex = 0;
            this.ctrlSupplierCardWithFilter1.SupplierSelected += new System.EventHandler<PosAndAccountantProject.Suppliers.Controls.ctrlSupplierCardWithFilter.SupplierSelectedEventArgs>(this.ctrlSupplierCardWithFilter1_SupplierSelected);
            this.ctrlSupplierCardWithFilter1.SupplierNotFound += new System.EventHandler(this.ctrlSupplierCardWithFilter1_SupplierNotFound);
            // 
            // btnClose
            // 
            this.btnClose.BorderColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderRadius = 10;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnClose.Location = new System.Drawing.Point(385, 637);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(106, 45);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "اغلاق";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BorderColor = System.Drawing.Color.Transparent;
            this.btnSelect.BorderRadius = 10;
            this.btnSelect.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSelect.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSelect.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSelect.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSelect.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnSelect.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnSelect.Location = new System.Drawing.Point(179, 637);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(111, 45);
            this.btnSelect.TabIndex = 18;
            this.btnSelect.Text = "اختيار";
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // frmFindSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(656, 724);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.ctrlSupplierCardWithFilter1);
            this.Name = "frmFindSupplier";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFindSupplier";
            this.Load += new System.EventHandler(this.frmFindSupplier_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ctrlSupplierCardWithFilter ctrlSupplierCardWithFilter1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnSelect;
    }
}