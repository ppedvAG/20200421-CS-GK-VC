using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesLib
{
    public static class MyBool
    {
        static bool myB1 = true;
        static bool myB2 = false;
        static bool myB3 = true;

        public static void ZeigeGleichheit()
        {
            Console.WriteLine($"myB1 == myB2: {myB1 == myB2}"); //False
            Console.WriteLine($"4 == 5: {4 == 5}"); //Fale
            Console.WriteLine($"\"Bla\" == \"Bla\": {"Bla" == "Bla"}"); // True
        }
        public static void ZeigeUngleichheit()
        {
            Console.WriteLine($"myB1 != myB2: {myB1 != myB2}"); // True
        }

        public static void ZeigeUnd()
        {
            Console.WriteLine("ZeigeUnd");
            Console.WriteLine("{0}: ", myB1 != myB2 && "Bla" == "Bla"); // True
            Console.WriteLine("{0}: ", myB1 != myB2 && myB3); // True
        }

        public static void ZeigeOder()
        {
            Console.WriteLine("ZeigeOder");
            Console.WriteLine("{0}: ", myB1 != myB2 || "Bla" == "Bla"); // True
            Console.WriteLine("{0}: ", myB1 != myB2 || false); // True
        }


        public static void ZeigeAusschlOder()
        {
            Console.WriteLine("ZeigeAusschlOder");
            // Entweder Links oder Rechts darf true stehen, damit der gesamte Ausdruck true hat
            Console.WriteLine("{0}: ", myB1 != myB2 ^ "Bla" == "Bla"); // False
            Console.WriteLine("{0}: ", myB1 != myB2 ^ false); // True
        }
    }
}
