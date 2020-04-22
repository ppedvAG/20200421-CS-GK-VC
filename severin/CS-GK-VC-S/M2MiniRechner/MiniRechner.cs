using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Rechner
{
	class MiniRechner
	{
		static void Main(string[] args)
		{
			Console.Write("Bitte geben Sie eine Int Zahl ein: ");
			int intZahl = int.Parse(Console.ReadLine());
			Console.Write("Bitte geben Sie eine double Zahl ein: ");
			double dblZahl = double.Parse(Console.ReadLine());

			Console.WriteLine($"intZahl + dblZahl: {intZahl + dblZahl}");
			Console.WriteLine($"intZahl + (int)dblZahl: {intZahl + (int)dblZahl}");

			Console.WriteLine($"größer / kleiner: {Math.Max(intZahl, dblZahl) / Math.Min(intZahl, dblZahl)}");

			Console.ReadKey();
		}
	}
}
