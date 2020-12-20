namespace EgzaminProbny
{
    class Wycieczka
    {
        internal protected double cena;
        internal protected string miejsce;



        public Wycieczka(string miejsce)
        { 
        }

        public Wycieczka(string miejsce, double cena)
        {
            this.cena = cena;
            this.miejsce = miejsce;
        }


        public string Info() => (miejsce +" "+ cena.ToString());
    }
}
