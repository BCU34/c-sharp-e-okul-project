using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eokul
{
    public partial class FrmOgretmenGiris : Form
    {
        public FrmOgretmenGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=burak;Initial Catalog=Eokulveritabani;Integrated Security=True");
        Random rnd = new Random();
        string capthca;
        void capcathaolusturma()
        {
            string[] dizi1 = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "r", "s", "q", "t", "v", "y", "x", "z" };
            string[] dizi2 = { "<", "!", "'", "#", "+", "$", "@", "%", "½", "/", "?", "*" };
            capthca = "";
            for (int i = 1; i <= 6; i++)
            {
                int rndsayi1 = rnd.Next(1, 4);
                if (rndsayi1 == 1)
                {
                    if (rnd.Next(1, 3) == 1)
                    {
                        capthca += dizi1[rnd.Next(0, dizi1.Length)].ToString().ToUpper();
                    }
                    else
                    {
                        capthca += dizi1[rnd.Next(0, dizi1.Length)].ToString().ToLower();
                    }
                }
                else if (rndsayi1 == 2)
                {
                    capthca += rnd.Next(0, 10);
                }
                else
                {
                    capthca += dizi2[rnd.Next(0, dizi2.Length)].ToString();
                }
            }
            lblCaptcha.Text = capthca;

        }
        private void btnGosterGizle_Click(object sender, EventArgs e)
        {
            if (txtSifre.UseSystemPasswordChar == true)
            {
                btnGosterGizle.BackgroundImage = Properties.Resources.show;
                btnGosterGizle.BackgroundImageLayout = ImageLayout.Zoom;
                txtSifre.UseSystemPasswordChar = false;
            }
            else
            {
                btnGosterGizle.BackgroundImage = Properties.Resources.hide;
                btnGosterGizle.BackgroundImageLayout = ImageLayout.Zoom;
                txtSifre.UseSystemPasswordChar = true;
            }
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            bool d1 = false;
            string name = "", surname = "", Turkiyecumhuriyetikimliknumara = "", lesson = "", password = "", gender = "", schoolname = "";
            int yearsold = 0, id = 0;
            if (txtCaptcha.Text == capthca)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from Tbl_Ogretmen where Ogretmen_TC = @p1 and Ogretmen_sifre = @p2", baglanti);
                komut.Parameters.AddWithValue("@p1", maskTC.Text);
                komut.Parameters.AddWithValue("@p2", txtSifre.Text);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    d1 = true;
                    id = int.Parse(dr[0].ToString());
                    name = dr[1].ToString();
                    surname = dr[2].ToString();
                    yearsold = int.Parse(dr[3].ToString());
                    Turkiyecumhuriyetikimliknumara = dr[4].ToString();
                    lesson = dr[5].ToString();
                    password = dr[6].ToString();
                    gender = dr[7].ToString();
                }
                else
                {
                    MessageBox.Show("TC Kimlik Numara veya şifre yanlış", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                baglanti.Close();
                if (d1 == true)
                {
                    baglanti.Open();
                    SqlCommand komutokuladi = new SqlCommand("select OkulunAdi from Tbl_Mudur where Mudur_id = 1", baglanti);
                    SqlDataReader drokuladi = komutokuladi.ExecuteReader();
                    while (drokuladi.Read())
                    {
                        schoolname = drokuladi[0].ToString().ToUpper();
                    }
                    baglanti.Close();
                    FrmOgretmenİslemler islem = new FrmOgretmenİslemler();
                    islem.ogretmenid = id;
                    islem.ogretmenad = name;
                    islem.ogretmensoyad = surname;
                    islem.ogretmenyas = yearsold;
                    islem.ogretmenTC = Turkiyecumhuriyetikimliknumara;
                    islem.ogretmenders = lesson;
                    islem.ogretmensifre = password;
                    islem.ogretmencinsiyet = gender;
                    islem.okulunadi = schoolname;
                    islem.Show();
                    this.Close();
                }
                txtCaptcha.Text = ""; txtSifre.Text = ""; maskTC.Text = "";
                maskTC.Focus();
                txtSifre.UseSystemPasswordChar = true;
                btnGosterGizle.BackgroundImage = Properties.Resources.hide;
                btnGosterGizle.BackgroundImageLayout = ImageLayout.Zoom;
            }
            else
            {
                MessageBox.Show("Hata! Captcha doğrulanamadı", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCaptcha.Text = "";
                txtCaptcha.Focus();
            }
            capcathaolusturma();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmOgretmenKayit fok = new FrmOgretmenKayit();
            fok.Show();
            this.Close();
        }

        private void FrmOgretmenGiris_Load(object sender, EventArgs e)
        {
            capcathaolusturma();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            FrmAnaGiris f = new FrmAnaGiris();
            f.Show();
            this.Close();
        }

        private void FrmOgretmenGiris_Click(object sender, EventArgs e)
        {
            /*MessageBox.Show(capthca);*/
        }
    }
}
