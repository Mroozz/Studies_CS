namespace EgzaminProbny
{
    class WycieczkaKrajowa : Wycieczka
    {
        private bool allInclusive;

        
        public WycieczkaKrajowa(string miejsce, double cena, bool allInclusive) : base ( miejsce, cena)
        {
            this.allInclusive = allInclusive;
        }


        public void LastMinute() => this.cena *= 0.5;
    }
}
