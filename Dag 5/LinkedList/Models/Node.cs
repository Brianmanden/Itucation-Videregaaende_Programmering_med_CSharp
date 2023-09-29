namespace LinkedList.Models
{
    public class Node
    {
        public object Data { get; set; }
        public Node Next { get; set; }

        public Node(object data, Node next)
        {
            this.Data = data;
            this.Next = next;
        }
    }
}
