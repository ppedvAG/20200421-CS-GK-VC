using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTypesLib;

namespace DataTypesLibConsumer
{
	class DTLConsumer
	{
		static void Main(string[] args)
		{
			MyBool.ZeigeGleichheit();

			MyBool.ZeigeUngleichheit();

			MyBool.ZeigeUngleichheit();

			MyBool.ZeigeUnd();

			MyBool.ZeigeOder();

			MyBool.ZeigeAusschlOder();

			MyString.ZeigeInterpoliertesString();

			MyString.ZeigeEscapes();

			MyString.ZeigeInterpoliertesString();

			MyString.ZeigeInterpoliertesVerbatimString();

			MyInt.ZeigeLiterals();

			MyInt.ZeigeMöglicheWerte();

			MyInt.ZeigeParsing();

			MyInt.ZeigeCasting();

			MyInt.ZeigeVergleich();

			Console.ReadKey();
		}
	}
}
