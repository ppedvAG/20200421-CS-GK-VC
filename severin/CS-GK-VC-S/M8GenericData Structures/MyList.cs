using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M8GenericData_Structures
{
	class MyList
	{
		// Schreiben eines Element in die Liste
		internal static List<DateTime> ZeigeListen()
		{
			List<DateTime> dateTimes = new List<DateTime>();
			dateTimes.Add(DateTime.Now);
			dateTimes.Add(DateTime.UtcNow);
			dateTimes.Add(DateTime.MinValue);



			List<string> stringsList = new List<string>();
			stringsList.Add("Hallo World");
			stringsList.Add(DateTime.Now.ToString());

			return dateTimes;
		}

			//
			// Summary:
			//     Löscht ein Element aus der angegebenen Liste an dem angegebenen Index
			//
			// Parameters:
			//   liste:
			//     Liste, aus welcher gelöscht werden soll.
			//
			//   index:
			//     index vom zu löschenden Element.
			//       
			// Returns:
			//     Anzahl von Elementen in der Liste nach dem Löschen.
			//
			// Exceptions:
			//   T:System.IndexOutOfRangeException:
			//     index negativ oder größer als Anzahl von Elementen ist.  

		// Lösche ein Element über den Index
		internal static int LöscheEinElementAmIndex(List<DateTime> liste, int index)
		{

			if (index > liste.Count - 1 || index < 0)
			{
				throw new IndexOutOfRangeException("außerhalb von möglichen Bereich");
			}
			else
			{
				liste.RemoveAt(index);				
			}
			
			return liste.Count;

		}
		// Lösche ein bestimmtes Element
		internal static int LöscheEinElement(List<DateTime> liste, DateTime el)
		{

			if (liste.Contains<DateTime>(el))
			{
				liste.Remove(el);
			}
			else
			{
				//throw new doesNotExistxception;
				Console.WriteLine("Das gesuchte Element ist nicht in der Liste");
			}
			return liste.Count;

		}
	}
}
