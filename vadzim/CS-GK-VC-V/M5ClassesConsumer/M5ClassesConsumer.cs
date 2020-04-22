using Demo_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5ClassesConsumer
{
    class M5ClassesConsumer
    {
        static void Main(string[] args)
        {
            Detail.SagHalloStatic();
            Detail detail = new Detail(4.2, 6.2);
            detail.SagHallo();
            Console.WriteLine(detail.Breite);
            Console.WriteLine(detail.Höhe);

            Console.ReadKey();
        }
    }
}
