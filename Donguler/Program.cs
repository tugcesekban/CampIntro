using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            Product product = new Product { Id = 1, ProductName = "Dress", ProductPicture = "Picture1", CategoryId = 1, Price = 55, UnitsInStock = 4 };
            Product product2 = new Product { Id = 2, ProductName = "Suit", ProductPicture = "Picture2", CategoryId = 2, Price = 145, UnitsInStock = 6 };

            Product[] products = new Product[] { product, product2 };
            Console.WriteLine("--------Foreach ile------------");
            foreach (var p in products)
            {
                Console.WriteLine("Ürün Id'si-" + " " + p.Id +" "+ p.ProductName+ " "+ p.ProductPicture + " " +"Ürün Stok Miktarı-" + " "+ p.UnitsInStock+ " " + "Ürün fiyatı-" + " "+ p.Price + " "+ "Ürün kategori id'si-" + " " + p.CategoryId);
            }
            Console.WriteLine("--------For ile------------");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("Ürün Id'si-" + " "+  products[i].Id + " " + products[i].ProductName + " "+ products[i].ProductPicture+ " "  +"Ürün Stok Miktarı-" + " " + products[i].UnitsInStock +" "+ "Ürün fiyatı-" + " " + products[i].Price+" " + "Ürün kategori id'si-" + " " + products[i].CategoryId);
            }

            Console.WriteLine("--------While ile------------");
            int n = 0;
            while (n < products.Length)
            {
                Console.WriteLine("Ürün Id'si-" + " "+ products[n].Id + " " + "Ürün kategori id'si-" + " " + products[n].CategoryId + " " + products[n].ProductName + " " + products[n].ProductPicture+ " " +"Ürün Stok Miktarı -" + " " + products[n].UnitsInStock +" " + "Ürün fiyatı-" + " " + products[n].Price);
                n++;
            }
        }


        //        string[] kurslar = new string[] {"Yazılım Kursu", "Programlama Kursu", "Java", "Phyton", "Kotlin", "C#", "C++" };

        //        for (int i = 0; i < kurslar.Length; i++)
        //        {
        //            Console.WriteLine(kurslar[i]);

        //        }
        //        Console.WriteLine("Form bitti");


        //        foreach (string kurs in kurslar) //tercih daha yüksek
        //        {
        //            Console.WriteLine(kurs);
        //        }
        //        Console.WriteLine("Sayfa Sonu");
        //    }
    

        class Product
        {
            public int Id { get; set; }
            public int CategoryId { get; set; }
            public string ProductName { get; set; }
            public string ProductPicture { get; set; }
            public decimal Price { get; set; }
            public short UnitsInStock { get; set; }


        }
    }
}
