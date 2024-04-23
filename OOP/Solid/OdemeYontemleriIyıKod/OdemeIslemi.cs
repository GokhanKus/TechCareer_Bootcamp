using OOP.Solid.OdemeYontemleriIyıKod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Solid.OdemeYontemleriKotuKod
{
    internal class OdemeIslemi
    {
        private readonly IOdemeType _odemeType;
        public OdemeIslemi(IOdemeType odemeType)
        {
            _odemeType = odemeType;
        }
        public void OdemeYap(int tutar)
        {
            _odemeType.OdemeYap(tutar);
        }
    }
}
