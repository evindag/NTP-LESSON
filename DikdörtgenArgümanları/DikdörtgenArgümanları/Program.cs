using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DikdörtgenArgümanları
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan ksıa ve uzun kenar değerlerini al
            Console.WriteLine("Dikdörtgenin kısa kenarını girin: ");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Dikdörtgenin uzun kenarını girin: ");
            int b = Convert.ToInt16(Console.ReadLine());

            //Dikdörtgen nesnesini oluştur
            Dikdortgen d = new Dikdortgen(a,b);

            //Alan ve çevre hesaplama
            Console.WriteLine("Dikdörtgenin alanı: "+d.AlanHesapla());
            Console.WriteLine("Dikdörtgenin çevresi "+d.CevreHesaplama());
            Console.ReadLine();
        }
    }
}
