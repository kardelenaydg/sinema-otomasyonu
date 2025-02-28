using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinema
{
    public partial class Kullanıcı : Form
    {
        public Kullanıcı()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form16 frm = new Form16();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form17 frm = new Form17();
            frm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form9 frm = new Form9();
            frm.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form11 frm = new Form11();
            frm.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form12 frm = new Form12();
            frm.ShowDialog();
        }
    }
}
