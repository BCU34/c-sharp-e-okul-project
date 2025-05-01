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
    public partial class FrmMudurGiris : Form
    {
        public FrmMudurGiris()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        string capthca;
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
        private void button1_Click(object sender, EventArgs e)
        {
            string masaustu="",mudurunadi = "", mudurunsoyadi = "", mudurunid = "", muduruntc = "", mudurunyas = "", mudurunDT = "", mdrokulunadi = "", mudursifre = "", rutbe = "", sorumluolunansube = "";
            bool formagidilsin = false;
            if (txtCaptcha.Text == capthca)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from Tbl_Mudur where Mudur_TC = @p1 and Mudur_Sifre = @p2", baglanti);
                komut.Parameters.AddWithValue("@p1", maskTC.Text);
                komut.Parameters.AddWithValue("@p2", txtSifre.Text);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    formagidilsin = true;
                    mudurunid = dr[0].ToString();
                    mudurunadi = dr[1].ToString();
                    mudurunsoyadi = dr[2].ToString();
                    muduruntc = dr[3].ToString();
                    mudurunyas = dr[4].ToString();
                    mudurunDT = dr[5].ToString();
                    mdrokulunadi = dr[6].ToString();
                    mudursifre = dr[7].ToString();
                    rutbe = dr[8].ToString();
                    sorumluolunansube = dr[9].ToString();
                    masaustu = dr[12].ToString();
                }
                else
                {
                    timer1.Stop();
                    MessageBox.Show("Tc Kimlik Numarası veya Şifre yanlış.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    timer1.Start();
                }
                baglanti.Close();
                txtSifre.Text = "";maskTC.Text = "";txtCaptcha.Text = "";maskTC.Focus();
                if (formagidilsin == true)
                {
                    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    FrmMudurDetay fmd = new FrmMudurDetay();
                    fmd.mudurunid = mudurunid;
                    fmd.mudurunadi = mudurunadi;
                    fmd.mudurunsoyadi = mudurunsoyadi;
                    fmd.muduruntc = muduruntc;
                    fmd.mudurunyas = mudurunyas;
                    fmd.mudurunDT = mudurunDT;
                    fmd.mdrokulunadi = mdrokulunadi;
                    fmd.mudursifre = mudursifre;
                    fmd.rutbe = rutbe;
                    fmd.sorumluolunansube = sorumluolunansube;
                    baglanti.Open();
                    SqlCommand MasaustuUPDATE = new SqlCommand("update Tbl_Mudur set Mudur_Masaustusu = @p1 where Mudur_id = @p2", baglanti);
                    MasaustuUPDATE.Parameters.AddWithValue("@p1", desktopPath);
                    MasaustuUPDATE.Parameters.AddWithValue("@p2", mudurunid);
                    MasaustuUPDATE.ExecuteNonQuery();
                    baglanti.Close();
                    fmd.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Hata! Captcha doğrulanamadı", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCaptcha.Text = "";
                txtCaptcha.Focus();
            }
            capcathaolusturma();
        }
        bool thg;
        private void btnGoster_Click(object sender, EventArgs e)
        {
            if (txtSifre.UseSystemPasswordChar == true)
            {
                Image image = Properties.Resources.show;
                btnGoster.BackgroundImage = image;
                btnGoster.BackgroundImageLayout = ImageLayout.Zoom;
                txtSifre.UseSystemPasswordChar = false;
            }
            else
            {
                Image image = Properties.Resources.hide;
                btnGoster.BackgroundImage = image;
                btnGoster.BackgroundImageLayout = ImageLayout.Zoom;
                txtSifre.UseSystemPasswordChar = true;
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            FrmAnaGiris form = new FrmAnaGiris();
            form.Show();
            this.Close();

        }

        private void FrmMudurGiris_Load(object sender, EventArgs e)
        {
            capcathaolusturma();
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

        private void lblZaman_Click(object sender, EventArgs e)
        {
            thgyapma();
        }
    }
}
