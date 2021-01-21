using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//veri tabanı icin gerekli kutuphane

namespace kutuphaneOtomasyonu
{
    public partial class kitapduzenle : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        public kitapduzenle()
        {
            InitializeComponent();
        }

        //baglantiyi yapiyoruz
        void kitapGetir()
        {
            baglanti = new SqlConnection("server=.; Initial Catalog=kutuphaneOtomasyonu;Integrated Security=SSPI");
            baglanti.Open();
            da = new SqlDataAdapter("select * from kitap", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridViewkitap.DataSource = tablo;
            baglanti.Close();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void kitapduzenle_Load(object sender, EventArgs e)
        {
            //buraya baglanti metodunu cagiriyoruz 
            kitapGetir();
        }

        //textboxların dolmasını sağlayan metod
        private void dataGridViewkitap_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtkitapid.Text = dataGridViewkitap.CurrentRow.Cells[0].Value.ToString();
            txtkitapadi.Text = dataGridViewkitap.CurrentRow.Cells[1].Value.ToString();
            txtkitapyazari.Text = dataGridViewkitap.CurrentRow.Cells[2].Value.ToString();
            txtbaskiyili.Text = dataGridViewkitap.CurrentRow.Cells[3].Value.ToString();
            txtkitapdili.Text = dataGridViewkitap.CurrentRow.Cells[4].Value.ToString();
            txtyayinevi.Text=dataGridViewkitap.CurrentRow.Cells[5].Value.ToString();
            txtkitapaciklama.Text = dataGridViewkitap.CurrentRow.Cells[6].Value.ToString();
        }

        //kitap ekleme metodu
        private void kitapekle_Click(object sender, EventArgs e)
        {
            string sorgu = ("insert into kitap(kitapAdi,kitapYazari,kitapBaskiYili,kitapDili,kitapYayinEvi,aciklama) values (@kitapAdi,@kitapYazari,@kitapBaskiYili,@kitapDili,@kitapYayinEvi,@aciklama)");
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@kitapAdi", txtkitapadi.Text);
            komut.Parameters.AddWithValue("@kitapYazari", txtkitapyazari.Text);
            komut.Parameters.AddWithValue("@kitapBaskiYili", txtbaskiyili.Text);
            komut.Parameters.AddWithValue("@kitapDili", txtkitapdili.Text);
            komut.Parameters.AddWithValue("@kitapYayinEvi", txtyayinevi.Text);
            komut.Parameters.AddWithValue("@aciklama", txtkitapaciklama.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            kitapGetir();//kitap ekledikten sonra güncel veri tabanini görmek icin metodu cagiriyoruz.


        }

        //silme metodu
        private void kitapsil_Click(object sender, EventArgs e)
        {
            string sorgu = "delete from kitap where kitapID=@kitapID";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@kitapID", Convert.ToInt32(txtkitapid.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            kitapGetir();//kitap ekledikten sonra güncel veri tabanini görmek icin metodu cagiriyoruz.
        }

        //güncellem metodu
        private void kitapgüncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "update kitap set kitapAdi=@kitapAdi,kitapYazari=@KitapYazari,kitapBaskiYili=@kitapBaskiYili,kitapDili=@kitapDili,kitapYayinEvi=@kitapYayinEvi,aciklama=@aciklama where kitapID=@kitapID";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@kitapID", Convert.ToInt32(txtkitapid.Text));
            komut.Parameters.AddWithValue("@kitapAdi", txtkitapadi.Text);
            komut.Parameters.AddWithValue("@kitapYazari", txtkitapyazari.Text);
            komut.Parameters.AddWithValue("@kitapBaskiYili", txtbaskiyili.Text);
            komut.Parameters.AddWithValue("@kitapDili", txtkitapdili.Text);
            komut.Parameters.AddWithValue("@kitapYayinEvi", txtyayinevi.Text);
            komut.Parameters.AddWithValue("@aciklama", txtkitapaciklama.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            kitapGetir();//kitap ekledikten sonra güncel veri tabanini görmek icin metodu cagiriyoruz.
        }

        private void anasayfadön_Click(object sender, EventArgs e)
        {
            Form1 gecis = new Form1();
            gecis.Show();
            this.Hide();
        }

        //temizleme metodu
        private void temizle_Click(object sender, EventArgs e)
        {
            txtkitapid.Clear();
            txtbaskiyili.Clear();
            txtkitapaciklama.Clear();
            txtkitapadi.Clear();
            txtkitapyazari.Clear();
            txtyayinevi.Clear();
            txtkitapdili.Clear();
        }
    }
}
