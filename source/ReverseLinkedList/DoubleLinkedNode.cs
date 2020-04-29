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
            return $"{Previous?.Value ?? "null"} {Value} {Next?.Value ?? "null"} - {Next?.ToString()}".Trim().Trim('-');
        }
    }

    internal static class DoubleLinkedNodeHelper
    {
        public static void ReverseDoubleList(ref DoubleLinkedNode head)
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

        public static void ReverseDoubleListRecursive(ref DoubleLinkedNode doubleHead)
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
    }
}
