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

    
}
