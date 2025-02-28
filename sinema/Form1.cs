using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace sinema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;port=3307;Database=vizyonvt;Uid=root;Pwd=Whiteman3000;");
        


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
              
                
                baglanti.Open();

               
                string query = "SELECT Kullanıcıadı, Ksifre FROM vt WHERE Kullanıcıadı = @username AND Ksifre = @password";
                MySqlCommand sorgula = new MySqlCommand(query, baglanti);

               
                sorgula.Parameters.AddWithValue("@username", textBox1.Text.Trim()); 
                sorgula.Parameters.AddWithValue("@password", textBox2.Text.Trim());    

                
                MySqlDataReader oku = sorgula.ExecuteReader();

                if (oku.Read())
                {
                    Form2 frm=new Form2();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı kullanıcı adı veya şifre!");
                }

                oku.Close();
                baglanti.Close();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox1.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }
    }
}
