using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eokul
{
    public partial class TimerForm : Form
    {
        public TimerForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=burak;Initial Catalog=Eokulveritabani;Integrated Security=True");
        private void TimerForm_Load(object sender, EventArgs e)
        {
            zaman();
            saniye = dsaniye;
            dakika = ddakika;
            saat = dsaat;
            gun = dgun;
            timer1.Start();
        }
        int saniye, dakika, saat, gun, dsaniye, ddakika, dsaat, dgun;

        private void TimerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            zaman();
        }



        void zaman()
        {
            baglanti.Open();
            SqlCommand komutt = new SqlCommand("select * from Tbl_Timerr where timer_id = @p1", baglanti);
            komutt.Parameters.AddWithValue("@p1", 1);
            SqlDataReader dr1 = komutt.ExecuteReader();
            while (dr1.Read())
            {
                dsaniye = int.Parse(dr1[1].ToString());
                ddakika = int.Parse(dr1[2].ToString());
                dsaat = int.Parse(dr1[3].ToString());
                dgun = int.Parse(dr1[4].ToString());
            }
            baglanti.Close();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutt = new SqlCommand("select * from Tbl_Timerr where timer_id = @p1", baglanti);
            komutt.Parameters.AddWithValue("@p1", 1);
            SqlDataReader dr1 = komutt.ExecuteReader();
            while (dr1.Read())
            {
                saniye = int.Parse(dr1[1].ToString());
                dakika = int.Parse(dr1[2].ToString());
                saat = int.Parse(dr1[3].ToString());
                gun = int.Parse(dr1[4].ToString());
            }
            baglanti.Close();

            saniye++;
            if (saniye >= 60)
            {
                dakika++;
                saniye = 0;
            }
            if (dakika >= 60)
            {
                saat++;
                dakika = 0;
            }
            if (saat >= 24)
            {
                gun++;
                saat = 0;
            }
            baglanti.Open();
            string metin;
            SqlCommand komut = new SqlCommand("update Tbl_Timerr set timer_saniye = @p1,timer_dakika = @p2,timer_saat = @p3,timer_gun = @p4,timer_tamhali = @p5,timer_kisahali = @p6 where timer_id = @p7", baglanti);
            komut.Parameters.AddWithValue("@p1", saniye);
            komut.Parameters.AddWithValue("@p2", dakika);
            komut.Parameters.AddWithValue("@p3", saat);
            komut.Parameters.AddWithValue("@p4", gun);
            komut.Parameters.AddWithValue("@p5", gun + " gün, " + saat + " saat, " + dakika + " dakika, " + saniye + " saniye");
            if (gun >= 10)
            {
                if (saat >= 10)
                {
                    if (dakika >= 10)
                    {
                        if (saniye >= 10)
                        {
                            metin = gun + ":" + saat + ":" + dakika + ":" + saniye;
                        }
                        else
                        {
                            metin = gun + ":" + saat + ":" + dakika + ":0" + saniye;
                        }
                    }
                    else
                    {
                        if (saniye >= 10)
                        {
                            metin = gun + ":" + saat + ":0" + dakika + ":" + saniye;
                        }
                        else
                        {
                            metin = gun + ":" + saat + ":0" + dakika + ":0" + saniye;
                        }
                    }
                }
                else
                {
                    if (dakika >= 10)
                    {
                        if (saniye >= 10)
                        {
                            metin = gun + ":0" + saat + ":" + dakika + ":" + saniye;
                        }
                        else
                        {
                            metin = gun + ":0" + saat + ":" + dakika + ":0" + saniye;
                        }
                    }
                    else
                    {
                        if (saniye >= 10)
                        {
                            metin = gun + ":0" + saat + ":0" + dakika + ":" + saniye;
                        }
                        else
                        {
                            metin = gun + ":0" + saat + ":0" + dakika + ":0" + saniye;
                        }
                    }
                }
            }
            else
            {
                if (saat >= 10)
                {
                    if (dakika >= 10)
                    {
                        if (saniye >= 10)
                        {
                            metin = "0"+gun + ":" + saat + ":" + dakika + ":" + saniye;
                        }
                        else
                        {
                            metin = "0"+gun + ":" + saat + ":" + dakika + ":0" + saniye;
                        }
                    }
                    else
                    {
                        if (saniye >= 10)
                        {
                            metin = "0"+gun + ":" + saat + ":0" + dakika + ":" + saniye;
                        }
                        else
                        {
                            metin = "0"+gun + ":" + saat + ":0" + dakika + ":0" + saniye;
                        }
                    }
                }
                else
                {
                    if (dakika >= 10)
                    {
                        if (saniye >= 10)
                        {
                            metin = "0"+gun + ":0" + saat + ":" + dakika + ":" + saniye;
                        }
                        else
                        {
                            metin = "0"+gun + ":0" + saat + ":" + dakika + ":0" + saniye;
                        }
                    }
                    else
                    {
                        if (saniye >= 10)
                        {
                            metin = "0"+gun + ":0" + saat + ":0" + dakika + ":" + saniye;
                        }
                        else
                        {
                            metin = "0"+gun + ":0" + saat + ":0" + dakika + ":0" + saniye;
                        }
                    }
                }
            }
            komut.Parameters.AddWithValue("@p6", metin);
            komut.Parameters.AddWithValue("@p7", 1);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
