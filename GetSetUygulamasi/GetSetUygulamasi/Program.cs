using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSetUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green; //consolu yeşil rengine boyar. 
            Araba araba1 = new Araba();
            araba1.SetRenk("Mavi");
            // arabanın rengini ayarladık (set)
            Console.WriteLine("Arabanın rengi : " +araba1.GetRenk());
            Araba araba2 = new Araba();
            araba2.SetRenk("Yeşil");
            // arabanın rengini ayarladık (set)
            Console.WriteLine("Arabanın rengi : " + araba2.GetRenk());
            Console.ReadLine();
        }
    }
}
