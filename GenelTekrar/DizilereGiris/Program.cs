namespace DizilereGiris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int

            int[] sayilar = new int[4];

            sayilar[0] = 10;
            sayilar[1] = 20;
            sayilar[2] = 30;
            sayilar[3] = 40;

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }
            Console.ReadLine();

            //string

            string[] isimler = { "Polat", "Ali", "Ahmet", "Mehmet" };

            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine(isimler[i]);
            }
            Console.ReadLine();

            //double

            double[] ondaliklisayilar = {1.44,7.66,8.34,10.5 };

            for(int i = 0;i<ondaliklisayilar.Length;i++)
            {
                Console.WriteLine(ondaliklisayilar[i]);
            }
            Console.ReadLine();

            //char

            char[] karakterler = { 'P', 'R', 'A', 'D', 'A' };

            for (int i = 0; i < karakterler.Length; i++)
            {
                Console.WriteLine(karakterler[i]);
            }
            Console.ReadLine();

            //dizinin elemamlarını kullanıcıdan alıp ekrana yazdıralım 

            int[] sayi = new int[4];

            for (int i = 0; i < sayi.Length; i++)
            {
                Console.Write("sayi Dizisininin" + (i+1) + ". index değerini giriniz : ");

                sayi[i] =Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("**************");

            for (int i = 0; i < sayi.Length; i++)
            {
                Console.WriteLine(sayi[i]);
            }
            Console.ReadLine();
        }
    }
}