namespace SwitchCaseYapisi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıya nasıl bir işlem yapmak istediğini soralım
            //1 - BAKİYE GÖRÜNTÜLE
            //2 - PARA ÇEKME
            //3 - PARA YATIRMA
            //4-ÇIKIŞ

            int bakiye = 1000;

            Console.WriteLine("ATM YE HOŞGELDİNİZ");
            Console.WriteLine("LÜTFEN BİR İŞLEM SEÇİNİZ");

            Console.WriteLine("1 - BAKİYE GÖRÜNTÜLE");
            Console.WriteLine("2 - PARA ÇEKME");
            Console.WriteLine("3 - PARA YATIRMA");
            Console.WriteLine("4 - ÇIKIŞ");

            string secim = Console.ReadLine();

            switch (secim) 
            {
                case "1":
                 Console.WriteLine("Bakiyeniz : "+bakiye);
                    Console.ReadLine();
                    break;

                case "2":
                    Console.WriteLine("çekmek istediğiniz tutarı giriniz");
                    int cekilecektutar=Convert.ToInt32(Console.ReadLine());

                    if (cekilecektutar>bakiye)
                    {
                        Console.WriteLine("Bakiyenizden fazla tutar çekemezsiniz");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("kalan bakiyeniz : " + (bakiye - cekilecektutar));
                        Console.ReadLine();
                    }
                    break;
                case "3":
                    Console.WriteLine("Yatırmak istediğiniz tutarı giriniz");
                    int yatirilacaktutar=Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("yeni bakiyeniz : " + (bakiye+yatirilacaktutar));
                    Console.ReadLine();
                    break;

                    case "4":
                    Console.WriteLine("Hesabınızdan Çıkış yapılıyor İyi Günler...");
                    break;
                    Console.ReadLine();

                    default:
                    Console.WriteLine("Lütfen geçerli bir değer giriniz!");
                    break;
                    Console.ReadLine() ;

            }

        }
    }
}