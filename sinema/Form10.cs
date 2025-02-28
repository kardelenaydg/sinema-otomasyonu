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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;port=3307;Database=vizyonvt;Uid=root;Pwd=Whiteman3000;");
        public string idNo = "";
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "select * from filmler WHERE ID=@p1";
            MySqlCommand komut=new MySqlCommand(sorgu,baglanti);
            komut.Parameters.AddWithValue("@p1", idNo);
            MySqlDataReader oku=komut.ExecuteReader();
            if (oku.Read())
            {
                pbResim.ImageLocation = oku["AFIS"].ToString();
                lblFilmAdı.Text = oku["ADI"].ToString();
                lblBicim.Text = oku["BICIMI"].ToString();
                lblOzellik.Text = oku["OZELLIKLERI"].ToString();
                lblOyuncu.Text = oku["OYUNCU"].ToString();
                lblYönetmen.Text = oku["YONETMEN"].ToString();
                lblVizyon.Text = oku["TARIH"].ToString();
                lblPuan.Text = oku["PUAN"].ToString();
                lblDetay.Text = oku["DETAY"].ToString();
                lblTürü.Text = oku["TURU"].ToString();
            }
            baglanti.Close();
        }
    }
}
