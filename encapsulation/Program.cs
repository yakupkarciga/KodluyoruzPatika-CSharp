using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim = "Batuhan";
            ogrenci.Soyisim = "Kıltaç";
            ogrenci.No = 1234;
            ogrenci.Sinif = 3;
            ogrenci.OgrenciBilgileriniGetir();

            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileriniGetir();

            ogrenci.SinifDusur();
            ogrenci.OgrenciBilgileriniGetir();

            Ogrenci ogrenci1 = new Ogrenci("Ahmet", "Mehmet", 5678, 1);
            ogrenci1.SinifDusur();
            ogrenci1.OgrenciBilgileriniGetir();
        }
    }

    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int no;
        private int sinif;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int No { get => no; set => no = value; }
        public int Sinif
        {
            get => sinif;
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Sınıf en az 1 olabilir!");
                    sinif = 1;
                }
                else
                {
                    sinif = value;
                }
            }
        }

        public Ogrenci(string isim, string soyisim, int no, int sinif)
        {
            Isim = isim;
            Soyisim = soyisim;
            No = no;
            Sinif = sinif;
        }

        public Ogrenci() { }

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("** Öğrenci Bilgileri **");
            Console.WriteLine("Öğrenci Adı: " + this.isim);
            Console.WriteLine("Öğrenci Soyadı: " + this.soyisim);
            Console.WriteLine("Öğrenci No: " + this.no);
            Console.WriteLine("Öğrenci Sınıfı: " + this.sinif);
        }

        public void SinifAtlat()
        {
            this.sinif = this.sinif + 1;
        }

        public void SinifDusur()
        {
            this.sinif = this.sinif - 1;
        }
    }
}