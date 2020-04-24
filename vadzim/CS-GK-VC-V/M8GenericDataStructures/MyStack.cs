using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M8GenericDataStructures
{
    class MyStack
    {
        internal static Stack<TYPE> ErzeugeStack<TYPE>(params TYPE[] elementeFürStack)
        {
            Stack<TYPE> autoStack = new Stack<TYPE>();
            foreach (var item in elementeFürStack)
            {
                autoStack.Push(item);               
            }
            return autoStack;
        }
        // Löschen mit Pop()
    }
}
