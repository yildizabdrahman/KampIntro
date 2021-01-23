using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DatabesLoggerService : IloggerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı");
        }
    }
}
