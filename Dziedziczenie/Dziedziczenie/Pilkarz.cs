using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
    class Pilkarz : Osoba
    {
        private string pozycja;

        public string Pozycja
        {
            get { return pozycja; }
            set { pozycja = value; }
        }

        private string klub;

        public string Klub
        {
            get { return klub; }
            set { klub = value; }
        }

        private int liczbaGoli;

        public int LiczbaGoli
        {
            get { return liczbaGoli; }
            set { liczbaGoli = value; }
        }

        public Pilkarz(string imie_, string nazwisko_, string dataUrodzenia_, string pozycja_, string klub_) : base(imie_, nazwisko_, dataUrodzenia_)
        {
            this.pozycja = pozycja_;
            this.klub = klub_;
            this.liczbaGoli = 0;
        }

        public override void WypiszInfo()
        {
            base.WypiszInfo();
            Console.WriteLine($"Pozostałe informacje: pozycja {this.pozycja}, klub {this.klub}, liczba strzelonych goli {this.liczbaGoli}");
        }

        public void StrzelGola() {
            Console.WriteLine("GOOOOOL!");
            this.liczbaGoli++;
        }
    }
}
