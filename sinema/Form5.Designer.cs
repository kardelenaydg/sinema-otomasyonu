namespace sinema
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBiyografi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnResimyukle = new System.Windows.Forms.Button();
            this.pbResim = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rBKadın = new System.Windows.Forms.RadioButton();
            this.rBErkek = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.nYıl = new System.Windows.Forms.NumericUpDown();
            this.nAy = new System.Windows.Forms.NumericUpDown();
            this.nGun = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nYıl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGun)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 56);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Brown;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(826, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 56);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Algerian", 22.2F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "OYUNCU KAYIT EKRANI";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Gray;
            this.btnKaydet.FlatAppearance.BorderSize = 0;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(57, 665);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(419, 67);
            this.btnKaydet.TabIndex = 9;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox3.Controls.Add(this.txtBiyografi);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox3.Location = new System.Drawing.Point(38, 387);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(553, 272);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " ";
            // 
            // txtBiyografi
            // 
            this.txtBiyografi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBiyografi.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBiyografi.Location = new System.Drawing.Point(3, 29);
            this.txtBiyografi.Multiline = true;
            this.txtBiyografi.Name = "txtBiyografi";
            this.txtBiyografi.Size = new System.Drawing.Size(547, 240);
            this.txtBiyografi.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Teal;
            this.label10.Location = new System.Drawing.Point(-4, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 24);
            this.label10.TabIndex = 0;
            this.label10.Text = "BİYOGRAFİ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnResimyukle);
            this.groupBox2.Controls.Add(this.pbResim);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(427, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(444, 305);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " ";
            // 
            // btnResimyukle
            // 
            this.btnResimyukle.BackColor = System.Drawing.Color.Gray;
            this.btnResimyukle.FlatAppearance.BorderSize = 0;
            this.btnResimyukle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResimyukle.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.btnResimyukle.ForeColor = System.Drawing.Color.White;
            this.btnResimyukle.Location = new System.Drawing.Point(24, 233);
            this.btnResimyukle.Name = "btnResimyukle";
            this.btnResimyukle.Size = new System.Drawing.Size(163, 53);
            this.btnResimyukle.TabIndex = 4;
            this.btnResimyukle.Text = "YÜKLE";
            this.btnResimyukle.UseVisualStyleBackColor = false;
            this.btnResimyukle.Click += new System.EventHandler(this.btnResimyukle_Click);
            // 
            // pbResim
            // 
            this.pbResim.Image = ((System.Drawing.Image)(resources.GetObject("pbResim.Image")));
            this.pbResim.Location = new System.Drawing.Point(14, 30);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(281, 188);
            this.pbResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbResim.TabIndex = 3;
            this.pbResim.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(19, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "FOTOĞRAF";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.rBKadın);
            this.groupBox1.Controls.Add(this.rBErkek);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nYıl);
            this.groupBox1.Controls.Add(this.nAy);
            this.groupBox1.Controls.Add(this.nGun);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 316);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtID.Location = new System.Drawing.Point(26, 150);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(288, 26);
            this.txtID.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(7, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "ID";
            // 
            // rBKadın
            // 
            this.rBKadın.AutoSize = true;
            this.rBKadın.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rBKadın.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rBKadın.ForeColor = System.Drawing.Color.Black;
            this.rBKadın.Location = new System.Drawing.Point(128, 281);
            this.rBKadın.Name = "rBKadın";
            this.rBKadın.Size = new System.Drawing.Size(93, 29);
            this.rBKadın.TabIndex = 11;
            this.rBKadın.Text = "KADIN";
            this.rBKadın.UseVisualStyleBackColor = true;
            this.rBKadın.CheckedChanged += new System.EventHandler(this.rBKadın_CheckedChanged);
            // 
            // rBErkek
            // 
            this.rBErkek.AutoSize = true;
            this.rBErkek.Checked = true;
            this.rBErkek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rBErkek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rBErkek.ForeColor = System.Drawing.Color.Black;
            this.rBErkek.Location = new System.Drawing.Point(5, 281);
            this.rBErkek.Name = "rBErkek";
            this.rBErkek.Size = new System.Drawing.Size(99, 29);
            this.rBErkek.TabIndex = 10;
            this.rBErkek.TabStop = true;
            this.rBErkek.Text = "ERKEK";
            this.rBErkek.UseVisualStyleBackColor = true;
            this.rBErkek.CheckedChanged += new System.EventHandler(this.rBErkek_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(6, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "CİNSİYET";
            // 
            // nYıl
            // 
            this.nYıl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nYıl.Location = new System.Drawing.Point(174, 217);
            this.nYıl.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nYıl.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nYıl.Name = "nYıl";
            this.nYıl.Size = new System.Drawing.Size(124, 26);
            this.nYıl.TabIndex = 7;
            this.nYıl.Value = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            // 
            // nAy
            // 
            this.nAy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nAy.Location = new System.Drawing.Point(93, 217);
            this.nAy.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nAy.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nAy.Name = "nAy";
            this.nAy.Size = new System.Drawing.Size(75, 26);
            this.nAy.TabIndex = 6;
            this.nAy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nGun
            // 
            this.nGun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nGun.Location = new System.Drawing.Point(12, 217);
            this.nGun.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nGun.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nGun.Name = "nGun";
            this.nGun.Size = new System.Drawing.Size(75, 26);
            this.nGun.TabIndex = 5;
            this.nGun.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(7, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "DOĞUM TARİHİ";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSoyad.Location = new System.Drawing.Point(26, 88);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(288, 26);
            this.txtSoyad.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(0, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "SOYAD";
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtAd.Location = new System.Drawing.Point(26, 26);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(288, 26);
            this.txtAd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(1, -3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "AD";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(896, 759);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(400, 50);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form5";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nYıl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGun)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtBiyografi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnResimyukle;
        private System.Windows.Forms.PictureBox pbResim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rBKadın;
        private System.Windows.Forms.RadioButton rBErkek;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nYıl;
        private System.Windows.Forms.NumericUpDown nAy;
        private System.Windows.Forms.NumericUpDown nGun;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label2;
    }
}