from typing import Optional
from dataStructure.ListNode import ListNode


class Solution:
    def hasCycle(self, head: Optional[ListNode]) -> bool:
        fast = head
        slow = head
        canSlowMove = False
        while True:
            if fast is None or slow is None:
                return False
            fast = fast.next
            if canSlowMove:
                if fast is None:
                    return False
                fast = fast.next
                slow = slow.next
                if slow == fast and fast is not None:
                    return True
            canSlowMove = not canSlowMove

nod1 = ListNode(val=3)
nod2 = ListNode(val=2)
nod3 = ListNode(val=0)
nod4 = ListNode(val=-4)
nod1.next = nod2
nod2.next = nod3
nod3.next = nod4
nod4.next = nod2
Solution().hasCycle(nod1)
