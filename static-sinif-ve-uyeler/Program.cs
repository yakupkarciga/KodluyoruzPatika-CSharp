using System;

namespace static_sinif_ve_uyeler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan Sayısı: " + Calisan.CalisanSayisi);
            Calisan calisan = new Calisan("Batuhan", "Kıltaç", "IT");
            Console.WriteLine("Çalışan Sayısı: " + Calisan.CalisanSayisi);
            Calisan calisan1 = new Calisan("Ahmet", "Mehmet", "BT");
            Calisan calisan2 = new Calisan("Hasan", "Hüseyin", "KT");
            Console.WriteLine("Çalışan Sayısı: " + Calisan.CalisanSayisi);


            Console.WriteLine("Toplama sonucu: " + Islemler.Topla(100, 200));
            Console.WriteLine("Çıkarma sonucu: " + Islemler.Cikar(200, 100));
        }
    }

    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi; }

        private string Isim;
        private string Soyisim;
        private string Departman;

        static Calisan()
        {
            calisanSayisi = 0;
        }

        public Calisan(string isim, string soyisim, string departman)
        {
            this.Isim = isim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            calisanSayisi++;
        }
    }

    static class Islemler
    {
        public static long Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public static long Cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
    }
}