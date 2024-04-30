using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OdemeFormu.OdemeYontemleri
{
    internal class OdemeIslemiFactory
    {
        public IOdemeYontemi GenerateInstance(string className)
        {
            var getType = Assembly.GetAssembly(typeof(IOdemeYontemi));
            var instance = (IOdemeYontemi)getType.CreateInstance("OdemeFormu.OdemeYontemleri." + className, true); //cmbboxtan secilen deger bir class ismi aslinda ve burada onun bir nesne ornegini olusturuyoruz.
            return instance;
        }
    }
}
