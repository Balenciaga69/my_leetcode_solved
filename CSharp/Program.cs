var solution = new Solution();
int[] nums = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };
int val = 2;
int result = solution.RemoveElement(nums, val);

public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        var result = 0;
        var left = 0;
        var right = nums.Length - 1;
        while (left < right)
        {
            if (nums[left] == val)
            {
                nums[left] = nums[right];
                right--;
            }
            else
            {
                left++;
            }
        }
        return right + 1;
    }
}