using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M8GenericData_Structures
{
	class M8GenStructures
	{
		public static int NeueLänge { get; set; }

		static void Main(string[] args)
		{
			// #############################

			#region Using Lists
			//
			// Listenaufruf
			//
			List<DateTime> listeVonDateTime = MyList.ZeigeListen();

			int i = 0;

			foreach (var item in listeVonDateTime)
			{
				//Versuch
				Console.WriteLine($"listeVonDateTimes[{i}] : {item} - Element Nr. {++i}");

				// eigentliches auslesen der Liste
				Console.WriteLine($"{i}. {item}");

				i = i + 1;

			}

			Console.WriteLine($"listeVonDateTime.Count: {listeVonDateTime.Count}"); // wie viele Datensätze mögliche sind

			//auf eine einzelene stellen zugreifen
			Console.WriteLine($"Letzte Stelle einer Liste: {listeVonDateTime[listeVonDateTime.Count - 1]}");

			// 
			try
			{
				int NeueLänge = MyList.LöscheEinElementAmIndex(listeVonDateTime, 4); // soll fehler werfen
			}
			catch (IndexOutOfRangeException e)
			{
				string message = e.Message;
				Console.WriteLine(message);
			}
			catch (Exception e)
			{
				string message = e.Message;
				Console.WriteLine(message);
			}
			finally
			{
				Console.WriteLine($"neue Länge: {NeueLänge}");
			}


			// mit Fehler ausgabe
			// Console.WriteLine($"{listeVonDateTime[listeVonDateTime.Count]}");


			Console.WriteLine($"neueLänge: {NeueLänge}");
			#endregion

			// #############################

			#region Using Stacks
			//
			Stack<short> shortsStack = MyStack.ErzeugeStack<short>(3, 5, 1);

			Console.WriteLine("\nshortsStack");
			foreach (var item in shortsStack)
			{
				Console.WriteLine(item);
			}

			//
			Stack<char> charStack = MyStack.ErzeugeStack<char>('g', 'f', '5', '"', '7');

			Console.WriteLine("\ncharStack");
			foreach (var item in charStack)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine($"Anzahl von Elemnten von Stack: {charStack.Count}");

			//
			Stack<DateTime> listInStack = MyStack.ErzeugeStack<DateTime>(listeVonDateTime.ToArray());
			foreach (var item in listInStack)
			{
				Console.WriteLine(item);
			}

			#endregion

			// #############################

			#region Using Queue
			//
			Queue<uint> uintQueue = MyQueue.ErzeugeQueue<uint>(8, 6, 5, 2, 3);

			Console.WriteLine("\nuintQueue");
			foreach (var item in uintQueue)
			{
				Console.WriteLine(item);
			}
			#endregion

			// #############################

			#region Using KeyValuePairs

			KeyValuePair<byte, bool> myByteBoolKVP = MyKeyValuePair.ErzeugeKeyValuePair<byte, bool>(5, true);
			Console.WriteLine($"byte.MaxValue: {byte.MaxValue}"); // Max wert bei byte = 255
			Console.WriteLine("myByteBoolKVP.Key:" + myByteBoolKVP.Key);
			Console.WriteLine("myByteBoolKVP.Value:" + myByteBoolKVP.Value);
			#endregion


			#region Using Dictionary
			Dictionary<byte, bool> myDictionary = MyDictionary.ErzeugeDictionary<byte, bool>(myByteBoolKVP, MyKeyValuePair.ErzeugeKeyValuePair<byte, bool>(3,false), MyKeyValuePair.ErzeugeKeyValuePair<byte, bool>(1, true));
			Console.WriteLine("\nmyDictionary");
			foreach (var item in myDictionary.Keys)
			{
				Console.WriteLine($"key: {item}");
			}
			foreach (var item in myDictionary.Values)
			{
				Console.WriteLine($"value: {item}");
			}

			#endregion
			Console.ReadKey();

		}
	}
}
