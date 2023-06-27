using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            //SwitchCasePlakaSehir();

            SwitchCaseMevsimUygulamasi();

            Console.Read();
        }

        private static void SwitchCaseMevsimUygulamasi()
        {
            string mevsim;
            Console.Write("Mevsim değerini giriniz: ");
            mevsim = Console.ReadLine();

            switch (mevsim)
            {
                case "Sonbahar": Console.Write("Eylül - Ekim - Kasım"); break;
                case "Kış": Console.Write("Aralık - Ocak - Şubat"); break;
                case "İlkbahar": Console.Write("Mart - Nisan - Mayıs"); break;
                case "Yaz": Console.Write("Haziran - Temmuz - Ağustos"); break;
                default: Console.WriteLine("Yanlış değer girdiniz.."); break;
            }
        }

        private static void SwitchCasePlakaSehir()
        {
            byte plaka;
            Console.Write("Plakayı Giriniz: ");
            plaka = Convert.ToByte(Console.ReadLine());

            switch (plaka)
            {
                case 1: Console.Write("Merhaba Adana"); break;
                case 2: Console.Write("Merhaba Adıyaman"); break;
                case 3: Console.Write("Merhaba Afyonkarahisar"); break;
                default: Console.Write("Girdiğiniz Plakaya Ait Şehir Bilgisi Henüz Girilmemiştir."); break;
            }
        }
    }
}
