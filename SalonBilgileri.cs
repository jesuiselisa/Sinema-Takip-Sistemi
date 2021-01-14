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
    public partial class SalonBilgileri : Form
    {
        public SalonBilgileri()
        {
            InitializeComponent();
        }

        SinemaEntitiess se = new SinemaEntitiess();

        private void cmbxSalonAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxSalonAd.SelectedItem.ToString() == "Salon A")
            {
                dataGridView1.DataSource = se.SalonA.ToList();
            }
            else if (cmbxSalonAd.SelectedItem.ToString() == "Salon B")
            {
                dataGridView1.DataSource = se.SalonB.ToList();
            }
            else if (cmbxSalonAd.SelectedItem.ToString() == "Salon C")
            {
                dataGridView1.DataSource = se.SalonC.ToList();
            }
            else
            {
                dataGridView1.DataSource = se.Salonlar.ToList();
            }
        }

        private void cmbxSeans_SelectedIndexChanged(object sender, EventArgs e)
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

        private void SalonBilgileri_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = se.Salonlar.ToList();
        }
    }
}
