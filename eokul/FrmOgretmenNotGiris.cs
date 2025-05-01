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
using System.Collections;
namespace eokul
{
    public partial class FrmOgretmenNotGiris : Form
    {
        public FrmOgretmenNotGiris()
        {
            InitializeComponent();
        }
        public int ogrenci_id;
        public string ogrenci_ad;
        public string ogrenci_soyad;
        public int ogrenci_sinif;
        public string ogrenci_sube;
        public string ogrenci_bolum;
        public string ogrenci_alan;
        public string ogretmen_ders;
        public int ogretmen_id;
        public int ogrenci_numara;
        public int ogrenci_dersnotlariID;
        SqlConnection baglanti = new SqlConnection("Data Source=burak;Initial Catalog=Eokulveritabani;Integrated Security=True");
        ArrayList dersortalama = new ArrayList();
        ArrayList herdersnotlar = new ArrayList();
        void notlarislemload()
        {
            if (herdersnotlar.Count > 0)
            {
                float ort = 0;
                foreach (float i in herdersnotlar)
                {
                    ort += i;
                }
                dersortalama.Add((ort / herdersnotlar.Count).ToString());
            }
            else
            {
                dersortalama.Add("");
            }
            herdersnotlar.Clear();
        }
        void islemload()
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select * from Tbl_Notlar where notlar_id = @p1", baglanti);
            komut1.Parameters.AddWithValue("@p1", ogrenci_id);
            SqlDataReader dr1 = komut1.ExecuteReader();
            dersortalama.Clear();
            herdersnotlar.Clear();
            if (dr1.Read())
            {
                if (!string.IsNullOrEmpty(dr1[1].ToString()))
                {
                    txtCografya1Not.Text = dr1[1].ToString();
                    if (dr1[1].ToString().ToUpper() =="K" || dr1[1].ToString().ToUpper() == "G")
                    {
                        herdersnotlar.Add((float)0);
                    }
                    else
                    {
                        herdersnotlar.Add(float.Parse(dr1[1].ToString()));
                    }
                }
                if (!string.IsNullOrEmpty(dr1[2].ToString()))
                {
                    txtCografya2Not.Text = dr1[2].ToString();
                    if (dr1[2].ToString().ToUpper() == "K" || dr1[2].ToString().ToUpper() == "G")
                    {
                        herdersnotlar.Add((float)0);
                    }
                    else
                    {
                        herdersnotlar.Add(float.Parse(dr1[2].ToString()));
                    }
                }
                if (!string.IsNullOrEmpty(dr1[3].ToString()))
                {
                    txtCografya1Sozlu.Text = dr1[3].ToString();
                    if (dr1[3].ToString().ToUpper() == "K" || dr1[3].ToString().ToUpper() == "G")
                    {
                        herdersnotlar.Add((float)0);
                    }
                    else
                    {
                        herdersnotlar.Add(float.Parse(dr1[3].ToString()));
                    }
                }
                if (!string.IsNullOrEmpty(dr1[4].ToString()))
                {
                    txtCografya2Sozlu.Text = dr1[4].ToString();
                    if (dr1[4].ToString().ToUpper() == "K" || dr1[4].ToString().ToUpper() == "G")
                    {
                        herdersnotlar.Add((float)0);
                    }
                    else
                    {
                        herdersnotlar.Add(float.Parse(dr1[4].ToString()));
                    }
                }
                notlarislemload();
                if (!string.IsNullOrEmpty(dr1[5].ToString()))
                {
                    txtTurkce1Not.Text = dr1[5].ToString();
                    if (dr1[5].ToString().ToUpper() == "K" || dr1[5].ToString().ToUpper() == "G")
                    {
                        herdersnotlar.Add((float)0);
                    }
                    else
                    {
                        herdersnotlar.Add(float.Parse(dr1[5].ToString()));
                    }
                }
                if (!string.IsNullOrEmpty(dr1[6].ToString()))
                {
                    txtTurkce2Not.Text = dr1[6].ToString();
                    if (dr1[6].ToString().ToUpper() == "K" || dr1[6].ToString().ToUpper() == "G")
                    {
                        herdersnotlar.Add((float)0);
                    }
                    else
                    {
                        herdersnotlar.Add(float.Parse(dr1[6].ToString()));
                    }
                }
                if (!string.IsNullOrEmpty(dr1[7].ToString()))
                {
                    txtTurkce1Sozlu.Text = dr1[7].ToString();
                    if (dr1[7].ToString().ToUpper() == "K" || dr1[7].ToString().ToUpper() == "G")
                    {
                        herdersnotlar.Add((float)0);
                    }
                    else
                    {
                        herdersnotlar.Add(float.Parse(dr1[7].ToString()));
                    }
                }
                if (!string.IsNullOrEmpty(dr1[8].ToString()))
                {
                    txtTurkce2Sozlu.Text = dr1[8].ToString();
                    if (dr1[8].ToString().ToUpper() == "K" || dr1[8].ToString().ToUpper() == "G")
                    {
                        herdersnotlar.Add((float)0);
                    }
                    else
                    {
                        herdersnotlar.Add(float.Parse(dr1[8].ToString()));
                    }
                }
                notlarislemload();
                if (!string.IsNullOrEmpty(dr1[9].ToString()))
                {
                    txtTarih1Not.Text = dr1[9].ToString();
                    if (dr1[9].ToString().ToUpper() == "K" || dr1[9].ToString().ToUpper() == "G")
                    {
                        herdersnotlar.Add((float)0);
                    }
                    else
                    {
                        herdersnotlar.Add(float.Parse(dr1[9].ToString()));
                    }
                }
                if (!string.IsNullOrEmpty(dr1[10].ToString()))
                {
                    txtTarih2Not.Text = dr1[10].ToString();
                    if (dr1[10].ToString().ToUpper() == "K" || dr1[10].ToString().ToUpper() == "G")
                    {
                        herdersnotlar.Add((float)0);
                    }
                    else
                    {
                        herdersnotlar.Add(float.Parse(dr1[10].ToString()));
                    }
                }
                if (!string.IsNullOrEmpty(dr1[11].ToString()))
                {
                    txtTarih1Sozlu.Text = dr1[11].ToString();
                    if (dr1[11].ToString().ToUpper() == "K" || dr1[11].ToString().ToUpper() == "G")
                    {
                        herdersnotlar.Add((float)0);
                    }
                    else
                    {
                        herdersnotlar.Add(float.Parse(dr1[11].ToString()));
                    }
                }
                if (!string.IsNullOrEmpty(dr1[12].ToString()))
                {
                    txtTarih2Sozlu.Text = dr1[12].ToString();
                    if (dr1[12].ToString().ToUpper() == "K" || dr1[12].ToString().ToUpper() == "G")
                    {
                        herdersnotlar.Add((float)0);
                    }
                    else
                    {
                        herdersnotlar.Add(float.Parse(dr1[12].ToString()));
                    }
                }
                notlarislemload();

                if (!string.IsNullOrEmpty(dr1[13].ToString()))
                {
                    txtDin1Not.Text = dr1[13].ToString();
                    if (dr1[13].ToString().ToUpper() == "K" || dr1[13].ToString().ToUpper() == "G")
                    {
                        herdersnotlar.Add((float)0);
                    }
                    else
                    {
                        herdersnotlar.Add(float.Parse(dr1[13].ToString()));
                    }
                }
                if (!string.IsNullOrEmpty(dr1[14].ToString()))
                {
                    txtDin2Not.Text = dr1[14].ToString();
                    if (dr1[14].ToString().ToUpper() == "K" || dr1[14].ToString().ToUpper() == "G")
                    {
                        herdersnotlar.Add((float)0);
                    }
                    else
                    {
                        herdersnotlar.Add(float.Parse(dr1[14].ToString()));
                    }
                }
                if (!string.IsNullOrEmpty(dr1[15].ToString()))
                {
                    txtDin1Sozlu.Text = dr1[15].ToString();
                    if (dr1[15].ToString().ToUpper() == "K" || dr1[15].ToString().ToUpper() == "G")
                    {
                        herdersnotlar.Add((float)0);
                    }
                    else
                    {
                        herdersnotlar.Add(float.Parse(dr1[15].ToString()));
                    }
                }
                if (!string.IsNullOrEmpty(dr1[16].ToString()))
                {
                    txtDin2Sozlu.Text = dr1[16].ToString();
                    if (dr1[16].ToString().ToUpper() == "K" || dr1[16].ToString().ToUpper() == "G")
                    {
                        herdersnotlar.Add((float)0);
                    }
                    else
                    {
                        herdersnotlar.Add(float.Parse(dr1[16].ToString()));
                    }
                }
                notlarislemload();
                if (!string.IsNullOrEmpty(dr1[17].ToString()))
                {
                    txtİng1Not.Text = dr1[17].ToString();
                    if (dr1[17].ToString().ToUpper() == "K" || dr1[17].ToString().ToUpper() == "G")
                    {
                        herdersnotlar.Add((float)0);
                    }
                    else
                    {
                        herdersnotlar.Add(float.Parse(dr1[17].ToString()));
                    }
                }
                if (!string.IsNullOrEmpty(dr1[18].ToString()))
                {
                    txtİng2Not.Text = dr1[18].ToString();
                    if (dr1[18].ToString().ToUpper() == "K" || dr1[18].ToString().ToUpper() == "G")
                    {
                        herdersnotlar.Add((float)0);
                    }
                    else
                    {
                        herdersnotlar.Add(float.Parse(dr1[18].ToString()));
                    }
                }
                if (!string.IsNullOrEmpty(dr1[19].ToString()))
                {
                    txtİng1Sozlu.Text = dr1[19].ToString();
                    if (dr1[19].ToString().ToUpper() == "K" || dr1[19].ToString().ToUpper() == "G")
                    {
                        herdersnotlar.Add((float)0);
                    }
                    else
                    {
                        herdersnotlar.Add(float.Parse(dr1[19].ToString()));
                    }
                }
                if (!string.IsNullOrEmpty(dr1[20].ToString()))
                {
                    txtİng2Sozlu.Text = dr1[20].ToString();
                    if (dr1[20].ToString().ToUpper() == "K" || dr1[20].ToString().ToUpper() == "G")
                    {
                        herdersnotlar.Add((float)0);
                    }
                    else
                    {
                        herdersnotlar.Add(float.Parse(dr1[20].ToString()));
                    }
                }
                notlarislemload();
                if (!string.IsNullOrEmpty(dr1[21].ToString()))
                {
                    txtFelsefe1Not.Text = dr1[21].ToString();
                    if (dr1[21].ToString().ToUpper() == "K" || dr1[21].ToString().ToUpper() == "G")
                    {
                        herdersnotlar.Add((float)0);
                    }
                    else
                    {
                        herdersnotlar.Add(float.Parse(dr1[21].ToString()));
                    }
                }
                if (!string.IsNullOrEmpty(dr1[22].ToString()))
                {
                    txtFelsefe2Not.Text = dr1[22].ToString();
                    if (dr1[22].ToString().ToUpper() == "K" || dr1[22].ToString().ToUpper() == "G")
                    {
                        herdersnotlar.Add((float)0);
                    }
                    else
                    {
                        herdersnotlar.Add(float.Parse(dr1[22].ToString()));
                    }
                }
                if (!string.IsNullOrEmpty(dr1[23].ToString()))
                {
                    txtFelsefe1Sozlu.Text = dr1[23].ToString();
                    if (dr1[23].ToString().ToUpper() == "K" || dr1[23].ToString().ToUpper() == "G")
                    {
                        herdersnotlar.Add((float)0);
                    }
                    else
                    {
                        herdersnotlar.Add(float.Parse(dr1[23].ToString()));
                    }
                }
                if (!string.IsNullOrEmpty(dr1[24].ToString()))
                {
                    txtFelsefe2Sozlu.Text = dr1[24].ToString();
                    if (dr1[24].ToString().ToUpper() == "K" || dr1[24].ToString().ToUpper() == "G")
                    {
                        herdersnotlar.Add((float)0);
                    }
                    else
                    {
                        herdersnotlar.Add(float.Parse(dr1[24].ToString()));
                    }
                }
                notlarislemload();
                if (!string.IsNullOrEmpty(dr1[25].ToString()))
                {
                    txtMat1Not.Text = dr1[25].ToString();
                    if (dr1[25].ToString().ToUpper() == "K" || dr1[25].ToString().ToUpper() == "G")
                    {
                        herdersnotlar.Add((float)0);
                    }
                    else
                    {
                        herdersnotlar.Add(float.Parse(dr1[25].ToString()));
                    }
                }
                if (!string.IsNullOrEmpty(dr1[26].ToString()))
                {
                    txtMat2Not.Text = dr1[26].ToString();
                    if (dr1[26].ToString().ToUpper() == "K" || dr1[26].ToString().ToUpper() == "G")
                    {
                        herdersnotlar.Add((float)0);
                    }
                    else
                    {
                        herdersnotlar.Add(float.Parse(dr1[26].ToString()));
                    }
                }
                if (!string.IsNullOrEmpty(dr1[27].ToString()))
                {
                    txtMat1Sozlu.Text = dr1[27].ToString();
                    if (dr1[27].ToString().ToUpper() == "K" || dr1[27].ToString().ToUpper() == "G")
                    {
                        herdersnotlar.Add((float)0);
                    }
                    else
                    {
                        herdersnotlar.Add(float.Parse(dr1[27].ToString()));
                    }
                }
                if (!string.IsNullOrEmpty(dr1[28].ToString()))
                {
                    txtMat2Sozlu.Text = dr1[28].ToString();
                    if (dr1[28].ToString().ToUpper() == "K" || dr1[28].ToString().ToUpper() == "G")
                    {
                        herdersnotlar.Add((float)0);
                    }
                    else
                    {
                        herdersnotlar.Add(float.Parse(dr1[28].ToString()));
                    }
                }
                notlarislemload();
                if (!string.IsNullOrEmpty(dr1[29].ToString()))
                {
                    txtBiyoloji1Not.Text = dr1[29].ToString();
                    if (dr1[29].ToString().ToUpper() == "K" || dr1[29].ToString().ToUpper() == "G")
                    {
                        herdersnotlar.Add((float)0);
                    }
                    else
                    {
                        herdersnotlar.Add(float.Parse(dr1[29].ToString()));
                    }
                }
                if (!string.IsNullOrEmpty(dr1[30].ToString()))
                {
                    txtBiyoloji2Not.Text = dr1[30].ToString();
                    if (dr1[30].ToString().ToUpper() == "K" || dr1[30].ToString().ToUpper() == "G")
                    {
                        herdersnotlar.Add((float)0);
                    }
                    else
                    {
                        herdersnotlar.Add(float.Parse(dr1[30].ToString()));
                    }
                }
                if (!string.IsNullOrEmpty(dr1[31].ToString()))
                {
                    txtBiyoloji1Sozlu.Text = dr1[31].ToString();
                    if (dr1[31].ToString().ToUpper() == "K" || dr1[31].ToString().ToUpper() == "G")
                    {
                        herdersnotlar.Add((float)0);
                    }
                    else
                    {
                        herdersnotlar.Add(float.Parse(dr1[31].ToString()));
                    }
                }
                if (!string.IsNullOrEmpty(dr1[32].ToString()))
                {
                    txtBiyoloji2Sozlu.Text = dr1[32].ToString();
                    if (dr1[32].ToString().ToUpper() == "K" || dr1[32].ToString().ToUpper() == "G")
                    {
                        herdersnotlar.Add((float)0);
                    }
                    else
                    {
                        herdersnotlar.Add(float.Parse(dr1[32].ToString()));
                    }
                }
                notlarislemload();
                if (!string.IsNullOrEmpty(dr1[33].ToString()))
                {
                    txtFizik1Not.Text = dr1[33].ToString();
                    if (dr1[33].ToString().ToUpper() == "K" || dr1[33].ToString().ToUpper() == "G")
                    {
                        herdersnotlar.Add((float)0);
                    }
                    else
                    {
                        herdersnotlar.Add(float.Parse(dr1[33].ToString()));
                    }
                }
                if (!string.IsNullOrEmpty(dr1[34].ToString()))
                {
                    txtFizik2Not.Text = dr1[34].ToString();
                    if (dr1[34].ToString().ToUpper() == "K" || dr1[34].ToString().ToUpper() == "G")
                    {
                        herdersnotlar.Add((float)0);
                    }
                    else
                    {
                        herdersnotlar.Add(float.Parse(dr1[34].ToString()));
                    }
                }
                if (!string.IsNullOrEmpty(dr1[35].ToString()))
                {
                    txtFizik1Sozlu.Text = dr1[35].ToString();
                    if (dr1[35].ToString().ToUpper() == "K" || dr1[35].ToString().ToUpper() == "G")
                    {
                        herdersnotlar.Add((float)0);
                    }
                    else
                    {
                        herdersnotlar.Add(float.Parse(dr1[35].ToString()));
                    }
                }
                if (!string.IsNullOrEmpty(dr1[36].ToString()))
                {
                    txtFizik2Sozlu.Text = dr1[36].ToString();
                    if (dr1[36].ToString().ToUpper() == "K" || dr1[36].ToString().ToUpper() == "G")
                    {
                        herdersnotlar.Add((float)0);
                    }
                    else
                    {
                        herdersnotlar.Add(float.Parse(dr1[36].ToString()));
                    }
                }
                notlarislemload();
                if (!string.IsNullOrEmpty(dr1[37].ToString()))
                {
                    txtKimya1Not.Text = dr1[37].ToString();
                    if (dr1[37].ToString().ToUpper() == "K" || dr1[37].ToString().ToUpper() == "G")
                    {
                        herdersnotlar.Add((float)0);
                    }
                    else
                    {
                        herdersnotlar.Add(float.Parse(dr1[37].ToString()));
                    }
                }
                if (!string.IsNullOrEmpty(dr1[38].ToString()))
                {
                    txtKimya2Not.Text = dr1[38].ToString();
                    if (dr1[38].ToString().ToUpper() == "K" || dr1[38].ToString().ToUpper() == "G")
                    {
                        herdersnotlar.Add((float)0);
                    }
                    else
                    {
                        herdersnotlar.Add(float.Parse(dr1[38].ToString()));
                    }
                }
                if (!string.IsNullOrEmpty(dr1[39].ToString()))
                {
                    txtKimya1Sozlu.Text = dr1[39].ToString();
                    if (dr1[39].ToString().ToUpper() == "K" || dr1[39].ToString().ToUpper() == "G")
                    {
                        herdersnotlar.Add((float)0);
                    }
                    else
                    {
                        herdersnotlar.Add(float.Parse(dr1[39].ToString()));
                    }
                }
                if (!string.IsNullOrEmpty(dr1[40].ToString()))
                {
                    txtKimya2Sozlu.Text = dr1[40].ToString();
                    if (dr1[40].ToString().ToUpper() == "K" || dr1[40].ToString().ToUpper() == "G")
                    {
                        herdersnotlar.Add((float)0);
                    }
                    else
                    {
                        herdersnotlar.Add(float.Parse(dr1[40].ToString()));
                    }
                }
                notlarislemload();
                if (!string.IsNullOrEmpty(dr1[41].ToString()))
                {
                    txtBeden1Not.Text = dr1[41].ToString();
                    if (dr1[41].ToString().ToUpper() == "K" || dr1[41].ToString().ToUpper() == "G")
                    {
                        herdersnotlar.Add((float)0);
                    }
                    else
                    {
                        herdersnotlar.Add(float.Parse(dr1[41].ToString()));
                    }
                }
                if (!string.IsNullOrEmpty(dr1[42].ToString()))
                {
                    txtBeden2Not.Text = dr1[42].ToString();
                    if (dr1[42].ToString().ToUpper() == "K" || dr1[42].ToString().ToUpper() == "G")
                    {
                        herdersnotlar.Add((float)0);
                    }
                    else
                    {
                        herdersnotlar.Add(float.Parse(dr1[42].ToString()));
                    }
                }
                if (!string.IsNullOrEmpty(dr1[43].ToString()))
                {
                    txtBeden1Sozlu.Text = dr1[43].ToString();
                    if (dr1[43].ToString().ToUpper() == "K" || dr1[43].ToString().ToUpper() == "G")
                    {
                        herdersnotlar.Add((float)0);
                    }
                    else
                    {
                        herdersnotlar.Add(float.Parse(dr1[43].ToString()));
                    }
                }
                if (!string.IsNullOrEmpty(dr1[44].ToString()))
                {
                    txtBeden2Sozlu.Text = dr1[44].ToString();
                    if (dr1[44].ToString().ToUpper() == "K" || dr1[44].ToString().ToUpper() == "G")
                    {
                        herdersnotlar.Add((float)0);
                    }
                    else
                    {
                        herdersnotlar.Add(float.Parse(dr1[44].ToString()));
                    }
                }
                notlarislemload();
            }
            baglanti.Close();
            for (int i = 0; i < dersortalama.Count; i++)
            {
                Label lbl = this.Controls.Find("lblDersPuan" + i, true) [0]as Label;
                if (string.IsNullOrEmpty(dersortalama[i].ToString()))
                    lbl.Text = "Puanı: ---";
                else 
                    lbl.Text = "Puanı: " + dersortalama[i];
            }
            int[] diziderssaati;
            if(ogrenci_sinif > 9)
            {
                diziderssaati = new int[11];
                diziderssaati[0] = 2;
                diziderssaati[1] = 5;
                diziderssaati[2] = 2;
                diziderssaati[3] = 2;
                diziderssaati[4] = 4;
                diziderssaati[5] = 2;
                diziderssaati[6] = 5;
                diziderssaati[7] = 2;
                diziderssaati[8] = 2;
                diziderssaati[9] = 2;
                diziderssaati[10] = 2;
            }
            else
            {
                diziderssaati = new int[10];
                diziderssaati[0] = 2;
                diziderssaati[1] = 5;
                diziderssaati[2] = 2;
                diziderssaati[3] = 2;
                diziderssaati[4] = 4;
                diziderssaati[5] = 5;
                diziderssaati[6] = 2;
                diziderssaati[7] = 2;
                diziderssaati[8] = 2;
                diziderssaati[9] = 2;
            }
            float ort = 0;
            int sayaccik=0,toplambolum=0;
            bool boluneceksayi = false;
            string ortalamametin = "";
            foreach (string j in dersortalama)
            {
                if (j != "")
                {
                    ort += float.Parse(j)*diziderssaati[sayaccik];
                    boluneceksayi=true;
                    toplambolum += diziderssaati[sayaccik];
                }
                sayaccik++;
            }
            if (!boluneceksayi)
            {
                ortalamametin = "---";
            }
            else
            {
                ort = ort / toplambolum;
                ortalamametin = ort.ToString();
            }
            
