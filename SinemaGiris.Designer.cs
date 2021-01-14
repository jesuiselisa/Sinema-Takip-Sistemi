namespace Sinema
{
    partial class SinemaGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SinemaGiris));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.personellerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salonlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salonBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salonEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biletlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biletListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biletAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKullaniciAd = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Crimson;
            this.menuStrip1.Enabled = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personellerToolStripMenuItem,
            this.filmlerToolStripMenuItem,
            this.salonlarToolStripMenuItem,
            this.biletlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(632, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // personellerToolStripMenuItem
            // 
            this.personellerToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.personellerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelListesiToolStripMenuItem,
            this.personelEkleToolStripMenuItem});
            this.personellerToolStripMenuItem.ForeColor = System.Drawing.Color.Crimson;
            this.personellerToolStripMenuItem.Name = "personellerToolStripMenuItem";
            this.personellerToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.personellerToolStripMenuItem.Text = "Personeller";
            // 
            // personelListesiToolStripMenuItem
            // 
            this.personelListesiToolStripMenuItem.ForeColor = System.Drawing.Color.Crimson;
            this.personelListesiToolStripMenuItem.Name = "personelListesiToolStripMenuItem";
            this.personelListesiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.personelListesiToolStripMenuItem.Text = "Personel Listesi";
            this.personelListesiToolStripMenuItem.Click += new System.EventHandler(this.personelListesiToolStripMenuItem_Click);
            // 
            // personelEkleToolStripMenuItem
            // 
            this.personelEkleToolStripMenuItem.ForeColor = System.Drawing.Color.Crimson;
            this.personelEkleToolStripMenuItem.Name = "personelEkleToolStripMenuItem";
            this.personelEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.personelEkleToolStripMenuItem.Text = "Personel Ekle";
            this.personelEkleToolStripMenuItem.Click += new System.EventHandler(this.personelEkleToolStripMenuItem_Click);
            // 
            // filmlerToolStripMenuItem
            // 
            this.filmlerToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.filmlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filmListesiToolStripMenuItem,
            this.filmEkleToolStripMenuItem});
            this.filmlerToolStripMenuItem.ForeColor = System.Drawing.Color.Crimson;
            this.filmlerToolStripMenuItem.Name = "filmlerToolStripMenuItem";
            this.filmlerToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.filmlerToolStripMenuItem.Text = "Filmler";
            // 
            // filmListesiToolStripMenuItem
            // 
            this.filmListesiToolStripMenuItem.ForeColor = System.Drawing.Color.Crimson;
            this.filmListesiToolStripMenuItem.Name = "filmListesiToolStripMenuItem";
            this.filmListesiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.filmListesiToolStripMenuItem.Text = "Film Listesi";
            this.filmListesiToolStripMenuItem.Click += new System.EventHandler(this.filmListesiToolStripMenuItem_Click);
            // 
            // filmEkleToolStripMenuItem
            // 
            this.filmEkleToolStripMenuItem.ForeColor = System.Drawing.Color.Crimson;
            this.filmEkleToolStripMenuItem.Name = "filmEkleToolStripMenuItem";
            this.filmEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.filmEkleToolStripMenuItem.Text = "Film Ekle";
            this.filmEkleToolStripMenuItem.Click += new System.EventHandler(this.filmEkleToolStripMenuItem_Click);
            // 
            // salonlarToolStripMenuItem
            // 
            this.salonlarToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.salonlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salonBilgileriToolStripMenuItem,
            this.salonEkleToolStripMenuItem});
            this.salonlarToolStripMenuItem.ForeColor = System.Drawing.Color.Crimson;
            this.salonlarToolStripMenuItem.Name = "salonlarToolStripMenuItem";
            this.salonlarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.salonlarToolStripMenuItem.Text = "Salonlar";
            // 
            // salonBilgileriToolStripMenuItem
            // 
            this.salonBilgileriToolStripMenuItem.ForeColor = System.Drawing.Color.Crimson;
            this.salonBilgileriToolStripMenuItem.Name = "salonBilgileriToolStripMenuItem";
            this.salonBilgileriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salonBilgileriToolStripMenuItem.Text = "Salon Bilgileri";
            this.salonBilgileriToolStripMenuItem.Click += new System.EventHandler(this.salonBilgileriToolStripMenuItem_Click);
            // 
            // salonEkleToolStripMenuItem
            // 
            this.salonEkleToolStripMenuItem.ForeColor = System.Drawing.Color.Crimson;
            this.salonEkleToolStripMenuItem.Name = "salonEkleToolStripMenuItem";
            this.salonEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salonEkleToolStripMenuItem.Text = "Salon Ekle";
            // 
            // biletlerToolStripMenuItem
            // 
            this.biletlerToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.biletlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.biletListesiToolStripMenuItem,
            this.biletAlToolStripMenuItem});
            this.biletlerToolStripMenuItem.ForeColor = System.Drawing.Color.Crimson;
            this.biletlerToolStripMenuItem.Name = "biletlerToolStripMenuItem";
            this.biletlerToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.biletlerToolStripMenuItem.Text = "Biletler";
            // 
            // biletListesiToolStripMenuItem
            // 
            this.biletListesiToolStripMenuItem.ForeColor = System.Drawing.Color.Crimson;
            this.biletListesiToolStripMenuItem.Name = "biletListesiToolStripMenuItem";
            this.biletListesiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.biletListesiToolStripMenuItem.Text = "Bilet Listesi";
            this.biletListesiToolStripMenuItem.Click += new System.EventHandler(this.biletListesiToolStripMenuItem_Click);
            // 
            // biletAlToolStripMenuItem
            // 
            this.biletAlToolStripMenuItem.ForeColor = System.Drawing.Color.Crimson;
            this.biletAlToolStripMenuItem.Name = "biletAlToolStripMenuItem";
            this.biletAlToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.biletAlToolStripMenuItem.Text = "Bilet Al";
            this.biletAlToolStripMenuItem.Click += new System.EventHandler(this.biletAlToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.txtSifre);
            this.groupBox1.Controls.Add(this.btnGiris);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtKullaniciAd);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox1.Location = new System.Drawing.Point(0, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(632, 428);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş Sistemi";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(232, 190);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(278, 25);
            this.txtSifre.TabIndex = 6;
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.Crimson;
            this.btnGiris.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGiris.Location = new System.Drawing.Point(232, 243);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(278, 32);
            this.btnGiris.TabIndex = 5;
            this.btnGiris.Text = "GİRİŞ";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Crimson;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(171, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Crimson;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(127, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı: ";
            // 
            // txtKullaniciAd
            // 
            this.txtKullaniciAd.Location = new System.Drawing.Point(232, 132);
            this.txtKullaniciAd.Name = "txtKullaniciAd";
            this.txtKullaniciAd.Size = new System.Drawing.Size(278, 25);
            this.txtKullaniciAd.TabIndex = 0;
            // 
            // SinemaGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 428);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "SinemaGiris";
            this.Text = "SinemaGiris";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personellerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salonlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biletlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biletListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biletAlToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKullaniciAd;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.ToolStripMenuItem salonBilgileriToolStripMenuItem;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.ToolStripMenuItem salonEkleToolStripMenuItem;
    }
}



