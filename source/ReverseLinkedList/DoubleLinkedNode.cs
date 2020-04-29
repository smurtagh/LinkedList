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
            DoubleLinkedNode previousNode = null;
            while (head != null)
            {
                DoubleLinkedNode nextNode = head.Next;
                head.Previous = head.Next;
                head.Next = previousNode;
                previousNode = head;
                head = nextNode;
            }
            head = previousNode;
        }

        public static void ReverseDoubleLinkedListRecursive(ref DoubleLinkedNode doubleHead)
        {
            DoubleLinkedNode result = null;
            ReverseDoubleLinkedListRecursive(ref result, doubleHead);
            doubleHead = result;
        }

        private static void ReverseDoubleLinkedListRecursive(ref DoubleLinkedNode head, DoubleLinkedNode currentNode)
        {
            if (currentNode == null)
                return;

            DoubleLinkedNode nextNode = currentNode.Next;
            currentNode.Previous = currentNode.Next;
            currentNode.Next = head;
            head = currentNode;

            ReverseDoubleLinkedListRecursive(ref head, nextNode);
        }
    }
}
