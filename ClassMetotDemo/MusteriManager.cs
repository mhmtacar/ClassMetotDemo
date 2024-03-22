using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("{0} {1} isimli müşteri eklendi", musteri.Adi, musteri.Soyadi);
        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine("{0} {1} isimli müşteri silindi", musteri.Adi, musteri.Soyadi);
        }

        public void List(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Müşteri: {0} {1} ", musteri.Adi, musteri.Soyadi);
            } 
        }

    }
}
