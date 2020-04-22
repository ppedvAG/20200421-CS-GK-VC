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

            MyIf.ZeigeTrueBlock();

            MyIf.ZeigeTernärenOperator();

            MySwitch.ZeigeSwitch();

            MyRandom myRandom = new MyRandom();
            myRandom.ZeigeRandom();

            MyRandom myRandom1 = new MyRandom();
            myRandom1.ZeigeRandom();

            MyRandom myRandom2 = new MyRandom();
            myRandom2.ZeigeRandom();

            Console.ReadKey();
        }
    }
}
