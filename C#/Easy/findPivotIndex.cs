public class Solution {
    public int PivotIndex(int[] nums) {
        int sumL = 0;
        int sumR = nums.Sum();
         for(int i = 0; i < nums.Length; i++)
         {
            sumR -= nums[i];
            if(sumL == sumR)
                return i;
            sumL += nums[i];
         }
         return -1;
    }
}