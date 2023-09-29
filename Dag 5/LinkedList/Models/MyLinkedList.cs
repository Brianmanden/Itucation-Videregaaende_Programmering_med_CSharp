﻿using System.ComponentModel;

namespace LinkedList.Models
{
    public class MyLinkedList
    {
        Node firstNode;
        int count;

        public int Count { get => count; }
        public bool IsEmpty { get => count == 0; }

        public MyLinkedList() {
            count = 0;
            firstNode = null;
        }

        /// <summary>
        /// Add data at specified index.
        /// </summary>
        /// <param name="index">The index where the data will be added.</param>
        /// <param name="data">Any data of type object.</param>
        /// <exception cref="IndexOutOfRangeException"></exception>
        public void Add(int index, object data)
        {
            // It is not possible to add a node to a negative index
            if (index < 0)
            {
                throw new IndexOutOfRangeException($"Index is out of range. Index: {index}");
            }

            // It is not possible to add a node to an index further ahead of the actual number of nodes in the linked list. Change to using the last node on the linked list instead.
            if (index > count)
            {
                index = count;
            }

            Node current = firstNode;
            // If the linked list is empty or attempting to add data at the first place of the linked list ...
            if (IsEmpty || index == 0)
            {
                // ... add data to the first node
                firstNode = new Node(data, firstNode);
            }
            // Loop through the linked list to the node before the index and get it´s next node to be able to splice in the given data
            else
            {
                for (int i = 0; i < index - 1; i++)
                {
                    // Get the next node where the linked list is opened up and ...
                    current = current.Next;
                }
                // ... add in the given data and splice with next to close the linked list again.
                current.Next = new Node(data, current.Next);
            }
            // A new node has been added. Adjust count accordingly.
            count++;
        }

        /// <summary>
        /// Append data to the end of the linked list
        /// </summary>
        /// <param name="data"></param>
        public void Add(object data) {
            Add(count, data);
        }

        public void RemoveAt(int index)
        {
            // It is not possible to remove a node at a negative index
            if (index < 0)
            {
                throw new IndexOutOfRangeException($"Index is out of range. Index: {index}");
            }

            // It is not possible to remove any nodes from an empty list
            if (IsEmpty)
            {
                Console.WriteLine("Nothing to remove.");
            }

            // To get started parsing the linked list - set current node to the firstNode
            Node current = firstNode;

            // If attempting to remove the first node in the linked list ...
            if (index == 0)
            {
                // ... set the firstNode to the next node in the linked list = the first node is "unlinked" from list
                firstNode = current.Next;
            }
            else
            {
                // Loop through linked list from start to the node before the one to be removed ...
                for (int i = 0; i < index - 1; i++)
                {
                    // ... assuming node before one to be removed is reached ...
                    current = current.Next;
                }
                // ... with node before node to be removed, skip the one to be removed and splice list again
                current.Next = current.Next.Next;
            }
            // A node has been removed. Adjust count accordingly.
            count--;
        }

        public void Print()
        {
            Node current = firstNode;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }
    }
}
