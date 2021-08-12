using System;

namespace degiskenler
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            byte b = 5; // 1 byte yer kaplar
            sbyte sb = 5; // 1 byte yer kaplar

            short s = 5; // 2 byte yer kaplar
            ushort us = 5; // 2 byte yer kaplar

            Int16 i16 = 2; // 2 byte yer kaplar
            int i = 2; // 4 byte yer kaplar
            Int32 i32 = 2; // 4 byte yer kaplar
            Int64 i64 = 2; // 8 byte yer kaplar

            uint ui = 2; // 4 byte yer kaplar
            long l = 4; // 8 byte yer kaplar
            ulong ul = 4; // 8 byte yer kaplar

            float f = 5; // 4 byte yer kaplar
            double d = 5; // 8 byte yer kaplar
            decimal de = 5; // 16 byte yer kaplar

            char ch = '2'; // 2 byte yer kaplar
            string str = "Batuhan"; // sınırsız yer kaplar

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            object o1 = "Batuhan";
            object o2 = 'B';
            object o3 = 4;
            object o4 = 4.5;
            
            // string ifadeler
            string str1 = string.Empty;
            str1 = "Batuhan Kıltaç";
            string ad = "Batuhan";
            string soyad = "Kıltaç";
            string tamIsim = ad + " " + soyad;

            // integer tanımlama
            int i1 = 5;
            int i2 = 3;
            int i3 = i1 * i2;
            
            // boolean
            bool bool1 = 10 > 2;

            // degisken donusumleri
            string str20 = "20";
            int int20 = 20;
            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine("Yeni String Değer: " + yeniDeger);

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine("Yeni Integer Değer: " + int21);
            
            int int22 = int20 + int.Parse(str20);
            Console.WriteLine("Yeni Integer Değer: " + int22);

            // datetime
            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime1 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime1);

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);




        }
    }
}
