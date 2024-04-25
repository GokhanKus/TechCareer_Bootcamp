using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Heap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Array&ArrayList
            /*
            Arraylist farklı veri tiplerindeki verilerin koleksiyon olarak depolandigi bir veri yapısıdır.(Nesnelerin referanslarini depolar)
            Dinamik boyuta sahiptir, yani elemanlar eklendikce veya cikarildikca boyutu otomatik olarak ayarlanir.
            veri türü olarak object kullanildigindan veri guvenligi(type safety) riski tasir ve boxing/unboxing islemleri perf. kaybina neden olabilir, maliyetlidir  
            
            Arrayler, tek bir veri turunde verileri depolayabilir ve sabit boyutludur
            Array bellek yonetimi ve erisim hızı acisindan avantajlıdır, ancak boyutu onceden belirlendigi icin esnek degildir.
             */
            int[] numbers = { 3, 5, 7 };

            ArrayList array = new ArrayList { 3, 7.5, "a", "b", true, new List<int> { 24, 5 }, numbers, 2, 7, 227 };
            array.Add(5.5);//Boxing: Değer türündeki değişkenler ArrayList'e eklenirken object türüne dönüştürülür.
            //array.Sort();
            int sayi1 = (int)array[0];//goruldugu uzere Unboxing islemi yapiliyor cunku Arraylistin boxing'leyerek yani object turunde verileri sakladigini soylemistik
            string word1 = (string)array[3];

            List<object> list = new List<object>() { 2, 52, 2, 55, "as", "b", true, numbers };
            list.Add(5.5);//Herhangi bir dönüşüm yapılmaz, int değer doğrudan eklenebilir, cunku List<object> zaten object türünde elemanları saklayacak şekilde tanımlanmıştır.
                          //list.Sort();
            int sayi2 = (int)list[0];
            bool bool1 = (bool)list[6];
            #endregion

            #region ArrayList & list<object> Fark
            /*
			modern C# kodlamada List<T> (generic liste) tercih edilirken, ArrayList daha eski kod tabanlarında veya eski framework versiyonlarında kullanilirdi.
            List<>'te LINQ kullanilabilirken; arraylistte yapamazsin
			 */
            #endregion

            #region Boxing & Unboxing

            object o1 = 6;
            int sayi3 = (int)o1; //unboxing (object'ten int'e), referans turunden deger turune donusum.
            int sayi4 = 10;
            object o2 = sayi4;   //boxing (int'ten object'e) deger turunden referans turune donusum.

            #endregion
        }
    }
}
