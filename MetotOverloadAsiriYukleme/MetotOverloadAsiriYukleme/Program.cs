using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotOverloadAsiriYukleme
{
    class Program
    {
        public static int carpim(int s1, int s2)
        {
            return s1 * s2;
        }

        public static int carpim (int s1, int s2, int s3)
        {
            return s1 * s2 * s3;
        }
        static void Main(string[] args)
        {
            //Aşırı Yükleme: Görevleri farklı olmak şartıyla aynı isimde birden fazla metot bulunmasıdır.
            Console.WriteLine(carpim(50,30));
            Console.WriteLine(carpim(20,30,40));
            Console.Read();

        }
    }
}
