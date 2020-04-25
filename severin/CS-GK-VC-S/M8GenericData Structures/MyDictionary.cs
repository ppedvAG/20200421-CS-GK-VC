using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M8GenericData_Structures
{
	class MyDictionary
	{
		internal static Dictionary<TKey, TValue> ErzeugeDictionary<TKey, TValue>(params KeyValuePair<TKey, TValue>[] kvpArray)
		{
			Dictionary<TKey, TValue> myDictionary = new Dictionary<TKey, TValue>();
			foreach (var item in kvpArray)
			{
				myDictionary.Add(item.Key, item.Value);
			}			
			return myDictionary;
		}
	}
}
