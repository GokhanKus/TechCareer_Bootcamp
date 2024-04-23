
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Solid.LoglamaYontemleriIyiKod
{
    internal class Logger
    {
        private readonly ILogger _logger;
        public Logger(ILogger logger)
        {
            _logger = logger;
        }
        public void KayitEtmeIslemi(string message)
        {
            _logger.LogKayit(message);
        }
    }
}
