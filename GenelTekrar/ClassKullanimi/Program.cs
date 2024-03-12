namespace ClassKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Musteri M=new Musteri();
           Urun U = new Urun();

            M.MüsteriAdi = "POLAT";
            M.MüsteriSoyadi = "TÜRK";
            M.MüsteriAdresi = "ŞİŞLİ/MECİDİYEKÖY/34000";
            M.MüsteriGSM = "506*****53";

            M.MüsteriGetir();

            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine("MÜŞTERİ ADI    : " +M.MüsteriAdi);
            Console.WriteLine("MÜŞTERİ SOYADI : " + M.MüsteriSoyadi);
            Console.WriteLine("MÜŞTERİ ADRESİ : " + M.MüsteriAdresi);
            Console.WriteLine("MÜŞTERİ GSM    : " + M.MüsteriGSM);
            Console.ReadLine();

            M.MüsteriAdi = "MURAT";
            M.MüsteriSoyadi = "TAŞ";
            M.MüsteriAdresi = "BEYOĞLU/TAKSİM/34000";
            M.MüsteriGSM = "532*****77";

            Console.WriteLine("MÜŞTERİ ADI    : " + M.MüsteriAdi);
            Console.WriteLine("MÜŞTERİ SOYADI : " + M.MüsteriSoyadi);
            Console.WriteLine("MÜŞTERİ ADRESİ : " + M.MüsteriAdresi);
            Console.WriteLine("MÜŞTERİ GSM    : " + M.MüsteriGSM);
            Console.ReadLine();

            M.MüsteriAdi = "ARDA";
            M.MüsteriSoyadi = "LALECİ";
            M.MüsteriAdresi = "BEŞİKTAŞ/LEVENT/34000";
            M.MüsteriGSM = "538*****06";

            Console.WriteLine("MÜŞTERİ ADI    : " + M.MüsteriAdi);
            Console.WriteLine("MÜŞTERİ SOYADI : " + M.MüsteriSoyadi);
            Console.WriteLine("MÜŞTERİ ADRESİ : " + M.MüsteriAdresi);
            Console.WriteLine("MÜŞTERİ GSM    : " + M.MüsteriGSM);
            Console.ReadLine();

            M.MüsteriAdi = "SALİH";
            M.MüsteriSoyadi = "DEVECİ";
            M.MüsteriAdresi = "SARIYER/YENİKÖY/34000";
            M.MüsteriGSM = "212*****43";

            Console.WriteLine("MÜŞTERİ ADI    : " + M.MüsteriAdi);
            Console.WriteLine("MÜŞTERİ SOYADI : " + M.MüsteriSoyadi);
            Console.WriteLine("MÜŞTERİ ADRESİ : " + M.MüsteriAdresi);
            Console.WriteLine("MÜŞTERİ GSM    : " + M.MüsteriGSM);
            Console.ReadLine();

            M.MüsteriAdi = "AHMET";
            M.MüsteriSoyadi = "KOÇ";
            M.MüsteriAdresi = "KADIKÖY/CADDEBOSTAN/34000";
            M.MüsteriGSM = "536*****12";

            Console.WriteLine("MÜŞTERİ ADI    : " + M.MüsteriAdi);
            Console.WriteLine("MÜŞTERİ SOYADI : " + M.MüsteriSoyadi);
            Console.WriteLine("MÜŞTERİ ADRESİ : " + M.MüsteriAdresi);
            Console.WriteLine("MÜŞTERİ GSM    : " + M.MüsteriGSM);
            Console.ReadLine();
            Console.Clear();

            U.UrunGetir();

            U.UrunAdi = "MERCEDES G63";
            U.UrunKodu = 111;
            U.UrunFiyat = "27.800.000 TL";

            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine("ÜRÜN ADI    : " + U.UrunAdi);
            Console.WriteLine("ÜRÜN KODU   : " + U.UrunKodu);
            Console.WriteLine("ÜRÜN FİYATI : " + U.UrunFiyat);
            Console.ReadLine();

            U.UrunAdi = "AUDİ A7 ";
            U.UrunKodu = 222;
            U.UrunFiyat = "5.630.000TL";

            Console.WriteLine("ÜRÜN ADI    : " + U.UrunAdi);
            Console.WriteLine("ÜRÜN KODU   : " + U.UrunKodu);
            Console.WriteLine("ÜRÜN FİYATI : " + U.UrunFiyat);
            Console.ReadLine();

            U.UrunAdi = "BMW X7";
            U.UrunKodu = 333;
            U.UrunFiyat = "17.120.000TL";

            Console.WriteLine("ÜRÜN ADI    : " + U.UrunAdi);
            Console.WriteLine("ÜRÜN KODU   : " + U.UrunKodu);
            Console.WriteLine("ÜRÜN FİYATI : " + U.UrunFiyat);
            Console.ReadLine();

            U.UrunAdi = "BENTLEY GT";
            U.UrunKodu = 444;
            U.UrunFiyat = "33.690.000TL";

            Console.WriteLine("ÜRÜN ADI    : " + U.UrunAdi);
            Console.WriteLine("ÜRÜN KODU   : " + U.UrunKodu);
            Console.WriteLine("ÜRÜN FİYATI : " + U.UrunFiyat);
            Console.ReadLine();
            U.UrunAdi = "FORD MUSTANG GT";
            U.UrunKodu = 555;
            U.UrunFiyat = "7.200.000TL";

            Console.WriteLine("ÜRÜN ADI    : " + U.UrunAdi);
            Console.WriteLine("ÜRÜN KODU   : " + U.UrunKodu);
            Console.WriteLine("ÜRÜN FİYATI : " + U.UrunFiyat);
            Console.ReadLine();
            Console.Clear();

        }
    }
}