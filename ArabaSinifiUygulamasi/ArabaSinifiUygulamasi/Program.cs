using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabaSinifiUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Yeni Sınıf Ekleme Yöntemleri
             
            1- Project / Add Class / Class / İsim ver.cs / Add
            2- View / Solution Explorer / projenin üstüne Sağ tık / Add / Class
             
             */

            Araba newCar = new Araba();
            // 4 tane metot geldi. Bunun sebebi Araba classımızda niteliklerin erişim belirleyicilerini public yapmadığımız için varsayılan olarak private olarak algılanmasıdır. Bu yüzden Araba classımızda niteliklere public eklemesi yaptık. 

            newCar.marka = "Range Rover";
            newCar.model = "2023";
            newCar.hiz = 300;
            newCar.motorGucu = 1.6;
            newCar.renk = "Siyah";

            Console.WriteLine("**** Arabanızın Özellikleri **** ");
            Console.WriteLine();
            Console.WriteLine("Markası: " + newCar.marka);
            Console.WriteLine("Modeli: " + newCar.model);
            Console.WriteLine("Hızı: " + newCar.hiz);
            Console.WriteLine("Motor Gücü: " + newCar.motorGucu);
            Console.WriteLine("Rengi: " + newCar.renk);

            Console.Read();

        }
    }
}
