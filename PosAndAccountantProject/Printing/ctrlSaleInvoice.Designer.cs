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
            this.components = new System.ComponentModel.Container();
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
            this.lblTotalLabel = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.pnlHeaderBorder = new System.Windows.Forms.Panel();
            this.lblNetLabel = new System.Windows.Forms.Label();
            this.lblNetValue = new System.Windows.Forms.Label();
            this.lblTotalQtyLabel = new System.Windows.Forms.Label();
            this.lblTotalQtyValue = new System.Windows.Forms.Label();
            this.separator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lblDiscount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDebtValue = new System.Windows.Forms.Label();
            this.lblDebt = new System.Windows.Forms.Label();
            this.lblTotalAmountWithDebtValue = new System.Windows.Forms.Label();
            this.lblTotalAmountWithDebt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.separator3 = new Guna.UI2.WinForms.Guna2Separator();
            this.lblFooter = new System.Windows.Forms.Label();
            this.colIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvReceiptItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReceiptItems.ColumnHeadersHeight = 30;
            this.dgvReceiptItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvReceiptItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIndex,
            this.colDescription,
            this.colPrice,
            this.colQty,
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
            // lblTotalLabel
            // 
            this.lblTotalLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalLabel.Location = new System.Drawing.Point(446, 551);
            this.lblTotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalLabel.Name = "lblTotalLabel";
            this.lblTotalLabel.Size = new System.Drawing.Size(78, 38);
            this.lblTotalLabel.TabIndex = 7;
            this.lblTotalLabel.Text = "المجموع:";
            this.lblTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalValue.Location = new System.Drawing.Point(297, 551);
            this.lblTotalValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(127, 38);
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
            this.lblNetLabel.Location = new System.Drawing.Point(446, 629);
            this.lblNetLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNetLabel.Name = "lblNetLabel";
            this.lblNetLabel.Size = new System.Drawing.Size(78, 38);
            this.lblNetLabel.TabIndex = 10;
            this.lblNetLabel.Text = "الصافي:";
            this.lblNetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNetValue
            // 
            this.lblNetValue.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetValue.Location = new System.Drawing.Point(297, 629);
            this.lblNetValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNetValue.Name = "lblNetValue";
            this.lblNetValue.Size = new System.Drawing.Size(127, 38);
            this.lblNetValue.TabIndex = 11;
            this.lblNetValue.Text = "0.00";
            this.lblNetValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalQtyLabel
            // 
            this.lblTotalQtyLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalQtyLabel.Location = new System.Drawing.Point(170, 553);
            this.lblTotalQtyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalQtyLabel.Name = "lblTotalQtyLabel";
            this.lblTotalQtyLabel.Size = new System.Drawing.Size(102, 38);
            this.lblTotalQtyLabel.TabIndex = 12;
            this.lblTotalQtyLabel.Text = "إجمالي القطع:";
            this.lblTotalQtyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalQtyValue
            // 
            this.lblTotalQtyValue.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalQtyValue.Location = new System.Drawing.Point(4, 551);
            this.lblTotalQtyValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalQtyValue.Name = "lblTotalQtyValue";
            this.lblTotalQtyValue.Size = new System.Drawing.Size(109, 38);
            this.lblTotalQtyValue.TabIndex = 13;
            this.lblTotalQtyValue.Text = "0";
            this.lblTotalQtyValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // separator1
            // 
            this.separator1.Location = new System.Drawing.Point(279, 544);
            this.separator1.Name = "separator1";
            this.separator1.Size = new System.Drawing.Size(11, 123);
            this.separator1.TabIndex = 14;
            // 
            // separator2
            // 
            this.separator2.Location = new System.Drawing.Point(0, 538);
            this.separator2.Name = "separator2";
            this.separator2.Size = new System.Drawing.Size(526, 10);
            this.separator2.TabIndex = 15;
            // 
            // lblDiscount
            // 
            this.lblDiscount.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(297, 591);
            this.lblDiscount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(127, 38);
            this.lblDiscount.TabIndex = 17;
            this.lblDiscount.Text = "0.00";
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(446, 591);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 38);
            this.label2.TabIndex = 16;
            this.label2.Text = "الخصم:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDebtValue
            // 
            this.lblDebtValue.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebtValue.Location = new System.Drawing.Point(4, 591);
            this.lblDebtValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDebtValue.Name = "lblDebtValue";
            this.lblDebtValue.Size = new System.Drawing.Size(127, 38);
            this.lblDebtValue.TabIndex = 19;
            this.lblDebtValue.Text = "0.00";
            this.lblDebtValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDebt
            // 
            this.lblDebt.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebt.Location = new System.Drawing.Point(144, 591);
            this.lblDebt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDebt.Name = "lblDebt";
            this.lblDebt.Size = new System.Drawing.Size(128, 38);
            this.lblDebt.TabIndex = 18;
            this.lblDebt.Text = "قيمة الدين السابق:";
            this.lblDebt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalAmountWithDebtValue
            // 
            this.lblTotalAmountWithDebtValue.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmountWithDebtValue.Location = new System.Drawing.Point(4, 629);
            this.lblTotalAmountWithDebtValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalAmountWithDebtValue.Name = "lblTotalAmountWithDebtValue";
            this.lblTotalAmountWithDebtValue.Size = new System.Drawing.Size(127, 38);
            this.lblTotalAmountWithDebtValue.TabIndex = 21;
            this.lblTotalAmountWithDebtValue.Text = "0.00";
            this.lblTotalAmountWithDebtValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalAmountWithDebt
            // 
            this.lblTotalAmountWithDebt.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmountWithDebt.Location = new System.Drawing.Point(144, 629);
            this.lblTotalAmountWithDebt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalAmountWithDebt.Name = "lblTotalAmountWithDebt";
            this.lblTotalAmountWithDebt.Size = new System.Drawing.Size(128, 38);
            this.lblTotalAmountWithDebt.TabIndex = 20;
            this.lblTotalAmountWithDebt.Text = "الصافي مع الدين:";
            this.lblTotalAmountWithDebt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 667);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 37);
            this.label1.TabIndex = 23;
            this.label1.Text = "0.00";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(296, 667);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 37);
            this.label5.TabIndex = 22;
            this.label5.Text = "الدفعة الحالية:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // separator3
            // 
            this.separator3.Location = new System.Drawing.Point(4, 657);
            this.separator3.Name = "separator3";
            this.separator3.Size = new System.Drawing.Size(526, 10);
            this.separator3.TabIndex = 24;
            // 
            // lblFooter
            // 
            this.lblFooter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooter.Location = new System.Drawing.Point(4, 713);
            this.lblFooter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(520, 40);
            this.lblFooter.TabIndex = 25;
            this.lblFooter.Text = "الماهر للمحااسبة";
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // colPrice
            // 
            this.colPrice.HeaderText = "السعر";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            this.colPrice.Width = 50;
            // 
            // colQty
            // 
            this.colQty.HeaderText = "الكمية";
            this.colQty.Name = "colQty";
            this.colQty.ReadOnly = true;
            this.colQty.Width = 70;
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "الإجمالي";
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            this.colTotal.Width = 80;
            // 
            // ctrlSaleInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblFooter);
            this.Controls.Add(this.separator3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTotalAmountWithDebtValue);
            this.Controls.Add(this.lblTotalAmountWithDebt);
            this.Controls.Add(this.lblDebtValue);
            this.Controls.Add(this.lblDebt);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.separator2);
            this.Controls.Add(this.separator1);
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
            this.Size = new System.Drawing.Size(525, 753);
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
        private Guna.UI2.WinForms.Guna2VSeparator separator1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Separator separator2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDebtValue;
        private System.Windows.Forms.Label lblDebt;
        private System.Windows.Forms.Label lblTotalAmountWithDebtValue;
        private System.Windows.Forms.Label lblTotalAmountWithDebt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Separator separator3;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
    }
}