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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;port=3307;Database=vizyonvt;Uid=root;Pwd=Whiteman3000;");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            if (txtBiletNo.Text!="")
            {
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("select * from biletler WHERE BKOD=@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", txtBiletNo.Text.ToString());
                MySqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    Form13 frm = new Form13();
                    frm.biletNo = txtBiletNo.Text.ToString();
                    txtBiletNo.Text = "";
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("BİLET BULUNAMADI");
                    baglanti.Close();
                }
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("LÜTFEN BİLET NUMARASI GİRİNİZ");
            }
          
        }
    }
}
