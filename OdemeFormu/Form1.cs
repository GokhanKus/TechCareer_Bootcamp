using OdemeFormu.OdemeYontemleri;
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

namespace OdemeFormu
{
    public partial class Form1 : Form
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=TechCareer; Integrated Security=True;";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOdemeYap_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OdemeYontemleriniGetir();
        }

        private void OdemeYontemleriniGetir()
        {
            List<OdemeTipi> odemeTipleri = new List<OdemeTipi> { new OdemeTipi { ClassName = "", DisplayName = "Odeme Tipi Seciniz" } };
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "select * from OdemeYontemi";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string className = (string)reader["ClassName"];
                        string displayName = (string)reader["DisplayName"];
                        odemeTipleri.Add(new OdemeTipi
                        {
                            ClassName = className,
                            DisplayName = displayName
                        });

                    }
                    cmbOdemeTipi.DataSource = odemeTipleri;
                    cmbOdemeTipi.DisplayMember = "DisplayName";
                    cmbOdemeTipi.ValueMember = "ClassName";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("bir hata meydana geldi: " + ex.Message);
                    throw;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
