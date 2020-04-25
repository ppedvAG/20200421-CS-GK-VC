using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3Zahlenratespiel
{
	class MyRandom : Random
	{
		public int NextInclusive(int max)
		{
			return base.Next(max + 1);
		}
	}
}
