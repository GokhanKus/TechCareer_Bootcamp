using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization_Ornek.Entities
{
    public class Product
    {
        public string Name { get; set; }
        public DateTime ExpiryDate { get; set; }
        public double Price { get; set; }
    }
}
