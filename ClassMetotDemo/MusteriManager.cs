using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {

        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Firstname + " Adlı Müşteri Eklendi.");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Firstname + " Adlı Müşteri Silindi.");
        }

        public void MusteriListesi(Musteri[] musteriler)
        {
            Console.WriteLine("Müşteri Listesi");

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Firstname + musteri.Lastname);
            }

        }


    }
}
