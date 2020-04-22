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
            klein, mittel, groß, family
        }

        public static void ZeigeEnumerator()
        {
            Pizzagrößen pizzagrößen = Pizzagrößen.mittel;
            Pizzagrößen pizzagrößen2 = Pizzagrößen.family;
            Pizzagrößen pizzagrößen3 = (Pizzagrößen)2;
            Console.WriteLine($@"
- Ich hab eine {pizzagrößen}-Pizza genommen.
- Und ich hab mir {pizzagrößen2}-Größen gegönnt.
- Pizzagröße 3 ist {pizzagrößen3}");
        }
    }
}
