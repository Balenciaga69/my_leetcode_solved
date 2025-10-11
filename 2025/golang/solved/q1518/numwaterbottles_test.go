package q1518

import "testing"

type testCase struct {
	numBottles  int
	numExchange int
	expected    int
}

// 測試函數
func TestNumWaterBottles(t *testing.T) {
	cases := []testCase{
		{numBottles: 9, numExchange: 3, expected: 13},

		{numBottles: 15, numExchange: 4, expected: 19},

		{numBottles: 4, numExchange: 2, expected: 7},

		{numBottles: 5, numExchange: 3, expected: 7},

		{numBottles: 1, numExchange: 5, expected: 1},

		{numBottles: 100, numExchange: 5, expected: 124},
	}

	for _, c := range cases {
		actual := numWaterBottles(c.numBottles, c.numExchange)

		if actual != c.expected {
			t.Errorf("輸入 (Bottles: %d, Exchange: %d)；預期結果: %d；實際結果: %d",
				c.numBottles, c.numExchange, c.expected, actual)
		}
	}
}
