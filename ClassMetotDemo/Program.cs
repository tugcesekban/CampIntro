using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Akın";
            musteri1.Soyadi = "Deniz";
            musteri1.HesapNo = 34455455;



            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Aslı";
            musteri2.Soyadi = "Demir";
            musteri2.HesapNo = 4546566;


            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Pelin";
            musteri3.Soyadi = "Nehir";
            musteri3.HesapNo = 8797979;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Delete(musteri3);
            musteriManager.List(musteriler);

        }
    }
}
