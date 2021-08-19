using System;

namespace kurucu_metotlar
{
    class Program
    {
        public static void Main(string[] args)
        {
            // erisim belirleyiciler
            // * Public
            // * Private
            // * Internal
            // * Protected

            Calisan calisan1 = new Calisan("Batuhan", "Kıltaç", 1234567, "IT");
            calisan1.CalisanBilgileri();

            Console.WriteLine("\n*************************\n");

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Ahmet";
            calisan2.Soyad = "Mehmet";
            calisan2.No = 2468101;
            calisan2.Departman = "BT";
            calisan2.CalisanBilgileri();

            Console.WriteLine("\n*************************\n");

            Calisan calisan3 = new Calisan("Hasan", "Hüseyin");
            calisan3.CalisanBilgileri();
        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Calisan(string ad, string soyad, int no, string departman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }

        public Calisan(string ad, string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;
        }

        public Calisan() { }

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı: " + Ad);
            Console.WriteLine("Çalışan Soyadı: " + Soyad);
            Console.WriteLine("Çalışan No: " + No);
            Console.WriteLine("Çalışan Departmanı: " + Departman);
        }
    }
}