using System;
using System.Collections.Generic;

namespace generic_list
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<String> renkListesi = new List<String>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");


            // count
            Console.WriteLine("Sayı Listesi eleman sayısı: " + sayiListesi.Count);
            Console.WriteLine("Renk Listesi eleman sayısı: " + renkListesi.Count);


            // foreach ve List.Foreach ile erişim
            Console.WriteLine("\n** Sayı Listesi **");
            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("\n** Renk Listesi **");
            foreach (var renk in renkListesi)
            {
                Console.WriteLine(renk);
            }

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));


            // listeden eleman çıkartma
            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));


            // liste içerisinde arama
            if (sayiListesi.Contains(10))
            {
                Console.WriteLine("10, Liste içerisinde bulundu!");
            }


            // eleman ile indexe erişim
            Console.WriteLine(renkListesi.BinarySearch("Turuncu"));


            // diziyi List'e çevirme
            string[] hayvanlar = { "kedi", "köpek", "kuş" };
            List<string> hayvanlarListesi = new List<string>(hayvanlar);


            // liste temizleme
            hayvanlarListesi.Clear();


            // list içerisinde nesne tutmak
            List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();

            Kullanicilar kullanici1 = new Kullanicilar();
            kullanici1.Isim = "Batuhan";
            kullanici1.Soyisim = "Kıltaç";
            kullanici1.Yas = 31;

            Kullanicilar kullanici2 = new Kullanicilar();
            kullanici2.Isim = "Ahmet";
            kullanici2.Soyisim = "Mehmet";
            kullanici2.Yas = 32;

            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2);


            List<Kullanicilar> yeniListe = new List<Kullanicilar>();
            yeniListe.Add(new Kullanicilar()
            {
                Isim = "Deniz",
                Soyisim = "Arda",
                Yas = 24
            });
            foreach (var kullanici in kullaniciListesi)
            {
                Console.WriteLine("Kullanıcı Adı: " + kullanici.Isim);
                Console.WriteLine("Kullanıcı Soyadı: " + kullanici.Soyisim);
                Console.WriteLine("Kullanıcı Yaşı: " + kullanici.Yas);
            }
        }
    }

    public class Kullanicilar
    {
        string isim;
        string soyisim;
        int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}