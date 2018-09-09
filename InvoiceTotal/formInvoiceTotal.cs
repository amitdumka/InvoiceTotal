using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceTotal
{
    public partial class formInvTotal : Form
    {

        int numberOfInvoices = 0;
        decimal totalOfInvoices = 0m;
        decimal invoiceAverage = 0.0m;
        decimal[] invoice = new decimal[5];
        int index = 0;

        public formInvTotal()
        {
            InitializeComponent();
        }

        
        private void btnExit_Click(object sender, EventArgs e)
        {
            string invoices = "";
            Array.Sort(invoice);
            foreach (var item in invoice)
            {
                if(item > 0)
                    invoices += item + "\n";
            }
            MessageBox.Show(invoices, "Order Totals");
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try {
                if(txbEnterSubtotal.Text == "")
                {
                    MessageBox.Show("Subtotal value is required.", "Required Value");
                    txbEnterSubtotal.Focus();
                }
                decimal subtotalEntry = Convert.ToDecimal(txbEnterSubtotal.Text);
                decimal discountPercent = 0m;
                if (subtotalEntry >= 500)
                {
                    discountPercent = 0.2m;
                }
                else if (subtotalEntry >= 250 && subtotalEntry < 500)
                {
                    discountPercent = .15m;
                }
                else if (subtotalEntry >= 100 && subtotalEntry < 250)
                {
                    discountPercent = .1m;
                }

                decimal discountAmount = subtotalEntry * discountPercent;
                decimal total = subtotalEntry - discountAmount;

                invoice[index++] = total;

                txbSubtotal.Text = subtotalEntry.ToString("C");
                txbDscntPct.Text = discountPercent.ToString("p1");
                txbDscntAmnt.Text = discountAmount.ToString("c");
                txbTotal.Text = total.ToString("c");

                ++numberOfInvoices;
                txbNumOfInv.Text = numberOfInvoices.ToString();
                totalOfInvoices += total;
                txbTotalOfInv.Text = totalOfInvoices.ToString("c");
                invoiceAverage = totalOfInvoices / numberOfInvoices;
                txbInvoiceAverage.Text = invoiceAverage.ToString("c2");

                txbEnterSubtotal.Text = "";

                txbEnterSubtotal.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("A format exception has occured. Please check the entry.", "Format Error");
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("You cannot add more than 5 invoices", "Range Error");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnClearTotals_Click(object sender, EventArgs e)
        {
            numberOfInvoices = 0;
            totalOfInvoices = 0;
            invoiceAverage = 0m;

            txbNumOfInv.Text = "";
            txbTotalOfInv.Text = "";
            txbInvoiceAverage.Text = "";


            txbSubtotal.Text = "";
            txbDscntPct.Text = "";
            txbDscntAmnt.Text = "";
            txbTotal.Text = "";
            txbEnterSubtotal.Text = "";

            txbEnterSubtotal.Focus();
        }

        private void formInvTotal_Load(object sender, EventArgs e)
        {

        }

    }
}
