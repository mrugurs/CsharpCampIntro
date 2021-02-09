using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Adi = "Murat";
            musteri1.SoyAdi = "UĞUR";
            musteri1.Id = 1;
            musteri1.TcNo = "5646568131";
            musteri1.MusteriNo = "2316165";


            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "65465";
            musteri2.VergiNo = "646841651";
            musteri2.SirketAdi = "Murtisoft";


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);


        }
    }
}
