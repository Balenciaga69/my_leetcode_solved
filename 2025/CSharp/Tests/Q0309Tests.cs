﻿using Shared.Solutions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests;

public class Q0309Tests
{
    public static IEnumerable<object[]> GetMaxProfitTestData()
    {
        yield return new object[] { new int[] { 1, 2, 3, 0, 2 }, 3 };
        yield return new object[] { new int[] { 1 }, 0 };
        yield return new object[] { new int[] { 5, 4, 3, 2, 1 }, 0 };
        yield return new object[] { new int[] { 6, 1, 3, 2, 4, 7 }, 6 };
    }

    [Theory]
    [MemberData(nameof(GetMaxProfitTestData))]
    public void MaxProfit_ShouldReturnExpectedResult(int[] prices, int expected)
    {
        var actual = new Solution().MaxProfit(prices);
        Assert.Equal(expected, actual);
    }
}
