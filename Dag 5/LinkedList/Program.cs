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

            // More nodes are consecutively added to the linked list
            linkedList.Add("fourth");
            linkedList.Add("to be removed"); // index 4
            linkedList.Add("fifth");
            linkedList.Print();
            // Output:
            // first
            // second
            // third
            // fourth
            // to be removed
            // fifth

            Console.WriteLine(Environment.NewLine);

            // remove node at index 4
            linkedList.RemoveAt(4);
            linkedList.Print();
            // Output:
            // first
            // second
            // third
            // fourth
            // fifth

            Console.ReadKey();
        }
    }
}