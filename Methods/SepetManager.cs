using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        //namin convetion
        //syntax
        public void Ekle( urun urun)
        {
            Console.WriteLine(" Tebrikler.Sepete Eklendi:" + urun.UrunAdı);
            //
        }

        public void Ekle2(string urunAdi , string aciklama ,double fiyat , int stokAdedi)
        {
            Console.WriteLine(" Tebrikler.Sepete Eklendi:" + urunAdi);

        }
    }
}
