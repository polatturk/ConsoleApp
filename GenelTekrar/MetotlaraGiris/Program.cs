using System;

namespace MetotlaraGiris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Parametresiz - geriye değer döndürmeyen metot tanımlama..

            selamver();
            adiniyaz();
            toplamayap(5,7);

            static void selamver()
            {
                Console.WriteLine("selamlar :" );
                Console.ReadLine();
            }

            static void adiniyaz()
            {
                Console.WriteLine("polat:)");
                Console.ReadLine();
            }

            // Parametre alan - geriye değer döndüren metot tanımlama..

            static void toplamayap(int sayi1, int sayi2)
            {
                Console.WriteLine("gönderilen sayilarin toplami :"+ (sayi1+sayi2));

            }


        }
    }
}