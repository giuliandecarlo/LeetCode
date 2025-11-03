public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs.Length == 0) return "";
       Array.Sort(strs, (x, y) => x.Length.CompareTo(y.Length));
        string prefix = "";
        for(int i = 0; i < strs[0].Count(); i++)
        {
            for(int j = 1; j < strs.Count(); j++)
            {
                if (strs[j][i] != strs[0][i])
                    return prefix;
            }
            prefix += strs[0][i];
        }
        return prefix;
    }
}