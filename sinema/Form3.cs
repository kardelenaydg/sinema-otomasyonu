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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;port=3307;Database=vizyonvt;Uid=root;Pwd=Whiteman3000;");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        public string resimYolu = "";
        private void btnResimyukle_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "RESİM SEÇME EKRANI";
            ofd.Filter = "PNG | *.png | JPG-JPEG | *.jpg;*.jpeg | All Files | *.*";
            ofd.FilterIndex = 3;

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                pbResim.Image=new Bitmap(ofd.FileName);
                resimYolu=ofd.FileName.ToString();
            }
        }

        private void rBErkek_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "erkek";
            
        }

        private void rBKadın_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "kadın";
        }

        public string cinsiyet = "erkek";

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
            if(txtAd.Text!=""&&txtSoyad.Text!=""&&txtBiyografi.Text!=""&& resimYolu != ""&&txtID.Text!="")
            {
                yasHesaplama();
                string adSoyad = txtAd.Text.ToString().ToUpper() + " " + txtSoyad.Text.ToString().ToUpper();
                string ID=txtID.Text.ToString().ToUpper();
                baglanti.Open();
                MySqlCommand kayit = new MySqlCommand("insert into yönetmen (ADSOYAD,CİNSİYET,YAS,BİYOGRAFİ,RESİM,ID) VALUES (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
                kayit.Parameters.AddWithValue("@p1", adSoyad);
                kayit.Parameters.AddWithValue("@p2", cinsiyet);
                kayit.Parameters.AddWithValue("@p3", bYas);
                kayit.Parameters.AddWithValue("@p4", txtBiyografi.Text.ToString());
                kayit.Parameters.AddWithValue("@p5", resimYolu);
                kayit.Parameters.AddWithValue("@p6", ID);
                kayit.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Yönetmen kayıt işlemi başarılı!");
                aracTemizle();
            }
            else if (txtID.Text == "")
            {
                MessageBox.Show("ID değeri zorunludur");
            }
            else
            {
                MessageBox.Show("Lütfen Tüm Alanları Eksiksiz Doldurunuz");
            }
        }
        void aracTemizle()
        {
            txtID.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtBiyografi.Text = "";
            nGun.Value = 1;
            nAy.Value = 1;
            nYıl.Value = 2024;
            rBErkek.Checked = true;
            rBKadın.Checked = false;
            cinsiyet = "0";
            bYas = "0";
            txtAd.Focus();
            pbResim.ImageLocation = @"C:\Users\Eren\Desktop\sinema foto\no-photo.png";
        }
        public string bYas="0";
        void yasHesaplama()
        {
            string dogum= nGun.Value.ToString()+"-"+nAy.Value.ToString()+"-"+nYıl.Value.ToString();
            DateTime dogumTarihi = Convert.ToDateTime(dogum);
            DateTime bugun = DateTime.Today;
            int yas = bugun.Year - dogumTarihi.Year;
            bYas =yas.ToString() ;
        }

        private void nGun_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pbResim_Click(object sender, EventArgs e)
        {

        }
    }
}
