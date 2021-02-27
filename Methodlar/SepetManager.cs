using System;
using System.Collections.Generic;
using System.Text;

namespace Methodlar
{
    class SepetManager
    {
        public void Ekle(Product product)
        {
            Console.WriteLine("Sepete eklendi" + product.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Sepete eklendi" + urunAdi);
        }
    }
}
