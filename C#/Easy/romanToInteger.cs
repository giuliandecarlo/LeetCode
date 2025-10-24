public class Solution {
    public int RomanToInt(string s) {
        Dictionary<string, int> symbolMap = new Dictionary<string, int>{
        { "I", 1 },
        { "V", 5 },
        { "X", 10 },
        { "L", 50 },
        { "C", 100 },
        { "D", 500 },
        { "M", 1000 }
        };
        int tot = 0;
        for(int i = 0; i < s.Count(); i++)
        {
            if (i < s.Count() -1  && symbolMap[s[i].ToString()] < symbolMap[s[i+1].ToString()])
                    tot -= symbolMap[s[i].ToString()];
            else
            tot += symbolMap[s[i].ToString()];
        }
        return tot;
    }
}