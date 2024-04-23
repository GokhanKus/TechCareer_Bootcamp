using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Reflections
{
    internal class MyReflectionClass
    {
        private int _x, _y;
        public string MyProp{ get; set; }
        public MyReflectionClass(int x, int y)
        {
            _x = x;
            _y = y;
        }
        private void MesajGoster()
        {
            Console.WriteLine($"mesaj for: {_x} {_y}");
        }
        public void MesajDon()
        {
            Console.WriteLine("MesajDon metodu");
        }
        public int Toplam()
        {
            return _x + _y;
        }
        internal int SayilariCarp(int a,int b,int c)
        {
            return a * b * c;
        }
        public bool Sifirmi(int z)
        {
            if (z == 0) return true;
            return false;
        }
        public ClassExample Example()
        {
            return new ClassExample { sayi1 = 10, metin1 = "string metin..." };
        }
    }
}
