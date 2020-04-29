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
}
