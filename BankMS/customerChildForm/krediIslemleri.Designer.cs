namespace BankMS.customerChildForm
{
    partial class krediIslemleri
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
            this.label8 = new System.Windows.Forms.Label();
            this.pnlLoanPayment = new System.Windows.Forms.Panel();
            this.lblCurrencyB = new System.Windows.Forms.Label();
            this.btnPayLoan = new System.Windows.Forms.Button();
            this.loanAmountTB = new System.Windows.Forms.TextBox();
            this.loanAccountTB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pnlCreditRequest = new System.Windows.Forms.Panel();
            this.ExpirationCB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCurrencyA = new System.Windows.Forms.Label();
            this.btnCreditRequest = new System.Windows.Forms.Button();
            this.creditAmountTB = new System.Windows.Forms.TextBox();
            this.creditAccountTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.balanceTB = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.btnCheckBalance = new System.Windows.Forms.Button();
            this.accountTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.customerDataGrid = new System.Windows.Forms.DataGridView();
            this.pnlLoanPayment.SuspendLayout();
            this.pnlCreditRequest.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(589, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(256, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "KREDİ BORCU ÖDEME";
            // 
            // pnlLoanPayment
            // 
            this.pnlLoanPayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlLoanPayment.Controls.Add(this.lblCurrencyB);
            this.pnlLoanPayment.Controls.Add(this.btnPayLoan);
            this.pnlLoanPayment.Controls.Add(this.loanAmountTB);
            this.pnlLoanPayment.Controls.Add(this.loanAccountTB);
            this.pnlLoanPayment.Controls.Add(this.label11);
            this.pnlLoanPayment.Controls.Add(this.label12);
            this.pnlLoanPayment.Location = new System.Drawing.Point(451, 223);
            this.pnlLoanPayment.Name = "pnlLoanPayment";
            this.pnlLoanPayment.Size = new System.Drawing.Size(402, 146);
            this.pnlLoanPayment.TabIndex = 13;
            // 
            // lblCurrencyB
            // 
            this.lblCurrencyB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCurrencyB.AutoSize = true;
            this.lblCurrencyB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrencyB.Location = new System.Drawing.Point(263, 67);
            this.lblCurrencyB.Name = "lblCurrencyB";
            this.lblCurrencyB.Size = new System.Drawing.Size(53, 15);
            this.lblCurrencyB.TabIndex = 21;
            this.lblCurrencyB.Text = "currency";
            // 
            // btnPayLoan
            // 
            this.btnPayLoan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPayLoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(190)))));
            this.btnPayLoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayLoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayLoan.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayLoan.ForeColor = System.Drawing.Color.Black;
            this.btnPayLoan.Location = new System.Drawing.Point(303, 99);
            this.btnPayLoan.Margin = new System.Windows.Forms.Padding(4);
            this.btnPayLoan.Name = "btnPayLoan";
            this.btnPayLoan.Size = new System.Drawing.Size(75, 35);
            this.btnPayLoan.TabIndex = 10;
            this.btnPayLoan.Text = "ÖDE";
            this.btnPayLoan.UseVisualStyleBackColor = false;
            this.btnPayLoan.Click += new System.EventHandler(this.btnPayLoan_Click);
            // 
            // loanAmountTB
            // 
            this.loanAmountTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanAmountTB.Location = new System.Drawing.Point(155, 56);
            this.loanAmountTB.Name = "loanAmountTB";
            this.loanAmountTB.Size = new System.Drawing.Size(102, 26);
            this.loanAmountTB.TabIndex = 6;
            // 
            // loanAccountTB
            // 
            this.loanAccountTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanAccountTB.Location = new System.Drawing.Point(155, 13);
            this.loanAccountTB.Name = "loanAccountTB";
            this.loanAccountTB.ReadOnly = true;
            this.loanAccountTB.Size = new System.Drawing.Size(223, 26);
            this.loanAccountTB.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(24, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "Tutar:";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(24, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 20);
            this.label12.TabIndex = 9;
            this.label12.Text = "Hesap Numarısı:";
            // 
            // pnlCreditRequest
            // 
            this.pnlCreditRequest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlCreditRequest.Controls.Add(this.ExpirationCB);
            this.pnlCreditRequest.Controls.Add(this.label6);
            this.pnlCreditRequest.Controls.Add(this.lblCurrencyA);
            this.pnlCreditRequest.Controls.Add(this.btnCreditRequest);
            this.pnlCreditRequest.Controls.Add(this.creditAmountTB);
            this.pnlCreditRequest.Controls.Add(this.creditAccountTB);
            this.pnlCreditRequest.Controls.Add(this.label9);
            this.pnlCreditRequest.Controls.Add(this.label7);
            this.pnlCreditRequest.Location = new System.Drawing.Point(22, 223);
            this.pnlCreditRequest.Name = "pnlCreditRequest";
            this.pnlCreditRequest.Size = new System.Drawing.Size(402, 146);
            this.pnlCreditRequest.TabIndex = 12;
            // 
            // ExpirationCB
            // 
            this.ExpirationCB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExpirationCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ExpirationCB.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpirationCB.ForeColor = System.Drawing.Color.Black;
            this.ExpirationCB.FormattingEnabled = true;
            this.ExpirationCB.Items.AddRange(new object[] {
            "6",
            "12",
            "18",
            "24"});
            this.ExpirationCB.Location = new System.Drawing.Point(155, 94);
            this.ExpirationCB.Name = "ExpirationCB";
            this.ExpirationCB.Size = new System.Drawing.Size(98, 25);
            this.ExpirationCB.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Vade:";
            // 
            // lblCurrencyA
            // 
            this.lblCurrencyA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCurrencyA.AutoSize = true;
            this.lblCurrencyA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrencyA.Location = new System.Drawing.Point(263, 67);
            this.lblCurrencyA.Name = "lblCurrencyA";
            this.lblCurrencyA.Size = new System.Drawing.Size(53, 15);
            this.lblCurrencyA.TabIndex = 21;
            this.lblCurrencyA.Text = "currency";
            // 
            // btnCreditRequest
            // 
            this.btnCreditRequest.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCreditRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(190)))));
            this.btnCreditRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreditRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreditRequest.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreditRequest.ForeColor = System.Drawing.Color.Black;
            this.btnCreditRequest.Location = new System.Drawing.Point(303, 99);
            this.btnCreditRequest.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreditRequest.Name = "btnCreditRequest";
            this.btnCreditRequest.Size = new System.Drawing.Size(75, 35);
            this.btnCreditRequest.TabIndex = 9;
            this.btnCreditRequest.Text = "Onayla";
            this.btnCreditRequest.UseVisualStyleBackColor = false;
            this.btnCreditRequest.Click += new System.EventHandler(this.btnCreditRequest_Click);
            // 
            // creditAmountTB
            // 
            this.creditAmountTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditAmountTB.Location = new System.Drawing.Point(155, 56);
            this.creditAmountTB.Name = "creditAmountTB";
            this.creditAmountTB.Size = new System.Drawing.Size(102, 26);
            this.creditAmountTB.TabIndex = 5;
            // 
            // creditAccountTB
            // 
            this.creditAccountTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditAccountTB.Location = new System.Drawing.Point(155, 13);
            this.creditAccountTB.Name = "creditAccountTB";
            this.creditAccountTB.ReadOnly = true;
            this.creditAccountTB.Size = new System.Drawing.Size(223, 26);
            this.creditAccountTB.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Kredi Tutarı(TL):";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Hesap Numarısı:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(160, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "KREDİ TALEBİ";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "KREDİ TALEBİ VE KREDİ BORCU ÖDEME";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.lblCurrency);
            this.panel1.Controls.Add(this.balanceTB);
            this.panel1.Controls.Add(this.lblBalance);
            this.panel1.Controls.Add(this.btnCheckBalance);
            this.panel1.Controls.Add(this.accountTB);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Location = new System.Drawing.Point(113, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 112);
            this.panel1.TabIndex = 14;
            // 
            // lblCurrency
            // 
            this.lblCurrency.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrency.Location = new System.Drawing.Point(586, 70);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(53, 15);
            this.lblCurrency.TabIndex = 20;
            this.lblCurrency.Text = "currency";
            // 
            // balanceTB
            // 
            this.balanceTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceTB.Location = new System.Drawing.Point(487, 64);
            this.balanceTB.Name = "balanceTB";
            this.balanceTB.ReadOnly = true;
            this.balanceTB.Size = new System.Drawing.Size(93, 26);
            this.balanceTB.TabIndex = 19;
            // 
            // lblBalance
            // 
            this.lblBalance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(483, 38);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(62, 20);
            this.lblBalance.TabIndex = 18;
            this.lblBalance.Text = "Bakiye";
            // 
            // btnCheckBalance
            // 
            this.btnCheckBalance.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCheckBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(190)))));
            this.btnCheckBalance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckBalance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckBalance.ForeColor = System.Drawing.Color.Black;
            this.btnCheckBalance.Location = new System.Drawing.Point(294, 55);
            this.btnCheckBalance.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckBalance.Name = "btnCheckBalance";
            this.btnCheckBalance.Size = new System.Drawing.Size(116, 35);
            this.btnCheckBalance.TabIndex = 4;
            this.btnCheckBalance.Text = "Göster";
            this.btnCheckBalance.UseVisualStyleBackColor = false;
            this.btnCheckBalance.Click += new System.EventHandler(this.btnCheckBalance_Click);
            // 
            // accountTB
            // 
            this.accountTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountTB.Location = new System.Drawing.Point(58, 61);
            this.accountTB.Name = "accountTB";
            this.accountTB.ReadOnly = true;
            this.accountTB.Size = new System.Drawing.Size(223, 29);
            this.accountTB.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hesap Numarısı";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(278, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(174, 20);
            this.label13.TabIndex = 1;
            this.label13.Text = "BAKİYE KONTROLÜ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(141, 437);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 52;
            this.label3.Text = "Hesaplarim:";
            // 
            // customerDataGrid
            // 
            this.customerDataGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.customerDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGrid.Location = new System.Drawing.Point(240, 388);
            this.customerDataGrid.Name = "customerDataGrid";
            this.customerDataGrid.Size = new System.Drawing.Size(360, 130);
            this.customerDataGrid.TabIndex = 51;
            this.customerDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerDataGrid_CellClick);
            // 
            // krediIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(874, 546);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.customerDataGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pnlLoanPayment);
            this.Controls.Add(this.pnlCreditRequest);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "krediIslemleri";
            this.Text = "krediTalebi";
            this.pnlLoanPayment.ResumeLayout(false);
            this.pnlLoanPayment.PerformLayout();
            this.pnlCreditRequest.ResumeLayout(false);
            this.pnlCreditRequest.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlLoanPayment;
        private System.Windows.Forms.Panel pnlCreditRequest;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.TextBox balanceTB;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Button btnCheckBalance;
        private System.Windows.Forms.TextBox accountTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblCurrencyB;
        private System.Windows.Forms.Button btnPayLoan;
        private System.Windows.Forms.TextBox loanAmountTB;
        private System.Windows.Forms.TextBox loanAccountTB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox ExpirationCB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCurrencyA;
        private System.Windows.Forms.Button btnCreditRequest;
        private System.Windows.Forms.TextBox creditAmountTB;
        private System.Windows.Forms.TextBox creditAccountTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView customerDataGrid;
    }
}