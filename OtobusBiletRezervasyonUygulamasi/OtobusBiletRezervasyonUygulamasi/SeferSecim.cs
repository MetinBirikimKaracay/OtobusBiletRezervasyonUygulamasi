using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace OtobusBiletRezervasyonUygulamasi
{
    public partial class SeferSecim : Form
    {

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-QD6HDJ2\SQLEXPRESS;Initial Catalog=OtobusRezervasyon;Integrated Security=True");

        public SeferSecim()
        {
            InitializeComponent();
        }
        public int saat;
        bool[] seciliMi = new bool[30];

        private void SaatSecClick(object sender, EventArgs e)
        {
            Button ButtonSaat = (Button)sender;
            saat = Convert.ToInt32(ButtonSaat.Text);
            if (seciliMi[saat - 1])
            {
                ButtonSaat.BackColor = Color.Gainsboro;
                BtnSaat10.Enabled = true;
                BtnSaat12.Enabled = true;
                BtnSaat14.Enabled = true;
                seciliMi[saat - 1] = false;
            }
            else
            {

                if (ButtonSaat.Text == "10")
                {
                    ButtonSaat.BackColor = Color.DarkGray;
                    BtnSaat12.Enabled = false;
                    BtnSaat14.Enabled = false;
                    seciliMi[saat - 1] = true;
                }
                else if (ButtonSaat.Text == "12")
                {
                    ButtonSaat.BackColor = Color.DarkGray;
                    BtnSaat10.Enabled = false;
                    BtnSaat14.Enabled = false;
                    seciliMi[saat - 1] = true;
                }
                else if (ButtonSaat.Text == "14")
                {
                    ButtonSaat.BackColor = Color.DarkGray;
                    BtnSaat10.Enabled = false;
                    BtnSaat12.Enabled = false;
                    seciliMi[saat - 1] = true;
                }
            }
        }

        private void BtnSeferSec_Click(object sender, EventArgs e)
        {
            DateTime tarih = Convert.ToDateTime(dtpSeferTarihi.Text);
            Rezervasyon frm = new Rezervasyon();
            if (cmbKalkıs.Text == cmbVarıs.Text)
            {
                MessageBox.Show("Kalkış Ve Varış Noktaları Farklı Olmalıdır!!!!");
            }
            else if(saat.ToString() == "0")
            {
                MessageBox.Show("Saati Seçmediniz!!");
            }
            else
            {
                frm.saatb = saat.ToString();
                frm.kalkis = cmbKalkıs.Text;
                frm.varis = cmbVarıs.Text;
                frm.tarih = tarih;
                frm.Show();
            }
        }

        private void SeferSecim_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TBLSefer", baglanti);
            komut.ExecuteNonQuery();
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                cmbKalkıs.Items.Add(oku["Kalkıs"]);
                cmbVarıs.Items.Add(oku["Varıs"]);
            }
            baglanti.Close();

        }
    }
}
//Data Source=DESKTOP-QD6HDJ2\SQLEXPRESS;Initial Catalog=OtobusRezervasyon;Integrated Security=True