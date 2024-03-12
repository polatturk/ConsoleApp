namespace LoginPage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int haksayisi = 3;
            while (true)
            {
                Console.WriteLine("kullanıcı adınızı giriniz");
                string kullaniciAdi=Console.ReadLine();
                Console.WriteLine("şifrenizi giriniz");
                string Sifre=Console.ReadLine();

                if (kullaniciAdi == "polat" && Sifre == "123")
                {
                    Console.WriteLine("TEBRİKLER BAŞARILI BİR ŞEKİLDE GİRİŞ YAPTINIZ");
                    break;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("KULLANICI ADINIZ VEYA ŞİFRENİZ YANLIŞ !");
                    if(haksayisi>0)
                    {
                        haksayisi -= 1;
                        Console.ReadLine();
                    }
                    if(haksayisi==0) 
                    {
                        Console.WriteLine("HAKKINIZ DOLMUŞTUR DAHA GİRİŞ YAPAMAZSINIZ");
                        break;
                        Console.ReadLine();
                    }
                }
            }

        }
    }
}