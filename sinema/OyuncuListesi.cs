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
    public partial class OyuncuListesi : UserControl
    {
        public OyuncuListesi()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;port=3307;Database=vizyonvt;Uid=root;Pwd=Whiteman3000;");
        private void OyuncuListesi_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand sil = new MySqlCommand("delete from oyuncular where ADSOYAD=@p1", baglanti);
            sil.Parameters.AddWithValue("@p1", lblAdSoyad.Text);
            sil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show(lblAdSoyad.Text + " kişisi silindi");
            this.Hide();
        }

        private void btnResimyukle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "select * from oyuncular where ADSOYAD=@p1";
            MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@p1", lblAdSoyad.Text);
            MySqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                MessageBox.Show("Biyografi: " + oku["BIYOGRAFI"].ToString(), oku["ADSOYAD"].ToString());
            }
            baglanti.Close();
        }
    }
}
