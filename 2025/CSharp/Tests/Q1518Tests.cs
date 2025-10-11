namespace Tests;

// 假設您的 Solution 類別在 Shared.Solutions 命名空間中
using Shared.Solutions;
using Xunit; // 引入 Xunit 相關的命名空間

public class Q1518Tests // 依照 LeetCode 題號命名測試類別
{
    [Theory]
    [InlineData(9, 3, 13)]
    [InlineData(15, 4, 19)]
    [InlineData(4, 2, 7)]
    [InlineData(5, 3, 7)]
    [InlineData(1, 5, 1)]
    [InlineData(100, 5, 124)]
    public void NumWaterBottlesTest(int numBottles, int numExchange, int expected)
    {
        var solution = new Solution();
        var actual = solution.NumWaterBottles(numBottles, numExchange);
        Assert.Equal(expected, actual);
    }
}