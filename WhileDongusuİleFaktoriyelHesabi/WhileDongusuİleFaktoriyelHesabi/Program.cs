using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileDongusuİleFaktoriyelHesabi
{
    class Program
    {
        static void Main(string[] args)
        {
            int faktoriyeliBulunacakSayi, faktoriyel = 1, i = 1;
            Console.Write("Faktöriyel Değerini Öğrenmek İstediğiniz Sayıyı Giriniz: ");
            faktoriyeliBulunacakSayi = Convert.ToInt32(Console.ReadLine());

            while (i <= faktoriyeliBulunacakSayi)
            {
                faktoriyel *= i;
                Console.WriteLine("{0} Sayısının Faktöriyel Değeri: {1}", i, faktoriyel);
                i++;
            }

            Console.Read();


        }
    }
}
