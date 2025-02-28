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
    public partial class KayıtOl : Form
    {
        public KayıtOl()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;port=3307;Database=vizyonvt;Uid=root;Pwd=Whiteman3000;");
        private void btnKayıt_Click(object sender, EventArgs e)
        {
            if (txtAd.Text != "" && txtSoyad.Text != "" && txtTelNo.Text != "" && txtKullanıcıAdı.Text != "" && txtSifre.Text != "")
            {
                string sorgu2 = "select * from kayitol where KullaniciAdi=@kadi";
                baglanti.Open();
                MySqlCommand komut2 = new MySqlCommand(sorgu2, baglanti);
                komut2.Parameters.AddWithValue("@kadi", txtKullanıcıAdı.Text.ToString());
                MySqlDataReader oku = komut2.ExecuteReader();
                if (!oku.Read())
                {
                    baglanti.Close();
                    string ad = txtAd.Text.ToString().ToUpper();
                    string soyad = txtSoyad.Text.ToString().ToUpper();
                    baglanti.Open();
                    MySqlCommand kayit = new MySqlCommand("insert into kayitol (İsim,Soyisim,TelNo,KullaniciAdi,Sifre) VALUES (@p1,@p2,@p3,@p4,@p5)", baglanti);
                    kayit.Parameters.AddWithValue("@p1", ad);
                    kayit.Parameters.AddWithValue("@p2", soyad);
                    kayit.Parameters.AddWithValue("@p3", txtTelNo.Text.ToString());
                    kayit.Parameters.AddWithValue("@p4", txtKullanıcıAdı.Text.ToString());
                    kayit.Parameters.AddWithValue("@p5", txtSifre.Text.ToString());
                    kayit.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("KAYIT OLMA İŞLEMİ BAŞARILI");
                    aracTemizle();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı Kullanılıyor Lütfen Başka Bir Kullanıcı Adı Giriniz");
                    aracTemizle();
                    baglanti.Close();
                }
                baglanti.Close();

            }
         
            else
            {
                MessageBox.Show("Lütfen Tüm Alanları Eksiksiz Doldurunuz");
            }
        }
        void aracTemizle()
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtTelNo.Text = "";
            txtKullanıcıAdı.Text = "";
            txtSifre.Text = "";
            txtAd.Focus();
        }
    }
}
