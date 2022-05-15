﻿namespace BankMS.customerChildForm
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
            this.loanCurrencyCB = new System.Windows.Forms.ComboBox();
            this.pnlLoanPayment = new System.Windows.Forms.Panel();
            this.btnConfirmLoan = new System.Windows.Forms.Button();
            this.btnCancelLoan = new System.Windows.Forms.Button();
            this.loanAmountTB = new System.Windows.Forms.TextBox();
            this.loanAccountTB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.creditAmountTB = new System.Windows.Forms.TextBox();
            this.creditAccountTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlCreditRequest = new System.Windows.Forms.Panel();
            this.btnConfirmCredit = new System.Windows.Forms.Button();
            this.btnCancelCredit = new System.Windows.Forms.Button();
            this.accountTB = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCheckBalance = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlLoanPayment.SuspendLayout();
            this.pnlCreditRequest.SuspendLayout();
            this.panel1.SuspendLayout();
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
            // loanCurrencyCB
            // 
            this.loanCurrencyCB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loanCurrencyCB.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanCurrencyCB.ForeColor = System.Drawing.Color.Black;
            this.loanCurrencyCB.FormattingEnabled = true;
            this.loanCurrencyCB.Items.AddRange(new object[] {
            "Lira",
            "Dollar",
            "Euro"});
            this.loanCurrencyCB.Location = new System.Drawing.Point(268, 51);
            this.loanCurrencyCB.Name = "loanCurrencyCB";
            this.loanCurrencyCB.Size = new System.Drawing.Size(98, 25);
            this.loanCurrencyCB.TabIndex = 5;
            this.loanCurrencyCB.Text = "Para Birimi";
            // 
            // pnlLoanPayment
            // 
            this.pnlLoanPayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlLoanPayment.Controls.Add(this.btnConfirmLoan);
            this.pnlLoanPayment.Controls.Add(this.btnCancelLoan);
            this.pnlLoanPayment.Controls.Add(this.loanCurrencyCB);
            this.pnlLoanPayment.Controls.Add(this.loanAmountTB);
            this.pnlLoanPayment.Controls.Add(this.loanAccountTB);
            this.pnlLoanPayment.Controls.Add(this.label11);
            this.pnlLoanPayment.Controls.Add(this.label12);
            this.pnlLoanPayment.Location = new System.Drawing.Point(451, 223);
            this.pnlLoanPayment.Name = "pnlLoanPayment";
            this.pnlLoanPayment.Size = new System.Drawing.Size(402, 311);
            this.pnlLoanPayment.TabIndex = 13;
            // 
            // btnConfirmLoan
            // 
            this.btnConfirmLoan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConfirmLoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(190)))));
            this.btnConfirmLoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmLoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmLoan.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmLoan.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmLoan.Location = new System.Drawing.Point(207, 259);
            this.btnConfirmLoan.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmLoan.Name = "btnConfirmLoan";
            this.btnConfirmLoan.Size = new System.Drawing.Size(75, 35);
            this.btnConfirmLoan.TabIndex = 4;
            this.btnConfirmLoan.Text = "Onayla";
            this.btnConfirmLoan.UseVisualStyleBackColor = false;
            // 
            // btnCancelLoan
            // 
            this.btnCancelLoan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelLoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(190)))));
            this.btnCancelLoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelLoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelLoan.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelLoan.ForeColor = System.Drawing.Color.Black;
            this.btnCancelLoan.Location = new System.Drawing.Point(290, 259);
            this.btnCancelLoan.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelLoan.Name = "btnCancelLoan";
            this.btnCancelLoan.Size = new System.Drawing.Size(76, 35);
            this.btnCancelLoan.TabIndex = 4;
            this.btnCancelLoan.Text = "İptal et";
            this.btnCancelLoan.UseVisualStyleBackColor = false;
            // 
            // loanAmountTB
            // 
            this.loanAmountTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanAmountTB.Location = new System.Drawing.Point(143, 50);
            this.loanAmountTB.Name = "loanAmountTB";
            this.loanAmountTB.Size = new System.Drawing.Size(102, 26);
            this.loanAmountTB.TabIndex = 0;
            // 
            // loanAccountTB
            // 
            this.loanAccountTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanAccountTB.Location = new System.Drawing.Point(143, 7);
            this.loanAccountTB.Name = "loanAccountTB";
            this.loanAccountTB.Size = new System.Drawing.Size(223, 26);
            this.loanAccountTB.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Tutar:";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "Hesap Numarısı:";
            // 
            // creditAmountTB
            // 
            this.creditAmountTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditAmountTB.Location = new System.Drawing.Point(143, 50);
            this.creditAmountTB.Name = "creditAmountTB";
            this.creditAmountTB.Size = new System.Drawing.Size(102, 26);
            this.creditAmountTB.TabIndex = 0;
            // 
            // creditAccountTB
            // 
            this.creditAccountTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditAccountTB.Location = new System.Drawing.Point(143, 7);
            this.creditAccountTB.Name = "creditAccountTB";
            this.creditAccountTB.Size = new System.Drawing.Size(223, 26);
            this.creditAccountTB.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Kredi Tutarı(TL):";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Hesap Numarısı:";
            // 
            // pnlCreditRequest
            // 
            this.pnlCreditRequest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlCreditRequest.Controls.Add(this.btnConfirmCredit);
            this.pnlCreditRequest.Controls.Add(this.btnCancelCredit);
            this.pnlCreditRequest.Controls.Add(this.creditAmountTB);
            this.pnlCreditRequest.Controls.Add(this.creditAccountTB);
            this.pnlCreditRequest.Controls.Add(this.label9);
            this.pnlCreditRequest.Controls.Add(this.label7);
            this.pnlCreditRequest.Location = new System.Drawing.Point(22, 223);
            this.pnlCreditRequest.Name = "pnlCreditRequest";
            this.pnlCreditRequest.Size = new System.Drawing.Size(402, 311);
            this.pnlCreditRequest.TabIndex = 12;
            // 
            // btnConfirmCredit
            // 
            this.btnConfirmCredit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConfirmCredit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(190)))));
            this.btnConfirmCredit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmCredit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmCredit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmCredit.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmCredit.Location = new System.Drawing.Point(207, 259);
            this.btnConfirmCredit.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmCredit.Name = "btnConfirmCredit";
            this.btnConfirmCredit.Size = new System.Drawing.Size(75, 35);
            this.btnConfirmCredit.TabIndex = 4;
            this.btnConfirmCredit.Text = "Onayla";
            this.btnConfirmCredit.UseVisualStyleBackColor = false;
            // 
            // btnCancelCredit
            // 
            this.btnCancelCredit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelCredit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(190)))));
            this.btnCancelCredit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelCredit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelCredit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelCredit.ForeColor = System.Drawing.Color.Black;
            this.btnCancelCredit.Location = new System.Drawing.Point(290, 259);
            this.btnCancelCredit.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelCredit.Name = "btnCancelCredit";
            this.btnCancelCredit.Size = new System.Drawing.Size(76, 35);
            this.btnCancelCredit.TabIndex = 4;
            this.btnCancelCredit.Text = "İptal et";
            this.btnCancelCredit.UseVisualStyleBackColor = false;
            // 
            // accountTB
            // 
            this.accountTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountTB.Location = new System.Drawing.Point(82, 61);
            this.accountTB.Name = "accountTB";
            this.accountTB.Size = new System.Drawing.Size(223, 29);
            this.accountTB.TabIndex = 0;
            // 
            // lblBalance
            // 
            this.lblBalance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(601, 67);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(133, 20);
            this.lblBalance.TabIndex = 1;
            this.lblBalance.Text = "Hesap Bakiyem";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 38);
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
            this.label13.Location = new System.Drawing.Point(302, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(174, 20);
            this.label13.TabIndex = 1;
            this.label13.Text = "BAKİYE KONTROLÜ";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.btnCheckBalance);
            this.panel1.Controls.Add(this.accountTB);
            this.panel1.Controls.Add(this.lblBalance);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Location = new System.Drawing.Point(83, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 112);
            this.panel1.TabIndex = 11;
            // 
            // btnCheckBalance
            // 
            this.btnCheckBalance.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCheckBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(190)))));
            this.btnCheckBalance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckBalance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckBalance.ForeColor = System.Drawing.Color.Black;
            this.btnCheckBalance.Location = new System.Drawing.Point(317, 55);
            this.btnCheckBalance.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckBalance.Name = "btnCheckBalance";
            this.btnCheckBalance.Size = new System.Drawing.Size(116, 35);
            this.btnCheckBalance.TabIndex = 4;
            this.btnCheckBalance.Text = "Göster";
            this.btnCheckBalance.UseVisualStyleBackColor = false;
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
            // krediIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(874, 546);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pnlLoanPayment);
            this.Controls.Add(this.pnlCreditRequest);
            this.Controls.Add(this.panel1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox loanCurrencyCB;
        private System.Windows.Forms.Panel pnlLoanPayment;
        //private Bunifu.Framework.UI.BunifuThinButton2 btnCancelLoan;
        //private Bunifu.Framework.UI.BunifuThinButton2 btnConfirmLoan;
        private System.Windows.Forms.TextBox loanAmountTB;
        private System.Windows.Forms.TextBox loanAccountTB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        //private Bunifu.Framework.UI.BunifuThinButton2 btnCancelCredit;
        //private Bunifu.Framework.UI.BunifuThinButton2 btnConfirmCredit;
        private System.Windows.Forms.TextBox creditAmountTB;
        private System.Windows.Forms.TextBox creditAccountTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlCreditRequest;
        //private Bunifu.Framework.UI.BunifuThinButton2 btnCheckBalance;
        private System.Windows.Forms.TextBox accountTB;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirmLoan;
        private System.Windows.Forms.Button btnCancelLoan;
        private System.Windows.Forms.Button btnConfirmCredit;
        private System.Windows.Forms.Button btnCancelCredit;
        private System.Windows.Forms.Button btnCheckBalance;
    }
}