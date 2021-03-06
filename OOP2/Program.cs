using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "65655";
            musteri1.Adi = "Ali";
            musteri1.Soyadi = "Veli";
            musteri1.Id = 1;
            musteri1.TCNo = "12345678901";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.MusteriNo = "33444";
            musteri2.Id = 2;
            musteri2.SirketAdi = "Kodlama";
            musteri2.VergiNo = "343455";


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri3);
            musteriManager.Add(musteri4);
        }
    }
}
