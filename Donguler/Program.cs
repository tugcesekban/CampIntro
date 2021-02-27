using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] kurslar = new string[] {"Yazılım Kursu", "Programlama Kursu", "Java", "Phyton", "Kotlin", "C#", "C++" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);

            }
            Console.WriteLine("Form bitti");


            foreach (string kurs in kurslar) //tercih daha yüksek
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("Sayfa Sonu");
        }
    }
}
