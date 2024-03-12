namespace BedenKitleIndeksi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // beden kitle indeksi = kilo / boy*boy
            // beden kitle indeksi 18'e eşit veya düşükse ZAYIF
            // 18 ile 25 arasındaysa NORMAL 
            // 25 ' ten büyükse OBEZ yazdıran program yapın

            Console.WriteLine("boyunuzu giriniz");
            double boy=Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("kilonuzu giriniz");
            int kilo = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            double indeks = (kilo / boy*boy);

            if (indeks <=18)
            {
                Console.WriteLine("ZAYIF");
                Console.ReadLine();

            }
            else if (indeks >18 && indeks <25)
            {
                Console.WriteLine("NORMAL");
                Console.ReadLine();
            }
            else if(indeks >25)
            {
                Console.WriteLine("OBEZ");
                Console.ReadLine();
            }

        }
    }
}