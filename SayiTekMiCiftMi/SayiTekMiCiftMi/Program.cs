using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiTekMiCiftMi
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.Write("Bir sayı giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());

            if(sayi % 2 == 0)
            {
                Console.Write("Girmiş olduğunuz {0} sayısı çifttir.", sayi);
            }

            else
            {
                Console.Write("Girmiş olduğunuz {0} sayısı tektir.", sayi);
            }

            Console.Read();
        }
    }
}
