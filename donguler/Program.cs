using System;

namespace donguler
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
            Console.Write("Bir sayı giriniz: ");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 1; i <= sayac; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }

            // ****************************************************************
            int tekToplam = 0;
            int ciftToplam = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 2 == 1)
                {
                    tekToplam += i;
                }
                else
                {
                    ciftToplam += i;
                }
            }
            Console.WriteLine("1000'e kadar olan tek sayılar toplamı: " + tekToplam);
            Console.WriteLine("1000'e kadar olan çift sayılar toplamı: " + ciftToplam);

            // ****************************************************************
            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                {
                    break;
                }
                Console.WriteLine(i);
            }

            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            */

            // ****************************************************************
            Console.Write("Bir sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine("Ortalama: " + toplam / sayi);

            //****************************************************************
            char character = 'a';
            while (character <= 'z')
            {
                Console.Write(character + ",");
                character++;
            }

            // ****************************************************************
            string[] arabalar = { "BMW", "Mercedes", "Audi", "Nissan" };
            foreach (var i in arabalar)
            {
                Console.WriteLine(i);
            }
        }
    }
}
