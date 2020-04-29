using System;

namespace ReverseLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

            //================== Single Linked List ============================
            Console.WriteLine("Single Link");

            var linkedHead = new LinkedNode() { Value = "1", Next = new LinkedNode { Value = "2", Next = new LinkedNode() { Value = "3", Next = new LinkedNode() { Value = "4", Next = new LinkedNode() { Value = "5" } } } } };

            //show original order
            Console.WriteLine(linkedHead.ToString());

            ReverseList(ref linkedHead);

            //show reverse order
            Console.WriteLine(linkedHead.ToString());

            ReverseListRecursive(ref linkedHead);

            //back to normal
            Console.WriteLine(linkedHead.ToString());

            //================== Double Linked List ============================
            Console.WriteLine("Dobule Link");
            
            var doubleLinkedHead = new DoubleLinkedNode() { Value = "1" };
            var doubleLinkedSecond = new DoubleLinkedNode() { Value = "2" };
            var doubleLinkedThird = new DoubleLinkedNode() { Value = "3" };
            var doubleLinkedFourth = new DoubleLinkedNode() { Value = "4" };
            var doubleLinkedFitfth = new DoubleLinkedNode() { Value = "5" };

            doubleLinkedHead.Next = doubleLinkedSecond;
            doubleLinkedSecond.Previous = doubleLinkedHead;
            doubleLinkedSecond.Next = doubleLinkedThird;
            doubleLinkedThird.Previous = doubleLinkedSecond;
            doubleLinkedThird.Next = doubleLinkedFourth;
            doubleLinkedFourth.Previous = doubleLinkedThird;
            doubleLinkedFourth.Next = doubleLinkedFitfth;
            doubleLinkedFitfth.Previous = doubleLinkedFourth;

            //show original order
            Console.WriteLine(doubleLinkedHead.ToString());

            ReverseDoubleList(ref doubleLinkedHead);

            //show reverse order
            Console.WriteLine(doubleLinkedHead.ToString());

            ReverseDoubleListRecursive(ref doubleLinkedHead);

            //back to normal
            Console.WriteLine(doubleLinkedHead.ToString());

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        private static void ReverseDoubleList(ref DoubleLinkedNode head)
        {
            DoubleLinkedNode current = head, result = null;
            while (current != null)
            {
                DoubleLinkedNode nextIteration = current.Next;
                current.Previous = current.Next;
                current.Next = result;                
                result = current;
                current = nextIteration;
            }
            head = result;
        }

        private static void ReverseDoubleListRecursive(ref DoubleLinkedNode doubleHead)
        {
            DoubleLinkedNode result = null;
            ReverseDoubleListRecursive(ref result, doubleHead);
            doubleHead = result;
        }

        private static void ReverseDoubleListRecursive(ref DoubleLinkedNode head, DoubleLinkedNode current)
        {
            if (current == null)
                return;

            DoubleLinkedNode nextIteration = current.Next;
            current.Previous = current.Next;
            current.Next = head;
            head = current;

            ReverseDoubleListRecursive(ref head, nextIteration);
        }

        private static void ReverseList(ref LinkedNode head)
        {
            LinkedNode current = head, result = null;
            while (current != null)
            {
                LinkedNode nextIteration = current.Next;
                current.Next = result;
                result = current;
                current = nextIteration;
            }
            head = result;
        }

        private static void ReverseListRecursive(ref LinkedNode head)
        {
            LinkedNode result = null;
            ReverseListRecursive(ref result, head);
            head = result;
        }

        private static void ReverseListRecursive(ref LinkedNode head, LinkedNode current)
        {
            if (current == null)
                return;

            LinkedNode nextIteration = current.Next;
            current.Next = head;
            head = current;

            ReverseListRecursive(ref head, nextIteration);
        }
    }
}
