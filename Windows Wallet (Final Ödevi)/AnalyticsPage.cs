using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting; // Grafik kütüphanesi

namespace Windows_Wallet__Final_Ödevi_
{
    public partial class AnalyticsPage : UserControl
    {
        public AnalyticsPage()
        {
            InitializeComponent();
            AnalyticsPage_Load(this, EventArgs.Empty);
        }

        private void AnalyticsPage_Load(object sender, EventArgs e)
        {
            GrafikleriOlustur();
        }

        private void GrafikleriOlustur()
        {
            this.Controls.Clear();
            this.Dock = DockStyle.Fill;
            this.BackColor = Color.FromArgb(230, 230, 230); // Hafif gri arka plan
            this.Padding = new Padding(20);

            // 1. PANEL DÜZENİ (İki grafik yan yana)
            TableLayoutPanel table = new TableLayoutPanel();
            table.Dock = DockStyle.Fill;
            table.ColumnCount = 2;
            table.RowCount = 1;
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F)); // %50 Sol
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F)); // %50 Sağ
            this.Controls.Add(table);

            // -----------------------------------------------------------
            // SOL GRAFİK: VARLIK DAĞILIMI (PASTA - PIE CHART)
            // -----------------------------------------------------------
            Chart chartVarlik = new Chart();
            chartVarlik.Dock = DockStyle.Fill;
            chartVarlik.BackColor = Color.White;

            ChartArea area1 = new ChartArea("MainArea");
            chartVarlik.ChartAreas.Add(area1);

            Legend legend1 = new Legend("Legend");
            legend1.Docking = Docking.Bottom; // Açıklamalar altta
            chartVarlik.Legends.Add(legend1);

            Series serisVarlik = new Series("Varlıklar");
            serisVarlik.ChartType = SeriesChartType.Doughnut; // Simit grafik (daha modern)
            serisVarlik.Font = new Font("Segoe UI", 10f);
            serisVarlik.LabelForeColor = Color.White;
            chartVarlik.Series.Add(serisVarlik);

            // --- VERİLERİ HESAPLA (BURASI DEĞİŞTİ) ---
            double tl = VeriDeposu.ToplamBakiye;
            double dolarTL = VeriDeposu.DolarBakiyesi * VeriDeposu.AnlikDolarKuru;
            double euroTL = VeriDeposu.EuroBakiyesi * VeriDeposu.AnlikEuroKuru;
            double sterlinTL = VeriDeposu.SterlinBakiyesi * VeriDeposu.AnlikSterlinKuru;
            double altinTL = VeriDeposu.AltinBakiyesi * VeriDeposu.AnlikAltinKuru;

            // Grafiğe Ekle (Sadece 0'dan büyükse ekle ki kirlilik olmasın)
            if (tl > 0) serisVarlik.Points.AddXY($"TL ({tl:N0}₺)", tl);
            if (dolarTL > 0) serisVarlik.Points.AddXY($"Dolar ({dolarTL:N0}₺)", dolarTL);
            if (euroTL > 0) serisVarlik.Points.AddXY($"Euro ({euroTL:N0}₺)", euroTL);
            if (sterlinTL > 0) serisVarlik.Points.AddXY($"Sterlin ({sterlinTL:N0}₺)", sterlinTL);
            if (altinTL > 0) serisVarlik.Points.AddXY($"Altın ({altinTL:N0}₺)", altinTL);

            Title baslik1 = new Title("Varlık Dağılımı (TL Karşılığı)");
            baslik1.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            chartVarlik.Titles.Add(baslik1);

            // Köşeleri yuvarlatılmış panel içine koyalım
            Panel pnlLeft = new Panel { Dock = DockStyle.Fill, Padding = new Padding(10) };
            pnlLeft.Controls.Add(chartVarlik);
            table.Controls.Add(pnlLeft, 0, 0);


            // -----------------------------------------------------------
            // SAĞ GRAFİK: GELİR / GİDER ANALİZİ (SÜTUN - COLUMN CHART)
            // -----------------------------------------------------------
            Chart chartIslem = new Chart();
            chartIslem.Dock = DockStyle.Fill;
            chartIslem.BackColor = Color.White;

            ChartArea area2 = new ChartArea("MainArea");
            area2.AxisX.MajorGrid.Enabled = false; // Dikey çizgileri kapat
            area2.AxisY.LineColor = Color.LightGray;
            area2.AxisY.MajorGrid.LineColor = Color.FromArgb(240, 240, 240);
            chartIslem.ChartAreas.Add(area2);

            Series serisIslem = new Series("İşlemler");
            serisIslem.ChartType = SeriesChartType.Column; // Sütun grafik
            serisIslem.Color = Color.SeaGreen;
            chartIslem.Series.Add(serisIslem);

            // Son 10 İşlemi Getir
            var sonIslemler = VeriDeposu.Islemler.OrderByDescending(x => x.Id).Take(10).Reverse().ToList();

            foreach (var islem in sonIslemler)
            {
                int index = serisIslem.Points.AddXY(islem.Baslik, islem.Tutar);
                // Gelirse Yeşil, Giderse Kırmızı yap
                if (islem is Gider)
                {
                    serisIslem.Points[index].Color = Color.IndianRed;
                }
                else
                {
                    serisIslem.Points[index].Color = Color.SeaGreen;
                }
            }

            Title baslik2 = new Title("Son İşlemler Grafiği");
            baslik2.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            chartIslem.Titles.Add(baslik2);

            Panel pnlRight = new Panel { Dock = DockStyle.Fill, Padding = new Padding(10) };
            pnlRight.Controls.Add(chartIslem);
            table.Controls.Add(pnlRight, 1, 0);
        }
    }
}