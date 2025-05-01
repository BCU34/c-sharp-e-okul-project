using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace eokul
{
    public partial class FrmOgretmenKayit : Form
    {
        public FrmOgretmenKayit()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=burak;Initial Catalog=Eokulveritabani;Integrated Security=True");
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Eğer burada yeniyseniz, önce başvuru yapmalısınız. Sonra Müdür ve yardımcıları sizin başvurunuzu kabul ettiğini anlamanız için başvurunuzu kontrol edebilirsiniz. Kabul edilince kayıt sisteminden kayıt olarak giriş sisteminden de giriş yapabilirsiniz.","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            FrmOgretmenGiris frm = new FrmOgretmenGiris();
            frm.Show();
            this.Close();
        }
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
        private void FrmOgretmenKayit_Load(object sender, EventArgs e)
        {
            capcathaolusturma();
        }
        string cinsiyet;
        void temizle()
        {
            txtAd.Text = "";
            txtOgretmenSoyad.Text = "";
            txtOgretmenYas.Text = "";
            txtCaptcha.Text = "";
            txtOgretmenSifre.Text = "";
            radioErkek.Checked = true;
            radioKadin.Checked = false;
            maskOgretmenTC.Text = "";
            comboBox1.Text = "Coğrafya";
            txtAd.Focus();
        }
        private void btnKayit_Click(object sender, EventArgs e)
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
                bool d1 = false, baskabul, kayitoldu;
                baglanti.Open();
                SqlCommand komutsiralama = new SqlCommand("select Ogretmen_sifre = @p1, Ogretmen_kayitoldumu = @p2 from Tbl_Ogretmen where Ogretmen_ad = @p3 and Ogretmen_soyad = @p4 and Ogretmen_yas = @p5 and Ogretmen_TC = @p6 and Ogretmen_cinsiyet = @p7 and Ogretmen_baskabul = @p8 and Ogretmen_kayitoldumu = @p9", baglanti);
                komutsiralama.Parameters.AddWithValue("@p1", txtOgretmenSifre.Text);
                komutsiralama.Parameters.AddWithValue("@p2", true);
                komutsiralama.Parameters.AddWithValue("@p3", txtAd.Text);
                komutsiralama.Parameters.AddWithValue("@p4", txtOgretmenSoyad.Text);
                komutsiralama.Parameters.AddWithValue("@p5", txtOgretmenYas.Text);
                komutsiralama.Parameters.AddWithValue("@p6", maskOgretmenTC.Text);
                komutsiralama.Parameters.AddWithValue("@p7", cinsiyet);
                komutsiralama.Parameters.AddWithValue("@p8", true);
                komutsiralama.Parameters.AddWithValue("@p9", false);
                SqlDataReader dr = komutsiralama.ExecuteReader();
                if (dr.Read())
                {
                    d1 = true;
                }
                else
                {
                    d1 = false;
                }
                baglanti.Close();
                if (d1 == true)
                {
                    DateTime tarih = DateTime.Now;
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("update Tbl_Ogretmen set Ogretmen_sifre = @p1, Ogretmen_kayitoldumu = @p2,Ogretmen_kayitoldugutarih = @p3 where Ogretmen_ad = @p4 and Ogretmen_soyad = @p5 and Ogretmen_yas = @p6 and Ogretmen_TC = @p7 and Ogretmen_cinsiyet = @p8 and Ogretmen_baskabul = @p9 and Ogretmen_kayitoldumu = @p10", baglanti);
                    komut.Parameters.AddWithValue("@p1", txtOgretmenSifre.Text);
                    komut.Parameters.AddWithValue("@p2", true);
                    komut.Parameters.AddWithValue("@p3", tarih.ToString("d"));
                    komut.Parameters.AddWithValue("@p4", txtAd.Text);
                    komut.Parameters.AddWithValue("@p5", txtOgretmenSoyad.Text);
                    komut.Parameters.AddWithValue("@p6", txtOgretmenYas.Text);
                    komut.Parameters.AddWithValue("@p7", maskOgretmenTC.Text);
                    komut.Parameters.AddWithValue("@p8", cinsiyet);
                    komut.Parameters.AddWithValue("@p9", true);
                    komut.Parameters.AddWithValue("@p10", false);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kayıt edilmiştir! Artık giriş yapabilirsiniz.", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                }
                else
                {
                    bool dtt2 = false;
                    baglanti.Open();
                    SqlCommand komutsiralama2 = new SqlCommand("select Ogretmen_baskabul,Ogretmen_kayitoldumu from Tbl_Ogretmen where Ogretmen_ad = @p1 and Ogretmen_soyad = @p2 and Ogretmen_yas = @p3 and Ogretmen_TC = @p4 and Ogretmen_cinsiyet = @p5", baglanti);
                    komutsiralama2.Parameters.AddWithValue("@p1", txtAd.Text);
                    komutsiralama2.Parameters.AddWithValue("@p2", txtOgretmenSoyad.Text);
                    komutsiralama2.Parameters.AddWithValue("@p3", txtOgretmenYas.Text);
                    komutsiralama2.Parameters.AddWithValue("@p4", maskOgretmenTC.Text);
                    komutsiralama2.Parameters.AddWithValue("@p5", cinsiyet);
                    SqlDataReader dr2 = komutsiralama2.ExecuteReader();
                    if (dr2.Read())
                    {
                        baskabul = bool.Parse(dr2[0].ToString());
                        kayitoldu = bool.Parse(dr2[1].ToString());
                        if (baskabul == false)
                        {
                            MessageBox.Show("Daha başvurunuz kabul edilmemiştir! Kabul edilince kayıt olmaya çalışın.", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (kayitoldu == true)
                        {
                            MessageBox.Show("Bu öğretmen kayıtlı.", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        dtt2 = true;
                    }
                    baglanti.Close();
                    if (dtt2 == true)
                    {
                        baglanti.Open();
                        SqlCommand sqlCommand = new SqlCommand("select * from Tbl_SilinenBasvurular where Sbasvuru_ad = @p1 and Sbasvuru_soyad = @p2 and Sbasvuru_TC = @p3 and Sbasvuru_meslek = 'Öğretmen'", baglanti);
                        sqlCommand.Parameters.AddWithValue("@p1", txtAd.Text);
                        sqlCommand.Parameters.AddWithValue("@p2", txtOgretmenSoyad.Text);
                        sqlCommand.Parameters.AddWithValue("@p3", maskOgretmenTC.Text);
                        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                        if (sqlDataReader.Read())
                        {
                            MessageBox.Show("Maalesef kayıt olamazsınız. Başvurunuz reddedilmiştir.", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Aranan Öğretmen bulunamamıştır. Eğer bilgileriniz doğruluğundan eminseniz öncelikle başvuru yapmanız gerekiyor", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        baglanti.Close();
                    }
                }
                temizle();
                capcathaolusturma();
            }
            else
            {
                MessageBox.Show("Hata! Captcha doğrulanamadı", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                capcathaolusturma();
                txtCaptcha.Text = "";
                txtCaptcha.Focus();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmOgretmenBasvuru basvuru = new FrmOgretmenBasvuru();
            basvuru.Show();
            this.Close();
        }
    }
}
