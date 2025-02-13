using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GercekHayatInterfaceOrnegi
{
    class Baba:IArabaSuren,ITuvaleteGiden,ICocukBakan,ICalısan
    {
        public void ArabaSuren()
        {
            Console.WriteLine("baba araba sürer");
        }

        public void TuvaleteGiden()
        {
            Console.WriteLine("baba tuvalete gider");
        }

 
        public void CocukBakan()
        {
            Console.WriteLine("baba çoçuk bakar");
        }

        public void Calısan()
        {
            Console.WriteLine("baba çalışır.");
        }
    }
}
