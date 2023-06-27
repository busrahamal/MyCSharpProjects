using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatDegiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Float, ondalıklı değerler alır. Double ile aynıdır ancak doubledan daha küçük değerler alır.
            // Kod kısmında ondalık değer girerken değerin sonunda f ya da F eklenmelidir. F eklenmezse onu double olarak kabul ediyor ve double floata çevrilemedi hatası veriyor.
            // Kod kısmında . ile değer girilir.

            //FloatKodKismindaDegerGirme();

            //Float'a dönüştürme işlemi float.Parse() metoduyla gerçekleşir.
            FloatKlavyedenDegerGirmeveDonusturme();

        }

        private static void FloatKlavyedenDegerGirmeveDonusturme()
        {
            float sayi1, sayi2, toplam;
            Console.Write("1. Sayı: ");
            sayi1 = float.Parse(Console.ReadLine()); // Console.ReadLine() string olduğu için floata dönüştürdük
            Console.Write("2. Sayı: ");
            sayi2 = float.Parse(Console.ReadLine());
            toplam = sayi1 + sayi2;
            Console.Write("Sayıların Toplamı: " + toplam);

            Console.Read();
        }

        private static void FloatKodKismindaDegerGirme()
        {
            float sayi = 142.58F;
            Console.Write(sayi);
            Console.Read();
        }
    }
}
