//O(N)
public class Solution {
    public int MissingNumber(int[] nums) {
        int n = nums.Length;
        int expectedSum = n * (n + 1) / 2;
        
        int sum = 0;
        foreach (int num in nums) {
            sum += num;
        }
        
        return expectedSum - sum;
    }
}

// O(NLogN)
public class Solution
{
    public int MissingNumber(int[] nums)
    {
        Array.Sort(nums);
        for (int i = 0; i < nums.Count(); i++)
        {
            if (nums[i] != i)
                return i;
        }
        return nums.Count();
    }
}