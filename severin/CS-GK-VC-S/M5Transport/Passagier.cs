using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace M5Transport
{
	public class Passagier
	{
		public string Vorname { get; set; }
		public string Nachname { get; set; }
		public int Alter { get; set; }

		public Passagier(string n, int a)
		{
			Nachname = n;
			Alter = a;
		}

		
	}
}
