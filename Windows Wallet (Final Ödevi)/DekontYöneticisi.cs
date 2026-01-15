using System;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text; // Kütüphaneyi ekledik
using iTextSharp.text.pdf;

namespace Windows_Wallet__Final_Ödevi_
{
    public static class DekontYoneticisi
    {
        public static void DekontOlustur(Islem islem)
        {
            // Dosyayı nereye kaydedeceğimizi soralım
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF Dosyası|*.pdf";
            sfd.FileName = $"Dekont_{islem.Id}_{DateTime.Now:yyyyMMdd}.pdf";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // 1. DÖKÜMANI OLUŞTUR (A5 Boyutu seçtim, dekont için kibar durur)
                    Document doc = new Document(PageSize.A5, 25, 25, 30, 30);
                    PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                    doc.Open();

                    // --- TÜRKÇE FONT AYARI (Çok Önemli) ---
                    // Windows'un kendi Arial fontunu kullanıyoruz ki "ğ, ş, ı" bozuk çıkmasın
                    string fontYolu = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf");
                    BaseFont bf = BaseFont.CreateFont(fontYolu, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

                    Font baslikFont = new Font(bf, 18, iTextSharp.text.Font.BOLD, BaseColor.DARK_GRAY);
                    Font normalFont = new Font(bf, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                    Font kalinFont = new Font(bf, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                    Font tarihFont = new Font(bf, 8, iTextSharp.text.Font.ITALIC, BaseColor.GRAY);

                    // 2. LOGO / BAŞLIK KISMI
                    Paragraph baslik = new Paragraph("WINDOWS WALLET", baslikFont);
                    baslik.Alignment = Element.ALIGN_CENTER;
                    doc.Add(baslik);

                    Paragraph altBaslik = new Paragraph("İŞLEM DEKONTU", kalinFont);
                    altBaslik.Alignment = Element.ALIGN_CENTER;
                    altBaslik.SpacingAfter = 20f;
                    doc.Add(altBaslik);

                    // Çizgi Çek
                    iTextSharp.text.pdf.draw.LineSeparator cizgi = new iTextSharp.text.pdf.draw.LineSeparator(1f, 100f, BaseColor.LIGHT_GRAY, Element.ALIGN_CENTER, -1);
                    doc.Add(new Chunk(cizgi));
                    doc.Add(new Paragraph(" ")); // Boşluk

                    // 3. İŞLEM DETAYLARI TABLOSU
                    PdfPTable tablo = new PdfPTable(2); // 2 Sütunlu tablo
                    tablo.WidthPercentage = 100;
                    tablo.SetWidths(new float[] { 1f, 2f }); // Sol sütun dar, sağ geniş

                    // Hücre ekleme fonksiyonumuz (aşağıda)
                    TabloSatirEkle(tablo, "İşlem No (ID):", islem.Id.ToString(), kalinFont, normalFont);
                    TabloSatirEkle(tablo, "İşlem Tarihi:", islem.Tarih.ToString("dd.MM.yyyy HH:mm"), kalinFont, normalFont);

                    // Kategori Belirleme
                    string kategori = "Genel";
                    string tur = "Bilinmiyor";
                    if (islem is Gelir g) { kategori = g.GelirKategorisi; tur = "GELİR (Giriş)"; }
                    else if (islem is Gider gd) { kategori = gd.HarcamaKategorisi; tur = "GİDER (Çıkış)"; }

                    TabloSatirEkle(tablo, "İşlem Türü:", tur, kalinFont, normalFont);
                    TabloSatirEkle(tablo, "Kategori:", kategori, kalinFont, normalFont);
                    TabloSatirEkle(tablo, "Açıklama:", islem.Baslik, kalinFont, normalFont);

                    // Tutar Kısmı (Biraz daha büyük)
                    PdfPCell cellTutarBaslik = new PdfPCell(new Phrase("TUTAR:", kalinFont));
                    cellTutarBaslik.Border = 0;
                    cellTutarBaslik.PaddingTop = 10f;
                    tablo.AddCell(cellTutarBaslik);

                    Font tutarFont = new Font(bf, 14, iTextSharp.text.Font.BOLD, (islem is Gelir) ? BaseColor.GREEN : BaseColor.RED);
                    PdfPCell cellTutarDeger = new PdfPCell(new Phrase($"{islem.Tutar:N2} TL", tutarFont));
                    cellTutarDeger.Border = 0;
                    cellTutarDeger.PaddingTop = 10f;
                    tablo.AddCell(cellTutarDeger);

                    doc.Add(tablo);

                    // 4. ALT BİLGİ (Footer)
                    doc.Add(new Paragraph(" "));
                    doc.Add(new Chunk(cizgi));
                    Paragraph footer = new Paragraph($"Bu dekont {DateTime.Now} tarihinde dijital olarak oluşturulmuştur.\nWindows Wallet Güvencesiyle.", tarihFont);
                    footer.Alignment = Element.ALIGN_CENTER;
                    footer.SpacingBefore = 10f;
                    doc.Add(footer);

                    // Kapat
                    doc.Close();

                    // Kullanıcıya sor: Açmak ister mi?
                    DialogResult cevap = MessageBox.Show("Dekont başarıyla oluşturuldu! Açmak ister misiniz?", "Başarılı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (cevap == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(sfd.FileName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
            }
        }

        // Tabloya pratik satır ekleme yardımcısı
        private static void TabloSatirEkle(PdfPTable tablo, string baslik, string deger, Font fBaslik, Font fDeger)
        {
            PdfPCell c1 = new PdfPCell(new Phrase(baslik, fBaslik));
            c1.Border = 0;
            c1.PaddingBottom = 5f;
            tablo.AddCell(c1);

            PdfPCell c2 = new PdfPCell(new Phrase(deger, fDeger));
            c2.Border = 0;
            c2.PaddingBottom = 5f;
            tablo.AddCell(c2);
        }
    }
}