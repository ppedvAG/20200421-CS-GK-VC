using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5Fuhrpark
{
    public interface IKannRollen
    {
        int AnzahlRäder { get; set; }
        int Luftdruck { get; set; }
        int NachpumpenLuftDruck(int luft);
    }
}
