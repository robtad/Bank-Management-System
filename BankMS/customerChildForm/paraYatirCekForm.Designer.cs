namespace BankMS.customerChildForm
{
    partial class paraYatirCekForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.accountTB = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pnlDeposit = new System.Windows.Forms.Panel();
            this.depositDatePicker = new System.Windows.Forms.DateTimePicker();
            this.depositCurrencyCB = new System.Windows.Forms.ComboBox();
            this.depositAmountTB = new System.Windows.Forms.TextBox();
            this.depositNoteTB = new System.Windows.Forms.TextBox();
            this.depositAccountTB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlWithdraw = new System.Windows.Forms.Panel();
            this.withdrawDatePicker = new System.Windows.Forms.DateTimePicker();
            this.withdrawCurrencyCB = new System.Windows.Forms.ComboBox();
            this.withdrawAmountTB = new System.Windows.Forms.TextBox();
            this.withdrawNoteTB = new System.Windows.Forms.TextBox();
            this.withdrawAccountTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCheckBalance = new System.Windows.Forms.Button();
            this.btnCancelDeposit = new System.Windows.Forms.Button();
            this.btnConfirmDeposit = new System.Windows.Forms.Button();
            this.btnConfirmWithdrawal = new System.Windows.Forms.Button();
            this.btnCancelWithdrawal = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlDeposit.SuspendLayout();
            this.pnlWithdraw.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "PARA YATIRMA VE ÇEKME İŞLEMLERİ";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.btnCheckBalance);
            this.panel1.Controls.Add(this.accountTB);
            this.panel1.Controls.Add(this.lblBalance);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Location = new System.Drawing.Point(88, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 112);
            this.panel1.TabIndex = 2;
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
            // pnlDeposit
            // 
            this.pnlDeposit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlDeposit.Controls.Add(this.btnConfirmDeposit);
            this.pnlDeposit.Controls.Add(this.btnCancelDeposit);
            this.pnlDeposit.Controls.Add(this.depositDatePicker);
            this.pnlDeposit.Controls.Add(this.depositCurrencyCB);
            this.pnlDeposit.Controls.Add(this.depositAmountTB);
            this.pnlDeposit.Controls.Add(this.depositNoteTB);
            this.pnlDeposit.Controls.Add(this.depositAccountTB);
            this.pnlDeposit.Controls.Add(this.label10);
            this.pnlDeposit.Controls.Add(this.label6);
            this.pnlDeposit.Controls.Add(this.label9);
            this.pnlDeposit.Controls.Add(this.label7);
            this.pnlDeposit.Location = new System.Drawing.Point(27, 219);
            this.pnlDeposit.Name = "pnlDeposit";
            this.pnlDeposit.Size = new System.Drawing.Size(402, 311);
            this.pnlDeposit.TabIndex = 6;
            // 
            // depositDatePicker
            // 
            this.depositDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositDatePicker.Location = new System.Drawing.Point(143, 95);
            this.depositDatePicker.Name = "depositDatePicker";
            this.depositDatePicker.Size = new System.Drawing.Size(223, 22);
            this.depositDatePicker.TabIndex = 6;
            // 
            // depositCurrencyCB
            // 
            this.depositCurrencyCB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.depositCurrencyCB.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositCurrencyCB.ForeColor = System.Drawing.Color.Black;
            this.depositCurrencyCB.FormattingEnabled = true;
            this.depositCurrencyCB.Items.AddRange(new object[] {
            "Lira",
            "Dollar",
            "Euro"});
            this.depositCurrencyCB.Location = new System.Drawing.Point(268, 51);
            this.depositCurrencyCB.Name = "depositCurrencyCB";
            this.depositCurrencyCB.Size = new System.Drawing.Size(98, 25);
            this.depositCurrencyCB.TabIndex = 5;
            this.depositCurrencyCB.Text = "Para Birimi";
            // 
            // depositAmountTB
            // 
            this.depositAmountTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositAmountTB.Location = new System.Drawing.Point(143, 50);
            this.depositAmountTB.Name = "depositAmountTB";
            this.depositAmountTB.Size = new System.Drawing.Size(102, 26);
            this.depositAmountTB.TabIndex = 0;
            // 
            // depositNoteTB
            // 
            this.depositNoteTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositNoteTB.Location = new System.Drawing.Point(143, 133);
            this.depositNoteTB.Multiline = true;
            this.depositNoteTB.Name = "depositNoteTB";
            this.depositNoteTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.depositNoteTB.Size = new System.Drawing.Size(223, 97);
            this.depositNoteTB.TabIndex = 0;
            // 
            // depositAccountTB
            // 
            this.depositAccountTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositAccountTB.Location = new System.Drawing.Point(143, 7);
            this.depositAccountTB.Name = "depositAccountTB";
            this.depositAccountTB.Size = new System.Drawing.Size(223, 26);
            this.depositAccountTB.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Açıklama:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tarih:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Mevduat Tutarı:";
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
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(165, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "PARA YATIR";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(594, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "PARA ÇEK";
            // 
            // pnlWithdraw
            // 
            this.pnlWithdraw.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlWithdraw.Controls.Add(this.btnCancelWithdrawal);
            this.pnlWithdraw.Controls.Add(this.btnConfirmWithdrawal);
            this.pnlWithdraw.Controls.Add(this.withdrawDatePicker);
            this.pnlWithdraw.Controls.Add(this.withdrawCurrencyCB);
            this.pnlWithdraw.Controls.Add(this.withdrawAmountTB);
            this.pnlWithdraw.Controls.Add(this.withdrawNoteTB);
            this.pnlWithdraw.Controls.Add(this.withdrawAccountTB);
            this.pnlWithdraw.Controls.Add(this.label3);
            this.pnlWithdraw.Controls.Add(this.label4);
            this.pnlWithdraw.Controls.Add(this.label11);
            this.pnlWithdraw.Controls.Add(this.label12);
            this.pnlWithdraw.Location = new System.Drawing.Point(456, 219);
            this.pnlWithdraw.Name = "pnlWithdraw";
            this.pnlWithdraw.Size = new System.Drawing.Size(402, 311);
            this.pnlWithdraw.TabIndex = 7;
            // 
            // withdrawDatePicker
            // 
            this.withdrawDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawDatePicker.Location = new System.Drawing.Point(143, 95);
            this.withdrawDatePicker.Name = "withdrawDatePicker";
            this.withdrawDatePicker.Size = new System.Drawing.Size(223, 22);
            this.withdrawDatePicker.TabIndex = 6;
            // 
            // withdrawCurrencyCB
            // 
            this.withdrawCurrencyCB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.withdrawCurrencyCB.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawCurrencyCB.ForeColor = System.Drawing.Color.Black;
            this.withdrawCurrencyCB.FormattingEnabled = true;
            this.withdrawCurrencyCB.Items.AddRange(new object[] {
            "Lira",
            "Dollar",
            "Euro"});
            this.withdrawCurrencyCB.Location = new System.Drawing.Point(268, 51);
            this.withdrawCurrencyCB.Name = "withdrawCurrencyCB";
            this.withdrawCurrencyCB.Size = new System.Drawing.Size(98, 25);
            this.withdrawCurrencyCB.TabIndex = 5;
            this.withdrawCurrencyCB.Text = "Para Birimi";
            // 
            // withdrawAmountTB
            // 
            this.withdrawAmountTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawAmountTB.Location = new System.Drawing.Point(143, 50);
            this.withdrawAmountTB.Name = "withdrawAmountTB";
            this.withdrawAmountTB.Size = new System.Drawing.Size(102, 26);
            this.withdrawAmountTB.TabIndex = 0;
            // 
            // withdrawNoteTB
            // 
            this.withdrawNoteTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawNoteTB.Location = new System.Drawing.Point(143, 133);
            this.withdrawNoteTB.Multiline = true;
            this.withdrawNoteTB.Name = "withdrawNoteTB";
            this.withdrawNoteTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.withdrawNoteTB.Size = new System.Drawing.Size(223, 97);
            this.withdrawNoteTB.TabIndex = 0;
            // 
            // withdrawAccountTB
            // 
            this.withdrawAccountTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawAccountTB.Location = new System.Drawing.Point(143, 7);
            this.withdrawAccountTB.Name = "withdrawAccountTB";
            this.withdrawAccountTB.Size = new System.Drawing.Size(223, 26);
            this.withdrawAccountTB.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Açıklama:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tarih:";
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
            // btnCheckBalance
            // 
            this.btnCheckBalance.ForeColor = System.Drawing.Color.Black;
            this.btnCheckBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(190)))));
            this.btnCheckBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckBalance.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCheckBalance.Text = "Göster";
            this.btnCheckBalance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckBalance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckBalance.Location = new System.Drawing.Point(317, 55);
            this.btnCheckBalance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheckBalance.Name = "btnCheckBalance";
            this.btnCheckBalance.Size = new System.Drawing.Size(116, 35);
            this.btnCheckBalance.TabIndex = 4;
            this.btnCheckBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancelDeposit
            // 
            this.btnCancelDeposit.ForeColor = System.Drawing.Color.Black;
            this.btnCancelDeposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(190)))));
            this.btnCancelDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelDeposit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelDeposit.Text = "İptal et";
            this.btnCancelDeposit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelDeposit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelDeposit.Location = new System.Drawing.Point(290, 259);
            this.btnCancelDeposit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelDeposit.Name = "btnCancelDeposit";
            this.btnCancelDeposit.Size = new System.Drawing.Size(76, 35);
            this.btnCancelDeposit.TabIndex = 4;
            this.btnCancelDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConfirmDeposit
            // 
            this.btnConfirmDeposit.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmDeposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(190)))));
            this.btnConfirmDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmDeposit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConfirmDeposit.Text = "Onayla";
            this.btnConfirmDeposit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmDeposit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmDeposit.Location = new System.Drawing.Point(207, 259);
            this.btnConfirmDeposit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfirmDeposit.Name = "btnConfirmDeposit";
            this.btnConfirmDeposit.Size = new System.Drawing.Size(75, 35);
            this.btnConfirmDeposit.TabIndex = 4;
            this.btnConfirmDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConfirmWithdrawal
            // 
            this.btnConfirmWithdrawal.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmWithdrawal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(190)))));
            this.btnConfirmWithdrawal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmWithdrawal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConfirmWithdrawal.Text = "Onayla";
            this.btnConfirmWithdrawal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmWithdrawal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmWithdrawal.Location = new System.Drawing.Point(207, 259);
            this.btnConfirmWithdrawal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfirmWithdrawal.Name = "btnConfirmWithdrawal";
            this.btnConfirmWithdrawal.Size = new System.Drawing.Size(75, 35);
            this.btnConfirmWithdrawal.TabIndex = 4;
            this.btnConfirmWithdrawal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancelWithdrawal
            // 
            this.btnCancelWithdrawal.ForeColor = System.Drawing.Color.Black;
            this.btnCancelWithdrawal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(190)))));
            this.btnCancelWithdrawal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelWithdrawal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelWithdrawal.Text = "İptal et";
            this.btnCancelWithdrawal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelWithdrawal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelWithdrawal.Location = new System.Drawing.Point(290, 259);
            this.btnCancelWithdrawal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelWithdrawal.Name = "btnCancelWithdrawal";
            this.btnCancelWithdrawal.Size = new System.Drawing.Size(76, 35);
            this.btnCancelWithdrawal.TabIndex = 4;
            this.btnCancelWithdrawal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paraYatirCekForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(890, 542);
            this.Controls.Add(this.pnlWithdraw);
            this.Controls.Add(this.pnlDeposit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "paraYatirCekForm";
            this.Text = "paraYatir";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlDeposit.ResumeLayout(false);
            this.pnlDeposit.PerformLayout();
            this.pnlWithdraw.ResumeLayout(false);
            this.pnlWithdraw.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox accountTB;
        private System.Windows.Forms.Label label2;
        //private Bunifu.Framework.UI.BunifuThinButton2 btnCheckBalance;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Panel pnlDeposit;
        //private Bunifu.Framework.UI.BunifuThinButton2 btnConfirmDeposit;
        private System.Windows.Forms.TextBox depositAccountTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox depositAmountTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox depositCurrencyCB;
        private System.Windows.Forms.DateTimePicker depositDatePicker;
        //private Bunifu.Framework.UI.BunifuThinButton2 btnCancelDeposit;
        private System.Windows.Forms.TextBox depositNoteTB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pnlWithdraw;
        private System.Windows.Forms.DateTimePicker withdrawDatePicker;
        private System.Windows.Forms.ComboBox withdrawCurrencyCB;
       // private Bunifu.Framework.UI.BunifuThinButton2 btnCancelWithdrawal;
        //private Bunifu.Framework.UI.BunifuThinButton2 btnConfirmWithdrawal;
        private System.Windows.Forms.TextBox withdrawAmountTB;
        private System.Windows.Forms.TextBox withdrawNoteTB;
        private System.Windows.Forms.TextBox withdrawAccountTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnCheckBalance;
        private System.Windows.Forms.Button btnConfirmDeposit;
        private System.Windows.Forms.Button btnCancelDeposit;
        private System.Windows.Forms.Button btnCancelWithdrawal;
        private System.Windows.Forms.Button btnConfirmWithdrawal;
    }
}