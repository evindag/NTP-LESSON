using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            PrivateErisim p = new PrivateErisim();
           // p.GizliMetot();
            // hata : private metota erişilemez.
            p.SinifIcindenErisim(); //hata yok çünkü public durumda
        }
    }
}
