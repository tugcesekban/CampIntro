using System;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety: tip güvenliği
            //değer tutucu :category
            string categorylabel = "categorisi";
            int ogrenciSayisi = 4500;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            Console.WriteLine(categorylabel);




            double dolarBugun = 7.45;
            double dolarDun = 7.35;

            if (dolarBugun> dolarDun)
            {
                Console.WriteLine("Dolar artış");
            }
            else if (dolarBugun < dolarDun)
            {
                Console.WriteLine("Dolar azalış");
            }
            else
            {
                Console.WriteLine("Dolar değişmedi");
            }




            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Kullanıcı Ayarlar butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }
        }
    }
}
