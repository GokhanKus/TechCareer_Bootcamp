using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Solid.OdemeYontemleriKotuKod
{
    internal class KrediKartiK
    {
        public bool KrediKartiOdemeYapK(double tutar)
        {
            Console.WriteLine("kredi karti ile " + tutar + " tl odeme yapildi");
            return true;
        }
    }
}
