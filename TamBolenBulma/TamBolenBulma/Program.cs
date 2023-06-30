using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamBolenBulma
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.Write("Tam Bölenlerinin Hesaplanmasını İstediğiniz Sayıyı Giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= sayi; i++) // Ctrl + K + D: Gerekli boşlukları ayarlar.
            {
                if (sayi % i == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.Read();
        }
    }
}
