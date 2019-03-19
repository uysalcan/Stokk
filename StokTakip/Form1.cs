using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//Sql kütüphanesini tanımlmak için yazıln kod

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        SqlConnection baglan;//bağlantı
        SqlCommand komut;//komut
        SqlDataAdapter veri;//veri bağdaştırıcısı
        void Baglanti()//her satıra yazmaktan ise kısayol olarak oluşturulup bağlanti ile sql connect 'bağlanti' cekiliyor
        {
            baglan = new SqlConnection("Data Source=FEEFER\\SQLEXPRESS;Initial Catalog=StokTakip;Integrated Security=True"); //bağlanti kodu server = . bilgisayardki konumu catalog db adı 
            baglan.Open();
            veri = new SqlDataAdapter("Select * From tblStokTakip", baglan); //yukarıdaki konum içerisindeki table yi cekmeye yarayan kod
            DataTable tablo = new DataTable();
            veri.Fill(tablo);
            datagr.DataSource = tablo;
            //  baglan.Close();
        }
        public Form1()
        {
            InitializeComponent();
        }    
        private void Form1_Load(object sender, EventArgs e)
        {
            Baglanti();        
        }
        private void giris_Click(object sender, EventArgs e)
        {

        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void ad_Click(object sender, EventArgs e)
        {

        }
        private void gr_Click(object sender, EventArgs e)
        {

        }
        private void grup_TextChanged(object sender, EventArgs e)
        {

        }
        private void stok_Click(object sender, EventArgs e)
        {

        }
        private void mstok_TextChanged(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Adi.Text = datagr.CurrentRow.Cells[0].Value.ToString();//textleri datagridviewe kaydediyor 
            grup.Text = datagr.CurrentRow.Cells[1].Value.ToString();
            mstok.Text = datagr.CurrentRow.Cells[2].Value.ToString(); 
        }
        private void Adi_TextChanged(object sender, EventArgs e)
        {

        }
        private void Kaydet_Click(object sender, EventArgs e)
        { 
            int hata = 0;
            if (Adi.Text == "")
                hata = 1;
            if (grup.Text == "")
                hata = 1;
            if (mstok.Text == "")
                hata = 1;
            if (hata == 1)
                MessageBox.Show("Boş Bırakılamaz.");//int 0 atıyoruz her text boxu 0 ile test ediyoruz 0 boş 1 dolu oluyor 1 e eşit ise yani dolu ise bir sonrakine geçiyor değil ise hata veriyor ekrana yazı cıkıyor
            else
            {
                try//try catch ekleme sebebim primary key olan mevcut stok aynı girildiğinde ekrana uyarı vermeyip program patlıyordu aynı kayıt bulunduğunda hata almak yerine uyarı vermesini sağlamak içindi
                {
                    string sorgu = "Insert into tblStokTakip (Adi,Grubu,MevcutStok) values (@Adi,@Grubu,@MevcutStok)";//Adi sql column adı ve @Adi ise bu column un ismini c# ta belirtilmesine yarayan kod 
                    komut = new SqlCommand(sorgu, baglan);
                    komut.Parameters.AddWithValue("@Adi", Adi.Text); //burada ise adi ni hangi text boxtan veri alıp sqle kaydedeceğini yönlendiren kod
                    komut.Parameters.AddWithValue("@Grubu", grup.Text);
                    komut.Parameters.AddWithValue("@MevcutStok", mstok.Text);
                    komut.ExecuteNonQuery();
                    Baglanti();
                }
                catch
                {
                    MessageBox.Show("Aynı Stok Bulunmaktadır.");
                }          
            }
        }
        private void Arama_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from tblStokTakip where MevcutStok like '" + Arama.Text + "%'", baglan); //tblstoktakip yani sql içerisindeki StokTakipteki Tablo içerisinde mevcut stok kayıtlarını arama text ile karşılştırıp diziyor
            DataSet ds = new DataSet();
           // baglan.Open();
            da.Fill(ds, "tblStokTakip");
            datagr.DataSource = ds.Tables["tblStokTakip"];
          //  baglan.Close();
        }

        private void Sil_Click(object sender, EventArgs e)
        {

        }
    }
}
