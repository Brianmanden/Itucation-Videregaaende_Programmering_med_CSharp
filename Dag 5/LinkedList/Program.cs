using LinkedList.Models;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Linked list is instantiated
            MyLinkedList linkedList = new MyLinkedList();

            // The index 123 of the first node is ignored due to guard logic in the class. The first node gets added to the start of the linked list.
            linkedList.Add(123, "first");
            // This second node gets added to the end of the linked list.
            linkedList.Add("third");
            // This third node is inserted in between the nodes at index 0 and 1.
            linkedList.Add(1, "second");

            linkedList.Print();
            // Output:
            // first
            // second
            // third
        }
    }
}