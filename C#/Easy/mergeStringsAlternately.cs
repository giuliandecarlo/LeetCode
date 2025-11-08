public class Solution {
    public string MergeAlternately(string word1, string word2) {
        string res = "";
        int minLen = Math.Min(word1.Length, word2.Length);
        int maxLen = Math.Max(word1.Length, word2.Length);

        for (int i = 0; i < minLen; i++)
        {
            res += word1[i];
            res += word2[i];
        }

        if (word1.Length > word2.Length)
            res += word1.Substring(minLen);
        else
            res += word2.Substring(minLen);
        return res;
    }
}