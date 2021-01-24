using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri { Id = 1, Isim = "Fuki", Soyisim = "Başkan", Sehir = "Sakarya" };
            Musteri musteri2 = new Musteri { Id = 2, Isim = "Eymen", Soyisim = "Başkan", Sehir = "Düzce" };
            Musteri musteri3 = new Musteri { Id = 3, Isim = "Nesli", Soyisim = "K", Sehir = "İstanbul" };
            Musteri musteri4 = new Musteri { Id = 4, Isim = "Gizem", Soyisim = "G", Sehir = "İstanbul" };

            MusteriManager customerManger = new MusteriManager();

            customerManger.Add(musteri1);
            customerManger.Add(musteri2);
            customerManger.Add(musteri3);
            customerManger.Add(musteri4);

            customerManger.List();

            customerManger.Delete(musteri3);

            customerManger.List();


        }
    }
}
