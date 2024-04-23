using OOP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classes
{
    public abstract class Calisan : ICalisan
    {
        public string Adi{ get; set; }
        public string Soyadi{ get; set; }
        public string FullIsmi => $"{Adi} {Soyadi}";
        public string Departmani{ get; set; }
        public int CalisaninMaasi(int maas)
        {
            return maas;
        }
    }
}
