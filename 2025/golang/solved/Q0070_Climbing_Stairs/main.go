package Q0070_Climbing_Stairs

/*
你正在爬樓梯。要到達頂部需要 n 階。
每次你可以爬 1 階或 2 階。有多少種不同的方式可以爬到頂部？



*/

import "fmt"

func mySolution(n int) int {
	if n <= 2 {
		return n
	}
	return mySolution(n-1) + mySolution(n-2)
}

func climbStairs(n int) int {
	return mySolution(n)
}

func Exec() {
	type testcase struct {
		N      int
		Expect int
	}

	var tests = []testcase{
		{N: 2, Expect: 2},
		{N: 3, Expect: 3},
		{N: 1, Expect: 1},
		{N: 4, Expect: 5},
		{N: 5, Expect: 8},
	}

	for idx, test := range tests {
		n := test.N
		result := climbStairs(n)
		fmt.Printf("Case %d: n = %d\n", idx, n)
		fmt.Printf("       expect = %d, result = %d\n", test.Expect, result)
		fmt.Println()
	}
}
