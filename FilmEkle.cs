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
    public partial class FilmEkle : Form
    {
        public FilmEkle()
        {
            InitializeComponent();
        }

        SinemaEntitiess se = new SinemaEntitiess();

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Filmler film = new Filmler();

            film.FilmAd = txtFilmAd.Text;
            film.Basrol = txtBasrol.Text;
            film.Dil = txtDil.Text;
            film.IMDb = txtImdb.Text;
            film.Konu = txtKonu.Text;
            film.Senarist = txtSenarist.Text;
            film.Sure = txtSure.Text;
            film.Tur = txtTur.Text;
            film.VizyonTarihi = Convert.ToDateTime(dateTimePicker1.Value);
            film.YetiskinlikDuzeyi = txtYetiskinlikDuzeyi.Text;
            film.Yonetmen = txtYonetmen.Text;

            se.Filmler.Add(film);
            se.SaveChanges();

            MessageBox.Show("Film Eklendi");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            var film = se.Filmler.Where(w => w.FilmId == id).FirstOrDefault();

            se.Filmler.Remove(film);
            se.SaveChanges();

            MessageBox.Show("Film Silindi");
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            var film = se.Filmler.Where(w => w.FilmAd == txtFilmAd.Text).FirstOrDefault();

            txtID.Text = film.FilmId.ToString();
            txtBasrol.Text = film.Basrol;
            txtDil.Text = film.Dil;
            txtImdb.Text = film.IMDb;
            txtKonu.Text = film.Konu;
            txtSenarist.Text = film.Senarist;
            txtSure.Text = film.Sure;
            txtTur.Text = film.Tur;
            dateTimePicker1.Value = film.VizyonTarihi.Value;
            txtYetiskinlikDuzeyi.Text = film.YetiskinlikDuzeyi;
            txtYonetmen.Text = film.Yonetmen;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            var film = se.Filmler.Where(w => w.FilmId == id).FirstOrDefault();

            film.FilmAd = txtFilmAd.Text;
            film.Basrol = txtBasrol.Text;
            film.Dil = txtDil.Text;
            film.IMDb = txtImdb.Text;
            film.Konu = txtKonu.Text;
            film.Senarist = txtSenarist.Text;
            film.Sure = txtSure.Text;
            film.Tur = txtTur.Text;
            film.VizyonTarihi = Convert.ToDateTime(dateTimePicker1.Value);
            film.YetiskinlikDuzeyi = txtYetiskinlikDuzeyi.Text;
            film.Yonetmen = txtYonetmen.Text;

            se.SaveChanges();

            MessageBox.Show("Film Güncellendi");
        }
    }
}
