namespace BankMS.tellerChildForm
{
    partial class taleplerForm
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
            this.customerDataGrid2 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.customerDataGrid = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancelNewAcc = new System.Windows.Forms.Button();
            this.btnConfirmNewAcc = new System.Windows.Forms.Button();
            this.CurrencyTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CustomerIdNewTB = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConfirmDeleteAcc = new System.Windows.Forms.Button();
            this.AccountNoTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CustomerIdDeleteTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerDataGrid2
            // 
            this.customerDataGrid2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerDataGrid2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerDataGrid2.BackgroundColor = System.Drawing.Color.White;
            this.customerDataGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGrid2.Location = new System.Drawing.Point(451, 268);
            this.customerDataGrid2.Name = "customerDataGrid2";
            this.customerDataGrid2.Size = new System.Drawing.Size(361, 159);
            this.customerDataGrid2.TabIndex = 20;
            this.customerDataGrid2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerDataGrid2_CellClick);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(446, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(400, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "MEVCÜT HESAP SİLME TALEBİLERİ";
            // 
            // customerDataGrid
            // 
            this.customerDataGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.customerDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGrid.Location = new System.Drawing.Point(55, 268);
            this.customerDataGrid.Name = "customerDataGrid";
            this.customerDataGrid.Size = new System.Drawing.Size(361, 159);
            this.customerDataGrid.TabIndex = 23;
            this.customerDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerDataGrid_CellClick);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(355, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "YENİ HESAP AÇMA TALEBİLERİ";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.btnCancelNewAcc);
            this.panel2.Controls.Add(this.btnConfirmNewAcc);
            this.panel2.Controls.Add(this.CurrencyTB);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.CustomerIdNewTB);
            this.panel2.Location = new System.Drawing.Point(55, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(361, 171);
            this.panel2.TabIndex = 25;
            // 
            // btnCancelNewAcc
            // 
            this.btnCancelNewAcc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelNewAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(190)))));
            this.btnCancelNewAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelNewAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelNewAcc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelNewAcc.ForeColor = System.Drawing.Color.Black;
            this.btnCancelNewAcc.Location = new System.Drawing.Point(215, 101);
            this.btnCancelNewAcc.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelNewAcc.Name = "btnCancelNewAcc";
            this.btnCancelNewAcc.Size = new System.Drawing.Size(75, 35);
            this.btnCancelNewAcc.TabIndex = 73;
            this.btnCancelNewAcc.Text = "Iptal Et";
            this.btnCancelNewAcc.UseVisualStyleBackColor = false;
            this.btnCancelNewAcc.Click += new System.EventHandler(this.btnCancelNewAcc_Click);
            // 
            // btnConfirmNewAcc
            // 
            this.btnConfirmNewAcc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConfirmNewAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(190)))));
            this.btnConfirmNewAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmNewAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmNewAcc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmNewAcc.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmNewAcc.Location = new System.Drawing.Point(132, 101);
            this.btnConfirmNewAcc.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmNewAcc.Name = "btnConfirmNewAcc";
            this.btnConfirmNewAcc.Size = new System.Drawing.Size(75, 35);
            this.btnConfirmNewAcc.TabIndex = 66;
            this.btnConfirmNewAcc.Text = "Onayla";
            this.btnConfirmNewAcc.UseVisualStyleBackColor = false;
            this.btnConfirmNewAcc.Click += new System.EventHandler(this.btnConfirmNewAcc_Click);
            // 
            // CurrencyTB
            // 
            this.CurrencyTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrencyTB.Location = new System.Drawing.Point(132, 56);
            this.CurrencyTB.Name = "CurrencyTB";
            this.CurrencyTB.ReadOnly = true;
            this.CurrencyTB.Size = new System.Drawing.Size(158, 26);
            this.CurrencyTB.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 70;
            this.label2.Text = "Hesap Turu:";
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
            // CustomerIdNewTB
            // 
            this.CustomerIdNewTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerIdNewTB.Location = new System.Drawing.Point(132, 15);
            this.CustomerIdNewTB.Name = "CustomerIdNewTB";
            this.CustomerIdNewTB.ReadOnly = true;
            this.CustomerIdNewTB.Size = new System.Drawing.Size(158, 26);
            this.CustomerIdNewTB.TabIndex = 67;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.btnConfirmDeleteAcc);
            this.panel1.Controls.Add(this.AccountNoTB);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.CustomerIdDeleteTB);
            this.panel1.Location = new System.Drawing.Point(451, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 171);
            this.panel1.TabIndex = 26;
            // 
            // btnConfirmDeleteAcc
            // 
            this.btnConfirmDeleteAcc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConfirmDeleteAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(190)))));
            this.btnConfirmDeleteAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmDeleteAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmDeleteAcc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmDeleteAcc.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmDeleteAcc.Location = new System.Drawing.Point(215, 101);
            this.btnConfirmDeleteAcc.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmDeleteAcc.Name = "btnConfirmDeleteAcc";
            this.btnConfirmDeleteAcc.Size = new System.Drawing.Size(75, 35);
            this.btnConfirmDeleteAcc.TabIndex = 73;
            this.btnConfirmDeleteAcc.Text = "Onayla";
            this.btnConfirmDeleteAcc.UseVisualStyleBackColor = false;
            this.btnConfirmDeleteAcc.Click += new System.EventHandler(this.btnConfirmDeleteAcc_Click);
            // 
            // AccountNoTB
            // 
            this.AccountNoTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountNoTB.Location = new System.Drawing.Point(132, 56);
            this.AccountNoTB.Name = "AccountNoTB";
            this.AccountNoTB.ReadOnly = true;
            this.AccountNoTB.Size = new System.Drawing.Size(158, 26);
            this.AccountNoTB.TabIndex = 71;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 70;
            this.label6.Text = "Hesap No:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 20);
            this.label7.TabIndex = 69;
            this.label7.Text = "Musteri TCKN:";
            // 
            // CustomerIdDeleteTB
            // 
            this.CustomerIdDeleteTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerIdDeleteTB.Location = new System.Drawing.Point(132, 15);
            this.CustomerIdDeleteTB.Name = "CustomerIdDeleteTB";
            this.CustomerIdDeleteTB.ReadOnly = true;
            this.CustomerIdDeleteTB.Size = new System.Drawing.Size(158, 26);
            this.CustomerIdDeleteTB.TabIndex = 67;
            // 
            // taleplerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 510);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.customerDataGrid);
            this.Controls.Add(this.customerDataGrid2);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "taleplerForm";
            this.Text = "taleplerForm";
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView customerDataGrid2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView customerDataGrid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancelNewAcc;
        private System.Windows.Forms.Button btnConfirmNewAcc;
        private System.Windows.Forms.TextBox CurrencyTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CustomerIdNewTB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnConfirmDeleteAcc;
        private System.Windows.Forms.TextBox AccountNoTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CustomerIdDeleteTB;
    }
}