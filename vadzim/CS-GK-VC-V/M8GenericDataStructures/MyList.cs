using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M8GenericDataStructures
{
    class MyList
    {
        internal static List<DateTime> ZeigeListen()
        {
            List<DateTime> dateTimes = new List<DateTime>();
            dateTimes.Add(DateTime.Now);
            dateTimes.Add(DateTime.UtcNow);
            dateTimes.Add(DateTime.MaxValue);            

            List<string> stringsListe = new List<string>();
            stringsListe.Add(DateTime.Now.ToString());

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
        
        // *todo Kommentar geht nicht ins IntelliSense rüber
        internal static int LöscheEinElementAmIndex(List<DateTime> liste, int index)
        {
            if (index > liste.Count-1 || index < 0)
            {
                throw new IndexOutOfRangeException("außerhalb vom möglichen Bereich");
            }
            else
            {
                liste.RemoveAt(index);                  
            }
            return liste.Count;
        }
        internal static int LöscheEinElement(List<DateTime> liste, DateTime el)
        {
            if (liste.Contains<DateTime>(el))
            {
                liste.Remove(el);
            }
            else
            {
                // throw new doesNotExistException;
                Console.WriteLine("Das gesuchte Element ist nicht in der Liste");
            }
            return liste.Count;
        }
    }
}
