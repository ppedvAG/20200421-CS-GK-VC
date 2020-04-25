using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M8GenericData_Structures
{
	class MyKeyValuePair
	{
		internal static KeyValuePair<TKey, TValue> ErzeugeKeyValuePair<TKey, TValue>(TKey key, TValue value)
		{
			KeyValuePair<TKey, TValue> myKeyValuePair = new KeyValuePair<TKey, TValue>(key, value);
			return myKeyValuePair;
		}
		
	}
}
