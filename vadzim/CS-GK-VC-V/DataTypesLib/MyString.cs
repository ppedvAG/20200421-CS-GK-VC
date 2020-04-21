using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesLib
{
    public static class MyString
    {
        public static void ZeigeInterpoliertesString()
        {
            string interpolStr = $"DateTime.Now: {DateTime.Now}";
            Console.WriteLine(interpolStr);
        }

        public static void ZeigeEscapes()
        {
            string myStr = "\n nach n, \t nach t";
            Console.WriteLine(myStr);
        }

        public static void ZeigeVerbatimString()
        {
            Console.WriteLine("ZeigeVerbatimString");
            string myStr = @"
            nach n,          nach t";
            Console.WriteLine(myStr);
        }

        public static void ZeigeinterpoliertesVerbatimString()
        {
            Console.WriteLine("ZeigeinterpoliertesVerbatimString");
            string myStr = $@"
nach n,     {DateTime.Now}    nach t";
            Console.WriteLine(myStr);
        }
    }
}
