using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseLinkedList
{
    internal class LinkedNode
    {
        public LinkedNode Next { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            return $"V:{Value} N:{Next?.Value ?? "null"} - {Next?.ToString()}".Trim().Trim('-');
        }
    }

    internal static class LinkedNodeHelper
    {
        public static void ReverseLinkedList(ref LinkedNode head)
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

        public static void ReverseLinkedListRecursive(ref LinkedNode head)
        {
            LinkedNode result = null;
            ReverseLinkedListRecursive(ref result, head);
            head = result;
        }

        private static void ReverseLinkedListRecursive(ref LinkedNode head, LinkedNode current)
        {
            if (current == null)
                return;

            LinkedNode nextIteration = current.Next;
            current.Next = head;
            head = current;

            ReverseLinkedListRecursive(ref head, nextIteration);
        }
    }
}
