using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Wallet__Final_Ödevi_
{
    // INHERITANCE (KALITIM)
    public class Gider : Islem
    {
        public string HarcamaKategorisi { get; set; } // Ekstra özellik (Örn: Mutfak, Benzin)

        public override string TuruGetir()
        {
            return "Gider";
        }
    }
}
