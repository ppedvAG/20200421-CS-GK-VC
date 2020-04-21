using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Console
{
    class DConsole
    {
        static void Main(string[] args)
        {
            #region 1
            Console.WriteLine("### WriteLine(string) ###");
            int alter = 35;
            string name = "Steffen";
            Console.WriteLine("Das ist ein Text");
            Console.WriteLine(name);
            Console.WriteLine(alter);
            #endregion
            // 1
            Console.WriteLine("\n ### WriteLine(string, arg0, arg1) ###");
            Console.WriteLine("Ich heiße {0} und bin {1} Jahre alt.", name, alter);


            // 2
            Console.WriteLine("\n ### WriteLine(string) ###");
            Console.Write("Zeile ohne Umbruch");
            Console.WriteLine("\n Eurozeichen: €");


            // 3
            Console.WriteLine("\n ### OutputEncoding ###");
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Eurozeichen: €");
            string eingabe = Console.ReadLine();
            Console.WriteLine("Es wurde eingegeben: {0}", eingabe);


            // 4
            Console.WriteLine("\n ### ReadKey ###");
            Console.ReadKey();
        }
    }
}
