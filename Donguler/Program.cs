using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Kampı";
            string kurs2 = "Programlamaya giriş";
            string kurs3 = "Java kursu";

            string[] kurslar = new string[] { "Yazılım Geliştirici Kampı","Programlamaya Giriş","Java kursu","Python" };



            for (int i = 0; i < kurslar.Length ; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("FOR BİTTİ");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("Sayfa Sonu");
        }
    }

    
}
