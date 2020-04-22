using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3Zahlenratespiel
{
	class Zahlen
	{
		static void Main(string[] args)
		{
			Random random = new Random();

			int zufall = random.Next(5);
			int eingabe;

			Console.WriteLine($"Zufallszahl: {zufall}");

			do
			{
				Console.WriteLine("Geben sie eine Zahl ein:");
				eingabe = int.Parse(Console.ReadLine());

				if (eingabe == zufall)
				{
					Console.WriteLine("Der Wert ist gleich");
				}

				if (eingabe > zufall)
				{
					Console.WriteLine("Der Wert ist größer");
				}

				if (eingabe < zufall)
				{
					Console.WriteLine("Der Wert ist kleiner");
				}
			} while (eingabe != zufall);
		
			Console.ReadKey();
		}
	}
}

// int.Parse(Console.ReadLine());
