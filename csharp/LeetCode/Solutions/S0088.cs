// 題目：將 nums2 合併進 nums1，使 nums1 成為一個非遞減排序陣列；nums1 已預留足夠空間容納 m + n 個元素。
namespace LeetCode.Solutions;
// TODO:
public class S0088
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        var i1 = m - 1;
        var i2 = n - 1;
        for (int curr = nums1.Length - 1; curr > -1; curr--) {
            if(i1 == -1)
            {
                nums1[curr] = nums2[i2];
                i2--;
                continue;
            }
            if(i2==-1)
            {
                nums1[curr] = nums1[i1];
                i1--;
                continue;
            }
            if (nums1[i1]> nums2[i2])
            {
                nums1[curr] = nums1[i1];
                i1--;
            }
            else
            {
                nums1[curr] = nums2[i2];
                i2--;
            }
        }
    }
}

