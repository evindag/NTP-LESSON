using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicErisim
{
    class PublicOrnek
    {
        public string GenelDegisken { get; set; }

        public void GenelMetot()
        {
            Console.WriteLine("Public ( Genel) metota her yerden erişilebilir.");
        }
    }
}
