using System;
using System.Collections.Generic;

namespace dictionary_list
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> kullanicilar = new Dictionary<int, string>();
            kullanicilar.Add(10, "Batuhan");
            kullanicilar.Add(12, "Ahmet");
            kullanicilar.Add(18, "Mehmet");
            kullanicilar.Add(20, "Ayşe");


            // elemanlara erişim
            Console.WriteLine(kullanicilar[12]);
            foreach (var i in kullanicilar)
            {
                Console.WriteLine(i);
            }


            // count
            Console.WriteLine(kullanicilar.Count);


            // contains
            Console.WriteLine(kullanicilar.ContainsKey(12));
            Console.WriteLine(kullanicilar.ContainsValue("Batuhan"));


            // remove
            kullanicilar.Remove(12);
            foreach (var i in kullanicilar)
            {
                Console.WriteLine(i);
            }


            // keys - values
            foreach (var i in kullanicilar.Keys)
            {
                Console.WriteLine(i);
            }

            foreach (var i in kullanicilar.Values)
            {
                Console.WriteLine(i);
            }
        }
    }
}