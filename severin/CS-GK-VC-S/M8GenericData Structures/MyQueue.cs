using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M8GenericData_Structures
{
	class MyQueue
	{
		internal static Queue<TYPE> ErzeugeQueue<TYPE>(params TYPE[] elementeFürQueue)
		{
			Queue<TYPE> autoQueue = new Queue<TYPE>();

			foreach (var item in elementeFürQueue)
			{
				autoQueue.Enqueue(item);
			}
			return autoQueue;
		}
	}
}
