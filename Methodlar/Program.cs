using System;

namespace Methodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Id = 1;
            urun1.Adi = "Nar";
            urun1.Aciklama = "Adıyaman Narı";
            urun1.Fiyat = 50;

            Urun urun2 = new Urun();
            urun2.Id = 2;
            urun2.Adi = "Elma";
            urun2.Aciklama = "Amasya Elması";
            urun2.Fiyat = 20;

            Urun urun3 = new Urun();
            urun3.Id = 3;
            urun3.Adi = "Portakal";
            urun3.Aciklama = "Mersin Portakalı";
            urun3.Fiyat = 25;

            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi + " " + urun.Aciklama + " " + urun.Fiyat + "tl");
            }

            Console.WriteLine("------------------Methodlar----------------------");

            //instance örnek

            SepetMenager sepetMenager = new SepetMenager();
            sepetMenager.Ekle(urun1);

        }
    }
}
