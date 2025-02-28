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
using Org.BouncyCastle.Asn1.X509;

namespace sinema
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;port=3307;Database=vizyonvt;Uid=root;Pwd=Whiteman3000;");
        public string biletNo = "";
        private void Form13_Load(object sender, EventArgs e)
        {
            lblBiletNo.Text = biletNo;
            lblBiletNo2.Text = biletNo;
            barkodNoOluştur();
            bilgiGetir();
        }
        void bilgiGetir()
        {
            string sorgu = "select * from biletler WHERE BKOD=@kod";
            baglanti.Open();
            MySqlCommand getir = new MySqlCommand(sorgu, baglanti);
            getir.Parameters.AddWithValue("@kod", biletNo);
            MySqlDataReader oku=getir.ExecuteReader();
            if(oku.Read())
            {
                lblFilmAdi.Text = oku["FILMADI"].ToString();
                lblFilmAdi2.Text = oku["FILMADI"].ToString();
                lblTelNo.Text = oku["TELNO"].ToString();
                lblAdSoyad.Text = oku["ADSOYAD"].ToString();
                lblBiletTürü.Text = oku["TUR"].ToString();
                lblSalonAdi.Text = oku["SALON"].ToString();
                lblSalon2.Text = oku["SALON"].ToString();
                lblTarih2.Text = oku["TARIH"].ToString()+" "+oku["SAAT"].ToString();
                lblTarihSaat.Text = oku["TARIH"].ToString()+ " " + oku["SAAT"].ToString();
                lblIslemTarih.Text = oku["ISLEMSAATI"].ToString() ;
                lblKoltuklar.Text = oku["KOLTUKNO"].ToString();
                lblKoltuk2.Text = oku["KOLTUKNO"].ToString();

            }
            baglanti.Close();
        }
        void barkodNoOluştur()
        {
            Random rastgele = new Random();
            string karakterler = "123456789987612345678998765432154321123456789987123456789987654321654321123456789987654321123456789987654321";
            string kod = "";
            for (int i = 1; i < 11; i++)
            {
                kod += karakterler[rastgele.Next(karakterler.Length)];
            }
            lblBarkod1.Text = kod.ToString();
            lblBarkod2.Text = kod.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
