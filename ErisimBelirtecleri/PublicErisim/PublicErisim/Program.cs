using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicErisim
{
    class Program
    {
        static void Main(string[] args)
        {
            PublicOrnek p = new PublicOrnek();
            p.GenelDegisken = "Hata Yok";
            p.GenelMetot();
            Console.ReadLine();
        }
    }
}
