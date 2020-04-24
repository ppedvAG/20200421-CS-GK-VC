using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5Fuhrpark
{
    class Schiff : Transport, IKannAndereTransportieren
    {
        

        public enum SchiffsTreibstoff
        {
            Diesel,
            Dampf,
            Wind,
            Muskelkraft
        }
        public SchiffsTreibstoff Treibstoff { get; set; }
        public Transport AktLadung { get; set; }
        public Transport MaxLadung { get; set; }

        public Schiff(string name, int preis, int maximalGeschwindigkeit, SchiffsTreibstoff treibstoff) : base(name, preis, maximalGeschwindigkeit)
        {

        }

        public void Belade(Transport transport)
        {
            throw new NotImplementedException();
        }

        public void Entlade()
        {
            throw new NotImplementedException();
        }
    }
}
