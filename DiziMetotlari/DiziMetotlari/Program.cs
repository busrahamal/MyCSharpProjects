using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziMetotlari
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Dizi Metotları
             --------------------------
             * Sort: Dizideki verileri küçükten büyüğe sıralar. Sayılarda 1-2-3 gibi, string ifadelerde a, b, c olacak şeklinde sıralama yapar.
             
             * Reverse: Diziyi tersten yazar. a-b-c yi c-b-a şeklinde yazar.
             
             * IndexOf: Aranan değerin index sırasını döndürür. a, b, c olduğunda IndexOf("a") 0 değerini döndürür.
             
             * Max: Dizideki en büyük elemanı verir.
             
             * Min: Dizideki en küçük elemanı verir.
             
             * Length: Dizinin uzunluğunu verir.          
             
             */


            //SortKullanimi();
            //SortveReverseKullanimi();
            //IndexOfKullanimi();

            MinMaxKullanimi();
            Console.Read();

        }

        private static void MinMaxKullanimi()
        {
            int[] degerler = { 25, 96, 32, 58, 47, 33 };
            Console.WriteLine("Dizideki Minimum Deger: " + degerler.Min());
            Console.WriteLine("Dizideki Maksimum Değer: " + degerler.Max());
        }

        private static void IndexOfKullanimi()
        {
            int[] sayilar = { 20, 30, 40, 90, 56 };
            Console.WriteLine(Array.IndexOf(sayilar, 20));  // Array.IndexOf(diziadı, aranacakdeğer);
        }

        private static void SortveReverseKullanimi()
        {
            string[] isimler = { "Ali", "Ahmet", "Ayşe", "Fatma", "Hayriye" };
            Array.Sort(isimler);        // A'dan Z'ye sıralar.
            Array.Reverse(isimler);     // Z'den A'ya sıralar.

            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine(isimler[i]);
            }
        }

        private static void SortKullanimi()
        {
            int[] sayilar = { 18, 10, 20, 64, 45, 58, 95, 22 };
            Array.Sort(sayilar);

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }
        }
    }
}
