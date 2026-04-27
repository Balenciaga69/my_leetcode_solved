// TODO:
// 題目：給定單向鏈結串列 head，移除倒數第 n 個節點並回傳新的 head。
using LeetCode.Utilities;

namespace LeetCode.Solutions;

public class S0019
{
    private const Method ActiveMethod = Method.OnePassTwoPointers;

    private enum Method
    {
        OnePassTwoPointers,
        TwoPassLength
    }

    /*
     * 主方法只負責切換目前採用的解法。
     * 預設使用 dummy node 加雙指針，一次遍歷即可移除倒數第 n 個節點。
     * dummy node 可統一處理刪除 head 的邊界情況。
     */
    public ListNode? RemoveNthFromEnd(ListNode? head, int n)
    {
        return ActiveMethod switch
        {
            Method.OnePassTwoPointers => RemoveNthFromEnd_OnePassTwoPointers(head, n),
            Method.TwoPassLength => RemoveNthFromEnd_TwoPassLength(head, n),
            _ => throw new InvalidOperationException("Unknown solution method.")
        };
    }

    /*
     * fast 先從 dummy 往前走 n + 1 步，讓 slow 停在待刪節點的前一個位置。
     * 之後 fast/slow 同步前進，直到 fast 為 null。
     * 最後改接 slow.next，即可一次遍歷完成刪除。
     */
    public ListNode? RemoveNthFromEnd_OnePassTwoPointers(ListNode? head, int n) // __一次遍歷雙指針法
    {
        var dummy = new ListNode(0, head);
        var fast = dummy;
        var slow = dummy;

        for (var i = 0; i <= n; i++)
        {
            fast = fast.next!;
        }

        while (fast is not null)
        {
            fast = fast.next!;
            slow = slow.next!;
        }

        slow.next = slow.next?.next;
        return dummy.next;
    }

    /*
     * 第一趟先計算 linked list 長度。
     * 第二趟走到第 length - n 個位置，也就是待刪節點前一個節點。
     * 寫法容易理解，但需要兩次遍歷。
     */
    public ListNode? RemoveNthFromEnd_TwoPassLength(ListNode? head, int n) // __兩次遍歷長度法
    {
        var dummy = new ListNode(0, head);
        var length = 0;
        var current = head;

        while (current is not null)
        {
            length++;
            current = current.next;
        }

        current = dummy;

        for (var i = 0; i < length - n; i++)
        {
            current = current.next!;
        }

        current.next = current.next?.next;
        return dummy.next;
    }
}
