using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç için Temel Kursu";
            string kurs3 = "Java";

            //array - dizi

            string[] kurslar = new string[]
            {
                "Yazılım Geliştirici Yetiştirme Kampı",
                "Programlamaya Başlangıç için Temel Kursu",
                "Java",
                "Python",
                "C++",
                "C#"
            };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("\n*****************************************\n");

            foreach (string kurs in kurslar) //dizilere uygulanır!
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("\nsayfa sonu - footer");
        }
    }
}
