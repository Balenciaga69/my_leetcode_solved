package q0021

/*
- You are given the heads of two sorted linked lists list1 and list2.
- Merge the two lists into one sorted list. The list should be made by splicing together the nodes of the first two lists.
- Return the head of the merged linked list.

Input: list1 = [1,2,4], list2 = [1,3,4]
Output: [1,1,2,3,4,4]
Example 2:

Input: list1 = [], list2 = []
Output: []
Example 3:

Input: list1 = [], list2 = [0]
Output: [0]

topics: Linked List, Recursion

繁體中文:
- 您將獲得兩個已排序鏈表 list1 和 list2 的頭部。
- 將這兩個列表合併為一個排序列表。該列表應通過拼接前兩個列表的節點來製作。
- 返回合併後鏈表的頭部。
*/

type ListNode struct {
	Val  int
	Next *ListNode
}

func mergeTwoLists(list1 *ListNode, list2 *ListNode) *ListNode {
	base := &ListNode{}
	curr := base
	for list1 != nil && list2 != nil {
		// 取較小的節點前進
		if list1.Val < list2.Val {
			curr.Next = list1
			list1 = list1.Next
		} else {
			curr.Next = list2
			list2 = list2.Next
		}
		// 移動到下一個節點
		curr = curr.Next
	}
	// 鏈接剩餘鏈表
	if list1 != nil {
		curr.Next = list1
	} else {
		curr.Next = list2
	}
	return base.Next
}
