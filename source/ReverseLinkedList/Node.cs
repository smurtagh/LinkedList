using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseLinkedList
{
    internal class Node
    {
        public Node Next { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            return $"{Value} - {Next?.ToString()}".Trim().Trim('-');
        }
    }

    internal class DoubleNode
    {
        public DoubleNode Previous { get; set; }
        public DoubleNode Next { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            return $"{Previous?.Value ?? "null"} {Value} {Next?.Value ?? "null"} - {Next?.ToString()}".Trim().Trim('-');
        }
    }
}
