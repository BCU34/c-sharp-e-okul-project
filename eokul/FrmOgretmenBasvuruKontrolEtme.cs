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
namespace eokul
{
    public partial class FrmOgretmenBasvuruKontrolEtme : Form
    {
        public FrmOgretmenBasvuruKontrolEtme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=burak;Initial Catalog=Eokulveritabani;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            bool d1=false;
            baglanti.Open();
            SqlCommand komutonce = new SqlCommand("select * from Tbl_Ogretmen where Ogretmen_TC = @p1 and Ogretmen_ad=@p2 and Ogretmen_soyad = @p3", baglanti);
            komutonce.Parameters.AddWithValue("@p1", maskTC.Text);
            komutonce.Parameters.AddWithValue("@p2", txtAd.Text);
            komutonce.Parameters.AddWithValue("@p3", txtSoyad.Text);
            SqlDataReader dronce = komutonce.ExecuteReader();
            if (dronce.Read())
            {
                if (bool.Parse(dronce[9].ToString()) == true)
                {
                    if (bool.Parse(dronce[10].ToString()) == true)
                    {
                        MessageBox.Show("Bu Aranan kişi zaten kayıt bile olmuştur!","bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Başvurunuz kabul edilmiştir!","bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Başvurunuz henüz kabul edilmemiştir!","bilgi",MessageBoxButtons.OK);
                }
            }
            else
            {
                d1 = true;
            }
            baglanti.Close();
            if (d1 == true)
            {
                baglanti.Open();
                SqlCommand komutsilinenbasvuru = new SqlCommand("select * from Tbl_SilinenBasvurular where Sbasvuru_ad = @p1 and Sbasvuru_soyad = @p2 and Sbasvuru_TC = @p3 and Sbasvuru_meslek = @p4", baglanti);
                komutsilinenbasvuru.Parameters.AddWithValue("@p1", txtAd.Text);
                komutsilinenbasvuru.Parameters.AddWithValue("@p2", txtSoyad.Text);
                komutsilinenbasvuru.Parameters.AddWithValue("@p3", maskTC.Text);
                komutsilinenbasvuru.Parameters.AddWithValue("@p4", "Öğretmen");
                SqlDataReader dataReader = komutsilinenbasvuru.ExecuteReader();
                if (dataReader.Read())
                {
                    MessageBox.Show("Başvurunuz Reddedilmiştir.","bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Aranan Öğretmen bulunamadı. Bilgileri yanlış girilmiştir ya da siz başvurunuzu yapmamışsınızdır.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                baglanti.Close();
            }
        }

        private void FrmOgretmenBasvuruKontrolEtme_Load(object sender, EventArgs e)
        {

        }
    }
}
