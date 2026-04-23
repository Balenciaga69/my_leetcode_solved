namespace LeetCode.Solutions;

public class S0941
{
    public bool ValidMountainArray(int[] arr)
    {
        if (arr.Length < 3) return false;
        int i = 0;
        while (i < arr.Length - 1 && arr[i] < arr[i + 1])
        {
            i++;
        }
        if (i == arr.Length - 1) return false; // 一路上生到底
        if (i == 0) return false; // 開頭就是高峰
        while (i < arr.Length - 1 && arr[i] > arr[i + 1])
        {
            i++;
        }
        if (i != arr.Length - 1) return false;
        return true;
    }
}
