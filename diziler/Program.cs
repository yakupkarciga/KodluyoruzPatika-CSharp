using System;

namespace diziler
{
    class Program
    {
        public static void Main(string[] args)
        {
            // sort
            int[] sayiDizisi = { 23, 12, 4, 86, 72, 3, 11, 17 };
            Array.Sort(sayiDizisi);
            Console.WriteLine("** Sıralı Liste **");
            foreach (var i in sayiDizisi)
            {
                Console.WriteLine(i);
            }


            // clear
            Array.Clear(sayiDizisi, 2, 2);
            Console.WriteLine("** Silinen Liste **");
            foreach (var i in sayiDizisi)
            {
                Console.WriteLine(i);
            }


            // reverse
            Array.Reverse(sayiDizisi);
            Console.WriteLine("** Ters Liste **");
            foreach (var i in sayiDizisi)
            {
                Console.WriteLine(i);
            }


            // indexof
            Console.WriteLine("** 23 sayısının index numarası **");
            Console.WriteLine(Array.IndexOf(sayiDizisi, 23));


            // resize
            Array.Resize<int>(ref sayiDizisi, 9);
            sayiDizisi[8] = 99;
            Console.WriteLine("** Resize Liste **");
            foreach (var i in sayiDizisi)
            {
                Console.WriteLine(i);
            }
        }
    }
}