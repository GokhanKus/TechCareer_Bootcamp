using OOP.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calisan[] calisanlar =
            {
                new GenelMudur{Adi = "Hakan", Soyadi = "Demir",Departmani = "Genel Mudur"},
                new Mudur{Adi = "Ayse", Soyadi = "Ozdemir",Departmani = "Mudur"},
                new Stajyer{Adi = "Gokay", Soyadi = "Celik",Departmani = "Stajyer"},
                new Programci{Adi = "Gokhan", Soyadi = "Kus",Departmani = "Programci"}
            };
            int maasToplami = 0;
            foreach (var calisan in calisanlar)
            {
                Console.WriteLine($"{calisan.FullIsmi} - {calisan.Departmani} - {calisan.Maasi()}");
                maasToplami += calisan.Maasi();
            }
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("calisanlarin maas toplami" + " " + maasToplami);
        }
    }
}
