using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Solid.OdemeYontemleriKotuKod
{
    internal class MailOrderK
    {
        public bool MailOrderOdemeYapK(double tutar)
        {
            Console.WriteLine("mail order ile " + tutar + " tl odeme yapildi");
            return true;
        }
    }
}
