using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3ArrayNControls
{
    static class MyArray
    {
        public static void ZeigeArray()
        {
            string[] arrOfStr = new string[3];
            arrOfStr[1] = "Tulpe";
            arrOfStr[2] = "Rose";
            Console.WriteLine($"arrOfStr:{arrOfStr}"); // Zeigt nur den Datentyp aber nicht den Inhalt
            
            foreach (string item in arrOfStr)
            {
                //if (item == "")
                //{
                //    Console.WriteLine("Leeres Elemet");
                //}
                if (item == "")
                    Console.WriteLine("Leeres Element");
                if (item == null)
                    Console.WriteLine("Element gleich null");

                Console.WriteLine(item);

            }
        }

        public static void ZeigeDoubleArray()
        {
            double[] arrOfDbl = new double[] { 4.2, 6.3, 5.2 };

            for (int i = 0; i < arrOfDbl.Length; i++)
            {
                Console.WriteLine(arrOfDbl[i]);
            }
        }

        //Console.WriteLine($"{}");

    }
}
