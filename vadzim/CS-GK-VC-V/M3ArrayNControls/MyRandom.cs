using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3ArrayNControls
{
    class MyRandom
    {
        public void ZeigeRandom()
        {
            Random random = new Random();
            int zufallszahl = random.Next(5); // liefert eine Zufallszahl zw. 0 und 4 inclusive
            Console.WriteLine($"Zufallszahl: {zufallszahl}"); 
        }
    }
}
