using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassParametreliToplamaKullaniciGirisli
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("1.sayiyi giriniz");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.sayiyi giriniz");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3.sayiyi giriniz");
            int sayi3 = Convert.ToInt32(Console.ReadLine());
            toplama_islemi t = new toplama_islemi(sayi1, sayi2, sayi3);
            Console.WriteLine("toplam "+ t.toplam());
            Console.ReadLine();
            



            
        }
    }
}
