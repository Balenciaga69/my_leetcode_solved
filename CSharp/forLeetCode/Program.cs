var nums = new int[] { 2, 7, 5, 11, 15 };
var target = 9;
var result = TwoSum(nums, target);

Console.WriteLine($"[{result[0]}, {result[1]}]");

static int[] TwoSum(int[] nums, int target)
{
    var result = new int[2];
    var dict = new Dictionary<int, int>();
    for (int i = 0; i < nums.Length; i++)
    {
        var complement = target - nums[i];
        if (dict.ContainsKey(complement))
        {
            result[0] = dict[complement];
            result[1] = i;
            return result;
        }
        dict[nums[i]] = i;
    }
    return result;
}
