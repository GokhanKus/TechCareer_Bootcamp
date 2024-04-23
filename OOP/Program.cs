﻿using OOP.Classes;
using OOP.Solid.LoglamaYontemleriIyiKod;
using OOP.Solid.LoglamaYontemleriKotuKod;
using OOP.Solid.OdemeYontemleriIyıKod;
using OOP.Solid.OdemeYontemleriKotuKod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region OOP - 1
            //Calisan[] calisanlar =
            //{
            //    new GenelMudur{Adi = "Hakan", Soyadi = "Demir",Departmani = "Genel Mudur"},
            //    new Mudur{Adi = "Ayse", Soyadi = "Ozdemir",Departmani = "Mudur"},
            //    new Stajyer{Adi = "Gokay", Soyadi = "Celik",Departmani = "Stajyer"},
            //    new Programci{Adi = "Gokhan", Soyadi = "Kus",Departmani = "Programci"}
            //};
            //int maasToplami = 0;
            //foreach (var calisan in calisanlar)
            //{
            //    Console.WriteLine($"{calisan.FullIsmi} - {calisan.Departmani} - {calisan.Maasi()}");
            //    maasToplami += calisan.Maasi();
            //}
            //Console.WriteLine(new string('-', 50));
            //Console.WriteLine("calisanlarin maas toplami" + " " + maasToplami);
            #endregion

            #region Solid(Open Closed Kotu Kod) 1
            OdemeIslemiK odeme1 = new OdemeIslemiK(new KrediKartiK(),new MailOrderK());
            odeme1.OdemeYapK(OdemeTypeK.KrediKartiK,2555);

            #endregion

            #region Solid(Open Closed Iyi Kod) 1
            OdemeIslemi odeme2 = new OdemeIslemi(new KrediKarti());
            OdemeIslemi odeme3 = new OdemeIslemi(new Iyzico());
            OdemeIslemi odeme4 = new OdemeIslemi(new MailOrder());
            odeme2.OdemeYap(555);
            odeme3.OdemeYap(111);
            odeme4.OdemeYap(222);
            #endregion

            #region Solid(Open Closed Kotu Kod) 2
            LoggerK kayit1 = new LoggerK(new XmlLogK(), new TextLogK());
            kayit1.KayitEt(LogTypeK.TextLog, "text log icin mesaj");
            #endregion

            #region Solid(Open Closed Iyi Kod) 2
            Logger kayit2 = new Logger(new XmlLog()); 
            Logger kayit3 = new Logger(new DbLog()); 
            Logger kayit4 = new Logger(new TextLog());
            kayit2.KayitEtmeIslemi("mesaj1");
            kayit3.KayitEtmeIslemi("mesaj2");
            kayit4.KayitEtmeIslemi("mesaj3");
            #endregion

        }
    }
}
