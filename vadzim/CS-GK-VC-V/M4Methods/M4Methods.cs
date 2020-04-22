using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M4Methods
{
    class M4Methods
    {        
        static void Main(string[] args)
        {
            
            // var rückgabe = MOhneReturn(); // void kann nicht zu var zugewiesen werden
            // void rückgabe = MOhneReturn(); // Es ist unmöglich, void-Variablen zu deklarieren
            //MOhneReturn();

            //bool rückgabe = MMitReturn();
            //Console.WriteLine($"Die Antwort war: {rückgabe}");

            // Console.WriteLine($"Das Wort 'Donau-Dampfschifffahrtsgesellschaftskapitänswitwe' " +
            //    $"hat {BerechneStringLänge("Donau-Dampfschifffahrtsgesellschaftskapitänswitwe")} Zeichen.");


            //        Console.WriteLine($"3 + 4 = {AddiereUndSubtrahiereUndMultipliziere(3, 4, out int diff, out int prod)}, " +
            //            $"3 - 4 = {diff}, " +
            //            $"3 * 4 = {prod}");

            //        int i1 = 6, i2 = 3, i3, i4;

            //        Console.WriteLine($"{i1} + {i2} = {AddiereUndSubtrahiereUndMultipliziere(i1, i2, out i3, out i4)}, " +
            //$"{i1} - {i2} = {i3}, " +
            //$"{i1} * {i2} = {i4}");

            //            double d1 = 521.6, d2 = 5.3, d3 = 3.2;
            //            int i5 = 2;
            //            Console.WriteLine($@"
            //{d1} % {d2} = {GibModuloUndMaxUndRoundedSum(d1, d2, ref d3, ref i5)}
            //Max({d1}, {d2}) = {d3}
            //Round({d1} + {d2}) = i5");

            Console.WriteLine($"Summe: {AddiereUndMultipliziere(out int prod, 3,4,6,7,8,9,4,2)}, Produkt: {prod}");


            Console.ReadKey();
        }

        static void MOhneReturn()
        {
            bool istGut = true;
            Console.WriteLine($"Corona ist gut? {istGut}");
        }

        static bool MMitReturn()
        {
            Console.Write("Geht es Ihnen gut? - ");
            if (Console.ReadLine() == "ja")
                return true;
            else return false;
        }

        static string FrageNachWohlergehen()
        {
            Console.Write("Geht es Ihnen gut? - ");
            return Console.ReadLine();
        }

        static int BerechneStringLänge(string par)
        {
            return par.Length;
        }

        static int AddiereUndSubtrahiereUndMultipliziere(int a, int b, out int differenz, out int produkt)
        {
            differenz = a - b;
            produkt = a * b;
            return a + b;
        }

        static double GibModuloUndMaxUndRoundedSum(double a, double b, ref double m, ref int s)
        {
            m = Math.Max(a, b);
            s = (int)Math.Round(a + b);
            return a % b;
        }

        static int AddiereUndMultipliziere(out int produkt, params int[] zahlen)
        {
            produkt = 1;
            foreach (int item in zahlen)
            {
                // produkt = produkt * item;
                produkt *= item;
            }
            
            return zahlen.Sum();
        }
    }
}
