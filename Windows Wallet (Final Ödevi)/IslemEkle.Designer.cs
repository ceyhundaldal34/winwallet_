namespace Windows_Wallet__Final_Ödevi_
{
    partial class IslemEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnKaydet = new System.Windows.Forms.Button();
            this.rbGider = new System.Windows.Forms.RadioButton();
            this.rbGelir = new System.Windows.Forms.RadioButton();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.cmbTur = new System.Windows.Forms.ComboBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(150, 166);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(99, 31);
            this.btnKaydet.TabIndex = 15;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // rbGider
            // 
            this.rbGider.AutoSize = true;
            this.rbGider.Location = new System.Drawing.Point(294, 97);
            this.rbGider.Name = "rbGider";
            this.rbGider.Size = new System.Drawing.Size(71, 20);
            this.rbGider.TabIndex = 14;
            this.rbGider.TabStop = true;
            this.rbGider.Text = "Gelir (-)";
            this.rbGider.UseVisualStyleBackColor = true;
            // 
            // rbGelir
            // 
            this.rbGelir.AutoSize = true;
            this.rbGelir.Location = new System.Drawing.Point(371, 97);
            this.rbGelir.Name = "rbGelir";
            this.rbGelir.Size = new System.Drawing.Size(74, 20);
            this.rbGelir.TabIndex = 13;
            this.rbGelir.TabStop = true;
            this.rbGelir.Text = "Gelir (+)";
            this.rbGelir.UseVisualStyleBackColor = true;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(130, 126);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(138, 22);
            this.txtAciklama.TabIndex = 12;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarih.Location = new System.Drawing.Point(130, 31);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(200, 22);
            this.dtpTarih.TabIndex = 11;
            // 
            // cmbTur
            // 
            this.cmbTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTur.FormattingEnabled = true;
            this.cmbTur.Items.AddRange(new object[] {
            "Market",
            "Fatura",
            "Kira ",
            "Maaş",
            "Freelance",
            "Eğlence"});
            this.cmbTur.Location = new System.Drawing.Point(130, 96);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Size = new System.Drawing.Size(138, 24);
            this.cmbTur.TabIndex = 10;
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(130, 68);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(138, 22);
            this.txtTutar.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(32, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tarih:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(32, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tutar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(32, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tür:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(32, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 23);
            this.label4.TabIndex = 19;
            this.label4.Text = "Açıklama:";
            // 
            // IslemEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.rbGider);
            this.Controls.Add(this.rbGelir);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.cmbTur);
            this.Controls.Add(this.txtTutar);
            this.Name = "IslemEkle";
            this.Text = "IslemEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.RadioButton rbGider;
        private System.Windows.Forms.RadioButton rbGelir;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.ComboBox cmbTur;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}