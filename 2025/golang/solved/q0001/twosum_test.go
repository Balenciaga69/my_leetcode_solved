package q0001

import (
	"reflect"
	"sort"
	"testing"
)

func TestTwoSum(t *testing.T) {
	tests := []struct {
		name     string
		nums     []int
		target   int
		expected []int
	}{
		{"example1", []int{2, 7, 11, 15}, 9, []int{0, 1}},
		{"example2", []int{3, 2, 4}, 6, []int{1, 2}},
		{"example3", []int{3, 3}, 6, []int{0, 1}},
	}

	for _, tt := range tests {
		t.Run(tt.name, func(t *testing.T) {
			result := twoSum(tt.nums, tt.target)
			sort.Ints(result)
			sort.Ints(tt.expected)
			if !reflect.DeepEqual(result, tt.expected) {
				t.Errorf("twoSum(%v, %d) = %v; want %v", tt.nums, tt.target, result, tt.expected)
			}
		})
	}
}
