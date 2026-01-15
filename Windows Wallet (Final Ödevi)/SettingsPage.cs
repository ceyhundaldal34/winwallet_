using System;
using System.Drawing;
using System.Windows.Forms;

namespace Windows_Wallet__Final_Ödevi_
{
    public partial class SettingsPage : UserControl
    {
        public SettingsPage()
        {
            InitializeComponent();
            TasarimiHazirla();
        }

        private void TasarimiHazirla()
        {
            this.Dock = DockStyle.Fill;
            this.BackColor = Color.FromArgb(240, 240, 240); // Hafif gri arka plan
            this.Padding = new Padding(30);

            // Başlık
            Label lblBaslik = new Label();
            lblBaslik.Text = "Ayarlar";
            lblBaslik.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            lblBaslik.ForeColor = Color.FromArgb(44, 62, 80);
            lblBaslik.AutoSize = true;
            lblBaslik.Location = new Point(30, 30);
            this.Controls.Add(lblBaslik);

            // Panel oluştur (Kart görünümü için)
            Panel pnlKart = new Panel();
            pnlKart.Size = new Size(400, 350);
            pnlKart.Location = new Point(30, 80);
            pnlKart.BackColor = Color.White;
            this.Controls.Add(pnlKart);

            // Yuvarlak köşe efekti (Hata verirse try-catch ile geç)
            try { Elips.Apply(pnlKart, 20); } catch { }

            // Tema Değiştir Butonu (Süs)
            Button btnTema = new Button();
            btnTema.Text = "🌙  Koyu Mod (Dark Mode)";
            btnTema.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            btnTema.FlatStyle = FlatStyle.Flat;
            btnTema.FlatAppearance.BorderSize = 0;
            btnTema.BackColor = Color.FromArgb(64, 64, 64); // Koyu Gri
            btnTema.ForeColor = Color.White;
            btnTema.Size = new Size(360, 50);
            btnTema.Location = new Point(20, 170); // Konumunu diğer butonlara göre ayarla
            btnTema.Cursor = Cursors.Hand;
            btnTema.Click += (s, e) => MessageBox.Show("Koyu Mod özelliği, kodların yetişmemesi sebebiyle v2.0 sürümüne ertelenmiştir.\n\n(Mevcut tema: Füme Grisi)", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            pnlKart.Controls.Add(btnTema);

            // --- İÇERİK ---

            // 1. Verileri Sıfırla Butonu
            Button btnSifirla = new Button();
            btnSifirla.Text = "🗑️  Tüm Verileri Sıfırla";
            btnSifirla.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            btnSifirla.FlatStyle = FlatStyle.Flat;
            btnSifirla.FlatAppearance.BorderSize = 0;
            btnSifirla.BackColor = Color.FromArgb(231, 76, 60); // Kırmızı
            btnSifirla.ForeColor = Color.White;
            btnSifirla.Size = new Size(360, 50);
            btnSifirla.Location = new Point(20, 30);
            btnSifirla.Cursor = Cursors.Hand;
            btnSifirla.Click += BtnSifirla_Click;
            pnlKart.Controls.Add(btnSifirla);

            // 2. Hakkında Butonu
            Button btnHakkinda = new Button();
            btnHakkinda.Text = "ℹ️  Uygulama Hakkında";
            btnHakkinda.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            btnHakkinda.FlatStyle = FlatStyle.Flat;
            btnHakkinda.FlatAppearance.BorderSize = 0;
            btnHakkinda.BackColor = Color.FromArgb(52, 152, 219); // Mavi
            btnHakkinda.ForeColor = Color.White;
            btnHakkinda.Size = new Size(360, 50);
            btnHakkinda.Location = new Point(20, 100);
            btnHakkinda.Cursor = Cursors.Hand;
            btnHakkinda.Click += (s, e) => MessageBox.Show("Windows Wallet v1.0\nGeliştirici: Ceyhun Daldal\n Yusuf Taha Alıcı \n\n'Cüzdan Takip Sistemi", "Hakkında");
            pnlKart.Controls.Add(btnHakkinda);

            // 3. Çıkış Yap Butonu
            Button btnCikis = new Button();
            btnCikis.Text = "🚪  Çıkış Yap";
            btnCikis.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnCikis.FlatStyle = FlatStyle.Flat;
            btnCikis.FlatAppearance.BorderSize = 2;
            btnCikis.FlatAppearance.BorderColor = Color.FromArgb(44, 62, 80);
            btnCikis.BackColor = Color.Transparent;
            btnCikis.ForeColor = Color.FromArgb(44, 62, 80);
            btnCikis.Size = new Size(360, 50);
            btnCikis.Location = new Point(20, 250); // En altta
            btnCikis.Cursor = Cursors.Hand;
            btnCikis.Click += (s, e) => Application.Restart(); // Uygulamayı resetler (Login ekranına atar)
            pnlKart.Controls.Add(btnCikis);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Restart(); // Uygulamayı resetler (Login'e atar)
        }

        private void BtnSifirla_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Tüm veriler silinecek! Emin misin?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (cevap == DialogResult.Yes)
            {
                // Veri Deposunu Temizle
                VeriDeposu.Islemler.Clear();
                VeriDeposu.ToplamBakiye = 0;
                VeriDeposu.DolarBakiyesi = 0;
                VeriDeposu.AltinBakiyesi = 0;

                MessageBox.Show("Veriler başarıyla sıfırlandı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}