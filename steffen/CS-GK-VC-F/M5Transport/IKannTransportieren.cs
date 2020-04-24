using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5Transport
{
    interface IKannTransportieren
    {
        Transportmittel Ladung { set; get;}
        int Beladen(Transportmittel transportmittel);
        
    }
}
