package climbingstairs

import "testing"

func TestClimbStairs(t *testing.T) {
	tests := []struct {
		name     string
		input    int
		expected int
	}{
		{"n=1", 1, 1},
		{"n=2", 2, 2},
		{"n=3", 3, 3},
		{"n=4", 4, 5},
		{"n=5", 5, 8},
	}

	for _, tt := range tests {
		t.Run(tt.name, func(t *testing.T) {
			result := climbStairs(tt.input)
			if result != tt.expected {
				t.Errorf("climbStairs(%d) = %d; want %d", tt.input, result, tt.expected)
			}
		})
	}
}
