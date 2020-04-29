using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseLinkedList
{
    internal class DoubleLinkedNode
    {
        public DoubleLinkedNode Previous { get; set; }
        public DoubleLinkedNode Next { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            return $"P:{Previous?.Value ?? "null"} V:{Value} N:{Next?.Value ?? "null"} - {Next?.ToString()}".Trim().Trim('-');
        }
    }

    internal static class DoubleLinkedNodeHelper
    {
        public static void ReverseDoubleLinkedList(ref DoubleLinkedNode head)
        {
            DoubleLinkedNode result = null;
            while (head != null)
            {
                DoubleLinkedNode nextIteration = head.Next;
                head.Previous = head.Next;
                head.Next = result;
                result = head;
                head = nextIteration;
            }
            head = result;
        }

        public static void ReverseDoubleLinkedListRecursive(ref DoubleLinkedNode doubleHead)
        {
            DoubleLinkedNode result = null;
            RReverseDoubleLinkedListRecursive(ref result, doubleHead);
            doubleHead = result;
        }

        private static void RReverseDoubleLinkedListRecursive(ref DoubleLinkedNode head, DoubleLinkedNode current)
        {
            if (current == null)
                return;

            DoubleLinkedNode nextIteration = current.Next;
            current.Previous = current.Next;
            current.Next = head;
            head = current;

            RReverseDoubleLinkedListRecursive(ref head, nextIteration);
        }
    }
}
