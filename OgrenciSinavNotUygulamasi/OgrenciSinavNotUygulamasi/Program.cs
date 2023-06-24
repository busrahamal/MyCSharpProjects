using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciSinavNotUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {

            // Double: Ondalıklı sayılar için kullanılır. Kod kısmında . ile değer girilirken console ekranında değer , ile görünür. 
            //Double değer, a = 5, a = 5d, a = 5D şeklinde girilir.
            Console.WriteLine("*** Öğrenci Sınav Not Uygulaması ***");
            Console.WriteLine();

            string adi, soyadi, bolum, ders;
            double vize, final, ortalama;

            Console.Write("Ad: ");
            adi = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Soyad: ");
            soyadi = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Bölüm: ");
            bolum = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Ders: ");
            ders = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("--- Notlar ---");
            Console.WriteLine();
            Console.Write("Vize Notu: ");
            vize = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Final Notu: ");
            final = Convert.ToDouble(Console.ReadLine());

            ortalama = (((vize * 40)/100) + ((final * 60)/100));

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("||| Öğrenci Bilgileri |||");

            Console.WriteLine();
          
            Console.WriteLine("Öğrencinin Adı Soyadı: {0} {1}", adi, soyadi);
            Console.WriteLine("Bölümü: {0}", bolum);
            Console.WriteLine("Dersi: {0}", ders);
            Console.WriteLine("Öğrencinin Not Ortalaması: {0}", ortalama);

            Console.Read();
        }
    }
}
