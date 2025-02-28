namespace sinema
{
    partial class salonListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(salonListesi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSalonAdi = new System.Windows.Forms.Label();
            this.lblKoltukSayisi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 101);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblSalonAdi
            // 
            this.lblSalonAdi.AutoSize = true;
            this.lblSalonAdi.BackColor = System.Drawing.Color.Transparent;
            this.lblSalonAdi.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSalonAdi.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSalonAdi.ForeColor = System.Drawing.Color.Teal;
            this.lblSalonAdi.Location = new System.Drawing.Point(115, 9);
            this.lblSalonAdi.Name = "lblSalonAdi";
            this.lblSalonAdi.Size = new System.Drawing.Size(65, 21);
            this.lblSalonAdi.TabIndex = 2;
            this.lblSalonAdi.Text = "label1";
            // 
            // lblKoltukSayisi
            // 
            this.lblKoltukSayisi.AutoSize = true;
            this.lblKoltukSayisi.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKoltukSayisi.ForeColor = System.Drawing.Color.Black;
            this.lblKoltukSayisi.Location = new System.Drawing.Point(115, 62);
            this.lblKoltukSayisi.Name = "lblKoltukSayisi";
            this.lblKoltukSayisi.Size = new System.Drawing.Size(62, 21);
            this.lblKoltukSayisi.TabIndex = 3;
            this.lblKoltukSayisi.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(114, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Koltuk Sayısı";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // salonListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblKoltukSayisi);
            this.Controls.Add(this.lblSalonAdi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "salonListesi";
            this.Size = new System.Drawing.Size(338, 101);
            this.Load += new System.EventHandler(this.salonListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lblSalonAdi;
        public System.Windows.Forms.Label lblKoltukSayisi;
        private System.Windows.Forms.Label label1;
    }
}
