using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateOrnek
{
    class PrivateErisim
    {
        private string GizliDegisken = "Sadece sınıfiçi erişim";
       
        private void GizliMetot()
        {
            Console.WriteLine("Gizli metota sadece sınıf içinden erişim sağlanabilir.");
        }

        public void SinifIcindenErisim()
        {
            Console.WriteLine(GizliDegisken);
            // aynı sınıf içinden erişim olduğu için hata yok.
            GizliMetot(); // Hata yok.
        }
    }
}
