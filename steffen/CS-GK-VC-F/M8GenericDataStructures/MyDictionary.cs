using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M8GenericDataStructures
{
    class MyDictionary
    {
        internal static Dictionary<TKey, TValue> ErzeugeDictionary<TKey, TValue>(TKey key, TValue value)
        {
            Dictionary<TKey, TValue> myDictionary = new Dictionary<TKey, TValue>();
            myDictionary.Add(key, value);
            return myDictionary;
        }
    }
}
