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
    public partial class SalonEkle : Form
    {
        public SalonEkle()
        {
            InitializeComponent();
        }

        SinemaEntitiess se = new SinemaEntitiess();

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cmbxSalonAd.SelectedItem.ToString() == "Salon A")
            {
                SalonA salon = new SalonA();

                salon.Tarih = Convert.ToDateTime(txtTarih.Text);
                salon.SeansNo = cmbxSeans.SelectedItem.ToString();

                salon.A1 = "Bos";
                salon.A2 = "Bos";
                salon.A3 = "Bos";
                salon.A4 = "Bos";
                salon.A5 = "Bos";
                salon.B1 = "Bos";
                salon.B2 = "Bos";
                salon.B3 = "Bos";
                salon.B4 = "Bos";
                salon.B5 = "Bos";
                salon.C1 = "Bos";
                salon.C2 = "Bos";
                salon.C3 = "Bos";
                salon.C4 = "Bos";
                salon.C5 = "Bos";

                se.SalonA.Add(salon);
                se.SaveChanges();

                MessageBox.Show("Salon A Kaydedildi");
            }
            else if (cmbxSalonAd.SelectedItem.ToString() == "Salon B")
            {
                SalonB salon = new SalonB();

                salon.Tarih = Convert.ToDateTime(txtTarih.Text);
                salon.SeansNo = cmbxSeans.SelectedItem.ToString();

                salon.A1 = "Bos";
                salon.A2 = "Bos";
                salon.A3 = "Bos";
                salon.A4 = "Bos";
                salon.A5 = "Bos";
                salon.B1 = "Bos";
                salon.B2 = "Bos";
                salon.B3 = "Bos";
                salon.B4 = "Bos";
                salon.B5 = "Bos";
                salon.C1 = "Bos";
                salon.C2 = "Bos";
                salon.C3 = "Bos";
                salon.C4 = "Bos";
                salon.C5 = "Bos";

                se.SalonB.Add(salon);
                se.SaveChanges();

                MessageBox.Show("Salon B Kaydedildi");

            }
            else if (cmbxSalonAd.SelectedItem.ToString() == "Salon C")
            {
                SalonC salon = new SalonC();

                salon.Tarih = Convert.ToDateTime(txtTarih.Text);
                salon.SeansNo = cmbxSeans.SelectedItem.ToString();

                salon.A1 = "Bos";
                salon.A2 = "Bos";
                salon.A3 = "Bos";
                salon.A4 = "Bos";
                salon.A5 = "Bos";
                salon.B1 = "Bos";
                salon.B2 = "Bos";
                salon.B3 = "Bos";
                salon.B4 = "Bos";
                salon.B5 = "Bos";
                salon.C1 = "Bos";
                salon.C2 = "Bos";
                salon.C3 = "Bos";
                salon.C4 = "Bos";
                salon.C5 = "Bos";

                se.SalonC.Add(salon);
                se.SaveChanges();

                MessageBox.Show("Salon C Kaydedildi");

            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (cmbxSalonAd.SelectedItem.ToString() == "Salon A")
            {
                int id = Convert.ToInt32(txtID.Text);
                var salon = se.SalonA.Where(w => w.SalonId == id).FirstOrDefault();

                se.SalonA.Remove(salon);
                se.SaveChanges();

                MessageBox.Show("Salon A Silindi");
            }
            else if (cmbxSalonAd.SelectedItem.ToString() == "Salon B")
            {
                int id = Convert.ToInt32(txtID.Text);
                var salon = se.SalonB.Where(w => w.SalonId == id).FirstOrDefault();

                se.SalonB.Remove(salon);
                se.SaveChanges();

                MessageBox.Show("Salon B Silindi");

            }
            else if (cmbxSalonAd.SelectedItem.ToString() == "Salon C")
            {
                int id = Convert.ToInt32(txtID.Text);
                var salon = se.SalonC.Where(w => w.SalonId == id).FirstOrDefault();

                se.SalonC.Remove(salon);
                se.SaveChanges();

                MessageBox.Show("Salon C Silindi");

            }
        }
    }
}
