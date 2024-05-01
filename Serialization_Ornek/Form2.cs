using Newtonsoft.Json;
using Serialization_Ornek.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serialization_Ornek
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnJsonSerialize_Click(object sender, EventArgs e)
        {
            Product product1 = new Product
            {
                Name = "Toblerone",
                ExpiryDate = new DateTime(2025, 12, 30),
                Price = 250
            };
            #region 1.yontem (uzun)
            JsonSerializer jsonSerializer = new JsonSerializer();//Form1'deki JsonSerializer'dan farklı olarak bu newtonsoft.json kullaniyor
            using (StreamWriter streamWriter = new StreamWriter("C:\\ASP.NET_Projects\\TechCareer_Bootcamp\\Serialization_Ornek\\JsonDosyasi\\product.json"))
            {
                using (JsonWriter jsonWriter = new JsonTextWriter(streamWriter))
                {
                    jsonSerializer.Serialize(streamWriter, product1);
                    lblSonuc.Text = "serilize islemi yapildi";
                }
            }
            #endregion

            #region 2.yontem kisa

            //try
            //{
            //    string jsonString = JsonConvert.SerializeObject(product1);
            //    File.WriteAllText("C:\\ASP.NET_Projects\\TechCareer_Bootcamp\\Serialization_Ornek\\JsonDosyasi\\product.json", jsonString);
            //    lblSonuc.Text = "serilize islemi yapildi";
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Dosya yazma hatası: " + ex.Message);
            //}

            #endregion
        }

        private void btnJsonDeserialize_Click(object sender, EventArgs e)
        {
            #region 1.yontem(uzun)
            JsonSerializer jsonSerializer = new JsonSerializer(); //newtonsofta ait olan jsonserializer
            using (StreamReader streamReader = new StreamReader("C:\\ASP.NET_Projects\\TechCareer_Bootcamp\\Serialization_Ornek\\JsonDosyasi\\product.json"))
            {
                using (JsonReader jsonReader = new JsonTextReader(streamReader))
                {
                    Product product1 = (Product)jsonSerializer.Deserialize(jsonReader, typeof(Product));
                    MessageBox.Show($"{product1.Name}, {product1.ExpiryDate}, {product1.Price}");
                }
            }

            #endregion

            #region 2.yontem(kisa)
            //try
            //{
            //    string jsonString = File.ReadAllText("C:\\ASP.NET_Projects\\TechCareer_Bootcamp\\Serialization_Ornek\\JsonDosyasi\\product.json");
            //    var product1 = JsonConvert.DeserializeObject<Product>(jsonString);
            //    MessageBox.Show($"{product1.Name}, {product1.ExpiryDate}, {product1.Price}");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Dosya yazma hatası: " + ex.Message);
            //}
            #endregion
        }
    }
}
