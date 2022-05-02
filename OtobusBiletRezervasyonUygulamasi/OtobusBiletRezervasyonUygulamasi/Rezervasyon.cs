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
    public partial class Rezervasyon : Form
    {

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-QD6HDJ2\SQLEXPRESS;Initial Catalog=OtobusRezervasyon;Integrated Security=True");

        public Rezervasyon()
        {
            InitializeComponent();
        }

        public string saatb;
        public string kalkis;
        public string varis;
        public DateTime tarih;
        string otobusNO;

        private void Rezervasyon_Load(object sender, EventArgs e)
        {
            lblSaat.Text = saatb;
            if (saatb == "10")
            {
                otobusNO = "1";
            }
            else if (saatb == "12")
            {
                otobusNO = "2";
            }
            else if (saatb == "14")
            {
                otobusNO = "3";
            }

            lblKalkis.Text = kalkis;
            lblVaris.Text = varis;
            lblTarih.Text = tarih.ToString("yyyy-MM-dd");

            KoltukKontrol();
        }

        bool[] seciliMi = new bool[16];
        int koltukNo = 0;
        List<string> koltuklar = new List<string>();

        private void KoltukButtonClick(object sender, EventArgs e)
        {
            Button tiklananKoltuk = (Button)sender;

            koltukNo = Convert.ToInt32(tiklananKoltuk.Text);
            koltuklar.Add(tiklananKoltuk.Text);

            if (seciliMi[koltukNo - 1])
            {
                tiklananKoltuk.BackColor = Color.White;
                seciliMi[koltukNo - 1] = false;
            }
            else
            {
                tiklananKoltuk.BackColor = Color.LightGreen;
                seciliMi[koltukNo - 1] = true;
            }
        }

        private void BtnOnayla_Click(object sender, EventArgs e)
        {

            if (txtYolcuAd.Text == "" || txtYolcuSoyad.Text == "" || txtTc.Text == "" || mskTelefon.Text == "" || cmbCinsiyet.Text == "")
            {
                MessageBox.Show("Form Boş Bırakılamaz!");
            }
            else if (koltuklar.Count == 0)
            {
                MessageBox.Show("Koltuk Seçmediniz!");
            }
            else
            {
                txtOzetAd.Text = txtYolcuAd.Text;
                txtOzetSoyad.Text = txtYolcuSoyad.Text;
                txtKalkıs.Text = lblKalkis.Text;
                txtVarıs.Text = lblVaris.Text;
                mskOzetTarih.Text = lblTarih.Text;
                txtSaat.Text = lblSaat.Text + ":00";
                txtKoltuk.Text = string.Join("-", koltuklar);

                if (lblKalkis.Text == "Kırklareli" && lblVaris.Text == "Istanbul" || lblKalkis.Text == "Istanbul" && lblVaris.Text == "Kırklareli")
                {
                    txtUcret.Text = (koltuklar.Count * 85).ToString();
                }
                else if (lblKalkis.Text == "Kırklareli" && lblVaris.Text == "Tekirdag" || lblKalkis.Text == "Tekirdag" && lblVaris.Text == "Kırklareli")
                {
                    txtUcret.Text = (koltuklar.Count * 50).ToString();
                }
                else if (lblKalkis.Text == "Kırklareli" && lblVaris.Text == "Edirne" || lblKalkis.Text == "Edirne" && lblVaris.Text == "Kırklareli")
                {
                    txtUcret.Text = (koltuklar.Count * 70).ToString();
                }
            }
        }

        private void KoltukKontrol()
        {
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from TBLRezervasyon where OtobusNo = '" + otobusNO + "' " +
                "and Kalkıs = '" + kalkis + "' and Varıs ='" + varis + "' and Tarih = '" + tarih.ToString("yyyy-MM-dd") + "'", baglanti);
            komut2.ExecuteNonQuery();
            SqlDataReader oku = komut2.ExecuteReader();

            while (oku.Read())
            {
                if (oku["KoltukNo"].ToString() == "1" && oku["OtobusNo"].ToString() == otobusNO)
                {
                    if (oku["Cinsiyet"].ToString() == "Bay")
                    {
                        Koltuk1.BackColor = Color.Blue;
                    }
                    else
                    {
                        Koltuk1.BackColor = Color.Pink;
                    }
                    Koltuk1.Enabled = false;
                }
                if (oku["KoltukNo"].ToString() == "2" && oku["OtobusNo"].ToString() == otobusNO)
                {
                    if (oku["Cinsiyet"].ToString() == "Bay")
                    {
                        Koltuk2.BackColor = Color.Blue;
                    }
                    else
                    {
                        Koltuk2.BackColor = Color.Pink;
                    }
                    Koltuk2.Enabled = false;
                }
                if (oku["KoltukNo"].ToString() == "3" && oku["OtobusNo"].ToString() == otobusNO)
                {
                    if (oku["Cinsiyet"].ToString() == "Bay")
                    {
                        Koltuk3.BackColor = Color.Blue;
                    }
                    else
                    {
                        Koltuk3.BackColor = Color.Pink;
                    }
                    Koltuk3.Enabled = false;
                }
                if (oku["KoltukNo"].ToString() == "4" && oku["OtobusNo"].ToString() == otobusNO)
                {
                    if (oku["Cinsiyet"].ToString() == "Bay")
                    {
                        Koltuk4.BackColor = Color.Blue;
                    }
                    else
                    {
                        Koltuk4.BackColor = Color.Pink;
                    }
                    Koltuk4.Enabled = false;
                }
                if (oku["KoltukNo"].ToString() == "5" && oku["OtobusNo"].ToString() == otobusNO)
                {
                    if (oku["Cinsiyet"].ToString() == "Bay")
                    {
                        Koltuk5.BackColor = Color.Blue;
                    }
                    else
                    {
                        Koltuk5.BackColor = Color.Pink;
                    }
                    Koltuk5.Enabled = false;
                }
                if (oku["KoltukNo"].ToString() == "6" && oku["OtobusNo"].ToString() == otobusNO)
                {
                    if (oku["Cinsiyet"].ToString() == "Bay")
                    {
                        Koltuk6.BackColor = Color.Blue;
                    }
                    else
                    {
                        Koltuk6.BackColor = Color.Pink;
                    }
                    Koltuk6.Enabled = false;
                }
                if (oku["KoltukNo"].ToString() == "7" && oku["OtobusNo"].ToString() == otobusNO)
                {
                    if (oku["Cinsiyet"].ToString() == "Bay")
                    {
                        Koltuk7.BackColor = Color.Blue;
                    }
                    else
                    {
                        Koltuk7.BackColor = Color.Pink;
                    }
                    Koltuk7.Enabled = false;
                }
                if (oku["KoltukNo"].ToString() == "8" && oku["OtobusNo"].ToString() == otobusNO)
                {
                    if (oku["Cinsiyet"].ToString() == "Bay")
                    {
                        Koltuk8.BackColor = Color.Blue;
                    }
                    else
                    {
                        Koltuk8.BackColor = Color.Pink;
                    }
                    Koltuk8.Enabled = false;
                }
                if (oku["KoltukNo"].ToString() == "9" && oku["OtobusNo"].ToString() == otobusNO)
                {
                    if (oku["Cinsiyet"].ToString() == "Bay")
                    {
                        Koltuk9.BackColor = Color.Blue;
                    }
                    else
                    {
                        Koltuk9.BackColor = Color.Pink;
                    }
                    Koltuk9.Enabled = false;
                }
                if (oku["KoltukNo"].ToString() == "10" && oku["OtobusNo"].ToString() == otobusNO)
                {
                    if (oku["Cinsiyet"].ToString() == "Bay")
                    {
                        Koltuk10.BackColor = Color.Blue;
                    }
                    else
                    {
                        Koltuk10.BackColor = Color.Pink;
                    }
                    Koltuk10.Enabled = false;
                }
                if (oku["KoltukNo"].ToString() == "11" && oku["OtobusNo"].ToString() == otobusNO)
                {
                    if (oku["Cinsiyet"].ToString() == "Bay")
                    {
                        Koltuk11.BackColor = Color.Blue;
                    }
                    else
                    {
                        Koltuk11.BackColor = Color.Pink;
                    }
                    Koltuk11.Enabled = false;
                }
                if (oku["KoltukNo"].ToString() == "12" && oku["OtobusNo"].ToString() == otobusNO)
                {
                    if (oku["Cinsiyet"].ToString() == "Bay")
                    {
                        Koltuk12.BackColor = Color.Blue;
                    }
                    else
                    {
                        Koltuk12.BackColor = Color.Pink;
                    }
                    Koltuk12.Enabled = false;
                }
                if (oku["KoltukNo"].ToString() == "13" && oku["OtobusNo"].ToString() == otobusNO)
                {
                    if (oku["Cinsiyet"].ToString() == "Bay")
                    {
                        Koltuk13.BackColor = Color.Blue;
                    }
                    else
                    {
                        Koltuk13.BackColor = Color.Pink;
                    }
                    Koltuk13.Enabled = false;
                }
                if (oku["KoltukNo"].ToString() == "14" && oku["OtobusNo"].ToString() == otobusNO)
                {
                    if (oku["Cinsiyet"].ToString() == "Bay")
                    {
                        Koltuk14.BackColor = Color.Blue;
                    }
                    else
                    {
                        Koltuk14.BackColor = Color.Pink;
                    }
                    Koltuk14.Enabled = false;
                }
                if (oku["KoltukNo"].ToString() == "15" && oku["OtobusNo"].ToString() == otobusNO)
                {
                    if (oku["Cinsiyet"].ToString() == "Bay")
                    {
                        Koltuk15.BackColor = Color.Blue;
                    }
                    else
                    {
                        Koltuk15.BackColor = Color.Pink;
                    }
                    Koltuk15.Enabled = false;
                }
                if (oku["KoltukNo"].ToString() == "16" && oku["OtobusNo"].ToString() == otobusNO)
                {
                    if (oku["Cinsiyet"].ToString() == "Bay")
                    {
                        Koltuk16.BackColor = Color.Blue;
                    }
                    else
                    {
                        Koltuk16.BackColor = Color.Pink;
                    }
                    Koltuk16.Enabled = false;
                }
            }
            baglanti.Close();
        }

        private void BtnRezervasyon_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            for (int i = 0; i < koltuklar.Count; i++)
            {
                SqlCommand komut = new SqlCommand("insert into TBLRezervasyon (OtobusNo,KoltukNo,Adı,Soyadı,Tc,Cinsiyet,Telefon,Tarih,Saat,Kalkıs,Varıs) values(@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9,@P10,@P11)", baglanti);

                komut.Parameters.AddWithValue("@P1", otobusNO);
                komut.Parameters.AddWithValue("@P2", koltuklar[i]);
                komut.Parameters.AddWithValue("@P3", txtOzetAd.Text);
                komut.Parameters.AddWithValue("@P4", txtOzetSoyad.Text);
                komut.Parameters.AddWithValue("@P5", txtTc.Text);
                komut.Parameters.AddWithValue("@P6", cmbCinsiyet.Text);
                komut.Parameters.AddWithValue("@P7", mskTelefon.Text);
                komut.Parameters.AddWithValue("@P8", tarih);
                komut.Parameters.AddWithValue("@P9", lblSaat.Text);
                komut.Parameters.AddWithValue("@P10", lblKalkis.Text);
                komut.Parameters.AddWithValue("@P11", lblVaris.Text);
                komut.ExecuteNonQuery();
            }
            baglanti.Close();
            MessageBox.Show("Rezervasyonunuz Başarı İle Gerçekleşti!");
        }
    }
}
