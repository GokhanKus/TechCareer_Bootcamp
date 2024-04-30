using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemeFormu.OdemeYontemleri
{
    internal class MailOrder: IOdemeYontemi
    {
        public string OdemeIslemi(int tutar)
        {
            return $"MailOrder ile {tutar} tutarinda odeme yapildi";
        }
    }
}
