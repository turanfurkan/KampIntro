using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] { "Ahmet", "Mehmet", "Burak", "Eren" };
           

            List<string> isimler1 = new List<string> { "Mustafa", "Abdullah", "Kerem", "Emre" };
            isimler1.Add("Furkan");
            
            Console.WriteLine(isimler1[4]);

            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine(isimler1[i]);
            }
            
        }
    }
}
