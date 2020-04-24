using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5Transport
{
	interface IKannRollen
	{
		// Propertie
		int AnzahlRäder { get; set; }
		int Luftdruck { get; set; }

		// Konstruktor
		int NachpumpenLuftDruck(int luft);
	}
}
