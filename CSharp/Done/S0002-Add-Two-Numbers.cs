using System.Collections;

namespace Csharp.Done
{
    public class S0002_Add_Two_Numbers
    {
        public ListNode? AddTwoNumbers(ListNode? l1, ListNode? l2)
        {
            ListNode? result = null;
            ListNode? currentNode = null;
            int curry = 0;
            while (l1 != null || l2 != null)
            {
                int sum = 0 + curry;

                if (l1 != null)
                {
                    sum += l1.val;
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    sum += l2.val;
                    l2 = l2.next;
                }
                if (currentNode == null)
                {
                    currentNode = new ListNode(sum % 10, null);
                }
                else
                {
                    currentNode.next = new ListNode(sum % 10, null);
                    currentNode = currentNode.next;
                }
                if (result == null)
                {
                    result = currentNode;
                }
                curry = sum / 10;
            }

            if (curry > 0 && currentNode != null)
            {
                currentNode.next = new ListNode(curry, null);
            }
            return result;
        }

        public void Run()
        {
            var a = ConvertArrayToLinkedList(new int[] { 9, 9, 9, 9, 9, 9 });
            var b = ConvertArrayToLinkedList(new int[] { 9, 9, 9 });
            var c = AddTwoNumbers(a, b);
        }

        private ListNode? ConvertArrayToLinkedList(int[] arr)
        {
            return arr.Aggregate((ListNode?)null, (next, val) => new ListNode(val, next));
        }

        public class ListNode
        {
            public int val;
            public ListNode? next;

            public ListNode(int val = 0, ListNode? next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
    }
}