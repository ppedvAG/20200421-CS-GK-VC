using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5Fuhrpark
{
    class Flugzeug : Transport, IKannRollen
    {       
        public int MaxFlugHöhe { get; set; }
        public int AnzahlRäder { get; set; }
        public int Luftdruck { get; set; }

        public Flugzeug(string name, int preis, int maximalGeschwindigkeit, int anzRäder) : base(name, preis, maximalGeschwindigkeit)
        {
            AnzahlRäder = anzRäder;            
        }

        public int NachpumpenLuftDruck(int luft)
        {            
            Luftdruck += luft;
            return 4;
        }
    }
}
