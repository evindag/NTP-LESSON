using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSetUygulamasi
{
    class Araba
    {
        private string renk;

        public string GetRenk()
        {
            //Renk özelliğine erişmek için
            return renk;
        }
        public void SetRenk(string yeniRenk)
        {
            //renk özelliğini değiştirmek için
            renk = yeniRenk;
        }

    }
}
