using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M5Transport;

namespace M5Fuhrpark
{
	public class Transport
	{
		// Enum

		public enum MyEnum
		{
			aus, an
		}

		public enum GeschwEinheit
		{
			Kilometer, Meilen
		}

		// Properties
		#region Properties
		public string Name { get; set; }
		public double MaxGeschwindigkeit { get; }
		public double Preis { get; set; }
		public double AktuelleGeschwindigkeit { get; private set; }
		public MyEnum Zustand { get; private set; }
		public List<Passagier> Passagierliste { get; set; }
		#endregion

		// Konstruktor
		#region Konstruktor
		public Transport(string name, double max, double preis)
		{
			Name = name;
			MaxGeschwindigkeit = max;
			Preis = preis;
			AktuelleGeschwindigkeit = 0;
			Zustand = MyEnum.aus;
		}
		#endregion

		// Methods
		#region Methods
		public double Beschleunige(double erhöhung, GeschwEinheit geschwEinheit)
		{
			if (geschwEinheit == GeschwEinheit.Meilen)
			{
				erhöhung = MeilenToKm(erhöhung);
			}

			AktuelleGeschwindigkeit += erhöhung;

			if (AktuelleGeschwindigkeit > MaxGeschwindigkeit)
			{
				return MaxGeschwindigkeit;
			}
			else
			{
				return AktuelleGeschwindigkeit;
			}

		}
		public void StartMotor()
		{
			Zustand = MyEnum.an;
		}

		public void StoppeMotor()
		{
			Zustand = MyEnum.aus;
		}

		public virtual string BeschreibeMich()
		{
			string beschreibung = $"Beschreibung des Fahrzeuges: {Name}, {MaxGeschwindigkeit}, {Preis}, {AktuelleGeschwindigkeit}, {Zustand}";
			return beschreibung;
		}

		public static double KmToMiles(double km)
		{
			double miles = km * 0.621371;
			return miles;
		}
		public static double MeilenToKm(double meilen)
		{
			double km = Math.Round(meilen * 1.60934);
			return km;
		}

		#endregion
	}

}
