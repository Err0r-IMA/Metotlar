﻿using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "elma";
            double fiyati = 15;
            string aciklama = "amasya elmasi";

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "amasya elması";


            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = " Diyarbakır karpuzu";


            Urun[] urunler = new Urun[] { urun1, urun2 };

            //type-safe --tip güvenli
            foreach (Urun urun in urunler)
            {

                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------------");

              


            }

            Console.WriteLine("----------metotlar--------------");
            //instance - örnek 
            //encapsulation

            SepetManager sepetManager = new SepetManager();

            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);


            //sepetManager.Ekle("Armut ", 12, 10);



        }



    }
}


//Dont repeat yourself - DRY - Clean Code - Best Practice 
