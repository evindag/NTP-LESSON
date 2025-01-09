using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesTelefonUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Telefon telefon1 = new Telefon();
            telefon1.Marka = "Samsung";
            telefon1.Model = "Galaxy S21";
            telefon1.Fiyat = 20000;

            telefon1.BilgiYazdir();
            telefon1.AramaYap("0545-555-5555");

            Telefon telefon2 = new Telefon();
            telefon2.Marka = "Apple";
            telefon2.Model = "Iphone14";
            telefon2.Fiyat = 30000;

            telefon2.BilgiYazdir();
            telefon2.AramaYap("0545-444-4444");
            Console.ReadLine();
        }
    }
}
