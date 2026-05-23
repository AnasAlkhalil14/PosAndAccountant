namespace PosAndAccountantProject.Printing
{
    partial class ctrlSaleInvoice
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblStoreName = new System.Windows.Forms.Label();
            this.lblStoreSubtitle = new System.Windows.Forms.Label();
            this.lblInvoiceNumber = new System.Windows.Forms.Label();
            this.lblCustomerType = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.dgvReceiptItems = new System.Windows.Forms.DataGridView();
            this.colIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalLabel = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.pnlHeaderBorder = new System.Windows.Forms.Panel();
            this.lblNetLabel = new System.Windows.Forms.Label();
            this.lblNetValue = new System.Windows.Forms.Label();
            this.lblTotalQtyLabel = new System.Windows.Forms.Label();
            this.lblTotalQtyValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceiptItems)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStoreName
            // 
            this.lblStoreName.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoreName.Location = new System.Drawing.Point(4, 15);
            this.lblStoreName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStoreName.Name = "lblStoreName";
            this.lblStoreName.Size = new System.Drawing.Size(516, 46);
            this.lblStoreName.TabIndex = 0;
            this.lblStoreName.Text = "ميني ماركت الماهر";
            this.lblStoreName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStoreSubtitle
            // 
            this.lblStoreSubtitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoreSubtitle.Location = new System.Drawing.Point(4, 62);
            this.lblStoreSubtitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStoreSubtitle.Name = "lblStoreSubtitle";
            this.lblStoreSubtitle.Size = new System.Drawing.Size(516, 31);
            this.lblStoreSubtitle.TabIndex = 1;
            this.lblStoreSubtitle.Text = "لبيع المواد الغذائية";
            this.lblStoreSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInvoiceNumber
            // 
            this.lblInvoiceNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInvoiceNumber.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceNumber.Location = new System.Drawing.Point(266, 115);
            this.lblInvoiceNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInvoiceNumber.Name = "lblInvoiceNumber";
            this.lblInvoiceNumber.Size = new System.Drawing.Size(254, 37);
            this.lblInvoiceNumber.TabIndex = 2;
            this.lblInvoiceNumber.Text = "فاتورة رقم : 0000";
            this.lblInvoiceNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCustomerType
            // 
            this.lblCustomerType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCustomerType.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerType.Location = new System.Drawing.Point(4, 115);
            this.lblCustomerType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerType.Name = "lblCustomerType";
            this.lblCustomerType.Size = new System.Drawing.Size(262, 37);
            this.lblCustomerType.TabIndex = 3;
            this.lblCustomerType.Text = "المطلوب من : زبون نقدي";
            this.lblCustomerType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDate
            // 
            this.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDate.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(266, 152);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(254, 37);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "2026/05/23";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTime.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(4, 152);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(262, 37);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "الوقت : 12:00 PM";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvReceiptItems
            // 
            this.dgvReceiptItems.AllowUserToAddRows = false;
            this.dgvReceiptItems.AllowUserToDeleteRows = false;
            this.dgvReceiptItems.AllowUserToResizeColumns = false;
            this.dgvReceiptItems.AllowUserToResizeRows = false;
            this.dgvReceiptItems.BackgroundColor = System.Drawing.Color.White;
            this.dgvReceiptItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReceiptItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReceiptItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvReceiptItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReceiptItems.ColumnHeadersHeight = 30;
            this.dgvReceiptItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvReceiptItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIndex,
            this.colDescription,
            this.colQty,
            this.colPrice,
            this.colTotal});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReceiptItems.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReceiptItems.EnableHeadersVisualStyles = false;
            this.dgvReceiptItems.GridColor = System.Drawing.Color.Black;
            this.dgvReceiptItems.Location = new System.Drawing.Point(4, 215);
            this.dgvReceiptItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvReceiptItems.MultiSelect = false;
            this.dgvReceiptItems.Name = "dgvReceiptItems";
            this.dgvReceiptItems.ReadOnly = true;
            this.dgvReceiptItems.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvReceiptItems.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReceiptItems.RowTemplate.Height = 28;
            this.dgvReceiptItems.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvReceiptItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReceiptItems.Size = new System.Drawing.Size(516, 308);
            this.dgvReceiptItems.TabIndex = 6;
            // 
            // colIndex
            // 
            this.colIndex.FillWeight = 30F;
            this.colIndex.HeaderText = "م";
            this.colIndex.Name = "colIndex";
            this.colIndex.ReadOnly = true;
            this.colIndex.Width = 30;
            // 
            // colDescription
            // 
            this.colDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDescription.HeaderText = "البيان";
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            // 
            // colQty
            // 
            this.colQty.HeaderText = "الكمية";
            this.colQty.Name = "colQty";
            this.colQty.ReadOnly = true;
            this.colQty.Width = 50;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "السعر";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            this.colPrice.Width = 70;
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "الإجمالي";
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            this.colTotal.Width = 80;
            // 
            // lblTotalLabel
            // 
            this.lblTotalLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalLabel.Location = new System.Drawing.Point(266, 546);
            this.lblTotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalLabel.Name = "lblTotalLabel";
            this.lblTotalLabel.Size = new System.Drawing.Size(255, 38);
            this.lblTotalLabel.TabIndex = 7;
            this.lblTotalLabel.Text = "المجموع:";
            this.lblTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalValue.Location = new System.Drawing.Point(4, 546);
            this.lblTotalValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(252, 38);
            this.lblTotalValue.TabIndex = 8;
            this.lblTotalValue.Text = "0.00";
            this.lblTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlHeaderBorder
            // 
            this.pnlHeaderBorder.BackColor = System.Drawing.Color.Black;
            this.pnlHeaderBorder.Location = new System.Drawing.Point(4, 206);
            this.pnlHeaderBorder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlHeaderBorder.Name = "pnlHeaderBorder";
            this.pnlHeaderBorder.Size = new System.Drawing.Size(516, 3);
            this.pnlHeaderBorder.TabIndex = 9;
            // 
            // lblNetLabel
            // 
            this.lblNetLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetLabel.Location = new System.Drawing.Point(266, 592);
            this.lblNetLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNetLabel.Name = "lblNetLabel";
            this.lblNetLabel.Size = new System.Drawing.Size(255, 38);
            this.lblNetLabel.TabIndex = 10;
            this.lblNetLabel.Text = "الصافي:";
            this.lblNetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNetValue
            // 
            this.lblNetValue.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetValue.Location = new System.Drawing.Point(4, 592);
            this.lblNetValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNetValue.Name = "lblNetValue";
            this.lblNetValue.Size = new System.Drawing.Size(252, 38);
            this.lblNetValue.TabIndex = 11;
            this.lblNetValue.Text = "0.00";
            this.lblNetValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalQtyLabel
            // 
            this.lblTotalQtyLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalQtyLabel.Location = new System.Drawing.Point(266, 638);
            this.lblTotalQtyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalQtyLabel.Name = "lblTotalQtyLabel";
            this.lblTotalQtyLabel.Size = new System.Drawing.Size(255, 38);
            this.lblTotalQtyLabel.TabIndex = 12;
            this.lblTotalQtyLabel.Text = "إجمالي القطع:";
            this.lblTotalQtyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalQtyValue
            // 
            this.lblTotalQtyValue.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalQtyValue.Location = new System.Drawing.Point(4, 638);
            this.lblTotalQtyValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalQtyValue.Name = "lblTotalQtyValue";
            this.lblTotalQtyValue.Size = new System.Drawing.Size(252, 38);
            this.lblTotalQtyValue.TabIndex = 13;
            this.lblTotalQtyValue.Text = "0";
            this.lblTotalQtyValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ctrlSaleInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblTotalQtyValue);
            this.Controls.Add(this.lblTotalQtyLabel);
            this.Controls.Add(this.lblNetValue);
            this.Controls.Add(this.lblNetLabel);
            this.Controls.Add(this.pnlHeaderBorder);
            this.Controls.Add(this.lblTotalValue);
            this.Controls.Add(this.lblTotalLabel);
            this.Controls.Add(this.dgvReceiptItems);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblCustomerType);
            this.Controls.Add(this.lblInvoiceNumber);
            this.Controls.Add(this.lblStoreSubtitle);
            this.Controls.Add(this.lblStoreName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ctrlSaleInvoice";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(525, 708);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceiptItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblStoreName;
        private System.Windows.Forms.Label lblStoreSubtitle;
        private System.Windows.Forms.Label lblInvoiceNumber;
        private System.Windows.Forms.Label lblCustomerType;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.DataGridView dgvReceiptItems;
        private System.Windows.Forms.Label lblTotalLabel;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Panel pnlHeaderBorder;
        private System.Windows.Forms.Label lblNetLabel;
        private System.Windows.Forms.Label lblNetValue;
        private System.Windows.Forms.Label lblTotalQtyLabel;
        private System.Windows.Forms.Label lblTotalQtyValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
    }
}