using System;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] {"yazılım geliştrici kampı",
                                             "programlamaya başlangıç kursu",
                                              "java" };





            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);


            }
            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);

            }
        }
    }
}