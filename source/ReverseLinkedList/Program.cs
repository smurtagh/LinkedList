using System;

namespace ReverseLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

            //================== Single Linked List ============================
            Console.WriteLine("Single Link");

            var head = new Node() { Value = "1", Next = new Node { Value = "2", Next = new Node() { Value = "3", Next = new Node() { Value = "4", Next = new Node() { Value = "5" } } } } };

            //show original order
            Console.WriteLine(head.Print());

            ReverseList(ref head);

            //show reverse order
            Console.WriteLine(head.Print());

            Node result = null;
            ReverseListRecursive(ref result, head);

            //back to normal
            Console.WriteLine(result.Print());

            //================== Double Linked List ============================
            Console.WriteLine("Dobule Link");
            
            var doubleHead = new DoubleNode() { Value = "1" };
            var doubleSecond = new DoubleNode() { Value = "2" };
            var doubleThird = new DoubleNode() { Value = "3" };
            var doubleFourth = new DoubleNode() { Value = "4" };
            var doubleFitfth = new DoubleNode() { Value = "5" };

            doubleHead.Next = doubleSecond;
            doubleSecond.Previous = doubleHead;
            doubleSecond.Next = doubleThird;
            doubleThird.Previous = doubleSecond;
            doubleThird.Next = doubleFourth;
            doubleFourth.Previous = doubleThird;
            doubleFourth.Next = doubleFitfth;
            doubleFitfth.Previous = doubleFourth;

            //show original order
            Console.WriteLine(doubleHead.Print());

            ReverseDoubleList(ref doubleHead);

            //show reverse order
            Console.WriteLine(doubleHead.Print());

            ReverseDoubleListRecursive(ref doubleHead);

            //back to normal
            Console.WriteLine(doubleHead.Print());

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        private static void ReverseDoubleList(ref DoubleNode head)
        {
            DoubleNode current = head, result = null;
            while (current != null)
            {
                DoubleNode nextIteration = current.Next;
                current.Previous = current.Next;
                current.Next = result;                
                result = current;
                current = nextIteration;
            }
            head = result;
        }

        private static void ReverseDoubleListRecursive(ref DoubleNode doubleHead)
        {
            DoubleNode result = null;
            ReverseDoubleListRecursive(ref result, doubleHead);
            doubleHead = result;
        }

        private static void ReverseDoubleListRecursive(ref DoubleNode head, DoubleNode current)
        {
            if (current == null)
                return;

            DoubleNode nextIteration = current.Next;
            current.Previous = current.Next;
            current.Next = head;
            head = current;

            ReverseDoubleListRecursive(ref head, nextIteration);
        }

        private static void ReverseList(ref Node head)
        {
            Node current = head, result = null;
            while (current != null)
            {
                Node nextIteration = current.Next;
                current.Next = result;
                result = current;
                current = nextIteration;
            }
            head = result;
        }

        private static void ReverseListRecursive(ref Node head)
        {
            Node result = null;
            ReverseListRecursive(ref result, head);
            head = result;
        }

        private static void ReverseListRecursive(ref Node head, Node current)
        {
            if (current == null)
                return;

            Node nextIteration = current.Next;
            current.Next = head;
            head = current;

            ReverseListRecursive(ref head, nextIteration);
        }
    }
}
