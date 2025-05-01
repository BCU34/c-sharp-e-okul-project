using System;
using System.Collections;
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
    public partial class FrmMudureGelenBasvurular : Form
    {
        public FrmMudureGelenBasvurular()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=burak;Initial Catalog=Eokulveritabani;Integrated Security=True");
        ArrayList b_listeidleri = new ArrayList();
        ArrayList c_listeidleri = new ArrayList();
        void Basvuruclickk()
        {
            baglanti.Open();
            SqlCommand siralamakomudu = new SqlCommand("select * from Tbl_Basvuru where Basvuru_meslek = @p1", baglanti);
            if (radioOgrenci.Checked == true)
            {
                siralamakomudu.Parameters.AddWithValue("@p1", "Öğrenci");
                groupBGO.Text = "Başvuru Gönderen Öğrenciler";
                groupOgrDetay.Text = "Öğrenci Detaylar";
                label10.Visible = false;
                txtOgretmenDers.Visible = false;
            }
            else if (radioOgretmen.Checked == true)
            {
                siralamakomudu.Parameters.AddWithValue("@p1", "Öğretmen");
                groupBGO.Text = "Başvuru Gönderen Öğretmenler";
                groupOgrDetay.Text = "Öğretmen Detaylar";
                label10.Visible = true;
                txtOgretmenDers.Visible = true;
            }
            else
            {
                siralamakomudu.Parameters.AddWithValue("@p1", "Müdür Yardımcısı");
                groupBGO.Text = "Başvuru Gönderen Müdür Yardımcıları";
                groupOgrDetay.Text = "Müdür Yardımcı Detaylar";
                label10.Visible = true;
                txtOgretmenDers.Visible = true;
            }
            richAciklama.Text = "NULL";
            txtOgrenciAdSoyad.Text = "null null";
            txtOgrenciYas.Text = "00";
            radioErkek.Checked = true;
            radioKadin.Checked = false;
            maskOgrenciTC.Text = "00000000000";
            txtOgretmenDers.Text = "null";
            SqlDataReader dr = siralamakomudu.ExecuteReader();
            listBox1.Items.Clear();
            b_listeidleri.Clear();
            while (dr.Read())
            {
                listBox1.Items.Add(dr[1].ToString() + " " + dr[2].ToString());
                b_listeidleri.Add(int.Parse(dr[0].ToString()));
            }
            baglanti.Close();
            if (radioOgrenci.Checked == true)
            {
                //baska zaman
            }
            else if(radioOgretmen.Checked==true)
            {
                baglanti.Open();
                SqlCommand sql = new SqlCommand("select * from Tbl_Ogretmen where Ogretmen_baskabul = @p1",baglanti);
                sql.Parameters.AddWithValue("@p1", false);
                SqlDataReader sqlData = sql.ExecuteReader();
                c_listeidleri.Clear();
                while (sqlData.Read())
                {
                    c_listeidleri.Add(int.Parse(sqlData[0].ToString()));
                }
                baglanti.Close();
            }
        }
        public string mudurrutbe;
        public string muduradi;
        public string mudursoyadi;
        private void FrmMudureGelenBasvurular_Load(object sender, EventArgs e)
        {
            Basvuruclickk();
            this.Text = muduradi + " " + mudursoyadi + " " + mudurrutbe + " - Başvurular";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                int indeks = int.Parse(b_listeidleri[listBox1.SelectedIndex].ToString());
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from Tbl_Basvuru where Basvuru_id = @p1", baglanti);
                komut.Parameters.AddWithValue("@p1", indeks);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    txtOgrenciAdSoyad.Text = dr[1] + " " + dr[2];
                    txtOgrenciYas.Text = dr[3].ToString();
                    if (dr[4].ToString() == "Erkek")
                    {
                        radioErkek.Checked = true;
                        radioKadin.Checked = false;
                    }
                    else
                    {
                        radioErkek.Checked = false;
                        radioKadin.Checked = true;
                    }
                    maskOgrenciTC.Text = dr[5].ToString();
                    txtOgretmenDers.Text = dr[6].ToString();
                    richAciklama.Text = dr[7].ToString();
                }
                baglanti.Close();
            }
        }

        private void radioOgrenci_CheckedChanged(object sender, EventArgs e)
        {
            Basvuruclickk();
        }

        private void radioOgretmen_CheckedChanged(object sender, EventArgs e)
        {
            Basvuruclickk();
        }

        private void radioMdrYardimcisi_CheckedChanged(object sender, EventArgs e)
        {
            Basvuruclickk();
        }

        private void btnOgrtckimliknogosteraciklama_Click(object sender, EventArgs e)
        {
            if (maskOgrenciTC.UseSystemPasswordChar == true)
            {
                btnOgrtckimliknogosteraciklama.BackgroundImage = Properties.Resources.show;
                btnOgrtckimliknogosteraciklama.BackgroundImageLayout = ImageLayout.Zoom;
                maskOgrenciTC.UseSystemPasswordChar = false;
            }
            else
            {
                btnOgrtckimliknogosteraciklama.BackgroundImage = Properties.Resources.hide;
                btnOgrtckimliknogosteraciklama.BackgroundImageLayout = ImageLayout.Zoom;
                maskOgrenciTC.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioOgretmen.Checked==true)
            {
                int indeks1 = int.Parse(b_listeidleri[listBox1.SelectedIndex].ToString());
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Delete from Tbl_Basvuru where Basvuru_id = @p1", baglanti);
                komut.Parameters.AddWithValue("@p1", indeks1);
                komut.ExecuteNonQuery();
                baglanti.Close();
                int indeks2 =int.Parse(c_listeidleri[listBox1.SelectedIndex].ToString());
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update Tbl_Ogretmen set Ogretmen_baskabul = @p1 where Ogretmen_id = @p2", baglanti);
                komut2.Parameters.AddWithValue("@p1", true);
                komut2.Parameters.AddWithValue("@p2", indeks2);
                komut2.ExecuteNonQuery();
                baglanti.Close();
            }
            MessageBox.Show("Başvuru Kabul edilmiştir!");
            Basvuruclickk();
        }
        string cinsiyet;
        private void button2_Click(object sender, EventArgs e)
        {
            if (radioOgretmen.Checked == true)
            {
                int indeks1 = int.Parse(c_listeidleri[listBox1.SelectedIndex].ToString()),indeks2 = int.Parse(b_listeidleri[listBox1.SelectedIndex].ToString());
                string ad="", soyad="",meslekk="";
                baglanti.Open();
                SqlCommand komutsiralaama = new SqlCommand("select Basvuru_ad, Basvuru_soyad,Basvuru_meslek from Tbl_Basvuru where Basvuru_id = @p1", baglanti);
                komutsiralaama.Parameters.AddWithValue("@p1", indeks2);
                SqlDataReader dr1 = komutsiralaama.ExecuteReader();
                while (dr1.Read())
                {
                    ad = dr1[0].ToString();
                    soyad = dr1[1].ToString();
                    meslekk = dr1[2].ToString();
                    
                }
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut1 = new SqlCommand("Delete from Tbl_Ogretmen where Ogretmen_id = @p1", baglanti);
                komut1.Parameters.AddWithValue("@p1", indeks1);
                komut1.ExecuteNonQuery();
                baglanti.Close();
               
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("Delete from Tbl_Basvuru where Basvuru_id = @p1", baglanti);
                komut2.Parameters.AddWithValue("@p1", indeks2);
                komut2.ExecuteNonQuery();
                baglanti.Close();
                if(radioErkek.Checked == true)
                {
                    cinsiyet = "Erkek";
                }
                else
                {
                    cinsiyet = "Kadın";
                }
                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("insert into Tbl_SilinenBasvurular (Sbasvuru_id,Sbasvuru_ad,Sbasvuru_soyad,Sbasvuru_TC,Sbasvuru_meslek,Sbasvuru_yas,Sbasvuru_cinsiyet,Sbasvuru_ders,Sbasvuru_aciklama) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", baglanti);
                komut3.Parameters.AddWithValue("@p1", indeks2);
                komut3.Parameters.AddWithValue("@p2", ad);
                komut3.Parameters.AddWithValue("@p3", soyad);
                komut3.Parameters.AddWithValue("@p4", maskOgrenciTC.Text);
                komut3.Parameters.AddWithValue("@p5", meslekk);
                komut3.Parameters.AddWithValue("@p6", int.Parse(txtOgrenciYas.Text));
                komut3.Parameters.AddWithValue("@p7", cinsiyet);
                komut3.Parameters.AddWithValue("@p8", txtOgretmenDers.Text);
                komut3.Parameters.AddWithValue("@p9", richAciklama.Text);
                komut3.ExecuteNonQuery();
                baglanti.Close();
            }
            MessageBox.Show("Başvuru reddedilmiştir!","bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Basvuruclickk();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmBasvurularsql basvurular = new FrmBasvurularsql();
            basvurular.Show();
        }
    }
}
