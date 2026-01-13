package q0016

import (
	"fmt"
	"testing"
)

func TestThreeSumClosest(t *testing.T) {
	tests := []struct {
		nums   []int
		target int
		want   int
	}{
		{[]int{-1, 2, 1, -4}, 1, 2},
		{[]int{0, 0, 0}, 1, 0},
	}
	for _, tt := range tests {
		t.Run(fmt.Sprintf("nums=%v,target=%d", tt.nums, tt.target), func(t *testing.T) {
			got := threeSumClosest(tt.nums, tt.target)
			if got != tt.want {
				t.Errorf("threeSumClosest(%v, %d) = %d; want %d", tt.nums, tt.target, got, tt.want)
			}
		})
	}
}
