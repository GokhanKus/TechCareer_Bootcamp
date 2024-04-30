using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapFormu.Entity
{
    public class Yazar
    {
        public int Id { get; set; }
        public string YazarAdi { get; set; } = "Yazar ad";
        public string YazarSoyadi { get; set; } = "Yazar soyad";
        public string YazarAdSoyad { get; set; }
             //=> $"{YazarAdi} {YazarSoyadi}";
    }
}
