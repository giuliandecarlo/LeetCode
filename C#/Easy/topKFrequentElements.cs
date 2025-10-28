public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> freqMap = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            if (freqMap.ContainsKey(num))
                freqMap[num]++;
            else
                freqMap[num] = 1;
        }

        var topK = freqMap
            .OrderByDescending(kvp => kvp.Value)
            .Take(k)
            .Select(kvp => kvp.Key)
            .ToArray();

        return topK;
    }
}