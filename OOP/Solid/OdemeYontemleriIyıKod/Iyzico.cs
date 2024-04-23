using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Solid.OdemeYontemleriIyıKod
{
    internal class Iyzico:IOdemeType
    {
        public bool OdemeYap(int tutar)
        {
            Console.WriteLine($"Iyzico ile {tutar} tl tutarinda odeme yapildi");
            return true;
        }
    }
}
