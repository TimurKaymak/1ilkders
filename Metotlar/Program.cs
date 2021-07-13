using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] meyveler = new string[] { };
            Urun urun1 = new Urun();
            urun1.Adi = "elma";
            urun1.Fiyat = 15;
            urun1.Id = 1;
            urun1.Aciklama = "elma gibi elma";
            
            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyat = 20;
            urun2.Id = 2;
            urun1.Aciklama = "karpuzz";

            Urun[] urunler = new Urun[] {urun1,urun2 };
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyat);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------------");

            }
            Console.WriteLine("--------METOTLAR----------");
            SepetManager sepet = new SepetManager();
            sepet.Ekle(urun1);
            sepet.Ekle(urun2);






        }
    }
}
