using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AritmetikDortİslemUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Aritmetik Dört İşlem Uygulaması ***");
            Console.WriteLine();

            int sayi1, sayi2, toplam, fark, carpim, bolum, mod, secim;

            Console.Write("1. Sayıyı Giriniz: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.Write("2. Sayıyı Giriniz: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("--- Yapılabilen İşlem Listesi ---");

            Console.WriteLine();

            Console.WriteLine("1 - Toplama");
            Console.WriteLine("2 - Çıkarma");
            Console.WriteLine("3 - Çarpma");
            Console.WriteLine("4 - Bölme");
            Console.WriteLine("5 - Mod Alma");

            Console.WriteLine();

            Console.Write("Yapılmasını İstediğiniz İşlemin Numarasını Giriniz: ");
            secim = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            if(secim == 1)
            {
                toplam = sayi1 + sayi2;
                Console.Write("Seçmiş Olduğunuz İşlem Toplama İşlemidir. Girilen Sayıların Toplamı: {0} + {1} = {2}",sayi1, sayi2, toplam);
            }

            else if(secim == 2)
            {
                fark = sayi1 - sayi2;
                Console.Write("Seçmiş Olduğunuz İşlem Çıkarma İşlemidir. Girilen Sayıların Farkı: {0} - {1} = {2}", sayi1, sayi2, fark);
            }

            else if (secim == 3)
            {
                carpim = sayi1 * sayi2;
                Console.Write("Seçmiş Olduğunuz İşlem Çarpma İşlemidir. Girilen Sayıların Çarpımı: {0} x {1} = {2}",sayi1, sayi2, carpim);
            }

            else if (secim == 4)
            {
                bolum = sayi1 / sayi2;
                Console.Write("Seçmiş Olduğunuz İşlem Bölme İşlemidir. Girilen Sayıların Bölümü: {0} / {1} = {2}", sayi1, sayi2, bolum);
            }

            else if (secim == 5)
            {
                mod = sayi1 % sayi2;
                Console.Write("Seçmiş Olduğunuz İşlem Mod İşlemidir. Girilen Sayıların Modu: {0} % {1} = {2}", sayi1, sayi2, mod);
            }

            else 
            {
                Console.Write("Üzgünüz :( Liste Dışı Seçim Yaptığınız İçin İşlem Gerçekleştiremiyoruz.");
            }

            Console.Read();
            
        }
    }
}
