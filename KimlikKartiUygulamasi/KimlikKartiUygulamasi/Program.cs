using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimlikKartiUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** KİMLİK KARTI UYGULAMASI ***");
            Console.WriteLine();
            string adi, soyadi, universite, sehir, bolum;
            Console.Write("Adı: ");
            adi = Console.ReadLine();
            Console.Write("Soyadı: ");
            soyadi = Console.ReadLine();
            Console.Write("Şehir: ");
            sehir = Console.ReadLine();
            Console.Write("Üniversite: ");
            universite = Console.ReadLine();
            Console.Write("Bölüm: ");
            bolum = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Adı {0} Soyadı {1} olan öğrenci, {2} şehrinde bulunan {3} Üniversitesinde {4} Bölümünü okumaktadır.",adi, soyadi, sehir, universite, bolum);
            Console.Read();
        }
    }
}
