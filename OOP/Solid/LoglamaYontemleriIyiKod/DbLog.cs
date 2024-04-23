using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Solid.LoglamaYontemleriIyiKod
{
    internal class DbLog : ILogger
    {
        public void LogKayit(string message)
        {
            Console.WriteLine($"db log: {message}");
        }
    }
}
