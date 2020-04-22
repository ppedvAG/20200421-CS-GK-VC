using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M4Methods
{
	class Methods
	{

		static void Main(string[] args)
		{
			// var rückgabe = MOhneReturn(); // void kann nicht zu var zugewiesen werden
			// void rückgabe = MOhneReturn(); // es ist unmöglich eine void Variable zu deklarieren
			MOhneReturn(); // nur das ist möglich

					//bool rückgabe = MMitReturn();
					//Console.WriteLine($"Die Antwort war: {rückgabe}");

					//Console.WriteLine(MMitReturnStr());

					//Console.WriteLine($"Das Wort 'Donau-Dampfschifffahrtsgesellschaftskapitänswitwe'" +
					//	$"hat {BerechneStringLänge("Donau-Dampfschifffahrtsgesellschaftskapitänswitwe")} zeichen.");

					//Console.WriteLine($"3 + 4 = {AddiereUndSubtrahiereUndMultipliziere(3, 4, out int diff, out int prod)} " +
					//	$"3 - 4 = {diff} " +
					//	$"3 * 4 = {prod}");

					//int i1 = 6, i2 = 3, i3, i4;
					//Console.WriteLine($"6 + 3 = {AddiereUndSubtrahiereUndMultipliziere(i1, i2, out i3, out i4)} " +
					//	$"{i1} - {i2} = {i3} " +
					//	$"{i1} * {i2} = {i4}");

			double d1 = 521.6, d2 = 5.3, d3 = 7, d4 = 9;
			Console.WriteLine($"{d1} % {d2} = {GibModuloUndMaxUndRoundedSum(d1, d2, ref d3, ref d4)} " +
				$"Max({d1}, {d2}) " +
				$"Round({d1} + {d2} = {d4}");

			Console.WriteLine($"Summe: {AddiereUndMultipliziere(out int prod, 3,4,6,7,8,9,4,2)}, Produkt: {prod}");

			Console.ReadKey();
		}
		static void MOhneReturn() // es gibt keine Rückgabe, ist nur für eine Funktion eines Programmes ohne Rückgabe
		{
			bool istGut = true;
			Console.WriteLine($"Corona ist gut? {istGut}");
		}

		static bool MMitReturn()
		{
			Console.Write("Geht es Ihnen gut? - ");
			if (Console.ReadLine() == "ja")
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		static string MMitReturnStr()
		{
			Console.Write("Geht es Ihnen immernoch gut? - ");
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

		static double GibModuloUndMaxUndRoundedSum(double a, double b, ref double c, ref double d)
		{
			
			c = Math.Max(a, b);
			d = Math.Round(a + b);
			return a % b;
		}
		static int AddiereUndMultipliziere(out int produkt, params int[] zahlen)
		{
			produkt = 1;
			foreach (var item in zahlen)
			{
				produkt = produkt * item;
			}
			
			return zahlen.Sum();
		}
	}
}
