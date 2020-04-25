using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M5Fuhrpark;

namespace M5Transport
{
	public class Flugzeug : Transport, IKannRollen, IMitTransport
	{
		// Propertie
		public double Sitze { get; set; }

		// Propertie von IKannRollen
		public int AnzahlRäder { get; set; }
		public int Luftdruck { get; set; }

		// Propertie von IMitTransport
		public int AnzahlTransportmInLadung { get; set; }
		public Transport Ladung { get; set; }

		// Konstruktor
		public Flugzeug(string name, double max, double preis, double sitze) : base(name, max, preis)
		{
			Sitze = sitze;
		}

		public override string BeschreibeMich()
		{
			string beschreibung = base.BeschreibeMich() + ", " + Sitze;
			return beschreibung;
		}

		// Konstruktor von IKannRollen
		public int NachpumpenLuftDruck(int luft)
		{
			Luftdruck += luft;
			return Luftdruck;
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
