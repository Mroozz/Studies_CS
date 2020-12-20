using System;
using System.Collections.Generic;
using System.Text;

namespace _54599_Mateusz_Mróz_ININ2_B1._1
{
    class SrodekLokomocji
    {
        internal protected int iloscMiejsc;
        internal protected string model;



        public SrodekLokomocji(string model)
        {
        }

        public SrodekLokomocji(string model, int iloscMiejsc)
        {
            this.iloscMiejsc = iloscMiejsc;
            this.model = model;
        }


        public string Info() => (model + " " + iloscMiejsc.ToString());
    }
}

