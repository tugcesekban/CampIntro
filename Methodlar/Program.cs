using System;

namespace Methodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(); // bir class tanımlamak için yapılmalı. Class'ın örneği
            product1.Adi = "elma";
            product1.Fiyati = 10;
            product1.Aciklama = "Amasya Elması";

            Product product2 = new Product();
            product2.Adi = "karpuz";
            product2.Fiyati = 50;
            product2.Aciklama = "Diyarbakır Karpuzu";

            Product[] products = new Product[] { product1 , product2};

            //type-safe
            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("-----------------");
            }

            Console.WriteLine("---------------Methodlar-------");

            //instance
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);
            sepetManager.Ekle2("mango", "tropikal mango", 15,18);
            sepetManager.Ekle2("muz", "Antalya Muz", 19,22);
        }

    }
}
