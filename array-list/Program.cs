using System;
using System.Collections;
using System.Collections.Generic;

namespace array_list
{
    class Program
    {
        public static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            liste.Add("Batuhan");
            liste.Add(2);
            liste.Add(true);
            liste.Add('B');


            // verilere erişim
            Console.WriteLine(liste[1]);
            foreach (var i in liste)
            {
                Console.WriteLine(i);
            }


            // addrange
            string[] renkler = { "kırmızı", "sarı", "yeşil" };
            liste.AddRange(renkler);
            List<int> sayilar = new List<int>() { 1, 8, 3, 7, 9, 92, 5 };
            liste.AddRange(sayilar);
            foreach (var i in liste)
            {
                Console.WriteLine(i);
            }


            // sort
            liste.Sort();
            foreach (var i in liste)
            {
                Console.WriteLine(i);
            }


            // binary search
            Console.WriteLine(liste.BinarySearch(9));


            // reverse
            liste.Reverse();
            foreach (var i in liste)
            {
                Console.WriteLine(i);
            }


            // clear
            liste.Clear();
            foreach (var i in liste)
            {
                Console.WriteLine(i);
            }
        }
    }
}