using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";


            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";


            Product[] urunler = new Product[] { urun1, urun2 };

            //Type-safe -- tip güvenli
            foreach (Product urun in urunler)
            {

                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------------------------");

            }

            Console.WriteLine("-----------------Methods-----------------");

            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            Console.WriteLine("----------------------------");

            sepetManager.Ekle2("Armut", "Yeşil armut",12,10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12,9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12,8);




        }
    }
}




// Methotlar Tekrar tekrar kullanılabilirliği sağlayan bir otam sunar...
// Do not repeat yourself...  DRY - Clean Code - Best Practice
