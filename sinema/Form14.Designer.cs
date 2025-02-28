namespace sinema
{
    partial class Form14
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form14));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cbSalon = new System.Windows.Forms.ComboBox();
            this.lblSeçilen = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblSeansSec = new System.Windows.Forms.Label();
            this.panelSeans = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.nYıl = new System.Windows.Forms.NumericUpDown();
            this.nAy = new System.Windows.Forms.NumericUpDown();
            this.nGun = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbFilmAdi = new System.Windows.Forms.ComboBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnOluştur = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbDoluSaatler = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nYıl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGun)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 56);
            this.panel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(840, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 56);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Algerian", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "SALON ATAMA EKRANI";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cbSalon);
            this.groupBox7.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox7.ForeColor = System.Drawing.Color.Teal;
            this.groupBox7.Location = new System.Drawing.Point(16, 169);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.groupBox7.Size = new System.Drawing.Size(287, 63);
            this.groupBox7.TabIndex = 20;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "SALON ADI";
            // 
            // cbSalon
            // 
            this.cbSalon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cbSalon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSalon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSalon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbSalon.FormattingEnabled = true;
            this.cbSalon.Location = new System.Drawing.Point(10, 30);
            this.cbSalon.Name = "cbSalon";
            this.cbSalon.Size = new System.Drawing.Size(274, 30);
            this.cbSalon.TabIndex = 0;
            // 
            // lblSeçilen
            // 
            this.lblSeçilen.AutoSize = true;
            this.lblSeçilen.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSeçilen.ForeColor = System.Drawing.Color.Teal;
            this.lblSeçilen.Location = new System.Drawing.Point(425, 443);
            this.lblSeçilen.Name = "lblSeçilen";
            this.lblSeçilen.Size = new System.Drawing.Size(160, 31);
            this.lblSeçilen.TabIndex = 21;
            this.lblSeçilen.Text = "lblKoltukSayisi";
            this.lblSeçilen.Visible = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblSeansSec);
            this.groupBox6.Controls.Add(this.panelSeans);
            this.groupBox6.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox6.ForeColor = System.Drawing.Color.Teal;
            this.groupBox6.Location = new System.Drawing.Point(374, 85);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.groupBox6.Size = new System.Drawing.Size(481, 317);
            this.groupBox6.TabIndex = 19;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "SEANS SAATİ";
            // 
            // lblSeansSec
            // 
            this.lblSeansSec.AutoSize = true;
            this.lblSeansSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSeansSec.ForeColor = System.Drawing.Color.Teal;
            this.lblSeansSec.Location = new System.Drawing.Point(212, 8);
            this.lblSeansSec.Name = "lblSeansSec";
            this.lblSeansSec.Size = new System.Drawing.Size(75, 16);
            this.lblSeansSec.TabIndex = 20;
            this.lblSeansSec.Text = "gg/aa/yyyy";
            this.lblSeansSec.Visible = false;
            // 
            // panelSeans
            // 
            this.panelSeans.AutoScroll = true;
            this.panelSeans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSeans.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelSeans.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panelSeans.ForeColor = System.Drawing.Color.Black;
            this.panelSeans.Location = new System.Drawing.Point(10, 27);
            this.panelSeans.Name = "panelSeans";
            this.panelSeans.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.panelSeans.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelSeans.Size = new System.Drawing.Size(468, 287);
            this.panelSeans.TabIndex = 20;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.nYıl);
            this.groupBox5.Controls.Add(this.nAy);
            this.groupBox5.Controls.Add(this.nGun);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox5.ForeColor = System.Drawing.Color.Teal;
            this.groupBox5.Location = new System.Drawing.Point(17, 251);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.groupBox5.Size = new System.Drawing.Size(287, 63);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "TARİH";
            // 
            // nYıl
            // 
            this.nYıl.Font = new System.Drawing.Font("Microsoft Tai Le", 10F);
            this.nYıl.Location = new System.Drawing.Point(168, 28);
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
            this.nYıl.Size = new System.Drawing.Size(124, 29);
            this.nYıl.TabIndex = 17;
            this.nYıl.Value = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            // 
            // nAy
            // 
            this.nAy.Font = new System.Drawing.Font("Microsoft Tai Le", 10F);
            this.nAy.Location = new System.Drawing.Point(85, 28);
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
            this.nAy.Size = new System.Drawing.Size(75, 29);
            this.nAy.TabIndex = 16;
            this.nAy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nGun
            // 
            this.nGun.Font = new System.Drawing.Font("Microsoft Tai Le", 10F);
            this.nGun.Location = new System.Drawing.Point(3, 29);
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
            this.nGun.Size = new System.Drawing.Size(75, 29);
            this.nGun.TabIndex = 15;
            this.nGun.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(209, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "gg/aa/yyyy";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbFilmAdi);
            this.groupBox2.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.Teal;
            this.groupBox2.Location = new System.Drawing.Point(12, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.groupBox2.Size = new System.Drawing.Size(287, 65);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FİLM ADI";
            // 
            // cbFilmAdi
            // 
            this.cbFilmAdi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cbFilmAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilmAdi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFilmAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbFilmAdi.FormattingEnabled = true;
            this.cbFilmAdi.Location = new System.Drawing.Point(10, 32);
            this.cbFilmAdi.Name = "cbFilmAdi";
            this.cbFilmAdi.Size = new System.Drawing.Size(274, 30);
            this.cbFilmAdi.TabIndex = 0;
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.Gray;
            this.btnTemizle.FlatAppearance.BorderSize = 0;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.Color.White;
            this.btnTemizle.Location = new System.Drawing.Point(185, 330);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(145, 34);
            this.btnTemizle.TabIndex = 32;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnOluştur
            // 
            this.btnOluştur.BackColor = System.Drawing.Color.Gray;
            this.btnOluştur.FlatAppearance.BorderSize = 0;
            this.btnOluştur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOluştur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOluştur.ForeColor = System.Drawing.Color.White;
            this.btnOluştur.Location = new System.Drawing.Point(22, 330);
            this.btnOluştur.Name = "btnOluştur";
            this.btnOluştur.Size = new System.Drawing.Size(145, 34);
            this.btnOluştur.TabIndex = 31;
            this.btnOluştur.Text = "TAMAMLA";
            this.btnOluştur.UseVisualStyleBackColor = false;
            this.btnOluştur.Click += new System.EventHandler(this.btnOluştur_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbDoluSaatler);
            this.groupBox1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.Teal;
            this.groupBox1.Location = new System.Drawing.Point(20, 421);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.groupBox1.Size = new System.Drawing.Size(287, 63);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DOLU SAATLER";
            this.groupBox1.Visible = false;
            // 
            // cbDoluSaatler
            // 
            this.cbDoluSaatler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cbDoluSaatler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDoluSaatler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDoluSaatler.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbDoluSaatler.FormattingEnabled = true;
            this.cbDoluSaatler.Location = new System.Drawing.Point(10, 30);
            this.cbDoluSaatler.Name = "cbDoluSaatler";
            this.cbDoluSaatler.Size = new System.Drawing.Size(274, 30);
            this.cbDoluSaatler.TabIndex = 0;
            // 
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(899, 434);
            this.Controls.Add(this.lblSeçilen);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnOluştur);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(450, 210);
            this.Name = "Form14";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form14";
            this.Load += new System.EventHandler(this.Form14_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nYıl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGun)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lblSeçilen;
        private System.Windows.Forms.ComboBox cbSalon;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblSeansSec;
        private System.Windows.Forms.FlowLayoutPanel panelSeans;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbFilmAdi;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnOluştur;
        private System.Windows.Forms.NumericUpDown nYıl;
        private System.Windows.Forms.NumericUpDown nAy;
        private System.Windows.Forms.NumericUpDown nGun;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbDoluSaatler;
    }
}