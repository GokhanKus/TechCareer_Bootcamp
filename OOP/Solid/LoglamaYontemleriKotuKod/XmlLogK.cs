using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Solid.LoglamaYontemleriKotuKod
{
    internal class XmlLogK
    {
        public string XmlIleMesajiYazdir(string message)
        {
            string mesaj = $"xml message: {message}";
            Console.WriteLine(mesaj);
            return mesaj;
        }
    }
}
