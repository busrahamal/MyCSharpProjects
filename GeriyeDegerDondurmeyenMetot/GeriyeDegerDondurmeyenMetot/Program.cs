using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeriyeDegerDondurmeyenMetot
{
    class Program
    {
        public static void denemeMetodu() //public: erişim belirleyici static void (sınıftan nesne üretmiyoruz demek) metotAdı()
        {
            Console.WriteLine("Bu bir deneme metodudur.");
        }

        public static void MetinYaz(string metin)
        {
            Console.WriteLine("***** {0} *****", metin);
        }

        public static void DegerAl(string deger)
        {
           Console.Write("Girdiğiniz Deger: " + deger);
        }

        public static void DegerAl2()
        {
            Console.Write("Bir Değer Yazınız: ");
            string deger2 = Console.ReadLine();
            Console.WriteLine("Yazılan Değer: "+deger2);

        }
        static void Main(string[] args)
        {
            //denemeMetodu();
            //MetinYaz("Büşra HAMAL");
            //Console.Write("Bir Değer Giriniz: ");
            //string kelime = Console.ReadLine();
            //DegerAl(kelime);
            DegerAl2();
            Console.Read();
        }
    }
}
