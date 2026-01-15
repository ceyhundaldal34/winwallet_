using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace Windows_Wallet__Final_Ödevi_
{
    public partial class TradePage : UserControl
    {
        // --- DEĞİŞKENLER ---
        private enum ParaBirimi { Dolar, Euro, Sterlin, Altin }
        private ParaBirimi _seciliBirim = ParaBirimi.Dolar;

        // UI Elemanları (Sınıf seviyesinde tanımladık ki her yerden erişelim)
        private Label _lblKurBilgi;
        private Label _lblVarlikBilgi;
        private TextBox _txtMiktar;
        private Label _lblBaslik;    // Başlık
        private Label _lblMiktar;    // "İşlem Miktarı" yazısı
        private Button _btnDolar, _btnEuro, _btnSterlin, _btnAltin;
        private Button _btnAl, _btnSat;

        // Paneller
        private Panel _mainPanel;
        private Panel _pnlTabs;    // Üst butonların paneli
        private Panel _pnlContent; // Orta içerik paneli

        public TradePage()
        {
            InitializeComponent();
            this.Load += TradePage_Load;
            this.Resize += (s, e) => { HizalamayiGuncelle(); }; // Ekran boyutu değişince çalışır
        }

        private void TradePage_Load(object sender, EventArgs e)
        {
            KurlariTCMBdenGuncelle();
            ArayuzOlustur();
            BirimGuncelle(ParaBirimi.Dolar);
            HizalamayiGuncelle(); // Açılışta hizala
        }

        private void KurlariTCMBdenGuncelle()
        {
            try
            {
                string tcmbUrl = "https://www.tcmb.gov.tr/kurlar/today.xml";
                var xmlDoc = new XmlDocument();
                xmlDoc.Load(tcmbUrl);

                string dolarSatis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/ForexSelling").InnerXml;
                VeriDeposu.AnlikDolarKuru = Convert.ToDouble(dolarSatis.Replace('.', ','));

                string euroSatis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/ForexSelling").InnerXml;
                VeriDeposu.AnlikEuroKuru = Convert.ToDouble(euroSatis.Replace('.', ','));

                string sterlinSatis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/ForexSelling").InnerXml;
                VeriDeposu.AnlikSterlinKuru = Convert.ToDouble(sterlinSatis.Replace('.', ','));

                VeriDeposu.AnlikAltinKuru = VeriDeposu.AnlikDolarKuru * 147.8;
            }
            catch { }
        }

        private void ArayuzOlustur()
        {
            this.Controls.Clear();
            this.Dock = DockStyle.Fill;
            this.BackColor = Color.White;

            // ANA PANEL
            _mainPanel = new Panel();
            _mainPanel.Dock = DockStyle.Fill;
            _mainPanel.Padding = new Padding(50);
            this.Controls.Add(_mainPanel);

            // 1. ÜST BUTONLAR PANELİ (FlowLayout DEĞİL, Normal Panel yaptık ki ortalayabilelim)
            _pnlTabs = new Panel();
            _pnlTabs.Dock = DockStyle.Top;
            _pnlTabs.Height = 80;
            _mainPanel.Controls.Add(_pnlTabs);

            // Butonları oluştur
            _btnDolar = TabButonuUret("USD - Dolar");
            _btnEuro = TabButonuUret("EUR - Euro");
            _btnSterlin = TabButonuUret("GBP - Sterlin");
            _btnAltin = TabButonuUret("GAU - Altın");

            _btnDolar.Click += (s, e) => BirimGuncelle(ParaBirimi.Dolar);
            _btnEuro.Click += (s, e) => BirimGuncelle(ParaBirimi.Euro);
            _btnSterlin.Click += (s, e) => BirimGuncelle(ParaBirimi.Sterlin);
            _btnAltin.Click += (s, e) => BirimGuncelle(ParaBirimi.Altin);

            _pnlTabs.Controls.Add(_btnDolar);
            _pnlTabs.Controls.Add(_btnEuro);
            _pnlTabs.Controls.Add(_btnSterlin);
            _pnlTabs.Controls.Add(_btnAltin);

            // 2. İÇERİK PANELİ
            _pnlContent = new Panel();
            _pnlContent.Dock = DockStyle.Fill;
            _pnlContent.Padding = new Padding(0, 30, 0, 0);
            _mainPanel.Controls.Add(_pnlContent);
            _pnlContent.BringToFront();

            // --- ELEMANLARI OLUŞTUR (Konumlarını HizalamayiGuncelle() içinde vereceğiz) ---

            _lblBaslik = new Label();
            _lblBaslik.Text = "Döviz ve Altın Al/Sat İşlemleri";
            _lblBaslik.Font = new Font("Segoe UI", 22, FontStyle.Bold);
            _lblBaslik.ForeColor = Color.FromArgb(33, 37, 41);
            _lblBaslik.AutoSize = false;
            _lblBaslik.Size = new Size(600, 50);
            _lblBaslik.TextAlign = ContentAlignment.MiddleCenter;
            _pnlContent.Controls.Add(_lblBaslik);

            _lblKurBilgi = new Label();
            _lblKurBilgi.Text = "...";
            _lblKurBilgi.Font = new Font("Segoe UI", 36, FontStyle.Bold);
            _lblKurBilgi.ForeColor = Color.FromArgb(44, 62, 80);
            _lblKurBilgi.AutoSize = false;
            _lblKurBilgi.Size = new Size(600, 80);
            _lblKurBilgi.TextAlign = ContentAlignment.MiddleCenter;
            _pnlContent.Controls.Add(_lblKurBilgi);

            _lblVarlikBilgi = new Label();
            _lblVarlikBilgi.Text = "...";
            _lblVarlikBilgi.Font = new Font("Segoe UI", 12);
            _lblVarlikBilgi.ForeColor = Color.Gray;
            _lblVarlikBilgi.AutoSize = false;
            _lblVarlikBilgi.Size = new Size(600, 30);
            _lblVarlikBilgi.TextAlign = ContentAlignment.MiddleCenter;
            _pnlContent.Controls.Add(_lblVarlikBilgi);

            _lblMiktar = new Label();
            _lblMiktar.Text = "İşlem Miktarı (Birim):";
            _lblMiktar.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            _lblMiktar.ForeColor = Color.Gray;
            _lblMiktar.AutoSize = true;
            _pnlContent.Controls.Add(_lblMiktar);

            _txtMiktar = new TextBox();
            _txtMiktar.Size = new Size(300, 40);
            _txtMiktar.Font = new Font("Segoe UI", 16);
            _txtMiktar.TextAlign = HorizontalAlignment.Center;
            _txtMiktar.KeyPress += (s, e) => { if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',') e.Handled = true; };
            _pnlContent.Controls.Add(_txtMiktar);

            _btnAl = new Button { Text = "AL (Buy)", BackColor = Color.SeaGreen, ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Size = new Size(145, 50), Font = new Font("Segoe UI", 12, FontStyle.Bold), Cursor = Cursors.Hand };
            _btnAl.FlatAppearance.BorderSize = 0;
            _btnAl.Click += BtnAl_Click;
            _pnlContent.Controls.Add(_btnAl);

            _btnSat = new Button { Text = "SAT (Sell)", BackColor = Color.IndianRed, ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Size = new Size(145, 50), Font = new Font("Segoe UI", 12, FontStyle.Bold), Cursor = Cursors.Hand };
            _btnSat.FlatAppearance.BorderSize = 0;
            _btnSat.Click += BtnSat_Click;
            _pnlContent.Controls.Add(_btnSat);
        }

        // --- KRİTİK NOKTA: HİZALAMA FONKSİYONU ---
        private void HizalamayiGuncelle()
        {
            if (_mainPanel == null || this.Width == 0) return;

            // 1. ÜST BUTONLARI ORTALA
            int btnWidth = 120;
            int gap = 15;
            int totalBtnWidth = (btnWidth * 4) + (gap * 3);
            int startX_Tabs = (_pnlTabs.Width - totalBtnWidth) / 2; // Tam orta noktayı bul

            _btnDolar.Location = new Point(startX_Tabs, 15);
            _btnEuro.Location = new Point(startX_Tabs + btnWidth + gap, 15);
            _btnSterlin.Location = new Point(startX_Tabs + (btnWidth + gap) * 2, 15);
            _btnAltin.Location = new Point(startX_Tabs + (btnWidth + gap) * 3, 15);

            // 2. ORTA İÇERİĞİ ORTALA (İstediğin gibi HAFİF SOLA Kaydırarak)
            int shiftLeft = 20; // Sola kaydırma miktarı (Piksel)
            int centerX = (_pnlContent.Width / 2) - shiftLeft; // Merkez noktasını biraz sola çektik

            // Başlık, Kur ve Varlık (Genişlikleri 600 olduğu için yarısını çıkarıp ortalıyoruz)
            _lblBaslik.Location = new Point(centerX - (600 / 2), 20);
            _lblKurBilgi.Location = new Point(centerX - (600 / 2), 90);
            _lblVarlikBilgi.Location = new Point(centerX - (600 / 2), 170);

            // Input Kutusu ve Butonlar (Genişlikleri 300 olduğu için yarısını çıkarıyoruz)
            int inputHalf = 300 / 2;
            _lblMiktar.Location = new Point(centerX - inputHalf, 220);
            _txtMiktar.Location = new Point(centerX - inputHalf, 245);
            _btnAl.Location = new Point(centerX - inputHalf, 300);
            _btnSat.Location = new Point(centerX - inputHalf + 155, 300); // Sat butonu sağa
        }

        private void BirimGuncelle(ParaBirimi birim)
        {
            _seciliBirim = birim;
            ResetTabs();

            double kur = 0;
            double cüzdan = 0;
            string simge = "";

            switch (birim)
            {
                case ParaBirimi.Dolar:
                    HighlightTab(_btnDolar);
                    kur = VeriDeposu.AnlikDolarKuru;
                    cüzdan = VeriDeposu.DolarBakiyesi;
                    simge = "$";
                    _lblKurBilgi.Text = $"1 USD = {kur:N2} ₺";
                    break;
                case ParaBirimi.Euro:
                    HighlightTab(_btnEuro);
                    kur = VeriDeposu.AnlikEuroKuru;
                    cüzdan = VeriDeposu.EuroBakiyesi;
                    simge = "€";
                    _lblKurBilgi.Text = $"1 EUR = {kur:N2} ₺";
                    break;
                case ParaBirimi.Sterlin:
                    HighlightTab(_btnSterlin);
                    kur = VeriDeposu.AnlikSterlinKuru;
                    cüzdan = VeriDeposu.SterlinBakiyesi;
                    simge = "£";
                    _lblKurBilgi.Text = $"1 GBP = {kur:N2} ₺";
                    break;
                case ParaBirimi.Altin:
                    HighlightTab(_btnAltin);
                    kur = VeriDeposu.AnlikAltinKuru;
                    cüzdan = VeriDeposu.AltinBakiyesi;
                    simge = "Gr";
                    _lblKurBilgi.Text = $"1 Gr Altın = {kur:N2} ₺";
                    break;
            }
            _lblVarlikBilgi.Text = $"Mevcut Varlık: {cüzdan:N2} {simge}";
        }

        private void BtnAl_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(_txtMiktar.Text, out double miktar) || miktar <= 0) { MessageBox.Show("Geçerli miktar girin."); return; }

            double kur = GetCurrentRate();
            double toplamTutarTL = miktar * kur;

            if (VeriDeposu.ToplamBakiye < toplamTutarTL)
            {
                MessageBox.Show("Yetersiz TL Bakiyesi!");
                return;
            }

            VeriDeposu.ToplamBakiye -= toplamTutarTL;

            string birimAd = "";
            switch (_seciliBirim)
            {
                case ParaBirimi.Dolar: VeriDeposu.DolarBakiyesi += miktar; birimAd = "Dolar"; break;
                case ParaBirimi.Euro: VeriDeposu.EuroBakiyesi += miktar; birimAd = "Euro"; break;
                case ParaBirimi.Sterlin: VeriDeposu.SterlinBakiyesi += miktar; birimAd = "Sterlin"; break;
                case ParaBirimi.Altin: VeriDeposu.AltinBakiyesi += miktar; birimAd = "Altın"; break;
            }

            int newId = (VeriDeposu.Islemler.Count > 0) ? VeriDeposu.Islemler.Max(x => x.Id) + 1 : 1;
            VeriDeposu.Islemler.Add(new Gider
            {
                Id = newId,
                Baslik = $"{birimAd} Alımı",
                Tutar = toplamTutarTL,
                Tarih = DateTime.Now,
                HarcamaKategorisi = "Yatırım"
            });

            MessageBox.Show($"{miktar} birim {birimAd} alındı.");
            BirimGuncelle(_seciliBirim);
            _txtMiktar.Clear();
        }

        private void BtnSat_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(_txtMiktar.Text, out double miktar) || miktar <= 0) { MessageBox.Show("Geçerli miktar girin."); return; }

            double kur = GetCurrentRate();
            double toplamTutarTL = miktar * kur;
            double mevcutVarlik = 0;
            string birimAd = "";

            switch (_seciliBirim)
            {
                case ParaBirimi.Dolar: mevcutVarlik = VeriDeposu.DolarBakiyesi; birimAd = "Dolar"; break;
                case ParaBirimi.Euro: mevcutVarlik = VeriDeposu.EuroBakiyesi; birimAd = "Euro"; break;
                case ParaBirimi.Sterlin: mevcutVarlik = VeriDeposu.SterlinBakiyesi; birimAd = "Sterlin"; break;
                case ParaBirimi.Altin: mevcutVarlik = VeriDeposu.AltinBakiyesi; birimAd = "Altın"; break;
            }

            if (mevcutVarlik < miktar)
            {
                MessageBox.Show($"Yetersiz {birimAd} bakiyesi!");
                return;
            }

            VeriDeposu.ToplamBakiye += toplamTutarTL;

            switch (_seciliBirim)
            {
                case ParaBirimi.Dolar: VeriDeposu.DolarBakiyesi -= miktar; break;
                case ParaBirimi.Euro: VeriDeposu.EuroBakiyesi -= miktar; break;
                case ParaBirimi.Sterlin: VeriDeposu.SterlinBakiyesi -= miktar; break;
                case ParaBirimi.Altin: VeriDeposu.AltinBakiyesi -= miktar; break;
            }

            int newId = (VeriDeposu.Islemler.Count > 0) ? VeriDeposu.Islemler.Max(x => x.Id) + 1 : 1;
            VeriDeposu.Islemler.Add(new Gelir
            {
                Id = newId,
                Baslik = $"{birimAd} Satışı",
                Tutar = toplamTutarTL,
                Tarih = DateTime.Now,
                GelirKategorisi = "Yatırım"
            });

            MessageBox.Show($"{miktar} birim {birimAd} satıldı.");
            BirimGuncelle(_seciliBirim);
            _txtMiktar.Clear();
        }

        private double GetCurrentRate()
        {
            switch (_seciliBirim)
            {
                case ParaBirimi.Dolar: return VeriDeposu.AnlikDolarKuru;
                case ParaBirimi.Euro: return VeriDeposu.AnlikEuroKuru;
                case ParaBirimi.Sterlin: return VeriDeposu.AnlikSterlinKuru;
                case ParaBirimi.Altin: return VeriDeposu.AnlikAltinKuru;
                default: return 0;
            }
        }

        private Button TabButonuUret(string text)
        {
            Button btn = new Button();
            btn.Text = text;
            btn.Size = new Size(120, 45);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.BorderColor = Color.LightGray;
            btn.BackColor = Color.White;
            btn.ForeColor = Color.Gray;
            btn.Cursor = Cursors.Hand;
            return btn;
        }

        private void ResetTabs()
        {
            foreach (Control c in _pnlTabs.Controls)
            {
                if (c is Button b)
                {
                    b.BackColor = Color.White;
                    b.ForeColor = Color.Gray;
                }
            }
        }

        private void HighlightTab(Button btn)
        {
            btn.BackColor = Color.FromArgb(235, 245, 255);
            btn.ForeColor = Color.FromArgb(0, 100, 200);
        }
    }
}