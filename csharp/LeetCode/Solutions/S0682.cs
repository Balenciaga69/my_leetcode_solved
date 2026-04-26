namespace LeetCode.Solutions;
public class S0682
{
    public int CalPoints(string[] operations)
    {
        var stack = new Stack<int>();
        foreach (var op in operations)
        {
            switch (op)
            {
                case "+":
                    var top1 = stack.Pop();
                    var top2 = stack.Pop();
                    var sum = top1 + top2;
                    stack.Push(top2);
                    stack.Push(top1);
                    stack.Push(sum);
                    break;
                case "C":
                    stack.Pop();
                    break;
                case "D":
                    var val = stack.Peek();
                    stack.Push(val * 2);
                    break;
                default:
                    int.TryParse(op, out var num);
                    stack.Push(num);
                    break;
            }
        }
        return stack.Sum();
    }
}
