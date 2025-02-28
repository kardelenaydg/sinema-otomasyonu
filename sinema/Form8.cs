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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;port=3307;Database=vizyonvt;Uid=root;Pwd=Whiteman3000;");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            verileriSil();
          
        }
        void verileriSil()
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("delete from secılenler", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        public string resimYolu = "";
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "RESİM SEÇME EKRANI";
            ofd.Filter = "PNG | *.png | JPG-JPEG | *.jpg;*.jpeg | All Files | *.*";
            ofd.FilterIndex = 3;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbResim.Image = new Bitmap(ofd.FileName);
                resimYolu = ofd.FileName.ToString();
            }
        }
        void kOlustur()
        {
            for (double i = 0; i <= 10; i+=0.1)
            {
                comboBox1.Items.Add(i);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void yListesiGetir()
        {
            string sorgu = "select * from yönetmen ORDER BY ADSOYAD ASC ";
            fYönetmenPaneli.Controls.Clear();
            baglanti.Open();
            MySqlCommand komut=new MySqlCommand(sorgu,baglanti);
            MySqlDataReader oku =komut.ExecuteReader();
            while(oku.Read())
            {
                yListeAraci arac = new yListeAraci();
                arac.lblAdi.Text = oku["ADSOYAD"].ToString();
                fYönetmenPaneli.Controls.Add(arac);
            }
            baglanti.Close();
        }
        void oListesiGetir()
        {
            string sorgu = "select * from oyuncular ORDER BY ADSOYAD ASC ";
            fOyuncuPaneli.Controls.Clear();
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
            MySqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                oListeAracı arac = new oListeAracı();
                arac.lblAdi.Text = oku["ADSOYAD"].ToString();
                fOyuncuPaneli.Controls.Add(arac);
            }
            baglanti.Close();
        }
        private void Form8_Load(object sender, EventArgs e)
        {
            yListesiGetir();
            oListesiGetir();
            kOlustur();
        }

        private void lblAksiyon_Click(object sender, EventArgs e)
        {
            if (lblAksiyon.ForeColor == Color.Black)
            {
                lblAksiyon.ForeColor = Color.Brown;
            }
            else
            {
                lblAksiyon.ForeColor = Color.Black;
            }
        }

        private void lblKorku_Click(object sender, EventArgs e)
        {
            if (lblKorku.ForeColor == Color.Black)
            {
                lblKorku.ForeColor = Color.Brown;
            }
            else
            {
                lblKorku.ForeColor = Color.Black;
            }
        }

        private void lblDrama_Click(object sender, EventArgs e)
        {
            if (lblDrama.ForeColor == Color.Black)
            {
                lblDrama.ForeColor = Color.Brown;
            }
            else
            {
                lblDrama.ForeColor = Color.Black;
            }
        }

        private void lblGerilim_Click(object sender, EventArgs e)
        {
            if (lblGerilim.ForeColor == Color.Black)
            {
                lblGerilim.ForeColor = Color.Brown;
            }
            else
            {
                lblGerilim.ForeColor = Color.Black;
            }
        }

        private void lblKomedi_Click(object sender, EventArgs e)
        {
            if (lblKomedi.ForeColor == Color.Black)
            {
                lblKomedi.ForeColor = Color.Brown;
            }
            else
            {
                lblKomedi.ForeColor = Color.Black;
            }
        }

        private void lblRomantik_Click(object sender, EventArgs e)
        {
            if (lblRomantik.ForeColor == Color.Black)
            {
                lblRomantik.ForeColor = Color.Brown;
            }
            else
            {
                lblRomantik.ForeColor = Color.Black;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (label2.ForeColor == Color.Black)
            {
                label2.ForeColor = Color.Brown;
            }
            else
            {
                label2.ForeColor = Color.Black;
            }
        }

        private void lblTürkçe_Click(object sender, EventArgs e)
        {
            if (lblTürkçe.ForeColor == Color.Black)
            {
                lblTürkçe.ForeColor = Color.Brown;
            }
            else
            {
                lblTürkçe.ForeColor = Color.Black;
            }
        }

        private void lblAltyazı_Click(object sender, EventArgs e)
        {
            if (lblAltyazı.ForeColor == Color.Black)
            {
                lblAltyazı.ForeColor = Color.Brown;
            }
            else
            {
                lblAltyazı.ForeColor = Color.Black;
            }
        }

        private void lblİngilizce_Click(object sender, EventArgs e)
        {
            if (lblİngilizce.ForeColor == Color.Black)
            {
                lblİngilizce.ForeColor = Color.Brown;
            }
            else
            {
                lblİngilizce.ForeColor = Color.Black;
            }
        }

        private void lblŞiddet_Click(object sender, EventArgs e)
        {
            if (lblŞiddet.ForeColor == Color.Black)
            {
                lblŞiddet.ForeColor = Color.Brown;
            }
            else
            {
                lblŞiddet.ForeColor = Color.Black;
            }
        }

        private void lblOlumsuz_Click(object sender, EventArgs e)
        {
            if (lblOlumsuz.ForeColor == Color.Black)
            {
                lblOlumsuz.ForeColor = Color.Brown;
            }
            else
            {
                lblOlumsuz.ForeColor = Color.Black;
            }
        }

        private void lblCinsellik_Click(object sender, EventArgs e)
        {
            if (lblCinsellik.ForeColor == Color.Black)
            {
                lblCinsellik.ForeColor = Color.Brown;
            }
            else
            {
                lblCinsellik.ForeColor = Color.Black;
            }
        }

        private void lblAşk_Click(object sender, EventArgs e)
        {
            if (lblAşk.ForeColor == Color.Black)
            {
                lblAşk.ForeColor = Color.Brown;
            }
            else
            {
                lblAşk.ForeColor = Color.Black;
            }
        }

        private void lbl18_Click(object sender, EventArgs e)
        {
            if (lbl18.ForeColor == Color.Black)
            {
                lbl18.ForeColor = Color.Brown;
            }
            else
            {
                lbl18.ForeColor = Color.Black;
            }
        }

        string yonetmen = "";
        string oyuncu = "";
        void secilenYonetmen()
        {
            yonetmen = "";
            string sorgu = "select * from secılenler WHERE TUR='YÖNETMEN'";
            baglanti.Open(); 
            MySqlCommand komut=new MySqlCommand(sorgu,baglanti);
            MySqlDataReader oku =komut.ExecuteReader();
            while (oku.Read())
            {
                yonetmen += " ," + oku["KISI"].ToString();
            }
            baglanti.Close();
        }
        void secilenOyuncu()
        {
            oyuncu = "";
            string sorgu = "select * from secılenler WHERE TUR='OYUNCU'";
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
            MySqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                oyuncu += " ," + oku["KISI"].ToString();
            }
            baglanti.Close();
        }
        void temizlemeMetodu()
        {
            this.Controls.Clear();
            this.InitializeComponent();
            textBox1.Focus();
            verileriSil();
            yListesiGetir();
            oListesiGetir();
            vizyonhesapla();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
           
            vizyonhesapla();
            secilenOyuncu();
            secilenYonetmen();
            tur();
            ozellık();
            bicim();
            if (txtID.Text!=""&&textBox1.Text!=""&&resimYolu!=""&&comboBox1.Text!=""&&yonetmen!=""&&oyuncu!=""&&secilenBicim!=""&&secilenTur!=""&&secilenOzellik!=""&&vtarih!=""&&textBox2.Text!="")
            {
                baglanti.Close();
                string sorgu = "insert into filmler (ID,ADI,TURU,OZELLIKLERI,BICIMI,YONETMEN,OYUNCU,DETAY,PUAN,AFIS,TARIH) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11) ";
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@p1", txtID.Text);
                komut.Parameters.AddWithValue("@p2", textBox1.Text.ToUpper());
                if (secilenTur.Length > 2)
                {
                    komut.Parameters.AddWithValue("@p3", secilenTur.Substring(2));

                }
                else
                {
                    komut.Parameters.AddWithValue("@p3", secilenTur);
                }
                if (secilenOzellik.Length > 2)
                {
                    komut.Parameters.AddWithValue("@p4", secilenOzellik.Substring(2));

                }
                else
                {
                    komut.Parameters.AddWithValue("@p4", secilenOzellik);
                }
                if (secilenBicim.Length > 2)
                {
                    komut.Parameters.AddWithValue("@p5", secilenBicim.Substring(2));

                }
                else
                {
                    komut.Parameters.AddWithValue("@p5", secilenBicim);
                }
                if (yonetmen.Length > 2)
                {
                    komut.Parameters.AddWithValue("@p6", yonetmen.Substring(2));

                }
                else
                {
                    komut.Parameters.AddWithValue("@p6", yonetmen);
                }
                if (oyuncu.Length > 2)
                {
                    komut.Parameters.AddWithValue("@p7", oyuncu.Substring(2));

                }
                else
                {
                    komut.Parameters.AddWithValue("@p7", oyuncu);
                }
                komut.Parameters.AddWithValue("@p8", textBox2.Text.ToUpper());
                komut.Parameters.AddWithValue("@p9", comboBox1.Text);
                komut.Parameters.AddWithValue("@p10", pbResim);
                komut.Parameters.AddWithValue("@p11", vtarih);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("film kaydı eklendi");
            }
            else
            {
                MessageBox.Show("LÜTFEN TÜM SEÇİMLERİ YAPINIZ");
            }
          
           
        }
        string secilenTur = "";
        string secilenOzellik = "";
        string secilenBicim = "";
        void tur()
        {
            foreach (Control arac in groupBox2.Controls)
            {
                if(arac is Label)
                {
                    if(arac.ForeColor==Color.Black)
                    {

                    }
                    else
                    {
                        secilenTur += " ," + arac.Text.ToString();
                    }
                }
            }
        }
        void ozellık()
        {
            foreach (Control arac in groupBox3.Controls)
            {
                if (arac is Label)
                {
                    if (arac.ForeColor == Color.Black)
                    {

                    }
                    else
                    {
                        secilenOzellik += " ," + arac.Text.ToString();
                    }
                }
            }
        }
        void bicim()
        {
            foreach (Control arac in groupBox4.Controls)
            {
                if (arac is Label)
                {
                    if (arac.ForeColor == Color.Black)
                    {

                    }
                    else
                    {
                        secilenBicim += " ," + arac.Text.ToString();
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        string vtarih = "";
        void vizyonhesapla()
        {
            vtarih=nGun.Value+"-"+nAy.Value+"-"+nYıl.Value;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
