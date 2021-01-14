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
    public partial class SinemaGiris : Form
    {
        private int childFormNumber = 0;

        public SinemaGiris()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        SinemaEntitiess se = new SinemaEntitiess();

        private void btnGiris_Click(object sender, EventArgs e)
        {

            if (txtKullaniciAd.Text != null && txtSifre.Text !=null)
            {
                var personel = se.Personeller.Where(w => w.KullaniciAd == txtKullaniciAd.Text).FirstOrDefault();

                if (personel.Sifre == txtSifre.Text)
                {
                    menuStrip1.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Lütfen Kullanıcı Adını ve Şifresini Eksiksiz Giriniz!");
            }

        }

        private void personelListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelListesi frm = new PersonelListesi();
            frm.Show();
        }

        private void personelEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelEkle frm = new PersonelEkle();
            frm.Show();
        }

        private void filmListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilmListesi frm = new FilmListesi();
            frm.Show();
        }

        private void filmEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilmEkle frm = new FilmEkle();
            frm.Show();
        }

        private void biletListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BiletListesi frm = new BiletListesi();
            frm.Show();
        }

        private void biletAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BiletAl frm = new BiletAl();
            frm.Show();
        }

        private void salonBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalonBilgileri frm = new SalonBilgileri();
            frm.Show();
        }
        
    }
}
