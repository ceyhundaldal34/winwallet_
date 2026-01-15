using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Wallet__Final_Ödevi_
{
    public class Transaction
    {
        // Veritabanındaki "Primary Key" (Benzersiz Kimlik)
        public int Id { get; set; }

        // İşlem Başlığı (Örn: "Market Alışverişi", "Ev Kirası")
        public string Title { get; set; }

        // Tutar (Para birimi olduğu için 'decimal' kullanıyoruz)
        public decimal Amount { get; set; }

        // İşlem Tarihi
        public DateTime Date { get; set; }

        // Türü: "Gelir" veya "Gider"
        public string Type { get; set; }

        // Kategori (Örn: "Fatura", "Gıda", "Eğlence")
        public string Category { get; set; }

        // Ekstra Açıklama
        public string Description { get; set; }
    }
}