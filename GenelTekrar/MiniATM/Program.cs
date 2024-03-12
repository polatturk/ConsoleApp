namespace MiniATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
             int bakiye = 1000;
            //kullanıcıya nasıl bir işlem yapmak istediğini soralım
            //1 - BAKİYE GÖRÜNTÜLE
            //2 - PARA ÇEKME
            //3 - PARA YATIRMA
            //Q-ÇIKIŞ

            Console.WriteLine("ATM ye Hoşgeldiniz");
            Console.WriteLine("lütfen hangi işlemi yapmak istediğinizi seçiniz");
            string secim = Console.ReadLine();
            Console.Clear();

            if (secim == "1")
            {
                Console.WriteLine("Şuanki bakiyeniz : " + bakiye);
                Console.ReadLine();
            }
            else if (secim == "2")
            {
                Console.WriteLine("çekmek istediğiniz tutarı giriniz");
                int cekilecektutar = Convert.ToInt32(Console.ReadLine());

                if (cekilecektutar <= bakiye)
                {
                    Console.WriteLine("kalan tutar : " + (bakiye - cekilecektutar));
                }
                else
                {
                    Console.WriteLine("bakiyenizden fazla para çekemezsiniz");
                }
            }
            else if (secim == "3")
            {
                Console.WriteLine("Yatırmak istediğiniz tutar");
                int yatirilacaktutar = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Toplam tutar :" + (bakiye + yatirilacaktutar));
            }
            else if (secim == "4")
            {
                Console.WriteLine("ATM ' den çıkış yapılıyor");
                Console.WriteLine("ATM ' den çıkış yapıldı iyi güngler ...");
            }
            else
            {
                Console.WriteLine("lütfen geçerli bir değer giriniz");
            }

        }
    }
}