using System;

namespace GenericIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Furkan");

            Console.WriteLine(isimler);
        }
    }
}
