using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinifNiteliklerineKlavyedenDegerGirisi
{
    class Program
    {
        static void Main(string[] args)
        {
            Kisiler k = new Kisiler();
            Console.WriteLine(" ***** Kişi Bilgileri ***** ");
            Console.WriteLine();
            Console.Write("Id Giriniz: ");
            k.id = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Ad Giriniz: ");
            k.ad = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Soyad Giriniz: ");
            k.soyad = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Yaş Giriniz: ");
            k.yas = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Doğum Yeri Giriniz: ");
            k.dogumYeri = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Meslek Giriniz: ");
            k.meslek = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("----- Kişi Bilgileriniz -----");
            Console.WriteLine();

            Console.WriteLine(k.id + " - " + k.ad + " " + k.soyad + ", " + k.yas + ", " + k.dogumYeri + ", " + k.meslek);

            Console.Read();




        }
    }
}
