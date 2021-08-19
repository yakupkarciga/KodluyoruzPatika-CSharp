using System;

namespace enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Günler: " + Gunler.Pazar);
            Console.WriteLine("Günler: " + (int)Gunler.Cumartesi + ". gün " + Gunler.Cumartesi);


            int sicaklik = 32;
            if (sicaklik <= (int)HavaDurumu.Normal)
            {
                Console.WriteLine("Dışarıya çıkmak için havanın biraz daha ısınmasını bekle.");
            }
            else if (sicaklik >= (int)HavaDurumu.Sıcak)
            {
                Console.WriteLine("Dışarıya çıkmak için çok sıcak bir gün.");
            }
            else if (sicaklik >= (int)HavaDurumu.Normal && sicaklik < (int)HavaDurumu.ÇokSıcak)
            {
                Console.WriteLine("Hadi dışarıya çıkalım.");
            }
        }
    }

    enum Gunler
    {
        Pazartesi = 1, Salı = 2, Çarşamba = 3, Perşembe = 4, Cuma = 5, Cumartesi = 6, Pazar = 7
    }

    enum HavaDurumu
    {
        Soğuk = 5, Normal = 20, Sıcak = 25, ÇokSıcak = 30
    }
}