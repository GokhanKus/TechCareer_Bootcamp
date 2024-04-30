using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numerik.Islemler.HesaplamaIslemleri
{
    public class Matematik //class ve metotlar public, cunku bu bir dll olacak yani kütüphane, using ile baska projelerde kullanilacak.
    {
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int Cikart(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
        public double Bol(int sayi1, int sayi2)
        {
            if (sayi2 != 0)
            {
                return (double)sayi1 / sayi2;
            }
            throw new DivideByZeroException("0'a bolunme hatasi");
        }
        public double UstelFonksiyon(double sayi1, double sayi2) //2 5 = 2.2.2.2.2
        {
            if (sayi1 == 0 && sayi2 == 0)
            {
                throw new Exception("0 uzeri 0 tanimsiz.");
            }
            if (sayi2 == 0)
            {
                return 1;
            }
            else if (sayi2 > 0) // ornegin 3 uzeri 5
            {
                double sayi = 1;
                while (sayi2 != 0)
                {
                    sayi *= sayi1;
                    sayi2--;
                }
                return sayi;
            }
            else //orn 3 uzeri -5
            {
                double sayi = 1;
                sayi1 = 1 / sayi1;
                while (sayi2 != 0)
                {
                    sayi *= sayi1;
                    sayi2++;
                }
                return sayi;
            }
        }
    }
}
