using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3Zahlenraten
{
    static class ZufallszahlSchleife
    {
        public static void ZufallzahlSchleife()
        {
            Random random = new Random();
            // es kommt max.  0, 1, 2, 3, 4 zurück
            int Zufallszahl = random.Next(5);
            Console.WriteLine($"Die Zufallszahl ist: {Zufallszahl}");
            Console.WriteLine("\n ## Test ##");
            MyRandom myRandom = new MyRandom();
            int ZufallszahlNeu = myRandom.Next(5);
            Console.WriteLine($"Die Zufallszahlneu ist: {ZufallszahlNeu}");

            Console.WriteLine("Bitte geben Sie Ihre getippte Zahl ein: ");
            int intZahl = int.Parse(Console.ReadLine());

            while (intZahl != Zufallszahl)
            {
                Console.WriteLine($"Die Zufallszahl ist: {Zufallszahl}");
                Console.WriteLine("Ihre eingegebene Zahl ist nicht gleich der Zufallszahl. :-(" +
                    " \nBitte erneut versuchen.");
                if (intZahl < Zufallszahl)
                {
                    Console.WriteLine("Zufallszahl ist größer");
                }
                else
                {
                    if (intZahl == Zufallszahl)
                    {
                        Console.WriteLine("Zufallszahl ist gleich");
                    }
                    else
                    {
                        Console.WriteLine("Zufallszahl ist kleiner");
                    }
                }
                intZahl = int.Parse(Console.ReadLine());

            }

            if (intZahl == Zufallszahl)
            {
                Console.WriteLine("Treffer");
            }
        }
    }
}
