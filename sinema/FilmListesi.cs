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
    public partial class FilmListesi : UserControl
    {
        public FilmListesi()
        {
            InitializeComponent();
        }

        private void groupBox9_Enter(object sender, EventArgs e)
        {

        }

        private void btnFilm_Click(object sender, EventArgs e)
        {
            Form10 frm = new Form10();
            frm.idNo=lblIdNo.Text;
            frm.ShowDialog();
        }
    }
}
