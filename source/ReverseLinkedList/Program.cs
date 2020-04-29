using System;

namespace ReverseLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListReverse();
            
            Console.WriteLine();

            DoubleLinkedListReverse();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }        

        private static void LinkedListReverse()
        {
            Console.WriteLine("Single Link");

            var linkedHead = new LinkedNode() { Value = "1", Next = new LinkedNode { Value = "2", Next = new LinkedNode() { Value = "3", Next = new LinkedNode() { Value = "4", Next = new LinkedNode() { Value = "5" } } } } };

            //show original order
            Console.WriteLine(linkedHead.ToString());

            //reverse it
            LinkedNodeHelper.ReverseLinkedList(ref linkedHead);

            //show reverse order
            Console.WriteLine(linkedHead.ToString());

            //reverse it again
            LinkedNodeHelper.ReverseLinkedListRecursive(ref linkedHead);

            //show original order again
            Console.WriteLine(linkedHead.ToString());
        }

        private static void DoubleLinkedListReverse()
        {
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

            //reverse it
            DoubleLinkedNodeHelper.ReverseDoubleLinkedList(ref doubleLinkedHead);

            //show reverse order
            Console.WriteLine(doubleLinkedHead.ToString());

            //reverse it again
            DoubleLinkedNodeHelper.ReverseDoubleLinkedListRecursive(ref doubleLinkedHead);

            //show original order again
            Console.WriteLine(doubleLinkedHead.ToString());
        }
    }
}
