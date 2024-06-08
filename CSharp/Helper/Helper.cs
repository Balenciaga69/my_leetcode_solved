using Csharp.LeetCode.Structure;

namespace Csharp.Helper
{
    public class Helper
    {
        public ListNode? ConvertArrayToLinkedList(int[] arr)

        {
            return arr.Aggregate((ListNode?)null, (next, val) => new ListNode(val, next));
        }
    }
}