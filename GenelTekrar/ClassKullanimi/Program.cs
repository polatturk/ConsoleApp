namespace ClassKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Musteri M=new Musteri();
           Urun U = new Urun();

            M.MüsteriAdi = "POLAT";
            M.MüsteriSoyadi = " TÜRK";
            M.MüsteriAdresi = "ŞİŞLİ/MECİDİYEKÖY/34000";
            M.MüsteriGSM = "506*****53";

            M.MüsteriGetir();

            Console.WriteLine("MÜŞTERİ ADI : " +M.MüsteriAdi);
            Console.WriteLine("MÜŞTERİ SOYADI : " + M.MüsteriSoyadi);
            Console.WriteLine("MÜŞTERİ ADRESİ : " + M.MüsteriAdresi);
            Console.WriteLine("MÜŞTERİ GSM : " + M.MüsteriGSM);
            Console.ReadLine();
            Console.Clear();
            U.UrunGetir();

            U.UrunAdi = "MERCEDES G63";
            U.UrunKodu = 777;
            U.UrunFiyat = "27.800.000 TL";

            Console.WriteLine("ÜRÜN ADI : " + U.UrunAdi);
            Console.WriteLine("ÜRÜN KODU : " + U.UrunKodu);
            Console.WriteLine("ÜRÜN FİYATI : " + U.UrunFiyat);
            Console.ReadLine();
        }
    }
}