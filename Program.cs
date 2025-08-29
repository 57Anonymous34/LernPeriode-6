using Lern_periode_6.Held;
using Lern_periode_6.Bösewicht;
using System.Linq.Expressions;


namespace Lern_periode_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Scofield Held1 = new Scofield("Michael Scofield","Brechstange","Hochbegabt",60,10);


            Hulk Held2 = new Hulk("Hulk", "Hammer", "Stark", 70, 15);


            Spiderman Held3 = new Spiderman("Spiderman", "Spinnetz", "Spinnensinn", 60, 17);

            Console.WriteLine($"Hallo, es gibt "Spiderman", Scofield und Halk, Was müchtest Du sein?");
                Console.WriteLine("")

            Bösemann Bösewicht1 = new Bösemann("Bösemann", "Axt", "Kuckt Böse", 50, 8);

          


            Silver_Surfer Bösewicht2 = new Silver_Surfer("Silver_Surfer", "Surf Board","Fliegen", 65, 18);

            Thanos Bösewicht3 = new Thanos("Thanos", "Goldener Handschuh", "Ultimative zerstörung", 85, 20);



            // Held1.brechstange.damage += 5è

            
        }
    }
}
