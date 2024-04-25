using AttributeOrnek.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci { Adi = "Gokhan", Soyadi = "Kus", Bolumu = "Bilg. Muh." };
            Ogrenci ogrenci2 = new Ogrenci { Adi = "Deniz", Soyadi = "Damla" };
            //eger attribute yazmasaydik, o class'a ait her property icin null kontrolu ve olusturulan her nesne icin aynı null kontrollerini tekrar tekrar yapmak zorunda olurduk.
            //if(ogrenci1.Adi ==null||ogrenci1.Soyadi==null||ogrenci1.Bolumu == null) { }
            //if(ogrenci2.Adi ==null||ogrenci2.Soyadi==null||ogrenci2.Bolumu == null) { }

            if (RequiredFieldCheck.Verify(ogrenci2))
                Console.WriteLine("ogrenci bilgilerin hepsi girildi");

            else
                Console.WriteLine("ogrenci bilgilerinin hepsi girilmedi");
        }
    }
}
