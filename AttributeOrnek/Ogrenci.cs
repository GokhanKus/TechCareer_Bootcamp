using AttributeOrnek.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeOrnek
{
    internal class Ogrenci
    {
        [RequiredField]
        public string Adi { get; set; }

        [RequiredField]
        public string Soyadi { get; set; }

        [RequiredField]
        public string Bolumu { get; set; }
    }
}
