using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5Fuhrpark
{
    class FuhrparkApp
    {
        static void Main(string[] args)
        {
            double miles = Transport.KmZuMeilen(220);
            Console.WriteLine($"220 km zu Miles: {miles}");

            // Transport transport = new Transport(
            Console.ReadKey();
        }
    }
}
