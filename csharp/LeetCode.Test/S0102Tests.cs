using LeetCode.Solutions;
using LeetCode.Utilities;

namespace LeetCode.Test
{
    public class S0102Tests
    {
        [Fact]
        public void LevelOrder_ReturnsExpectedLevels_ForFirstExample()
        {
            var root = TreeBuilder.FromLevelOrder([3, 9, 20, null, null, 15, 7]);

            var result = new S0102().LevelOrder(root);

            AssertLevelsEqual([[3], [9, 20], [15, 7]], result);
        }

        [Fact]
        public void LevelOrder_ReturnsSingleLevel_ForSingleNode()
        {
            var root = TreeBuilder.FromLevelOrder([1]);

            var result = new S0102().LevelOrder(root);

            AssertLevelsEqual([[1]], result);
        }

        [Fact]
        public void LevelOrder_ReturnsEmpty_ForEmptyTree()
        {
            var result = new S0102().LevelOrder(null);

            Assert.Empty(result);
        }

        [Fact]
        public void LevelOrder_AllMethodsReturnSameLevels()
        {
            var root = TreeBuilder.FromLevelOrder([1, 2, 3, 4, null, null, 5]);
            var solution = new S0102();

            AssertLevelsEqual([[1], [2, 3], [4, 5]], solution.LevelOrder_BfsQueue(root));
            AssertLevelsEqual([[1], [2, 3], [4, 5]], solution.LevelOrder_DfsByDepth(root));
        }

        private static void AssertLevelsEqual(int[][] expected, IList<IList<int>> actual)
        {
            Assert.Equal(expected.Select(level => level.ToArray()).ToArray(), actual.Select(level => level.ToArray()).ToArray());
        }
    }
}
