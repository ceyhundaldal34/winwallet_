using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Windows_Wallet__Final_Ödevi_
{
    public partial class IslemEkle : Form
    {
        public Islem YeniIslem { get; private set; }

        private Button _btnGelir, _btnGider;
        private DateTimePicker _dtpTarih;
        private TextBox _txtTutar;
        private TextBox _txtAciklama;
        private ComboBox _cmbKategori;
        private Button _btnKaydet;

        private bool _isGelir = false;

        // Kategoriler
        private string[] _gelirKategorileri = { "Maaş", "Freelance", "Satış", "Yatırım", "Harçlık", "Diğer" };
        private string[] _giderKategorileri = { "Gıda", "Ulaşım", "Eğlence", "Fatura", "Kira", "Giyim", "Sağlık", "Diğer" };

        public IslemEkle()
        {
            InitializeComponent();
            ModernArayuzOlustur();
        }

        private void ModernArayuzOlustur()
        {
            this.Controls.Clear();

            // 1. FORM AYARLARI
            this.Text = "Yeni İşlem Ekle";
            this.Size = new Size(400, 620); // Rahat sığması için biraz daha uzun
            this.BackColor = Color.White;
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // 2. TÜR SEÇİMİ (ÜST PANEL)
            Panel pnlTur = new Panel { Dock = DockStyle.Top, Height = 70, Padding = new Padding(20, 15, 20, 10) };

            _btnGelir = new Button();
            _btnGelir.Text = "GELİR";
            _btnGelir.Dock = DockStyle.Left;
            _btnGelir.Width = 175;
            _btnGelir.FlatStyle = FlatStyle.Flat;
            _btnGelir.Cursor = Cursors.Hand;
            _btnGelir.Click += (s, e) => TurDegistir(true);

            _btnGider = new Button();
            _btnGider.Text = "GİDER";
            _btnGider.Dock = DockStyle.Right;
            _btnGider.Width = 175;
            _btnGider.FlatStyle = FlatStyle.Flat;
            _btnGider.Cursor = Cursors.Hand;
            _btnGider.Click += (s, e) => TurDegistir(false);

            pnlTur.Controls.Add(_btnGelir);
            pnlTur.Controls.Add(_btnGider);
            this.Controls.Add(pnlTur);

            // 3. KAYDET BUTONU (EN ALTTA)
            _btnKaydet = new Button();
            _btnKaydet.Text = "KAYDET";
            _btnKaydet.Dock = DockStyle.Bottom;
            _btnKaydet.Height = 55;
            _btnKaydet.BackColor = Color.SeaGreen; // Başlangıç rengi
            _btnKaydet.ForeColor = Color.White;
            _btnKaydet.FlatStyle = FlatStyle.Flat;
            _btnKaydet.FlatAppearance.BorderSize = 0;
            _btnKaydet.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            _btnKaydet.Cursor = Cursors.Hand;
            _btnKaydet.Click += BtnKaydet_Click;
            this.Controls.Add(_btnKaydet);

            // 4. ORTA ALAN (INPUTLAR)
            FlowLayoutPanel pnlInput = new FlowLayoutPanel();
            pnlInput.Dock = DockStyle.Fill;
            pnlInput.Padding = new Padding(30, 10, 30, 0); // Genel boşluk
            pnlInput.FlowDirection = FlowDirection.TopDown;
            this.Controls.Add(pnlInput);

            // --- GÖRÜNMEZ YASTIK (SPACER) ---
            // Tarih yazısının butonların altında kalmasını kesin olarak engeller
            Panel pnlSpacer = new Panel { Height = 20, Width = 10, BackColor = Color.Transparent };
            pnlInput.Controls.Add(pnlSpacer);
            // --------------------------------

            // Tarih
            pnlInput.Controls.Add(LabelUret("Tarih"));
            _dtpTarih = new DateTimePicker { Width = 320, Height = 30, Font = new Font("Segoe UI", 10), Format = DateTimePickerFormat.Short };
            pnlInput.Controls.Add(_dtpTarih);

            // Tutar
            pnlInput.Controls.Add(LabelUret("Tutar (₺)"));
            _txtTutar = new TextBox { Width = 320, Font = new Font("Segoe UI", 12, FontStyle.Bold) };
            _txtTutar.KeyPress += (s, e) => { if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',') e.Handled = true; };
            pnlInput.Controls.Add(_txtTutar);

            // Kategori
            pnlInput.Controls.Add(LabelUret("Kategori"));
            _cmbKategori = new ComboBox { Width = 320, Font = new Font("Segoe UI", 10), DropDownStyle = ComboBoxStyle.DropDownList };
            pnlInput.Controls.Add(_cmbKategori);

            // Açıklama
            pnlInput.Controls.Add(LabelUret("Açıklama"));
            _txtAciklama = new TextBox { Width = 320, Height = 60, Multiline = true, Font = new Font("Segoe UI", 10) };
            pnlInput.Controls.Add(_txtAciklama);

            pnlTur.BringToFront(); // Butonlar her zaman en üstte

            // Başlangıç Ayarı
            TurDegistir(true);
        }

        private void TurDegistir(bool gelirMi)
        {
            _isGelir = gelirMi;

            // Kategori Listesini Güncelle
            _cmbKategori.Items.Clear();
            if (gelirMi)
            {
                _cmbKategori.Items.AddRange(_gelirKategorileri);
            }
            else
            {
                _cmbKategori.Items.AddRange(_giderKategorileri);
            }
            if (_cmbKategori.Items.Count > 0) _cmbKategori.SelectedIndex = 0;

            if (gelirMi)
            {
                // GELİR MODU AYARLARI
                _btnGelir.BackColor = Color.SeaGreen;
                _btnGelir.ForeColor = Color.White;
                _btnGelir.FlatAppearance.BorderSize = 0;

                _btnGider.BackColor = Color.White;
                _btnGider.ForeColor = Color.Gray;
                _btnGider.FlatAppearance.BorderColor = Color.LightGray;
                _btnGider.FlatAppearance.BorderSize = 1;

                // Kaydet Butonu Yeşil Olsun
                _btnKaydet.BackColor = Color.SeaGreen;
                _btnKaydet.Text = "GELİR KAYDET";
            }
            else
            {
                // GİDER MODU AYARLARI
                _btnGider.BackColor = Color.IndianRed;
                _btnGider.ForeColor = Color.White;
                _btnGider.FlatAppearance.BorderSize = 0;

                _btnGelir.BackColor = Color.White;
                _btnGelir.ForeColor = Color.Gray;
                _btnGelir.FlatAppearance.BorderColor = Color.LightGray;
                _btnGelir.FlatAppearance.BorderSize = 1;

                // Kaydet Butonu Kırmızı Olsun
                _btnKaydet.BackColor = Color.IndianRed;
                _btnKaydet.Text = "GİDER KAYDET";
            }
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_txtTutar.Text) || string.IsNullOrEmpty(_txtAciklama.Text))
            {
                MessageBox.Show("Lütfen tutar ve açıklama giriniz.");
                return;
            }

            double tutar;
            if (!double.TryParse(_txtTutar.Text, out tutar))
            {
                MessageBox.Show("Geçersiz tutar.");
                return;
            }

            string secilenKategori = _cmbKategori.SelectedItem != null ? _cmbKategori.SelectedItem.ToString() : "Diğer";

            // --- ID ÜRETME MANTIĞI (DÜZELTİLEN KISIM) ---
            // Listede eleman var mı? Varsa en büyük ID'yi bul 1 ekle, yoksa 1 yap.
            // Bu sayede her yeni işlem bir öncekinden büyük numaraya sahip olur.
            int yeniId = (VeriDeposu.Islemler.Count > 0) ? VeriDeposu.Islemler.Max(x => x.Id) + 1 : 1;
            // ---------------------------------------------

            // --- TARİH VE SAAT AYARI ---
            // Sadece tarihi alırsak saat 00:00 olur ve sıralama şaşabilir.
            // Seçilen tarihin üstüne şu anki saati ekleyelim:
            DateTime tarih = _dtpTarih.Value.Date + DateTime.Now.TimeOfDay;
            // ---------------------------

            if (_isGelir)
            {
                YeniIslem = new Gelir
                {
                    Id = yeniId, // Rastgele değil, sıralı ID
                    Tarih = tarih,
                    Baslik = _txtAciklama.Text,
                    Tutar = tutar,
                    GelirKategorisi = secilenKategori
                };
                VeriDeposu.Islemler.Add(YeniIslem);
                VeriDeposu.ToplamBakiye += tutar;
            }
            else
            {
                YeniIslem = new Gider
                {
                    Id = yeniId, // Rastgele değil, sıralı ID
                    Tarih = tarih,
                    Baslik = _txtAciklama.Text,
                    Tutar = tutar,
                    HarcamaKategorisi = secilenKategori
                };
                VeriDeposu.Islemler.Add(YeniIslem);
                VeriDeposu.ToplamBakiye -= tutar;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private Label LabelUret(string text)
        {
            return new Label { Text = text, Font = new Font("Segoe UI", 9, FontStyle.Bold), ForeColor = Color.Gray, Margin = new Padding(0, 15, 0, 5), AutoSize = true };
        }
    }
}