using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMustafaOzcanIntroductionMaraton
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Karsilama();
            AnaAdimMesafesiHesaplama();           

        }

        private static void AnaAdimMesafesiHesaplama()
        {
            bool devamMi = true;
            while (devamMi)
            {
                double adimBoyu;
                int adimSayisi, saat, dakika;// bilgiler bilgial metodu ile değişeceği için ilk tanımlamalar yapıldı
                BilgiAl(out adimBoyu, out adimSayisi, out saat, out dakika);//Tüm bilgilerin kontrol edilerek alındığı metod
           
                int toplamAdım = (ToplamAdimHesapla(saat, dakika, adimSayisi));//metod ile toplam adım hesaplanıyor
                                
                Console.WriteLine(MesafeBul(adimBoyu, toplamAdım) + " Metre koşu mesafeniz...");// Metod writeline metoduna direk yazıldı

                devamMi = Ugurlama();//devammi metodu boolien değer döndürdüğü için soru sorulup cevaba göre program tekrar çalışabiliyor.
            }
        }

        private static void Karsilama()
        {
            Console.WriteLine("Hoşgeldiniz Bu Programa Adım Boyunuzu(cm), 1 Dk da kaç adım attığınızı ve Toplam koşu sürenizi girdiğiniz takdirde size toplam koşu mesafeniz hesaplanıp söylenecektir.\n\n ____Sınırlar____\n\n*Adım Boyu=35cm-150 cm\n*1 Dk da Atılan Adım=50 -150\n*Süreler: saat 0-12 , dakika 0sn-59sn");
        }
        private static bool Ugurlama()
        {
            Console.WriteLine("Devam Etmek için 'Evet' yazin");

            string cevap = Console.ReadLine().ToLower();
            bool devamMi = false;
            if (cevap == "evet")
            {
                devamMi = true;
            }
            return devamMi;
        }
        public static double MesafeBul(double adimBoyu, int toplamAdım)
        {
            double mesafe = ((adimBoyu * toplamAdım) / 100);
            return mesafe;
        }
        public static int ToplamAdimHesapla(int saat, int dakika, int adimSayisi)
        {
            int toplamZaman = dakika + (saat * 60);
            int toplamAdım = toplamZaman * adimSayisi;
            return toplamAdım;
        }
        public static void BilgiAl(out double adimBoyu, out int adimSayisi, out int saat, out int dakika)
        {//Tüm bilgilerin doğruluğu kontrol edilmiş hatalı girişlerde bilgilendirme yapılmış çıkış yapılma seçenekleri sunulmuştur.

            Console.WriteLine("Adım Boyunuzu giriniz(cm)- Çıkmak İçin E ye basın");
            string soru = Console.ReadLine().ToLower(); //Adım boyu girişi
            if (soru=="e") Environment.Exit(0); //Çıkış kontrol

            bool boyKontrol = double.TryParse(soru, out adimBoyu);     
            while (!boyKontrol || adimBoyu>151|| adimBoyu<35)  //veri hatalı ise veride while girip tekrar soruyor
            {
                Console.WriteLine("Hatalı veri girdiniz(35 cm-150 cm arası sadece sayı giriniz)\nAdım Boyunuzu giriniz(cm)");
                boyKontrol = double.TryParse(Console.ReadLine(), out adimBoyu);
            }

            
            Console.WriteLine("1 dk da kaç adım atıyorsunuz - Çıkmak İçin E yazın");
            soru = Console.ReadLine().ToLower();//Adım sayisi girişi
            if (soru == "e") Environment.Exit(0); // çıkış satırı
            bool adimKontrol = int.TryParse(soru, out adimSayisi);   
            while (!adimKontrol || adimSayisi > 150 || adimSayisi < 50)//veri hatalı ise veride while girip tekrar soruyor
            {
                Console.WriteLine("Hatalı veri girdiniz(50 adım ile 150 adım arası sadece sayı giriniz)\n 1 dk da kaç adım atıyorsunuz");
                adimKontrol = int.TryParse(Console.ReadLine(), out adimSayisi);
            }

            Console.WriteLine("Koşu saatinizi giriniz- Çıkmak İçin E yazın");
            soru = Console.ReadLine().ToLower(); //çıkış kontrol
            if (soru == "e") Environment.Exit(0);
            bool saatKontrol = int.TryParse(soru, out saat);   //saat girişi
            while (!saatKontrol || saat > 13 )//veri hatalı ise veride while girip tekrar soruyor
            {
                Console.WriteLine("Hatalı veri girdiniz(0-12 arası sadece sayı giriniz)\n1 dk da kaç adım atıyorsunuz");
                saatKontrol = int.TryParse(Console.ReadLine(), out saat);
            }

            Console.WriteLine("Koşu Dakikanızı giriniz- Çıkmak İçin E yazın");
            soru = Console.ReadLine().ToLower();
            if (soru == "e") Environment.Exit(0);//çıkış kontrol
            bool dakikaKontrol = int.TryParse(soru, out dakika);   //dakika girişi
            while (!dakikaKontrol || dakika > 60)  //veri hatalı ise veride while girip tekrar soruyor
            {
                Console.WriteLine("Hatalı veri girdiniz(0 dk-59 dk arası sadece sayı giriniz)\n1 dk da kaç adım atıyorsunuz");
                dakikaKontrol = int.TryParse(Console.ReadLine(), out dakika);
            }

        }

    }
}
