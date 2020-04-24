using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3Zahlenratespiel
{
    class M3Zahlenraten
    {
        static void Main(string[] args)
        {
            //Erzeuge eine Zufallszahl zwischen 1 und 5
            //Prüfe Nutzereingabe und gebe aus ob seine Zahl größer, gleich oder kleiner der Zufallszahl ist

            Random generator = new Random();
            int zufallszahl = generator.Next(1);    
            

            Console.WriteLine("\n ## TEST ##");
            Console.WriteLine($"{zufallszahl}");
            MyRandomT myRandom = new MyRandomT();
            int zufallszahl2 = myRandom.Next(1);
            Console.WriteLine($"{zufallszahl2}");

            M3ArrayNControls.MyRandom myRandom3 = new M3ArrayNControls.MyRandom();
            int zufallszahl3 = myRandom3.Next(1);
            Console.WriteLine($"{zufallszahl3}");


            int ratemalzahl;
            do
            {
                Console.WriteLine("Erraten Sie eine int-Zahl zwischen 1 und 5: ");
                ratemalzahl = int.Parse(Console.ReadLine());
                if (zufallszahl == ratemalzahl)
                {
                    Console.WriteLine("Sie haben die Zahl erraten");
                }
                else if (zufallszahl < ratemalzahl)
                {
                    Console.WriteLine("Zufallszahl ist kleiner als Sie denken");

                }
                else
                {
                    Console.WriteLine("Zufallszahl ist größer als Sie denken");
                }
            } while (zufallszahl != ratemalzahl);
            Console.ReadKey();
        }
    }
}
