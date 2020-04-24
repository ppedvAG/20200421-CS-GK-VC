using M5Classes;
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

            Detail detail2 = new Detail
            { 
                Breite = 4.3,
                Höhe = 234.4  
            };
            Detail detail = new Detail(4.2, 6.2);
            detail.SagHallo();
            Console.WriteLine(detail.Breite);
            Console.WriteLine(detail.Höhe);
            Console.WriteLine(detail.DefaultEinheit);

            Console.WriteLine(detail2.Breite);
            Console.WriteLine(detail2.Höhe);

            Detail detail3 = new Detail();

            Console.ReadKey();
        }
    }
}
