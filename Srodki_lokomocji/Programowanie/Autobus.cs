using System;
using System.Collections.Generic;
using System.Text;

namespace _54599_Mateusz_Mróz_ININ2_B1._1
{
    class Autobus : SrodekLokomocji
    {
        private bool klimatyzacja;
        double bilet = 5.2;

        public Autobus(string model, int iloscMiejsc, bool klimatyzacja) : base(model, iloscMiejsc)
        {
            this.klimatyzacja = klimatyzacja;
        }


        public void Bilet(double y) => this.bilet *= 5.2;

        
    }
}
        