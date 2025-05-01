using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eokul
{
    public partial class FrmOgretmenBasvuru : Form
    {
        public FrmOgretmenBasvuru()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=burak;Initial Catalog=Eokulveritabani;Integrated Security=True");
        Random rnd = new Random();
        string capthca;
        void temizle()
        {
            txtAd.Focus();
            txtOgretmenİd.Text = "";
            txtAd.Text = "";
            txtOgretmenSoyad.Text = "";
            txtOgretmenYas.Text = "";
            txtCaptcha.Text = "";
            radioErkek.Checked = true;
            radioKadin.Checked = false;
            maskOgretmenTC.Text = "";
            comboBox1.Text = "Coğrafya";
            richAciklama.Text = "Kendinizi kısaca tanıtın. \r\nHangi okullarda ders verdiniz? \r\nHangi okuldan mezun oldunuz? \r\nBaşarılarınız nelerdir?\r\n";
        }
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
        private void FrmOgretmenBasvuru_Load(object sender, EventArgs e)
        {
            capcathaolusturma();
        }
        string cinsiyet;
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCaptcha.Text == capthca)
            {
                if (radioErkek.Checked == true)
                {
                    cinsiyet = "Erkek";
                }
                else
                {
                    cinsiyet = "Kadın";
                }
                baglanti.Open();
                SqlCommand komutogretmentablosunaekleme = new SqlCommand("insert into Tbl_Ogretmen (Ogretmen_ad,Ogretmen_soyad,Ogretmen_yas,Ogretmen_TC,Ogretmen_ders,Ogretmen_cinsiyet,Ogretmen_profilfoto,Ogretmen_baskabul,Ogretmen_kayitoldumu) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", baglanti);
                komutogretmentablosunaekleme.Parameters.AddWithValue("@p1", txtAd.Text);
                komutogretmentablosunaekleme.Parameters.AddWithValue("@p2", txtOgretmenSoyad.Text);
                komutogretmentablosunaekleme.Parameters.AddWithValue("@p3", int.Parse(txtOgretmenYas.Text));
                komutogretmentablosunaekleme.Parameters.AddWithValue("@p4", maskOgretmenTC.Text);
                komutogretmentablosunaekleme.Parameters.AddWithValue("@p5", comboBox1.Text);
                komutogretmentablosunaekleme.Parameters.AddWithValue("@p6", cinsiyet);
                komutogretmentablosunaekleme.Parameters.AddWithValue("@p7", "yok");
                komutogretmentablosunaekleme.Parameters.AddWithValue("@p8", false);
                komutogretmentablosunaekleme.Parameters.AddWithValue("@p9", false);
                komutogretmentablosunaekleme.ExecuteNonQuery();
                baglanti.Close();
                baglanti.Open();
                SqlCommand komutbasvurutablosunaekleme = new SqlCommand("insert into Tbl_Basvuru (Basvuru_ad,Basvuru_soyad,Basvuru_ogryas,Basvuru_cinsiyet,Basvuru_ogrTC,Basvuru_ders,Basvuru_aciklama,Basvuru_meslek) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", baglanti);
                komutbasvurutablosunaekleme.Parameters.AddWithValue("@p1", txtAd.Text);
                komutbasvurutablosunaekleme.Parameters.AddWithValue("@p2", txtOgretmenSoyad.Text);
                komutbasvurutablosunaekleme.Parameters.AddWithValue("@p3", int.Parse(txtOgretmenYas.Text));
                komutbasvurutablosunaekleme.Parameters.AddWithValue("@p4", cinsiyet);
                komutbasvurutablosunaekleme.Parameters.AddWithValue("@p5", maskOgretmenTC.Text);
                komutbasvurutablosunaekleme.Parameters.AddWithValue("@p6", comboBox1.Text);
                komutbasvurutablosunaekleme.Parameters.AddWithValue("@p7", richAciklama.Text);
                komutbasvurutablosunaekleme.Parameters.AddWithValue("@p8", "Öğretmen");
                komutbasvurutablosunaekleme.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Başvurunuz Gönderilmiştir!","bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                temizle();
            }
            else
            {
                MessageBox.Show("Hata! Captcha doğrulanamadı","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtCaptcha.Text = "";
                txtCaptcha.Focus();
            }
            capcathaolusturma();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmOgretmenBasvuruKontrolEtme kontrol = new FrmOgretmenBasvuruKontrolEtme();
            kontrol.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmOgretmenBasvuruSilme sil = new FrmOgretmenBasvuruSilme();
            sil.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(txtOgretmenİd.Text!="")
            {
                baglanti.Open();
                SqlCommand komutguncelleme1 = new SqlCommand("update Tbl_Basvuru set Basvuru_ad = @p1, Basvuru_soyad = @p2, Basvuru_ogryas = @p3, Basvuru_cinsiyet = @p4, Basvuru_ogrTC = @p5, Basvuru_ders = @p6, Basvuru_aciklama = @p7 where Basvuru_id = @p8", baglanti);
                komutguncelleme1.Parameters.AddWithValue("@p1", txtAd.Text);
                komutguncelleme1.Parameters.AddWithValue("@p2", txtOgretmenSoyad.Text);
                komutguncelleme1.Parameters.AddWithValue("@p3", int.Parse(txtOgretmenYas.Text));
                komutguncelleme1.Parameters.AddWithValue("@p4", cinsiyet);
                komutguncelleme1.Parameters.AddWithValue("@p5", maskOgretmenTC.Text);
                komutguncelleme1.Parameters.AddWithValue("@p6", comboBox1.Text);
                komutguncelleme1.Parameters.AddWithValue("@p7", richAciklama.Text);
                komutguncelleme1.Parameters.AddWithValue("@p8", basvuruid);
                komutguncelleme1.ExecuteNonQuery();
                baglanti.Close();
                baglanti.Open();
                SqlCommand komutguncelleme2 = new SqlCommand("update Tbl_Ogretmen set Ogretmen_ad = @p1, Ogretmen_soyad = @p2, Ogretmen_yas = @p3, Ogretmen_cinsiyet = @p4, Ogretmen_TC = @p5, Ogretmen_ders = @p6 where Ogretmen_id = @p7", baglanti);
                komutguncelleme2.Parameters.AddWithValue("@p1", txtAd.Text);
                komutguncelleme2.Parameters.AddWithValue("@p2", txtOgretmenSoyad.Text);
                komutguncelleme2.Parameters.AddWithValue("@p3", int.Parse(txtOgretmenYas.Text));
                komutguncelleme2.Parameters.AddWithValue("@p4", cinsiyet);
                komutguncelleme2.Parameters.AddWithValue("@p5", maskOgretmenTC.Text);
                komutguncelleme2.Parameters.AddWithValue("@p6", comboBox1.Text);
                komutguncelleme2.Parameters.AddWithValue("@p7", ogretmenid);
                komutguncelleme2.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Bilgileriniz güncellenilmiştir!","bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                temizle();
            }
            else
            {
                MessageBox.Show("Hata! Öncelikle İD yazan butona tıklayın ve id yerine bir sayı yazacaktır, işte böylece bilgileriniz hakkında güncelleme yapabilirsiniz.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        int ogretmenid, basvuruid;

        private void btnGeri_Click(object sender, EventArgs e)
        {
            FrmOgretmenKayit k = new FrmOgretmenKayit();
            k.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bool d1 = false;
            if (radioErkek.Checked == true)
            {
                cinsiyet = "Erkek";
            }
            else
            {
                cinsiyet = "Kadın";
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select Ogretmen_id from Tbl_Ogretmen where Ogretmen_ad = @p1 and Ogretmen_soyad = @p2 and Ogretmen_yas = @p3 and Ogretmen_cinsiyet = @p4 and Ogretmen_TC = @p5 and Ogretmen_ders = @p6 and Ogretmen_profilfoto = @p7 and Ogretmen_baskabul = @p8 and Ogretmen_kayitoldumu = @p9", baglanti);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtOgretmenSoyad.Text);
            komut.Parameters.AddWithValue("@p3", int.Parse(txtOgretmenYas.Text));
            komut.Parameters.AddWithValue("@p4", cinsiyet);
            komut.Parameters.AddWithValue("@p5", maskOgretmenTC.Text);
            komut.Parameters.AddWithValue("@p6", comboBox1.Text);
            komut.Parameters.AddWithValue("@p7", "yok");
            komut.Parameters.AddWithValue("@p8", false);
            komut.Parameters.AddWithValue("@p9", false);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                ogretmenid =int.Parse(dr[0].ToString());
            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand komutbasvuru = new SqlCommand("select Basvuru_id from Tbl_Basvuru where Basvuru_ad = @p1 and Basvuru_soyad = @p2 and Basvuru_ogryas = @p3 and Basvuru_cinsiyet = @p4 and Basvuru_ogrTC = @p5 and Basvuru_ders = @p6 and Basvuru_aciklama = @p7", baglanti);
            komutbasvuru.Parameters.AddWithValue("@p1", txtAd.Text);
            komutbasvuru.Parameters.AddWithValue("@p2", txtOgretmenSoyad.Text);
            komutbasvuru.Parameters.AddWithValue("@p3", int.Parse(txtOgretmenYas.Text));
            komutbasvuru.Parameters.AddWithValue("@p4", cinsiyet);
            komutbasvuru.Parameters.AddWithValue("@p5", maskOgretmenTC.Text);
            komutbasvuru.Parameters.AddWithValue("@p6", comboBox1.Text);
            komutbasvuru.Parameters.AddWithValue("@p7", richAciklama.Text);
            SqlDataReader dr2 = komutbasvuru.ExecuteReader();
            if (dr2.Read())
            {
                basvuruid = int.Parse(dr2[0].ToString());
            }
            else
            {
                d1 = true;
            }

            if (d1 == true)
            {
                MessageBox.Show("Hata. Öğretmen bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtOgretmenİd.Text=ogretmenid.ToString();
                MessageBox.Show("İd bulundu","bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            baglanti.Close();
        }
    }
}
