namespace InvoiceTotal
{
    partial class formInvTotal
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
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblDsctPct = new System.Windows.Forms.Label();
            this.lblDsctAmnt = new System.Windows.Forms.Label();
            this.txbSubtotal = new System.Windows.Forms.TextBox();
            this.txbDscntPct = new System.Windows.Forms.TextBox();
            this.txbDscntAmnt = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txbTotal = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClearTotals = new System.Windows.Forms.Button();
            this.txbEnterSubtotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNumOfInv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbTotalOfInv = new System.Windows.Forms.TextBox();
            this.txbInvoiceAverage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(18, 112);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(49, 13);
            this.lblSubtotal.TabIndex = 0;
            this.lblSubtotal.Text = "&Subtotal:";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDsctPct
            // 
            this.lblDsctPct.AutoSize = true;
            this.lblDsctPct.Location = new System.Drawing.Point(18, 148);
            this.lblDsctPct.Name = "lblDsctPct";
            this.lblDsctPct.Size = new System.Drawing.Size(92, 13);
            this.lblDsctPct.TabIndex = 1;
            this.lblDsctPct.Text = "Discount Percent:";
            this.lblDsctPct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDsctAmnt
            // 
            this.lblDsctAmnt.AutoSize = true;
            this.lblDsctAmnt.Location = new System.Drawing.Point(18, 184);
            this.lblDsctAmnt.Name = "lblDsctAmnt";
            this.lblDsctAmnt.Size = new System.Drawing.Size(91, 13);
            this.lblDsctAmnt.TabIndex = 2;
            this.lblDsctAmnt.Text = "Discount Amount:";
            this.lblDsctAmnt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txbSubtotal
            // 
            this.txbSubtotal.Location = new System.Drawing.Point(131, 106);
            this.txbSubtotal.Name = "txbSubtotal";
            this.txbSubtotal.ReadOnly = true;
            this.txbSubtotal.Size = new System.Drawing.Size(181, 20);
            this.txbSubtotal.TabIndex = 1;
            this.txbSubtotal.TabStop = false;
            // 
            // txbDscntPct
            // 
            this.txbDscntPct.Location = new System.Drawing.Point(131, 139);
            this.txbDscntPct.Name = "txbDscntPct";
            this.txbDscntPct.ReadOnly = true;
            this.txbDscntPct.Size = new System.Drawing.Size(181, 20);
            this.txbDscntPct.TabIndex = 1;
            this.txbDscntPct.TabStop = false;
            // 
            // txbDscntAmnt
            // 
            this.txbDscntAmnt.Location = new System.Drawing.Point(131, 176);
            this.txbDscntAmnt.Name = "txbDscntAmnt";
            this.txbDscntAmnt.ReadOnly = true;
            this.txbDscntAmnt.Size = new System.Drawing.Size(181, 20);
            this.txbDscntAmnt.TabIndex = 2;
            this.txbDscntAmnt.TabStop = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(18, 220);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total:";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txbTotal
            // 
            this.txbTotal.Location = new System.Drawing.Point(131, 213);
            this.txbTotal.Name = "txbTotal";
            this.txbTotal.ReadOnly = true;
            this.txbTotal.Size = new System.Drawing.Size(181, 20);
            this.txbTotal.TabIndex = 3;
            this.txbTotal.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(87, 268);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(263, 268);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Subtotal:";
            // 
            // btnClearTotals
            // 
            this.btnClearTotals.Location = new System.Drawing.Point(175, 268);
            this.btnClearTotals.Name = "btnClearTotals";
            this.btnClearTotals.Size = new System.Drawing.Size(75, 23);
            this.btnClearTotals.TabIndex = 5;
            this.btnClearTotals.Text = "Clear Totals";
            this.btnClearTotals.UseVisualStyleBackColor = true;
            this.btnClearTotals.Click += new System.EventHandler(this.btnClearTotals_Click);
            // 
            // txbEnterSubtotal
            // 
            this.txbEnterSubtotal.Location = new System.Drawing.Point(131, 69);
            this.txbEnterSubtotal.Name = "txbEnterSubtotal";
            this.txbEnterSubtotal.Size = new System.Drawing.Size(181, 20);
            this.txbEnterSubtotal.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Number of invoices:";
            // 
            // txbNumOfInv
            // 
            this.txbNumOfInv.Location = new System.Drawing.Point(498, 66);
            this.txbNumOfInv.Name = "txbNumOfInv";
            this.txbNumOfInv.ReadOnly = true;
            this.txbNumOfInv.Size = new System.Drawing.Size(181, 20);
            this.txbNumOfInv.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total of invoices:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Invoice average:";
            // 
            // txbTotalOfInv
            // 
            this.txbTotalOfInv.Location = new System.Drawing.Point(498, 105);
            this.txbTotalOfInv.Name = "txbTotalOfInv";
            this.txbTotalOfInv.ReadOnly = true;
            this.txbTotalOfInv.Size = new System.Drawing.Size(181, 20);
            this.txbTotalOfInv.TabIndex = 10;
            // 
            // txbInvoiceAverage
            // 
            this.txbInvoiceAverage.Location = new System.Drawing.Point(498, 141);
            this.txbInvoiceAverage.Name = "txbInvoiceAverage";
            this.txbInvoiceAverage.ReadOnly = true;
            this.txbInvoiceAverage.Size = new System.Drawing.Size(181, 20);
            this.txbInvoiceAverage.TabIndex = 11;
            // 
            // formInvTotal
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(845, 450);
            this.Controls.Add(this.txbInvoiceAverage);
            this.Controls.Add(this.txbTotalOfInv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbNumOfInv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbEnterSubtotal);
            this.Controls.Add(this.btnClearTotals);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txbTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txbDscntAmnt);
            this.Controls.Add(this.txbDscntPct);
            this.Controls.Add(this.txbSubtotal);
            this.Controls.Add(this.lblDsctAmnt);
            this.Controls.Add(this.lblDsctPct);
            this.Controls.Add(this.lblSubtotal);
            this.Name = "formInvTotal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice Total";
            this.Load += new System.EventHandler(this.formInvTotal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblDsctPct;
        private System.Windows.Forms.Label lblDsctAmnt;
        private System.Windows.Forms.TextBox txbSubtotal;
        private System.Windows.Forms.TextBox txbDscntPct;
        private System.Windows.Forms.TextBox txbDscntAmnt;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txbTotal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClearTotals;
        private System.Windows.Forms.TextBox txbEnterSubtotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNumOfInv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbTotalOfInv;
        private System.Windows.Forms.TextBox txbInvoiceAverage;
    }
}

