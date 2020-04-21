using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesLib
{
    public static class MyEnum
    {
        enum Pizzagrößen
        {
            klein=2, mittel, groß=1, family
        }
        // bei dieser Key-Belegung ist family auch mit 2 indiziert

        public static void ZeigeEnumerator()
        {
            Pizzagrößen pizzagrößen = Pizzagrößen.mittel;
            Pizzagrößen pizzagrößen2 = Pizzagrößen.family;
            Console.WriteLine($@"
- Ich hab mir eine {pizzagrößen}-Pizza genommen.
- Und ich hab mir {pizzagrößen2}-Größe gegönnt.");
        }
    }
}
