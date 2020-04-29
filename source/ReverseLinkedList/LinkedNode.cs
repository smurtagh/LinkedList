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
            return $"{Value} - {Next?.ToString()}".Trim().Trim('-');
        }
    }

    internal static class LinkedNodeHelper
    {
        public static void ReverseList(ref LinkedNode head)
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

        public static void ReverseListRecursive(ref LinkedNode head)
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
