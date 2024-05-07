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
        /*
        Factory Design Pattern, bir nesne oluşturma işlemini kolaylaştırır. Temel amacı, nesne oluşturma sürecini soyutlamak ve 
        istemcilerin spesifik bir sınıfı doğrudan oluşturmak yerine bir fabrika sınıfı aracılığıyla nesneleri oluşturmasına olanak tanımaktır.
        Bu, kodun daha esnek, bakımı daha kolay ve genişletmeye daha açık olmasını sağlar.
        */
        public IOdemeYontemi GenerateInstance(string className) //burasi static metot olabilir
        {
            var getType = Assembly.GetAssembly(typeof(IOdemeYontemi));
            var instance = (IOdemeYontemi)getType.CreateInstance("OdemeFormu.OdemeYontemleri." + className, true); //cmbboxtan secilen deger bir class ismi aslinda ve burada onun bir nesne ornegini olusturuyoruz.
            return instance;
        }
    }
}
