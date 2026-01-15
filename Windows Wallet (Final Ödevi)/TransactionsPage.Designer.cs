namespace Windows_Wallet__Final_Ödevi_
{
    partial class TransactionsPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.gridTumIslemler = new System.Windows.Forms.DataGridView();
            this.btnYeniIslem = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tür = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Başlık = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridTumIslemler)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "BURASI İŞLEMLER";
            // 
            // gridTumIslemler
            // 
            this.gridTumIslemler.AllowUserToAddRows = false;
            this.gridTumIslemler.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.gridTumIslemler.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridTumIslemler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridTumIslemler.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridTumIslemler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTumIslemler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridTumIslemler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTumIslemler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Tür,
            this.Başlık,
            this.Tutar,
            this.Tarih});
            this.gridTumIslemler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTumIslemler.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.gridTumIslemler.Location = new System.Drawing.Point(0, 0);
            this.gridTumIslemler.Name = "gridTumIslemler";
            this.gridTumIslemler.ReadOnly = true;
            this.gridTumIslemler.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.gridTumIslemler.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gridTumIslemler.RowTemplate.Height = 24;
            this.gridTumIslemler.Size = new System.Drawing.Size(1042, 478);
            this.gridTumIslemler.TabIndex = 1;
            // 
            // btnYeniIslem
            // 
            this.btnYeniIslem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYeniIslem.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniIslem.Location = new System.Drawing.Point(883, 210);
            this.btnYeniIslem.Name = "btnYeniIslem";
            this.btnYeniIslem.Size = new System.Drawing.Size(119, 36);
            this.btnYeniIslem.TabIndex = 2;
            this.btnYeniIslem.Text = "+YENİ İŞLEM";
            this.btnYeniIslem.UseVisualStyleBackColor = true;

            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Tür
            // 
            this.Tür.HeaderText = "Tür";
            this.Tür.MinimumWidth = 6;
            this.Tür.Name = "Tür";
            this.Tür.ReadOnly = true;
            // 
            // Başlık
            // 
            this.Başlık.HeaderText = "Başlık";
            this.Başlık.MinimumWidth = 6;
            this.Başlık.Name = "Başlık";
            this.Başlık.ReadOnly = true;
            // 
            // Tutar
            // 
            this.Tutar.HeaderText = "Tutar";
            this.Tutar.MinimumWidth = 6;
            this.Tutar.Name = "Tutar";
            this.Tutar.ReadOnly = true;
            // 
            // Tarih
            // 
            this.Tarih.HeaderText = "Tarih";
            this.Tarih.MinimumWidth = 6;
            this.Tarih.Name = "Tarih";
            this.Tarih.ReadOnly = true;
            // 
            // TransactionsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.btnYeniIslem);
            this.Controls.Add(this.gridTumIslemler);
            this.Controls.Add(this.label1);
            this.Name = "TransactionsPage";
            this.Size = new System.Drawing.Size(1042, 478);
            ((System.ComponentModel.ISupportInitialize)(this.gridTumIslemler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridTumIslemler;
        private System.Windows.Forms.Button btnYeniIslem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tür;
        private System.Windows.Forms.DataGridViewTextBoxColumn Başlık;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih;
    }
}
