using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] { "C#", "python", "angular", "java", "c++", "c", "go" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For Bitti");

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "Python";
            kurs1.KursKategori = "Yazılım";
            kurs1.IzlenmeOrani = 52;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "C#";
            kurs2.KursKategori = "Yazılım";
            kurs2.IzlenmeOrani = 32;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Java";
            kurs3.KursKategori = "Yazılım";
            kurs3.IzlenmeOrani = 72;

            Kurs[] Kurslar = new Kurs[] {kurs1, kurs2, kurs3 };

            foreach (var kurs in Kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.IzlenmeOrani);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursKategori { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}