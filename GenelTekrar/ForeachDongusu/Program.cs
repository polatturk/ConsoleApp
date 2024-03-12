namespace ForeachDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = { "polat", "rabia", "ahmet", "mehmet" };

            foreach (string r in isimler)
            {
                Console.WriteLine(r);
            }
            Console.ReadLine();


        }
    }
}