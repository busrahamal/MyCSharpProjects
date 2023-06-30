using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakteriSayisiHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             - Bir bakteri türü her saatin sonunda kendini 2'ye bölerek çoğalmaktadır.
             - Yeni oluşan bakteriler de aynı şekilde çoğalmaktadır.
             - 24 saatin sonunda bu ortamda kaç tane bakteri olur?
             
             
             */
            int bakteriSayisi = 1;
            
            for(int i = 1; i<=24; i++)
            {
                bakteriSayisi = bakteriSayisi * 2;
                Console.WriteLine("{0}. Saatin Sonundaki Bakteri Sayısı: {1}",i,bakteriSayisi);
            }

            Console.Read();
        }
    }
}
