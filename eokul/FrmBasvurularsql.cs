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
    public partial class FrmBasvurularsql : Form
    {
        public FrmBasvurularsql()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=burak;Initial Catalog=Eokulveritabani;Integrated Security=True");
        private void FrmBasvurularsql_Load(object sender, EventArgs e)
        {
            this.tbl_SilinenBasvurularTableAdapter1.Fill(this.eokulveritabaniDataSet.Tbl_SilinenBasvurular);
            this.tbl_BasvuruTableAdapter1.Fill(this.eokulveritabaniDataSet.Tbl_Basvuru);
            gridKabulBasvuru.ColumnCount = 8;
            int a=0;
            baglanti.Open();
            SqlCommand komutdeneme = new SqlCommand("select count(*) from Tbl_Ogretmen where Ogretmen_baskabul = 1", baglanti);
            SqlDataReader drdeneme = komutdeneme.ExecuteReader();
            while (drdeneme.Read())
            {
                a = int.Parse(drdeneme[0].ToString());
            }
            baglanti.Close();
            gridKabulBasvuru.RowCount = a;
            int sayac = 0;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT Ogretmen_id, Ogretmen_ad, Ogretmen_soyad, Ogretmen_yas, Ogretmen_cinsiyet, Ogretmen_ders, Ogretmen_TC, Ogretmen_sifre FROM Tbl_Ogretmen WHERE Ogretmen_baskabul = 1", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                gridKabulBasvuru.Rows[sayac].Cells[0].Value = dr[0].ToString();
                gridKabulBasvuru.Rows[sayac].Cells[1].Value = dr[1].ToString();
                gridKabulBasvuru.Rows[sayac].Cells[2].Value = dr[2].ToString();
                gridKabulBasvuru.Rows[sayac].Cells[3].Value = dr[3].ToString();
                gridKabulBasvuru.Rows[sayac].Cells[4].Value = dr[4].ToString();
                gridKabulBasvuru.Rows[sayac].Cells[5].Value = dr[5].ToString();
                gridKabulBasvuru.Rows[sayac].Cells[6].Value = dr[6].ToString();
                gridKabulBasvuru.Rows[sayac].Cells[7].Value = dr[7].ToString();
                sayac++;
            }
            baglanti.Close();
        }

        
    }
}
