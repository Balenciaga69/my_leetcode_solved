namespace Csharp.Solutions.S0056;

public class Solution
{
    public Solution()
    {
        var intervals = new int[][]
         {
            new int[] { 1, 3 },
            new int[] { 2, 6 },
            new int[] { 8, 10 },
            new int[] { 15, 18 },
         };

        this.Merge(intervals);
    }

    public int[][] Merge(int[][] intervals)
    {
        var merged = new List<int[][]>();
    }
}

/*
 先排序；逐個比較區間
 */