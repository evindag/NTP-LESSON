using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GercekHayatInterfaceOrnegi
{
    class Cocuk:IOkulaGiden,ITuvaleteGiden,IOyunOynayan
    {
    public void OkulaGiden()
{
 	Console.WriteLine("Cocuk okula gider.");
}

public void TuvaleteGiden()
{
 	Console.WriteLine("Çocuk tuvalete gider.");
}

public void OyunOynayan()
{
 	Console.WriteLine("Çocuk oyun oynar.");
}
}

    }

