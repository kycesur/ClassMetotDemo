using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    { public void MusteriEkle (Musteri musteri)
            {

            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " Eklendi.");

            }
        public void MusteriSil (Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " silindi.");

        }
        public void MusteriListele(Musteri[] musteriler)
        {
            foreach (Musteri musteri  in musteriler)
            {
                Console.WriteLine(musteri.Ad +" "+ musteri.Soyad );
            }
            Console.WriteLine(musteriler.Count()+" adet kişi listelendi."); 
        }
    }
}
