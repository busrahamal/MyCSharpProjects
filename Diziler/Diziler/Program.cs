using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //String Türünde Dizi Tanımlama: string [] renkler = {"sarı", "mavi", "yeşil", "kırmızı"};
            //Int Türünde Dizi Tanımlama: int [] sayilar = {10, 20, 30, 40, 50, 60, 70};

            //DizininButunElemanlariniEkranaYazdirma();

            //DizilerİcindeKararYapisiKulanimi();

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int toplam = 0;

            for(int i = 0; i<numbers.Length;i++)
            {
                toplam += numbers[i];
            }

            Console.Write("Toplam: "+toplam);

            Console.Read();

        }

        private static void DizilerİcindeKararYapisiKulanimi()
        {
            int[] degerler = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
            for (int i = 0; i < degerler.Length; i++)
            {
                if (degerler[i] % 20 == 0 | degerler[i] % 30 == 0)
                {
                    Console.WriteLine(degerler[i]);
                }
            }
        }

        private static void DizininButunElemanlariniEkranaYazdirma()
        {
            int[] notlar = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            for (int i = 0; i < notlar.Length; i++)
            {
                Console.WriteLine(notlar[i]);
            }
        }
    }
}
