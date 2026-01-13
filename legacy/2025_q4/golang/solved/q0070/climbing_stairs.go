package q0070

/*
你正在爬樓梯。要到達頂部需要 n 階。
You are climbing a staircase. It takes n steps to reach the top.
每次你可以爬 1 階或 2 階。有多少種不同的方式可以爬到頂部？
Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?


*/

func aiSolution(n int) int {
	if n <= 2 {
		return n
	}
	return aiSolution(n-1) + aiSolution(n-2)
}

func mySolution(n int) int {
	if n <= 2 {
		return n
	}
	prev1, prev2 := 2, 1
	for i := 3; i <= n; i++ {
		current := prev1 + prev2
		prev2 = prev1
		prev1 = current
	}
	return prev1
}

func climbStairs(n int) int {
	return mySolution(n)
}
