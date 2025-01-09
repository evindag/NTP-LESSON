using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassParametreliToplamaIslemi
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ToplamaIslemi t = new ToplamaIslemi();
            //int toplam = t.Topla(3, 4, 5);
            int toplam = t.Topla(sayi2:3, sayi1:4, sayi3:5);
            Console.WriteLine("Toplam : " +toplam);
            Console.ReadLine();
            
        }
    }
}
