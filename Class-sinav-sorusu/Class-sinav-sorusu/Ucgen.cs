using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_sinav_sorusu
{
    public class Ucgen
    {
        private double taban;
        private double yukseklik;
        private double kenar1;
        private double kenar2;
        private double kenar3;

        public Ucgen(double taban, double yukseklik, double kenar1, double kenar2, double kenar3)
        {
            this.taban = taban;
            this.yukseklik = yukseklik;
            this.kenar1 = kenar1;
            this.kenar2 = kenar2;
            this.kenar3 = kenar3;
        }

        public double AlanHesapla()
        {
            return (taban * yukseklik) / 2; // Alan = (taban * yükseklik) / 2
        }

        public double CevreHesapla()
        {
            return kenar1 + kenar2 + kenar3; // Çevre = kenar1 + kenar2 + kenar3
        }
    }
}

