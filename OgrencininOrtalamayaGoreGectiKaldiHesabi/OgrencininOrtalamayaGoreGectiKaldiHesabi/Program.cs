using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrencininOrtalamayaGoreGectiKaldiHesabi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Öğrencinin Ortalamaya göre Geçti kaldı Hesabı ***");
            Console.WriteLine();

            float sinav1, sinav2, ortalama;

            Console.Write("1. Sınav Notu: ");
            sinav1 = float.Parse(Console.ReadLine());

            Console.Write("2. Sınav Notu: ");
            sinav2 = float.Parse(Console.ReadLine());

            ortalama = (sinav1 + sinav2) / 2;

            Console.WriteLine("Öğrencinin Ortalaması: "+ortalama);

            if(ortalama < 50)
            {
                Console.Write("Öğrenci Dersten Kalmıştır..");
            }

            else if(ortalama >= 50)
            {
                Console.Write("Öğrenci Dersten Geçmiştir...");
            }

            else
            {
                Console.Write("Yanlış ya da Eksik Bir Not Girişi Yaptınız.. ");
            }

            Console.Read();
        }
    }
}
