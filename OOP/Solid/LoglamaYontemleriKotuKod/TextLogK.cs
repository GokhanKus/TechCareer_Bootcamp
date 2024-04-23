using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Solid.LoglamaYontemleriKotuKod
{
    internal class TextLogK
    {
        public string TextIleMesajiYazdir(string message)
        {
            string mesaj = $"text message: {message}";
            Console.WriteLine(mesaj);
            return mesaj;
        }
    }
}
