using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler = new List<string> {"Ali", "Berk", "Can" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            isimler.Add("Deniz");
            Console.WriteLine(isimler[3]);

        }
    }
}
