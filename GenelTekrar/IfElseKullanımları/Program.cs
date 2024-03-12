namespace IfElseKullanımlari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ÖĞRENCİNİN NOTU 50 DEN BÜYÜKSE BAŞARILI DEĞİL İSE BAŞARISIZ OLSUN 

            Console.WriteLine("1.Notunuzu giriniz ");
            string sayi1 = Console.ReadLine();
            Console.Clear();

            int a = Convert.ToInt32(sayi1);

            if (a >= 50)
            {
                Console.WriteLine("BAŞARILI");
            }
            else
            {
                Console.WriteLine("BAŞARISIZ");
            }
            Console.ReadLine();


            //Kullanıcıdan 3 tane not alan ve bu notların ortalamasını bulan eğer
            // 80 - 100 arasındaysa A+yazdıran
            // 60 - 80 arasındaysa A yazdıran
            // 40 - 60 arasındaysa B+yazdıran
            // 40 dan küçük ise F yazdıran programı yapın


            Console.WriteLine("1.notunuz ? ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("2.notunuz ? ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("3.notunuz ? ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            int sonuc = (x + b + c) / 3;

            if (sonuc > 80 && sonuc < 100)
            {
                Console.WriteLine("A+");
            }
            else if (sonuc > 60 && sonuc < 80)
            {
                Console.WriteLine("A");
            }
            else if (sonuc > 40 && sonuc < 60)
            {
                Console.WriteLine("B+");
            }
            else
            {
                Console.WriteLine("F");
            }
            Console.ReadLine();


        }
    }
}