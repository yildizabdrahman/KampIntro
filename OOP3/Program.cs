using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager esnafKrediManager = new EsnafKredisiManager();

            IloggerService databaseLoggerService = new DatabesLoggerService();
            IloggerService fileLoggerService = new FileLoggerService();
            IloggerService smsLoggerService = new SmsLoggerService();

            List<IloggerService> loggers = new List<IloggerService>() { fileLoggerService, smsLoggerService };
            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(esnafKrediManager,loggers);


            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager, konutKrediManager};
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

           
        }
    }
}
