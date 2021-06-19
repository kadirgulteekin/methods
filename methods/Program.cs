using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //tekrar tekrar kullabilriliği sağlayan kodlardır.

            Products urun1 = new Products(); //classtan bir değişken tanımlayan zaman new'lemek gerekiyor.
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";
            urun1.StokAdeti = 65;

            Products urun2 = new Products();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";
            urun2.StokAdeti = 89;

            Products[] urunler = new Products[]
            {
                urun1,urun2
            };

            //type safe
            foreach (Products x in urunler)
            {

                Console.WriteLine(x.Adi);
                Console.WriteLine(x.Fiyati);
                Console.WriteLine(x.Aciklama);
                Console.WriteLine(x.StokAdeti);
                Console.WriteLine("-----------------");
            }
            //encupsolution
            Console.WriteLine("---------Metotlar------------");
            
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle2("Armut", "Yeşil Armut", 12,100);
            sepetManager.Ekle2("Elma", "Kırmızı Elma", 10,65);
          

            Console.ReadLine();


            
        }
    }
}
