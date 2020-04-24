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
            #region Using Lists
            List<DateTime> listeVonDateTimes = MyList.ZeigeListen();
            int i = 0;
            foreach (var el in listeVonDateTimes)
            {                
                Console.WriteLine($"listeVonDateTimes[{i}] : {el} - Element Nr. {++i}");                
            }
            Console.WriteLine($"listeVonDateTimes.Count: {listeVonDateTimes.Count}");
            Console.WriteLine($"{listeVonDateTimes[listeVonDateTimes.Count-1]}");           
            try
            {                
                NeueLänge = MyList.LöscheEinElementAmIndex(listeVonDateTimes, 4);
            }
            catch (IndexOutOfRangeException e)
            {
                string message = e.Message;
                Console.WriteLine(message);
            }
            catch (Exception e)
            {
                string message = e.Message;
                Console.WriteLine(message);
            }
            finally
            { 
            Console.WriteLine($"neueLänge: {NeueLänge}");
            }
            #endregion

            // ########################################################
            // ########################################################
            // ########################################################

            #region Using Stacks
            Stack<short> shortsStack = MyStack.ErzeugeStack<short>(3, 5, 1);
            Console.WriteLine("\nshortsStack");
            foreach (var item in shortsStack)
            {
                Console.WriteLine(item);
            }
            Stack<char> charsStack = MyStack.ErzeugeStack<char>('g', 'f', '5', '"', '7');
            Console.WriteLine("\ncharsStack");
            foreach (var item in charsStack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Anzahl von Elementen in charsStack: {charsStack.Count}");

            // Liste zu einem Array umwandeln und aus diesem Array ein Stack bauen
            Stack<DateTime> dtsStack = MyStack.ErzeugeStack<DateTime>(listeVonDateTimes.ToArray());
            Console.WriteLine("\ndtsStack"); 
            foreach (var item in dtsStack)
            {
                Console.WriteLine(item);
            }

            #endregion

            // ########################################################
            // ########################################################
            // ########################################################

            #region Using Queues
            Queue<uint> uintsQueue = MyQueue.ErzeugeQueue<uint>(3, 3, 5, 2);
            // uintsQueue.OrderByDescending
            Console.WriteLine("\nuintsQueue");
            foreach (var item in uintsQueue)
            {
                Console.WriteLine(item);
            }
            #endregion


            #region Using KeyValuePairs
            KeyValuePair<byte, bool> myByteBoolKVP = MyKeyValuePair.ErzeugeKVP<byte, bool>(5, true);
            Console.WriteLine("byte.MaxValue: " + byte.MaxValue); // 255
            Console.Write("myByteBoolKVP.Key: " + myByteBoolKVP.Key);
            Console.WriteLine(", myByteBoolKVP.Value: " + myByteBoolKVP.Value);
            #endregion
            Console.ReadKey();
        }
    }
}
