using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeOrnek.Attributes
{
    //interited false olursa mesela insan class'inda attributeyi yazdık. ogrenci.cs : insan.cs kalitimi yaparsak ogrenci classi o attributeyi kullanamaz, kullanmak istersek interited = true..
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    internal class RequiredFieldAttribute : Attribute
    {

    }
}
