using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesTelefonUygulamasi
{
    class Telefon
    {
        public string Marka;
        public string Model;
        public int Fiyat;

         public void BilgiYazdir()
        {
            Console.WriteLine("-------Telefon Bilgileri------- \nMarka :" +Marka +"\nModel :" +Model+"\nFiyat :"+Fiyat+" TL");
        }

         public void AramaYap(string numara)
         {
             Console.WriteLine(Marka+" "+Model+" ile" + " " + numara +" numarasını arıyorsunuz.");
         }
    }
}
