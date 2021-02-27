using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
          

            Kurs kurs1 = new Kurs();
            kurs1.egitmen = "tugce";
            kurs1.kursAdi = "yazilim";
            kurs1.izlenmeOrani = 34;

            Kurs kurs2 = new Kurs();
            kurs2.egitmen = "lamis";
            kurs2.kursAdi = "kimya";
            kurs2.izlenmeOrani = 35;

            // Console.WriteLine(kurs1.egitmen + ":" + kurs1.kursAdi);

            Kurs[] kurslar = new Kurs[]{ kurs1, kurs2 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.egitmen + ":" + kurs.kursAdi);
            }

       //     Console.WriteLine("Hello World!");
        }
    }
    class Kurs
    {
        public string kursAdi { get; set; }
        public string egitmen { get; set; }
        public int izlenmeOrani { get; set; }
    }
}
