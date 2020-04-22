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
            //var rückgabe = MOhneReturn(); // void kann nicht zu var zugewiesen werden
            //void rückgabe = MOhneReturn(); // es ist unmöglich void-variablen zu declarieren

            //MOhneReturn();
            //bool rückgabe = MMitReturn();
            //Console.WriteLine($"Die Antwort war: {rückgabe}");

            // Methode mit Rückgabe eines Strings
            //string eingabe = MMitReturnString();
            //Console.WriteLine($"Die Antwort war: {eingabe}");
            //Console.WriteLine($"Die Antwort war: {MMitReturnString()}"); // 2. Möglichkeit

            //Console.WriteLine($"Das Wort 'Donau-Dampfschifffahrtsgesellschaftskapitänswitwe'" +
            //    $"hat : {BerechneStringLänge("Donau-Dampfschifffahrtsgesellschaftskapitänswitwe")} Zeichen.");


            //   Console.WriteLine($"3 + 4 = {AddiereUndSubstrahiereUndMultipliziere(3, 4, out int diff, out int prod)}," +
            //       $"3 - 4 = {diff}, " +
            //       $"3 * " +
            //       $"4 = {prod}");


            //   int i1 = 4, i2 = 5, i3, i4;

            //       Console.WriteLine($"{i1} + {i2} = {AddiereUndSubstrahiereUndMultipliziere(i1, i2, out i3, out i4)}," +
            //$"{i1} - {i2} = {i3}, " +
            //$"{i1} * " +
            //$"{i2} = {i4}");

            //            double d1 = 5781.3, d2 = 521.6, d3 = 3.2, i5 = 2;
            //            Console.WriteLine($@"
            //{d1} % {d2} = {GibModuloUndMaxundRoundedSum(d1, d2, ref d3, ref i5)}
            //Max({d1}, {d2} = {d3}
            //Round({d1} + {d2}) =(out int prod, 6,3,4,4,4,4,4,1233213,5) {i5}");

            Console.WriteLine($"{AddiereUndMultipliziere(out int prod, 6,3,74,491,74,42,454,12,5)}, " +
                $"Produkt: {prod}");

               Console.ReadKey();
        }

        static void MOhneReturn()
        {
            bool istGut = true;
            Console.WriteLine($"Corona ist gut? {istGut}");
        }

        static bool MMitReturn()
        {
            Console.Write("Geht es Ihnen gut? ");
            if (Console.ReadLine() == "ja")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static string MMitReturnString()
        {
            Console.Write("Geht es Ihnen gut? ");
            string eingabe = Console.ReadLine();
            return (eingabe);
            //return Console.ReadLine(); // oder direkt ausgeben
        }

        static int BerechneStringLänge(string par)
        {
            return par.Length;
        }

        static int AddiereUndSubstrahiereUndMultipliziere(int a, int b, out int differenz, out int produkt)
        {
            differenz = a - b;
            produkt = a * b;
            return a + b;

        }

        static double GibModuloUndMaxundRoundedSum(double a, double b, ref double maxi, ref double summeRunden)
        {
            double Mod;

            Mod = a % b;
            maxi = Math.Max(a, b);
            summeRunden = Math.Round((a / b), 4);
            return Mod; 
        }

        static int AddiereUndMultipliziere(out int produkt, params int[] zahlen)
        {
            produkt = 1;
            foreach (var item in zahlen)
            {
                // produkt = produkt * item
                produkt *= item;
            }

            return zahlen.Sum();

        }
    }
}
