from typing import List, Optional


class ListNode:
    # LeetCode 常用的單向鏈結節點定義。
    def __init__(self, x: int):
        self.val: int = x
        self.next: Optional["ListNode"] = None


def build_list(values):
    # 依照 values 建立一般的單向鏈結串列，不包含 cycle。
    head = ListNode(values[0])
    cur = head
    for val in values[1:]:
        cur.next = ListNode(val)
        cur = cur.next
    return head


def build_cycle_list(values: List[int], pos: int) -> ListNode:
    # 建立帶 cycle 的鏈結串列：
    # pos 表示尾節點要連回的索引，-1 代表不建立 cycle。
    head = ListNode(values[0])
    curr = head
    cycle_node = None

    if pos == 0:
        cycle_node = head

    for i in range(1, len(values)):
        curr.next = ListNode(values[i])
        curr = curr.next

        if i == pos:
            cycle_node = curr

    if pos != -1:
        curr.next = cycle_node
    return head
