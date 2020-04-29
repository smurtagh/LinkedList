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
            LinkedNode previousNode = null;
            while (head != null)
            {
                LinkedNode nextNode = head.Next;
                head.Next = previousNode;
                previousNode = head;
                head = nextNode;
            }
            head = previousNode;
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

            LinkedNode nextNode = current.Next;
            current.Next = head;
            head = current;

            ReverseLinkedListRecursive(ref head, nextNode);
        }
    }
}
