namespace Windows_Wallet__Final_Ödevi_
{
    partial class MainForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnAyarlar = new System.Windows.Forms.Button();
            this.btnHedefler = new System.Windows.Forms.Button();
            this.btnKartlarim = new System.Windows.Forms.Button();
            this.btnAnaliz = new System.Windows.Forms.Button();
            this.btnTrade = new System.Windows.Forms.Button();
            this.pnlKullanici = new System.Windows.Forms.Panel();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.Islemler = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.AnaSayfa = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuKullaniciDegistir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlMenu.SuspendLayout();
            this.pnlKullanici.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnlMenu.Controls.Add(this.btnAyarlar);
            this.pnlMenu.Controls.Add(this.btnHedefler);
            this.pnlMenu.Controls.Add(this.btnKartlarim);
            this.pnlMenu.Controls.Add(this.btnAnaliz);
            this.pnlMenu.Controls.Add(this.btnTrade);
            this.pnlMenu.Controls.Add(this.pnlKullanici);
            this.pnlMenu.Controls.Add(this.btnMenu);
            this.pnlMenu.Controls.Add(this.Islemler);
            this.pnlMenu.Controls.Add(this.panel1);
            this.pnlMenu.Controls.Add(this.AnaSayfa);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(242, 581);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnAyarlar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAyarlar.FlatAppearance.BorderSize = 0;
            this.btnAyarlar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(120)))), ((int)(((byte)(60)))));
            this.btnAyarlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyarlar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAyarlar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnAyarlar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyarlar.Location = new System.Drawing.Point(0, 204);
            this.btnAyarlar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAyarlar.Size = new System.Drawing.Size(242, 34);
            this.btnAyarlar.TabIndex = 7;
            this.btnAyarlar.Text = "Ayarlar";
            this.btnAyarlar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyarlar.UseVisualStyleBackColor = false;
            this.btnAyarlar.Click += new System.EventHandler(this.btnAyarlar_Click);
            // 
            // btnHedefler
            // 
            this.btnHedefler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnHedefler.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHedefler.FlatAppearance.BorderSize = 0;
            this.btnHedefler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(120)))), ((int)(((byte)(60)))));
            this.btnHedefler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHedefler.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHedefler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnHedefler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHedefler.Location = new System.Drawing.Point(0, 170);
            this.btnHedefler.Margin = new System.Windows.Forms.Padding(2);
            this.btnHedefler.Name = "btnHedefler";
            this.btnHedefler.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHedefler.Size = new System.Drawing.Size(242, 34);
            this.btnHedefler.TabIndex = 6;
            this.btnHedefler.Text = "Bütçe Hedefleri";
            this.btnHedefler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHedefler.UseVisualStyleBackColor = false;
            this.btnHedefler.Click += new System.EventHandler(this.btnHedefler_Click);
            // 
            // btnKartlarim
            // 
            this.btnKartlarim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnKartlarim.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKartlarim.FlatAppearance.BorderSize = 0;
            this.btnKartlarim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(120)))), ((int)(((byte)(60)))));
            this.btnKartlarim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKartlarim.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKartlarim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnKartlarim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKartlarim.Location = new System.Drawing.Point(0, 136);
            this.btnKartlarim.Margin = new System.Windows.Forms.Padding(2);
            this.btnKartlarim.Name = "btnKartlarim";
            this.btnKartlarim.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnKartlarim.Size = new System.Drawing.Size(242, 34);
            this.btnKartlarim.TabIndex = 5;
            this.btnKartlarim.Text = "Kartlarım";
            this.btnKartlarim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKartlarim.UseVisualStyleBackColor = false;
            this.btnKartlarim.Click += new System.EventHandler(this.btnKartlarim_Click_1);
            // 
            // btnAnaliz
            // 
            this.btnAnaliz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnAnaliz.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnaliz.FlatAppearance.BorderSize = 0;
            this.btnAnaliz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(120)))), ((int)(((byte)(60)))));
            this.btnAnaliz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnaliz.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaliz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnAnaliz.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnaliz.Location = new System.Drawing.Point(0, 102);
            this.btnAnaliz.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnaliz.Name = "btnAnaliz";
            this.btnAnaliz.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAnaliz.Size = new System.Drawing.Size(242, 34);
            this.btnAnaliz.TabIndex = 4;
            this.btnAnaliz.Text = "Analiz ve Raporlar";
            this.btnAnaliz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnaliz.UseVisualStyleBackColor = false;
            this.btnAnaliz.Click += new System.EventHandler(this.btnAnaliz_Click);
            // 
            // btnTrade
            // 
            this.btnTrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnTrade.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTrade.FlatAppearance.BorderSize = 0;
            this.btnTrade.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(120)))), ((int)(((byte)(60)))));
            this.btnTrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrade.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTrade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnTrade.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrade.Location = new System.Drawing.Point(0, 68);
            this.btnTrade.Margin = new System.Windows.Forms.Padding(2);
            this.btnTrade.Name = "btnTrade";
            this.btnTrade.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTrade.Size = new System.Drawing.Size(242, 34);
            this.btnTrade.TabIndex = 3;
            this.btnTrade.Text = "Al / Sat İşlemleri";
            this.btnTrade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrade.UseVisualStyleBackColor = false;
            this.btnTrade.Click += new System.EventHandler(this.btnTrade_Click);
            // 
            // pnlKullanici
            // 
            this.pnlKullanici.Controls.Add(this.lblKullanici);
            this.pnlKullanici.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlKullanici.Location = new System.Drawing.Point(0, 494);
            this.pnlKullanici.Name = "pnlKullanici";
            this.pnlKullanici.Size = new System.Drawing.Size(242, 38);
            this.pnlKullanici.TabIndex = 0;
            // 
            // lblKullanici
            // 
            this.lblKullanici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lblKullanici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKullanici.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanici.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(150)))), ((int)(((byte)(75)))));
            this.lblKullanici.Location = new System.Drawing.Point(0, 0);
            this.lblKullanici.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(242, 38);
            this.lblKullanici.TabIndex = 0;
            this.lblKullanici.Text = "Kullanıcı Adı";
            this.lblKullanici.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(120)))), ((int)(((byte)(60)))));
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnMenu.Location = new System.Drawing.Point(12, 5);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(35, 38);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Text = "☰";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // Islemler
            // 
            this.Islemler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Islemler.Dock = System.Windows.Forms.DockStyle.Top;
            this.Islemler.FlatAppearance.BorderSize = 0;
            this.Islemler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(120)))), ((int)(((byte)(60)))));
            this.Islemler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Islemler.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Islemler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Islemler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Islemler.Location = new System.Drawing.Point(0, 34);
            this.Islemler.Margin = new System.Windows.Forms.Padding(2);
            this.Islemler.Name = "Islemler";
            this.Islemler.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Islemler.Size = new System.Drawing.Size(242, 34);
            this.Islemler.TabIndex = 2;
            this.Islemler.Text = "Cüzdan Hareketleri";
            this.Islemler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Islemler.UseVisualStyleBackColor = false;
            this.Islemler.Click += new System.EventHandler(this.Islemler_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 532);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 49);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(150)))), ((int)(((byte)(75)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = " WIN WALLET ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AnaSayfa
            // 
            this.AnaSayfa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.AnaSayfa.Dock = System.Windows.Forms.DockStyle.Top;
            this.AnaSayfa.FlatAppearance.BorderSize = 0;
            this.AnaSayfa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(120)))), ((int)(((byte)(60)))));
            this.AnaSayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnaSayfa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AnaSayfa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.AnaSayfa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AnaSayfa.Location = new System.Drawing.Point(0, 0);
            this.AnaSayfa.Margin = new System.Windows.Forms.Padding(2);
            this.AnaSayfa.Name = "AnaSayfa";
            this.AnaSayfa.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.AnaSayfa.Size = new System.Drawing.Size(242, 34);
            this.AnaSayfa.TabIndex = 1;
            this.AnaSayfa.Text = "Ana Sayfa";
            this.AnaSayfa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AnaSayfa.UseVisualStyleBackColor = false;
            this.AnaSayfa.Click += new System.EventHandler(this.AnaSayfa_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(242, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(909, 34);
            this.pnlHeader.TabIndex = 1;
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(242, 34);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(2);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(909, 547);
            this.pnlContainer.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuKullaniciDegistir,
            this.menuCikis});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(191, 52);
            // 
            // menuKullaniciDegistir
            // 
            this.menuKullaniciDegistir.Name = "menuKullaniciDegistir";
            this.menuKullaniciDegistir.Size = new System.Drawing.Size(190, 24);
            this.menuKullaniciDegistir.Text = "Kullanıcı Değiştir";
            // 
            // menuCikis
            // 
            this.menuCikis.Name = "menuCikis";
            this.menuCikis.Size = new System.Drawing.Size(190, 24);
            this.menuCikis.Text = "Çıkış";
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 1;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1151, 581);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Click += new System.EventHandler(this.MainForm_Click);
            this.pnlMenu.ResumeLayout(false);
            this.pnlKullanici.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AnaSayfa;
        private System.Windows.Forms.Button Islemler;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuKullaniciDegistir;
        private System.Windows.Forms.ToolStripMenuItem menuCikis;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Panel pnlKullanici;
        private System.Windows.Forms.Button btnTrade;
        private System.Windows.Forms.Button btnAnaliz;
        private System.Windows.Forms.Button btnKartlarim;
        private System.Windows.Forms.Button btnAyarlar;
        private System.Windows.Forms.Button btnHedefler;
    }
}

