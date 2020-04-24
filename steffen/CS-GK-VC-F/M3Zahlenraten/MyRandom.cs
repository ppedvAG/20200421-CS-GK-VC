using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3Zahlenraten
{
    // MyRandom erbt von Klasse Random
    // diese kann ich nun modifizieren
    class MyRandom : Random
    {
        public int NextInclusive(int InMin, int InMax)
        {
            return base.Next(InMin, InMax + 1);
        }
    }
}
