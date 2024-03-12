using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassKullanimi
{
    internal class Musteri
    {
        public string MüsteriAdi;
        public string MüsteriSoyadi;
        public string MüsteriAdresi;
        public string MüsteriGSM;

        public void MüsteriGetir()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("MÜŞTERİLER LİSTELENİYOR..");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
