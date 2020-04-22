using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3Zahlenraten
{
    static class ZufallszahlPrüfen
    {
        public static void ZufallzahlPrüfen()
        {

        Random random = new Random();

        int Zufallszahl = random.Next(5);


        Console.WriteLine("Bitte geben Sie Ihre getippte Zahl ein: ");
            int intZahl = int.Parse(Console.ReadLine());
        Console.WriteLine($"Die Zufallszahl: {Zufallszahl}");

            if (intZahl<Zufallszahl)
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
        }

            //Console.ReadKey();

    }
}
