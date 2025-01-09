using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassParametreliToplamaKullaniciGirisli
{
     
    class toplama_islemi
    {
        private int sayi1, sayi2,sayi3;
        public toplama_islemi(int sayi1, int sayi2, int sayi3)
        {
            this.sayi1 = sayi1;
            this.sayi2 = sayi2;
            this.sayi3 = sayi3;
        } 
        
        public int toplam()
        {
            return sayi1 + sayi2 + sayi3;
        }
            
    }
}
