using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine($"Yeni Musteri Eklendi. Eklenen musteri >> {musteri.MusteriAdıSoyadı} ID:{musteri.MusteriID}");

        }

       
        public void Sil(Musteri musteri)
        {
            Console.WriteLine($"ID:{musteri.MusteriID} '{musteri.MusteriAdıSoyadı}' isimli musteri silindi.");
        }


        public void Listele(Musteri[] musteris)
        {

            Console.WriteLine("----------- Listelenen Musteriler ----------");
        }


    }
}
