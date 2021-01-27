using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {

            //engin demirog
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "1235";
            musteri1.Id = 1;
            musteri1.Adi = "engin";
            musteri1.SoyAdi = "demırog";
            musteri1.TcNo = "213123";

            // kodlama io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "32432";
            musteri2.SirketAdi="kodlama.io";
            musteri2.VergiNo = "3123213";

            //gerçek müşteri - tüzel  müşteri 


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2); 

        }
    }
}
