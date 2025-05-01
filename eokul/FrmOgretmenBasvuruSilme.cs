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
    public partial class FrmOgretmenBasvuruSilme : Form
    {
        public FrmOgretmenBasvuruSilme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=burak;Initial Catalog=Eokulveritabani;Integrated Security=True");
        bool durum;
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Tbl_Basvuru where Basvuru_ogrTC = @p1 and Basvuru_ad= @p2 and Basvuru_soyad= @p3", baglanti);
            komut.Parameters.AddWithValue("@p1", maskTC.Text);
            komut.Parameters.AddWithValue("@p2", txtAd.Text);
            komut.Parameters.AddWithValue("@p3", txtSoyad.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                durum = true;
            }
            else
            {
                durum = false;
            }
            baglanti.Close();
            if (durum == true)
            {
                baglanti.Open();
                SqlCommand komutsilme = new SqlCommand("Delete From Tbl_Ogretmen where Ogretmen_TC = @p1 and Ogretmen_ad = @p2 and Ogretmen_soyad = @p3", baglanti);
                komutsilme.Parameters.AddWithValue("@p1", maskTC.Text);
                komutsilme.Parameters.AddWithValue("@p2", txtAd.Text);
                komutsilme.Parameters.AddWithValue("@p3", txtSoyad.Text);
                komutsilme.ExecuteNonQuery();
                baglanti.Close();
                baglanti.Open();
                SqlCommand komutsilme2 = new SqlCommand("Delete From Tbl_Basvuru where Basvuru_ogrTC = @p1 and Basvuru_ad= @p2 and Basvuru_soyad= @p3", baglanti);
                komutsilme2.Parameters.AddWithValue("@p1", maskTC.Text);
                komutsilme2.Parameters.AddWithValue("@p2", txtAd.Text);
                komutsilme2.Parameters.AddWithValue("@p3", txtSoyad.Text);
                komutsilme2.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Bilgileriniz silinmiştir!","bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hata. Ya yanlış bilgiler girildi veya bu kişi öğretmenler arasından başvuru yapmamış.","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void FrmOgretmenBasvuruSilme_Load(object sender, EventArgs e)
        {

        }
    }
}
