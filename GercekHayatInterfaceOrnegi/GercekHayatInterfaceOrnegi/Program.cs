using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GercekHayatInterfaceOrnegi
{
    class Program
    {
        static void Main(string[] args)
        {
            Baba baba = new Baba();
            Anne anne = new Anne();
            Cocuk cocuk = new Cocuk();

            // Babanın görevleri
            baba.ArabaSuren();
            baba.Calısan();
            baba.CocukBakan();
            baba.TuvaleteGiden();
           // Annenin görevleri
            anne.ArabaSuren();
            anne.TuvaleteGiden();
            anne.CocukBakan();
            anne.YemekYapan();
            // Çocuğun görevleri
            cocuk.OyunOynayan();
            cocuk.TuvaleteGiden();
            cocuk.OkulaGiden();
            Console.ReadLine();
        }
    }
}
