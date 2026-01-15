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
    public partial class LoginForm : Form
    {
        public string KullaniciAdi { get; set; } // Ana forma göndereceğimiz veri

        public LoginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Ortada başlasın
            this.FormBorderStyle = FormBorderStyle.None; // Çerçevesiz modern görünüm
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            
            if (txtUser.Text != "" && txtPass.Text == "1234")
            {
                KullaniciAdi = txtUser.Text; // Kullanıcı adını kaydet
                VeriDeposu.KullaniciAdi = txtUser.Text;
                this.DialogResult = DialogResult.OK; // Program.cs'e "Tamam" sinyali gönder
                this.Close(); // Formu kapat
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCikis_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

