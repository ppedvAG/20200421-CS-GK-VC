using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3ArrayNControls
{
    class MyIf
    {
        public static void ZeigeTrueBlock()
        {
            int myInt1 = 57;
            int myInt2 = 5;
            
            Console.WriteLine("Vergleich als Bedingung");

            if (myInt1 < myInt2)
            {
                Console.WriteLine("myInt1 ist größer");
            }
            else
            {
                Console.WriteLine("myInt2 ist größer");
            }

            Console.WriteLine("\n Null wert nicht auswertbar");
            //if (null)
            //{
            //    Console.WriteLine("myInt1 ist null");
            //}
            Console.WriteLine("\n es werden nur Anweisungen erwartet die bool zurückgeben" +
                " in C#");
            //if (myInt1)
            //{
            //    Console.WriteLine("myInt1 ist null");
            //}
        }

        public static void ZeigeTernärenOperator()
        {
            Console.WriteLine(true ? "true" : "false");
            string myStr = "heute";
            Console.WriteLine(myStr == "morgen"  ? "morgen" : "heute");

        }
    }
}
