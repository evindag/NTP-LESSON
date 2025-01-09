using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternalErisim
{
    class Program
    {
        static void Main(string[] args)
        {
            InternalOrnek i = new InternalOrnek();
            i.InternalMetot();
            Console.WriteLine(i.DahiliDegisken);
            Console.ReadLine();
            
        }
    }
}
