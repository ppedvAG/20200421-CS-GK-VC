using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M8GenericDataStructures
{
    class MyList
    {
        public static List<DateTime> ZeigeListen()
        {
            List<DateTime> dateTimes = new List<DateTime>();
            dateTimes.Add(DateTime.Now);
            dateTimes.Add(DateTime.UtcNow);
            dateTimes.Add(DateTime.Today);
            dateTimes.Add(DateTime.MinValue);
            dateTimes.Add(DateTime.MaxValue);


            List<string> stringListe = new List<string>();
            stringListe.Add(DateTime.Now.ToString());

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

        internal static int LöscheEinElementAmIndex(List<DateTime> liste, int index)
        {
            // Remove(element)
            // RemoveAt(index)
            if (index > liste.Count - 1 || index < 0)
            {
                throw new IndexOutOfRangeException("ausserhalb des gültigen Bereichs");
            }
            else
            {
                liste.RemoveAt(index);
            }
            return liste.Count;
        }

        internal static int LöscheEinElement(List<DateTime> liste, DateTime element)
        {
            if (liste.Contains<DateTime>(element))
            {
                liste.Remove(element);
            }
            else
            {
                Console.WriteLine("Das gesuchte Element ist nicht in der Liste");
            }

            return liste.Count;

        }
    }
}
