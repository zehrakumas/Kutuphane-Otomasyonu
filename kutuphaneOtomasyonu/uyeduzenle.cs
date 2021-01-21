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
    public partial class uyeduzenle : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        public uyeduzenle()
        {
            InitializeComponent();
        }

        //datagridview doldurma alanı
        void uyeGetir()
        {
            baglanti = new SqlConnection("server=.; Initial Catalog=kutuphaneOtomasyonu;Integrated Security=SSPI");
            baglanti.Open();
            da = new SqlDataAdapter("select * from uye", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridViewUye.DataSource = tablo;
            baglanti.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridViewUye_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //veritabanı ilk proje açıldığında karşımıza gelmesi için burada ekliyoruz
        private void uyeduzenle_Load(object sender, EventArgs e)
        {
            uyeGetir();
        }

        //ana sayfaya dönme metodu
        private void anaSayfaDon_Click(object sender, EventArgs e)
        {
            Form1 gecis = new Form1();
            gecis.Show();
            this.Hide();
        }

        //Textboxların temizlenmesi
        private void temizle_Click(object sender, EventArgs e)
        {
            txtUyeAdres.Clear();
            txtUyeAdı.Clear();
            txtUyeEposta.Clear();
            txtUyeSoyadı.Clear();
            txtUyeTelefon.Clear();
            txtÜyeid.Clear();
        }

        //textboxların dolu olmasını sağlayan metod
        private void dataGridViewUye_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtÜyeid.Text = dataGridViewUye.CurrentRow.Cells[0].Value.ToString();
            txtUyeAdı.Text = dataGridViewUye.CurrentRow.Cells[1].Value.ToString();
            txtUyeSoyadı.Text = dataGridViewUye.CurrentRow.Cells[2].Value.ToString();
            txtUyeTelefon.Text = dataGridViewUye.CurrentRow.Cells[3].Value.ToString();
            txtUyeEposta.Text = dataGridViewUye.CurrentRow.Cells[4].Value.ToString();
            txtUyeAdres.Text = dataGridViewUye.CurrentRow.Cells[5].Value.ToString();
        }


        //yeni üye ekleme metodu
        private void uyeEkle_Click(object sender, EventArgs e)
        {
            string sorgu = ("insert into uye(uyeAdi,uyeSoyadi,uyeTelefon,uyeEposta,uyeAdres) values (@uyeAdi,@uyeSoyadi,@uyeTelefon,@uyeEposta,@uyeAdres)");
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@uyeAdi", txtUyeAdı.Text);
            komut.Parameters.AddWithValue("@uyeSoyadi", txtUyeSoyadı.Text);
            komut.Parameters.AddWithValue("@uyeTelefon", txtUyeTelefon.Text);
            komut.Parameters.AddWithValue("@uyeEposta", txtUyeEposta.Text);
            komut.Parameters.AddWithValue("@uyeAdres", txtUyeAdres.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            uyeGetir();//kitap ekledikten sonra güncel veri tabanini görmek icin metodu cagiriyoruz.
        }

        //üye silme metodu
        private void uyeSil_Click(object sender, EventArgs e)
        {
            string sorgu = "delete from uye where uyeID=@uyeID";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@uyeID", Convert.ToInt32(txtÜyeid.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            uyeGetir();//kitap ekledikten sonra güncel veri tabanini görmek icin metodu cagiriyoruz.
        }

        //üye güncelleme işlemleri 
        private void uyeGüncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "update uye set uyeAdi=@uyeAdi,uyeSoyadi=@uyeSoyadi,uyeTelefon=@uyeTelefon,uyeEposta=@uyeEposta,uyeAdres=@uyeAdres where uyeID=@uyeID";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@uyeID", Convert.ToInt32(txtÜyeid.Text));
            komut.Parameters.AddWithValue("@uyeAdi", txtUyeAdı.Text);
            komut.Parameters.AddWithValue("@uyeSoyadi", txtUyeSoyadı.Text);
            komut.Parameters.AddWithValue("@uyeTelefon", txtUyeTelefon.Text);
            komut.Parameters.AddWithValue("@uyeEposta", txtUyeEposta.Text);
            komut.Parameters.AddWithValue("@uyeAdres", txtUyeAdres.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            uyeGetir();//üye ekledikten sonra güncel veri tabanini görmek icin metodu cagiriyoruz.
        }
    }
}
