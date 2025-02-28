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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frm=new Form3();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 frm=new Form4();
            frm.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 frm=new Form5();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 frm=new Form6();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form7 frm=new Form7();
            frm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form8 frm=new Form8();
            frm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form9 frm=new Form9();
            frm.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form11 frm=new Form11();
            frm.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form12 frm=new Form12();
            frm.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form14 frm=new Form14();
            frm.ShowDialog();
        }
    }
}
