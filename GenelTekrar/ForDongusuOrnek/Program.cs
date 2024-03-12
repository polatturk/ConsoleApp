namespace ForDongusuOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kullanıcıdan bir sayı alacağız 0 dan başlayıp aldığımız sayıya kadar toplaycağız ve girdiği sayıya böleceğiz
            // eğer ortalama 50 den büyükse ortalama 50 den büyüktür değilse tersini yazdıralım

            Console.WriteLine("lütfen bir sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;

            for (int i = 1; i <= sayi; i++)
            {
                toplam += i;
            }
            double ortalama = toplam / sayi;
            if (ortalama > 50)
            {
                Console.WriteLine("ortalamanız 50 den büyüktür");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("ortalamanız 50 den küçüktür");
                Console.ReadLine();
            }
        }
    }
}