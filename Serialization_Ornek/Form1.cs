//using Newtonsoft.Json;
using Serialization_Ornek.Entities;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Serialization;

namespace Serialization_Ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnXmlSerialized_Click(object sender, EventArgs e)
        {
            var objectToSerialize = new Employee
            {
                Id = 1,
                FullName = txtAdSoyad.Text,
                Phone = txtTelefon.Text,
                Departman = txtDepartman.Text,
                Salary = int.Parse(txtMaas.Text),
                DoB = dtDogumTarihi.Value
            };
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Employee));
            FileStream stream = new FileStream("C:\\ASP.NET_Projects\\TechCareer_Bootcamp\\Serialization_Ornek\\XmlDosyasi\\employee.xml",
                FileMode.Create, FileAccess.Write, FileShare.None);
            try
            {
                using (stream)
                {
                    xmlSerializer.Serialize(stream, objectToSerialize);
                    lblSonuc.Text = "bilgiler serilize edildi";
                    txtAdSoyad.Text = "";
                    txtTelefon.Text = "";
                    dtDogumTarihi.Value = DateTime.Now;
                    txtDepartman.Text = "";
                    txtMaas.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("bir hata oldu: " + ex.Message);
            }
            finally { stream.Close(); }
        }

        private void btnXmlDeserialized_Click(object sender, EventArgs e)
        {
            var employee = new Employee();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Employee));
            FileStream fileStream = new FileStream("C:\\ASP.NET_Projects\\TechCareer_Bootcamp\\Serialization_Ornek\\XmlDosyasi\\employee.xml", FileMode.Open, FileAccess.Read, FileShare.None);
            try
            {
                using (fileStream)
                {
                    employee = xmlSerializer.Deserialize(fileStream) as Employee;
                    lblSonuc.Text = "bilgiler deserilize edildi";
                    txtAdSoyad.Text = employee.FullName;
                    txtTelefon.Text = employee.Phone;
                    dtDogumTarihi.Value = employee.DoB;
                    txtDepartman.Text = employee.Departman;
                    txtMaas.Text = employee.Salary.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("bir hata oldu: " + ex.Message);
            }
            finally { fileStream.Close(); }
        }

        private void btnJsonSerialized_Click(object sender, EventArgs e)
        {
            var objectToSerialize = new Employee
            {
                Id = 1,
                FullName = txtAdSoyad.Text,
                Phone = txtTelefon.Text,
                Departman = txtDepartman.Text,
                Salary = int.Parse(txtMaas.Text),
                DoB = dtDogumTarihi.Value
            };
            #region 1. yol kisa yontem
            //string jsonEmployee = JsonSerializer.Serialize(objectToSerialize); //using System.Text.Json; 
            //string jsonEmployee = JsonConvert.SerializeObject(objectToSerialize); //using Newtonsoft.Json;
            //File.WriteAllText("C:\\ASP.NET_Projects\\TechCareer_Bootcamp\\Serialization_Ornek\\JsonDosyasi\\employee.json", jsonEmployee);
            #endregion

            #region 2. yol uzun yontem
            FileStream fileStream = new FileStream("C:\\ASP.NET_Projects\\TechCareer_Bootcamp\\Serialization_Ornek\\JsonDosyasi\\employee.json", FileMode.Create, FileAccess.Write, FileShare.None);
            try
            {
                using (fileStream)
                {
                    JsonSerializer.Serialize(fileStream, objectToSerialize);
                    lblSonuc.Text = "Bilgiler Serialize Edildi";
                    txtAdSoyad.Text = "";
                    txtTelefon.Text = "";
                    dtDogumTarihi.Value = DateTime.Now;
                    txtDepartman.Text = "";
                    txtMaas.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("bir hata oldu: " + ex.Message);
            }
            finally
            {
                fileStream.Close();
            }
            #endregion
        }

        private void btnJsonDeserialized_Click(object sender, EventArgs e)
        {
            var emp = new Employee();
            FileStream fileStream = new FileStream("C:\\ASP.NET_Projects\\TechCareer_Bootcamp\\Serialization_Ornek\\JsonDosyasi\\employee.json", FileMode.Open, FileAccess.Read, FileShare.None);
            try
            {
                using (fileStream)
                {
                    emp = JsonSerializer.Deserialize<Employee>(fileStream);
                    lblSonuc.Text = "bilgiler Deserilize edildi";
                    //lblSonuc.Visible = true;
                    txtAdSoyad.Text = emp.FullName;
                    txtTelefon.Text = emp.Phone;
                    dtDogumTarihi.Value = emp.DoB;
                    txtDepartman.Text = emp.Departman;
                    txtMaas.Text = emp.Salary.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("bir hata oldu: " + ex.Message);
            }
            finally
            {
                fileStream.Close();
            }

        }
    }
}
