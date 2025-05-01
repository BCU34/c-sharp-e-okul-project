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
    public partial class FrmOgretmenİslemler : Form
    {
        public FrmOgretmenİslemler()
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
        ArrayList ogrenciİD = new ArrayList();
        void notgiris()
        {
            FrmOgretmenNotGiris notgiris = new FrmOgretmenNotGiris();
            int indeks = dataOgrenciler.SelectedCells[0].RowIndex;
            baglanti.Open();
            SqlCommand komutsiralama1 = new SqlCommand("select * from Tbl_Ogrenci where ogrenci_id = @p1", baglanti);
            komutsiralama1.Parameters.AddWithValue("@p1", int.Parse(ogrenciİD[indeks].ToString()));
            SqlDataReader drsiralama1 = komutsiralama1.ExecuteReader();
            if (drsiralama1.Read())
            {
                notgiris.ogrenci_id = int.Parse(drsiralama1[0].ToString());
                notgiris.ogrenci_ad = drsiralama1[1].ToString();
                notgiris.ogrenci_soyad = drsiralama1[2].ToString();
                notgiris.ogrenci_sinif = int.Parse(drsiralama1[7].ToString());
                notgiris.ogrenci_sube = drsiralama1[8].ToString();
                notgiris.ogrenci_bolum = drsiralama1[9].ToString();
                notgiris.ogrenci_alan = drsiralama1[10].ToString();
                notgiris.ogrenci_numara = int.Parse(drsiralama1[11].ToString());
                notgiris.ogrenci_dersnotlariID = int.Parse(drsiralama1[14].ToString());
                notgiris.ogretmen_ders = ogretmenders;
                notgiris.ogretmen_id = ogretmenid;
                notgiris.ShowDialog();
            }
            baglanti.Close();
        }
        void profilfotokoyma()
        {
            bool d = true;
            baglanti.Open();
            try
            {
                
                SqlCommand komutd = new SqlCommand("select Ogretmen_profilfoto from Tbl_Ogretmen where Ogretmen_id = @p1", baglanti);
                komutd.Parameters.AddWithValue("@p1", ogretmenid);
                SqlDataReader drd = komutd.ExecuteReader();
                if (drd.Read())
                {
                    if (drd[0].ToString() != "yok")
                    {
                        btnOgretmenProfil.BackgroundImage = Image.FromFile(drd[0].ToString());
                        btnOgretmenProfil.BackgroundImageLayout = ImageLayout.Zoom;
                        btnOgretmenProfil.Text = "";
                    }
                    else
                    {
                        btnOgretmenProfil.BackgroundImage = null;
                        btnOgretmenProfil.Text = ogretmenad[0].ToString();
                    }
                }
                
            }
            catch
            {
                MessageBox.Show("HATA : Profil fotoğrafınız ya silinmiş ya da bir yerden bir yere taşınmış olmalı.","hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                d = false;
            }
            baglanti.Close();
            if (d == false)
            {
                profilfotoupdateguncelle();
            }
        }

        void OgrenciDataİslemler()
        {
            ogrenciİD.Clear();
            int satir = 0,dokuz=0,on=0,onbir=0,oniki=0;
            string metin2="",sart="",metin3="";
            if (checkATP.Checked == true && checkAMP.Checked == true)
            {
                sart += " (ogrenci_bolum = 'ATP' or ogrenci_bolum = 'AMP') and (";
            }
            else if (checkATP.Checked == true && checkAMP.Checked==false)
            {
                sart += " (ogrenci_bolum = 'ATP' or ogrenci_bolum <> 'AMP') and (";
            }
            else if (checkAMP.Checked == true && checkATP.Checked==false)
            {
                sart += " (ogrenci_bolum <> 'ATP' or ogrenci_bolum = 'AMP') and (";
            }
            else
            {
                sart += " (ogrenci_bolum <> 'ATP' and ogrenci_bolum <> 'AMP') and (";
            }
            metin3 = sart;
            int artcakkk1 = 0;
            if (checkAsube.Checked == true)
            {
                metin2 += " ogrenci_sube = 'A' or";
            }
            else
            {
                metin2 += " ogrenci_sube <> 'A' and";
                artcakkk1++;
            }
            if(checkBsube.Checked == true)
            {
                metin2 += " ogrenci_sube = 'B' or";
            }
            else
            {
                metin2 += " ogrenci_sube <> 'B' and";
                artcakkk1++;
            }
            if (checkCsube.Checked == true)
            {
                metin2 += " ogrenci_sube = 'C' or";
            }
            else
            {
                metin2 += " ogrenci_sube <> 'C' and";
                artcakkk1++;
            }
            if (checkDsube.Checked == true)
            {
                metin2 += " ogrenci_sube = 'D' or";
            }
            else
            {
                metin2 += " ogrenci_sube <> 'D' and";
                artcakkk1++;
            }
            if (checkEsube.Checked == true)
            {
                metin2 += " ogrenci_sube = 'E' or";
            }
            else
            {
                metin2 += " ogrenci_sube <> 'E' and";
                artcakkk1++;
            }
            if (checkFsube.Checked == true)
            {
                metin2 += " ogrenci_sube = 'F' or";
            }
            else
            {
                metin2 += " ogrenci_sube <> 'F' and";
                artcakkk1++;
            }
            if (checkGsube.Checked == true)
            {
                metin2 += " ogrenci_sube = 'G' or";
            }
            else
            {
                metin2 += " ogrenci_sube <> 'G' and";
                artcakkk1++;
            }
            if (checkHsube.Checked == true)
            {
                metin2 += " ogrenci_sube = 'H' or";
            }
            else
            {
                metin2 += " ogrenci_sube <> 'H' and";
                artcakkk1++;
            }
            for (int i = 0; i < metin2.Length; i++)
            {
                if(sart.Length==metin3.Length+metin2.Length-3)
                {
                    break;
                }
                else
                {
                    sart += metin2[i].ToString();
                }
            }
            
            sart += ")";
            baglanti.Open();
            SqlCommand toplamkomudu = new SqlCommand("select ogrenci_sinif, count(*) from Tbl_Ogrenci where"+sart+" group by ogrenci_sinif", baglanti);
            SqlDataReader drtoplam = toplamkomudu.ExecuteReader();
            while (drtoplam.Read())
            {
                if (drtoplam[0].ToString() == "9" && checkDOKUZ.Checked==true)
                {
                    dokuz = int.Parse(drtoplam[1].ToString());
                }
                else if (drtoplam[0].ToString() == "10" && checkON.Checked == true)
                {
                    on = int.Parse(drtoplam[1].ToString());
                }
                else if (drtoplam[0].ToString() == "11" && checkONBİR.Checked == true)
                {
                    onbir = int.Parse(drtoplam[1].ToString());
                }
                else if (drtoplam[0].ToString() == "12" && checkONİKİ.Checked == true)
                {
                    oniki = int.Parse(drtoplam[1].ToString());
                }
            }
            baglanti.Close();
            satir=dokuz+on+onbir+oniki;
            lblOgrenciSayisi.Text = "Toplam "+satir+" öğrenci sayısı";
            dataOgrenciler.RowCount = satir;
            if (dokuz > 0)
            {
                baglanti.Open();
                SqlCommand siralamakomudu1 = new SqlCommand("select ogrenci_id from Tbl_Ogrenci where ogrenci_sinif = '9' and ("+sart+")", baglanti);
                SqlDataReader datasiralama1 = siralamakomudu1.ExecuteReader();
                while (datasiralama1.Read())
                {
                    ogrenciİD.Add(datasiralama1[0].ToString());
                }
                baglanti.Close();
            }
            if (on > 0)
            {
                baglanti.Open();
                SqlCommand siralamakomudu1 = new SqlCommand("select ogrenci_id from Tbl_Ogrenci where ogrenci_sinif = '10' and (" + sart + ")", baglanti);
                SqlDataReader datasiralama1 = siralamakomudu1.ExecuteReader();
                while (datasiralama1.Read())
                {
                    ogrenciİD.Add(datasiralama1[0].ToString());
                }
                baglanti.Close();
            }
            if (onbir > 0)
            {
                baglanti.Open();
                SqlCommand siralamakomudu1 = new SqlCommand("select ogrenci_id from Tbl_Ogrenci where ogrenci_sinif = '11' and (" + sart + ")", baglanti);
                SqlDataReader datasiralama1 = siralamakomudu1.ExecuteReader();
                while (datasiralama1.Read())
                {
                    ogrenciİD.Add(datasiralama1[0].ToString());
                }
                baglanti.Close();
            }
            if (oniki > 0)
            {
                baglanti.Open();
                SqlCommand siralamakomudu1 = new SqlCommand("select ogrenci_id from Tbl_Ogrenci where ogrenci_sinif = '12' and ("+sart+")", baglanti);
                SqlDataReader datasiralama1 = siralamakomudu1.ExecuteReader();
                while (datasiralama1.Read())
                {
                    ogrenciİD.Add(datasiralama1[0].ToString());
                }
                baglanti.Close();
            }
            for (int i = 0; i < satir; i++)
            {
                int sütun = 0, id = 0, yas = 0, numara = 0, artansatirceel = 0;
                string sinif = "", ad = "", soyad = "", tc = "", sifre = "",bolum="",sehirilce="";
                dataOgrenciler.ColumnCount = 10;
                if (checkİD.Checked == true)
                {
                    int aa = 0;
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("select ogrenci_id from Tbl_Ogrenci where ogrenci_id = @p1 and ("+sart+")", baglanti);
                    komut.Parameters.AddWithValue("@p1", ogrenciİD[i]);
                    SqlDataReader datar = komut.ExecuteReader();
                    while (datar.Read())
                    {
                        id = int.Parse(datar[0].ToString());
                    }
                    baglanti.Close();
                    dataOgrenciler.Columns[artansatirceel].HeaderText = "İD";
                    if (id.ToString().Length > 5)
                    {
                        aa = (8 * (id.ToString().Length - 5));
                    }
                    dataOgrenciler.Columns[artansatirceel].Width = 50 + aa;
                    artansatirceel++;
                    sütun++;
                }
                if (checkAD.Checked == true)
                {
                    int aa = 0;
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("select ogrenci_ad from Tbl_Ogrenci where ogrenci_id = @p1 and (" + sart + ")", baglanti);
                    komut.Parameters.AddWithValue("@p1", ogrenciİD[i]);
                    SqlDataReader datar = komut.ExecuteReader();
                    while (datar.Read())
                    {
                        ad = datar[0].ToString();
                    }
                    baglanti.Close();
                    dataOgrenciler.Columns[artansatirceel].HeaderText = "Öğrenci Ad";
                    if (ad.Length > 12)
                    {
                        aa = (11 * (ad.Length - 12));
                    }
                    dataOgrenciler.Columns[artansatirceel].Width = 110 + aa;
                    artansatirceel++;
                    sütun++;
                }
                if (checkSOYAD.Checked == true)
                {
                    int aa = 0;
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("select ogrenci_soyad from Tbl_Ogrenci where ogrenci_id = @p1 and (" + sart + ")", baglanti);
                    komut.Parameters.AddWithValue("@p1", ogrenciİD[i]);
                    SqlDataReader datar = komut.ExecuteReader();
                    while (datar.Read())
                    {
                        soyad = datar[0].ToString();
                    }
                    baglanti.Close();
                    dataOgrenciler.Columns[artansatirceel].HeaderText = "Öğrenci Soyad";
                    if (soyad.Length > 12)
                    {
                        aa = (11 * (soyad.Length - 12));
                    }
                    dataOgrenciler.Columns[artansatirceel].Width = 125 + aa;
                    artansatirceel++;
                    sütun++;
                }
                if (checkYAS.Checked == true)
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("select ogrenci_yas from Tbl_Ogrenci where ogrenci_id = @p1 and ("+sart+")", baglanti);
                    komut.Parameters.AddWithValue("@p1", ogrenciİD[i]);
                    SqlDataReader datar = komut.ExecuteReader();
                    while (datar.Read())
                    {
                        yas = int.Parse(datar[0].ToString());
                    }
                    baglanti.Close();
                    dataOgrenciler.Columns[artansatirceel].HeaderText = "Yaş";
                    dataOgrenciler.Columns[artansatirceel].Width = 50;
                    artansatirceel++;
                    sütun++;
                }
                if (checkSİNİF.Checked == true)
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("select ogrenci_sinif,ogrenci_sube,ogrenci_bolum from Tbl_Ogrenci where ogrenci_id = @p1 and ("+sart+")", baglanti);
                    komut.Parameters.AddWithValue("@p1", ogrenciİD[i]);
                    SqlDataReader datar = komut.ExecuteReader();
                    while (datar.Read())
                    {
                        sinif = datar[0].ToString() + "/" + datar[1].ToString() + " " + datar[2].ToString();
                    }
                    baglanti.Close();
                    dataOgrenciler.Columns[artansatirceel].HeaderText = "Sınıf/Şube";
                    dataOgrenciler.Columns[artansatirceel].Width = 85;
                    artansatirceel++;
                    sütun++;
                }
                if (checkBOLUM.Checked == true)
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("select ogrenci_alan from Tbl_Ogrenci where ogrenci_id = @p1 and ("+sart+")", baglanti);
                    komut.Parameters.AddWithValue("@p1", ogrenciİD[i]);
                    SqlDataReader datar = komut.ExecuteReader();
                    while (datar.Read())
                    {
                        bolum = datar[0].ToString();
                    }
                    baglanti.Close();
                    dataOgrenciler.Columns[artansatirceel].HeaderText = "Bölüm";
                    dataOgrenciler.Columns[artansatirceel].Width = 150;
                    artansatirceel++;
                    sütun++;
                }
                if (checkNUMARA.Checked == true)
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("select ogrenci_numara from Tbl_Ogrenci where ogrenci_id = @p1 and (" + sart + ")", baglanti);
                    komut.Parameters.AddWithValue("@p1", ogrenciİD[i]);
                    SqlDataReader datar = komut.ExecuteReader();
                    while (datar.Read())
                    {
                        numara = int.Parse(datar[0].ToString());
                    }
                    baglanti.Close();
                    dataOgrenciler.Columns[artansatirceel].HeaderText = "Öğrenci No";
                    dataOgrenciler.Columns[artansatirceel].Width = 108;
                    artansatirceel++;
                    sütun++;
                }
                if (checkSEHİRİLCE.Checked == true)
                {
                    int aa = 0;
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("select ogrenci_sehir,ogrenci_ilce from Tbl_Ogrenci where ogrenci_id = @p1 and (" + sart + ")", baglanti);
                    komut.Parameters.AddWithValue("@p1", ogrenciİD[i]);
                    SqlDataReader datar = komut.ExecuteReader();
                    while (datar.Read())
                    {
                        sehirilce = datar[0].ToString() + "/"+datar[1].ToString();
                    }
                    baglanti.Close();
                    dataOgrenciler.Columns[artansatirceel].HeaderText = "İl/İlçe";
                    if (sehirilce.Length > 12)
                    {
                        aa = (11 * (sehirilce.Length - 12));
                    }
                    dataOgrenciler.Columns[artansatirceel].Width = 125 + aa;
                    artansatirceel++;
                    sütun++;
                }
                if (checkTC.Checked == true)
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("select ogrenci_TC from Tbl_Ogrenci where ogrenci_id = @p1 and (" + sart + ")", baglanti);
                    komut.Parameters.AddWithValue("@p1", ogrenciİD[i]);
                    SqlDataReader datar = komut.ExecuteReader();
                    while (datar.Read())
                    {
                        tc = datar[0].ToString();
                    }
                    baglanti.Close();
                    dataOgrenciler.Columns[artansatirceel].HeaderText = "Öğrenci TC";
                    dataOgrenciler.Columns[artansatirceel].Width = 105;
                    artansatirceel++;
                    sütun++;
                }
                if (checkSİFRE.Checked == true)
                {
                    int aa = 0;
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("select ogrenci_sifre from Tbl_Ogrenci where ogrenci_id = @p1 and (" + sart + ")", baglanti);
                    komut.Parameters.AddWithValue("@p1", ogrenciİD[i]);
                    SqlDataReader datar = komut.ExecuteReader();
                    while (datar.Read())
                    {
                        sifre = datar[0].ToString();
                    }
                    baglanti.Close();
                    dataOgrenciler.Columns[artansatirceel].HeaderText = "Şifre";
                    if (sifre.Length > 3)
                    {
                        aa = (13 * (sifre.Length - 3));
                    }
                    dataOgrenciler.Columns[artansatirceel].Width = 50 + aa;
                    artansatirceel++;
                    sütun++;
                }
                dataOgrenciler.ColumnCount = sütun;
                int artancell = 0;
                if (checkİD.Checked == true)
                {
                    dataOgrenciler.Rows[i].Cells[artancell].Value = id;
                    artancell++;
                }
                if (checkAD.Checked == true)
                {
                    dataOgrenciler.Rows[i].Cells[artancell].Value = ad;
                    artancell++;
                }
                if (checkSOYAD.Checked == true)
                {
                    dataOgrenciler.Rows[i].Cells[artancell].Value = soyad;
                    artancell++;
                }
                if (checkYAS.Checked == true)
                {
                    dataOgrenciler.Rows[i].Cells[artancell].Value = yas;
                    artancell++;
                }
                if (checkSİNİF.Checked == true)
                {
                    dataOgrenciler.Rows[i].Cells[artancell].Value = sinif;
                    artancell++;
                }
                if (checkBOLUM.Checked == true)
                {
                    dataOgrenciler.Rows[i].Cells[artancell].Value = bolum;
                    artancell++;
                }
                if (checkNUMARA.Checked == true)
                {
                    dataOgrenciler.Rows[i].Cells[artancell].Value = numara;
                    artancell++;
                }
                if (checkSEHİRİLCE.Checked == true)
                {
                    dataOgrenciler.Rows[i].Cells[artancell].Value = sehirilce;
                    artancell++;
                }
                if (checkTC.Checked == true)
                {
                    dataOgrenciler.Rows[i].Cells[artancell].Value = tc;
                    artancell++;
                }
                if (checkSİFRE.Checked == true)
                {
                    dataOgrenciler.Rows[i].Cells[artancell].Value = sifre;
                    artancell++;
                }
            }
            
        }
        private void FrmOgretmenİslemler_Load(object sender, EventArgs e)
        {
            profilfotokoyma();
            int artacak2 = 0;
            btnOgretmenProfil.Text = ogretmenad[0].ToString();
            lblOgretmenadsoyad.Text = ogretmenad + " " + ogretmensoyad;
            for (int i = 0; i < lblOgretmenadsoyad.Text.Length; i++)
            {
                if (lblOgretmenadsoyad.Text[i].ToString() == "i" || lblOgretmenadsoyad.Text[i].ToString() == "ı" || lblOgretmenadsoyad.Text[i].ToString() == "j" || lblOgretmenadsoyad.Text[i].ToString() == "l" || lblOgretmenadsoyad.Text[i].ToString() == "t" || lblOgretmenadsoyad.Text[i].ToString() == "İ" || lblOgretmenadsoyad.Text[i].ToString() == "I")
                {
                    artacak2 += 4;
                }
                else
                {
                    artacak2 += 7;
                }
            }
            Size panelboyutu = new Size(82+artacak2, panel1.Size.Height);
            panel1.Size = panelboyutu;
            int artacak = 0;
            lblOkulAdi.Text = okulunadi;
            for(int i = 0; i < lblOkulAdi.Text.Length; i++)
            {
                if (lblOkulAdi.Text[i].ToString() == "İ" || lblOkulAdi.Text[i].ToString() == "I")
                {
                    artacak += 12;
                }
                else if (lblOkulAdi.Text[i].ToString() == " ")
                {
                    artacak += 16;
                }
                else
                {
                    artacak += 24;
                }
            }
            Size sizeform = new Size(50+artacak, this.Size.Height);
            this.Size = sizeform;

            OgrenciDataİslemler();
        }

        private void checkİD_CheckedChanged(object sender, EventArgs e)
        {
            OgrenciDataİslemler();
        }

        private void checkAD_CheckedChanged(object sender, EventArgs e)
        {
            OgrenciDataİslemler();
        }

        private void checkSOYAD_CheckedChanged(object sender, EventArgs e)
        {
            OgrenciDataİslemler();
        }

        private void checkYAS_CheckedChanged(object sender, EventArgs e)
        {
            OgrenciDataİslemler();
        }

        private void checkSİNİF_CheckedChanged(object sender, EventArgs e)
        {
            OgrenciDataİslemler();
        }

        private void checkNUMARA_CheckedChanged(object sender, EventArgs e)
        {
            OgrenciDataİslemler();
        }

        private void checkTC_CheckedChanged(object sender, EventArgs e)
        {
            OgrenciDataİslemler();
        }

        private void checkSİFRE_CheckedChanged(object sender, EventArgs e)
        {
            OgrenciDataİslemler();
        }

        

        private void checkBOLUM_CheckedChanged(object sender, EventArgs e)
        {
            OgrenciDataİslemler();
        }

        private void checkSEHİRİLCE_CheckedChanged(object sender, EventArgs e)
        {
            OgrenciDataİslemler();
        }

        private void checkDOKUZ_CheckedChanged(object sender, EventArgs e)
        {
            OgrenciDataİslemler();
        }

        private void checkON_CheckedChanged(object sender, EventArgs e)
        {
            OgrenciDataİslemler();
        }

        private void checkONBİR_CheckedChanged(object sender, EventArgs e)
        {
            OgrenciDataİslemler();
        }

        private void checkONİKİ_CheckedChanged(object sender, EventArgs e)
        {
            OgrenciDataİslemler();
        }

        private void checkAsube_CheckedChanged(object sender, EventArgs e)
        {
            OgrenciDataİslemler();
        }

        private void checkBsube_CheckedChanged(object sender, EventArgs e)
        {
            OgrenciDataİslemler();
        }

        private void checkCsube_CheckedChanged(object sender, EventArgs e)
        {
            OgrenciDataİslemler();
        }

        private void checkDsube_CheckedChanged(object sender, EventArgs e)
        {
            OgrenciDataİslemler();
        }

        private void checkEsube_CheckedChanged(object sender, EventArgs e)
        {
            OgrenciDataİslemler();
        }

        private void checkFsube_CheckedChanged(object sender, EventArgs e)
        {
            OgrenciDataİslemler();
        }

        private void checkGsube_CheckedChanged(object sender, EventArgs e)
        {
            OgrenciDataİslemler();
        }

        private void checkHsube_CheckedChanged(object sender, EventArgs e)
        {
            OgrenciDataİslemler();
        }

        private void checkATP_CheckedChanged(object sender, EventArgs e)
        {
            OgrenciDataİslemler();
        }

        private void checkAMP_CheckedChanged(object sender, EventArgs e)
        {
            OgrenciDataİslemler();
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            FrmAnaGiris bag = new FrmAnaGiris();
            bag.Show();
            this.Close();
        }

        private void profilFotoğrafınıDeğiştirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Resim Dosyaları (*.png;*.jpg) |*.png;*.jpg";
            openFileDialog.Title = "Resim Seç";
            openFileDialog.Multiselect = false;
            openFileDialog.ShowHelp = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("update Tbl_Ogretmen set Ogretmen_profilfoto = @p1 where Ogretmen_id = @p2", baglanti);
                cmd.Parameters.AddWithValue("@p1", openFileDialog.FileName);
                cmd.Parameters.AddWithValue("@p2", ogretmenid);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Profil Fotoğrafınız eklenmiştir.", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            profilfotokoyma();
        }
        void profilfotoupdateguncelle()
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("update Tbl_Ogretmen set Ogretmen_profilfoto = 'yok' where Ogretmen_id = @p1", baglanti);
            cmd.Parameters.AddWithValue("@p1", ogretmenid);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Profil Fotoğrafınız başarıyla kaldırılmıştır!","bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        private void profilFotoğrafınıKaldırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            profilfotoupdateguncelle();
            profilfotokoyma();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            notgiris();
        }

        private void dataOgrenciler_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            notgiris();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmYoklamaSinifiGiris form = new FrmYoklamaSinifiGiris();
            form.ogretmenad = ogretmenad;
            form.ogretmensoyad = ogretmensoyad;
            form.ogretmenid = ogretmenid;
            form.ogretmencinsiyet = ogretmencinsiyet;
            form.ogretmenders = ogretmenders;
            form.ogretmensifre = ogretmensifre;
            form.ogretmenTC = ogretmenTC;
            form.okulunadi = okulunadi;
            form.ogretmenyas = ogretmenyas;
            form.Show();
        }
    }
}
