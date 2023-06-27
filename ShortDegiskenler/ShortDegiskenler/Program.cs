using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortDegiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Short: -32768 - +32767 arasında değer alır. Başında s olduğu için tekrar s koyma gereği duyulmamıştır. S = Signed demektir ve bu, negatif değerlerin de dahil olduğunu gösterir.
            // Dönüştürme işlemi klavyeden veri girişinde short.Parse ile, aritmetik işlemi ise (short) ya da Convert.ToInt16 şeklinde gerçekleşir. Çünkü ToInt16'nın içinde Short'un değer aralığı bulunmaktadır.
            // UShort: 0 - 65535 arasında değerler alır. U = Unsigned demektir. Yani negatif değerleri alamaz. Kullanımı short ile aynıdır. Int16 ile kullanımı yoktur.

            // ShortAtamaveKlavyedenDegerGirme();

            ShortConvertToInt16Donusumu();

            Console.Read();


        }

        private static void ShortConvertToInt16Donusumu()
        {
            short s1, s2, toplam;
            Console.Write("1. Sayıyı Giriniz: ");
            s1 = short.Parse(Console.ReadLine());
            Console.Write("2. Sayıyı Giriniz: ");
            s2 = short.Parse(Console.ReadLine());
            toplam = Convert.ToInt16(s1 + s2);
            Console.Write("Sayıların Toplamı: " + toplam);
        }

        private static void ShortAtamaveKlavyedenDegerGirme()
        {
            short sayi1, sayi2, toplam;
            Console.Write("1. Sayı: ");
            sayi1 = short.Parse(Console.ReadLine());
            Console.Write("2. Sayı: ");
            sayi2 = short.Parse(Console.ReadLine());
            toplam = (short)(sayi1 + sayi2);
            Console.WriteLine("Sayıların Toplamı: " + toplam);
        }
    }
}
