using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArdisikSayilarlaİslemler
{
    class Program
    {
        static void Main(string[] args)
        {
            //KlavyedenGirilenSayiyaKadarOlanSayilarinToplamiFor();

            //KlavyedenGirilenSayiyaKadarOlanSayilarinToplamiMatFormuluİle();

            //KlavyedenGirilenSayininFaktoriyeliniBulmaAzalarak();

            KlavyedenGirilenSayininFaktoriyeliniBulmaArtarak();

            Console.Read();
        }

        private static void KlavyedenGirilenSayininFaktoriyeliniBulmaArtarak()
        {
            int faktoriyeliHesaplanacakSayi, faktoriyelDegeri = 1;

            Console.Write("Faktöriyel Değerini Öğrenmek İstediğiniz Sayıyı Giriniz: ");
            faktoriyeliHesaplanacakSayi = Convert.ToInt32(Console.ReadLine());

            for (int j = 1; j <= faktoriyeliHesaplanacakSayi; j++)
            {
                faktoriyelDegeri *= j;
                Console.WriteLine("{0} Sayısının Faktöriyeli: {1}", j, faktoriyelDegeri);
            }
        }

        private static void KlavyedenGirilenSayininFaktoriyeliniBulmaAzalarak()
        {
            int faktoriyeliBulunacakSayi, faktoriyel = 1;

            Console.Write("Faktöriyelini hesaplamak istediğiniz sayıyı giriniz: ");
            faktoriyeliBulunacakSayi = Convert.ToInt32(Console.ReadLine());

            for (int i = faktoriyeliBulunacakSayi; i >= 1; i--)
            {
                faktoriyel *= i;
            }

            Console.Write("{0} Sayısının Faktöriyeli: {1}", faktoriyeliBulunacakSayi, faktoriyel);
        }

        private static void KlavyedenGirilenSayiyaKadarOlanSayilarinToplamiMatFormuluİle()
        {
            int sinirSayi, toplamDeger;
            Console.Write("Sınır sayıyı giriniz: ");
            sinirSayi = Convert.ToInt32(Console.ReadLine());

            toplamDeger = (sinirSayi * (sinirSayi + 1)) / 2;

            Console.WriteLine("{0} Sayısına Kadar Olan Sayıların Toplamı: {1} ", sinirSayi, toplamDeger);
        }

        private static void KlavyedenGirilenSayiyaKadarOlanSayilarinToplamiFor()
        {
            int toplam = 0;
            int sayi;
            Console.Write("Sınır sayıyı giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= sayi; i++)
            {
                toplam += i;
            }

            Console.WriteLine("{0} Sayısına Kadar Olan Sayıların Toplamı: {1} ", sayi, toplam);
        }
    }
}
