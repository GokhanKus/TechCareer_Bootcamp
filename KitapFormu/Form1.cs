using KitapFormu.Entity;
using KitapFormu.Utilities;
using Microsoft.Data.SqlClient;
using System.Data;
namespace KitapFormu
{
    public partial class Form1 : Form
    {
        //private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=TechCareer; Integrated Security=True;";//SSPI
        private readonly SingletonDbConnection _connection;
        //her metotta SqlConnectiona baglanmak zorunda kalmayalým, singleton ile halledelim.

        int secilenYazarId;
        int secilenKategoriId;
        int secilenYayineviId;
        public Form1()
        {
            InitializeComponent();
            _connection = SingletonDbConnection.GetInstance();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridViewiDoldur();
            KategorileriDoldur();
            YayinevleriniDoldur();
            YazarlariDoldur();
        }

        private void YazarlariDoldur()
        {
            List<Yazar> yazarlar = new List<Yazar> { new Yazar { Id = -1, YazarAdSoyad = "yazari belirtiniz" } };
            try
            {
                _connection.OpenConnection();
                string query = "select * from Yazar";
                SqlCommand command = new SqlCommand(query, _connection.Connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = (int)(reader["Id"]);
                    string yazarAdSoyad = $"{reader["YazarAdi"]} {reader["YazarSoyadi"]}";
                    yazarlar.Add(new Yazar
                    {
                        Id = id,
                        YazarAdSoyad = yazarAdSoyad
                    });
                }
                cmbYazar.DataSource = yazarlar;
                cmbYazar.DisplayMember = "YazarAdSoyad";
                cmbYazar.ValueMember = "Id";
                reader.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("bir hata meydana geldi: " + ex.Message);
            }
            finally
            {
                _connection.CloseConnection();
            }
        }

        private void YayinevleriniDoldur()
        {
            List<Yayinevi> yayineviList = new List<Yayinevi>();
            yayineviList.Add(new Yayinevi { Id = -1, YayineviAdi = "Lutfen yayinevi seciniz" });
            try
            {
                _connection.OpenConnection();
                string query = "select * from Yayinevi";
                SqlCommand command = new SqlCommand(query, _connection.Connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    yayineviList.Add(new Yayinevi
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        YayineviAdi = (string)reader["YayineviAdi"]
                    });
                }
                cmbYayinEvi.DataSource = yayineviList;
                cmbYayinEvi.DisplayMember = "YayineviAdi";
                cmbYayinEvi.ValueMember = "Id";
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("bir hata olustu " + ex.Message);
            }
            finally
            {
                _connection.CloseConnection();
            }
        }

