using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSetUygulamasi2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            // set metoduyla name özelliğine değer atanıyor
            person.Name = "Evin";
            //get metoduyla name özelliğinin değeri okunuyor ve ekrana yzdırılıyor.
            Console.WriteLine("Kişinin Adı : " + person.Name);
            Console.ReadLine();
        }
    }
}
