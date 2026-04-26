// TODO:
// 題目：給定座位與學生的位置陣列，透過最少移動次數讓每位學生坐到一個座位上；每個座位與學生只能配對一次。
namespace LeetCode.Solutions;
public class S2037
{
    public int MinMovesToSeat(int[] seats, int[] students)
    {
        Array.Sort(seats);
        Array.Sort(students);
        var result = 0;
        for (var i = 0; i < seats.Length; i++)
        {
            result += Math.Abs(seats[i] - students[i]);
        }
        return result;
    }
}
