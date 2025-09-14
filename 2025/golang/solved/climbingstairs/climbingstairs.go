package climbingstairs

/*
你正在爬樓梯。要到達頂部需要 n 階。
每次你可以爬 1 階或 2 階。有多少種不同的方式可以爬到頂部？
*/

func mySolution(n int) int {
	if n <= 2 {
		return n
	}
	return mySolution(n-1) + mySolution(n-2)
}

func climbStairs(n int) int {
	return mySolution(n)
}
