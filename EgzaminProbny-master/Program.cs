using System;

namespace EgzaminProbny
{
    class Program
    {
        static void Main(string[] args)
        {
            Wycieczka w1 = new Wycieczka("Gdańsk", 3000.0);
            Wycieczka w2 = new Wycieczka("Sopot", 5000.0);

            WycieczkaKrajowa wK1 = new WycieczkaKrajowa("Gdynia", 3200.0, false);
            WycieczkaKrajowa wK2 = new WycieczkaKrajowa("Zakopane", 4500.0, true);

            WycieczkaZagraniczna wZ1 = new WycieczkaZagraniczna("Portofino", 12000.0, 5);
            WycieczkaZagraniczna wZ2 = new WycieczkaZagraniczna("Paris", 10000.0, 2);

            wK1.LastMinute();
            wK2.LastMinute();

            wZ1.FirstMinute();
            wZ2.FirstMinute();

            Console.WriteLine(w1.Info());
            Console.WriteLine(w2.Info());
            Console.WriteLine(wK1.Info());
            Console.WriteLine(wK2.Info());
            Console.WriteLine(wZ1.Info());
            Console.WriteLine(wZ2.Info());

            Console.ReadKey();
        }
    }
}
