using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M5Fuhrpark;

namespace M5Transport
{
	public class PKW : Transport, IKannRollen
	{
	// Propertie
		public double AnzahlReifen { get; set; }
		
	// Propertie von IKannRollen
		public int AnzahlRäder { get; set; }
		public int Luftdruck { get; set; }

	// Konstruktor
		public PKW(string name, double max, double preis, double anzahlReifen) : base(name, max, preis)
		{
			AnzahlReifen = anzahlReifen;
		}

	// Konstuktor von IKannRollen
		public override string BeschreibeMich()
		{
			string beschreibung = base.BeschreibeMich() + ", " + AnzahlReifen;
			return beschreibung;
		}

		public int NachpumpenLuftDruck(int luft)
		{
			Luftdruck += luft;
			return Luftdruck;
		}

		
	}
}
