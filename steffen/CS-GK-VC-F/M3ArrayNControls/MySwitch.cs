using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3ArrayNControls
{
    static class MySwitch
    {
        public static void ZeigeSwitch()
        {
            DateTime datetime = new DateTime();
            // Mo - Salat
            // Di - Kartoffelauflauf
            // Mi - Pasta
            // Do - Kartoffelauflauf
            // Fr - Pilze
            // Sa, So - geschlossen

            datetime = DateTime.Today;
            Console.WriteLine(datetime);

            datetime = DateTime.Now;
            Console.WriteLine(datetime);

            datetime = datetime.AddDays(1.0);

            switch (datetime.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("Heute Salat im Angebot");
                    break;
                case DayOfWeek.Tuesday:
                case DayOfWeek.Thursday:
                    Console.WriteLine("Heute Kartoffelsalat im Angebot");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("Heute Pasta im Angebot");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("Heute Pilze im Angebot");
                    break;
                default:
                    Console.WriteLine("Heute geschlossen");
                    break;


            }
        }
    }
}
