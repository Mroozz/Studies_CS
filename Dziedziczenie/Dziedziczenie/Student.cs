using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
    class Student : Osoba
    {
        private int rok;
        private int grupa;
        private int nrIndeksu;

        private List<Ocena> oceny = new List<Ocena>();

        public Student(string imie_, string nazwisko_, string dataUrodzenia_, int rok_, int grupa_, int nrIndeksu_) :base(imie_, nazwisko_, dataUrodzenia_)
        {
            this.rok = rok_;
            this.grupa = grupa_;
            this.nrIndeksu = nrIndeksu_;
        }

        public override void WypiszInfo()
        {
            base.WypiszInfo();
            Console.WriteLine($"Pozostałe informacje: rok {this.rok}, grupa {this.grupa}, numer indeksu {this.nrIndeksu}");

            foreach (Ocena ocena in oceny){
                Console.WriteLine($"Oceny: Ocena {this.oceny}");

            }
        }

        #region MetodyZwiazaneZOcenami

        public void DodajOcene(string nazwaPrzedmiotu, string data, double wartosc) {
            Ocena ocena = new Ocena(nazwaPrzedmiotu, data, wartosc);
            oceny.Add(ocena);
        }

        public void WypiszOceny() {
            foreach (Ocena ocena in oceny)
            {
                Console.WriteLine($"Oceny: Ocena{this.oceny}");
            } 
        }

        public void WypiszOceny(string nazwaPrzedmiotu) {
            foreach (Ocena ocena in oceny)
            {
                if (ocena.NazwaPrzedmiotu == nazwaPrzedmiotu) {
                    ocena.WypiszInfo();
                }
                
            }
        }

        public void UsunOcene(string nazwaPrzedmiotu, string data, double wartosc) {

            foreach (Ocena ocena in oceny)
                for (int i = 0; i < oceny.Count;)

            {
                Ocena o = oceny[i];
                if (o.NazwaPrzedmiotu == nazwaPrzedmiotu && o.Data == data && o.Wartosc == wartosc)
                {
                    oceny.Remove(o);
                }
                else
                {
                    ++i;
                }
            }
        }
        public void UsunOceny(string nazwaPrzedmiotu)
        {
            foreach (Ocena ocena in oceny)
                for (int i = 0; i < oceny.Count;)
                { 
                    Ocena o = oceny[i];
                    if (o.NazwaPrzedmiotu == nazwaPrzedmiotu)

                    {
                        oceny.Clear();
                    }
                    else
                    {
                        i--;
                    }
                }


        }
        public void UsunOcene(string nazwaPrzedmiotu)
        {
            for (int i = 0; i < oceny.Count;) 
            {
                Ocena o = oceny[i];
                if (o.NazwaPrzedmiotu == nazwaPrzedmiotu)
                {
                    oceny.RemoveAt(i);
                }
            }
            #endregion

        }
    }
}
