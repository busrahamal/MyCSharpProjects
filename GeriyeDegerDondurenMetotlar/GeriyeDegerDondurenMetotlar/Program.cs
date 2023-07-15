using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeriyeDegerDondurenMetotlar
{
    class Program
    {

        public static int karesiniHesapla()
        {
            Console.Write("Karesi Hesaplanacak Sayıyı Giriniz: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int kare = x * x;
            Console.Write("Girdiğiniz Sayının Karesi: ");
            return kare;
        }

       public static int toplama (int x, int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            //Console.Write(karesiniHesapla());
            int s1, s2;
            Console.Write("Birinci Sayıyı Giriniz: ");
            s1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("İkinci Sayıyı Giriniz: ");
            s2 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Girilen Sayıların Toplamı: " +toplama (s1, s2));
            Console.WriteLine();
            Console.Write(toplama(6,15));
            Console.Read();
        }
    }
}
