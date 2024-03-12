namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // FOR DÖNGÜSÜ ÖRNEK 1
            for (int r = 1; r <= 10; r++)
            {
                Console.WriteLine(r);
            }
            Console.ReadLine();

            //ÖRNEK 2
            for (int r = 2; r <= 10; r += 2)
            {
                Console.WriteLine(r);
            }
            Console.ReadLine();

            //ÖRNEK 3

            for (int r = 1; r <= 10; r++)
            {
                for (int j = 1; j >= r; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine("");
            }
            Console.ReadLine();

            // WHİLE DÖNGÜSÜ

            //1 DEN 10 A KADAR OLAN SAYILARI YAZDIRALIM

            int a = 1;

            while (a <= 1)
            {
                Console.WriteLine(a);
                a++;
            }
            Console.ReadLine();

            // 100 DEN 0 A KADAR OLAN SAYILARIN ÇİFT OLANLARINI BÜYÜKTEN KÜÇÜĞE YAZDIRALIM

            int b = 100;

            while (b>=0)
            {
                Console.WriteLine(b);
                b -= 2;
            }
            Console.ReadLine();

            //DoWhile DÖNGÜSÜ

            //1 DEN 10 A KADAR OLAN SAYILARI EKRANA YAZDIRALIM
            
            int c = 1;

            do
            {
                Console.WriteLine(c);
                c++;
            } while (c <= 10);
            Console.ReadLine();

            // 1 DEN 100 E KADAR OLAN SAYILARIN TOPLAMINI EKRANA YAZDIRALIM 

            int d = 1;
            int toplam = 0;

            do
            {
                toplam += d;
                d++;
            } while (d<=100);
            Console.WriteLine("1 den 100 e kadar olan sayıların toplamı : " + toplam);
            Console.ReadLine();
        }
    }
}