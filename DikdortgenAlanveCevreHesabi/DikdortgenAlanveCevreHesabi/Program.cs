using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DikdortgenAlanveCevreHesabi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Dikdörtgen Alan ve Çevre Hesaplama Uygulaması ***");

            Console.WriteLine(); //degiskenAdi = Camel, DegiskenAdi = Pascal standardı

            int uzunKenar, kisaKenar, alan, cevre;

            Console.Write("Uzun Kenarı Giriniz: ");
            uzunKenar = Convert.ToInt32(Console.ReadLine()); //ReadLine string olduğu için Int'e çevirdik

            Console.Write("Kısa Kenarı Giriniz: ");
            kisaKenar = Convert.ToInt32(Console.ReadLine());

            alan = uzunKenar * kisaKenar;
            cevre = 2 * (uzunKenar + kisaKenar);

            Console.WriteLine();
            Console.WriteLine("Uzun kenarı {0}, kısa kenarı {1} olan dikdörtgenin alanı {2}, çevresi ise {3} olarak hesaplanmıştır.", uzunKenar, kisaKenar, alan, cevre);

            Console.Read();


        }
    }
}
