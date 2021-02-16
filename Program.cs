using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriID = 1;
            musteri1.MusteriAdıSoyadı = "Ali Kale";
            musteri1.MusteriDurumu = "Student";
            musteri1.MusteriKazancı = 0;


            Musteri musteri2 = new Musteri();
            musteri2.MusteriID = 2;
            musteri2.MusteriAdıSoyadı = "Engin Demirog";
            musteri2.MusteriDurumu = "Co-Founder";
            musteri2.MusteriKazancı = 20000;

            Musteri musteri3 = new Musteri();
            musteri3.MusteriID = 3;
            musteri3.MusteriAdıSoyadı = "Furkan polat";
            musteri3.MusteriDurumu = "Junior developer";
            musteri3.MusteriKazancı = 5000;



            Musteri[] musteris = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Listele(musteris);

            foreach (var musteri in musteris)
            {
                Console.WriteLine($"ID: {musteri.MusteriID} Adı Soyadı: {musteri.MusteriAdıSoyadı}  Durumu: {musteri.MusteriDurumu} ");

            }



        }


        
    }      
}
