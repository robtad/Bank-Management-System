namespace BankMS
{
    partial class managerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(managerForm));
            this.label2 = new System.Windows.Forms.Label();
            this.panelTopLogo = new System.Windows.Forms.Panel();
            this.bankLogo = new System.Windows.Forms.PictureBox();
            this.panelBankaSubmenu = new System.Windows.Forms.Panel();
            this.btnTarih = new System.Windows.Forms.Button();
            this.btnDoviz = new System.Windows.Forms.Button();
            this.btnKrediIslem = new System.Windows.Forms.Button();
            this.btnIslemKaydi = new System.Windows.Forms.Button();
            this.btnGenelDurum = new System.Windows.Forms.Button();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMusteriler = new System.Windows.Forms.Button();
            this.btnTemsilciler = new System.Windows.Forms.Button();
            this.btnBankaIslemleri = new System.Windows.Forms.Button();
            this.btnAnaSayfa = new System.Windows.Forms.Button();
            this.panelSideMenuBottom = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.panelTopLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bankLogo)).BeginInit();
            this.panelBankaSubmenu.SuspendLayout();
            this.panelSideMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelSideMenuBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "COMMERCIAL BANK";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTopLogo
            // 
            this.panelTopLogo.Controls.Add(this.bankLogo);
            this.panelTopLogo.Controls.Add(this.label2);
            this.panelTopLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopLogo.Location = new System.Drawing.Point(0, 0);
            this.panelTopLogo.Name = "panelTopLogo";
            this.panelTopLogo.Size = new System.Drawing.Size(239, 178);
            this.panelTopLogo.TabIndex = 15;
            // 
            // bankLogo
            // 
            this.bankLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bankLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bankLogo.Image = ((System.Drawing.Image)(resources.GetObject("bankLogo.Image")));
            this.bankLogo.Location = new System.Drawing.Point(84, 37);
            this.bankLogo.Name = "bankLogo";
            this.bankLogo.Size = new System.Drawing.Size(74, 73);
            this.bankLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bankLogo.TabIndex = 2;
            this.bankLogo.TabStop = false;
            // 
            // panelBankaSubmenu
            // 
            this.panelBankaSubmenu.Controls.Add(this.btnTarih);
            this.panelBankaSubmenu.Controls.Add(this.btnDoviz);
            this.panelBankaSubmenu.Controls.Add(this.btnKrediIslem);
            this.panelBankaSubmenu.Controls.Add(this.btnIslemKaydi);
            this.panelBankaSubmenu.Controls.Add(this.btnGenelDurum);
            this.panelBankaSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBankaSubmenu.Location = new System.Drawing.Point(0, 70);
            this.panelBankaSubmenu.MinimumSize = new System.Drawing.Size(221, 180);
            this.panelBankaSubmenu.Name = "panelBankaSubmenu";
            this.panelBankaSubmenu.Size = new System.Drawing.Size(222, 180);
            this.panelBankaSubmenu.TabIndex = 16;
            // 
            // btnTarih
            // 
            this.btnTarih.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(150)))));
            this.btnTarih.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTarih.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTarih.FlatAppearance.BorderSize = 0;
            this.btnTarih.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTarih.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTarih.ForeColor = System.Drawing.Color.Black;
            this.btnTarih.Image = global::BankMS.Properties.Resources.depositCashIcon2;
            this.btnTarih.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTarih.Location = new System.Drawing.Point(0, 140);
            this.btnTarih.Name = "btnTarih";
            this.btnTarih.Size = new System.Drawing.Size(222, 35);
            this.btnTarih.TabIndex = 10;
            this.btnTarih.Text = "BANKA TARİHİ";
            this.btnTarih.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTarih.UseVisualStyleBackColor = false;
            this.btnTarih.Click += new System.EventHandler(this.btnTarih_Click);
            // 
            // btnDoviz
            // 
            this.btnDoviz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(150)))));
            this.btnDoviz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDoviz.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoviz.FlatAppearance.BorderSize = 0;
            this.btnDoviz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoviz.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoviz.ForeColor = System.Drawing.Color.Black;
            this.btnDoviz.Image = global::BankMS.Properties.Resources.depositCashIcon2;
            this.btnDoviz.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoviz.Location = new System.Drawing.Point(0, 105);
            this.btnDoviz.Name = "btnDoviz";
            this.btnDoviz.Size = new System.Drawing.Size(222, 35);
            this.btnDoviz.TabIndex = 9;
            this.btnDoviz.Text = "DÖVİZ";
            this.btnDoviz.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDoviz.UseVisualStyleBackColor = false;
            this.btnDoviz.Click += new System.EventHandler(this.btnDoviz_Click);
            // 
            // btnKrediIslem
            // 
            this.btnKrediIslem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(150)))));
            this.btnKrediIslem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKrediIslem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKrediIslem.FlatAppearance.BorderSize = 0;
            this.btnKrediIslem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKrediIslem.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKrediIslem.ForeColor = System.Drawing.Color.Black;
            this.btnKrediIslem.Image = global::BankMS.Properties.Resources.depositCashIcon2;
            this.btnKrediIslem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKrediIslem.Location = new System.Drawing.Point(0, 70);
            this.btnKrediIslem.Name = "btnKrediIslem";
            this.btnKrediIslem.Size = new System.Drawing.Size(222, 35);
            this.btnKrediIslem.TabIndex = 8;
            this.btnKrediIslem.Text = "KREDİ İŞLEMLERİ";
            this.btnKrediIslem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKrediIslem.UseVisualStyleBackColor = false;
            this.btnKrediIslem.Click += new System.EventHandler(this.btnKrediIslem_Click);
            // 
            // btnIslemKaydi
            // 
            this.btnIslemKaydi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(150)))));
            this.btnIslemKaydi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIslemKaydi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIslemKaydi.FlatAppearance.BorderSize = 0;
            this.btnIslemKaydi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIslemKaydi.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIslemKaydi.ForeColor = System.Drawing.Color.Black;
            this.btnIslemKaydi.Image = global::BankMS.Properties.Resources.depositCashIcon2;
            this.btnIslemKaydi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIslemKaydi.Location = new System.Drawing.Point(0, 35);
            this.btnIslemKaydi.Name = "btnIslemKaydi";
            this.btnIslemKaydi.Size = new System.Drawing.Size(222, 35);
            this.btnIslemKaydi.TabIndex = 7;
            this.btnIslemKaydi.Text = "İŞLEM KAYDI";
            this.btnIslemKaydi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIslemKaydi.UseVisualStyleBackColor = false;
            this.btnIslemKaydi.Click += new System.EventHandler(this.btnIslemKaydi_Click);
            // 
            // btnGenelDurum
            // 
            this.btnGenelDurum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(150)))));
            this.btnGenelDurum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGenelDurum.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGenelDurum.FlatAppearance.BorderSize = 0;
            this.btnGenelDurum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenelDurum.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenelDurum.ForeColor = System.Drawing.Color.Black;
            this.btnGenelDurum.Image = global::BankMS.Properties.Resources.depositCashIcon2;
            this.btnGenelDurum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenelDurum.Location = new System.Drawing.Point(0, 0);
            this.btnGenelDurum.Name = "btnGenelDurum";
            this.btnGenelDurum.Size = new System.Drawing.Size(222, 35);
            this.btnGenelDurum.TabIndex = 6;
            this.btnGenelDurum.Text = "GENEL DURUMU";
            this.btnGenelDurum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenelDurum.UseVisualStyleBackColor = false;
            this.btnGenelDurum.Click += new System.EventHandler(this.btnGenelDurum_Click);
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(190)))));
            this.panelSideMenu.Controls.Add(this.panel1);
            this.panelSideMenu.Controls.Add(this.panelSideMenuBottom);
            this.panelSideMenu.Controls.Add(this.panelTopLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(239, 516);
            this.panelSideMenu.TabIndex = 14;
            //this.panelSideMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSideMenu_Paint);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.btnMusteriler);
            this.panel1.Controls.Add(this.btnTemsilciler);
            this.panel1.Controls.Add(this.panelBankaSubmenu);
            this.panel1.Controls.Add(this.btnBankaIslemleri);
            this.panel1.Controls.Add(this.btnAnaSayfa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 248);
            this.panel1.TabIndex = 21;
            // 
            // btnMusteriler
            // 
            this.btnMusteriler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(190)))));
            this.btnMusteriler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMusteriler.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMusteriler.FlatAppearance.BorderSize = 0;
            this.btnMusteriler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusteriler.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMusteriler.ForeColor = System.Drawing.Color.Black;
            this.btnMusteriler.Image = global::BankMS.Properties.Resources.depositCashIcon2;
            this.btnMusteriler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusteriler.Location = new System.Drawing.Point(0, 285);
            this.btnMusteriler.Name = "btnMusteriler";
            this.btnMusteriler.Size = new System.Drawing.Size(222, 35);
            this.btnMusteriler.TabIndex = 19;
            this.btnMusteriler.Text = "MÜŞTERİLER";
            this.btnMusteriler.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMusteriler.UseVisualStyleBackColor = false;
            this.btnMusteriler.Click += new System.EventHandler(this.btnMusteriler_Click);
            // 
            // btnTemsilciler
            // 
            this.btnTemsilciler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(190)))));
            this.btnTemsilciler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTemsilciler.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTemsilciler.FlatAppearance.BorderSize = 0;
            this.btnTemsilciler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemsilciler.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemsilciler.ForeColor = System.Drawing.Color.Black;
            this.btnTemsilciler.Image = global::BankMS.Properties.Resources.depositCashIcon2;
            this.btnTemsilciler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTemsilciler.Location = new System.Drawing.Point(0, 250);
            this.btnTemsilciler.Name = "btnTemsilciler";
            this.btnTemsilciler.Size = new System.Drawing.Size(222, 35);
            this.btnTemsilciler.TabIndex = 18;
            this.btnTemsilciler.Text = "TEMSİLCİLER";
            this.btnTemsilciler.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTemsilciler.UseVisualStyleBackColor = false;
            this.btnTemsilciler.Click += new System.EventHandler(this.btnTemsilciler_Click);
            // 
            // btnBankaIslemleri
            // 
            this.btnBankaIslemleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(190)))));
            this.btnBankaIslemleri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBankaIslemleri.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBankaIslemleri.FlatAppearance.BorderSize = 0;
            this.btnBankaIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBankaIslemleri.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBankaIslemleri.ForeColor = System.Drawing.Color.Black;
            this.btnBankaIslemleri.Image = global::BankMS.Properties.Resources.depositCashIcon2;
            this.btnBankaIslemleri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBankaIslemleri.Location = new System.Drawing.Point(0, 35);
            this.btnBankaIslemleri.Name = "btnBankaIslemleri";
            this.btnBankaIslemleri.Size = new System.Drawing.Size(222, 35);
            this.btnBankaIslemleri.TabIndex = 17;
            this.btnBankaIslemleri.Text = "BANKA İŞLEMLERİ";
            this.btnBankaIslemleri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBankaIslemleri.UseVisualStyleBackColor = false;
            this.btnBankaIslemleri.Click += new System.EventHandler(this.btnBankaIslemleri_Click);
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(190)))));
            this.btnAnaSayfa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAnaSayfa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnaSayfa.FlatAppearance.BorderSize = 0;
            this.btnAnaSayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnaSayfa.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnaSayfa.ForeColor = System.Drawing.Color.Black;
            this.btnAnaSayfa.Image = global::BankMS.Properties.Resources.depositCashIcon2;
            this.btnAnaSayfa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnaSayfa.Location = new System.Drawing.Point(0, 0);
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.Size = new System.Drawing.Size(222, 35);
            this.btnAnaSayfa.TabIndex = 16;
            this.btnAnaSayfa.Text = "ANA SAYFA";
            this.btnAnaSayfa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnaSayfa.UseVisualStyleBackColor = false;
            // 
            // panelSideMenuBottom
            // 
            this.panelSideMenuBottom.Controls.Add(this.btnLogout);
            this.panelSideMenuBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSideMenuBottom.Location = new System.Drawing.Point(0, 447);
            this.panelSideMenuBottom.Name = "panelSideMenuBottom";
            this.panelSideMenuBottom.Size = new System.Drawing.Size(239, 69);
            this.panelSideMenuBottom.TabIndex = 20;
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
            this.btnLogout.Location = new System.Drawing.Point(57, 23);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(116, 35);
            this.btnLogout.TabIndex = 19;
            this.btnLogout.Text = "LOG OUT";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panelCenter
            // 
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(239, 0);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(659, 516);
            this.panelCenter.TabIndex = 15;
            // 
            // managerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(898, 516);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelSideMenu);
            this.Name = "managerForm";
            this.Text = "manager";
            this.Load += new System.EventHandler(this.managerForm_Load);
            this.panelTopLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bankLogo)).EndInit();
            this.panelBankaSubmenu.ResumeLayout(false);
            this.panelSideMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelSideMenuBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox bankLogo;
        private System.Windows.Forms.Panel panelTopLogo;
        private System.Windows.Forms.Panel panelBankaSubmenu;
        private System.Windows.Forms.Button btnTarih;
        private System.Windows.Forms.Button btnDoviz;
        private System.Windows.Forms.Button btnKrediIslem;
        private System.Windows.Forms.Button btnIslemKaydi;
        private System.Windows.Forms.Button btnGenelDurum;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panelSideMenuBottom;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMusteriler;
        private System.Windows.Forms.Button btnTemsilciler;
        private System.Windows.Forms.Button btnBankaIslemleri;
        private System.Windows.Forms.Button btnAnaSayfa;
    }
}