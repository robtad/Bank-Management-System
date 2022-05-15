namespace BankMS.tellerChildForm
{
    partial class krediTalepleri
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancelCredit = new System.Windows.Forms.Button();
            this.btnConfirmCredit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CustomerIdTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.customerDataGrid = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.creditAmountTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.expirationTB = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.expirationTB);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.creditAmountTB);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.btnCancelCredit);
            this.panel2.Controls.Add(this.btnConfirmCredit);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.CustomerIdTB);
            this.panel2.Location = new System.Drawing.Point(220, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(361, 171);
            this.panel2.TabIndex = 28;
            // 
            // btnCancelCredit
            // 
            this.btnCancelCredit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelCredit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(190)))));
            this.btnCancelCredit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelCredit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelCredit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelCredit.ForeColor = System.Drawing.Color.Black;
            this.btnCancelCredit.Location = new System.Drawing.Point(235, 132);
            this.btnCancelCredit.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelCredit.Name = "btnCancelCredit";
            this.btnCancelCredit.Size = new System.Drawing.Size(75, 35);
            this.btnCancelCredit.TabIndex = 73;
            this.btnCancelCredit.Text = "Iptal Et";
            this.btnCancelCredit.UseVisualStyleBackColor = false;
            this.btnCancelCredit.Click += new System.EventHandler(this.btnCancelCredit_Click);
            // 
            // btnConfirmCredit
            // 
            this.btnConfirmCredit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConfirmCredit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(190)))));
            this.btnConfirmCredit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmCredit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmCredit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmCredit.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmCredit.Location = new System.Drawing.Point(149, 132);
            this.btnConfirmCredit.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmCredit.Name = "btnConfirmCredit";
            this.btnConfirmCredit.Size = new System.Drawing.Size(75, 35);
            this.btnConfirmCredit.TabIndex = 66;
            this.btnConfirmCredit.Text = "Onayla";
            this.btnConfirmCredit.UseVisualStyleBackColor = false;
            this.btnConfirmCredit.Click += new System.EventHandler(this.btnConfirmCredit_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 69;
            this.label4.Text = "Musteri TCKN:";
            // 
            // CustomerIdTB
            // 
            this.CustomerIdTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerIdTB.Location = new System.Drawing.Point(152, 12);
            this.CustomerIdTB.Name = "CustomerIdTB";
            this.CustomerIdTB.ReadOnly = true;
            this.CustomerIdTB.Size = new System.Drawing.Size(158, 26);
            this.CustomerIdTB.TabIndex = 67;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(295, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "KREDİ TALEBİLERİ";
            // 
            // customerDataGrid
            // 
            this.customerDataGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.customerDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGrid.Location = new System.Drawing.Point(150, 274);
            this.customerDataGrid.Name = "customerDataGrid";
            this.customerDataGrid.Size = new System.Drawing.Size(547, 159);
            this.customerDataGrid.TabIndex = 26;
            this.customerDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerDataGrid_CellClick);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 76;
            this.label6.Text = "Vade:";
            // 
            // creditAmountTB
            // 
            this.creditAmountTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditAmountTB.Location = new System.Drawing.Point(152, 48);
            this.creditAmountTB.Name = "creditAmountTB";
            this.creditAmountTB.ReadOnly = true;
            this.creditAmountTB.Size = new System.Drawing.Size(102, 26);
            this.creditAmountTB.TabIndex = 74;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 20);
            this.label9.TabIndex = 75;
            this.label9.Text = "Kredi Tutarı(TL):";
            // 
            // expirationTB
            // 
            this.expirationTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expirationTB.Location = new System.Drawing.Point(152, 80);
            this.expirationTB.Name = "expirationTB";
            this.expirationTB.ReadOnly = true;
            this.expirationTB.Size = new System.Drawing.Size(102, 26);
            this.expirationTB.TabIndex = 77;
            // 
            // krediTalepleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(796, 475);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.customerDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "krediTalepleri";
            this.Text = "krediTalepleri";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancelCredit;
        private System.Windows.Forms.Button btnConfirmCredit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CustomerIdTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView customerDataGrid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox creditAmountTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox expirationTB;
    }
}