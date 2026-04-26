// 題目：判斷整數陣列 arr 是否為有效山脈陣列，也就是先嚴格遞增到某個峰值，再嚴格遞減，且峰值不能在兩端。
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
