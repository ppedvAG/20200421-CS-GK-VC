using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesLib
{
    public static class MyInt
    {
        public static void ZeigeLiterals()
        {
            Console.WriteLine("ZeigeLiterals");
            int myInt = -3;
            int myInt2 = 0b_0000_0000_0000_0000_0000_0000_0000_1011; // 0b = binär 0h = Hex 0O = Octal
                                                                     // bei Ausgabe wird der Wert dezimal dargestellt
            Console.WriteLine($"{myInt}, {myInt2}");
        }

        public static void ZeigeMöglicheWerte()
        {
            Console.WriteLine("ZeigeMöglicheWerte");
            Console.WriteLine($"int.MaxValue: {int.MaxValue}");
            Console.WriteLine($"int.MinValue: {int.MinValue}");
        }

        public static void ZeigeParsing()
        {
            Console.WriteLine("ZeigeParsing");
            string myStr = "3";
            string myStr2 = "f";
            int myInt = int.Parse(myStr);
            int myInt2;
            bool istMöglich = int.TryParse(myStr2, out myInt2);

            Console.WriteLine($"myInt: {myInt}");
            Console.WriteLine($"myInt2: {myInt2}");
            Console.WriteLine($"istMöglich: {istMöglich}");
        }

        public static void ZeigeCasting()
        {
            Console.WriteLine("ZeigeCasting");
            double kommaZahl = 44.32;
            int ganzeZahl = (int)kommaZahl;

            Console.WriteLine($"ganzeZahl: {ganzeZahl}");
        }

        public static void ZeigeVergleich()
        {
            Console.WriteLine($"3 > 5: {3 > 5}");
        }
    }
}
        // Console.WriteLine($"{}");