using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
namespace eokul
{
    public partial class FrmYoklamaSinifiGiris : Form
    {
        public FrmYoklamaSinifiGiris()
        {
            InitializeComponent();
        }
        public int ogretmenid;
        public string ogretmenad;
        public string ogretmensoyad;
        public string ogretmenders;
        public string ogretmencinsiyet;
        public int ogretmenyas;
        public string ogretmenTC;
        public string ogretmensifre;
        public string okulunadi;
        SqlConnection baglanti = new SqlConnection("Data Source=burak;Initial Catalog=Eokulveritabani;Integrated Security=True");
        string[] ders_dizi = new string[6];
        void gun_eslestirme_sart(string tablo)
        {

            baglanti.Open();
            SqlCommand gun_eslestirme = new SqlCommand("select * from "+tablo, baglanti);
            SqlDataReader drgunesles = gun_eslestirme.ExecuteReader();
            if (drgunesles.Read())
            {
                ders_dizi[0] = drgunesles[1].ToString();
                ders_dizi[1] = drgunesles[2].ToString();
                ders_dizi[2] = drgunesles[3].ToString();
                ders_dizi[3] = drgunesles[4].ToString();
                ders_dizi[4] = drgunesles[5].ToString();
                ders_dizi[5] = drgunesles[6].ToString();
            }
            baglanti.Close();
        }
        void yoklama_sistemine_giris(string lesson_name)
        {
            FrmYoklamaSistemi yoklamasistem = new FrmYoklamaSistemi();
            yoklamasistem.ogretmenad = ogretmenad;
            yoklamasistem.ogretmensoyad = ogretmensoyad;
            yoklamasistem.ogretmencinsiyet = ogretmencinsiyet;
            yoklamasistem.ogretmenders = ogretmenders;
            yoklamasistem.dersadi = lesson_name;
            yoklamasistem.ogrenci_bolum = cmbAlan.Text;
            yoklamasistem.ogrenci_sube = cmbSube.Text;
            yoklamasistem.ogrenci_sinif = cmbSinif.Text;
            yoklamasistem.ogretmenid = ogretmenid;
            yoklamasistem.ogretmensifre = ogretmensifre;
            yoklamasistem.ogretmenTC = ogretmenTC;
            yoklamasistem.ogretmenyas = ogretmenyas;
            yoklamasistem.Show();
            this.Close();
        }
        void yoklama_sorgu(int deger)
        {
            if (ders_dizi[deger].ToString() != "bos")
            {
                if (ogretmenders == ders_dizi[deger].ToString())
                {
                    yoklama_sistemine_giris(ders_dizi[deger].ToString());
                }
                else
                {
                    DialogResult emin = MessageBox.Show("Yanlış giriş yapmadığınıza emin misiniz? Çünkü " + cmbSinif.Text + "/" + cmbSube.Text + " " + cmbAlan.Text + " sınıfının dersi '" + ders_dizi[deger] + "'. Ama sizin öğrettiğiniz ders '" + ogretmenders + "'. Eğer başka hoca izinliyse giriş yapabilirsiniz.", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (emin == DialogResult.Yes)
                    {
                        yoklama_sistemine_giris(ders_dizi[deger].ToString());
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Ders yoktur! Yoklama almanızı maalesef ki kabul edemem.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool drdersokundu = false;
            // Şuanlık bugunn degiskenini salladım, normalde kod >> DateTime.Now.ToString("dddd", new CultureInfo("tr-TR"))
            string bugunn = "pazartesi",bugun=bugunn.ToLower();
            int busaat = int.Parse(DateTime.Now.ToString("HH", new CultureInfo("tr-TR"))), budakika = int.Parse(DateTime.Now.ToString("mm", new CultureInfo("tr-TR")));
            baglanti.Open();
            SqlCommand derssaatikontroletme = new SqlCommand("select * from Tbl_Ogrenci inner join Tbl_DersProgramiPERSEMBE on Tbl_Ogrenci.ogrenci_dersprogrami = Tbl_DersProgramiPERSEMBE.dersprogrami_id where ogrenci_sinif = @p1 and ogrenci_sube = @p2 and ogrenci_bolum = @p3", baglanti);
            derssaatikontroletme.Parameters.AddWithValue("@p1", cmbSinif.Text);
            derssaatikontroletme.Parameters.AddWithValue("@p2", cmbSube.Text);
            derssaatikontroletme.Parameters.AddWithValue("@p3", cmbAlan.Text);
            SqlDataReader drders = derssaatikontroletme.ExecuteReader();
            if (drders.Read())
            {
                //ben baglanti.Open() içinde baglanti.Open() yazdığımdan dolayı böyle bir sonuç çıkardım.
                drdersokundu = true;
            }
            else
            {
                MessageBox.Show("HATA! Herhalde bir yeri yanlış girdiniz. Tekrar Deneyiniz.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            baglanti.Close();
            if (drdersokundu == true)
            {
                if (bugun == "pazartesi" || bugun == "salı" || bugun == "çarşamba" || bugun == "perşembe" || bugun == "cuma")
                {
                    switch (bugun)
                    {
                        case "pazartesi":
                            gun_eslestirme_sart("Tbl_DersProgramiPZRTESI");
                            break;
                        case "salı":
                            gun_eslestirme_sart("Tbl_DersProgramiSALI");
                            break;
                        case "çarşamba":
                            gun_eslestirme_sart("Tbl_DersProgramiCARSAMBA");
                            break;
                        case "perşembe":
                            gun_eslestirme_sart("Tbl_DersProgramiPERSEMBE");
                            break;
                        default:
                            gun_eslestirme_sart("Tbl_DersProgramiCUMA");
                            break;
                    }
                    if (busaat == 9)
                    {
                        if (budakika >= 0 && budakika <= 30)
                        {
                            yoklama_sorgu(0);
                        }
                        else if (budakika >= 40)
                        {
                            yoklama_sorgu(1);
                        }
                        else
                        {
                            MessageBox.Show("Tenefüs Zilindeyiz. Yoklama almanızı maalesef ki kabul edemem.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (busaat == 10)
                    {
                        if (budakika >= 0 && budakika <= 10)
                        {
                            yoklama_sorgu(1);
                        }
                        else if (budakika >= 20 && budakika <= 50)
                        {
                            yoklama_sorgu(2);
                        }
                        else
                        {
                            MessageBox.Show("Tenefüs Zilindeyiz. Yoklama almanızı maalesef ki kabul edemem.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (busaat == 11)
                    {
                        if (budakika >= 0 && budakika <= 30)
                        {
                            yoklama_sorgu(3);
                        }
                        else if (budakika >= 40)
                        {
                            yoklama_sorgu(4);
                        }
                        else
                        {
                            MessageBox.Show("Tenefüs Zilindeyiz. Yoklama almanızı maalesef ki kabul edemem.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (busaat == 12)
                    {
                        if (budakika >= 0 && budakika <= 10)
                        {
                            yoklama_sorgu(4);
                        }
                        else if (budakika >= 20 && budakika <= 50)
                        {
                            yoklama_sorgu(5);
                        }
                        else
                        {
                            MessageBox.Show("Tenefüs Zilindeyiz. Yoklama almanızı maalesef ki kabul edemem.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        // *** devam edecek öğlenciler mesela...
                    }
                }
                else
                {
                    MessageBox.Show("Bu gün günlerden '" + bugunn + "'. Yoklama alamazsınız", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
