using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            //TasitKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();


            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            BasvuruManager basvuruManager = new BasvuruManager();
            ILoggerService fileLoggerService = new FileLoggerService();

            Console.WriteLine("\n******************Tasit + File*********************");
            basvuruManager.BasvuruYap(tasitKrediManager, new List<ILoggerService>{fileLoggerService});

            Console.WriteLine("\n******************Konut + Database/Sms*********************");
            basvuruManager.BasvuruYap(konutKrediManager, new List<ILoggerService> {new DatabaseLoggerService(), new SmsLoggerService()});//böyle içeride de new'leyebiliyoruz

            Console.WriteLine("\n*******************Esnaf + SMS********************");
            basvuruManager.BasvuruYap(new EsnafKrediManager(), new List<ILoggerService>{new SmsLoggerService()});

            Console.WriteLine("\n******************Ihtiyac/Tasit/Konut*********************");
            List<IKrediManager> krediler = new List<IKrediManager> {ihtiyacKrediManager, tasitKrediManager, konutKrediManager};
            basvuruManager.KrediOnBilgilendirmesiYap(krediler);

            Console.WriteLine("\n*****************Konut + File/Database/Sms**********************");
            List<ILoggerService> loggers = new List<ILoggerService> {fileLoggerService, new DatabaseLoggerService(), new SmsLoggerService()};
            basvuruManager.BasvuruYap(konutKrediManager, loggers);
        }
    }
}
