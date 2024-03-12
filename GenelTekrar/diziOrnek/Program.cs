namespace diziOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcının girdiği sayı dizinin içinde var mı?
            //kontrol eden varsa kaç tane olduğunu söyleyen
            //yoksa da yoktur diyen programı yazalım 

            int[] sayilar = { 10,20,30,40,50,40,50,70,55,65,70,55,65,5,20,35,65,80};
            int adet = 0;
            int sayi;

            Console.WriteLine("lütfen bir sayı giriniz");

            sayi=Convert.ToInt32(Console.ReadLine);

            for(int i = 0; i < sayilar.Length;i++)
            {
                if(sayi == sayilar[i])
                {
                    adet++;
                }
            }

            if(adet == 0) 
            {
                Console.WriteLine("girdiğiniz değer dizide bulunamadı");
            }
            else
            {
                Console.WriteLine("girdiğiniz sayı dizide bulundu..");
                Console.WriteLine("adet : "+ adet);

            }
            Console.ReadLine();


        }   
    }
}