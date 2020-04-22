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
            DateTime dateTime = new DateTime();
            // Mo - Salat
            // Di - Kartoffelauflauf
            // Mi - Pasta
            // Do - Kartoffelauflauf
            // Fr - Pilzepfanne
            // Sa, So - geschlossen   
            dateTime = DateTime.Now; // Datum und Uhrzeit
            Console.WriteLine(dateTime);
            //dateTime = DateTime.Today; // Datum ohne Uhrzeit
            //Console.WriteLine(dateTime);
            dateTime = dateTime.AddDays(1.2); // Double, weil man kann noch die Uhrzeit mit addieren
            Console.WriteLine(dateTime);
            switch (dateTime.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("Heute im Angebot: Salat");
                    break;
                case DayOfWeek.Tuesday:                    
                case DayOfWeek.Thursday:
                    Console.WriteLine("Heute im Angebot: Kartoffelauflauf");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("Heute im Angebot: Pasta");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("Heute im Angebot: Pilzepfanne");
                    break;
                default:
                    Console.WriteLine("Heute sind wir leider geschlossen");
                    break;
            }
        }

    }
}
