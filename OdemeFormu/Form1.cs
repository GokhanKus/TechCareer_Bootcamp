using OdemeFormu.OdemeYontemleri;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace OdemeFormu
{
    public partial class Form1 : Form
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=TechCareer; Integrated Security=True;";
        private string odemeYontemiAdi; // == Class'in adina esittir.

        OdemeYontemi odemeIslemi;
        OdemeIslemiFactory factory;
        IOdemeYontemi odeme;
        public Form1()
        {
            InitializeComponent();
        }
        private void cmbOdemeTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            odemeYontemiAdi = cmbOdemeTipi.SelectedValue.ToString();
        }
        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            #region Open Closed ve Reflection 
            //Type odemeYontemiTuru = Type.GetType("OdemeFormu.OdemeYontemleri." + odemeYontemiAdi);
            //if (odemeYontemiTuru != null)
            //{
            //    IOdemeYontemi secilenOdemeYontemi = (IOdemeYontemi)Activator.CreateInstance(odemeYontemiTuru); //cmbbox'tan secilen odeme yonteminden bir nesne ornegi..
            //    OdemeYontemi odeme = new OdemeYontemi(secilenOdemeYontemi);
            //    lblSonuc.Text = odeme.Ode(int.Parse(txtTutar.Text));
            //}
            //else
            //{
            //    lblSonuc.Text = "boyle bir odeme yontemi eklenmemistir";
            //}
            #endregion

            #region  Open Closed, Reflection With Factory Design

            factory = new OdemeIslemiFactory();
            odeme = factory.GenerateInstance(odemeYontemiAdi);
            if (odeme != null)
            {
                odemeIslemi = new OdemeYontemi(odeme);
                lblSonuc.Text = odeme.OdemeIslemi(int.Parse(txtTutar.Text));
            }
            else
                lblSonuc.Text = $"{odemeYontemiAdi} ile odeme yontemi henuz eklenmemistir.";
            #endregion
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
