using System;
using System.Windows.Forms;

namespace PosAndAccountantProject.Printing
{
    public partial class ctrlSaleInvoice : UserControl
    {
        public ctrlSaleInvoice()
        {
            InitializeComponent();
        }

        public void PopulateAndResize(string invoiceId, string customerName, DataGridView sourceDgv, string totalAmount, string netAmount)
        {
            // 1. Populate metadata matching the layout pattern from your photo
            lblInvoiceNumber.Text = $" فاتورة رقم : {invoiceId}";
            lblCustomerType.Text = $" المطلوب من : {customerName}";
            lblDate.Text = DateTime.Now.ToString("yyyy/MM/dd");
            lblTime.Text = $"الوقت : {DateTime.Now.ToString("hh:mm tt")}";

            lblTotalValue.Text = totalAmount;
            lblNetValue.Text = netAmount;

            // 2. Clear old lines and transfer item rows safely
            dgvReceiptItems.Rows.Clear();
            int counter = 1;
            double totalItemsCount = 0;

            foreach (DataGridViewRow sourceRow in sourceDgv.Rows)
            {
                if (sourceRow.IsNewRow) continue;

                // Adjust these cell index values or column string names based on your main sales form structure
                string itemDescription = sourceRow.Cells[1].Value?.ToString() ?? ""; // Product Name
                string qty = sourceRow.Cells[3].Value?.ToString() ?? "0";            // Quantity
                string price = sourceRow.Cells[2].Value?.ToString() ?? "0.00";       // Price
                string total = sourceRow.Cells[4].Value?.ToString() ?? "0.00";       // Total Line Price

                dgvReceiptItems.Rows.Add(counter, itemDescription, qty, price, total);

                if (double.TryParse(qty, out double q))
                {
                    totalItemsCount += q;
                }
                counter++;
            }

            lblTotalQtyValue.Text = totalItemsCount.ToString();

            // 3. Dynamic layout recalculation to systematically remove vertical scrollbars
            int headerHeight = dgvReceiptItems.ColumnHeadersHeight;
            int rowHeight = dgvReceiptItems.RowTemplate.Height;
            int totalGridHeight = headerHeight + (dgvReceiptItems.Rows.Count * rowHeight);

            // Compute difference to slide totals down sequentially
            int heightDelta = totalGridHeight - dgvReceiptItems.Height;

            dgvReceiptItems.Height = totalGridHeight;

            // Shift totals labels downwards relative to the new grid scale
            lblTotalLabel.Top += heightDelta;
            lblTotalValue.Top += heightDelta;
            lblNetLabel.Top += heightDelta;
            lblNetValue.Top += heightDelta;
            lblTotalQtyLabel.Top += heightDelta;
            lblTotalQtyValue.Top += heightDelta;

            // Grow usercontrol container boundary
            this.Height += heightDelta;
            this.PerformLayout();
        }
    }
}