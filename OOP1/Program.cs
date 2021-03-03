using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.ProductName = "Masa";
            product1.CategoryId = 2;
            product1.UnitPrice = 550;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id = 2, CategoryId=6,ProductName = "Kalem", UnitPrice=35, UnitsInStock=4 };

            //PascalCase // camelCase
            //case sensitive

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

            //productManager.Topla2(3, 12);

            //int toplamSonucu = productManager.Topla(5, 13);
            //Console.WriteLine(toplamSonucu*3);
        }
    }
}
