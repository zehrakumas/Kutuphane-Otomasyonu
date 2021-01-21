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
    public partial class emanetduzenle : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        public emanetduzenle()
        {
            InitializeComponent();
        }
        void emanetGetir()
        {
            baglanti = new SqlConnection("server=.; Initial Catalog=kutuphaneOtomasyonu;Integrated Security=SSPI");
            baglanti.Open();
            da = new SqlDataAdapter("select * from emanet", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridViewEmanet.DataSource = tablo;
            baglanti.Close();
        }

        private void emanetduzenle_Load(object sender, EventArgs e)
        {
            emanetGetir();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        //textboxların dolu olmasını sağlayan metod-sağ propertiesden cellenter'e çift tıklayıp açıyoruz.
        private void dataGridViewEmanet_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtemanetid.Text = dataGridViewEmanet.CurrentRow.Cells[0].Value.ToString();
            txtkitapid.Text = dataGridViewEmanet.CurrentRow.Cells[1].Value.ToString();
            txtuyeid.Text = dataGridViewEmanet.CurrentRow.Cells[2].Value.ToString();
            dateTimePickeremanetVermeTarih.Text = dataGridViewEmanet.CurrentRow.Cells[3].Value.ToString();
            dateTimePickerEmanetGeriAlmaTarih.Text = dataGridViewEmanet.CurrentRow.Cells[4].Value.ToString();
        }

        //ana sayfaya dönme metodu
        private void anaSayfaDon_Click(object sender, EventArgs e)
        {
            Form1 gecis = new Form1();
            gecis.Show();
            this.Hide();
        }

        
        //emanet silme metodu
        private void emanetSil_Click(object sender, EventArgs e)
        {
            string sorgu = "delete from emanet where emanetID=@emanetID";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@emanetID", Convert.ToInt32(txtemanetid.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            emanetGetir();//kitap ekledikten sonra güncel veri tabanini görmek icin metodu cagiriyoruz.
        }

        //textboxları silen metod
        private void emanettemizle_Click(object sender, EventArgs e)
        {
            txtemanetid.Clear();
            txtkitapid.Clear();
            txtuyeid.Clear();
            dateTimePickerEmanetGeriAlmaTarih.ResetText();
            dateTimePickeremanetVermeTarih.ResetText();
        }

        //emanet ekleme metodu
        private void emanetEkle_Click(object sender, EventArgs e)
        {
            string sorgu = ("insert into emanet(kitapID,uyeID,emanetVermeTarih,emanetGeriAlmaTarih) values (@kitapID,@uyeID,@emanetVermeTarih,@emanetGeriAlmaTarih)");
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@kitapID", txtkitapid.Text);
            komut.Parameters.AddWithValue("@uyeID", txtuyeid.Text);
            komut.Parameters.AddWithValue("@emanetVermeTarih", dateTimePickeremanetVermeTarih.Text);
            komut.Parameters.AddWithValue("@emanetGeriAlmaTarih", dateTimePickerEmanetGeriAlmaTarih.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            emanetGetir();//emanet ekledikten sonra güncel veri tabanini görmek icin metodu cagiriyoruz.
        }

        //güncelleme metodu
        private void emanetGüncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "update emanet set uyeId=@uyeID,kitapID=@kitapID,emanetVermeTarih=@emanetVermeTarih,emanetGeriAlmaTarih=@emanetGeriAlmaTarih where emanetID=@emanetID";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@emanetID", Convert.ToInt32(txtemanetid.Text));
            komut.Parameters.AddWithValue("@uyeID", Convert.ToInt32(txtuyeid.Text));
            komut.Parameters.AddWithValue("@kitapID", Convert.ToInt32(txtkitapid.Text));
            komut.Parameters.AddWithValue("@emanetVermeTarih", dateTimePickeremanetVermeTarih.Text);
            komut.Parameters.AddWithValue("@emanetGeriAlmaTarih", dateTimePickerEmanetGeriAlmaTarih.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            emanetGetir();//emanet ekledikten sonra güncel veri tabanini görmek icin metodu cagiriyoruz.
        }
    }
}
