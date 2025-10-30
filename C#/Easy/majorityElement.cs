// O(1)
public class Solution {
    public int MajorityElement(int[] nums) {
        Array.Sort(nums);
        return nums[nums.Length / 2];
    }
}

// O(NLogN)
public class Solution
{
    public int MajorityElement(int[] nums)
    {
        Array.Sort(nums);
        int current = -1;
        int counter = 0;
        int top = 0;
        int topCounter = 0;
        foreach (int n in nums)
        {
            if (current != n)
            {
                current = n;
                counter = 0;
            }
            counter += 1;
            if (topCounter < counter)
            {
                top = n;
                topCounter = counter;
            }
        }
        return top;
    }
}