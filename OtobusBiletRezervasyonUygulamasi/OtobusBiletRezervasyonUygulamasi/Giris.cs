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
    public partial class Giris : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-QD6HDJ2\SQLEXPRESS;Initial Catalog=OtobusRezervasyon;Integrated Security=True");
        public Giris()
        {
            InitializeComponent();
        }

        private void BtnAdminGiris_Click(object sender, EventArgs e)
        {
            gbAdminGiris.Visible = true;
        }

        private void BtnYolcuGiris_Click(object sender, EventArgs e)
        {
            SeferSecim fr = new SeferSecim();
            SeferSecim fr1 = new SeferSecim();
            //fr.Hide();
            //fr1.Hide();
            fr.Show();
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TBLKullanıcı where KullaniciAdi = '" + txtAdmKullanıcı.Text + "' and Sifre = '" + txtAdmSifre.Text + "' ", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            if (oku.Read())
            {
                MessageBox.Show("Giriş Başarılı");
                AdminPanel fr = new AdminPanel();
                this.Hide();
                fr.Show();
            }
            else
            {
                MessageBox.Show("Bilgileri Hatalı Girdiniz");
            }

            baglanti.Close();

        }
    }
}
