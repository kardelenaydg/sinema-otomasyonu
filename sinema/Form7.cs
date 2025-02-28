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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;port=3307;Database=vizyonvt;Uid=root;Pwd=Whiteman3000;");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnResimyukle_Click(object sender, EventArgs e)
        {
            if (txtSalonAdi.Text != "" && cbKoltukSayisi.Text != ""&&txtID.Text!="")
            {
                baglanti.Open();
                MySqlCommand kaydet=new MySqlCommand("insert into salonlar (SALONADI,KOLTUKSAYISI,ID) values (@p1,@p2,@p3)",baglanti);
                kaydet.Parameters.AddWithValue("@p1",txtSalonAdi.Text.ToUpper());
                kaydet.Parameters.AddWithValue("@p2", cbKoltukSayisi.Text);
                kaydet.Parameters.AddWithValue("@p3", txtID.Text);
                kaydet.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("salon kaydedildi");
                txtSalonAdi.Text = "";
                cbKoltukSayisi.Text = "";
                txtSalonAdi.Focus();
                listeGetir();
                
            }
            else
            {
                MessageBox.Show("Lütfen bir değer giriniz");
            }
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            listeGetir();
        }
        void kOlustur()
        {
            for(int i = 1;i<=200;i++)
            {
                cbKoltukSayisi.Items.Add(i);
            }
        }
        void listeGetir()
        {
            panelSalon.Controls.Clear();
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("select * from salonlar ", baglanti);
        MySqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                salonListesi arac = new salonListesi();
            arac.lblSalonAdi.Text = oku["SALONADI"].ToString();
            arac.lblKoltukSayisi.Text = oku["KOLTUKSAYISI"].ToString();
            panelSalon.Controls.Add(arac);
            kOlustur();
            }
    baglanti.Close();
        }

        private void cbKoltukSayisi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSalonAdi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
