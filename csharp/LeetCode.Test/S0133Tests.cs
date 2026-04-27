using LeetCode.Solutions;
using LeetCode.Utilities;

namespace LeetCode.Test
{
    public class S0133Tests
    {
        public static IEnumerable<object[]> CloneGraphCases()
        {
            yield return [new[] { new[] { 2, 4 }, new[] { 1, 3 }, new[] { 2, 4 }, new[] { 1, 3 } }];
            yield return [new[] { Array.Empty<int>() }];
            yield return [Array.Empty<int[]>()];
        }

        [Theory]
        [MemberData(nameof(CloneGraphCases))]
        public void CloneGraph_ReturnsDeepCopyWithSameAdjacencyList(int[][] adjacencyList)
        {
            var original = GraphBuilder.FromAdjacencyList(adjacencyList);
            var clone = new S0133().CloneGraph(original);

            Assert.Equal(adjacencyList, GraphBuilder.ToAdjacencyList(clone));

            if (original is not null)
            {
                Assert.NotSame(original, clone);
                Assert.False(GraphBuilder.HasSharedReference(original, clone));
            }
            else
            {
                Assert.Null(clone);
            }
        }

        [Fact]
        public void CloneGraph_AllMethodsReturnSameGraph()
        {
            int[][] adjacencyList = [[2, 3], [1, 3], [1, 2]];
            var original = GraphBuilder.FromAdjacencyList(adjacencyList);
            var solution = new S0133();

            var dfsClone = solution.CloneGraph_DfsHashMap(original);
            var bfsClone = solution.CloneGraph_BfsHashMap(original);

            Assert.Equal(adjacencyList, GraphBuilder.ToAdjacencyList(dfsClone));
            Assert.Equal(adjacencyList, GraphBuilder.ToAdjacencyList(bfsClone));
            Assert.False(GraphBuilder.HasSharedReference(original, dfsClone));
            Assert.False(GraphBuilder.HasSharedReference(original, bfsClone));
        }
    }
}
