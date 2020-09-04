using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace CsharpPlayground
{
    class CollectionsTest
    {
        List<String> people = new List<String>();
        Dictionary<String, int> NIC = new Dictionary<string, int>();  //Dictionaries replace hashtables which serve the same purpose
        ConcurrentDictionary<String, int> NIC_Concurrent = new ConcurrentDictionary<string, int>();
        BitArray enemyGrid = new BitArray(3); // for bool, int and binary
        Tuple<int, String, bool> tups = new Tuple<int, String, bool>(1234, "VD", true); //Can store multiple values of multiple data types
        Stack<String> plates = new Stack<String>(); //LIFO - Last in First Out
        Queue<String> queue = new Queue<String>();//FIFO - First In First Out
        HashSet<String> myHash = new HashSet<String>(); //Removes duplicate items automatically.

        void populate()
        {
            var myTuple = Tuple.Create(1234, "VD", true); // Create and return a random tuple (System method)
            people.Add("VD");
            NIC.Add("VD", 123456);
            plates.Push("Plate one");
            plates.Push("Plate two");
            plates.Push("Plate three"); // Push - add item to stack, Pop- Remove last item added, Peek - Retrieve last added element
            queue.Enqueue("A"); // Enqueue - add item to queue, Dequeue - Remove earliest item added, Peek - Check the earliest item
            queue.Enqueue("B");
            queue.Enqueue("C");
        }
    }
}
