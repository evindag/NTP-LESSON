using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSetUygulamasi2
{
    class Person
    {
        // name özelliği
        private string name;

        //name için get ve set metotları
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
