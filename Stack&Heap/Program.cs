using Microsoft.Win32;
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

            #region Stack & Heap

            /*
			Stack ve heap ram uzerinde olan 2 alandır stack alaninda yerel degiskenler(int, byte, double vs..) saklanirken;		  Stack ==> Statik yapi (genisletilemez, sabit)
			Heapte ise büyük veri yapılarının veya nesneler saklanir (orn class'tan birr nesne olusturulunca o nesnenin verileri, objects, dynamic, Strings, class, delegate..) Heap  ==> Dinamik yapi (esnek yapida genisletilebilir)
			User u1 = new User1() dedigimizde Heap'te bu saklanirken Stack bolgesinde u1 adinda 534634 gibi bir ref numarasiyla heapteki o bolgeyi isaret eder
			
			Stack, programın çalışma zamanında derleyicinin yönettiği ve kullandığı bellek alanıdır.
			Stack ve heap, bellek yönetimiyle ilgili terimlerdir ve programın çalışma zamanında bellekte veri depolamanın farklı yollarını ifade ederler.
			Stack, son giren ilk çıkar (LIFO - Last In, First Out) mantığına göre çalışır. ust uste biriken bulasık tabaklar ornek olarak verilebilir
			Stack, Bellek alanı, compile-time'da tahsis edilir ve belirlenen bir boyutta sabittir.

			Heap, programın çalışma zamanında dinamik olarak tahsis edilen bellek alanıdır.
			Heap, özellikle nesnelerin ve büyük veri yapılarının saklanması için kullanılır.
			Bellek yönetimi programcı tarafından yapılır ve bellekten ayrılmış alanlar işaretçiler (pointers) ile yönetilir.
			Heap, kullanılan bellek miktarına bağlı olarak büyüyebilir veya küçülebilir.
            */

            //primitive(ilkel, basit), static, deger tipli(referans tipli değil) a ve b degerleri farklı, stack'te saklanir.
            int a = 5;
            int b = a;
            a = 10;
            Console.WriteLine($"a: {a}, b: {b}");

            //non primitive, referans tipli dizi1 ve dizi2 degerleri ayni, dizi2[0] degeri de 100 oldu
            int[] dizi1 = { 1, 2, 3, 4, 5, 6 };
            int[] dizi2 = dizi1;
            dizi1[0] = 100;
            Console.WriteLine("Dizi1\t\tDizi2");
            for (int i = 0; i < dizi1.Length; i++)
            {
                Console.Write($"{dizi1[i]}\t\t{dizi2[i]}\n");
            }
            //baska bir ornek: u2'nin adi ve soyadinin da degistigini gorecegiz; cunku u2, u1'in bellekteki konumunu isaret eder
            User u1 = new User { Adi = "Irmak", Soyadi = "Deniz" };
            User u2 = u1;
            u1.Adi = "Okyanus"; u1.Soyadi = "Su";
            Console.WriteLine($"u1 adi: {u1.Adi}, u1 soyadi: {u1.Soyadi} \nu2 adi: {u2.Adi}, u2 soyadi: {u2.Soyadi}");
            #endregion

            #region Stack, Queue
            /*
            Stack, çağrı yığını(call stack) gibi senaryolarda kullanılır.
            Queue, işlem kuyrukları(task queue) gibi senaryolarda kullanılır.
            */
            Stack stack = new Stack();
            stack.Push("gokhan");
            stack.Push("is");
            stack.Push("name");
            stack.Push("my");
            stack.Push("hello");
            //stack.Pop(); //son eklenen deger kaldirilir("hello")
            string metin1 = "";
            while (stack.Count > 0)
            {
                metin1 += stack.Pop() + " ";
            }
            Console.WriteLine(metin1);

            Console.WriteLine("------------");

            Queue queue = new Queue();
            queue.Enqueue("hello");
            queue.Enqueue("my");
            queue.Enqueue("name");
            queue.Enqueue("is");
            queue.Enqueue("gokhan");
            //queue.Dequeue();//ilk eklenen deger kaldirilir ("hello")
            string metin2 = "";
            while (queue.Count > 0)
            {
                metin2 += queue.Dequeue() + " ";
            }
            Console.WriteLine(metin2);
            #endregion

            #region HashTable, Dictionary, LinkedList

            Hashtable ht = new Hashtable();
            ht.Add(1, "bir");
            ht.Add("bir", "one");
            ht.Add("one", "uno");
            ht.Add("uno", 1);

            //Bu da heap'e ornek verilebilir; non primitive, referans tipli, generic1 ve generic2 degerleri ayni
            Dictionary<int, string> dic1 = new Dictionary<int, string>();
            dic1.Add(1, "bir");
            dic1.Add(2, "iki");
            dic1.Add(3, "uc");
            dic1.Add(4, "dort");

            Dictionary<int, string> dic2 = dic1;
            dic1.Add(5, "bes");
            dic1[1] = "yuz";    //key degeri 1 olan deger varsa yuz olarak degistir yoksa keyi 1 olan value'si "yuz" olan yeni deger ekle


            //Bu da heap'e ornek verilebilir; non primitive, referans tipli, generic1 ve generic2 degerleri ayni
            LinkedList<int> generic1 = new LinkedList<int>();
            for (int i = 0; i < 5; i++)
            {
                generic1.AddFirst(i);
            }

            //LinkedListler, bir diziye göre daha dinamik bir yapı sunar çünkü her eleman, kendisinden önceki ve sonraki elemanın referansını içerir
            LinkedList<int> generic2 = generic1;
            LinkedListNode<int> node = generic1.First;
            node.Value = 100;

            #endregion
        }
    }
}
