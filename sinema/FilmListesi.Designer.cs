namespace sinema
{
    partial class FilmListesi
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
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.lblIdNo = new System.Windows.Forms.Label();
            this.lblFilmAdi = new System.Windows.Forms.Label();
            this.pbResim = new System.Windows.Forms.PictureBox();
            this.btnFilm = new System.Windows.Forms.Button();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.lblIdNo);
            this.groupBox9.Controls.Add(this.lblFilmAdi);
            this.groupBox9.Controls.Add(this.pbResim);
            this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox9.Location = new System.Drawing.Point(12, 15);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.groupBox9.Size = new System.Drawing.Size(346, 333);
            this.groupBox9.TabIndex = 12;
            this.groupBox9.TabStop = false;
            this.groupBox9.Enter += new System.EventHandler(this.groupBox9_Enter);
            // 
            // lblIdNo
            // 
            this.lblIdNo.AutoSize = true;
            this.lblIdNo.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.lblIdNo.Location = new System.Drawing.Point(13, 306);
            this.lblIdNo.Name = "lblIdNo";
            this.lblIdNo.Size = new System.Drawing.Size(72, 24);
            this.lblIdNo.TabIndex = 11;
            this.lblIdNo.Text = "label1";
            this.lblIdNo.Visible = false;
            // 
            // lblFilmAdi
            // 
            this.lblFilmAdi.AutoSize = true;
            this.lblFilmAdi.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFilmAdi.ForeColor = System.Drawing.Color.Teal;
            this.lblFilmAdi.Location = new System.Drawing.Point(5, 9);
            this.lblFilmAdi.Name = "lblFilmAdi";
            this.lblFilmAdi.Size = new System.Drawing.Size(83, 28);
            this.lblFilmAdi.TabIndex = 10;
            this.lblFilmAdi.Text = "label1";
            // 
            // pbResim
            // 
            this.pbResim.ErrorImage = null;
            this.pbResim.Location = new System.Drawing.Point(10, 54);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(231, 249);
            this.pbResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbResim.TabIndex = 8;
            this.pbResim.TabStop = false;
            // 
            // btnFilm
            // 
            this.btnFilm.BackColor = System.Drawing.Color.Gray;
            this.btnFilm.FlatAppearance.BorderSize = 0;
            this.btnFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilm.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.btnFilm.ForeColor = System.Drawing.Color.White;
            this.btnFilm.Location = new System.Drawing.Point(22, 354);
            this.btnFilm.Name = "btnFilm";
            this.btnFilm.Size = new System.Drawing.Size(146, 49);
            this.btnFilm.TabIndex = 9;
            this.btnFilm.Text = "DETAY";
            this.btnFilm.UseVisualStyleBackColor = false;
            this.btnFilm.Click += new System.EventHandler(this.btnFilm_Click);
            // 
            // FilmListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.btnFilm);
            this.Name = "FilmListesi";
            this.Size = new System.Drawing.Size(304, 438);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button btnFilm;
        public System.Windows.Forms.PictureBox pbResim;
        public System.Windows.Forms.Label lblFilmAdi;
        public System.Windows.Forms.Label lblIdNo;
    }
}
