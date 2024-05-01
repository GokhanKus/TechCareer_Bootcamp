using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization_Ornek.Entities
{
    //[Serializable]//.NET Core 3.0 ve üzeri surumlerde artık bu attr'yi kullanmaya gerek yok. Json veya xml vs.. formatinda yine serialize ve deserialize islemlerini yapabiliyoruz.
    public class Employee //public olmazsa serilize islemi olmuyor
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Departman { get; set; }
        public DateTime DoB { get; set; }
        public int Salary{ get; set; }

        [NonSerialized]
        public string additionalInfo;
    }
}