        private void KategorileriDoldur()
        {
            List<Kategori> kategoriler = new List<Kategori> { new Kategori { Id = -1, KategoriAdi = "Lutfen Kategori Seciniz" } };
            try
            {
                _connection.OpenConnection();
                string query = "select * from Kategori";
                SqlCommand command = new SqlCommand(query, _connection.Connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    kategoriler.Add(new Kategori
                    {
                        Id = (int)reader["Id"],
                        KategoriAdi = (string)reader["KategoriAdi"]
                    });
                }
                cmbKategori.DataSource = kategoriler;
                cmbKategori.DisplayMember = "KategoriAdi";
                cmbKategori.ValueMember = "Id";
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("bir hata meydana geldi: " + ex.Message);
            }
            finally
            {
                _connection.CloseConnection();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string kitapAdi = txtKitapAdi.Text;
            decimal kitapFiyat = decimal.Parse(txtFiyat.Text);
            int sayfaSayisi = int.Parse(txtSayfaSayisi.Text);
            string query = "INSERT INTO Kitap(KitapAdi, Fiyat, SayfaSayisi, YazarId, KategoriId, YayineviId) " +
                "VALUES (@KitapAdi, @Fiyat, @SayfaSayisi,@YazarId,@KategoriId,@YayineviId)";
            try
            {
                _connection.OpenConnection();
                SqlCommand command = new SqlCommand(query, _connection.Connection);
                command.Parameters.AddWithValue("@KitapAdi", kitapAdi);
                command.Parameters.AddWithValue("@Fiyat", kitapFiyat);
                command.Parameters.AddWithValue("@SayfaSayisi", sayfaSayisi);
                command.Parameters.AddWithValue("@YazarId", secilenYazarId);
                command.Parameters.AddWithValue("@KategoriId", secilenKategoriId);
                command.Parameters.AddWithValue("@YayineviId", secilenYayineviId);
                int etkilenenKayitSayisi = command.ExecuteNonQuery();
                if (etkilenenKayitSayisi > 0 && secilenYazarId != 0 && secilenKategoriId != 0 && secilenYayineviId != 0)
                {
                    MessageBox.Show("Kayit Eklenmistir");
                    DataGridViewiDoldur();
                }
                else
                {
                    MessageBox.Show("secilenYazarId, secilenKategoriId, secilenYayineviId alanlarinin dolu olduguna emin olunuz");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("bir hata olustu " + ex.Message);
            }
            finally
            {
                _connection.CloseConnection();
            }
        }

        private void DataGridViewiDoldur()
        {

            #region 1.yontem
            //try
            //{
            //using (SqlConnection conn = singletonConnection.Connection)
            //    {
            //        connection.Open();
            //        string query = @"
            //            SELECT K.Id, K.KitapAdi, K.Fiyat, K.SayfaSayisi, 
            //                   Yazar.YazarAdi, Yazar.YazarSoyadi, 
            //                   Kategori.KategoriAdi, Yayinevi.YayineviAdi
            //            FROM Kitap AS K
            //            INNER JOIN Yazar ON K.YazarId = Yazar.Id
            //            INNER JOIN Kategori ON K.KategoriId = Kategori.Id
            //            INNER JOIN Yayinevi ON K.YayineviId = Yayinevi.Id
            //        ";

            //        SqlCommand command = new SqlCommand(query, connection);
            //        SqlDataAdapter adapter = new SqlDataAdapter(command);
            //        DataTable dataTable = new DataTable();

            //        adapter.Fill(dataTable);

            //        dataGridView1.DataSource = dataTable;
            //        connection.Close();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message);
            //}
            #endregion

            #region DataSet ile 2.yontem
            try
            {
                _connection.OpenConnection();
                string query = @"
                        SELECT K.Id, K.KitapAdi, K.Fiyat, K.SayfaSayisi, 
                               Yazar.YazarAdi, Yazar.YazarSoyadi, 
                               Kategori.KategoriAdi, Yayinevi.YayineviAdi
                        FROM Kitap AS K
                        INNER JOIN Yazar ON K.YazarId = Yazar.Id
                        INNER JOIN Kategori ON K.KategoriId = Kategori.Id
                        INNER JOIN Yayinevi ON K.YayineviId = Yayinevi.Id
                    ";

                SqlDataAdapter adapter = new SqlDataAdapter(query, _connection.Connection);
                DataSet dataSet = new DataSet();

                adapter.Fill(dataSet, "kitaplar");

                dataGridView1.DataSource = dataSet.Tables["kitaplar"];
                _connection.CloseConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            dataGridView1.Columns["Id"].Visible = false;

            #endregion
        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenKategoriId = cmbKategori.SelectedIndex;
            //Kategori kategori = (Kategori)cmbKategori.SelectedItem;
            //secilenKategoriId = kategori.Id;
        }

        private void cmbYayinEvi_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenYayineviId = cmbYayinEvi.SelectedIndex;
            //Yayinevi yayinevi = (Yayinevi)cmbYayinevi.SelectedItem;
            //secilenYayineviId = yayinevi.Id;
        }

        private void cmbYazar_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenYazarId = cmbYazar.SelectedIndex;
            //Yazar yazar = (Yazar)cmbYazar.SelectedItem;
            //secilenYazarId = yazar.Id;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // En az bir satýr seçilmiþ mi kontrolü
            {
                int secilenSatirIndex = dataGridView1.SelectedRows[0].Index; // Seçilen satýrýn indeksi
                int kitapId = Convert.ToInt32(dataGridView1.Rows[secilenSatirIndex].Cells["Id"].Value); // Seçilen satýrdaki KitapId deðeri
                string query = "DELETE FROM Kitap WHERE Id = @Id"; // Veritabanýndan silme sorgusu
                try
                {
                    _connection.OpenConnection();
                    SqlCommand command = new SqlCommand(query, _connection.Connection);
                    command.Parameters.AddWithValue("@Id", kitapId);
                    int etkilenenKayitSayisi = command.ExecuteNonQuery();
                    if (etkilenenKayitSayisi > 0)
                    {
                        MessageBox.Show("Kayýt silindi");
                        DataGridViewiDoldur(); // DataGridView'i yeniden doldur
                    }
                    else
                    {
                        MessageBox.Show("Kayýt silinemedi");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluþtu: " + ex.Message);
                }
                finally
                {
                    _connection.CloseConnection();
                }
            }
            else
            {
                MessageBox.Show("Lütfen silinecek bir satýr seçin.");
            }
        }
    }
}
