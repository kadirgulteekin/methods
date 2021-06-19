using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class SepetManager
    {
        //nameing convention
        //syntax
        public void Ekle(Products urun)
        {

            Console.WriteLine("Sepete eklendi : " +urun.Adi);
        }
        public void Ekle2(string urunAdi, string aciklama, double fiyat,int stokAdeti)

        {
            Console.WriteLine("Sepete eklendi : " + urunAdi);
        }
    }
}
