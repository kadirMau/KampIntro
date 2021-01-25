using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvnliği 
            //do not repeat yourself = kednini tekrarlama 
            //deger tutucu , alias 

            string kategoriEtiketi = "Kategori";
            //int ogrenciSayisi = 32000;
            //double faizOrani = 1.45;
            //bool sistemeGirisYapmısMı = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.55;


            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");

            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("artış butonu");
            }
            else
            {
                Console.WriteLine("degismedi");
            }

            //if (sistemeGirisYapmısMı==true)
            //{
            //    Console.WriteLine(" Kullanıcı Ayarlar Butonu  ");
            //}
            //else
            //{
            //    Console.WriteLine("giris yap butonu");
            //}

        }
    }
}
