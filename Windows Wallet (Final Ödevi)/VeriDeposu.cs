using System;
using System.Collections.Generic;
using System.Linq;

namespace Windows_Wallet__Final_Ödevi_
{
    public static class VeriDeposu
    {
        public static string KullaniciAdi = "Kullanıcı";

        // Tüm İşlemler Listesi
        public static List<Islem> Islemler = new List<Islem>();

        // 1. CÜZDANLAR (TL, Dolar, Altın)
        public static double ToplamBakiye = 150000.00; // TL Bakiyesi
        public static double DolarBakiyesi = 0;        // Dolar Cüzdanı
        public static double AltinBakiyesi = 0;        // Gram Altın Cüzdanı
        public static double EuroBakiyesi = 0;         // Euro Cüzdanı
        public static double SterlinBakiyesi = 0;      // Sterlin Cüzdanı

        // 2. CANLI KURLAR (Her yerden erişilsin diye buraya aldık)
        public static double AnlikDolarKuru = 30.50;
        public static double AnlikAltinKuru = 2050.00;
        public static double AnlikEuroKuru = 33.20;
        public static double AnlikSterlinKuru = 39.80;



        public static void BaslangicVerileriniYukle()
        {
            if (Islemler.Count == 0)
            {
                // Örnek veriler...
                Islemler.Add(new Gelir { Id = 1, Baslik = "Freelance İş", Tutar = 5000, Tarih = DateTime.Now.AddDays(-2), Aciklama = "Logo Tasarımı", GelirKaynagi = "Tasarım" });

                GuncelBakiyeyiHesapla();
            }
        }

        public static void GuncelBakiyeyiHesapla()
        {
            // Sadece TL giriş çıkışlarını hesaplar
            double gelirler = Islemler.Where(x => x is Gelir).Sum(x => x.Tutar);
            double giderler = Islemler.Where(x => x is Gider).Sum(x => x.Tutar);

            ToplamBakiye = 150000 + gelirler - giderler;
        }
    }
}