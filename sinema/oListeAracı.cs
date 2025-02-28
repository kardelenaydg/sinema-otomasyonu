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
    public partial class oListeAracı : UserControl
    {
        public oListeAracı()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;port=3307;Database=vizyonvt;Uid=root;Pwd=Whiteman3000;");
        private void lblAdi_Click(object sender, EventArgs e)
        {
            if (lblAdi.ForeColor == Color.Black)
            {
                lblAdi.ForeColor = Color.Brown;
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("insert into secılenler (KISI,TUR) values (@kısı,@tur)", baglanti);
                komut.Parameters.AddWithValue("@kısı", lblAdi.Text);
                komut.Parameters.AddWithValue("@tur", "OYUNCU");
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            else
            {
                lblAdi.ForeColor = Color.Black;
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("delete from secılenler where KISI=@kısı AND TUR=@tur", baglanti);
                komut.Parameters.AddWithValue("@kısı", lblAdi.Text);
                komut.Parameters.AddWithValue("@tur", "OYUNCU");
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
        }

        private void lblAdi_MouseMove(object sender, MouseEventArgs e)
        {
            lblAdi.Font = new Font(lblAdi.Font.Name, 12, FontStyle.Underline);
        }

        private void lblAdi_MouseLeave(object sender, EventArgs e)
        {
            lblAdi.Font = new Font(lblAdi.Font.Name, 12, FontStyle.Regular);
        }

        private void oListeAracı_Load(object sender, EventArgs e)
        {

        }
    }
}
