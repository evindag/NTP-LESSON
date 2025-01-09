using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DikdörtgenArgümanları
{
    class Dikdortgen
    {
        private int a, b;
        //parametreli yapıcı metot (constructor)
        public Dikdortgen(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        //Alan hesaplama metodu
        public int AlanHesapla()
        {
            return a * b;
        }
        
        //Çevre hesaplama metodu
        public int CevreHesaplama() 
        {
            return 2 * (a + b);
        }
        
        
        
    }
}
