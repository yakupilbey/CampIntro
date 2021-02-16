using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //abstraction
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demniroğ";
            musteri1.TcNo = "1234567890";




            //kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "kodlama.io";
            musteri2.VergiNo = "1234567890";



            //Gerçek Müşteri - Tüzel Müşteri 
            //SOLID - (L)

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CostumerManager costumerManager = new CostumerManager();
            costumerManager.Add(musteri1);
            costumerManager.Add(musteri2);





        }
    }
}
