using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegiskenlerdeMinMaxValue
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Float Minimum Değer: "   + float.MinValue);
            Console.WriteLine("Float Maksimum Değer: "  + float.MaxValue);
            Console.WriteLine();

            Console.WriteLine("Double Minimum Değer: "  + double.MinValue);
            Console.WriteLine("Double Maksimum Değer: " + double.MaxValue);
            Console.WriteLine();

            Console.WriteLine("SByte Minimum Değer: "   + sbyte.MinValue);
            Console.WriteLine("SByte Maksimum Değer: "  + sbyte.MaxValue);
            Console.WriteLine();

            Console.WriteLine("Byte Minimum Değer: "    + byte.MinValue);
            Console.WriteLine("Byte Maksimum Değer: "   + byte.MaxValue);
            Console.WriteLine();

            Console.WriteLine("Short Minimum Değer: "   + short.MinValue);
            Console.WriteLine("Short Maksimum Değer: "  + short.MaxValue);
            Console.WriteLine();

            Console.WriteLine("UShort Minimum Değer: "  + ushort.MinValue);
            Console.WriteLine("UShort Maksimum Değer: " + ushort.MaxValue);            
            Console.WriteLine();

            Console.WriteLine("Int Minimum Değer: "     + int.MinValue);
            Console.WriteLine("Int Maksimum Değer: "    + int.MaxValue);
            Console.WriteLine();

            Console.WriteLine("Decimal Minimum Değer: " + decimal.MinValue);
            Console.WriteLine("Decimal Maksimum Değer: "+ decimal.MaxValue);
            Console.WriteLine();         

            Console.Read();
        }
    }
}
