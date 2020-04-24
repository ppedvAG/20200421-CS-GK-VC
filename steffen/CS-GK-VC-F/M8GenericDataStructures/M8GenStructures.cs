using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M8GenericDataStructures
{
    class M8GenStructures
    {
        public static int NeueLänge { get; set; }

        static void Main(string[] args)
        {
            #region Using MyList-Classes

            List<DateTime> listeVonDateTimes = MyList.ZeigeListen();

            int i = 0;

            foreach (var element in listeVonDateTimes)
            {
                //Console.WriteLine($"{i++}. {element}");
                Console.WriteLine($"listeVonDateTimes[{i}] : {element} - Element Nr. {++i}");
            }

            Console.WriteLine($"listeVonDateTimes.Count: {listeVonDateTimes.Count}");
            Console.WriteLine($"listeVonDateTimes.Count-1t: {listeVonDateTimes[listeVonDateTimes.Count - 1]}");

            try
            {
                int neueLänge = MyList.LöscheEinElementAmIndex(listeVonDateTimes, 7);
            }

            catch (IndexOutOfRangeException e)
            {
                string message = e.Message;
                Console.WriteLine($"Fehlernachrich: {message}");
            }
            catch (Exception e)
            {
                string message = e.Message;
                Console.WriteLine($"Fehlernachrich: {message}");
            }
            finally
            {
                Console.WriteLine($"neue Länge: {NeueLänge}");
            }

            

            
            //int neueLänge = MyList.LöscheEinElementAmIndex(listeVonDateTimes, 7);
            #endregion

            #region Using MyStack-Classes

            Stack<short> shortsStack = MyStack.ErzeugeStack<short>(3, 5, 1);

            foreach (var item in shortsStack)
            {
                Console.WriteLine($"Ausgabe vom Stack (short): {item}");
            }

            Stack<char> charStack = MyStack.ErzeugeStack<char>('A', 'B', 'C', 'D', 'E', '1', '%');

            foreach (var item in charStack)
            {
                Console.WriteLine($"Ausgabe vom Stack (char): {item}");
            }

            Console.WriteLine($"Anzahl von Elemente shortsStack: {shortsStack.Count}.");
            Console.WriteLine($"Anzahl von Elemente charStack: {charStack.Count}.");

            Stack<DateTime> dateTimeStack = MyStack.ErzeugeStack<DateTime>(listeVonDateTimes.ToArray());
            foreach (var item in dateTimeStack)
            {
                Console.WriteLine($"Ausgabe vom Stack (datetime): {item}");
            }


            #endregion

            #region Using MyQueue-Classes


            Queue<uint> ointQueue = MyQueue.ErzeugeQueue<uint>(17, 18, 99, 23);

            //ointQueue.OrderByDescending


            foreach (var item in ointQueue)
            {
                Console.WriteLine($"Ausgabe vom Queue (uint): {item}");
            }

            Console.WriteLine($"Anzahl von Elemente uintQueue: {ointQueue.Count}.");


            #endregion

            #region Using MyKeyValuePair-Classes

            KeyValuePair<byte, bool> myByteBoolKVP = MyKeyValuePair.ErzeugeKVP<byte, bool>(5, true);
            Console.WriteLine("byte.MaxValue: " + byte.MaxValue); //255
            Console.WriteLine("myByteBoolKVP.Key: " + myByteBoolKVP.Key);
            Console.WriteLine("myByteBoolKVP.Value: " + myByteBoolKVP.Value);

            #endregion

            #region Using MyDictionary

            Dictionary<byte, bool> myDictionary = MyDictionary.ErzeugeDictionary<byte, bool>(myByteBoolKVP.Key, myByteBoolKVP.Value);

            //foreach (var item in myDictionary.Keys)
            //{
            //    Console.WriteLine($"key: {item}");
            //}

            //foreach (var item in myDictionary.Values)
            //{
            //    Console.WriteLine($"Value: {item}");
            //}


            foreach (var item in myDictionary)
            {
                Console.WriteLine($"Dictionary: {item.GetType()}");
            }
            #endregion
            Console.ReadKey();
        }
    }
}
