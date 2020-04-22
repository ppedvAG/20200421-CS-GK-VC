using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3ArrayNControls
{
    class M3ArrNCtrl
    {
        static void Main(string[] args)
        {
            MyArray.ZeigeArray();
            MyArray.ZeigeDoubleArray();
            MyIf.ZeigeTrueBlock();
            MyIf.ZeigeTernärenOperator();
            MySwitch.ZeigeSwitch();

            MyRandom.ZeigeRandom();
            
            Console.ReadKey();
        }
    }
}
