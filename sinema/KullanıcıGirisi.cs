using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sinema
{
    public partial class KullanıcıGirisi : Form
    {
        public KullanıcıGirisi()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;port=3307;Database=vizyonvt;Uid=root;Pwd=Whiteman3000;");
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     

        private void button2_Click(object sender, EventArgs e)
        {
            KayıtOl frm=new KayıtOl();
            frm.ShowDialog();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string query = "select KullaniciAdi, Sifre from kayitol WHERE KullaniciAdi=@p1 AND Sifre=@p2";
            MySqlCommand sorgula = new MySqlCommand(query, baglanti);
            sorgula.Parameters.AddWithValue("@p1", txtKullanıcıAdi.Text.Trim());
            sorgula.Parameters.AddWithValue("@p2", txtSifre.Text.Trim());
            MySqlDataReader oku = sorgula.ExecuteReader();
            if (oku.Read())
            {
                Kullanıcı frm = new Kullanıcı();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre!");
            }
            oku.Close();
            baglanti.Close();
            txtKullanıcıAdi.Text = "";
            txtSifre.Text = "";
            txtKullanıcıAdi.Focus();
            
        }
    }
}
