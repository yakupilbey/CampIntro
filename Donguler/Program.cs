using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya giriş için temel Kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";
            string kurs5 = "C++";



            // Array - Dizi
            //Liste formatı için diziler (arrays)

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya giriş için temel Kurs",
            "Java","Python","C#"};



            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For Bitii!");
            foreach (string kurs in kurslar)
            {
                //Dizi temelli yapıları tek tek dönmeye yarar.
                Console.WriteLine(kurs);
            }


            Console.WriteLine("Sayfa Sonu - Footer");
        }
    }
}