using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziyeKlavyedenDegerGirisi
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sehirler = new string[5];

            for(int i = 0; i < 5; i++) //değerleri hafızaya aldık
            {
                Console.Write("{0}. Şehri Giriniz: ", i+1);
                sehirler[i] = Console.ReadLine();
            }

            Console.WriteLine();

            for(int j = 0; j < 5; j++) //hafızaya alınan değerleri ekrana yazdırdık
            {
                Console.WriteLine("{0}. Şehir: {1}", j+1, sehirler[j]);
            }

            Console.Read();
        }
    }
}
