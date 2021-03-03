using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi: " + musteri.Adi + musteri.Soyadi + musteri.HesapNo);
        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi"+musteri.Id+ musteri.Adi + musteri.Soyadi + musteri.HesapNo);
        }

        public void List(Musteri[] musteriler)
        {
            foreach (var m in musteriler)
            {
                Console.WriteLine("Müşteriler listelendi: " + m.Adi + m.Soyadi + m.HesapNo);
            }
        }
    }
}
