using System;

namespace DENEME
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Console.Write("Adınızı giriniz: ");
            string name = Console.ReadLine();
            Console.Write("Soyadınızı giriniz: ");
            string surname = Console.ReadLine();

            Console.WriteLine("Hoşgeldiniz, " + name + " " + surname);

        }
    }
}