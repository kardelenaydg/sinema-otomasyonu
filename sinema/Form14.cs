using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace sinema
{
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;port=3307;Database=vizyonvt;Uid=root;Pwd=Whiteman3000;");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            bugununTarihi();
            FilmAdiGeitr();
            SalonAdiGeitr();
        }
        void FilmAdiGeitr()
        {
            string sorgu = "select * from filmler ";
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
            MySqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cbFilmAdi.Items.Add(oku["ADI"].ToString());
            }
            baglanti.Close();
        }
        void SalonAdiGeitr()
        {
            string sorgu = "select * from salonlar ";
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
            MySqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cbSalon.Items.Add(oku["SALONADI"].ToString());
            }
            baglanti.Close();
        }
        void bugununTarihi()
        {
            nGun.Value = DateTime.Today.Day;
            nAy.Value = DateTime.Today.Month;
            nYıl.Value = DateTime.Today.Year;
        }

        private void btnOluştur_Click(object sender, EventArgs e)
        {
            if (btnOluştur.Text == "TAMAMLA")
            {
                string sorgu = "select DISTINCT SAAT from kontrol WHERE TARIH=@tarih AND SALONADI=@salonadi";
                string tarih=nGun.Value+"-"+nAy.Value+"-"+nYıl.Value;
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@tarih",tarih);
                komut.Parameters.AddWithValue("@salonadi",cbSalon.Text.ToString());
                MySqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    cbDoluSaatler.Items.Add(oku["SAAT"].ToString());
                }
                baglanti.Close();
                seansKONTROL();
                btnOluştur.Text = "OLUŞTUR";
            }
            else
            {
                kaydet();
                temizle();
                btnOluştur.Text = "TAMAMLA";
            }
        }
        void kaydet()
        {
            string sorgu = "insert into kontrol (FILMADI,TARIH,SAAT,SALONADI) Values (@filmadi,@tarih,@saat,@salonadi) ";
            string tarih = nGun.Value + "-" + nAy.Value + "-" + nYıl.Value;
            baglanti.Open();
            MySqlCommand ekle = new MySqlCommand(sorgu, baglanti);
            ekle.Parameters.AddWithValue("@filmadi",cbFilmAdi.Text);
            ekle.Parameters.AddWithValue("@tarih", tarih);
            ekle.Parameters.AddWithValue("@saat", lblSeçilen.Text);
            ekle.Parameters.AddWithValue("@salonadi", cbSalon.Text);
            ekle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("SALON ATAMA BAŞARILI");
        }
        void seansSaatler(object sender,EventArgs e)
        {
            foreach(RadioButton item in panelSeans.Controls)
            {
                if (item.Checked)
                {
                    lblSeçilen.Text = item.Text.ToString();
                }
            }
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
        void temizle()
        {
            cbFilmAdi.Items.Clear();
            cbSalon.Items.Clear();
            cbDoluSaatler.Items.Clear();
            lblSeçilen.Text = "";
            bugununTarihi();
            FilmAdiGeitr();
            SalonAdiGeitr();
            panelSeans.Controls.Clear();
            btnOluştur.Text = "TAMAMLA";
        }
        void seansKONTROL()
        {
            panelSeans.Controls.Clear();
            for (int i = 10; i <= 22; i++)
            {
                for (int j = 0; j <= 30; j += 30)
                {
                    RadioButton rnd = new RadioButton();
                    rnd.Width = 70;
                    rnd.CheckedChanged += new EventHandler(seansSaatler);
                    if (j == 0)
                    {
                        rnd.Text = i.ToString() + ":" + j.ToString() + "0";
                    }
                    else
                    {
                        rnd.Text = i.ToString() + ":" + j.ToString();
                    }
                    if (cbDoluSaatler.Items.Contains(rnd.Text))
                    {
                        rnd.Visible = false;
                    }

                    panelSeans.Controls.Add(rnd);
                }
            }
        }
    }
}
