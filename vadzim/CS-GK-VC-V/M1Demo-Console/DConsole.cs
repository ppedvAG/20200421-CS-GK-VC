using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1Demo_Console
{
    class DConsole
    {
        static void Main(string[] args)
        {
            #region 1
            Console.WriteLine("\n### WriteLine(string) ###");
            int alter = 35;
            string name = "Vadzim";
            Console.WriteLine("mein Text für die Konsole");
            Console.WriteLine(alter);
            Console.WriteLine(name);
            #endregion


            Console.WriteLine("\n### WriteLine(string, arg0, arg1) ###");
            Console.WriteLine("Ich heiße {0} und bin {1} Jahre alt.", name, alter);


            Console.WriteLine("\n### Write(string) ###");
            Console.Write("Text ohne Zeilenumbruch");


            Console.WriteLine("\n### OutputEncoding ###");
            Console.WriteLine("\n Eurozeichen: €");
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Eurozeichen: €");
            Console.WriteLine("Geben Sie einen Text ein und klicken Sie auf 'Enter': ");


            Console.WriteLine("\n### ReadLine() ###");
            string eingabe = Console.ReadLine();
            Console.WriteLine("Sie haben eingegeben: {0}", eingabe);


            Console.WriteLine("\n### ReadKey() ###");
            Console.ReadKey();
        }
    }
}
