using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemeFormu.OdemeYontemleri
{
    internal class OdemeYontemi
    {
        private readonly IOdemeYontemi _odemeYontemi;
        public OdemeYontemi(IOdemeYontemi odemeYontemi)
        {
            _odemeYontemi = odemeYontemi;
        }
        //public string Ode(int tutar) //burasi Open Closed ve Reflection icin kullaniliyordu, factory design ile burasi yok artik.
        //{
        //    return _odemeYontemi.OdemeIslemi(tutar);
        //}
    }
}
