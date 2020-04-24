using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5Fuhrpark
{
    interface IKannAndereTransportieren
    {
        Transport AktLadung { get; set; }
        Transport MaxLadung { get; set; }
        void Belade(Transport transport);
        void Entlade();
    }
}
