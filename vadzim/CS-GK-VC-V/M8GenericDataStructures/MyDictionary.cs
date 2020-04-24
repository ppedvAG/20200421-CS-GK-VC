using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M8GenericDataStructures
{
    class MyDictionary
    {
        internal static Dictionary<T1, T2> ErzeugeDictionary<T1, T2>(params KeyValuePair<T1, T2>[] kvpArray)
        {
            Dictionary<T1, T2> dict = new Dictionary<T1, T2>();
            foreach (var item in kvpArray)
            {
                dict.Add(item.Key, item.Value);
            }
            return dict;
        }            
    }
}
