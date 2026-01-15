namespace Windows_Wallet__Final_Ödevi_
{
    partial class DashboardPage
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmbGrafikTuru = new System.Windows.Forms.ComboBox();
            this.pnlGrafikKarti = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dlrDegisim = new System.Windows.Forms.Label();
            this.lblDolar = new System.Windows.Forms.Label();
            this.dlrBaslik = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEuro = new System.Windows.Forms.Label();
            this.eurBaslik = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAltin = new System.Windows.Forms.Label();
            this.altinBaslik = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BaslikSterlin = new System.Windows.Forms.Label();
            this.lblSterlin = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.pnlGrafikKarti.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(120)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblBakiye);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(24, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 150);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(179, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "**** 1234";
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBakiye.ForeColor = System.Drawing.Color.White;
            this.lblBakiye.Location = new System.Drawing.Point(3, 38);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(263, 54);
            this.lblBakiye.TabIndex = 5;
            this.lblBakiye.Text = "₺ 150.000,00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label2.Location = new System.Drawing.Point(15, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "TOPLAM VARLIKLARIM";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(573, 191);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // cmbGrafikTuru
            // 
            this.cmbGrafikTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrafikTuru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbGrafikTuru.FormattingEnabled = true;
            this.cmbGrafikTuru.Items.AddRange(new object[] {
            "Gelir - Gider",
            "Harcama Detayları"});
            this.cmbGrafikTuru.Location = new System.Drawing.Point(19, 17);
            this.cmbGrafikTuru.Name = "cmbGrafikTuru";
            this.cmbGrafikTuru.Size = new System.Drawing.Size(22, 24);
            this.cmbGrafikTuru.TabIndex = 7;
            // 
            // pnlGrafikKarti
            // 
            this.pnlGrafikKarti.BackColor = System.Drawing.Color.White;
            this.pnlGrafikKarti.Controls.Add(this.cmbGrafikTuru);
            this.pnlGrafikKarti.Controls.Add(this.chart1);
            this.pnlGrafikKarti.Location = new System.Drawing.Point(377, 84);
            this.pnlGrafikKarti.Name = "pnlGrafikKarti";
            this.pnlGrafikKarti.Size = new System.Drawing.Size(573, 191);
            this.pnlGrafikKarti.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(150)))), ((int)(((byte)(75)))));
            this.label1.Location = new System.Drawing.Point(24, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 64);
            this.label1.TabIndex = 9;
            this.label1.Text = "PORTFÖY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dlrDegisim);
            this.panel2.Controls.Add(this.lblDolar);
            this.panel2.Controls.Add(this.dlrBaslik);
            this.panel2.Location = new System.Drawing.Point(24, 340);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(355, 57);
            this.panel2.TabIndex = 10;
            // 
            // dlrDegisim
            // 
            this.dlrDegisim.AutoSize = true;
            this.dlrDegisim.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dlrDegisim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dlrDegisim.Location = new System.Drawing.Point(258, 13);
            this.dlrDegisim.Name = "dlrDegisim";
            this.dlrDegisim.Size = new System.Drawing.Size(70, 28);
            this.dlrDegisim.TabIndex = 2;
            this.dlrDegisim.Text = "%0.00";
            // 
            // lblDolar
            // 
            this.lblDolar.AutoSize = true;
            this.lblDolar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblDolar.Location = new System.Drawing.Point(144, 13);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(83, 28);
            this.lblDolar.TabIndex = 1;
            this.lblDolar.Text = "00.00 ₺";
            // 
            // dlrBaslik
            // 
            this.dlrBaslik.AutoSize = true;
            this.dlrBaslik.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dlrBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dlrBaslik.Location = new System.Drawing.Point(26, 13);
            this.dlrBaslik.Name = "dlrBaslik";
            this.dlrBaslik.Size = new System.Drawing.Size(79, 28);
            this.dlrBaslik.TabIndex = 0;
            this.dlrBaslik.Text = "DOLAR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label4.Location = new System.Drawing.Point(249, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "%0.00";
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEuro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblEuro.Location = new System.Drawing.Point(135, 13);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(83, 28);
            this.lblEuro.TabIndex = 4;
            this.lblEuro.Text = "00.00 ₺";
            // 
            // eurBaslik
            // 
            this.eurBaslik.AutoSize = true;
            this.eurBaslik.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eurBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.eurBaslik.Location = new System.Drawing.Point(27, 13);
            this.eurBaslik.Name = "eurBaslik";
            this.eurBaslik.Size = new System.Drawing.Size(65, 28);
            this.eurBaslik.TabIndex = 3;
            this.eurBaslik.Text = "EURO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label7.Location = new System.Drawing.Point(258, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 28);
            this.label7.TabIndex = 8;
            this.label7.Text = "%0.00";
            // 
            // lblAltin
            // 
            this.lblAltin.AutoSize = true;
            this.lblAltin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblAltin.Location = new System.Drawing.Point(154, 13);
            this.lblAltin.Name = "lblAltin";
            this.lblAltin.Size = new System.Drawing.Size(83, 28);
            this.lblAltin.TabIndex = 7;
            this.lblAltin.Text = "00.00 ₺";
            // 
            // altinBaslik
            // 
            this.altinBaslik.AutoSize = true;
            this.altinBaslik.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altinBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.altinBaslik.Location = new System.Drawing.Point(26, 13);
            this.altinBaslik.Name = "altinBaslik";
            this.altinBaslik.Size = new System.Drawing.Size(111, 28);
            this.altinBaslik.TabIndex = 6;
            this.altinBaslik.Text = "ALTIN (Gr)";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.altinBaslik);
            this.panel3.Controls.Add(this.lblAltin);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(24, 415);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(355, 57);
            this.panel3.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.eurBaslik);
            this.panel4.Controls.Add(this.lblEuro);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(422, 340);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(355, 57);
            this.panel4.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.BaslikSterlin);
            this.panel5.Controls.Add(this.lblSterlin);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(422, 415);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(355, 57);
            this.panel5.TabIndex = 12;
            // 
            // BaslikSterlin
            // 
            this.BaslikSterlin.AutoSize = true;
            this.BaslikSterlin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaslikSterlin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BaslikSterlin.Location = new System.Drawing.Point(26, 13);
            this.BaslikSterlin.Name = "BaslikSterlin";
            this.BaslikSterlin.Size = new System.Drawing.Size(91, 28);
            this.BaslikSterlin.TabIndex = 6;
            this.BaslikSterlin.Text = "STERLİN";
            // 
            // lblSterlin
            // 
            this.lblSterlin.AutoSize = true;
            this.lblSterlin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSterlin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblSterlin.Location = new System.Drawing.Point(154, 13);
            this.lblSterlin.Name = "lblSterlin";
            this.lblSterlin.Size = new System.Drawing.Size(83, 28);
            this.lblSterlin.TabIndex = 7;
            this.lblSterlin.Text = "00.00 ₺";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label8.Location = new System.Drawing.Point(258, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 28);
            this.label8.TabIndex = 8;
            this.label8.Text = "%0.00";
            // 
            // DashboardPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlGrafikKarti);
            this.Controls.Add(this.panel1);
            this.Name = "DashboardPage";
            this.Size = new System.Drawing.Size(995, 626);
            this.Load += new System.EventHandler(this.DashboardPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.pnlGrafikKarti.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox cmbGrafikTuru;
        private System.Windows.Forms.Panel pnlGrafikKarti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDolar;
        private System.Windows.Forms.Label dlrBaslik;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAltin;
        private System.Windows.Forms.Label altinBaslik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.Label eurBaslik;
        private System.Windows.Forms.Label dlrDegisim;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label BaslikSterlin;
        private System.Windows.Forms.Label lblSterlin;
        private System.Windows.Forms.Label label8;
    }
}
