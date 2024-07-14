    public class ListNode
    {
        public object Data { get; private set; }
        public ListNode Next { get; set; }

        public ListNode(object dataValue) : this(dataValue, null) { }

        public ListNode(object dataValue, ListNode nextNode)
        {
            Data = dataValue;
            Next = nextNode;
        }
    }