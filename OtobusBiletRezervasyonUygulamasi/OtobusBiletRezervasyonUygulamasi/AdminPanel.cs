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
    public partial class AdminPanel : Form
    {

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-QD6HDJ2\SQLEXPRESS;Initial Catalog=OtobusRezervasyon;Integrated Security=True");

        public AdminPanel()
        {
            InitializeComponent();
        }

        private void VerileriGoster()
        {
            LviewMusteriler.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TBLRezervasyon", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["OtobusNo"].ToString());
                ekle.SubItems.Add(oku["KoltukNo"].ToString());
                ekle.SubItems.Add(oku["Adı"].ToString());
                ekle.SubItems.Add(oku["Soyadı"].ToString());
                ekle.SubItems.Add(oku["Tc"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Tarih"].ToString());
                ekle.SubItems.Add(oku["Saat"].ToString());
                ekle.SubItems.Add(oku["Kalkıs"].ToString());
                ekle.SubItems.Add(oku["Varıs"].ToString());

                LviewMusteriler.Items.Add(ekle);
            }
            baglanti.Close();

        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            VerileriGoster();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TBLSefer", baglanti);
            komut.ExecuteNonQuery();
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                cmbAdmKalkis.Items.Add(oku["Kalkıs"]);
                cmbAdmVaris.Items.Add(oku["Varıs"]);
            }
            baglanti.Close();
        }

        DateTime tarih;
        private void BtnAdmAra_Click(object sender, EventArgs e)
        {
            tarih = Convert.ToDateTime(dtpAdmTarih.Text);
            LviewMusteriler.Items.Clear();
            baglanti.Open(); //Adi like '%" + TxtAra.Text + "%' , Kalkıs ='"+cmbAdmKalkis.Text+"' and
            SqlCommand komut = new SqlCommand("select * from TBLRezervasyon where Varıs = '"+cmbAdmVaris.Text
                +"' and Kalkıs = '"+cmbAdmKalkis.Text
                +"' and Tarih = '"+dtpAdmTarih.Value.ToString("yyyy-MM-dd")+"' and Saat = '"+saat+"' ", baglanti);
            SqlDataReader oku1 = komut.ExecuteReader();

            while (oku1.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku1["id"].ToString();
                ekle.SubItems.Add(oku1["OtobusNo"].ToString());
                ekle.SubItems.Add(oku1["KoltukNo"].ToString());
                ekle.SubItems.Add(oku1["Adı"].ToString());
                ekle.SubItems.Add(oku1["Soyadı"].ToString());
                ekle.SubItems.Add(oku1["Tc"].ToString());
                ekle.SubItems.Add(oku1["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku1["Tarih"].ToString());
                ekle.SubItems.Add(oku1["Saat"].ToString());
                ekle.SubItems.Add(oku1["Kalkıs"].ToString());
                ekle.SubItems.Add(oku1["Varıs"].ToString());

                LviewMusteriler.Items.Add(ekle);
            }
            baglanti.Close();
            gbGuncelle.Visible = true;
        }
        
        private void KoltukKontrolu()
        {
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from TBLRezervasyon where OtobusNo = '" + otobusNO.Text + "' " +
                "and Kalkıs = '" + cmbAdmKalkis.Text + "' and Varıs ='" + cmbAdmVaris.Text + "' and Tarih = '" + tarih.ToString("yyyy-MM-dd") + "'", baglanti);
            komut2.ExecuteNonQuery();
            SqlDataReader oku = komut2.ExecuteReader();

            while (oku.Read())
            {
                if (oku["KoltukNo"].ToString() == "1" && oku["OtobusNo"].ToString() == otobusNO.Text)
                {
                    if (oku["Cinsiyet"].ToString() == "Bay")
                    {
                        AdmKoltuk1.BackColor = Color.Blue;
                    }
                    else
                    {
                        AdmKoltuk1.BackColor = Color.Pink;
                    }
                    AdmKoltuk1.Enabled = false;
                }
                if (oku["KoltukNo"].ToString() == "2" && oku["OtobusNo"].ToString() == otobusNO.Text)
                {
                    if (oku["Cinsiyet"].ToString() == "Bay")
                    {
                        AdmKoltuk2.BackColor = Color.Blue;
                    }
                    else
                    {
                        AdmKoltuk2.BackColor = Color.Pink;
                    }
                    AdmKoltuk2.Enabled = false;
                }
                if (oku["KoltukNo"].ToString() == "3" && oku["OtobusNo"].ToString() == otobusNO.Text)
                {
                    if (oku["Cinsiyet"].ToString() == "Bay")
                    {
                        AdmKoltuk3.BackColor = Color.Blue;
                    }
                    else
                    {
                        AdmKoltuk3.BackColor = Color.Pink;
                    }
                    AdmKoltuk3.Enabled = false;
                }
                if (oku["KoltukNo"].ToString() == "4" && oku["OtobusNo"].ToString() == otobusNO.Text)
                {
                    if (oku["Cinsiyet"].ToString() == "Bay")
                    {
                        AdmKoltuk4.BackColor = Color.Blue;
                    }
                    else
                    {
                        AdmKoltuk4.BackColor = Color.Pink;
                    }
                    AdmKoltuk4.Enabled = false;
                }
                if (oku["KoltukNo"].ToString() == "5" && oku["OtobusNo"].ToString() == otobusNO.Text)
                {
                    if (oku["Cinsiyet"].ToString() == "Bay")
                    {
                        AdmKoltuk5.BackColor = Color.Blue;
                    }
                    else
                    {
                        AdmKoltuk5.BackColor = Color.Pink;
                    }
                    AdmKoltuk5.Enabled = false;
                }
                if (oku["KoltukNo"].ToString() == "6" && oku["OtobusNo"].ToString() == otobusNO.Text)
                {
                    if (oku["Cinsiyet"].ToString() == "Bay")
                    {
                        AdmKoltuk6.BackColor = Color.Blue;
                    }
                    else
                    {
                        AdmKoltuk6.BackColor = Color.Pink;
                    }
                    AdmKoltuk6.Enabled = false;
                }
                if (oku["KoltukNo"].ToString() == "7" && oku["OtobusNo"].ToString() == otobusNO.Text)
                {
                    if (oku["Cinsiyet"].ToString() == "Bay")
                    {
                        AdmKoltuk7.BackColor = Color.Blue;
                    }
                    else
                    {
                        AdmKoltuk7.BackColor = Color.Pink;
                    }
                    AdmKoltuk7.Enabled = false;
                }
                if (oku["KoltukNo"].ToString() == "8" && oku["OtobusNo"].ToString() == otobusNO.Text)
                {
                    if (oku["Cinsiyet"].ToString() == "Bay")
                    {
                        AdmKoltuk8.BackColor = Color.Blue;
                    }
                    else
                    {
                        AdmKoltuk8.BackColor = Color.Pink;
                    }
                    AdmKoltuk8.Enabled = false;
                }
                if (oku["KoltukNo"].ToString() == "9" && oku["OtobusNo"].ToString() == otobusNO.Text)
                {
                    if (oku["Cinsiyet"].ToString() == "Bay")
                    {
                        AdmKoltuk9.BackColor = Color.Blue;
                    }
                    else
                    {
                        AdmKoltuk9.BackColor = Color.Pink;
                    }
                    AdmKoltuk9.Enabled = false;
                }
                if (oku["KoltukNo"].ToString() == "10" && oku["OtobusNo"].ToString() == otobusNO.Text)
                {
                    if (oku["Cinsiyet"].ToString() == "Bay")
                    {
                        AdmKoltuk10.BackColor = Color.Blue;
                    }
                    else
                    {
                        AdmKoltuk10.BackColor = Color.Pink;
                    }
                    AdmKoltuk10.Enabled = false;
                }
                if (oku["KoltukNo"].ToString() == "11" && oku["OtobusNo"].ToString() == otobusNO.Text)
                {
                    if (oku["Cinsiyet"].ToString() == "Bay")
                    {
                        AdmKoltuk11.BackColor = Color.Blue;
                    }
                    else
                    {
                        AdmKoltuk11.BackColor = Color.Pink;
                    }
                    AdmKoltuk11.Enabled = false;
                }
                if (oku["KoltukNo"].ToString() == "12" && oku["OtobusNo"].ToString() == otobusNO.Text)
                {
                    if (oku["Cinsiyet"].ToString() == "Bay")
                    {
                        AdmKoltuk12.BackColor = Color.Blue;
                    }
                    else
                    {
                        AdmKoltuk12.BackColor = Color.Pink;
                    }
                    AdmKoltuk12.Enabled = false;
                }
                if (oku["KoltukNo"].ToString() == "13" && oku["OtobusNo"].ToString() == otobusNO.Text)
                {
                    if (oku["Cinsiyet"].ToString() == "Bay")
                    {
                        AdmKoltuk13.BackColor = Color.Blue;
                    }
                    else
                    {
                        AdmKoltuk13.BackColor = Color.Pink;
                    }
                    AdmKoltuk13.Enabled = false;
                }
                if (oku["KoltukNo"].ToString() == "14" && oku["OtobusNo"].ToString() == otobusNO.Text)
                {
                    if (oku["Cinsiyet"].ToString() == "Bay")
                    {
                        AdmKoltuk14.BackColor = Color.Blue;
                    }
                    else
                    {
                        AdmKoltuk14.BackColor = Color.Pink;
                    }
                    AdmKoltuk14.Enabled = false;
                }
                if (oku["KoltukNo"].ToString() == "15" && oku["OtobusNo"].ToString() == otobusNO.Text)
                {
                    if (oku["Cinsiyet"].ToString() == "Bay")
                    {
                        AdmKoltuk15.BackColor = Color.Blue;
                    }
                    else
                    {
                        AdmKoltuk15.BackColor = Color.Pink;
                    }
                    AdmKoltuk15.Enabled = false;
                }
                if (oku["KoltukNo"].ToString() == "16" && oku["OtobusNo"].ToString() == otobusNO.Text)
                {
                    if (oku["Cinsiyet"].ToString() == "Bay")
                    {
                        AdmKoltuk16.BackColor = Color.Blue;
                    }
                    else
                    {
                        AdmKoltuk16.BackColor = Color.Pink;
                    }
                    AdmKoltuk16.Enabled = false;
                }
            }
            baglanti.Close();
        }

        private void BtnKoltukGoster_Click(object sender, EventArgs e)
        {
            KoltukKontrolu();
            gbKoltuklar.Visible = true;
        }

        private void BtnAdmGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update TBLRezervasyon set Adı='" + txtAdmAd.Text + "', Soyadı='" + txtAdmSoyad.Text
                + "', Tarih='" + dtpAdmTarihg.Value.ToString("yyyy-MM-dd") +  "', KoltukNo='" + txtAdmKoltuk.Text + "', Saat ='"+saat2+"' where id=" + id + " ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            VerileriGoster();
            gbKoltuklar.Visible = false;

        }
        int id = 0;
        private void LviewMusteriler_DoubleClick_1(object sender, EventArgs e)
        {
            id = int.Parse(LviewMusteriler.SelectedItems[0].SubItems[0].Text);
            txtAdmAd.Text = LviewMusteriler.SelectedItems[0].SubItems[3].Text;
            txtAdmSoyad.Text = LviewMusteriler.SelectedItems[0].SubItems[4].Text;
            dtpAdmTarihg.Text = LviewMusteriler.SelectedItems[0].SubItems[7].Text;
            txtAdmKoltuk.Text = LviewMusteriler.SelectedItems[0].SubItems[2].Text;
            otobusNO.Text = LviewMusteriler.SelectedItems[0].SubItems[1].Text;

        }

        public int saat;
        public int saat2;
        bool[] seciliMi = new bool[30];
        bool[] seciliMi2 = new bool[30];

        private void SaatSecAdm(object sender, EventArgs e)
        {
            Button ButtonSaat = (Button)sender;
            saat2 = Convert.ToInt32(ButtonSaat.Text);
            if (seciliMi2[saat2 - 1])
            {
                ButtonSaat.BackColor = Color.Gainsboro;
                BtnGuncelle10.Enabled = true;
                BtnGuncelle12.Enabled = true;
                BtnGuncelle14.Enabled = true;
                seciliMi2[saat2 - 1] = false;
            }
            else
            {

                if (ButtonSaat.Text == "10")
                {
                    ButtonSaat.BackColor = Color.DarkGray;
                    BtnGuncelle12.Enabled = false;
                    BtnGuncelle14.Enabled = false;
                    seciliMi2[saat2 - 1] = true;
                }
                else if (ButtonSaat.Text == "12")
                {
                    ButtonSaat.BackColor = Color.DarkGray;
                    BtnGuncelle10.Enabled = false;
                    BtnGuncelle14.Enabled = false;
                    seciliMi2[saat2 - 1] = true;
                }
                else if (ButtonSaat.Text == "14")
                {
                    ButtonSaat.BackColor = Color.DarkGray;
                    BtnGuncelle10.Enabled = false;
                    BtnGuncelle12.Enabled = false;
                    seciliMi2[saat2 - 1] = true;
                }
            }
        }

        private void AdminSaatSec(object sender, EventArgs e)
        {
            Button ButtonSaat = (Button)sender;
            saat = Convert.ToInt32(ButtonSaat.Text);
            if (seciliMi[saat - 1])
            {
                ButtonSaat.BackColor = Color.Gainsboro;
                BtnAdm10.Enabled = true;
                BtnAdm12.Enabled = true;
                BtnAdm14.Enabled = true;
                seciliMi[saat - 1] = false;
            }
            else
            {

                if (ButtonSaat.Text == "10")
                {
                    ButtonSaat.BackColor = Color.DarkGray;
                    BtnAdm12.Enabled = false;
                    BtnAdm14.Enabled = false;
                    seciliMi[saat - 1] = true;
                }
                else if (ButtonSaat.Text == "12")
                {
                    ButtonSaat.BackColor = Color.DarkGray;
                    BtnAdm10.Enabled = false;
                    BtnAdm14.Enabled = false;
                    seciliMi[saat - 1] = true;
                }
                else if (ButtonSaat.Text == "14")
                {
                    ButtonSaat.BackColor = Color.DarkGray;
                    BtnAdm10.Enabled = false;
                    BtnAdm12.Enabled = false;
                    seciliMi[saat - 1] = true;
                }
            }
        }

        bool[] koltukSeciliMi = new bool[16];
        int koltukNo = 0;
        List<string> koltuklar = new List<string>();

        private void KoltukAdmin(object sender, EventArgs e)
        {
            Button tiklananKoltuk = (Button)sender;

            koltukNo = Convert.ToInt32(tiklananKoltuk.Text);
            koltuklar.Add(tiklananKoltuk.Text);

            if (koltukSeciliMi[koltukNo - 1])
            {
                tiklananKoltuk.BackColor = Color.White;
                koltukSeciliMi[koltukNo - 1] = false;
            }
            else
            {
                tiklananKoltuk.BackColor = Color.LightGreen;
                koltukSeciliMi[koltukNo - 1] = true;
            }
        }

        private void BtnKoltukOnayla_Click(object sender, EventArgs e)
        {
            txtAdmKoltuk.Text = string.Join("-", koltuklar);
        }
    }
}
