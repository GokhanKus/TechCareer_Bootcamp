﻿using OOP.Solid.OdemeYontemleriIyıKod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Solid.OdemeYontemleriKotuKod
{
    internal class MailOrder:IOdemeType
    {
        public bool OdemeYap(int tutar)
        {
            Console.WriteLine("Mail order ile " + tutar + " tl odeme yapildi");
            return true;
        }
    }
}
