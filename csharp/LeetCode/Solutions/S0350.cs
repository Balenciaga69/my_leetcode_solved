namespace LeetCode.Solutions;
public class S0350
{
    public int[] Intersect(int[] nums1, int[] nums2)
    {
        Array.Sort(nums1);
        Array.Sort(nums2);
        var i = 0;
        var j = 0;
        var result = new List<int>();
        while (i < nums1.Length && j < nums2.Length)
        {
            var n1 = nums1[i];
            var n2 = nums2[j];
            if (n1 == n2)
            {
                result.Add(n1);
                i++; j++;
            }
            else if (n1 < n2)
            {
                i++;
            }
            else
            {
                j++;
            }
        }
        return result.ToArray();
    }
}
