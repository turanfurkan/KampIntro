using System;
using System.Collections.Generic;
using System.Text;

namespace Methodlar
{
    class SepetMenager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi." + " " + urun.Id + " :" + urun.Adi);
        }
    }
}
