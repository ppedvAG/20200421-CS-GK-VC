using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3ArrayNControls
{
    static class MyRandom
    {
        public static void ZeigeRandom()
        {
            Random random = new Random();
            Console.WriteLine($"Zufallszahl: { random.Next(5)}"); // liefert eine Zufallszahl von 0 bis 4
        }
    }
}
