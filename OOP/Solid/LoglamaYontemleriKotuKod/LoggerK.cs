using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Solid.LoglamaYontemleriKotuKod
{
    internal class LoggerK
    {
        private readonly XmlLogK _logK;
        private readonly TextLogK _textLogK;
        public LoggerK(XmlLogK logK, TextLogK textLogK)
        {
            _logK = logK;
            _textLogK = textLogK;
        }
        public void KayitEt(LogTypeK type, string message)
        {
            switch (type)
            {
                case LogTypeK.XmlLog:
                    _logK.XmlIleMesajiYazdir(message);
                    break;
                case LogTypeK.TextLog:
                    _textLogK.TextIleMesajiYazdir(message);
                    break;

                default:
                    break;
            }
        }
    }
}
