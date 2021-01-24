using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        List<Musteri> customers = new List<Musteri>();

        public void Add(Musteri customer)
        {
            customers.Add(customer);
            Console.WriteLine("\n -" + customer.Isim + " eklendi.");
        }

        public void List()
        {
            foreach (Musteri musteri in customers)
            {
                Console.WriteLine(musteri.Id + " " + musteri.Isim + " " + musteri.Soyisim + " " + musteri.Sehir);
            }
        }
        public void Delete(Musteri customer)
        {
            customers.Remove(customer);
            Console.WriteLine("\n -" + customer.Isim + " silindi.");
        }

    }
}
