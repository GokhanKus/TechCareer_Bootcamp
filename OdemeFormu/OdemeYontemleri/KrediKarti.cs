using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemeFormu.OdemeYontemleri
{
    internal class KrediKarti: IOdemeYontemi
    {
        public string OdemeIslemi(int tutar)
        {
            return $"KrediKarti ile {tutar} tutarinda odeme yapildi";
        }
    }
}
