using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Solid.OdemeYontemleriKotuKod
{
    internal class OdemeIslemiK
    {
        private KrediKartiK _krediKartiK;
        private MailOrderK _mailOrderK;
        public OdemeIslemiK(KrediKartiK krediKartiK, MailOrderK mailOrderK)
        {
            _krediKartiK = krediKartiK;
            _mailOrderK = mailOrderK;
        }
        public void OdemeYapK(OdemeTypeK type, double tutar)
        {
            switch (type)
            {
                case OdemeTypeK.KrediKartiK:
                    _krediKartiK.KrediKartiOdemeYapK(tutar);
                    break;
                case OdemeTypeK.MailOrderK:
                    _mailOrderK.MailOrderOdemeYapK(tutar);
                    break;
                default:
                    Console.WriteLine("hata..");
                    break;
            }
        }
    }
}
