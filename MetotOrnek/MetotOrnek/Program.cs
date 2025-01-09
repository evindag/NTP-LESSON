using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            BuyukSayi buyuk = new BuyukSayi();
            int a = 100;
            int b = 25;
            int sonuc = buyuk.BuyukSayiyiBul(a, b);
            Console.WriteLine("Büyük olan sayı : " + sonuc);
            Console.ReadLine();
        }
    }
}
