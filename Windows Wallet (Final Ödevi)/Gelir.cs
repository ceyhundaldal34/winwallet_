using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Wallet__Final_Ödevi_
{
    // Gelir sınıfı, Islem sınıfının tüm özelliklerini miras alır.
    public class Gelir : Islem
    {
        public string GelirKategorisi { get; set; } // <-- BUNU EKLE
        public string GelirKaynagi { get; set; } // Ekstra özellik (Örn: Maaş, Freelance)

        // Override (Ezme) işlemi
        public override string TuruGetir()
        {
            return "Gelir";
        }
    }
}