using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseLinkedList
{
    internal class Node
    {
        public Node Next { get; set; }
        public string Value { get; set; }
        
        public string Print()
        {
            return $"{Value} - {Next?.Print()}".Trim().Trim('-');
        }
    }

    internal class DoubleNode
    {
        public DoubleNode Previous { get; set; }
        public DoubleNode Next { get; set; }
        public string Value { get; set; }

        public string Print()
        {
            return $"{Previous?.Value ?? "null"} {Value} {Next?.Value ?? "null"} - {Next?.Print()}".Trim().Trim('-');
        }
    }
}
