using System;

namespace Classintro
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Timur Kaymak";
            kurs1.izlenmeOranı =68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "C++";
            kurs2.Egitmen = "ahmet";
            kurs2.izlenmeOranı = 64;


            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "java";
            kurs3.Egitmen = "berkay";
            kurs3.izlenmeOranı = 80;


            //Console.WriteLine(kurs1.KursAdi+" "+kurs1.Egitmen+" "+kurs1.izlenmeOranı);
            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };
            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+":"+kurs.Egitmen);

            }
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int izlenmeOranı { get; set; }


    }
}
