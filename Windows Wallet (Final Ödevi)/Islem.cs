using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Wallet__Final_Ödevi_
{
    // ABSTRACT CLASS (SOYUT SINIF) - Rapor Madde 17
    // Bu sınıftan doğrudan nesne üretilemez, miras alınması gerekir.
    public abstract class Islem
    {
        // ENCAPSULATION (KAPSÜLLEME) - Rapor Madde 16
        public int Id { get; set; }
        public string Baslik { get; set; }
        public double Tutar { get; set; }
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }

        // POLYMORPHISM (ÇOK BİÇİMLİLİK) - Rapor Madde 15
        // Bu özellik alt sınıflarda (Gelir/Gider) farklı çalışacak.
        public abstract string TuruGetir();

        // Sanal Metot (İstersek ezebiliriz)
        public virtual string OzetBilgi()
        {
            return $"{Tarih.ToShortDateString()} - {Baslik}: {Tutar} ₺";
        }
    }
}