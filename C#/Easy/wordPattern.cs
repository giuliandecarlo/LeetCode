public class Solution {
    public bool WordPattern(string pattern, string s) {
        var words = s.Split();
        Dictionary<char, string> patternMap = new Dictionary<char, string>();
        if(words.Length != pattern.Length)
            return false;
        for(int i=0; i < pattern.Length;i++)
        {
            if(patternMap.ContainsKey(pattern[i]))
                {
                if(words[i] != patternMap[pattern[i]])
                    return false;
                }else{
                    if(patternMap.ContainsValue(words[i]))
                        return false;
                    patternMap[pattern[i]] = words[i];
                    }
        }
        return true;
    }
}