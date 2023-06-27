using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiYarismasi1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Bilgi Yarışmamıza Hoşgeldiniz ***");
            Console.WriteLine();
            Console.WriteLine("Yarışma İle İlgili Kurallar");
            Console.WriteLine();
            Console.WriteLine("1- Yarışmamız 4 sorudan oluşmaktadır.");
            Console.WriteLine("2- Her soruda 4 şık bulunmaktadır.");
            Console.WriteLine("3- Diğer soruyu görebilmek için, mevcut soruyu doğru cevaplamanız gerekmektedir.");
            Console.WriteLine("4- Yanlış cevap verilmesi durumunda yarışma sona erecektir.");
            Console.WriteLine("5- 4 sorunun tamamının doğru cevaplanması durumunda yarışma kazanılacaktır.");
            Console.WriteLine();
            Console.WriteLine("GOOD LUCK :)");
            Console.WriteLine();
            Console.WriteLine("SORULAR");
            Console.WriteLine();

            int soru = 1, skor = 0;
            char cevap;

            if (soru == 1)
            {
                Console.WriteLine("{0}. Soru: Türkiye'nin Başkenti Neresidir?", soru);
                Console.WriteLine();
                Console.WriteLine("A - Ankara");
                Console.WriteLine("B - İstanbul");
                Console.WriteLine("C - İzmir");
                Console.WriteLine("D - Eskişehir");
                Console.WriteLine();
                Console.Write("Cevabınız: ");
                cevap = Convert.ToChar(Console.ReadLine());

                if (cevap == 'A' | cevap == 'a')
                {
                    soru = soru += 1;
                    skor = skor + 25;
                    Console.WriteLine("Tebrikler.. Skorunuz: " + skor);
                    Console.WriteLine("{0}. soruya geçmeye hak kazandınız. {0}. soru geliyor..",soru);
                    Console.WriteLine();
                }

                else
                {
                    Console.Write("Yanlış cevap verdiğiniz için {0}. soruya geçemezsiniz. Skorunuz: {1}", soru+1, skor);
                }

            }

            if (soru == 2)
            {
                Console.WriteLine("{0}. Soru: Türkiye'de kaç coğrafi bölge bulunmaktadır?", soru);
                Console.WriteLine();
                Console.WriteLine("A - 5");
                Console.WriteLine("B - 6");
                Console.WriteLine("C - 7");
                Console.WriteLine("D - 8");
                Console.WriteLine();
                Console.Write("Cevabınız: ");
                cevap = Convert.ToChar(Console.ReadLine());

                if (cevap == 'C' | cevap == 'c')
                {
                    soru = soru += 1;
                    skor = skor + 25;
                    Console.WriteLine("Tebrikler.. Skorunuz: " + skor);
                    Console.WriteLine("{0}. soruya geçmeye hak kazandınız. {0}. soru geliyor..", soru);
                    Console.WriteLine();
                }

                else
                {
                    Console.Write("Yanlış cevap verdiğiniz için {0}. soruya geçemezsiniz. Skorunuz: {1}", soru+1, skor);
                }

            }

            if(soru == 3)
            {
                Console.WriteLine("{0}. Soru: Osmaniye ilimiz hangi coğrafi bölgemizde yer almaktadır?", soru);
                Console.WriteLine();
                Console.WriteLine("A - Güneydoğu Anadolu Bölgesi");
                Console.WriteLine("B - Akdeniz Bölgesi");
                Console.WriteLine("C - Ege Bölgesi");
                Console.WriteLine("D - Doğu Anadolu Bölgesi");
                Console.WriteLine();
                Console.Write("Cevabınız: ");
                cevap = Convert.ToChar(Console.ReadLine());

                if(cevap == 'B' | cevap == 'b')
                {
                    soru += 1;
                    skor += 25;
                    Console.WriteLine("Tebrikler.. Skorunuz: " + skor);
                    Console.WriteLine("{0}. soruya geçmeye hak kazandınız. {0}. soru geliyor..", soru);
                    Console.WriteLine();
                }

                else
                {
                    Console.Write("Yanlış cevap verdiğiniz için {0}. soruya geçemezsiniz. Skorunuz: {1}",soru+1, skor);
                }
            }

            if(soru == 4)
            {
                Console.WriteLine("{0}. Soru: Aşağıdakilerden hangisi Türkiye'de bulunan illerden biridir?", soru);
                Console.WriteLine();
                Console.WriteLine("A - Bakü");
                Console.WriteLine("B - Düsseldorf");
                Console.WriteLine("C - Londra");
                Console.WriteLine("D - İstanbul");
                Console.WriteLine();
                Console.Write("Cevabınız: ");
                cevap = Convert.ToChar(Console.ReadLine());

                if(cevap == 'D' | cevap == 'd')
                {
                    skor += 25;
                    Console.Write("Tebrikler.. Tüm soruları bildiniz. Skorunuz: "+skor);
                }

                else
                {
                    Console.Write("Yanlış cevap verdiğiniz için yarışma burada sona ermiştir. Skorunuz: " + skor);
                }
            }

            Console.Read();

        }
    }
}
             
            
       
        

    





