using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "engin";
            int yas = 32;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "c";
            kurs1.Egitmen = "engın";
            kurs1.IzlenmeOranı = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.Egitmen = "kadir";
            kurs2.IzlenmeOranı = 58;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "python";
            kurs3.Egitmen = "kaan";
            kurs3.IzlenmeOranı = 75;

           


        }
    }

    class Kurs
    {
        public string  KursAdi { get; set; }
        public string Egitmen{ get; set; }
        public int IzlenmeOranı { get; set; }
    }
}
