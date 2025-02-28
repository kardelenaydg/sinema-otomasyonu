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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;port=3307;Database=vizyonvt;Uid=root;Pwd=Whiteman3000;");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form17_Load(object sender, EventArgs e)
        {
            ListePaneli.Controls.Clear();
            baglanti.Open();
            string sorgu = "select * from oyuncular ";
            MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
            MySqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                OyuncuListesi2 arac = new OyuncuListesi2();
                arac.lblAdSoyad.Text = oku["ADSOYAD"].ToString();
                arac.pbResimDetay.ImageLocation = oku["RESİM"].ToString();
                ListePaneli.Controls.Add(arac);
            }
            baglanti.Clone();
        }
    }
}
