using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSetUygulamasi3
{
    class Program
    {
        static void Main(string[] args)
        {
            Ucgen ucgen = new Ucgen();
            ucgen.A = 3;
            ucgen.B = 5;
            ucgen.C = 8;
            int cevre = ucgen.CevreHesaplama();
            Console.WriteLine("Üçgenin çevresi : " +cevre);
            Console.ReadLine();
        }
    }
}
