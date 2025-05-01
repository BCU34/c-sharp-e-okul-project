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
    public partial class FrmYoklamaSistemi : Form
    {
        public FrmYoklamaSistemi()
        {
            InitializeComponent();
        }
        public int ogretmenid;
        public string ogretmenad;
        public string ogretmensoyad;
        public string ogretmenders;
        public string dersadi;
        public string ogretmencinsiyet;
        public int ogretmenyas;
        public string ogretmenTC;
        public string ogretmensifre;
        public string okulunadi;
        public string ogrenci_sinif;
        public string ogrenci_sube;
        public string ogrenci_bolum;
        SqlConnection baglanti = new SqlConnection("Data Source=burak;Initial Catalog=Eokulveritabani;Integrated Security=True");
        private void FrmYoklamaSistemi_Load(object sender, EventArgs e)
        {
            lblSinifSubeBolum.Text = ogrenci_sinif + "/" + ogrenci_sube + " " + ogrenci_bolum;
            lblOgretmenAdSoyad.Text = ogretmenad + " " + ogretmensoyad;
            if(dersadi == ogretmenders)
            {
                lblnormaldedersadi.Visible = false;
            }
            else
            {
                lblnormaldedersadi.Visible = true;
                lblOgretmeninDersadi.Enabled = false;
                lblOgretmeninDersadi.BackColor = Color.Transparent;
                lblnormaldedersadi.Text = dersadi;
            }
            lblOgretmeninDersadi.Visible = true;
            lblOgretmeninDersadi.Text = ogretmenders;
        }


    }
}
