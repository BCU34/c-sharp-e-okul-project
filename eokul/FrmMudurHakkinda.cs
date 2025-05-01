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
    public partial class FrmMudurHakkinda : Form
    {
        public FrmMudurHakkinda()
        {
            InitializeComponent();
        }
        int gbkb = 0;
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
        void kolaylikguncelle(int deger)
        {
            label3.Top += deger;
            label4.Top += deger;
            label5.Top += deger;
            txtyas.Top += deger;
            txtDT.Top += deger;
            txtsifre.Top += deger;
            btnGostersifre.Top += deger;
        }
        void yukle(bool durum)
        {
            masktc.Text = muduruntc;
            txtyas.Text = mudurunyas;
            txtDT.Text = mudurunDT;
            txtsifre.Text = mudursifre;
            groupbilgiislem.Visible = durum;
            groupupdateislem.Visible = durum;
            label1.Visible = durum;
            label2.Visible = durum;
            label3.Visible = durum;
            label4.Visible = durum;
            label5.Visible = durum;
            masktc.Visible = durum;
            txtadsoyad.Visible = durum;
            txtDT.Visible = durum;
            txtsifre.Visible = durum;
            txtyas.Visible = durum;
            lblbilgi.Visible = false;
            btnGostersifre.Visible = durum;
            btnGostertc.Visible = durum;
            btnGuncelle.Visible = durum;
            btnbilgilendirmee.Visible = durum;
            if (gbkb == 1)
            {
                lblSoyad.Visible = true;
                txtGSoyad.Visible = true;
                txtadsoyad.Text = mudurunadi;
            }
            else
            {
                lblSoyad.Visible = false;
                txtGSoyad.Visible = false;
                txtadsoyad.Text = mudurunadi + " " + mudurunsoyadi;
            }
        }
        void basvuruacikmiupdate(bool durum)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Tbl_Mudur set M_hakkimdabasvuruacikmi = @p1 where Mudur_id = @p2", baglanti);
            komut.Parameters.AddWithValue("@p1", durum);
            komut.Parameters.AddWithValue("@p2", mudurunid);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        private void FrmMudurHakkinda_Load(object sender, EventArgs e)
        {
            basvuruacikmiupdate(true);
            yukle(true);
            
        }

        private void btnGostertc_Click(object sender, EventArgs e)
        {
            if (masktc.UseSystemPasswordChar == true)
            {
                Image resim = Properties.Resources.show;
                btnGostertc.BackgroundImage = resim;
                btnGostertc.BackgroundImageLayout = ImageLayout.Zoom;
                masktc.UseSystemPasswordChar = false;
            }
            else
            {
                Image resim = Properties.Resources.hide;
                btnGostertc.BackgroundImage = resim;
                btnGostertc.BackgroundImageLayout = ImageLayout.Zoom;
                masktc.UseSystemPasswordChar = true;
            }
        }

        private void btnGostersifre_Click(object sender, EventArgs e)
        {
            if (txtsifre.UseSystemPasswordChar == true)
            {
                Image resim = Properties.Resources.show;
                btnGostersifre.BackgroundImage = resim;
                btnGostersifre.BackgroundImageLayout = ImageLayout.Zoom;
                txtsifre.UseSystemPasswordChar = false;
            }
            else
            {
                Image resim = Properties.Resources.hide;
                btnGostersifre.BackgroundImage = resim;
                btnGostersifre.BackgroundImageLayout = ImageLayout.Zoom;
                txtsifre.UseSystemPasswordChar = true;
            }
        }

        private void btnbilgilendirmee_Click(object sender, EventArgs e)
        {
            if (lblbilgi.Visible == false)
                lblbilgi.Visible = true;
            else
                lblbilgi.Visible = false;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (masktc.Enabled == false)
            {
                masktc.Enabled = true;
                txtadsoyad.Enabled = true;
                txtDT.Enabled = true;
                txtsifre.Enabled = true;
                txtyas.Enabled = true;
                lblSoyad.Visible = true;
                txtGSoyad.Visible = true;
                txtadsoyad.Text = mudurunadi;
                txtGSoyad.Text = mudurunsoyadi;
                gbkb = 1;
                kolaylikguncelle(46);
            }
            else
            {
                if (txtadsoyad.Text == mudurunadi && txtGSoyad.Text == mudurunsoyadi && masktc.Text == muduruntc && txtDT.Text == mudurunDT && txtsifre.Text == mudursifre && txtyas.Text == mudurunyas)
                {

                }
                else
                {
                    baglanti.Open();
                    SqlCommand komutguncelle = new SqlCommand("update Tbl_Mudur set Mudur_ad = @p1, Mudur_soyad = @p2, Mudur_TC = @p3, Mudur_Yas = @p4, Mudur_DTarihi = @p5, Mudur_Sifre = @p6 where Mudur_id = @p7", baglanti);
                    komutguncelle.Parameters.AddWithValue("@p1", txtadsoyad.Text);
                    komutguncelle.Parameters.AddWithValue("@p2", txtGSoyad.Text);
                    komutguncelle.Parameters.AddWithValue("@p3", masktc.Text);
                    komutguncelle.Parameters.AddWithValue("@p4", txtyas.Text);
                    komutguncelle.Parameters.AddWithValue("@p5", txtDT.Text);
                    komutguncelle.Parameters.AddWithValue("@p6", txtsifre.Text);
                    komutguncelle.Parameters.AddWithValue("@p7", mudurunid);
                    komutguncelle.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Başarıyla bilgileriniz güncellenmiştir!", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                kolaylikguncelle(-46);
                muduruntc = masktc.Text;
                mudurunDT = txtDT.Text;
                mudursifre = txtsifre.Text;
                mudurunyas = txtyas.Text;
                mudurunadi = txtadsoyad.Text;
                mudurunsoyadi = txtGSoyad.Text;
                gbkb = 0;
                yukle(true);
                masktc.Enabled = false;
                txtadsoyad.Enabled = false;
                txtDT.Enabled = false;
                txtsifre.Enabled = false;
                txtyas.Enabled = false;
                lblSoyad.Visible = false;
                txtGSoyad.Visible = false;
            }
        }

        private void FrmMudurHakkinda_FormClosing(object sender, FormClosingEventArgs e)
        {
            basvuruacikmiupdate(false);
        }
    }
}
