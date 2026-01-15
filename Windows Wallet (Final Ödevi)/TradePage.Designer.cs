namespace Windows_Wallet__Final_Ödevi_
{
    partial class TradePage
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
            this.lblBakiye = new System.Windows.Forms.Label();
            this.cmbDovizTuru = new System.Windows.Forms.ComboBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.lblKarsilik = new System.Windows.Forms.Label();
            this.btnAl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.Location = new System.Drawing.Point(51, 34);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(49, 16);
            this.lblBakiye.TabIndex = 0;
            this.lblBakiye.Text = "Bakiye";
            // 
            // cmbDovizTuru
            // 
            this.cmbDovizTuru.FormattingEnabled = true;
            this.cmbDovizTuru.Items.AddRange(new object[] {
            "DOLAR",
            "ALTIN"});
            this.cmbDovizTuru.Location = new System.Drawing.Point(54, 64);
            this.cmbDovizTuru.Name = "cmbDovizTuru";
            this.cmbDovizTuru.Size = new System.Drawing.Size(121, 24);
            this.cmbDovizTuru.TabIndex = 1;
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(61, 94);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(100, 22);
            this.txtTutar.TabIndex = 2;
            // 
            // lblKarsilik
            // 
            this.lblKarsilik.AutoSize = true;
            this.lblKarsilik.Location = new System.Drawing.Point(131, 34);
            this.lblKarsilik.Name = "lblKarsilik";
            this.lblKarsilik.Size = new System.Drawing.Size(50, 16);
            this.lblKarsilik.TabIndex = 3;
            this.lblKarsilik.Text = "Karşılık";
            // 
            // btnAl
            // 
            this.btnAl.Location = new System.Drawing.Point(77, 137);
            this.btnAl.Name = "btnAl";
            this.btnAl.Size = new System.Drawing.Size(75, 23);
            this.btnAl.TabIndex = 4;
            this.btnAl.Text = "button1";
            this.btnAl.UseVisualStyleBackColor = true;
            // 
            // TradePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAl);
            this.Controls.Add(this.lblKarsilik);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.cmbDovizTuru);
            this.Controls.Add(this.lblBakiye);
            this.Name = "TradePage";
            this.Size = new System.Drawing.Size(1063, 542);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.ComboBox cmbDovizTuru;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label lblKarsilik;
        private System.Windows.Forms.Button btnAl;
    }
}
