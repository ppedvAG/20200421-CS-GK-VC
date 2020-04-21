using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Rechner
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Bitte geben sie eine Zahl ein: ");
            int intZahl = int.Parse(Console.ReadLine());
            Console.WriteLine("Bitte geben sie eine DoubleZahl ein: ");
            double myDbl = double.Parse(Console.ReadLine());
            double summe = intZahl + myDbl;
            Console.WriteLine($"Summe: {summe}");
            int ganzeZahl = (int)summe;
            Console.WriteLine($"Summe integer: {ganzeZahl}");
            // Größe berechnen
            double maxWert = Math.Max(intZahl, myDbl);
            double minWert = Math.Min(intZahl, myDbl);
            Console.WriteLine($"Maxwert: {Math.Max(intZahl, myDbl)}");
            Console.WriteLine($"Minwert: {Math.Min(intZahl, myDbl)}");
            Console.WriteLine($"Ergebnis: {maxWert / minWert}");


            Console.ReadKey();
        }
    }
}
