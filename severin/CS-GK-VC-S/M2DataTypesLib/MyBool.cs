using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesLib
{
    public static class MyBool // Bool kann nur true oder false ausgeben
    {
        static bool myB1 = true;
        static bool myB2 = false;
        static bool myB3 = true;
        public static void ZeigeGleichheit() // es werden zwei Werte miteinander verglichen
        {
            Console.WriteLine($"myB1 == myB2: {myB1 == myB2}"); // False
            Console.WriteLine($"4 == 5: {4 == 5}"); // False
            Console.WriteLine($"\"bla\" == \"bla\": {"bla" == "bla"}"); // False // damit " geschrieben werden muss davor \ gesetzt werden.
        }
        public static void ZeigeUngleichheit() // es werden zwei Werte auf ungleichheit geprüft
        {
            Console.WriteLine($"myB1 != myB2: {myB1 != myB2}");
        }
        public static void ZeigeUnd() // es müssen zwei Bedingungen erfüllt sein
        {
            Console.WriteLine("ZeigeUnd");
            Console.WriteLine(myB1 != myB2 && "bla" == "bla"); // True
            Console.WriteLine(myB1 != myB2 && myB3); // True
        }
        public static void ZeigeOder() // eines der Bedingungen muss erfüllt sein
        {
            Console.WriteLine("ZeigeOder");
            Console.WriteLine(myB1 != myB2 || "bla" == "bla"); // True
            Console.WriteLine(myB1 != myB2 || false); // True
        }
        public static void ZeigeAusschlOder() // es darf nur ein Wert richtig sein
        {
            Console.WriteLine("ZeigeAusschlOder");
            // Entweder links oder rechts darf true stehen,
            // damit der gesamte Ausdruck auch True hat.
            // Beider dürfen nicht das gleiche ergebnis haben.
            Console.WriteLine(myB1 != myB2 ^ "bla" == "bla"); // False
            Console.WriteLine(myB1 != myB2 ^ false); // True
        }
    }
}
