using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema
{
    public partial class PersonelListesi : Form
    {
        public PersonelListesi()
        {
            InitializeComponent();
        }

        SinemaEntitiess se = new SinemaEntitiess();

        private void btnGoruntule_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = se.Personeller.ToList();
        }
    }
}
