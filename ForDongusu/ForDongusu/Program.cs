using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            // SifirdanYirmiyeKadarCiftSayilar();

            BirdenYuzeKadarSayilar();

            Console.Read();
        }

        private static void BirdenYuzeKadarSayilar()
        {
            for (int i = 1; i <= 100; i++) // i++ == i = i + 1 == i += 1
            {
                Console.WriteLine("{0}. Dünyalı Merhaba. Biz Dostuz.", i);
            }
        }

        private static void SifirdanYirmiyeKadarCiftSayilar()
        {
            for (int i = 0; i <= 20; i = i + 2) // i + = 2
            {
                Console.WriteLine(i);
            }
        }
    }
}
