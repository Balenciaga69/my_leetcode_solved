package q0121

import "testing"

func TestMaxProfit(t *testing.T) {
	// Test case 1
	prices := []int{7, 1, 5, 3, 6, 4}
	expected := 5
	result := maxProfit(prices)
	if result != expected {
		t.Errorf("Test case 1 failed: expected %d, got %d", expected, result)
	}

	// Test case 2
	prices = []int{7, 6, 4, 3, 1}
	expected = 0
	result = maxProfit(prices)
	if result != expected {
		t.Errorf("Test case 2 failed: expected %d, got %d", expected, result)
	}

	// Test case 3
	prices = []int{1, 2}
	expected = 1
	result = maxProfit(prices)
	if result != expected {
		t.Errorf("Test case 3 failed: expected %d, got %d", expected, result)
	}

	// Test case 4
	prices = []int{1}
	expected = 0
	result = maxProfit(prices)
	if result != expected {
		t.Errorf("Test case 4 failed: expected %d, got %d", expected, result)
	}
}
