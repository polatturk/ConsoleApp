namespace TurDonusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //STRİNG VERİ TİPİNDEN İNT VERİ TİPİNE DÖNÜŞTÜRME YAPTIK

            string sayi1 = "1";
            string sayi2 = "2";

            int a = Convert.ToInt32(sayi1);
            int b = Convert.ToInt32(sayi2);

            //İNT VERİ TİPİNDEN STRİNG VERİ TİPİNE DÖNÜŞTÜRME YAPTIK

            int sayi3 = 5;
            int sayi4 = 10;

            string c = sayi1.ToString();
            string d = sayi2.ToString();

            Console.WriteLine(c + d);
            Console.ReadLine();

            //DOUBLE VERİ TİPİNDEN İNT VERİ TİPİNE DÖNÜŞTÜRME YAPTIK

            double sayi = 5.22;
            int e = Convert.ToInt32(sayi);

            Console.WriteLine(e);
            Console.WriteLine(sayi.GetType());
            Console.ReadLine();

            //Kullancıdan 2 tane sayı alan ve ikisinin toplamını ekrana yazdıran programı yapın

            Console.WriteLine("1.sayınızı giriniz");
            string sayi6 = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("2.sayınızı giriniz");
            string sayi7 = Console.ReadLine();
            Console.Clear();

            int X = Convert.ToInt32(sayi1);
            int P = Convert.ToInt32(sayi2);

            Console.WriteLine(a + b);
            Console.ReadLine();



        }
    }
}