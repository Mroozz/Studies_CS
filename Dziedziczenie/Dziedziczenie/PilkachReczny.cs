using System;
using System.Collections.Generic;
using System.Text;

namespace Dziedziczenie
{
    class PilkachReczny : Piłkarz
    {
        
        public PilkachReczny(string imie_, string nazwisko_, string dataUrodzenia_, string pozycja_, string klub_) : base(imie_, nazwisko_, dataUrodzenia_)
        {
            this.Pozycja = pozycja_;
            this.Klub = klub_;

        }

        
        
    }
}
