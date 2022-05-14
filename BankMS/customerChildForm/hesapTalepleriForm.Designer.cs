namespace BankMS.customerChildForm
{
    partial class hesapTalepleriForm
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
            this.pnlDeleteAcc = new System.Windows.Forms.Panel();
            this.btnConfirmDeleteAcc = new System.Windows.Forms.Button();
            this.AccNumberTB = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pnlCheckBalance = new System.Windows.Forms.Panel();
            this.balanceTB = new System.Windows.Forms.TextBox();
            this.btnCheckBalance = new System.Windows.Forms.Button();
            this.accountTB = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConfirmNewAcc = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.CurrencyCB = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.customerDataGrid = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.pnlDeleteAcc.SuspendLayout();
            this.pnlCheckBalance.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDeleteAcc
            // 
            this.pnlDeleteAcc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlDeleteAcc.Controls.Add(this.btnConfirmDeleteAcc);
            this.pnlDeleteAcc.Controls.Add(this.AccNumberTB);
            this.pnlDeleteAcc.Controls.Add(this.label12);
            this.pnlDeleteAcc.Location = new System.Drawing.Point(483, 238);
            this.pnlDeleteAcc.Name = "pnlDeleteAcc";
            this.pnlDeleteAcc.Size = new System.Drawing.Size(361, 64);
            this.pnlDeleteAcc.TabIndex = 13;
            // 
            // btnConfirmDeleteAcc
            // 
            this.btnConfirmDeleteAcc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConfirmDeleteAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(190)))));
            this.btnConfirmDeleteAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmDeleteAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmDeleteAcc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmDeleteAcc.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmDeleteAcc.Location = new System.Drawing.Point(275, 15);
            this.btnConfirmDeleteAcc.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmDeleteAcc.Name = "btnConfirmDeleteAcc";
            this.btnConfirmDeleteAcc.Size = new System.Drawing.Size(75, 35);
            this.btnConfirmDeleteAcc.TabIndex = 17;
            this.btnConfirmDeleteAcc.Text = "Gonder";
            this.btnConfirmDeleteAcc.UseVisualStyleBackColor = false;
            this.btnConfirmDeleteAcc.Click += new System.EventHandler(this.btnConfirmDeleteAcc_Click);
            // 
            // AccNumberTB
            // 
            this.AccNumberTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccNumberTB.Location = new System.Drawing.Point(135, 9);
            this.AccNumberTB.Name = "AccNumberTB";
            this.AccNumberTB.Size = new System.Drawing.Size(123, 26);
            this.AccNumberTB.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(11, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 20);
            this.label12.TabIndex = 16;
            this.label12.Text = "Hesap Numarısı:";
            // 
            // pnlCheckBalance
            // 
            this.pnlCheckBalance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlCheckBalance.Controls.Add(this.lblCurrency);
            this.pnlCheckBalance.Controls.Add(this.balanceTB);
            this.pnlCheckBalance.Controls.Add(this.btnCheckBalance);
            this.pnlCheckBalance.Controls.Add(this.accountTB);
            this.pnlCheckBalance.Controls.Add(this.lblBalance);
            this.pnlCheckBalance.Controls.Add(this.label2);
            this.pnlCheckBalance.Controls.Add(this.label13);
            this.pnlCheckBalance.Location = new System.Drawing.Point(80, 50);
            this.pnlCheckBalance.Name = "pnlCheckBalance";
            this.pnlCheckBalance.Size = new System.Drawing.Size(753, 112);
            this.pnlCheckBalance.TabIndex = 11;
            // 
            // balanceTB
            // 
            this.balanceTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceTB.Location = new System.Drawing.Point(538, 64);
            this.balanceTB.Name = "balanceTB";
            this.balanceTB.Size = new System.Drawing.Size(93, 26);
            this.balanceTB.TabIndex = 16;
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
            this.btnCheckBalance.Click += new System.EventHandler(this.btnCheckBalance_Click);
            // 
            // accountTB
            // 
            this.accountTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountTB.Location = new System.Drawing.Point(82, 61);
            this.accountTB.Name = "accountTB";
            this.accountTB.Size = new System.Drawing.Size(221, 29);
            this.accountTB.TabIndex = 0;
            // 
            // lblBalance
            // 
            this.lblBalance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(534, 38);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(62, 20);
            this.lblBalance.TabIndex = 1;
            this.lblBalance.Text = "Bakiye";
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
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(483, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(350, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "MEVCÜT HESAP SİLME TALEBİ";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(78, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(305, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "YENİ HESAP AÇMA TALEBİ";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "HESAP AÇMA VE SİLME TALEPLERİ";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.btnConfirmNewAcc);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.CurrencyCB);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(67, 238);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 64);
            this.panel1.TabIndex = 14;
            // 
            // btnConfirmNewAcc
            // 
            this.btnConfirmNewAcc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConfirmNewAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(190)))));
            this.btnConfirmNewAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmNewAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmNewAcc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmNewAcc.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmNewAcc.Location = new System.Drawing.Point(256, 12);
            this.btnConfirmNewAcc.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmNewAcc.Name = "btnConfirmNewAcc";
            this.btnConfirmNewAcc.Size = new System.Drawing.Size(75, 35);
            this.btnConfirmNewAcc.TabIndex = 49;
            this.btnConfirmNewAcc.Text = "Gonder";
            this.btnConfirmNewAcc.UseVisualStyleBackColor = false;
            this.btnConfirmNewAcc.Click += new System.EventHandler(this.btnConfirmNewAcc_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 25);
            this.label6.TabIndex = 10;
            // 
            // CurrencyCB
            // 
            this.CurrencyCB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrencyCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CurrencyCB.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrencyCB.ForeColor = System.Drawing.Color.Black;
            this.CurrencyCB.FormattingEnabled = true;
            this.CurrencyCB.Location = new System.Drawing.Point(132, 9);
            this.CurrencyCB.Name = "CurrencyCB";
            this.CurrencyCB.Size = new System.Drawing.Size(105, 25);
            this.CurrencyCB.TabIndex = 48;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 20);
            this.label11.TabIndex = 47;
            this.label11.Text = "Hesap Türü Id:";
            // 
            // customerDataGrid
            // 
            this.customerDataGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.customerDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGrid.Location = new System.Drawing.Point(483, 308);
            this.customerDataGrid.Name = "customerDataGrid";
            this.customerDataGrid.Size = new System.Drawing.Size(361, 166);
            this.customerDataGrid.TabIndex = 15;
            this.customerDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerDataGrid_CellContentClick);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(382, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 48;
            this.label3.Text = "Hesaplarim:";
            // 
            // lblCurrency
            // 
            this.lblCurrency.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrency.Location = new System.Drawing.Point(637, 70);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(53, 15);
            this.lblCurrency.TabIndex = 17;
            this.lblCurrency.Text = "currency";
            // 
            // hesapTalepleriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(869, 542);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.customerDataGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlDeleteAcc);
            this.Controls.Add(this.pnlCheckBalance);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "hesapTalepleriForm";
            this.Text = "hesapAcma";
            this.pnlDeleteAcc.ResumeLayout(false);
            this.pnlDeleteAcc.PerformLayout();
            this.pnlCheckBalance.ResumeLayout(false);
            this.pnlCheckBalance.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDeleteAcc;
        private System.Windows.Forms.Panel pnlCheckBalance;
        //private Bunifu.Framework.UI.BunifuThinButton2 btnCheckBalance;
        private System.Windows.Forms.TextBox accountTB;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCheckBalance;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnConfirmDeleteAcc;
        private System.Windows.Forms.TextBox AccNumberTB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnConfirmNewAcc;
        private System.Windows.Forms.ComboBox CurrencyCB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView customerDataGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox balanceTB;
        private System.Windows.Forms.Label lblCurrency;
    }
}