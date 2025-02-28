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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;port=3307;Database=vizyonvt;Uid=root;Pwd=Whiteman3000;");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            ListePaneli.Controls.Clear(); 
            baglanti.Open();
            string sorgu = "select * from filmler";
            MySqlCommand komut=new MySqlCommand(sorgu,baglanti);
            MySqlDataReader oku=komut.ExecuteReader();
            while(oku.Read())
            {
                FilmListesi arac=new FilmListesi();
                arac.lblFilmAdi.Text = oku["ADI"].ToString();
                arac.pbResim.ImageLocation = oku["AFIS"].ToString() ;
                arac.lblIdNo.Text = oku["ID"].ToString();
                ListePaneli.Controls.Add(arac);
            }
            baglanti.Close();
        }
    }
}
