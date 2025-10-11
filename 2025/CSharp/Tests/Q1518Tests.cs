namespace Tests;

// ���]�z�� Solution ���O�b Shared.Solutions �R�W�Ŷ���
using Shared.Solutions;
using Xunit; // �ޤJ Xunit �������R�W�Ŷ�

public class Q1518Tests // �̷� LeetCode �D���R�W�������O
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