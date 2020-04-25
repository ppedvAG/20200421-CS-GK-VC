using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M5Fuhrpark;

namespace M5Transport
{
	public class Schiff : Transport, IMitTransport
	{
	// Propertie
		public double Gewicht { get; set; }
		
	// Propertie von IMitTransport
		public int AnzahlTransportmInLadung { get; set; }
		public Transport Ladung { get; set; }

	// Konstruktor
		public Schiff(string name, double max, double preis, double gewicht) : base(name, max, preis)
		{
			Gewicht = gewicht;
		}

		public override string BeschreibeMich()
		{
			string beschreibung = base.BeschreibeMich() + ", " + Gewicht;
			return beschreibung;
		}

		// Konstruktor von IMitTransport
		public int AnzahlFreiePlätze(int plätze)
		{
			throw new NotImplementedException();
		}

		public int Belade(Transport t)
		{
			Ladung = t;
			return AnzahlTransportmInLadung++;
		}
	}
}
