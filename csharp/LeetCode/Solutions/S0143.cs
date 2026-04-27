// TODO:
// 題目：給定單向鏈結串列 head，將串列重排為 L0、Ln、L1、Ln-1...；不可修改節點值。
using LeetCode.Utilities;

namespace LeetCode.Solutions;

public class S0143
{
    private static readonly Method ActiveMethod = Method.FindMiddleReverseMerge;

    private enum Method
    {
        FindMiddleReverseMerge,
        Stack
    }

    /*
     * 主方法只負責切換目前採用的解法。
     * 預設使用找中點、反轉後半段、交錯合併三步。
     * 只改節點指標不改值，時間 O(n)，額外空間 O(1)。
     */
    public void ReorderList(ListNode? head)
    {
        switch (ActiveMethod)
        {
            case Method.FindMiddleReverseMerge:
                ReorderList_FindMiddleReverseMerge(head);
                break;
            case Method.Stack:
                ReorderList_Stack(head);
                break;
            default:
                throw new InvalidOperationException("Unknown solution method.");
        }
    }

    /*
     * slow/fast 找到前半段尾端，將 list 切成兩半。
     * 反轉後半段後，依序把第一段與反轉後的第二段交錯串接。
     * 這是本題面試偏好的原地解法。
     */
    public void ReorderList_FindMiddleReverseMerge(ListNode? head) // __找中點反轉合併法
    {
        if (head?.next is null)
        {
            return;
        }

        var slow = head;
        var fast = head;

        while (fast.next?.next is not null)
        {
            slow = slow!.next;
            fast = fast.next.next;
        }

        var second = Reverse(slow!.next);
        slow.next = null;
        var first = head;

        while (second is not null)
        {
            var firstNext = first!.next;
            var secondNext = second.next;

            first.next = second;
            second.next = firstNext;

            first = firstNext;
            second = secondNext;
        }
    }

    /*
     * 先把所有節點推入 stack，之後從尾端逐個取出插入前半段。
     * 走 length / 2 次後把尾端 next 設為 null，避免形成 cycle。
     * 寫法直觀，但需要 O(n) 額外空間。
     */
    public void ReorderList_Stack(ListNode? head) // __Stack法
    {
        if (head?.next is null)
        {
            return;
        }

        var stack = new Stack<ListNode>();
        var current = head;
        var length = 0;

        while (current is not null)
        {
            stack.Push(current);
            current = current.next;
            length++;
        }

        current = head;

        for (var i = 0; i < length / 2; i++)
        {
            var tail = stack.Pop();
            var next = current!.next;
            current.next = tail;
            tail.next = next;
            current = next;
        }

        current!.next = null;
    }

    private static ListNode? Reverse(ListNode? head)
    {
        ListNode? previous = null;
        var current = head;

        while (current is not null)
        {
            var next = current.next;
            current.next = previous;
            previous = current;
            current = next;
        }

        return previous;
    }
}
