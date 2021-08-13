using System;

namespace tipdonusumleri
{
    class Program
    {
        public static void Main(string[] args)
        {
            // implicit conversion (bilincsiz donusum)
            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a + b + c;
            Console.WriteLine("d'nin değeri: " + d);

            long h = d;
            Console.WriteLine("h'nin değeri: " + h);

            float i = h;
            Console.WriteLine("i'nin değeri: " + i);

            string e = "Batuhan";
            char f = 'B';
            object g = e + f + d;
            Console.WriteLine("g'nin değeri: " + g);


            // explicit conversion (bilincli donusum)
            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y'nin değeri: " + y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t'nin değeri: " + t);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v'nin değeri: " + v);


            // ToString() methodu
            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy'nin değeri: " + yy);

            string zz = 12.5f.ToString();
            Console.WriteLine("zz'nin değeri: " + zz);


            // System.Convert
            string s1 = "10", s2 = "20";
            int sayi1, sayi2;
            int toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);
            toplam = sayi1 + sayi2;
            Console.WriteLine("toplam: " + toplam);


            // Parse
            ParseMethod();
        }

        public static void ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "10.25";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            double1 = Double.Parse(metin2);

            Console.WriteLine("rakam1'in değeri: " + rakam1);
            Console.WriteLine("double1'in değeri: " + double1);
        }
    }
}