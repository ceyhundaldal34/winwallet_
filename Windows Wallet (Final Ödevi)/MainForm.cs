using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Wallet__Final_Ödevi_
{
    public partial class MainForm : Form, IMessageFilter
    {
        // --- DEĞİŞKENLER ---
        bool sidebarExpand = false;

        // DÜZELTME 1: Genişliği 200'den 260'a çıkardık ki yazılar sığsın
        const int MaxWidth = 260;
        const int MinWidth = 70;

        string _aktifKullanici;

        public MainForm(string kullaniciAdi)
        {
            InitializeComponent();
            _aktifKullanici = kullaniciAdi;
            lblKullanici.Text = "👤 " + _aktifKullanici;

            KurulumYap();
            PageYukle(new DashboardPage());
        }

        private void KurulumYap()
        {
            lblKullanici.Cursor = Cursors.Hand;
            lblKullanici.Click += LblKullanici_Click;
            menuKullaniciDegistir.Click += (s, e) => Application.Restart();
            menuCikis.Click += (s, e) => Application.Exit();
            DovizKartlariOlustur();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            int step = 30;

            if (sidebarExpand)
            {
                // --- AÇILMA MODU ---
                pnlMenu.Width += step;

                if (pnlMenu.Width >= 100)
                {
                    ButonMetinleriniAyarla(true);
                    lblKullanici.Text = "👤  " + _aktifKullanici;
                }

                if (pnlMenu.Width >= MaxWidth)
                {
                    pnlMenu.Width = MaxWidth;
                    sidebarExpand = true;
                    btnMenu.Visible = false;
                    MenuRenkleriniGuncelle(true);
                    sidebarTimer.Stop();
                }
            }
            else
            {
                // --- KAPANMA MODU ---
                btnMenu.Visible = true;
                pnlMenu.Width -= step;

                if (pnlMenu.Width <= 100)
                {
                    ButonMetinleriniAyarla(false);
                    lblKullanici.Text = "👤";
                }

                if (pnlMenu.Width <= MinWidth)
                {
                    pnlMenu.Width = MinWidth;
                    sidebarExpand = false;
                    MenuRenkleriniGuncelle(false);
                    sidebarTimer.Stop();
                }
            }
        }

        // DÜZELTME 2: Metinleri uzun halleriyle yazdık
        private void ButonMetinleriniAyarla(bool goster)
        {
            if (goster)
            {
                AnaSayfa.Text = "      Ana Sayfa";
                Islemler.Text = "      İşlemler";
                btnTrade.Text = "      Al / Sat İşlemleri";    // Uzun isim
                btnAnaliz.Text = "      Analiz ve Raporlar";    // Uzun isim
                btnKartlarim.Text = "      Kartlarım";
                btnHedefler.Text = "      Bütçe Hedefleri";       // Uzun isim
                btnAyarlar.Text = "      Ayarlar";
            }
            else
            {
                AnaSayfa.Text = "";
                Islemler.Text = "";
                btnTrade.Text = "";
                btnAnaliz.Text = "";
                btnKartlarim.Text = "";
                btnHedefler.Text = "";
                btnAyarlar.Text = "";
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidebarExpand = true;
            sidebarTimer.Start();
        }

        public void PageYukle(UserControl page)
        {
            pnlContainer.Controls.Clear();
            page.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(page);
        }

        // --- BUTON TIKLAMALARI (GÜVENLİK EKLENDİ) ---
        // DÜZELTME 3: Her butona "if (!sidebarExpand) return;" ekledik.
        // Bu sayede menü kapalıyken tıklansa bile sayfa değişmez.

        private void AnaSayfa_Click(object sender, EventArgs e)
        {
            if (!sidebarExpand) return; // Kapalıysa işlem yapma
            PageYukle(new DashboardPage());
        }

        private void Islemler_Click(object sender, EventArgs e)
        {
            if (!sidebarExpand) return;
            PageYukle(new TransactionsPage());
        }

        private void btnTrade_Click(object sender, EventArgs e)
        {
            if (!sidebarExpand) return;
            PageYukle(new TradePage());
        }

        private void btnAnaliz_Click(object sender, EventArgs e)
        {
            if (!sidebarExpand) return;
            PageYukle(new AnalyticsPage());
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            if (!sidebarExpand) return;
            PageYukle(new SettingsPage());
        }

        private void btnHedefler_Click(object sender, EventArgs e)
        {
            if (!sidebarExpand) return;
            MessageBox.Show("Hedef modülü şu an bakım aşamasındadır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnKartlarim_Click_1(object sender, EventArgs e)
        {
            if (!sidebarExpand) return;
            MessageBox.Show("Bu modül v2.0 sürümünde yayında olacaktır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LblKullanici_Click(object sender, EventArgs e)
        {
            if (!sidebarExpand) return; // Kullanıcı adına da tıklanmasın kapalıyken
            contextMenuStrip1.Show(lblKullanici, new Point(0, lblKullanici.Height));
        }

        private void DovizKartlariOlustur() { }
        private void btnHizliGelir_Click(object sender, EventArgs e) { }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ApplyModernTheme();
            Application.AddMessageFilter(this);

            pnlMenu.Width = MinWidth;
            ButonMetinleriniAyarla(false);
            sidebarExpand = false;
            MenuRenkleriniGuncelle(false);
        }

        private void ApplyModernTheme()
        {
            this.BackColor = Color.FromArgb(24, 24, 27);
            pnlMenu.BackColor = Color.FromArgb(15, 15, 15);
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.BackColor = Color.Transparent;
            btnMenu.ForeColor = Color.White;

            StyleButton(AnaSayfa);
            StyleButton(Islemler);
            StyleButton(btnTrade);
            StyleButton(btnAnaliz);
            StyleButton(btnKartlarim);
            StyleButton(btnHedefler);
            StyleButton(btnAyarlar);
        }

        private void StyleButton(Button btn)
        {
            if (btn == null) return;

            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Color.Transparent;
            btn.ForeColor = Color.FromArgb(220, 220, 220);
            btn.Font = new Font("Segoe UI", 11, FontStyle.Regular);
            btn.Cursor = Cursors.Hand;

            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(160, 120, 60);
            btn.FlatAppearance.MouseDownBackColor = Color.Black;

            btn.ImageAlign = ContentAlignment.MiddleLeft;
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn.Padding = new Padding(10, 0, 0, 0);
        }

        private void MainForm_Click(object sender, EventArgs e)
        {
            if (sidebarExpand == true)
            {
                sidebarExpand = false;
                sidebarTimer.Start();
            }
        }

        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == 0x0201 && sidebarExpand == true)
            {
                Point mousePos = Cursor.Position;
                Rectangle menuLimit = pnlMenu.RectangleToScreen(pnlMenu.ClientRectangle);
                Rectangle btnLimit = btnMenu.RectangleToScreen(btnMenu.ClientRectangle);

                if (!menuLimit.Contains(mousePos) && !btnLimit.Contains(mousePos))
                {
                    sidebarExpand = false;
                    sidebarTimer.Start();
                }
            }
            return false;
        }

        private void MenuRenkleriniGuncelle(bool acikMi)
        {
            Color hoverRengi;
            Cursor imlecTipi;

            if (acikMi)
            {
                hoverRengi = Color.FromArgb(160, 120, 60);
                imlecTipi = Cursors.Hand;
            }
            else
            {
                hoverRengi = Color.FromArgb(15, 15, 15);
                imlecTipi = Cursors.Default;
            }

            Button[] butonlar = { AnaSayfa, Islemler, btnTrade, btnAnaliz, btnKartlarim, btnHedefler, btnAyarlar };

            foreach (var btn in butonlar)
            {
                if (btn != null)
                {
                    btn.FlatAppearance.MouseOverBackColor = hoverRengi;
                    btn.Cursor = imlecTipi;
                    btn.FlatAppearance.MouseDownBackColor = acikMi ? Color.Black : Color.FromArgb(15, 15, 15);
                }
            }
        }
    }
}