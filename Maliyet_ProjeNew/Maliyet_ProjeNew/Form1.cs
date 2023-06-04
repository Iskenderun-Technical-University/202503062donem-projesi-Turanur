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
using System.Data.SqlTypes;


namespace Maliyet_ProjeNew
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            MalzemeListe();
        }

        //Data Source = DESKTOP - 248O3CN\SQLEXPRESS;Initial Catalog = ProjeMaliyet; Integrated Security = True
        // İKİNCİ VERİ TABANI
        // Data Source=DESKTOP-248O3CN\SQLEXPRESS;Initial Catalog=Test_Maliyet;Integrated Security=True

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-248O3CN\SQLEXPRESS;Initial Catalog=Test_Maliyet;Integrated Security=True");


        void MalzemeListe()
        {
            SqlDataAdapter da=new SqlDataAdapter("Select * From TBLMALZEMELER" , baglanti);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void UrunListesi()
        {
            //baglanti.Open();
            //string sql2 = "Select * From tblurunler where AD =@AD and URUNID = @URUNID and  MFIYAT=@MFIYAT and SFIYAT=@SFIYAT and STOK = @STOK";

            //SqlCommand komut = new SqlCommand(sql2, baglanti);
            //SqlDataAdapter da2 = new SqlDataAdapter(komut);
            //DataTable dt2 = new DataTable();
            //da2.Fill(dt2);
            //dataGridView1.DataSource = dt2;

            SqlDataAdapter da2 = new SqlDataAdapter("Select * From tblurunler",baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView1 .DataSource = dt2;

        }

        void kasa()
        {
            SqlDataAdapter da3 = new SqlDataAdapter("Select * From tblkasa", baglanti);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dataGridView1.DataSource = dt3;
        }

        void urunler()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TblUrunler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbUrun.ValueMember = " URUNID";
            CmbUrun.DisplayMember = "AD";
            CmbUrun.DataSource = dt;
            baglanti.Close();
        }


        void malzemeler()
        {
            baglanti.Open() ;
            SqlDataAdapter da = new SqlDataAdapter("Select * From tblmalzemeler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbMalzeme.ValueMember = "MALZEMEID";
            CmbMalzeme.DisplayMember = "AD";
            CmbMalzeme.DataSource = dt;
            baglanti.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MalzemeListe();

            urunler();

            malzemeler();
        }

        private void BtnUrunListesi_Click(object sender, EventArgs e)
        {
            UrunListesi();
        }

        private void BtnKasa_Click(object sender, EventArgs e)
        {

            kasa();
        }

        private void BtnMalzemeEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into tblmalzemeler (ad,stok,fiyat,notlar) values (@p1,@p2,@p3,@p4)" , baglanti);
            komut.Parameters.AddWithValue("@p1", TxtMalzemeAd.Text);
            komut.Parameters.AddWithValue("@p2", decimal.Parse(TxtMalzemeStok.Text));
            komut.Parameters.AddWithValue("@p3", decimal.Parse(TxtMalzemeFiyat.Text));
            komut.Parameters.AddWithValue("@p4", TxtMalzemeNot.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Malzemeniz Sisteme Eklenmiştir" , "Bilgi" , MessageBoxButtons.OK , MessageBoxIcon.Information);
            MalzemeListe();
        }

        private void BtnUrunEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into tblurunler(ad) values (@p1)" , baglanti);
            komut.Parameters.AddWithValue("@p1" , TxtUrunAd.Text);
            komut.ExecuteNonQuery ();
            baglanti.Close();
            MessageBox.Show("Ürün Sisteme Eklendi" , "Bilgi" , MessageBoxButtons.OK , MessageBoxIcon.Information);
            UrunListesi();
        }

        private void BtnUrunOluştur_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into tblfırın (urunıd,malzemeıd,mıktar,malıyet) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", CmbUrun.SelectedValue);
            komut.Parameters.AddWithValue("@p2", CmbMalzeme.SelectedValue);
            komut.Parameters.AddWithValue("@p3", decimal.Parse(TxtMiktar.Text));
            komut.Parameters.AddWithValue("@p4", decimal.Parse(TxtMaliyet.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Malzeme Eklendi","Bilgi", MessageBoxButtons.OK,MessageBoxIcon.Information);

            listBox1.Items.Add(CmbMalzeme.Text + " - " + TxtMaliyet.Text);

        }

        private void TxtMiktar_TextChanged(object sender, EventArgs e)
        {

            double maliyet;

            if(TxtMiktar.Text == "")
            {
                TxtMiktar.Text = "0";
            }

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From tblmalzemeler where Malzemeıd=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", CmbMalzeme.SelectedValue);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtMaliyet.Text = dr[3].ToString();
            }
            baglanti.Close();

            maliyet = Convert.ToDouble(TxtMaliyet.Text) / 1000 * Convert.ToDouble(TxtMiktar.Text); 

            TxtMaliyet.Text =   maliyet.ToString();

        }

        private void CmbMalzeme_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int secilen = dataGridView1.SelectedCells[0].RowIndex;


            TxtUrunID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtUrunAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select sum(Maliyet) from tblfırın where urunıd=@p1" , baglanti);
            komut.Parameters.AddWithValue("@p1", TxtUrunID.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtUrunMFiyat.Text = dr[0].ToString();
            }

            baglanti.Close() ;
        }

        private void BtnUrunGüncelle_Click(object sender, EventArgs e)
        {
            String t1 = TxtUrunID.Text;
            String t2 = TxtUrunAd.Text;
            String t3 = TxtUrunStok.Text;
            String t4 = TxtUrunMFiyat.Text;
            String t5 = TxtUrunSFiyat.Text;

            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE tblurunler SET urunıd='" + t1 + "' , urunad='" + t2 + "' , urunstok='" + t3 + "' , urunmfıyat='" + t4 + "' , urunsfıyat='" + t5 + "' WHERE urunstok '" + t3 + "' ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Malzeme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UrunListesi();



        }
    }
}
