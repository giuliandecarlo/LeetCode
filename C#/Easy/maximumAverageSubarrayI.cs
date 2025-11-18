public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        double sum = 0;
        for(int y = 0; y < k; y++)
        {
            sum += nums[y];
        }
        double maxSum = sum;
        for (int i=1; i <= nums.Length - k; i++)
        {
            sum -= nums[i-1];
            sum += nums[i+k-1];
            maxSum = Math.Max(maxSum, sum);
        }
        return maxSum/k;
    }
}