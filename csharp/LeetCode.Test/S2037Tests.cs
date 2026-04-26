using LeetCode.Solutions;

namespace LeetCode.Test
{
    public class S2037Tests
    {
        [Fact]
        public void MinMovesToSeat_ReturnsExpectedMoves_ForFirstExample()
        {
            var result = new S2037().MinMovesToSeat([3, 1, 5], [2, 7, 4]);

            Assert.Equal(4, result);
        }

        [Fact]
        public void MinMovesToSeat_ReturnsExpectedMoves_ForSecondExample()
        {
            var result = new S2037().MinMovesToSeat([4, 1, 5, 9], [1, 3, 2, 6]);

            Assert.Equal(7, result);
        }

        [Fact]
        public void MinMovesToSeat_ReturnsExpectedMoves_WhenPositionsRepeat()
        {
            var result = new S2037().MinMovesToSeat([2, 2, 6, 6], [1, 3, 2, 6]);

            Assert.Equal(4, result);
        }
    }
}
