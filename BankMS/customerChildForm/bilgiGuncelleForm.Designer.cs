﻿namespace BankMS.customerChildForm
{
    partial class bilgiGuncelleForm
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
            this.pnlCheckBalance = new System.Windows.Forms.Panel();
            this.newAccCustomerIdTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.customerPasswordTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.newAccTellerIdTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.newAccAddressTB = new System.Windows.Forms.TextBox();
            this.newAccGenderCB = new System.Windows.Forms.ComboBox();
            this.newAccPhoneTB = new System.Windows.Forms.TextBox();
            this.newAccDatePicker = new System.Windows.Forms.DateTimePicker();
            this.newAccNameTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.customerDataGrid = new System.Windows.Forms.DataGridView();
            this.userIdlbl = new System.Windows.Forms.Label();
            this.pnlCheckBalance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(377, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "BİLGİLERİNİZİ GÜNCELLEYİN";
            // 
            // pnlCheckBalance
            // 
            this.pnlCheckBalance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlCheckBalance.Controls.Add(this.newAccCustomerIdTB);
            this.pnlCheckBalance.Controls.Add(this.label4);
            this.pnlCheckBalance.Controls.Add(this.btnEditCustomer);
            this.pnlCheckBalance.Controls.Add(this.customerPasswordTB);
            this.pnlCheckBalance.Controls.Add(this.label3);
            this.pnlCheckBalance.Controls.Add(this.newAccTellerIdTB);
            this.pnlCheckBalance.Controls.Add(this.label2);
            this.pnlCheckBalance.Controls.Add(this.newAccAddressTB);
            this.pnlCheckBalance.Controls.Add(this.newAccGenderCB);
            this.pnlCheckBalance.Controls.Add(this.newAccPhoneTB);
            this.pnlCheckBalance.Controls.Add(this.newAccDatePicker);
            this.pnlCheckBalance.Controls.Add(this.newAccNameTB);
            this.pnlCheckBalance.Controls.Add(this.label6);
            this.pnlCheckBalance.Controls.Add(this.label17);
            this.pnlCheckBalance.Controls.Add(this.label15);
            this.pnlCheckBalance.Controls.Add(this.label9);
            this.pnlCheckBalance.Controls.Add(this.label7);
            this.pnlCheckBalance.Location = new System.Drawing.Point(121, 52);
            this.pnlCheckBalance.Name = "pnlCheckBalance";
            this.pnlCheckBalance.Size = new System.Drawing.Size(797, 226);
            this.pnlCheckBalance.TabIndex = 16;
            // 
            // newAccCustomerIdTB
            // 
            this.newAccCustomerIdTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newAccCustomerIdTB.Location = new System.Drawing.Point(26, 135);
            this.newAccCustomerIdTB.Name = "newAccCustomerIdTB";
            this.newAccCustomerIdTB.Size = new System.Drawing.Size(177, 26);
            this.newAccCustomerIdTB.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 54;
            this.label4.Text = "TC Kimlik:";
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEditCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(190)))));
            this.btnEditCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCustomer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCustomer.ForeColor = System.Drawing.Color.Black;
            this.btnEditCustomer.Location = new System.Drawing.Point(614, 181);
            this.btnEditCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(88, 35);
            this.btnEditCustomer.TabIndex = 49;
            this.btnEditCustomer.Text = "Düzenle";
            this.btnEditCustomer.UseVisualStyleBackColor = false;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // customerPasswordTB
            // 
            this.customerPasswordTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerPasswordTB.Location = new System.Drawing.Point(26, 181);
            this.customerPasswordTB.Name = "customerPasswordTB";
            this.customerPasswordTB.Size = new System.Drawing.Size(177, 26);
            this.customerPasswordTB.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 52;
            this.label3.Text = "Şifre:";
            // 
            // newAccTellerIdTB
            // 
            this.newAccTellerIdTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newAccTellerIdTB.Location = new System.Drawing.Point(26, 83);
            this.newAccTellerIdTB.Name = "newAccTellerIdTB";
            this.newAccTellerIdTB.Size = new System.Drawing.Size(177, 26);
            this.newAccTellerIdTB.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Temsilci Id:";
            // 
            // newAccAddressTB
            // 
            this.newAccAddressTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newAccAddressTB.Location = new System.Drawing.Point(233, 135);
            this.newAccAddressTB.Multiline = true;
            this.newAccAddressTB.Name = "newAccAddressTB";
            this.newAccAddressTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.newAccAddressTB.Size = new System.Drawing.Size(220, 72);
            this.newAccAddressTB.TabIndex = 45;
            // 
            // newAccGenderCB
            // 
            this.newAccGenderCB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newAccGenderCB.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newAccGenderCB.ForeColor = System.Drawing.Color.Black;
            this.newAccGenderCB.FormattingEnabled = true;
            this.newAccGenderCB.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.newAccGenderCB.Location = new System.Drawing.Point(233, 34);
            this.newAccGenderCB.Name = "newAccGenderCB";
            this.newAccGenderCB.Size = new System.Drawing.Size(220, 25);
            this.newAccGenderCB.TabIndex = 44;
            this.newAccGenderCB.Text = "Cinsiyet Seç";
            // 
            // newAccPhoneTB
            // 
            this.newAccPhoneTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newAccPhoneTB.Location = new System.Drawing.Point(233, 83);
            this.newAccPhoneTB.Name = "newAccPhoneTB";
            this.newAccPhoneTB.Size = new System.Drawing.Size(220, 26);
            this.newAccPhoneTB.TabIndex = 42;
            // 
            // newAccDatePicker
            // 
            this.newAccDatePicker.CustomFormat = "";
            this.newAccDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newAccDatePicker.Location = new System.Drawing.Point(482, 32);
            this.newAccDatePicker.Name = "newAccDatePicker";
            this.newAccDatePicker.Size = new System.Drawing.Size(220, 22);
            this.newAccDatePicker.TabIndex = 39;
            // 
            // newAccNameTB
            // 
            this.newAccNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newAccNameTB.Location = new System.Drawing.Point(26, 31);
            this.newAccNameTB.Name = "newAccNameTB";
            this.newAccNameTB.Size = new System.Drawing.Size(177, 26);
            this.newAccNameTB.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(478, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Tarih:";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(229, 8);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 20);
            this.label17.TabIndex = 34;
            this.label17.Text = "Cinsiyet:";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(229, 60);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 20);
            this.label15.TabIndex = 35;
            this.label15.Text = "Telefon:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(229, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 20);
            this.label9.TabIndex = 36;
            this.label9.Text = "Adres:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 38;
            this.label7.Text = "Ad-Soyad:";
            // 
            // customerDataGrid
            // 
            this.customerDataGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.customerDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGrid.Location = new System.Drawing.Point(31, 289);
            this.customerDataGrid.Name = "customerDataGrid";
            this.customerDataGrid.Size = new System.Drawing.Size(1023, 158);
            this.customerDataGrid.TabIndex = 17;
            this.customerDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerDataGrid_CellContentClick);
            // 
            // userIdlbl
            // 
            this.userIdlbl.AutoSize = true;
            this.userIdlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIdlbl.Location = new System.Drawing.Point(960, 52);
            this.userIdlbl.Name = "userIdlbl";
            this.userIdlbl.Size = new System.Drawing.Size(46, 18);
            this.userIdlbl.TabIndex = 55;
            this.userIdlbl.Text = "label5";
            // 
            // bilgiGuncelleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1072, 533);
            this.Controls.Add(this.userIdlbl);
            this.Controls.Add(this.customerDataGrid);
            this.Controls.Add(this.pnlCheckBalance);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "bilgiGuncelleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "bilgiGuncelle";
            this.pnlCheckBalance.ResumeLayout(false);
            this.pnlCheckBalance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlCheckBalance;
        private System.Windows.Forms.TextBox newAccCustomerIdTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.TextBox customerPasswordTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newAccTellerIdTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newAccAddressTB;
        private System.Windows.Forms.ComboBox newAccGenderCB;
        private System.Windows.Forms.TextBox newAccPhoneTB;
        private System.Windows.Forms.DateTimePicker newAccDatePicker;
        private System.Windows.Forms.TextBox newAccNameTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView customerDataGrid;
        private System.Windows.Forms.Label userIdlbl;
    }
}