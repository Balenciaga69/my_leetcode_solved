namespace LeetCode.Utilities;

public static class ListBuilder
{
    public static ListNode? FromArray(int[] values)
    {
        var dummy = new ListNode();
        var current = dummy;

        foreach (var value in values)
        {
            current.next = new ListNode(value);
            current = current.next;
        }

        return dummy.next;
    }

    public static int[] ToArray(ListNode? head)
    {
        var values = new List<int>();
        var current = head;

        while (current is not null)
        {
            values.Add(current.val);
            current = current.next;
        }

        return values.ToArray();
    }
}
