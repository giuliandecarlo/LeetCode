public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        List<bool> result = new List<bool>();
        int max = candies.Max();
        foreach(int current in candies)
        {
            result.Add(current + extraCandies >= max);
        }
        return result;
    }
}