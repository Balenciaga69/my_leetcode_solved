package q0021

import "testing"

// isEqual compares two linked lists for equality.
func isEqual(l1, l2 *ListNode) bool {
	for l1 != nil && l2 != nil {
		if l1.Val != l2.Val {
			return false
		}
		l1 = l1.Next
		l2 = l2.Next
	}
	return l1 == nil && l2 == nil
}

func TestMergeTwoSortedLists(t *testing.T) {
	// Test case 1
	list1 := &ListNode{Val: 1, Next: &ListNode{Val: 2, Next: &ListNode{Val: 4}}}
	list2 := &ListNode{Val: 1, Next: &ListNode{Val: 3, Next: &ListNode{Val: 4}}}
	expected := &ListNode{Val: 1, Next: &ListNode{Val: 1, Next: &ListNode{Val: 2, Next: &ListNode{Val: 3, Next: &ListNode{Val: 4, Next: &ListNode{Val: 4}}}}}}
	result := mergeTwoLists(list1, list2)
	if !isEqual(result, expected) {
		t.Errorf("Test case 1 failed: expected %v, got %v", expected, result)
	}

	// Test case 2
	list1 = nil
	list2 = nil
	expected = nil
	result = mergeTwoLists(list1, list2)
	if !isEqual(result, expected) {
		t.Errorf("Test case 2 failed: expected %v, got %v", expected, result)
	}

	// Test case 3
	list1 = nil
	list2 = &ListNode{Val: 0}
	expected = &ListNode{Val: 0}
	result = mergeTwoLists(list1, list2)
	if !isEqual(result, expected) {
		t.Errorf("Test case 3 failed: expected %v, got %v", expected, result)
	}
}
