using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Wallet__Final_Ödevi_
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 1. Önce Login Formunu açıyoruz
            LoginForm login = new LoginForm();

            // 2. Eğer giriş başarılıysa (DialogResult.OK dönerse)
            if (login.ShowDialog() == DialogResult.OK)
            {
                // Login'den gelen kullanıcı adını alıyoruz (Public bir property ile)
                string girisYapanKullanici = login.KullaniciAdi;

                // 3. Ana Formu başlatıyoruz
                Application.Run(new MainForm(girisYapanKullanici));
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
