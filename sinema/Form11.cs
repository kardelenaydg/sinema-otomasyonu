using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace sinema
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;port=3307;Database=vizyonvt;Uid=root;Pwd=Whiteman3000;");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void Form11_Load(object sender, EventArgs e)
        {
            FilmAdiGeitr();
            biletNoOluştur();
        }
        void biletNoOluştur()
        {
            Random rastgele =new Random();
            string karakterler = "123456789987612345678998765432154321123456789987123456789987654321654321123456789987654321123456789987654321";
            string kod = "";
            for(int i = 1;i<11;i++)
            {
                kod += karakterler[rastgele.Next(karakterler.Length)];
            }
            txtBarkod.Text = kod.ToString();
        }
        void FilmAdiGeitr()
        {
            string sorgu = "select * from filmler ";
            baglanti.Open();
            MySqlCommand komut =new MySqlCommand(sorgu,baglanti);
            MySqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cbFilmAdi.Items.Add(oku["ADI"].ToString());
            }
            baglanti.Close();
        }

        private void cbFilmAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbTarih.Items.Clear();
            string sorgu = "SELECT DISTINCT TARIH FROM kontrol WHERE FILMADI=@filmadi";
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand(sorgu,baglanti);
            komut.Parameters.AddWithValue("@filmadi", cbFilmAdi.Text.ToString());
            MySqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cbTarih.Items.Add(oku["TARIH"].ToString());
            }
            baglanti.Close();
        }

        

        private void cbTarih_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelSeans.Controls.Clear();
            string saatler = "";
            string sorgu = "SELECT DISTINCT SAAT FROM kontrol WHERE FILMADI=@filmadi AND TARIH=@tarih";
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@filmadi", cbFilmAdi.Text.ToString());
            komut.Parameters.AddWithValue("@tarih", cbTarih.Text.ToString());
            MySqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                saatler = oku["SAAT"].ToString();
                RadioButton rnd = new RadioButton();
                rnd.Text = saatler;
                rnd.ForeColor = Color.Black;
                rnd.Width = 70;
                rnd.FlatStyle = FlatStyle.Flat;
                rnd.CheckedChanged += new EventHandler(SeansSaatler);
                panelSeans.Controls.Add(rnd);
            }
            baglanti.Close();
        }
        void SeansSaatler(object sender,EventArgs e)
        {
            foreach(RadioButton item in panelSeans.Controls)
            {
                if (item.Checked)
                {
                    lblSeansSec.Text = item.Text+" seansı seçildi";
                    cbSalon.Items.Clear();

                    string sorgu = "SELECT DISTINCT SALONADI FROM kontrol WHERE FILMADI=@filmadi AND TARIH=@tarih AND SAAT=@saat";
                    baglanti.Open();
                    MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@filmadi", cbFilmAdi.Text.ToString());
                    komut.Parameters.AddWithValue("@tarih", cbTarih.Text.ToString());
                    komut.Parameters.AddWithValue("@saat", item.Text.ToString());
                    MySqlDataReader oku = komut.ExecuteReader();
                    while (oku.Read())
                    {
                        cbSalon.Items.Add(oku["SALONADI"].ToString());

                    }
                    baglanti.Close();
                }
            }
        }
        void biletNoSorgula()
        {
            string sorgu = "select * from biletler where BKOD=@no";
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@no",txtBarkod.Text.ToString());
            MySqlDataReader oku = komut.ExecuteReader();
            if (!oku.Read())
            {
                kaydetMetodu();
            }
            else
            {
                biletNoOluştur();
                baglanti.Close() ;
                biletNoSorgula();

            }
            baglanti.Close();
        }
        void kaydetMetodu()
        {
            string saat = lblSeansSec.Text.Replace(" seansı seçildi", "");
            string sorgu = "insert into biletler (BKOD, ADSOYAD, TELNO, KOLTUKNO, FILMADI, TARIH, SAAT, SALON, TUR, ISLEMSAATİ) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10) ";
            baglanti.Close();
            baglanti.Open();
            MySqlCommand kayit = new MySqlCommand(sorgu, baglanti);
            kayit.Parameters.AddWithValue("@p1",txtBarkod.Text.ToString());
            kayit.Parameters.AddWithValue("@p2",txtAdSoyad.Text.ToUpper().ToString());
            kayit.Parameters.AddWithValue("@p3",txtTelNo.Text.ToString());
            kayit.Parameters.AddWithValue("@p4",txtKoltuklar.Text.ToString());
            kayit.Parameters.AddWithValue("@p5",cbFilmAdi.Text.ToString());
            kayit.Parameters.AddWithValue("@p6",cbTarih.Text.ToString());
            kayit.Parameters.AddWithValue("@p7",saat);
            kayit.Parameters.AddWithValue("@p8",cbSalon.Text.ToString());
            kayit.Parameters.AddWithValue("@p9",cbBiletTürü.Text.ToString());
            kayit.Parameters.AddWithValue("@p10",DateTime.Now.ToString());
            kayit.ExecuteNonQuery();
            baglanti.Close();
            
            string sorgu2 = "UPDATE kontrol SET KOLTUKLAR=@numara WHERE FILMADI=@filmadi AND TARIH=@tarih AND SAAT=@saat AND SALONADI=@salonadi";
            baglanti.Open();
            MySqlCommand guncelle = new MySqlCommand(sorgu2, baglanti);
            if (lblGelenKoltuk.Text.ToString()=="")
            {
                guncelle.Parameters.AddWithValue("@numara",txtKoltuklar.Text.ToString());
            }
            else
            {
                guncelle.Parameters.AddWithValue("@numara", lblGelenKoltuk.Text.ToString() + "," + txtKoltuklar.Text.ToString());
            }
            guncelle.Parameters.AddWithValue("@filmadi", cbFilmAdi.Text.ToString());
            guncelle.Parameters.AddWithValue("@tarih", cbTarih.Text.ToString());
            guncelle.Parameters.AddWithValue("@saat", saat);
            guncelle.Parameters.AddWithValue("@salonadi", cbSalon.Text.ToString());
            guncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("BİLET SATIŞI BAŞARILI BİR ŞEKİLDE GERÇEKLEŞTİRİLDİ!");
            salonDurumGeldi();
            lblGelenKoltuk.Text = "";
            listeGelenKoltuk.Items.Clear();
            lbBelirlenen.Items.Clear();
            txtKoltuklar.Text = "";

        }
        private void btnOluştur_Click(object sender, EventArgs e)
        {
            if (txtAdSoyad.Text!=""&&txtBarkod.Text!=""&&txtKoltuklar.Text!=""&&txtTelNo.Text!=""&&cbBiletTürü.Text!=""&&cbFilmAdi.Text!=""&&cbSalon.Text!=""&&cbTarih.Text!="")
            {
                biletNoSorgula();
            }
            else
            {
                MessageBox.Show("TÜM ALANLARI OLDURUNUZ");
            }
        }
        void sectiklerimiz()
        {
            txtKoltuklar.Text = "";
            foreach(string item in lbBelirlenen.Items)
            {
                txtKoltuklar.Text += ","+item;
            }
            if(txtKoltuklar.Text.Length > 1 )
            {
                txtKoltuklar.Text = txtKoltuklar.Text.Substring(1);
            }
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn=(Button)sender;
            if (btn.ForeColor==Color.Black)
            {
                MessageBox.Show("BU KOLTUK DOLUDUR");
            }
            else
            {
                if (btn.ForeColor==Color.Yellow)
                {
                    btn.Image = (System.Drawing.Image)(Properties.Resources.sarı);
                    btn.ForeColor = Color.Blue;
                    lbBelirlenen.Items.Add(btn.Text);
                    sectiklerimiz();
                }
                else
                {
                    btn.Image = (System.Drawing.Image)(Properties.Resources.koltuk_mavi_sadece);
                    btn.ForeColor = Color.Yellow;
                    
                    lbBelirlenen.Items.Remove(btn.Text);
                    sectiklerimiz();
                }
            }
        }
        private void cbSalon_SelectedIndexChanged(object sender, EventArgs e)
        {
            salonDurumGeldi();
        }
        void salonDurumGeldi()
        {
            string sorgu = "SELECT * FROM salonlar WHERE SALONADI=@salomadi";
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@salomadi", cbSalon.Text.ToString());
            MySqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblKoltukSayisi.Text = oku["KOLTUKSAYISI"].ToString();

            }
            baglanti.Close();
            koltukGetir();
            DOLDUR();
        }
        void DOLDUR()
        {
            KoltukPaneli.Controls.Clear();
            int sayi = Convert.ToInt16(lblKoltukSayisi.Text);
            for (int i = 1; i <= sayi; i++)
            {
                Button btn = new Button();
                if (i <= 7)
                {
                    btn.Text = "A" + i.ToString();
                    btn.Name = "A" + i.ToString();
                }
                else if (i <= 14)
                {
                    btn.Text = "B" + (i-7).ToString();
                    btn.Name = "B" + (i-7).ToString();
                }
                else if (i <= 21)
                {
                    btn.Text = "C" + (i-14).ToString();
                    btn.Name = "C" + (i-14).ToString();
                }
                else if (i <= 28)
                {
                    btn.Text = "D" + (i-21).ToString();
                    btn.Name = "D" + (i-21).ToString();
                }
                else if (i <= 35)
                {
                    btn.Text = "E" + (i-28).ToString();
                    btn.Name = "E" + (i-28).ToString();
                }
                else if (i <= 42)
                {
                    btn.Text = "F" + (i-35).ToString();
                    btn.Name = "F" + (i-35).ToString();
                }
                else if (i <= 49)
                {
                    btn.Text = "G" + (i-42).ToString();
                    btn.Name = "G" + (i-42).ToString();
                }
                btn.Width = 50;
                btn.Height = 50;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;

                btn.BackColor = Color.White;
                btn.ForeColor = Color.White;
                btn.Click += Btn_Click;
                if (listeGelenKoltuk.Items.Contains(btn.Text))
                {
                    btn.Image = (System.Drawing.Image)(Properties.Resources.kırmızı);
                    btn.ForeColor= Color.Black;
                }
                else
                {
                    btn.Image = (System.Drawing.Image)(Properties.Resources.koltuk_mavi_sadece);
                    btn.ForeColor= Color.Yellow;
                }
                KoltukPaneli.Controls.Add(btn);
            }
        } 
        void koltukGetir()
        {
            lblGelenKoltuk.Text = "";
            string saat = lblSeansSec.Text.Replace(" seansı seçildi", "");
            string sorgu = "SELECT * FROM kontrol WHERE FILMADI=@filmadi AND TARIH=@tarih AND SAAT=@saat AND SALONADI=@salonadi";
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@filmadi", cbFilmAdi.Text.ToString());
            komut.Parameters.AddWithValue("@tarih", cbTarih.Text.ToString());
            komut.Parameters.AddWithValue("@saat",saat);
            komut.Parameters.AddWithValue("@salonadi", cbSalon.Text.ToString());
            MySqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblGelenKoltuk.Text += " ," + oku["KOLTUKLAR"].ToString();
                if (lblGelenKoltuk.Text.Length > 2)
                 {
                    lblGelenKoltuk.Text = lblGelenKoltuk.Text.Substring(2);
                }
                else
                {
                    lblGelenKoltuk.Text = "";
                }
               
            }
            
            baglanti.Close();
            koltukAyırma();


        }
        void koltukAyırma()
        {
            listeGelenKoltuk.Items.Clear();
            string no = "";
            string[] sec;
            no = lblGelenKoltuk.Text.ToString();
            sec = no.Split(',');
            foreach (string bulunan in sec)
            {
                listeGelenKoltuk.Items.Add(bulunan);
            }
        }

        private void lblKoltukSayisi_Click(object sender, EventArgs e)
        {

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAdSoyad.Text = "";
            txtTelNo.Text = "";
            txtKoltuklar.Text = "";
            cbBiletTürü.Text = "";
            cbSalon.Text = "";
            cbTarih.Text = "";
            txtBarkod.Text = "";
            lblGelenKoltuk.Text = "";
            lblKoltukSayisi.Text = "";
            lblSeansSec.Text = "";
            cbSalon.Items.Clear();
            cbTarih.Items.Clear();
            cbBiletTürü.Items.Clear();
            cbBiletTürü.Items.Add("YETİŞKEN");
            cbBiletTürü.Items.Add("ÖĞRENCİ");
            biletNoOluştur();
            panelSeans.Controls.Clear();
            KoltukPaneli.Controls.Clear();
            lbBelirlenen.Items.Clear();
            cbFilmAdi.Items.Clear();
            listeGelenKoltuk.Items.Clear();
            FilmAdiGeitr();
            txtAdSoyad.Focus();
            
            
        }

        private void txtBarkod_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
