using LeetCode.Solutions;

namespace LeetCode.Test
{
    public class S0015Tests
    {
        [Fact]
        public void ThreeSum_ReturnsExpectedTriplets_ForFirstExample()
        {
            var result = new S0015().ThreeSum([-1, 0, 1, 2, -1, -4]);

            AssertTripletsEqual([[-1, -1, 2], [-1, 0, 1]], result);
        }

        [Fact]
        public void ThreeSum_ReturnsEmpty_WhenNoTripletSumsToZero()
        {
            var result = new S0015().ThreeSum([0, 1, 1]);

            Assert.Empty(result);
        }

        [Fact]
        public void ThreeSum_ReturnsSingleZeroTriplet_WhenAllZeros()
        {
            var result = new S0015().ThreeSum([0, 0, 0]);

            AssertTripletsEqual([[0, 0, 0]], result);
        }

        [Fact]
        public void ThreeSum_AllMethodsReturnSameTriplets()
        {
            var solution = new S0015();
            int[] nums = [-2, 0, 1, 1, 2];

            AssertTripletsEqual([[-2, 0, 2], [-2, 1, 1]], solution.ThreeSum_SortTwoPointers([.. nums]));
            AssertTripletsEqual([[-2, 0, 2], [-2, 1, 1]], solution.ThreeSum_HashSetPerFixed([.. nums]));
        }

        private static void AssertTripletsEqual(int[][] expected, IList<IList<int>> actual)
        {
            var normalizedExpected = Normalize(expected.Select(triplet => triplet.ToList()));
            var normalizedActual = Normalize(actual);

            Assert.Equal(normalizedExpected, normalizedActual);
        }

        private static List<string> Normalize(IEnumerable<IList<int>> triplets)
        {
            return triplets
                .Select(triplet => triplet.Order().ToArray())
                .Select(triplet => string.Join(",", triplet))
                .Order()
                .ToList();
        }
    }
}
