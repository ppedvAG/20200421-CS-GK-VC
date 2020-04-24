using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M8GenericDataStructures
{
    class MyQueue
    {
        internal static Queue<T> ErzeugeQueue<T>(params T[] elementeFürQueue)
        {
            Queue<T> autoQueue = new Queue<T>();
            foreach (var item in elementeFürQueue)
            {
                autoQueue.Enqueue(item);
            }
            return autoQueue;
        }
    }
}
