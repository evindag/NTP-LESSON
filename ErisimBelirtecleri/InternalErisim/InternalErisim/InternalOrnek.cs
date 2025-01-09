using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternalErisim
{
    internal class InternalOrnek
    {
        //internal : Sadece aynı proje kapsamı içinde erişilebilir.
        //public: Tüm proje ve classlardan erişilebilir.
        internal string DahiliDegisken = "Aynı proje içinden erişim";

        internal void InternalMetot() 
        {
            Console.WriteLine("İnternal metot aynı proje içinden erişilebilir.");
        }
    }
}
