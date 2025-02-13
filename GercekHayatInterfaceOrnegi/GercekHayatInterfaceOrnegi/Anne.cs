using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GercekHayatInterfaceOrnegi
{
    class Anne:ITuvaleteGiden,IArabaSuren,ICocukBakan,IYemekYapan,ICalısan
    {
     
    



    
public void ArabaSuren()
{
    Console.WriteLine("anne araba sürer");
}



public void TuvaleteGiden()
{
    Console.WriteLine("Bir anne olsam da tuvalete giderim.");
}

public void CocukBakan()
{
    Console.WriteLine("Ben bir anneyim, çocuk bakarım.");
}

public void YemekYapan()
{
    Console.WriteLine("Ben bir anneyim, yemek yaparım.");
}

public void Calısan()
{
    Console.WriteLine("anne çalışır.");
}
    }
}
