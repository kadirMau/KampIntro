using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = "elma";
            double fiyati = 15;
            string acıklama = "yeşil";

            string[] meyveler = new string[] { };

            urun urun1 = new urun();
            urun1.UrunAdı = "elma";
            urun1.Fıyatı = 15;
            urun1.Acıklama = "yesil";

            urun urun2 = new urun();
            urun2.UrunAdı = "karpuz";
            urun2.Fıyatı = 65;
            urun2.Acıklama = "sulu diyarbakır karpuzu";

            urun[] urunler = new urun[] { urun1, urun2 };

            foreach (urun urun in urunler)
            {
                Console.WriteLine(urun.UrunAdı);
                Console.WriteLine(urun.Fıyatı);
                Console.WriteLine(urun.Acıklama);
                Console.WriteLine("-----------------");
            }


            Console.WriteLine("--------Metotlar--------");

            //instance örnek
            //encapsulation
            SepetManager sepetmanager = new SepetManager();
            sepetmanager.Ekle(urun1);
            sepetmanager.Ekle(urun2);

            sepetmanager.Ekle2("armut","yeşil armut", 12, 10);
            sepetmanager.Ekle2("elma", "yeşil elma", 12, 8);
            sepetmanager.Ekle2("karpuz", "yeşil karpuz", 12, 7);

        }
    }
}
// do not repeat yourself