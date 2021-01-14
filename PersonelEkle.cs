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
    public partial class PersonelEkle : Form
    {
        public PersonelEkle()
        {
            InitializeComponent();
        }

        SinemaEntitiess se = new SinemaEntitiess();

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Personeller personel = new Personeller();

            personel.KullaniciAd = txtKullaniciAd.Text;
            personel.Sifre = txtSifre.Text;
            personel.AdSoyad = txtAdSoyad.Text;
            personel.Mail = txtMail.Text;
            personel.Gsm = txtGsm.Text;
            personel.DogumGunu = Convert.ToDateTime(dateTimePicker1.Value);
            personel.CV = txtCV.Text;
            personel.Adres = txtAdres.Text;

            se.Personeller.Add(personel);
            se.SaveChanges();

            MessageBox.Show("Personel Eklendi");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            var personel = se.Personeller.Where(w => w.PersonelId == id).FirstOrDefault();

            se.Personeller.Remove(personel);
            se.SaveChanges();

            MessageBox.Show("Personel Silindi");
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            var personel = se.Personeller.Where(w => w.KullaniciAd == txtKullaniciAd.Text).FirstOrDefault();

            txtID.Text = personel.PersonelId.ToString();
            txtAdres.Text = personel.Adres;
            txtAdSoyad.Text = personel.AdSoyad;
            txtCV.Text = personel.CV;
            txtGsm.Text = personel.Gsm;
            txtID.Text = personel.PersonelId.ToString();
            txtMail.Text = personel.Mail;
            txtSifre.Text = personel.Sifre;
            dateTimePicker1.Value = personel.DogumGunu.Value;

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            var personel = se.Personeller.Where(w => w.PersonelId == id).FirstOrDefault();

            personel.KullaniciAd = txtKullaniciAd.Text;
            personel.Sifre = txtSifre.Text;
            personel.AdSoyad = txtAdSoyad.Text;
            personel.Mail = txtMail.Text;
            personel.Gsm = txtGsm.Text;
            personel.DogumGunu = Convert.ToDateTime(dateTimePicker1.Value);
            personel.CV = txtCV.Text;
            personel.Adres = txtAdres.Text;

            se.SaveChanges();

            MessageBox.Show("Personel Güncellendi");
        }
    }
}
