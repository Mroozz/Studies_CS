namespace EgzaminProbny
{
    class WycieczkaZagraniczna : Wycieczka
    {
        private int miesiac;


        public WycieczkaZagraniczna(string miejsce, double cena, int miesiac) : base(miejsce, cena)
        {
            this.miesiac = miesiac;
        }


        public void FirstMinute()
        {
            if (miesiac % 2 == 0) this.cena *= 0.8;
            else this.cena *= 0.9;

        }
    }
}
