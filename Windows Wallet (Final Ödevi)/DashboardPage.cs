using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Windows_Wallet__Final_Ödevi_
{
    public partial class DashboardPage : UserControl
    {
        public DashboardPage()
        {
            InitializeComponent();
            DashboardPage_Load(this, EventArgs.Empty);
        }

        private void DashboardPage_Load(object sender, EventArgs e)
        {
            // 1. GÜVENLİK: Veri yoksa ÖRNEK VERİLERLE DOLDUR (Sunum için)
            if (VeriDeposu.Islemler.Count == 0)
            {
                VeriDeposu.BaslangicVerileriniYukle();
                
                // Eğer hala boşsa (VeriDeposu tarafı boşsa) biz dolduralım
                if (VeriDeposu.Islemler.Count == 0)
                {
                    // TL Bakiye
                    VeriDeposu.ToplamBakiye = 45000;
                    
                    // --- KARTLAR GÖRÜNSÜN DİYE BİRAZ VARLIK EKLEYELİM ---
                    VeriDeposu.DolarBakiyesi = 100; // Örn: 100 Doların var
                    VeriDeposu.AltinBakiyesi = 5;   // Örn: 5 Gram Altının var
                    // Euro ve Sterlin 0 kalsın, onların 0 olarak göründüğünü test edelim
                    // -----------------------------------------------------

                    VeriDeposu.Islemler.Add(new Gelir { Id = 1, Baslik = "Maaş Ödemesi", Tutar = 50000, Tarih = DateTime.Now.AddDays(-2), GelirKategorisi = "Maaş" });
                    VeriDeposu.Islemler.Add(new Gider { Id = 2, Baslik = "Dolar Alımı", Tutar = 3200, Tarih = DateTime.Now.AddDays(-1), HarcamaKategorisi = "Yatırım" });
                }
            }

            // 2. TASARIM
            this.Controls.Clear();
            this.Dock = DockStyle.Fill;
            this.BackColor = Color.FromArgb(245, 245, 245);
            this.Padding = new Padding(20);

            // A) BAŞLIK
            Label lblSelam = new Label();
            lblSelam.Text = $"👋 Hoşgeldin {VeriDeposu.KullaniciAdi}, Bugün durumlar nasıl?";
            lblSelam.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblSelam.ForeColor = Color.FromArgb(64, 64, 64);
            lblSelam.AutoSize = true;
            lblSelam.Location = new Point(20, 10);
            this.Controls.Add(lblSelam);

            // B) KARTLAR PANELİ
            FlowLayoutPanel pnlKartlar = new FlowLayoutPanel();
            pnlKartlar.Location = new Point(20, 50);
            pnlKartlar.Size = new Size(this.Width - 40, 140);
            pnlKartlar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlKartlar.AutoScroll = true;        
            pnlKartlar.WrapContents = false;     
            this.Controls.Add(pnlKartlar);

            // --- KART 1: TL (MAVİ) ---
            pnlKartlar.Controls.Add(KartOlustur("Toplam Bakiye", $"{VeriDeposu.ToplamBakiye:N0} ₺", Color.FromArgb(52, 152, 219)));
            
            // --- KART 2: DOLAR (YEŞİL) --- 
            // 'if' kaldırdık -> Hep görünür, 0 olsa bile.
            double dolarTl = VeriDeposu.DolarBakiyesi * VeriDeposu.AnlikDolarKuru;
            pnlKartlar.Controls.Add(KartOlustur("Dolar Varlığı", $"{VeriDeposu.DolarBakiyesi:N0} $ ({dolarTl:N0} ₺)", Color.SeaGreen));
            
            // --- KART 3: EURO (MOR) ---
            double euroTl = VeriDeposu.EuroBakiyesi * VeriDeposu.AnlikEuroKuru;
            pnlKartlar.Controls.Add(KartOlustur("Euro Varlığı", $"{VeriDeposu.EuroBakiyesi:N0} € ({euroTl:N0} ₺)", Color.FromArgb(100, 80, 200)));
            
            // --- KART 4: STERLİN (KIRMIZI/PEMBE) ---
            double sterlinTl = VeriDeposu.SterlinBakiyesi * VeriDeposu.AnlikSterlinKuru;
            pnlKartlar.Controls.Add(KartOlustur("Sterlin Varlığı", $"{VeriDeposu.SterlinBakiyesi:N0} £ ({sterlinTl:N0} ₺)", Color.FromArgb(200, 60, 90)));
            
            // --- KART 5: ALTIN (TURUNCU) ---
            double altinTl = VeriDeposu.AltinBakiyesi * VeriDeposu.AnlikAltinKuru;
            pnlKartlar.Controls.Add(KartOlustur("Altın Varlığı", $"{VeriDeposu.AltinBakiyesi:N0} Gr ({altinTl:N0} ₺)", Color.Orange));


            // C) LİSTE BAŞLIĞI
            Label lblGecmis = new Label();
            lblGecmis.Text = "Son İşlem Hareketleri";
            lblGecmis.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblGecmis.ForeColor = Color.Gray;
            lblGecmis.AutoSize = true;
            lblGecmis.Location = new Point(20, 200);
            this.Controls.Add(lblGecmis);

            // D) LİSTE PANELİ
            Panel pnlListe = new Panel();
            pnlListe.Location = new Point(20, 230);
            pnlListe.Size = new Size(this.Width - 40, this.Height - 250);
            pnlListe.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlListe.AutoScroll = true;
            this.Controls.Add(pnlListe);

            // SON 4 İŞLEM
            var sonIslemler = VeriDeposu.Islemler.OrderByDescending(x => x.Id).Take(4).ToList();
            int yPos = 0;

            foreach (var islem in sonIslemler)
            {
                Panel satir = new Panel();
                satir.Size = new Size(pnlListe.Width - 20, 60);
                satir.Location = new Point(0, yPos);
                satir.BackColor = Color.White;

                // Sol Şerit
                Panel serit = new Panel();
                serit.Width = 5;
                serit.Dock = DockStyle.Left;
                serit.BackColor = (islem is Gelir) ? Color.SeaGreen : Color.IndianRed;
                satir.Controls.Add(serit);

                // Başlık
                Label lblBaslik = new Label();
                lblBaslik.Text = islem.Baslik;
                lblBaslik.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                lblBaslik.Location = new Point(15, 10);
                lblBaslik.AutoSize = true;
                satir.Controls.Add(lblBaslik);

                // Kategori
                string kategoriAdi = "Genel"; 
                if (islem is Gelir gelirIslemi) kategoriAdi = gelirIslemi.GelirKategorisi; 
                else if (islem is Gider giderIslemi) kategoriAdi = giderIslemi.HarcamaKategorisi;

                Label lblTarih = new Label();
                lblTarih.Text = $"{islem.Tarih:dd.MM.yyyy} • {kategoriAdi}";
                lblTarih.Font = new Font("Segoe UI", 8, FontStyle.Regular);
                lblTarih.ForeColor = Color.Gray;
                lblTarih.Location = new Point(15, 35);
                lblTarih.AutoSize = true;
                satir.Controls.Add(lblTarih);

                // Tutar
                Label lblTutar = new Label();
                lblTutar.Text = (islem is Gelir ? "+ " : "- ") + $"{islem.Tutar:N0} ₺";
                lblTutar.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                lblTutar.ForeColor = (islem is Gelir) ? Color.SeaGreen : Color.IndianRed;
                lblTutar.AutoSize = true;
                lblTutar.Location = new Point(satir.Width - 150, 15);
                lblTutar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                satir.Controls.Add(lblTutar);

                try { Elips.Apply(satir, 10); } catch { }

                pnlListe.Controls.Add(satir);
                yPos += 70;
            }
        }

        private Panel KartOlustur(string baslik, string deger, Color renk)
        {
            Panel pnl = new Panel();
            pnl.Size = new Size(240, 100); 
            pnl.BackColor = renk;
            pnl.Margin = new Padding(0, 0, 15, 0);

            try { Elips.Apply(pnl, 15); } catch { }

            Label lblBaslik = new Label();
            lblBaslik.Text = baslik;
            lblBaslik.ForeColor = Color.White;
            lblBaslik.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            lblBaslik.Location = new Point(15, 15);
            lblBaslik.AutoSize = true;
            pnl.Controls.Add(lblBaslik);

            Label lblDeger = new Label();
            lblDeger.Text = deger;
            lblDeger.ForeColor = Color.White;
            lblDeger.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblDeger.Location = new Point(15, 45);
            lblDeger.AutoSize = true;
            pnl.Controls.Add(lblDeger);

            return pnl;
        }
    }
}