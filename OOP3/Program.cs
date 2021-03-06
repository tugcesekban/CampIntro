using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager(); // IKrediManager'de o interface'i imp eden class'ın referans num. tutabiliyor.
            TasitKrediManager tasitKrediManager = new TasitKrediManager();

            DatabaseLoggerService databaseLoggerService = new DatabaseLoggerService();
            FileLoggerService fileLoggerService = new FileLoggerService();

            //   List<ILoggerService> loggerServices = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService()};


            BasvuruManager basvuruManager = new BasvuruManager();
            //    basvuruManager.BasvuruYap(tasitKrediManager, loggerServices); // 2.YOL: Yukarıdaki List<ILoggerService> devamı
            basvuruManager.BasvuruYap(tasitKrediManager, new List<ILoggerService> { new DatabaseLoggerService(), new SmsLoggerService() }); // new lenerek de oluşturulur     


            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager };

            //     basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
