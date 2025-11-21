public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        var counts = new Dictionary<int, int>();

        foreach(int el in arr)
        {
            if (!counts.ContainsKey(el))
                counts[el] = 0;

            counts[el]++;
        }
        HashSet<int> storage = new HashSet<int>();
        foreach (var count in counts.Values)
            if (!storage.Add(count))
                return false;
        return true;
    }
}