            lbldonemOrtalama.Text = ortalamametin;
            string derssinir = "";
            baglanti.Open();
            SqlCommand komutders = new SqlCommand("select Ogretmen_ders from Tbl_Ogretmen where Ogretmen_id = @p1", baglanti);
            komutders.Parameters.AddWithValue("@p1", ogretmen_id);
            SqlDataReader reader = komutders.ExecuteReader();
            if (reader.Read())
            {
                derssinir = reader[0].ToString();
            }
            baglanti.Close();
            switch (derssinir)
            {
                case "Coğrafya":
                    txtCografya1Not.Enabled = true;
                    txtCografya2Not.Enabled = true;
                    txtCografya1Sozlu.Enabled = true;
                    txtCografya2Sozlu.Enabled = true;
                    break;
                case "Türkçe":
                    txtTurkce1Not.Enabled = true;
                    txtTurkce2Not.Enabled = true;
                    txtTurkce1Sozlu.Enabled = true;
                    txtTurkce2Sozlu.Enabled = true;
                    break;
                case "Tarih":
                    txtTarih1Not.Enabled = true;
                    txtTarih2Not.Enabled = true;
                    txtTarih1Sozlu.Enabled = true;
                    txtTarih2Sozlu.Enabled = true;
                    break;
                case "Din":
                    txtDin1Not.Enabled = true;
                    txtDin2Not.Enabled = true;
                    txtDin1Sozlu.Enabled = true;
                    txtDin2Sozlu.Enabled = true;
                    break;
                case "İngilizce":
                    txtİng1Not.Enabled = true;
                    txtİng2Not.Enabled = true;
                    txtİng1Sozlu.Enabled = true;
                    txtİng2Sozlu.Enabled = true;
                    break;
                case "Felsefe":
                    txtFelsefe1Not.Enabled = true;
                    txtFelsefe2Not.Enabled = true;
                    txtFelsefe1Sozlu.Enabled = true;
                    txtFelsefe2Sozlu.Enabled = true;
                    break;
                case "Matematik":
                    txtMat1Not.Enabled = true;
                    txtMat2Not.Enabled = true;
                    txtMat1Sozlu.Enabled = true;
                    txtMat2Sozlu.Enabled = true;
                    break;
                case "Biyoloji":
                    txtBiyoloji1Not.Enabled = true;
                    txtBiyoloji2Not.Enabled = true;
                    txtBiyoloji1Sozlu.Enabled = true;
                    txtBiyoloji2Sozlu.Enabled = true;
                    break;
                case "Fizik":
                    txtFizik1Not.Enabled = true;
                    txtFizik2Not.Enabled = true;
                    txtFizik1Sozlu.Enabled = true;
                    txtFizik2Sozlu.Enabled = true;
                    break;
                case "Kimya":
                    txtKimya1Not.Enabled = true;
                    txtKimya2Not.Enabled = true;
                    txtKimya1Sozlu.Enabled = true;
                    txtKimya2Sozlu.Enabled = true;
                    break;
                case "Beden":
                    txtBeden1Not.Enabled = true;
                    txtBeden2Not.Enabled = true;
                    txtBeden1Sozlu.Enabled = true;
                    txtBeden2Sozlu.Enabled = true;
                    break;
            }
        }
        private void FrmOgretmenNotGiris_Load(object sender, EventArgs e)
        {
            lblAdSoyad.Text = ogrenci_ad + " " + ogrenci_soyad;
            lblNumara.Text = ogrenci_numara.ToString();
            lblSinifSube.Text = ogrenci_sinif + "/" + ogrenci_sube + " " + ogrenci_bolum;
            islemload();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool sartlardogrumu = true;
            string c1 = "", c2 = "", cs1 = "", cs2 = "", tu1 = "", tu2 = "", tus1 = "", tus2 = "", ta1 = "", ta2 = "", tas1 = "", tas2 = "", d1 = "", d2 = "", ds1 = "", ds2 = "", i1 = "", i2 = "", is1 = "", is2 = "", fe1 = "", fe2 = "", fes1 = "", fes2 = "",mat1="", mat2 = "", mats1 = "", mats2 = "", bi1 = "", bi2 = "", bis1 = "", bis2 = "",fi1="", fi2 = "", fis1 = "", fis2 = "", ki1 = "", ki2 = "", kis1 = "", kis2 = "", bed1 = "", bed2 = "", beds1 = "", beds2 = "";
            
            if (txtCografya1Not.Text != "")
            {
                if(txtCografya1Not.Text.ToUpper() == "G" || txtCografya1Not.Text.ToUpper() == "K" || int.TryParse(txtCografya1Not.Text,out int sad))
                {
                    c1 = txtCografya1Not.Text.ToUpper();
                }
                else if (!string.IsNullOrEmpty(txtCografya1Not.Text))
                {
                    sartlardogrumu = false;
                }
            }
            if (txtCografya2Not.Text != "")
            {
                if (txtCografya2Not.Text.ToUpper() == "G" || txtCografya2Not.Text.ToUpper() == "K" || int.TryParse(txtCografya2Not.Text, out int sad))
                {
                    c2 = txtCografya2Not.Text.ToUpper();
                }
                else if (!string.IsNullOrEmpty(txtCografya2Not.Text))
                {
                    sartlardogrumu = false;
                }
            }
            if (txtCografya1Sozlu.Text != "")
            {
                if (txtCografya1Sozlu.Text.ToUpper() == "G" || txtCografya1Sozlu.Text.ToUpper() == "K" || int.TryParse(txtCografya1Sozlu.Text, out int sad))
                {
                    cs1 = txtCografya1Sozlu.Text.ToUpper();
                }
                else if (!string.IsNullOrEmpty(txtCografya1Sozlu.Text))
                {
                    sartlardogrumu = false;
                }
            }
            if (txtCografya2Sozlu.Text != "")
            {
                if (txtCografya2Sozlu.Text.ToUpper() == "G" || txtCografya2Not.Text.ToUpper() == "K" || int.TryParse(txtCografya2Not.Text, out int sad))
                {
                    cs2 = txtCografya2Sozlu.Text.ToUpper();
                }
                else if (!string.IsNullOrEmpty(txtCografya2Sozlu.Text))
                {
                    sartlardogrumu = false;
                }
            }
            if (txtTurkce1Not.Text != "")
            {
                if (txtTurkce1Not.Text.ToUpper() == "G" || txtTurkce1Not.Text.ToUpper() == "K" || int.TryParse(txtTurkce1Not.Text, out int sad))
                {
                    tu1 = txtTurkce1Not.Text.ToUpper();
                }
                else if (!string.IsNullOrEmpty(txtTurkce1Not.Text))
                {
                    sartlardogrumu = false;
                }
            }
            if (txtTurkce2Not.Text != "")
            {
                if (txtTurkce2Not.Text.ToUpper() == "G" || txtTurkce2Not.Text.ToUpper() == "K" || int.TryParse(txtTurkce2Not.Text, out int sad))
                {
                    tu2 = txtTurkce2Not.Text.ToUpper();
                }
                else if (!string.IsNullOrEmpty(txtTurkce2Not.Text))
                {
                    sartlardogrumu = false;
                }
            }
            if (txtTurkce1Sozlu.Text != "")
            {
                if (txtTurkce1Sozlu.Text.ToUpper() == "G" || txtTurkce1Sozlu.Text.ToUpper() == "K" || int.TryParse(txtTurkce1Sozlu.Text, out int sad))
                {
                    tus1 = txtTurkce1Sozlu.Text.ToUpper();
                }
                else if (!string.IsNullOrEmpty(txtTurkce1Sozlu.Text))
                {
                    sartlardogrumu = false;
                }
            }
            if (txtTurkce2Sozlu.Text != "")
            {
                if (txtTurkce2Sozlu.Text.ToUpper() == "G" || txtTurkce2Sozlu.Text.ToUpper() == "K" || int.TryParse(txtTurkce2Sozlu.Text, out int sad))
                {
                    tus2 = txtTurkce2Sozlu.Text.ToUpper();
                }
                else if (!string.IsNullOrEmpty(txtTurkce2Sozlu.Text))
                {
                    sartlardogrumu = false;
                }
            }
            if (txtTarih1Not.Text != "")
            {
                if (txtTarih1Not.Text.ToUpper() == "G" || txtTarih1Not.Text.ToUpper() == "K" || int.TryParse(txtTarih1Not.Text, out int sad))
                {
                    ta1 = txtTarih1Not.Text.ToUpper();
                }
                else if (!string.IsNullOrEmpty(txtTarih1Not.Text))
                {
                    sartlardogrumu = false;
                }
            }
            if (txtTarih2Not.Text != "")
            {
                if (txtTarih2Not.Text.ToUpper() == "G" || txtTarih2Not.Text.ToUpper() == "K" || int.TryParse(txtTarih2Not.Text, out int sad))
                {
                    ta2 = txtTarih2Not.Text.ToUpper();
                }
                else if (!string.IsNullOrEmpty(txtTarih2Not.Text))
                {
                    sartlardogrumu = false;
                }
            }
            if (txtTarih1Sozlu.Text != "")
            {
                if (txtTarih1Sozlu.Text.ToUpper() == "G" || txtTarih1Sozlu.Text.ToUpper() == "K" || int.TryParse(txtTarih1Sozlu.Text, out int sad))
                {
                    tas1 = txtTarih1Sozlu.Text.ToUpper();
                }
                else if (!string.IsNullOrEmpty(txtTarih1Sozlu.Text))
                {
                    sartlardogrumu = false;
                }
            }
            if (txtTarih2Sozlu.Text != "")
            {
                if (txtTarih2Sozlu.Text.ToUpper() == "G" || txtTarih2Sozlu.Text.ToUpper() == "K" || int.TryParse(txtTarih2Sozlu.Text, out int sad))
                {
                    tas2 = txtTarih2Sozlu.Text.ToUpper();
                }
                else if (!string.IsNullOrEmpty(txtTarih2Sozlu.Text))
                {
                    sartlardogrumu = false;
                }
            }
            if (txtDin1Not.Text != "")
            {
                if (txtDin1Not.Text.ToUpper() == "G" || txtDin1Not.Text.ToUpper() == "K" || int.TryParse(txtDin1Not.Text, out int sad))
                {
                    d1 = txtDin1Not.Text.ToUpper();
                }
                else if (!string.IsNullOrEmpty(txtDin1Not.Text))
                {
                    sartlardogrumu = false;
                }
            }
            if (txtDin2Not.Text != "")
            {
                if (txtDin2Not.Text.ToUpper() == "G" || txtDin2Not.Text.ToUpper() == "K" || int.TryParse(txtDin2Not.Text, out int sad))
                {
                    d2 = txtDin2Not.Text.ToUpper();
                }
                else if (!string.IsNullOrEmpty(txtDin2Not.Text))
                {
                    sartlardogrumu = false;
                }
            }
            if (txtDin1Sozlu.Text != "")
            {
                if (txtDin1Sozlu.Text.ToUpper() == "G" || txtDin1Sozlu.Text.ToUpper() == "K" || int.TryParse(txtDin1Sozlu.Text, out int sad))
                {
                    ds1 = txtDin1Sozlu.Text.ToUpper();
                }
                else if (!string.IsNullOrEmpty(txtDin1Sozlu.Text))
                {
                    sartlardogrumu = false;
                }
            }
            if (txtDin2Sozlu.Text != "")
            {
                if (txtDin2Sozlu.Text.ToUpper() == "G" || txtDin2Sozlu.Text.ToUpper() == "K" || int.TryParse(txtDin2Sozlu.Text, out int sad))
                {
                    ds2 = txtDin2Sozlu.Text.ToUpper();
                }
                else if (!string.IsNullOrEmpty(txtDin2Sozlu.Text))
                {
                    sartlardogrumu = false;
                }
            }
            if (txtİng1Not.Text != "")
            {
                if (txtİng1Not.Text.ToUpper() == "G" || txtİng1Not.Text.ToUpper() == "K" || int.TryParse(txtİng1Not.Text, out int sad))
                {
                    i1 = txtİng1Not.Text.ToUpper();
                }
                else if (!string.IsNullOrEmpty(txtİng1Not.Text))
                {
                    sartlardogrumu = false;
                }
            }
            if (txtİng2Not.Text != "")
            {
                if (txtİng2Not.Text.ToUpper() == "G" || txtİng2Not.Text.ToUpper() == "K" || int.TryParse(txtİng2Not.Text, out int sad))
                {
                    i2 = txtİng2Not.Text.ToUpper();
                }
                else if (!string.IsNullOrEmpty(txtİng2Not.Text))
                {
                    sartlardogrumu = false;
                }
            }
            if (txtİng1Sozlu.Text != "")
            {
                if (txtİng1Sozlu.Text.ToUpper() == "G" || txtİng1Sozlu.Text.ToUpper() == "K" || int.TryParse(txtİng1Sozlu.Text, out int sad))
                {
                    is1 = txtİng1Sozlu.Text.ToUpper();
                }
                else if (!string.IsNullOrEmpty(txtİng1Sozlu.Text))
                {
                    sartlardogrumu = false;
                }
            }
            if (txtİng2Sozlu.Text != "")
            {
                if (txtİng2Sozlu.Text.ToUpper() == "G" || txtİng2Sozlu.Text.ToUpper() == "K" || int.TryParse(txtİng2Sozlu.Text, out int sad))
                {
                    is2 = txtİng2Sozlu.Text.ToUpper();
                }
                else if (!string.IsNullOrEmpty(txtİng2Sozlu.Text))
                {
                    sartlardogrumu = false;
                }
            }
            if (txtFelsefe1Not.Text != "")
            {
                if (txtFelsefe1Not.Text.ToUpper() == "G" || txtFelsefe1Not.Text.ToUpper() == "K" || int.TryParse(txtFelsefe1Not.Text, out int sad))
                {
                    fe1 = txtFelsefe1Not.Text.ToUpper();
                }
                else if (!string.IsNullOrEmpty(txtFelsefe1Not.Text))
                {
                    sartlardogrumu = false;
                }
            }
            if (txtFelsefe2Not.Text != "")
            {
                if (txtFelsefe2Not.Text.ToUpper() == "G" || txtFelsefe2Not.Text.ToUpper() == "K" || int.TryParse(txtFelsefe2Not.Text, out int sad))
                {
                    fe2 = txtFelsefe2Not.Text.ToUpper();
                }
                else if (!string.IsNullOrEmpty(txtFelsefe2Not.Text))
                {
                    sartlardogrumu = false;
                }
            }
            if (txtFelsefe1Sozlu.Text != "")
            {
                if (txtFelsefe1Sozlu.Text.ToUpper() == "G" || txtFelsefe1Sozlu.Text.ToUpper() == "K" || int.TryParse(txtFelsefe1Sozlu.Text, out int sad))
                {
                    fes1 = txtFelsefe1Sozlu.Text.ToUpper();
                }
                else if (!string.IsNullOrEmpty(txtFelsefe1Sozlu.Text))
                {
                    sartlardogrumu = false;
                }
            }
            if (txtFelsefe2Sozlu.Text != "")
            {
                if (txtFelsefe2Sozlu.Text.ToUpper() == "G" || txtFelsefe2Sozlu.Text.ToUpper() == "K" || int.TryParse(txtFelsefe2Sozlu.Text, out int sad))
                {
                    fes2 = txtFelsefe2Sozlu.Text.ToUpper();
                }
                else if (!string.IsNullOrEmpty(txtFelsefe2Sozlu.Text))
                {
                    sartlardogrumu = false;
                }
            }
            if (txtMat1Not.Text != "")
            {
                if (txtMat1Not.Text.ToUpper() == "G" || txtMat1Not.Text.ToUpper() == "K" || int.TryParse(txtMat1Not.Text, out int sad))
                {
                    mat1 = txtMat1Not.Text.ToUpper();
                }
                else if (!string.IsNullOrEmpty(txtMat1Not.Text))
                {
                    sartlardogrumu = false;
                }
            }
            if (txtMat2Not.Text != "")
            {
                if (txtMat2Not.Text.ToUpper() == "G" || txtMat2Not.Text.ToUpper() == "K" || int.TryParse(txtMat2Not.Text, out int sad))
                {
                    mat2 = txtMat2Not.Text.ToUpper();
                }
                else if (!string.IsNullOrEmpty(txtMat2Not.Text))
                {
                    sartlardogrumu = false;
                }
            }
            if (txtMat1Sozlu.Text != "")
            {
                if (txtMat1Sozlu.Text.ToUpper() == "G" || txtMat1Sozlu.Text.ToUpper() == "K" || int.TryParse(txtMat1Sozlu.Text, out int sad))
                {
                    mats1 = txtMat1Sozlu.Text.ToUpper();
                }
                else if (!string.IsNullOrEmpty(txtMat1Sozlu.Text))
                {
                    sartlardogrumu = false;
                }
            }
            if (txtMat2Sozlu.Text != "")
            {
                if (txtMat2Sozlu.Text.ToUpper() == "G" || txtMat2Sozlu.Text.ToUpper() == "K" || int.TryParse(txtMat2Sozlu.Text, out int sad))
                {
                    mats2 = txtMat2Sozlu.Text.ToUpper();
                }
                else if (!string.IsNullOrEmpty(txtMat2Sozlu.Text))
                {
                    sartlardogrumu = false;
                }
            }
            if (txtBiyoloji1Not.Text != "")
            {
                if (txtBiyoloji1Not.Text.ToUpper() == "G" || txtBiyoloji1Not.Text.ToUpper() == "K" || int.TryParse(txtBiyoloji1Not.Text, out int sad))
                {
                    bi1 = txtBiyoloji1Not.Text.ToUpper();
                }
                else if (!string.IsNullOrEmpty(txtBiyoloji1Not.Text))
                {
                    sartlardogrumu = false;
                }
            }
            if (txtBiyoloji2Not.Text != "")
            {
                if (txtBiyoloji2Not.Text.ToUpper() == "G" || txtBiyoloji2Not.Text.ToUpper() == "K" || int.TryParse(txtBiyoloji2Not.Text, out int sad))
                {
                    bi2 = txtBiyoloji2Not.Text.ToUpper();
                }
                else if (!string.IsNullOrEmpty(txtBiyoloji2Not.Text))
                {
                    sartlardogrumu = false;
                }
            }
            if (txtBiyoloji1Sozlu.Text != "")
            {
                if (txtBiyoloji1Sozlu.Text.ToUpper() == "G" || txtBiyoloji1Sozlu.Text.ToUpper() == "K" || int.TryParse(txtBiyoloji1Sozlu.Text, out int sad))
                {
                    bis1 = txtBiyoloji1Sozlu.Text.ToUpper();
                }
                else if (!string.IsNullOrEmpty(txtBiyoloji1Sozlu.Text))
                {
                    sartlardogrumu = false;
                }
            }
            if (txtBiyoloji2Sozlu.Text != "")
            {
                if (txtBiyoloji2Sozlu.Text.ToUpper() == "G" || txtBiyoloji2Sozlu.Text.ToUpper() == "K" || int.TryParse(txtBiyoloji2Sozlu.Text, out int sad))
                {
                    bis2 = txtBiyoloji2Sozlu.Text.ToUpper();
                }
                else if (!string.IsNullOrEmpty(txtBiyoloji2Sozlu.Text))
                {
                    sartlardogrumu = false;
                }
            }
            if (txtFizik1Not.Text != "")
            {
                if (txtFizik1Not.Text.ToUpper() == "G" || txtFizik1Not.Text.ToUpper() == "K" || int.TryParse(txtFizik1Not.Text, out int sad))
                {
                    fi1 = txtFizik1Not.Text.ToUpper();
                }
                else if (!string.IsNullOrEmpty(txtFizik1Not.Text))
                {
                    sartlardogrumu = false;
                }
            }
            if (txtFizik2Not.Text != "")
            {
                if (txtFizik2Not.Text.ToUpper() == "G" || txtFizik2Not.Text.ToUpper() == "K" || int.TryParse(txtFizik2Not.Text, out int sad))
                {
                    fi2 = txtFizik2Not.Text.ToUpper();
                }
                else if (!string.IsNullOrEmpty(txtFizik2Not.Text))
                {
                    sartlardogrumu = false;
                }
            }
            if (txtFizik1Sozlu.Text != "")
            {
                if (txtFizik1Sozlu.Text.ToUpper() == "G" || txtFizik1Sozlu.Text.ToUpper() == "K" || int.TryParse(txtFizik1Sozlu.Text, out int sad))
                {
                    fis1 = txtFizik1Sozlu.Text.ToUpper();
                }
                else if (!string.IsNullOrEmpty(txtFizik1Sozlu.Text))
                {
                    sartlardogrumu = false;
                }
            }
            if (txtFizik2Sozlu.Text != "")
            {
                if (txtFizik2Sozlu.Text.ToUpper() == "G" || txtFizik2Sozlu.Text.ToUpper() == "K" || int.TryParse(txtFizik2Sozlu.Text, out int sad))
                {
                    fis2 = txtFizik2Sozlu.Text.ToUpper();
                }
                else if (!string.IsNullOrEmpty(txtFizik2Sozlu.Text))
                {
                    sartlardogrumu = false;
                }
            }
            if (txtKimya1Not.Text != "")
            {
                if (txtKimya1Not.Text.ToUpper() == "G" || txtKimya1Not.Text.ToUpper() == "K" || int.TryParse(txtKimya1Not.Text, out int sad))
                {
                    ki1 = txtKimya1Not.Text.ToUpper();
                }
                else if (!string.IsNullOrEmpty(txtKimya1Not.Text))
                {
                    sartlardogrumu = false;
                }
            }
            if (txtKimya2Not.Text != "")
            {
                if (txtKimya2Not.Text.ToUpper() == "G" || txtKimya2Not.Text.ToUpper() == "K" || int.TryParse(txtKimya2Not.Text, out int sad))
                {
                    ki2 = txtKimya1Not.Text.ToUpper();
                }
                else if (!string.IsNullOrEmpty(txtKimya2Not.Text))
                {
                    sartlardogrumu = false;
                }
            }
            if (txtKimya1Sozlu.Text != "")
            {
                if (txtKimya1Sozlu.Text.ToUpper() == "G" || txtKimya1Sozlu.Text.ToUpper() == "K" || int.TryParse(txtKimya1Sozlu.Text, out int sad))
                {
                    kis1 = txtKimya1Sozlu.Text.ToUpper();
                }
                else if (!string.IsNullOrEmpty(txtKimya1Sozlu.Text))
                {
                    sartlardogrumu = false;
                }
            }
            if (txtKimya2Sozlu.Text != "")
            {
                if (txtKimya2Sozlu.Text.ToUpper() == "G" || txtKimya2Sozlu.Text.ToUpper() == "K" || int.TryParse(txtKimya2Sozlu.Text, out int sad))
                {
                    kis2 = txtKimya2Sozlu.Text.ToUpper();
                }
                else if (!string.IsNullOrEmpty(txtKimya2Sozlu.Text))
                {
                    sartlardogrumu = false;
                }
            }
            if (txtBeden1Not.Text != "")
            {
                if (txtBeden1Not.Text.ToUpper() == "G" || txtBeden1Not.Text.ToUpper() == "K" || int.TryParse(txtBeden1Not.Text, out int sad))
                {
                    bed1 = txtBeden1Not.Text.ToUpper();
                }
                else if (!string.IsNullOrEmpty(txtBeden1Not.Text))
                {
                    sartlardogrumu = false;
                }
            }
            if (txtBeden2Not.Text != "")
            {
                if (txtBeden2Not.Text.ToUpper() == "G" || txtBeden2Not.Text.ToUpper() == "K" || int.TryParse(txtBeden2Not.Text, out int sad))
                {
                    bed2 = txtBeden2Not.Text.ToUpper();
                }
                else if (!string.IsNullOrEmpty(txtBeden2Not.Text))
                {
                    sartlardogrumu = false;
                }
            }
            if (txtBeden1Sozlu.Text != "")
            {
                if (txtBeden1Sozlu.Text.ToUpper() == "G" || txtBeden1Sozlu.Text.ToUpper() == "K" || int.TryParse(txtBeden1Sozlu.Text, out int sad))
                {
                    beds1 = txtBeden1Sozlu.Text.ToUpper();
                }
                else if (!string.IsNullOrEmpty(txtBeden1Sozlu.Text))
                {
                    sartlardogrumu = false;
                }
            }
            if (txtBeden2Sozlu.Text != "")
            {
                if (txtBeden2Sozlu.Text.ToUpper() == "G" || txtBeden2Sozlu.Text.ToUpper() == "K" || int.TryParse(txtBeden2Sozlu.Text, out int sad))
                {
                    beds2 = txtBeden2Sozlu.Text.ToUpper();
                }
                else if (!string.IsNullOrEmpty(txtBeden2Sozlu.Text))
                {
                    sartlardogrumu = false;
                }
            }

            if (sartlardogrumu == true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update Tbl_Notlar set cografya_birincinot=@p1, coğrafya_ikincinot=@p2, coğrafya_birincisozlu=@p3, coğrafya_ikincisozlu=@p4, turkce_birincinot=@p5, turkce_ikincinot=@p6, turkce_birincisozlu=@p7, turkce_ikincisozlu=@p8, tarih_birincinot=@p9, tarih_ikincinot=@p10, tarih_birincisozlu=@p11, tarih_ikincisozlu=@p12, din_birincinot=@p13, din_ikincinot=@p14, din_birincisozlu=@p15, din_ikincisozlu=@p16, ingilizce_birincinot=@p17, ingilizce_ikincinot=@p18, ingilizce_birincisozlu=@p19, ingilizce_ikincisozlu=@p20, felsefe_birincinot=@p21, felsefe_ikincinot=@p22, felsefe_birincisozlu=@p23, felsefe_ikincisozlu=@p24, matematik_birincinot=@p25, matematik_ikincinot=@p26, matematik_birincisozlu=@p27, matematik_ikincisozlu=@p28, biyoloji_birincinot=@p29, biyoloji_ikincinot=@p30, biyoloji_birincisozlu=@p31, biyoloji_ikincisozlu=@p32, fizik_birincinot=@p33, fizik_ikincinot=@p34, fizik_birincisozlu=@p35, fizik_ikincisozlu=@p36, kimya_birincinot=@p37, kimya_ikincinot=@p38, kimya_birincisozlu=@p39, kimya_ikincisozlu=@p40, beden_birincinot=@p41, beden_ikincinot=@p42, beden_birincisozlu=@p43, beden_ikincisozlu=@p44 where notlar_id = @p45", baglanti);
                komut.Parameters.AddWithValue("@p1", (c1));
                komut.Parameters.AddWithValue("@p2", (c2));
                komut.Parameters.AddWithValue("@p3", (cs1));
                komut.Parameters.AddWithValue("@p4", (cs2));
                komut.Parameters.AddWithValue("@p5", (tu1));
                komut.Parameters.AddWithValue("@p6", (tu2));
                komut.Parameters.AddWithValue("@p7", (tus1));
                komut.Parameters.AddWithValue("@p8", (tus2));
                komut.Parameters.AddWithValue("@p9", (ta1));
                komut.Parameters.AddWithValue("@p10", (ta2));
                komut.Parameters.AddWithValue("@p11", (tas1));
                komut.Parameters.AddWithValue("@p12", (tas2));
                komut.Parameters.AddWithValue("@p13", (d1));
                komut.Parameters.AddWithValue("@p14", (d2));
                komut.Parameters.AddWithValue("@p15", (ds1));
                komut.Parameters.AddWithValue("@p16", (ds2));
                komut.Parameters.AddWithValue("@p17", (i1));
                komut.Parameters.AddWithValue("@p18", (i2));
                komut.Parameters.AddWithValue("@p19", (is1));
                komut.Parameters.AddWithValue("@p20", (is2));
                komut.Parameters.AddWithValue("@p21", (fe1));
                komut.Parameters.AddWithValue("@p22", (fe2));
                komut.Parameters.AddWithValue("@p23", (fes1));
                komut.Parameters.AddWithValue("@p24", (fes2));
                komut.Parameters.AddWithValue("@p25", (mat1));
                komut.Parameters.AddWithValue("@p26", (mat2));
                komut.Parameters.AddWithValue("@p27", (mats1));
                komut.Parameters.AddWithValue("@p28", (mats2));
                komut.Parameters.AddWithValue("@p29", (bi1));
                komut.Parameters.AddWithValue("@p30", (bi2));
                komut.Parameters.AddWithValue("@p31", (bis1));
                komut.Parameters.AddWithValue("@p32", (bis2));
                komut.Parameters.AddWithValue("@p33", (fi1));
                komut.Parameters.AddWithValue("@p34", (fi2));
                komut.Parameters.AddWithValue("@p35", (fis1));
                komut.Parameters.AddWithValue("@p36", (fis2));
                komut.Parameters.AddWithValue("@p37", (ki1));
                komut.Parameters.AddWithValue("@p38", (ki2));
                komut.Parameters.AddWithValue("@p39", (kis1));
                komut.Parameters.AddWithValue("@p40", (kis2));
                komut.Parameters.AddWithValue("@p41", (bed1));
                komut.Parameters.AddWithValue("@p42", (bed2));
                komut.Parameters.AddWithValue("@p43", (beds1));
                komut.Parameters.AddWithValue("@p44", (beds2));
                komut.Parameters.AddWithValue("@p45", ogrenci_id);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Notlar Güncellenilmiştir!", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                islemload();
            }
            else
            {
                MessageBox.Show("Hata!","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox10_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
