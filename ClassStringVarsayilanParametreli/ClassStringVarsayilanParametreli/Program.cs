using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStringVarsayilanParametreli
{
    class Program
    {
        static void Main(string[] args)
        {
            Isim i = new Isim();
            i.Selamla();
            i.Selamla("Emirhan");
            i.Selamla("Damla");
            i.Selamla();
            Console.ReadLine();
        }
    }
}
