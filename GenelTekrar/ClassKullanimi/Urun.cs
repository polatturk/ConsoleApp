using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassKullanimi
{
    internal class Urun
    {
        public string UrunAdi;
        public int UrunKodu;
        public string UrunFiyat;

        public void UrunGetir()
        {
            Console.WriteLine("ÜRÜNLER LİSTELENİYOR..");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
