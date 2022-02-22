namespace ab3term3try1
{
    public class LinkedListNode
    {
        public Key_ValuePair Pair{ get; }
        
        public LinkedListNode Next { get; set;  }

        public LinkedListNode(Key_ValuePair pair, LinkedListNode next = null)
        {
            Pair = pair;
            Next = next;
        }
        
    }
}
