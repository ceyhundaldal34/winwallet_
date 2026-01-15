using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Windows_Wallet__Final_Ödevi_
{
    public partial class TransactionsPage : UserControl
    {
        private TableLayoutPanel _mainLayout;
        private FlowLayoutPanel _listePanel;
        private List<Button> _navButtons = new List<Button>();

        public TransactionsPage()
        {
            InitializeComponent();
            this.Load += TransactionsPage_Load;
            this.Resize += (s, e) => { TabloyuHizala(); };
        }

        private void TransactionsPage_Load(object sender, EventArgs e)
        {
            // 1. VERİ KONTROLÜ
            if (VeriDeposu.Islemler == null) VeriDeposu.Islemler = new List<Islem>();
            if (VeriDeposu.Islemler.Count == 0)
            {
                VeriDeposu.BaslangicVerileriniYukle(); // Varsa metodunu çağır, yoksa manuel ekle
                if (VeriDeposu.Islemler.Count == 0)
                {
                    VeriDeposu.Islemler.Add(new Gelir { Id = 1, Baslik = "Freelance Web Projesi", Tutar = 5000, Tarih = DateTime.Now, GelirKategorisi = "Freelance" });
                    VeriDeposu.Islemler.Add(new Gider { Id = 2, Baslik = "Market Alışverişi", Tutar = 450, Tarih = DateTime.Now.AddDays(-1), HarcamaKategorisi = "Gıda" });
                    VeriDeposu.ToplamBakiye = 5000 - 450;
                }
            }

            // 2. SAYFA TEMİZLİĞİ
            this.Controls.Clear();
            this.Dock = DockStyle.Fill;
            this.BackColor = Color.White;
            this.Padding = new Padding(20);

            // 3. İSKELETİ KUR
            _mainLayout = new TableLayoutPanel();
            _mainLayout.Dock = DockStyle.Fill;
            _mainLayout.RowCount = 3;
            _mainLayout.ColumnCount = 1;
            _mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            _mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            _mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.Controls.Add(_mainLayout);

            // RAF 1: HEADER
            Panel pnlHeader = new Panel();
            pnlHeader.Dock = DockStyle.Fill;
            pnlHeader.BackColor = Color.White;
            _mainLayout.Controls.Add(pnlHeader, 0, 0);

            Label lblBaslik = new Label();
            lblBaslik.Text = "Cüzdan Hareketleri";
            lblBaslik.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            lblBaslik.ForeColor = Color.FromArgb(33, 37, 41);
            lblBaslik.AutoSize = true;
            lblBaslik.Location = new Point(0, 20);
            pnlHeader.Controls.Add(lblBaslik);

            // SAĞDAKİ BUTON GRUBU
            Panel pnlButonlar = new Panel();
            pnlButonlar.Size = new Size(420, 50);
            pnlButonlar.Dock = DockStyle.Right;
            pnlHeader.Controls.Add(pnlButonlar);

            TableLayoutPanel tblBtn = new TableLayoutPanel();
            tblBtn.Dock = DockStyle.Fill;
            tblBtn.RowCount = 1;
            tblBtn.ColumnCount = 4;
            tblBtn.Padding = new Padding(0, 10, 0, 0);
            pnlButonlar.Controls.Add(tblBtn);

            _navButtons.Clear();

            // 1. SÜTUN: EKLE BUTONU
            tblBtn.Controls.Add(EkleButonu(), 0, 0);

            // 2, 3, 4. SÜTUNLAR: FİLTRE BUTONLARI
            tblBtn.Controls.Add(NavButonu("Tümü", 0), 1, 0);
            tblBtn.Controls.Add(NavButonu("Gelirler", 1), 2, 0);
            tblBtn.Controls.Add(NavButonu("Giderler", 2), 3, 0);

            NavGuncelle(_navButtons[0]);

            // RAF 2: SÜTUN BAŞLIKLARI (DÜZENLENDİ: 5 SÜTUN)
            TableLayoutPanel pnlTitles = new TableLayoutPanel();
            pnlTitles.Dock = DockStyle.Fill;
            pnlTitles.BackColor = Color.FromArgb(248, 249, 250);
            pnlTitles.RowCount = 1;

            // --- DEĞİŞİKLİK BURADA: SÜTUN SAYISI 5 OLDU ---
            pnlTitles.ColumnCount = 5;
            pnlTitles.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));  // İkon
            pnlTitles.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));  // Bilgi
            pnlTitles.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F)); // Tutar
            pnlTitles.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));  // PDF (YENİ)
            pnlTitles.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));  // Sil
            _mainLayout.Controls.Add(pnlTitles, 0, 1);

            pnlTitles.Controls.Add(HeaderLabel("DURUM"), 0, 0);
            pnlTitles.Controls.Add(HeaderLabel("AÇIKLAMA / TARİH"), 1, 0);
            pnlTitles.Controls.Add(HeaderLabel("TUTAR"), 2, 0);
            pnlTitles.Controls.Add(HeaderLabel("PDF"), 3, 0); // Başlık Eklendi
            pnlTitles.Controls.Add(HeaderLabel("SİL"), 4, 0);

            // RAF 3: LİSTE
            _listePanel = new FlowLayoutPanel();
            _listePanel.Dock = DockStyle.Fill;
            _listePanel.AutoScroll = true;
            _listePanel.FlowDirection = FlowDirection.TopDown;
            _listePanel.WrapContents = false;
            _listePanel.BackColor = Color.White;
            _mainLayout.Controls.Add(_listePanel, 0, 2);

            ListeyiYukle(0);
        }

        private void ListeyiYukle(int mod)
        {
            if (_listePanel == null) return;
            _listePanel.Controls.Clear();
            _listePanel.SuspendLayout();

            var hamListe = VeriDeposu.Islemler.OrderByDescending(x => x.Id).ToList();
            var liste = hamListe;
            if (mod == 1) liste = hamListe.Where(x => x is Gelir).ToList();
            if (mod == 2) liste = hamListe.Where(x => x is Gider).ToList();

            if (liste.Count == 0)
            {
                Label lbl = new Label { Text = "Kayıt Yok", ForeColor = Color.Silver, Font = new Font("Segoe UI", 12), Margin = new Padding(20), AutoSize = true };
                _listePanel.Controls.Add(lbl);
            }

            foreach (var islem in liste)
            {
                Panel row = new Panel();
                row.Height = 70;
                row.Width = _listePanel.ClientSize.Width - 20;
                row.BackColor = Color.White;
                row.Margin = new Padding(0);

                TableLayoutPanel innerGrid = new TableLayoutPanel();
                innerGrid.Dock = DockStyle.Fill;
                innerGrid.RowCount = 1;

                // --- DEĞİŞİKLİK: 5 SÜTUNLU YAPI ---
                innerGrid.ColumnCount = 5;
                innerGrid.BackColor = Color.Transparent;

                // Sütun Genişlikleri (Başlıkla aynı olmalı)
                innerGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));  // İkon
                innerGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));  // Bilgi
                innerGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F)); // Tutar
                innerGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));  // PDF
                innerGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));  // Sil

                row.Controls.Add(innerGrid);

                // 1. SÜTUN: İKON (●)
                Label lblIcon = new Label();
                lblIcon.Text = "●";
                lblIcon.Dock = DockStyle.Fill;
                lblIcon.TextAlign = ContentAlignment.TopCenter;
                lblIcon.Padding = new Padding(0, 13, 0, 0);
                lblIcon.Font = new Font("Segoe UI", 16);
                lblIcon.ForeColor = (islem is Gelir) ? Color.SeaGreen : Color.IndianRed;
                innerGrid.Controls.Add(lblIcon, 0, 0);

                // 2. SÜTUN: BİLGİ
                Panel pnlInfo = new Panel { Dock = DockStyle.Fill, Padding = new Padding(0, 12, 0, 0) };
                Label lblAd = new Label { Text = islem.Baslik, AutoSize = true, Dock = DockStyle.Top, Font = new Font("Segoe UI", 10, FontStyle.Bold), ForeColor = Color.FromArgb(64, 64, 64) };

                string kat = "Genel";
                if (islem is Gelir gelir) kat = gelir.GelirKategorisi;
                else if (islem is Gider gider) kat = gider.HarcamaKategorisi;

                Label lblTarih = new Label { Text = $"{islem.Tarih:dd.MM.yyyy} • {kat}", AutoSize = true, Dock = DockStyle.Top, Font = new Font("Segoe UI", 8), ForeColor = Color.Gray };
                pnlInfo.Controls.Add(lblTarih);
                pnlInfo.Controls.Add(lblAd);
                innerGrid.Controls.Add(pnlInfo, 1, 0);

                // 3. SÜTUN: TUTAR
                Label lblTutar = new Label();
                lblTutar.Text = (islem is Gelir ? "+ " : "- ") + $"{islem.Tutar:N0} ₺";
                lblTutar.Dock = DockStyle.Fill;
                lblTutar.AutoSize = false;
                lblTutar.TextAlign = ContentAlignment.TopRight;
                lblTutar.Padding = new Padding(0, 22, 0, 0);
                lblTutar.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                lblTutar.ForeColor = (islem is Gelir) ? Color.SeaGreen : Color.IndianRed;
                innerGrid.Controls.Add(lblTutar, 2, 0);

                // --- 4. SÜTUN: DEKONT / PDF BUTONU ---
                Button btnPdf = new Button();
                btnPdf.Text = "📄";
                btnPdf.FlatStyle = FlatStyle.Flat;
                btnPdf.FlatAppearance.BorderSize = 0;
                btnPdf.Cursor = Cursors.Hand;
                btnPdf.ForeColor = Color.Gray;
                btnPdf.Font = new Font("Segoe UI", 12);
                btnPdf.Dock = DockStyle.Fill;

                // DÜZELTME 1: Yazıyı butonun içinde yukarı hizala
                btnPdf.TextAlign = ContentAlignment.TopCenter;

                // DÜZELTME 2: Üstten boşluğu azalttık (13'tü, 8 yaptık. Daha da yukarı istersen 5 yap)
                btnPdf.Margin = new Padding(0, 18, 0, 0);

                btnPdf.Click += (s, e) =>
                {
                    DekontYoneticisi.DekontOlustur(islem);
                };
                innerGrid.Controls.Add(btnPdf, 3, 0);


                // --- 5. SÜTUN: SİL BUTONU ---
                Button btnSil = new Button { Text = "🗑️", FlatStyle = FlatStyle.Flat, Cursor = Cursors.Hand, ForeColor = Color.IndianRed, Font = new Font("Segoe UI", 12) };
                btnSil.FlatAppearance.BorderSize = 0;
                btnSil.Dock = DockStyle.Fill;

                // DÜZELTME 1: Yazıyı yukarı hizala
                btnSil.TextAlign = ContentAlignment.TopCenter;

                // DÜZELTME 2: PDF butonuyla aynı hizada olsun (8 yaptık)
                btnSil.Margin = new Padding(0, 18, 0, 0);

                btnSil.Click += (s, ev) => {
                    if (MessageBox.Show("Bu kaydı silmek istediğine emin misin?", "Silme Onayı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        VeriDeposu.Islemler.Remove(islem);
                        if (islem is Gelir) VeriDeposu.ToplamBakiye -= islem.Tutar;
                        else VeriDeposu.ToplamBakiye += islem.Tutar;
                        ListeyiYukle(mod);
                    }
                };
                innerGrid.Controls.Add(btnSil, 4, 0);

                Panel line = new Panel { Height = 1, Dock = DockStyle.Bottom, BackColor = Color.FromArgb(240, 240, 240) };
                row.Controls.Add(line);

                _listePanel.Controls.Add(row);
            }
            _listePanel.ResumeLayout();
        }

        private void TabloyuHizala()
        {
            if (_listePanel == null) return;
            foreach (Control c in _listePanel.Controls)
            {
                if (c is Panel p) p.Width = _listePanel.ClientSize.Width - 10;
            }
        }

        private Label HeaderLabel(string text)
        {
            return new Label { Text = text, Font = new Font("Segoe UI", 8, FontStyle.Bold), ForeColor = Color.Gray, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft };
        }

        private Button NavButonu(string text, int mod)
        {
            Button btn = new Button();
            btn.Text = text;
            btn.Dock = DockStyle.Fill;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.BorderColor = Color.LightGray;
            btn.BackColor = Color.White;
            btn.ForeColor = Color.Gray;
            btn.Cursor = Cursors.Hand;
            btn.Margin = new Padding(3, 0, 0, 0);

            btn.Click += (s, e) => {
                ListeyiYukle(mod);
                NavGuncelle(btn);
            };
            _navButtons.Add(btn);
            return btn;
        }

        private Button EkleButonu()
        {
            Button btn = new Button();
            btn.Text = "+ Ekle";
            btn.Dock = DockStyle.Fill;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Color.SeaGreen;
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;
            btn.Margin = new Padding(0, 0, 10, 0);

            btn.Click += (s, e) => {
                using (var form = new IslemEkle())
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        ListeyiYukle(0);
                    }
                }
                ListeyiYukle(0);
            };

            return btn;
        }

        private void NavGuncelle(Button aktif)
        {
            foreach (var b in _navButtons)
            {
                b.BackColor = Color.White;
                b.ForeColor = Color.Gray;
                b.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            }
            aktif.BackColor = Color.FromArgb(235, 245, 255);
            aktif.ForeColor = Color.FromArgb(0, 100, 200);
            aktif.Font = new Font("Segoe UI", 9, FontStyle.Bold);
        }
    }
}