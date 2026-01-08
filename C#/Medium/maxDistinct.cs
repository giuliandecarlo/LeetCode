public class Solution {
    public int MaxDistinct(string s) {

        HashSet<char> seen = new HashSet<char>();
        foreach (char c in s)
        {
            seen.Add(c);
        }
        return seen.Count;

    }
}