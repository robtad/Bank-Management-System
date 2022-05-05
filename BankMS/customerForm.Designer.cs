namespace BankMS
{
    partial class customerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customerForm));
            this.sidePanel = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.btnGonder = new System.Windows.Forms.Button();
            this.btnAylikOzet = new System.Windows.Forms.Button();
            this.btnHesapAc = new System.Windows.Forms.Button();
            this.btnKrediTaleb = new System.Windows.Forms.Button();
            this.btnYatirCek = new System.Windows.Forms.Button();
            this.btnBilgiGuncelle = new System.Windows.Forms.Button();
            this.bankLogo = new System.Windows.Forms.PictureBox();
            this.centerPanel = new System.Windows.Forms.Panel();
            this.sidePanel.SuspendLayout();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bankLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(190)))));
            this.sidePanel.Controls.Add(this.btnLogout);
            this.sidePanel.Controls.Add(this.label2);
            this.sidePanel.Controls.Add(this.menuPanel);
            this.sidePanel.Controls.Add(this.bankLogo);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(215, 508);
            this.sidePanel.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(190)))));
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.Image = global::BankMS.Properties.Resources.goBackIcon;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(93, 277);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(116, 35);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "LOG OUT";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 474);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "COMMERCIAL BANK";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.btnGonder);
            this.menuPanel.Controls.Add(this.btnAylikOzet);
            this.menuPanel.Controls.Add(this.btnHesapAc);
            this.menuPanel.Controls.Add(this.btnKrediTaleb);
            this.menuPanel.Controls.Add(this.btnYatirCek);
            this.menuPanel.Controls.Add(this.btnBilgiGuncelle);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(215, 271);
            this.menuPanel.TabIndex = 9;
            // 
            // btnGonder
            // 
            this.btnGonder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(190)))));
            this.btnGonder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGonder.FlatAppearance.BorderSize = 0;
            this.btnGonder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGonder.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGonder.ForeColor = System.Drawing.Color.Black;
            this.btnGonder.Image = global::BankMS.Properties.Resources.moneyTransferIcon1;
            this.btnGonder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGonder.Location = new System.Drawing.Point(0, 41);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(214, 35);
            this.btnGonder.TabIndex = 1;
            this.btnGonder.Text = "PARA GÖNDER";
            this.btnGonder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGonder.UseVisualStyleBackColor = false;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // btnAylikOzet
            // 
            this.btnAylikOzet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(190)))));
            this.btnAylikOzet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAylikOzet.FlatAppearance.BorderSize = 0;
            this.btnAylikOzet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAylikOzet.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAylikOzet.ForeColor = System.Drawing.Color.Black;
            this.btnAylikOzet.Image = global::BankMS.Properties.Resources.summaryOverviewIcon1;
            this.btnAylikOzet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAylikOzet.Location = new System.Drawing.Point(3, 164);
            this.btnAylikOzet.Name = "btnAylikOzet";
            this.btnAylikOzet.Size = new System.Drawing.Size(214, 35);
            this.btnAylikOzet.TabIndex = 8;
            this.btnAylikOzet.Text = "AYLIK ÖZETİ GÖRÜNTÜLE";
            this.btnAylikOzet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAylikOzet.UseVisualStyleBackColor = false;
            this.btnAylikOzet.Click += new System.EventHandler(this.btnAylikOzet_Click);
            // 
            // btnHesapAc
            // 
            this.btnHesapAc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(190)))));
            this.btnHesapAc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHesapAc.FlatAppearance.BorderSize = 0;
            this.btnHesapAc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHesapAc.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHesapAc.ForeColor = System.Drawing.Color.Black;
            this.btnHesapAc.Image = global::BankMS.Properties.Resources.openAccountIcon1;
            this.btnHesapAc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHesapAc.Location = new System.Drawing.Point(3, 82);
            this.btnHesapAc.Name = "btnHesapAc";
            this.btnHesapAc.Size = new System.Drawing.Size(214, 35);
            this.btnHesapAc.TabIndex = 4;
            this.btnHesapAc.Text = "HESAP TALEPLERİM";
            this.btnHesapAc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHesapAc.UseVisualStyleBackColor = false;
            this.btnHesapAc.Click += new System.EventHandler(this.btnHesapTalepleri_Click);
            // 
            // btnKrediTaleb
            // 
            this.btnKrediTaleb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(190)))));
            this.btnKrediTaleb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKrediTaleb.FlatAppearance.BorderSize = 0;
            this.btnKrediTaleb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKrediTaleb.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKrediTaleb.ForeColor = System.Drawing.Color.Black;
            this.btnKrediTaleb.Image = global::BankMS.Properties.Resources.creditIcon;
            this.btnKrediTaleb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKrediTaleb.Location = new System.Drawing.Point(3, 123);
            this.btnKrediTaleb.Name = "btnKrediTaleb";
            this.btnKrediTaleb.Size = new System.Drawing.Size(214, 35);
            this.btnKrediTaleb.TabIndex = 2;
            this.btnKrediTaleb.Text = "KREDİ İŞLEMLERİ";
            this.btnKrediTaleb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKrediTaleb.UseVisualStyleBackColor = false;
            this.btnKrediTaleb.Click += new System.EventHandler(this.btnKrediIslemleri_Click);
            // 
            // btnYatirCek
            // 
            this.btnYatirCek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(190)))));
            this.btnYatirCek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnYatirCek.FlatAppearance.BorderSize = 0;
            this.btnYatirCek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYatirCek.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYatirCek.ForeColor = System.Drawing.Color.Black;
            this.btnYatirCek.Image = global::BankMS.Properties.Resources.depositCashIcon2;
            this.btnYatirCek.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYatirCek.Location = new System.Drawing.Point(0, 0);
            this.btnYatirCek.Name = "btnYatirCek";
            this.btnYatirCek.Size = new System.Drawing.Size(214, 35);
            this.btnYatirCek.TabIndex = 5;
            this.btnYatirCek.Text = "PARA [ YATIR | ÇEK ]";
            this.btnYatirCek.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYatirCek.UseVisualStyleBackColor = false;
            this.btnYatirCek.Click += new System.EventHandler(this.btnYatirCek_Click);
            // 
            // btnBilgiGuncelle
            // 
            this.btnBilgiGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(190)))));
            this.btnBilgiGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBilgiGuncelle.FlatAppearance.BorderSize = 0;
            this.btnBilgiGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBilgiGuncelle.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBilgiGuncelle.ForeColor = System.Drawing.Color.Black;
            this.btnBilgiGuncelle.Image = global::BankMS.Properties.Resources.updateInfoIcon1;
            this.btnBilgiGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBilgiGuncelle.Location = new System.Drawing.Point(3, 205);
            this.btnBilgiGuncelle.Name = "btnBilgiGuncelle";
            this.btnBilgiGuncelle.Size = new System.Drawing.Size(214, 35);
            this.btnBilgiGuncelle.TabIndex = 7;
            this.btnBilgiGuncelle.Text = "BİLGİLERİMİ GÜNCELLE";
            this.btnBilgiGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBilgiGuncelle.UseVisualStyleBackColor = false;
            this.btnBilgiGuncelle.Click += new System.EventHandler(this.btnBilgiGuncelle_Click);
            // 
            // bankLogo
            // 
            this.bankLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bankLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bankLogo.Image = ((System.Drawing.Image)(resources.GetObject("bankLogo.Image")));
            this.bankLogo.Location = new System.Drawing.Point(67, 398);
            this.bankLogo.Name = "bankLogo";
            this.bankLogo.Size = new System.Drawing.Size(74, 73);
            this.bankLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bankLogo.TabIndex = 2;
            this.bankLogo.TabStop = false;
            // 
            // centerPanel
            // 
            this.centerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerPanel.Location = new System.Drawing.Point(215, 0);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(617, 508);
            this.centerPanel.TabIndex = 1;
            // 
            // customerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(832, 508);
            this.Controls.Add(this.centerPanel);
            this.Controls.Add(this.sidePanel);
            this.Name = "customerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COMMERCIAL BANK [CUSTOMER]";
            this.sidePanel.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bankLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.Button btnKrediTaleb;
        private System.Windows.Forms.Button btnHesapSil;
        private System.Windows.Forms.Button btnHesapAc;
        private System.Windows.Forms.Button btnYatirCek;
        private System.Windows.Forms.Button btnBilgiGuncelle;
        private System.Windows.Forms.Button btnAylikOzet;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox bankLogo;
        private System.Windows.Forms.Panel centerPanel;
        private System.Windows.Forms.Button btnLogout;
    }
}