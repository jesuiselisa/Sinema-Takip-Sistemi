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
    public partial class BiletAl : Form
    {
        public BiletAl()
        {
            InitializeComponent();
        }

        SinemaEntitiess se = new SinemaEntitiess();

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Biletler bilet = new Biletler();

            bilet.MusteriAdSoyad = txtAdSoyad.Text;
            bilet.FilmAd = txtFilmAd.Text;
            bilet.FilmFormat = txtFilmFormat.Text;
            bilet.FilmSeans = cmbxSeans.SelectedItem.ToString();
            bilet.DilFormat = cmbxDilFormat.SelectedItem.ToString();
            bilet.KoltukNo = txtKoltukNo.Text;
            bilet.MusteriTur = cmbxMusteriTur.Text;
            bilet.SalonAd = cmbxSalonAd.SelectedItem.ToString();
            bilet.SalonFormat = cmbxSalonFormat.SelectedItem.ToString();
            bilet.Sure = txtSure.Text;
            bilet.Tarih = Convert.ToDateTime(txtTarih.Text);
            bilet.EkBilgiler = radKola.SelectedIndex.ToString() + " " + radMisir.SelectedIndex.ToString() + " " + radGozluk.SelectedIndex.ToString();

            se.Biletler.Add(bilet);
            se.SaveChanges();

            MessageBox.Show("Bilet Eklendi");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            var bilet = se.Biletler.Where(w => w.BiletId == id).FirstOrDefault();

            se.Biletler.Remove(bilet);
            se.SaveChanges();

            MessageBox.Show("Bilet Silindi");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            var bilet = se.Biletler.Where(w => w.BiletId == id).FirstOrDefault();

            bilet.MusteriAdSoyad = txtAdSoyad.Text;
            bilet.FilmAd = txtFilmAd.Text;
            bilet.FilmFormat = txtFilmFormat.Text;
            bilet.FilmSeans = cmbxSeans.SelectedItem.ToString();
            bilet.DilFormat = cmbxDilFormat.SelectedItem.ToString();
            bilet.KoltukNo = txtKoltukNo.Text;
            bilet.MusteriTur = cmbxMusteriTur.Text;
            bilet.SalonAd = cmbxSalonAd.SelectedItem.ToString();
            bilet.SalonFormat = cmbxSalonFormat.SelectedItem.ToString();
            bilet.Sure = txtSure.Text;
            bilet.Tarih = Convert.ToDateTime(txtTarih.Text);
            bilet.EkBilgiler = radKola.SelectedIndex.ToString() + " " + radMisir.SelectedIndex.ToString() + " " + radGozluk.SelectedIndex.ToString();

            se.SaveChanges();
            MessageBox.Show("Bilet Güncellendi");
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            var bilet = se.Biletler.Where(w => w.MusteriAdSoyad == txtAdSoyad.Text).FirstOrDefault();

            txtID.Text = bilet.BiletId.ToString();
            txtFilmAd.Text = bilet.FilmAd;
            txtFilmFormat.Text = bilet.FilmFormat;
            cmbxSeans.SelectedItem = bilet.FilmSeans;
            cmbxDilFormat.SelectedItem = bilet.DilFormat;
            txtKoltukNo.Text = bilet.KoltukNo;
            cmbxMusteriTur.Text = bilet.MusteriTur;
            cmbxSalonAd.SelectedItem = bilet.SalonAd;
            cmbxSalonFormat.SelectedItem = bilet.SalonFormat;
            txtSure.Text = bilet.Sure;
            txtTarih.Text = bilet.Tarih.ToString();
        }

        private void btnGoruntule_Click(object sender, EventArgs e)
        {
            if (cmbxSalonAd.SelectedItem.ToString() == "Salon A")
            {
                DateTime tarih = Convert.ToDateTime(txtTarih.Text);
                string seans = cmbxSeans.SelectedItem.ToString();
                var koltuk = se.SalonA.Where(w => w.Tarih == tarih && w.SeansNo == seans).FirstOrDefault();

                if (koltuk.A1 == "Bos")
                {
                    btnA1.BackColor = Color.MediumSeaGreen;
                }
                else
                {
                    btnA1.BackColor = Color.Crimson;
                }

                if (koltuk.A2 == "Bos")
                {
                    btnA2.BackColor = Color.MediumSeaGreen;
                }
                else
                {
                    btnA2.BackColor = Color.Crimson;
                }

                if (koltuk.A3 == "Bos")
                {
                    btnA3.BackColor = Color.MediumSeaGreen;
                }
                else
                {
                    btnA3.BackColor = Color.Crimson;
                }

                if (koltuk.A4 == "Bos")
                {
                    btnA4.BackColor = Color.MediumSeaGreen;
                }
                else
                {
                    btnA4.BackColor = Color.Crimson;
                }

                if (koltuk.A5 == "Bos")
                {
                    btnA5.BackColor = Color.MediumSeaGreen;
                }
                else
                {
                    btnA5.BackColor = Color.Crimson;
                }

                if (koltuk.B1 == "Bos")
                {
                    btnB1.BackColor = Color.MediumSeaGreen;
                }
                else
                {
                    btnB1.BackColor = Color.Crimson;
                }

                if (koltuk.B2 == "Bos")
                {
                    btnB2.BackColor = Color.MediumSeaGreen;
                }
                else
                {
                    btnB2.BackColor = Color.Crimson;
                }

                if (koltuk.B3 == "Bos")
                {
                    btnB3.BackColor = Color.MediumSeaGreen;
                }
                else
                {
                    btnB3.BackColor = Color.Crimson;
                }

                if (koltuk.B4 == "Bos")
                {
                    btnB4.BackColor = Color.MediumSeaGreen;
                }
                else
                {
                    btnB4.BackColor = Color.Crimson;
                }

                if (koltuk.B5 == "Bos")
                {
                    btnB5.BackColor = Color.MediumSeaGreen;
                }
                else
                {
                    btnB5.BackColor = Color.Crimson;
                }

                if (koltuk.C1 == "Bos")
                {
                    btnC1.BackColor = Color.MediumSeaGreen;
                }
                else
                {
                    btnC1.BackColor = Color.Crimson;
                }

                if (koltuk.C2 == "Bos")
                {
                    btnC2.BackColor = Color.MediumSeaGreen;
                }
                else
                {
                    btnC2.BackColor = Color.Crimson;
                }

                if (koltuk.C3 == "Bos")
                {
                    btnC3.BackColor = Color.MediumSeaGreen;
                }
                else
                {
                    btnC3.BackColor = Color.Crimson;
                }

                if (koltuk.C4 == "Bos")
                {
                    btnC4.BackColor = Color.MediumSeaGreen;
                }
                else
                {
                    btnC4.BackColor = Color.Crimson;
                }

                if (koltuk.C5 == "Bos")
                {
                    btnC5.BackColor = Color.MediumSeaGreen;
                }
                else
                {
                    btnC5.BackColor = Color.Crimson;
                }

            }
            else if (cmbxSalonAd.SelectedItem.ToString() == "Salon B")
            {
                DateTime tarih = Convert.ToDateTime(txtTarih.Text);
                string seans = cmbxSeans.SelectedItem.ToString();
                var koltuk = se.SalonB.Where(w => w.Tarih == tarih && w.SeansNo == seans).FirstOrDefault();

                if (koltuk.A1 == "Bos")
                {
                    btnA1.BackColor = Color.MediumSeaGreen;
                }
                else
                {
                    btnA1.BackColor = Color.Crimson;
                }

                if (koltuk.A2 == "Bos")
                {
                    btnA2.BackColor = Color.MediumSeaGreen;
                }
                else
                {
                    btnA2.BackColor = Color.Crimson;
                }

                if (koltuk.A3 == "Bos")
                {
                    btnA3.BackColor = Color.MediumSeaGreen;
                }
                else
                {
                    btnA3.BackColor = Color.Crimson;
                }

                if (koltuk.A4 == "Bos")
                {
                    btnA4.BackColor = Color.MediumSeaGreen;
                }
                else
                {
                    btnA4.BackColor = Color.Crimson;
                }

                if (koltuk.A5 == "Bos")
                {
                    btnA5.BackColor = Color.MediumSeaGreen;
                }
                else
                {
                    btnA5.BackColor = Color.Crimson;
                }

                if (koltuk.B1 == "Bos")
                {
                    btnB1.BackColor = Color.MediumSeaGreen;
                }
                else
                {
                    btnB1.BackColor = Color.Crimson;
                }

                if (koltuk.B2 == "Bos")
                {
                    btnB2.BackColor = Color.MediumSeaGreen;
                }
                else
                {
                    btnB2.BackColor = Color.Crimson;
                }

                if (koltuk.B3 == "Bos")
                {
                    btnB3.BackColor = Color.MediumSeaGreen;
                }
                else
                {
                    btnB3.BackColor = Color.Crimson;
                }

                if (koltuk.B4 == "Bos")
                {
                    btnB4.BackColor = Color.MediumSeaGreen;
                }
                else
                {
                    btnB4.BackColor = Color.Crimson;
                }

                if (koltuk.B5 == "Bos")
                {
                    btnB5.BackColor = Color.MediumSeaGreen;
                }
                else
                {
                    btnB5.BackColor = Color.Crimson;
                }

                if (koltuk.C1 == "Bos")
                {
                    btnC1.BackColor = Color.MediumSeaGreen;
                }
                else
                {
                    btnC1.BackColor = Color.Crimson;
                }

                if (koltuk.C2 == "Bos")
                {
                    btnC2.BackColor = Color.MediumSeaGreen;
                }
                else
                {
                    btnC2.BackColor = Color.Crimson;
                }

                if (koltuk.C3 == "Bos")
                {
                    btnC3.BackColor = Color.MediumSeaGreen;
                }
                else
                {
                    btnC3.BackColor = Color.Crimson;
                }

                if (koltuk.C4 == "Bos")
                {
                    btnC4.BackColor = Color.MediumSeaGreen;
                }
                else
                {
                    btnC4.BackColor = Color.Crimson;
                }

                if (koltuk.C5 == "Bos")
                {
                    btnC5.BackColor = Color.MediumSeaGreen;
                }
                else
                {
                    btnC5.BackColor = Color.Crimson;
                }
            }
            else if (cmbxSalonAd.SelectedItem.ToString() == "Salon C")
            {
                DateTime tarih = Convert.ToDateTime(txtTarih.Text);
                string seans = cmbxSeans.SelectedItem.ToString();
                var koltuk = se.SalonC.Where(w => w.Tarih == tarih && w.SeansNo == seans).FirstOrDefault();

                if (koltuk.A1 == "Bos")
                {
                    btnA1.BackColor = Color.MediumSeaGreen;
                }
                else
                {
                    btnA1.BackColor = Color.Crimson;
                }

                if (koltuk.A2 == "Bos")
                {
                    btnA2.BackColor = Color.MediumSeaGreen;
                }
                else
                {
                    btnA2.BackColor = Color.Crimson;
                }

                if (koltuk.A3 == "Bos")
                {
                    btnA3.BackColor = Color.MediumSeaGreen;
                }
                else
                {
                    btnA3.BackColor = Color.Crimson;
                }

                if (koltuk.A4 == "Bos")
                {
                    btnA4.BackColor = Color.MediumSeaGreen;
                }
                else
                {
                    btnA4.BackColor = Color.Crimson;
                }

                if (koltuk.A5 == "Bos")
                {
                    btnA5.BackColor = Color.MediumSeaGreen;
                }
                else
                {
                    btnA5.BackColor = Color.Crimson;
                }

                if (koltuk.B1 == "Bos")
                {
                    btnB1.BackColor = Color.MediumSeaGreen;
                }
                else
                {
                    btnB1.BackColor = Color.Crimson;
                }

                if (koltuk.B2 == "Bos")
                {
                    btnB2.BackColor = Color.MediumSeaGreen;
                }
                else
                {
                    btnB2.BackColor = Color.Crimson;
                }

                if (koltuk.B3 == "Bos")
                {
                    btnB3.BackColor = Color.MediumSeaGreen;
                }
                else
                {
                    btnB3.BackColor = Color.Crimson;
                }

                if (koltuk.B4 == "Bos")
                {
                    btnB4.BackColor = Color.MediumSeaGreen;
                }
                else
                {
                    btnB4.BackColor = Color.Crimson;
                }

                if (koltuk.B5 == "Bos")
                {
                    btnB5.BackColor = Color.MediumSeaGreen;
                }
                else
                {
                    btnB5.BackColor = Color.Crimson;
                }

                if (koltuk.C1 == "Bos")
                {
                    btnC1.BackColor = Color.MediumSeaGreen;
                }
                else
                {
                    btnC1.BackColor = Color.Crimson;
                }

                if (koltuk.C2 == "Bos")
                {
                    btnC2.BackColor = Color.MediumSeaGreen;
                }
                else
                {
                    btnC2.BackColor = Color.Crimson;
                }

                if (koltuk.C3 == "Bos")
                {
                    btnC3.BackColor = Color.MediumSeaGreen;
                }
                else
                {
                    btnC3.BackColor = Color.Crimson;
                }

                if (koltuk.C4 == "Bos")
                {
                    btnC4.BackColor = Color.MediumSeaGreen;
                }
                else
                {
                    btnC4.BackColor = Color.Crimson;
                }

                if (koltuk.C5 == "Bos")
                {
                    btnC5.BackColor = Color.MediumSeaGreen;
                }
                else
                {
                    btnC5.BackColor = Color.Crimson;
                }
            }
        }

        private void btnA1_Click(object sender, EventArgs e)
        {
            btnA1.BackColor = Color.Crimson;
        }

        private void btnA2_Click(object sender, EventArgs e)
        {
            btnA2.BackColor = Color.Crimson;
        }

        private void btnA3_Click(object sender, EventArgs e)
        {
            btnA3.BackColor = Color.Crimson;
        }

        private void btnA4_Click(object sender, EventArgs e)
        {
            btnA4.BackColor = Color.Crimson;
        }

        private void btnA5_Click(object sender, EventArgs e)
        {
            btnA5.BackColor = Color.Crimson;
        }

        private void btnB1_Click(object sender, EventArgs e)
        {
            btnB1.BackColor = Color.Crimson;
        }

        private void btnB2_Click(object sender, EventArgs e)
        {
            btnB2.BackColor = Color.Crimson;
        }

        private void btnB3_Click(object sender, EventArgs e)
        {
            btnB3.BackColor = Color.Crimson;
        }

        private void btnB4_Click(object sender, EventArgs e)
        {
            btnB4.BackColor = Color.Crimson;
        }

        private void btnB5_Click(object sender, EventArgs e)
        {
            btnB5.BackColor = Color.Crimson;
        }

        private void btnC1_Click(object sender, EventArgs e)
        {
            btnC1.BackColor = Color.Crimson;
        }

        private void btnC2_Click(object sender, EventArgs e)
        {
            btnC2.BackColor = Color.Crimson;
        }

        private void btnC3_Click(object sender, EventArgs e)
        {
            btnC3.BackColor = Color.Crimson;
        }

        private void btnC4_Click(object sender, EventArgs e)
        {
            btnC4.BackColor = Color.Crimson;
        }

        private void btnC5_Click(object sender, EventArgs e)
        {
            btnC5.BackColor = Color.Crimson;
        }


        private void btnA1_MouseEnter(object sender, EventArgs e)
        {
            btnA1.BackColor = Color.MediumSeaGreen;
        }

        private void btnA2_MouseEnter(object sender, EventArgs e)
        {
            btnA2.BackColor = Color.MediumSeaGreen;
        }

        private void btnA3_MouseEnter(object sender, EventArgs e)
        {
            btnA3.BackColor = Color.MediumSeaGreen;
        }

        private void btnA4_MouseEnter(object sender, EventArgs e)
        {
            btnA4.BackColor = Color.MediumSeaGreen;
        }

        private void btnA5_MouseEnter(object sender, EventArgs e)
        {
            btnA5.BackColor = Color.MediumSeaGreen;
        }

        private void btnB1_MouseEnter(object sender, EventArgs e)
        {
            btnB1.BackColor = Color.MediumSeaGreen;
        }

        private void btnB2_MouseEnter(object sender, EventArgs e)
        {
            btnB2.BackColor = Color.MediumSeaGreen;
        }

        private void btnB3_MouseEnter(object sender, EventArgs e)
        {
            btnB3.BackColor = Color.MediumSeaGreen;
        }

        private void btnB4_MouseEnter(object sender, EventArgs e)
        {
            btnB4.BackColor = Color.MediumSeaGreen;
        }

        private void btnB5_MouseEnter(object sender, EventArgs e)
        {
            btnB5.BackColor = Color.MediumSeaGreen;
        }

        private void btnC1_MouseEnter(object sender, EventArgs e)
        {
            btnC1.BackColor = Color.MediumSeaGreen;
        }

        private void btnC2_MouseEnter(object sender, EventArgs e)
        {
            btnC2.BackColor = Color.MediumSeaGreen;
        }

        private void btnC3_MouseEnter(object sender, EventArgs e)
        {
            btnC3.BackColor = Color.MediumSeaGreen;
        }

        private void btnC4_MouseEnter(object sender, EventArgs e)
        {
            btnC4.BackColor = Color.MediumSeaGreen;
        }

        private void btnC5_MouseEnter(object sender, EventArgs e)
        {
            btnC5.BackColor = Color.MediumSeaGreen;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cmbxSalonAd.SelectedItem.ToString() == "Salon A")
            {
                DateTime tarih = Convert.ToDateTime(txtTarih.Text);
                string seans = cmbxSeans.SelectedItem.ToString();
                var salon = se.SalonA.Where(w => w.Tarih == tarih && w.SeansNo == seans).FirstOrDefault();

                if (btnA1.BackColor == Color.MediumSeaGreen)
                {
                    salon.A1 = "Bos";
                }
                else
                {
                    salon.A1 = "Dolu";
                }

                if (btnA2.BackColor == Color.MediumSeaGreen)
                {
                    salon.A2 = "Bos";
                }
                else
                {
                    salon.A2 = "Dolu";
                }

                if (btnA3.BackColor == Color.MediumSeaGreen)
                {
                    salon.A3 = "Bos";
                }
                else
                {
                    salon.A3 = "Dolu";
                }

                if (btnA4.BackColor == Color.MediumSeaGreen)
                {
                    salon.A4 = "Bos";
                }
                else
                {
                    salon.A4 = "Dolu";
                }

                if (btnA5.BackColor == Color.MediumSeaGreen)
                {
                    salon.A5 = "Bos";
                }
                else
                {
                    salon.A5 = "Dolu";
                }

                if (btnB1.BackColor == Color.MediumSeaGreen)
                {
                    salon.B1 = "Bos";
                }
                else
                {
                    salon.B1 = "Dolu";
                }

                if (btnB2.BackColor == Color.MediumSeaGreen)
                {
                    salon.B2 = "Bos";
                }
                else
                {
                    salon.B2 = "Dolu";
                }

                if (btnB3.BackColor == Color.MediumSeaGreen)
                {
                    salon.B3 = "Bos";
                }
                else
                {
                    salon.B3 = "Dolu";
                }

                if (btnB4.BackColor == Color.MediumSeaGreen)
                {
                    salon.B4 = "Bos";
                }
                else
                {
                    salon.B4 = "Dolu";
                }

                if (btnB5.BackColor == Color.MediumSeaGreen)
                {
                    salon.B5 = "Bos";
                }
                else
                {
                    salon.B5 = "Dolu";
                }

                if (btnC1.BackColor == Color.MediumSeaGreen)
                {
                    salon.C1 = "Bos";
                }
                else
                {
                    salon.C1 = "Dolu";
                }

                if (btnC2.BackColor == Color.MediumSeaGreen)
                {
                    salon.C2 = "Bos";
                }
                else
                {
                    salon.C2 = "Dolu";
                }

                if (btnC3.BackColor == Color.MediumSeaGreen)
                {
                    salon.C3 = "Bos";
                }
                else
                {
                    salon.C3 = "Dolu";
                }

                if (btnC4.BackColor == Color.MediumSeaGreen)
                {
                    salon.C4 = "Bos";
                }
                else
                {
                    salon.C4 = "Dolu";
                }

                if (btnC5.BackColor == Color.MediumSeaGreen)
                {
                    salon.C5 = "Bos";
                }
                else
                {
                    salon.C5 = "Dolu";
                }

              
                se.SaveChanges();

                MessageBox.Show("Salon A Kaydedildi");
            }
            else if (cmbxSalonAd.SelectedItem.ToString() == "Salon B")
            {
                DateTime tarih = Convert.ToDateTime(txtTarih.Text);
                string seans = cmbxSeans.SelectedItem.ToString();
                var salon = se.SalonB.Where(w => w.Tarih == tarih && w.SeansNo == seans).FirstOrDefault();

                if (btnA1.BackColor == Color.MediumSeaGreen)
                {
                    salon.A1 = "Bos";
                }
                else
                {
                    salon.A1 = "Dolu";
                }

                if (btnA2.BackColor == Color.MediumSeaGreen)
                {
                    salon.A2 = "Bos";
                }
                else
                {
                    salon.A2 = "Dolu";
                }

                if (btnA3.BackColor == Color.MediumSeaGreen)
                {
                    salon.A3 = "Bos";
                }
                else
                {
                    salon.A3 = "Dolu";
                }

                if (btnA4.BackColor == Color.MediumSeaGreen)
                {
                    salon.A4 = "Bos";
                }
                else
                {
                    salon.A4 = "Dolu";
                }

                if (btnA5.BackColor == Color.MediumSeaGreen)
                {
                    salon.A5 = "Bos";
                }
                else
                {
                    salon.A5 = "Dolu";
                }

                if (btnB1.BackColor == Color.MediumSeaGreen)
                {
                    salon.B1 = "Bos";
                }
                else
                {
                    salon.B1 = "Dolu";
                }

                if (btnB2.BackColor == Color.MediumSeaGreen)
                {
                    salon.B2 = "Bos";
                }
                else
                {
                    salon.B2 = "Dolu";
                }

                if (btnB3.BackColor == Color.MediumSeaGreen)
                {
                    salon.B3 = "Bos";
                }
                else
                {
                    salon.B3 = "Dolu";
                }

                if (btnB4.BackColor == Color.MediumSeaGreen)
                {
                    salon.B4 = "Bos";
                }
                else
                {
                    salon.B4 = "Dolu";
                }

                if (btnB5.BackColor == Color.MediumSeaGreen)
                {
                    salon.B5 = "Bos";
                }
                else
                {
                    salon.B5 = "Dolu";
                }

                if (btnC1.BackColor == Color.MediumSeaGreen)
                {
                    salon.C1 = "Bos";
                }
                else
                {
                    salon.C1 = "Dolu";
                }

                if (btnC2.BackColor == Color.MediumSeaGreen)
                {
                    salon.C2 = "Bos";
                }
                else
                {
                    salon.C2 = "Dolu";
                }

                if (btnC3.BackColor == Color.MediumSeaGreen)
                {
                    salon.C3 = "Bos";
                }
                else
                {
                    salon.C3 = "Dolu";
                }

                if (btnC4.BackColor == Color.MediumSeaGreen)
                {
                    salon.C4 = "Bos";
                }
                else
                {
                    salon.C4 = "Dolu";
                }

                if (btnC5.BackColor == Color.MediumSeaGreen)
                {
                    salon.C5 = "Bos";
                }
                else
                {
                    salon.C5 = "Dolu";
                }

                se.SaveChanges();

                MessageBox.Show("Salon B Kaydedildi");

            }
            else if (cmbxSalonAd.SelectedItem.ToString() == "Salon C")
            {
                DateTime tarih = Convert.ToDateTime(txtTarih.Text);
                string seans = cmbxSeans.SelectedItem.ToString();
                var salon = se.SalonC.Where(w => w.Tarih == tarih && w.SeansNo == seans).FirstOrDefault();

                if (btnA1.BackColor == Color.MediumSeaGreen)
                {
                    salon.A1 = "Bos";
                }
                else
                {
                    salon.A1 = "Dolu";
                }

                if (btnA2.BackColor == Color.MediumSeaGreen)
                {
                    salon.A2 = "Bos";
                }
                else
                {
                    salon.A2 = "Dolu";
                }

                if (btnA3.BackColor == Color.MediumSeaGreen)
                {
                    salon.A3 = "Bos";
                }
                else
                {
                    salon.A3 = "Dolu";
                }

                if (btnA4.BackColor == Color.MediumSeaGreen)
                {
                    salon.A4 = "Bos";
                }
                else
                {
                    salon.A4 = "Dolu";
                }

                if (btnA5.BackColor == Color.MediumSeaGreen)
                {
                    salon.A5 = "Bos";
                }
                else
                {
                    salon.A5 = "Dolu";
                }

                if (btnB1.BackColor == Color.MediumSeaGreen)
                {
                    salon.B1 = "Bos";
                }
                else
                {
                    salon.B1 = "Dolu";
                }

                if (btnB2.BackColor == Color.MediumSeaGreen)
                {
                    salon.B2 = "Bos";
                }
                else
                {
                    salon.B2 = "Dolu";
                }

                if (btnB3.BackColor == Color.MediumSeaGreen)
                {
                    salon.B3 = "Bos";
                }
                else
                {
                    salon.B3 = "Dolu";
                }

                if (btnB4.BackColor == Color.MediumSeaGreen)
                {
                    salon.B4 = "Bos";
                }
                else
                {
                    salon.B4 = "Dolu";
                }

                if (btnB5.BackColor == Color.MediumSeaGreen)
                {
                    salon.B5 = "Bos";
                }
                else
                {
                    salon.B5 = "Dolu";
                }

                if (btnC1.BackColor == Color.MediumSeaGreen)
                {
                    salon.C1 = "Bos";
                }
                else
                {
                    salon.C1 = "Dolu";
                }

                if (btnC2.BackColor == Color.MediumSeaGreen)
                {
                    salon.C2 = "Bos";
                }
                else
                {
                    salon.C2 = "Dolu";
                }

                if (btnC3.BackColor == Color.MediumSeaGreen)
                {
                    salon.C3 = "Bos";
                }
                else
                {
                    salon.C3 = "Dolu";
                }

                if (btnC4.BackColor == Color.MediumSeaGreen)
                {
                    salon.C4 = "Bos";
                }
                else
                {
                    salon.C4 = "Dolu";
                }

                if (btnC5.BackColor == Color.MediumSeaGreen)
                {
                    salon.C5 = "Bos";
                }
                else
                {
                    salon.C5 = "Dolu";
                }

                se.SaveChanges();

                MessageBox.Show("Salon C Kaydedildi");

            }
        }
    }
}
