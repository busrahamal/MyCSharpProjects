using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachDongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Foreach Döngüsü
             
             * Dizilerle beraber kullanılan döngü türüdür.
             * 4 temel parametresi vardır: 
             
             * 1- değişken türü (dizinin değişken türü ile aynı olmalıdır.)
             * 2- değişken adı
             * 3- in (içinden) komutu
             * 4- dizi adı
             
             */

            //ForeachKullanimi();

            //ForeachİleDizidekiDegerleriToplama();

            //ForeachİleDizidekiDegerleriCarpma();

            ForeachİleDizidekiCiftDegerleriEkranaYazdirma();

            Console.Read();

        }

        private static void ForeachİleDizidekiCiftDegerleriEkranaYazdirma()
        {
            int[] sayilar = { 15, 25, 36, 98, 47, 52 };

            foreach (int s in sayilar)
            {
                if (s % 2 == 0)
                {
                    Console.WriteLine(s);
                    Array.Sort(sayilar);
                }
            }
        }

        private static void ForeachİleDizidekiDegerleriCarpma()
        {
            int[] degerler = { 1, 2, 3, 4, 5, 6 };
            int carpim = 1;

            foreach (int d in degerler)
            {
                carpim *= d;
            }

            Console.Write("Dizideki Değerlerin Çarpımı: " + carpim);
        }

        private static void ForeachİleDizidekiDegerleriToplama()
        {
            int[] notlar = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            int toplam = 0;

            foreach (int n in notlar)
            {
                toplam += n;
            }

            Console.Write("Dizideki Değerlerin Toplamı: " + toplam);
        }

        private static void ForeachKullanimi()
        {
            string[] sehirler = { "Kocaeli", "Konya", "Eskişehir", "Bursa", "Mersin", "İzmir" };

            foreach (string sehir in sehirler)
            {
                Console.WriteLine(sehir);
            }
        }
    }
}
