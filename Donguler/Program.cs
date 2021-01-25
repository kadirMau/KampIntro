using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //string kurs1 = "yazılım geliştirici yetiştirme kampı";
            //string kurs2 = "programlamaya baslangıc ıcın temel kurs";
            //string kurs3 = "java";
            //string kurs4= "python";

            //array-dizi 
            string[] kurslar = new string[] { "yazılım geliştirici yetiştirme kampı"," programlamaya baslangıc ıcın temel kurs", "java","python","c sharp" };
          
            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            foreach (string  kurs in kurslar)
            {
                Console.WriteLine();
            }
            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
