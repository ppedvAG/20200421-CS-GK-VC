using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M5Fuhrpark;

namespace M5Transport
{
	interface IMitTransport
	{
		// Propertie
		int AnzahlTransportmInLadung { get; set; }
		
		Transport Ladung { get; set; }
		
		// Konstruktor
		int AnzahlFreiePlätze(int plätze);

		int Belade(Transport t);
	}
}
