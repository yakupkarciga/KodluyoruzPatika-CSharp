using System;

namespace hazir_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp, Hoşgeldiniz!";
            string degisken1 = "CSharp!";

            // length
            Console.WriteLine(degisken.Length);


            // toupper() - tolower()
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());


            // concat()
            Console.WriteLine(String.Concat(degisken, "Merhaba."));


            // compare() - compareto()
            Console.WriteLine(String.Compare(degisken, degisken1, true));
            Console.WriteLine(String.Compare(degisken, degisken1, false));
            Console.WriteLine(degisken.CompareTo(degisken1));


            // contains()
            Console.WriteLine(degisken.Contains(degisken1));
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!"));
            Console.WriteLine(degisken.StartsWith("Merhaba"));


            // indexof()
            Console.WriteLine(degisken.IndexOf("CS"));


            // insert()
            Console.WriteLine(degisken.Insert(0, "Merhaba!"));


            // padleft() - padright()
            Console.WriteLine(degisken + degisken1.PadLeft(30));
            Console.WriteLine(degisken1 + degisken.PadRight(30));


            // remove()
            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5, 3));
            Console.WriteLine(degisken.Remove(0, 1));


            // replace()
            Console.WriteLine(degisken.Replace("CSharp", "C#"));


            // split()
            Console.WriteLine(degisken.Split(' ')[1]);


            // substring()
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4, 6));
        }
    }
}