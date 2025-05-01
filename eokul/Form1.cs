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
using System.IO;
namespace eokul
{
    public partial class FrmAnaGiris : Form
    {
        public FrmAnaGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=burak;Initial Catalog=Eokulveritabani;Integrated Security=True");
        void thgkontrol()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select timer_kisatam from Tbl_Timerr where timer_id = @p1", baglanti);
            komut.Parameters.AddWithValue("@p1", 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                thg = (bool)dr[0];
            }
            baglanti.Close();
        }
        void thgyapma()
        {
            thgkontrol();
            if (thg == true)
            {
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update Tbl_Timerr set timer_kisatam = @p1 where timer_id=@p2", baglanti);
                komut2.Parameters.AddWithValue("@p1", false);
                komut2.Parameters.AddWithValue("@p2", 1);
                komut2.ExecuteNonQuery();
                baglanti.Close();
                thg = false;
            }
            else
            {
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update Tbl_Timerr set timer_kisatam = @p1 where timer_id=@p2", baglanti);
                komut2.Parameters.AddWithValue("@p1", true);
                komut2.Parameters.AddWithValue("@p2", 1);
                komut2.ExecuteNonQuery();
                baglanti.Close();
                thg = true;
            }
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            string mudurunadi="",mudurunsoyadi="", mudurunid="", muduruntc="",mudurunyas="",mudurunDT = "",mdrokulunadi = "",mudursifre = "",rutbe = "",sorumluolunansube = "";
            bool detayagiris = false;
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            baglanti.Open();
            SqlCommand komudum = new SqlCommand("select * from Tbl_Mudur",baglanti);
            SqlDataReader sqlDataReader = komudum.ExecuteReader();
            while (sqlDataReader.Read())
            {
                if (sqlDataReader[12].ToString() == desktopPath)
                {
                    detayagiris = true;
                    mudurunid= sqlDataReader[0].ToString();
                    mudurunadi= sqlDataReader[1].ToString();
                    mudurunsoyadi= sqlDataReader[2].ToString();
                    muduruntc= sqlDataReader[3].ToString();
                    mudurunyas= sqlDataReader[4].ToString();
                    mudurunDT= sqlDataReader[5].ToString();
                    mdrokulunadi= sqlDataReader[6].ToString();
                    mudursifre= sqlDataReader[7].ToString();
                    rutbe= sqlDataReader[8].ToString();
                    sorumluolunansube= sqlDataReader[9].ToString();
                }
            }
            baglanti.Close();
            if (detayagiris == false) { 
                FrmMudurGiris f = new FrmMudurGiris();
                f.Show();
                this.Hide();
            }
            else
            {
                FrmMudurDetay f = new FrmMudurDetay();
                f.mudurunid = mudurunid;
                f.mudurunadi = mudurunadi;
                f.mudurunsoyadi = mudurunsoyadi;
                f.muduruntc = muduruntc;
                f.mudurunyas = mudurunyas;
                f.mudurunDT = mudurunDT;
                f.mdrokulunadi = mdrokulunadi;
                f.mudursifre = mudursifre;
                f.rutbe = rutbe;
                f.sorumluolunansube = sorumluolunansube;
                f.Show();
                this.Hide();
            }

        }
        private void FrmAnaGiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("update Tbl_Timerr set timer_calisimi = @p1 where timer_id=@p2", baglanti);
            komut2.Parameters.AddWithValue("@p1", false);
            komut2.Parameters.AddWithValue("@p2", 1);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            Application.Exit();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FrmOgretmenGiris ogr = new FrmOgretmenGiris();
            ogr.Show();
            this.Hide();
        }
        private void FrmAnaGiris_Load(object sender, EventArgs e)
        {
            thgkontrol();
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select timer_calisimi from Tbl_Timerr where timer_id = @p1", baglanti);
            komut3.Parameters.AddWithValue("@p1", 1);
            SqlDataReader dr2 = komut3.ExecuteReader();
            while (dr2.Read())
            {
                if ((bool)dr2[0] == false)
                {
                    TimerForm form = new TimerForm();
                    form.Show();
                }
            }
            baglanti.Close();
            if (thg == true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select timer_tamhali from Tbl_Timerr where timer_id = @p1", baglanti);
                komut.Parameters.AddWithValue("@p1", 1);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    lblZaman.Text = dr[0].ToString();
                }
                baglanti.Close();
            }
            else
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select timer_kisahali from Tbl_Timerr where timer_id = @p1", baglanti);
                komut.Parameters.AddWithValue("@p1", 1);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    lblZaman.Text = dr[0].ToString();
                }
                baglanti.Close();
            }
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("update Tbl_Timerr set timer_calisimi = @p1 where timer_id=@p2", baglanti);
            komut2.Parameters.AddWithValue("@p1", true);
            komut2.Parameters.AddWithValue("@p2", 1);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (thg == true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select timer_tamhali from Tbl_Timerr where timer_id = @p1", baglanti);
                komut.Parameters.AddWithValue("@p1", 1);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    lblZaman.Text = dr[0].ToString();
                }
                baglanti.Close();
            }
            else
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select timer_kisahali from Tbl_Timerr where timer_id = @p1", baglanti);
                komut.Parameters.AddWithValue("@p1", 1);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    lblZaman.Text = dr[0].ToString();
                }
                baglanti.Close();
            }
        }
        bool thg;
        private void lblZaman_Click(object sender, EventArgs e)
        {
            thgyapma();
        }

        
    }
}
