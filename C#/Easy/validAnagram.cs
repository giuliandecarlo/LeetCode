public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
            return false;

        for (int i = 0; i < t.Length; i++)
        {
            int index = s.IndexOf(t[i]);
            if (index == -1)
                return false;

            s = s.Remove(index, 1);
        }
        return s.Length == 0;
    }
}