using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            Kurs kurs1 = new Kurs();
            kurs1.kursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = "68";


            Kurs kurs2 = new Kurs();
            kurs2.kursAdi = "Java";
            kurs2.Egitmen = "Ramazan Ertin";
            kurs2.IzlenmeOrani = "68";


            Kurs kurs3 = new Kurs();
            kurs3.kursAdi = "Pyhton";
            kurs3.Egitmen = "Emrullah Arslan";
            kurs3.IzlenmeOrani = "68";

            //Console.WriteLine(kurs1.kursAdi + " :" + kurs1.Egitmen);
            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };
            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.kursAdi+ " : "+ kurs.Egitmen);
            }






            Console.WriteLine("Hello World!");
        }
    }
}
class Kurs
{
    public string kursAdi { get; set; }
    public string Egitmen { get; set; }
    public string IzlenmeOrani  { get; set; }
}