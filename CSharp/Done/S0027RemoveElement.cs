 namespace Csharp.Done
{
   public class S0027RemoveElement
   {
      public int RemoveElement(int[] nums, int val)
      {
         var left = 0;
         var right = nums.Length - 1;
         while (left <= right)
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

         return left;
      }
   }
}