using DataTypesLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesLibConsumer
{
    class DTLConsumer
    {
        static void Main(string[] args)
        {
            MyBool.ZeigeGleichheit();
            MyBool.ZeigeUngleichheit();
            MyBool.ZeigeUnd();
            MyBool.ZeigeOder();
            MyBool.ZeigeAusschlOder();
            MyString.ZeigeInterpoliertesString();
            MyString.ZeigeEscapes();
            MyString.ZeigeVerbatimString();
            MyString.ZeigeinterpoliertesVerbatimString();
            MyInt.ZeigeLiterals();
            MyInt.ZeigeMöglicheWerte();
            MyInt.ZeigeParsing();
            MyInt.ZeigeCasting();
            MyInt.ZeigeVergleich();
            MyDouble.ZeigeDouble();
            MyEnum.ZeigeEnumerator();
            Console.ReadKey();
        }
    }
}
