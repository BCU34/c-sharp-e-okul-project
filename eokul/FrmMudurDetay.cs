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
using System.Linq.Expressions;
using System.Collections;
using System.Reflection.Emit;
namespace eokul
{
    public partial class FrmMudurDetay : Form
    {
        public FrmMudurDetay()
        {
            InitializeComponent();
        }
        public string mudurunadi;
        public string mudurunsoyadi;
        public string mudurunid;
        public string muduruntc;
        public string mudurunyas;
        public string mudurunDT;
        public string mdrokulunadi;
        public string mudursifre;
        public string rutbe;
        public string sorumluolunansube;
        SqlConnection baglanti = new SqlConnection("Data Source=burak;Initial Catalog=Eokulveritabani;Integrated Security=True");
        void resimle()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select M_profilfoto from Tbl_Mudur where Mudur_id = @p1", baglanti);
            komut.Parameters.AddWithValue("@p1", mudurunid);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                try
                {
                    if (dr[0].ToString() != "yok")
                    {
                        Image img = Image.FromFile(dr[0].ToString());
                        btnmudurprofil.BackgroundImage = img;
                        btnmudurprofil.Text = "";
                        btnmudurprofil.BackgroundImageLayout = ImageLayout.Zoom;
                    }
                    else
                    {
                        btnmudurprofil.Text = mudurunadi[0].ToString();
                    }
                }
                catch
                {
                    btnmudurprofil.Text = mudurunadi[0].ToString();
                }
            }
            baglanti.Close();
        }
        bool thg;
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
        void Datagrafiksinir()
        {
            //Öğretmek Kısım
            baglanti.Open();
            SqlCommand komutogretmencinsiyet = new SqlCommand("select Ogretmen_cinsiyet,count(*) from Tbl_Ogretmen group by Ogretmen_cinsiyet", baglanti);
            SqlDataReader drogretmencinsiyet = komutogretmencinsiyet.ExecuteReader();
            while (drogretmencinsiyet.Read())
            {
                Ogrt_cinsiyet.Series["Cinsiyet"].Points.AddXY(drogretmencinsiyet[0].ToString(), drogretmencinsiyet[1].ToString());
            }
            baglanti.Close();
        }
        private void FrmMudurDetay_Load(object sender, EventArgs e)
        {
            Datagrafiksinir();
            resimle();
            this.Text = rutbe + " Detayları";
            lblOkulAdi.Text = mdrokulunadi.ToUpper();
            lblMuduradsoyad.Text = mudurunadi + " " + mudurunsoyadi.ToUpper();
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
            Point okulunadininlocationu = new Point(12, 9);
            lblOkulAdi.Location = okulunadininlocationu;
            Point panelinyeri = new Point((lblOkulAdi.Size.Width + 16), 9);
            panel1.Location = panelinyeri;
            int artacak = 0;
            for(int i = 0;i<lblMuduradsoyad.Text.Length;i++)
            {
                if (lblMuduradsoyad.Text[i].ToString()=="i" || lblMuduradsoyad.Text[i].ToString() == "ı" || lblMuduradsoyad.Text[i].ToString() == "j" || lblMuduradsoyad.Text[i].ToString() == "l" || lblMuduradsoyad.Text[i].ToString() == "t" || lblMuduradsoyad.Text[i].ToString() == "İ" || lblMuduradsoyad.Text[i].ToString() == "I")
                {
                    artacak += 4;
                }
                else
                {
                    artacak += 7;
                }
            }
            int panelboyutWidth = 68 + artacak;
            Size size1 = new Size(panelboyutWidth,panel1.Size.Height);
            panel1.Size = size1;
            Size size2 = new Size(panel1.Location.X + panelboyutWidth + 28, this.Size.Height);
            this.Size = size2;
            Point butonx1 = new Point(panel1.Location.X, 63);
            Size butonortak = new Size(int.Parse(panel1.Size.Width.ToString()), int.Parse(btnHakkimda.Size.Height.ToString()));
            Point butonx2 = new Point(panel1.Location.X, 97);
            Point butonx3 = new Point(panel1.Location.X, 131);
            btnBasvuru.Location = butonx2;
            btnHakkimda.Location = butonx1;
            btnCikis.Location = butonx3;
            btnBasvuru.Size = butonortak;
            btnCikis.Size = butonortak;
            btnHakkimda.Size = butonortak;
            timer1.Start();
        }
        bool hakkindasecenegi = false;
        private void btnmudurprofil_Click(object sender, EventArgs e)
        {
            if (hakkindasecenegi == false)
            {
                btnHakkimda.Visible = true;
                btnBasvuru.Visible = true;
                btnCikis.Visible = true;
                hakkindasecenegi = true;
            }
            else
            {
                btnBasvuru.Visible = false;
                btnHakkimda.Visible = false;
                btnCikis.Visible = false;
                hakkindasecenegi = false;
            }
        }
        bool fmhakkindabasvuruacikmi;
        void basvuruacikmiesitle()
        {
            baglanti.Open();
            SqlCommand komutbit = new SqlCommand("select M_hakkimdabasvuruacikmi from Tbl_Mudur where Mudur_id = @p1", baglanti);
            komutbit.Parameters.AddWithValue("@p1", mudurunid);
            SqlDataReader drbit = komutbit.ExecuteReader();
            while (drbit.Read())
            {
                fmhakkindabasvuruacikmi = bool.Parse(drbit[0].ToString());
            }
            baglanti.Close();
        }
        private void btnHakkimda_Click(object sender, EventArgs e)
        {
            basvuruacikmiesitle();
            if (fmhakkindabasvuruacikmi == false)
            {
                FrmMudurHakkinda fmh = new FrmMudurHakkinda();
                fmh.mudurunid = mudurunid;
                fmh.mudurunadi = mudurunadi;
                fmh.mudurunsoyadi = mudurunsoyadi;
                fmh.muduruntc = muduruntc;
                fmh.mudurunyas = mudurunyas;
                fmh.mudurunDT = mudurunDT;
                fmh.mdrokulunadi = mdrokulunadi;
                fmh.mudursifre = mudursifre;
                fmh.rutbe = rutbe;
                fmh.sorumluolunansube = sorumluolunansube;
                fmh.Show();
            }
            
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            FrmAnaGiris f = new FrmAnaGiris();
            f.Show();
            this.Close();
        }
        private void lblppdegistirme_MouseClick(object sender, MouseEventArgs e)
        {
            lblppdegistirme.Visible = false;
        }
        private void profilFotoğrafıKaldırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsilme = new SqlCommand("update Tbl_Mudur set M_profilfoto = 'yok' where Mudur_id=@p1", baglanti);
            komutsilme.Parameters.AddWithValue("@p1", mudurunid);
            komutsilme.ExecuteNonQuery();
            baglanti.Close();
            FrmMudurGiris frm = new FrmMudurGiris();
            this.Close();
            frm.Show();

        }
        private void profilFotoğrafıDeğiştirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Resim Dosyaları (*.png;*.jpg) |*.png;*.jpg";
            ofd.Title = "Resim Seç";
            ofd.InitialDirectory = "c:\\";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Update Tbl_Mudur set M_profilfoto = @p1 where Mudur_id = @p2", baglanti);
                komut.Parameters.AddWithValue("@p1", ofd.FileName);
                komut.Parameters.AddWithValue("@p2", mudurunid);
                komut.ExecuteNonQuery();
                baglanti.Close();
                Image image = Image.FromFile(ofd.FileName);
                btnmudurprofil.BackgroundImage = image;
                btnmudurprofil.Text = "";
                btnmudurprofil.BackgroundImageLayout = ImageLayout.Zoom;
                MessageBox.Show("Profil Fotoğrafı seçilmiştir!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblppdegistirme.Visible = true;

            }
        }
        private void lblZaman_Click(object sender, EventArgs e)
        {
            thgyapma();
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
        private void btnBasvuru_Click(object sender, EventArgs e)
        {
            basvuruacikmiesitle();
            if(fmhakkindabasvuruacikmi == false)
            {
                FrmMudureGelenBasvurular fmgb = new FrmMudureGelenBasvurular();
                fmgb.muduradi = mudurunadi;
                fmgb.mudursoyadi = mudurunsoyadi;
                fmgb.mudurrutbe = rutbe;
                fmgb.Show();
            }
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Hesabınızdan çıkış yapmak istediğinize emin misiniz?","İşlem",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand MasaustuUPDATE = new SqlCommand("update Tbl_Mudur set Mudur_Masaustusu = @p1 where Mudur_id = @p2", baglanti);
                MasaustuUPDATE.Parameters.AddWithValue("@p1", "");
                MasaustuUPDATE.Parameters.AddWithValue("@p2", mudurunid);
                MasaustuUPDATE.ExecuteNonQuery();
                baglanti.Close();
                FrmAnaGiris ana = new FrmAnaGiris();
                ana.Show();
                this.Close();
            }
            
        }
    }
}
