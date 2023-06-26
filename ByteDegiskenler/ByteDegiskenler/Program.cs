using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteDegiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            // byte = 0 - 255 arasında değerler alır. 0 ve 255 i de alır.
            // Atama işlemi yaparken ve kullanıcıdan veri isterken Convert.ToByte() dönüşümünü kullanmalıyız.
            // 255'ten daha büyük, 0'dan daha küçük değerler vereceksek int kullanmalıyız.
            // Yapılan işlemin sonucu da 255 ten büyük, 0'dan küçük olmamalıdır. Bu durumda int kullanılmalıdır. 

            // Sbyte : -128 ile +127 arasında değer alır.
            // S = Signed yani imzalanmış demektir. Başında S olan değişken tipleri negatif değerler de alabilir.
            // Byte da Sbyte da 256 karakter alır. Byte 0 - 255, Sbyte ise -128 - +127 ye kadar değer alır. 
            // SByte'ın kullanım şekli Byte ile aynıdır.

            //ByteKullanicidanDegerAlma();

            byte sayi1, sayi2, carpim;

            Console.Write("1. Sayı: ");
            sayi1 = Convert.ToByte(Console.ReadLine());
            Console.Write("2. Sayı: ");
            sayi2 = Convert.ToByte(Console.ReadLine());
            carpim = Convert.ToByte(sayi1 * sayi2);
            Console.WriteLine("{0} x {1} = {2}", sayi1, sayi2, carpim);

            Console.Read();



        }

        private static void ByteKullanicidanDegerAlma()
        {
            byte not;
            Console.Write("Notunuzu Giriniz: ");
            not = Convert.ToByte(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Notunuz: " + not);
        }

    }

       

        
}
