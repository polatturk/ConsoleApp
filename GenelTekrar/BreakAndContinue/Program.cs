namespace BreakAndContinue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 10; r++)
            {

                if (r == 7)
                {
                    break;
                }
                Console.WriteLine(r);
            }
            Console.ReadLine();
        }
    }
}